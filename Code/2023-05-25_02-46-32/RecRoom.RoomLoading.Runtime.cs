using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Google.Protobuf;
using Google.Protobuf.Collections;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
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
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3491110", Offset = "0x348F910", VA = "0x183491110")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C8540", Offset = "0x8C6D40", VA = "0x1808C8540")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD79980", Offset = "0xD78180", VA = "0x180D79980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LCAFMEKLLGH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HCKACEFMPCF> APNHNBKPOIP;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NECCIEOBFKO(long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ, NFBLDIHAPOJ GJGJDNGPKAK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JLPGPOOMIFG(long HAMIEGOKEJC, long BPODGJMCBKI, out HCKACEFMPCF ANGBHDDNJKO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DGKKMEKKLFM(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, out HCKACEFMPCF ANGBHDDNJKO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NIGPPAMDDAN(long HAMIEGOKEJC, long BPODGJMCBKI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[UnityEngine.Scripting.Preserve]
internal class IHCOPFNDBOG : LEHKMPCAGKL, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JLJHFIHPDNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public NKHBPCPCMLJ roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JLJHFIHPDNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x42B4730", Offset = "0x42B2F30", VA = "0x1842B4730")]
		internal object KCDDEDEMLNP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BOHNLHMBPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2DAA2E0", Offset = "0x2DA8AE0", VA = "0x182DAA2E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAC10", Offset = "0x2DA9410", VA = "0x182DAAC10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KGMACCFPPHI FEPFLACKKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2DAA240", Offset = "0x2DA8A40", VA = "0x182DAA240", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2DAA5F0", Offset = "0x2DA8DF0", VA = "0x182DAA5F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event KGMACCFPPHI GOIAEEEILBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAB70", Offset = "0x2DA9370", VA = "0x182DAAB70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2DAA1A0", Offset = "0x2DA89A0", VA = "0x182DAA1A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event KGMACCFPPHI LJENEBHMOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAD50", Offset = "0x2DA9550", VA = "0x182DAAD50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2DAACB0", Offset = "0x2DA94B0", VA = "0x182DAACB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NBGKOOKNBGP, bool> KFAMNOAKCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2DAA840", Offset = "0x2DA9040", VA = "0x182DAA840", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2DAA690", Offset = "0x2DA8E90", VA = "0x182DAA690", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "19")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2DAA380", Offset = "0x2DA8B80", VA = "0x182DAA380", Slot = "14")]
	public void DCAJNDNNNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2DAA810", Offset = "0x2DA9010", VA = "0x182DAA810", Slot = "15")]
	public void IHKAKCADEFN(NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2DAA730", Offset = "0x2DA8F30", VA = "0x182DAA730", Slot = "16")]
	public void GGHKLMBDLFL(NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2DAAB40", Offset = "0x2DA9340", VA = "0x182DAAB40", Slot = "17")]
	public void NECNIDCBHOL(NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2DAA760", Offset = "0x2DA8F60", VA = "0x182DAA760", Slot = "18")]
	public void HGDIGCPPJBC(NBGKOOKNBGP KAINKNJPFIL, bool GGKLFMPBGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2DAA8E0", Offset = "0x2DA90E0", VA = "0x182DAA8E0")]
	private void MKOHINBGHOB(KGMACCFPPHI NMPOOPDGJFD, NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public IHCOPFNDBOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface MHPAJLBPAGC : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GOMGBFEPMOD PFLGINGMBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGGMFLBIDCM();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ALFOAEHHOAI();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate IDIFMABCDLA COJGMJCEFDM(IGGCDPKBFGF AEEBHLKEAKN, DLLMEMMHNCB GOKELOIKDPH);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface MFLEOODBFAO : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIHFEMBJCAM KEABJGIDHIP(FHMBHNPINBI BOBCMCAMEBH);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBDNCJBLALE(Guid PALLEDHBFCO, Task OIDBJIACCJK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal struct GDNNMLKFEHK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string AADCMMNJLNA = "v_result";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const string AJFPDJKLBFG = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IDictionary<object, object> CBLNAPKAJBM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JDGGFLPNGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xC0EB30", Offset = "0xC0D330", VA = "0x180C0EB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xB91230", Offset = "0xB8FA30", VA = "0x180B91230")]
	public GDNNMLKFEHK(IDictionary<object, object> CBLNAPKAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2DA04C0", Offset = "0x2D9ECC0", VA = "0x182DA04C0")]
	public bool EHMCOLBLMFF(out FHMBHNPINBI DKIECHCHJFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0670", Offset = "0x2D9EE70", VA = "0x182DA0670")]
	public Guid LDBDBOFBKGH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2DA03B0", Offset = "0x2D9EBB0", VA = "0x182DA03B0")]
	public IDIFMABCDLA DLABMAIJNIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0580", Offset = "0x2D9ED80", VA = "0x182DA0580")]
	public static ExitGames.Client.Photon.Hashtable JLAKJAPJOGA(FHMBHNPINBI DKIECHCHJFL, IDIFMABCDLA NPAEKAKKGDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CJBKIJKLHJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IAAGAGMBLDF(KBIEMNNHIEA.KCEEEPMPGFI JNHEDBAKBGC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNLMDMHCHJC(KBIEMNNHIEA.KCEEEPMPGFI JNHEDBAKBGC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KLLAKEMPMAC
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class KBIEMNNHIEA : CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate IDIFMABCDLA KCEEEPMPGFI([NotNull] IGGCDPKBFGF OHCIFECEBBG);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IFFEFMAKIKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public IGGCDPKBFGF photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IFFEFMAKIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x42B2670", Offset = "0x42B0E70", VA = "0x1842B2670")]
		internal IDIFMABCDLA MGJPDCLGMDP(KCEEEPMPGFI v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly HashSet<KCEEEPMPGFI> OKOLPKIOIMJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEC50", Offset = "0x2DAD450", VA = "0x182DAEC50", Slot = "4")]
	public void IAAGAGMBLDF(KCEEEPMPGFI JNHEDBAKBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2DAECB0", Offset = "0x2DAD4B0", VA = "0x182DAECB0", Slot = "5")]
	public void KNLMDMHCHJC(KCEEEPMPGFI JNHEDBAKBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE9E0", Offset = "0x2DAD1E0", VA = "0x182DAE9E0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEA30", Offset = "0x2DAD230", VA = "0x182DAEA30")]
	protected IDIFMABCDLA HMEFICDIDBP(IGGCDPKBFGF AOLFPABEEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2D999D0", Offset = "0x2D981D0", VA = "0x182D999D0")]
	protected KBIEMNNHIEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JBODEACJCFG
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class GHOCBABIKGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BNNPCINDEGK subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GHOCBABIKGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x42B0ED0", Offset = "0x42AF6D0", VA = "0x1842B0ED0")]
		internal bool GDIHPPBMEEH(MPOOILGCDLJ s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2DABE60", Offset = "0x2DAA660", VA = "0x182DABE60")]
	public static LCMHJBMHMJN JLAKJAPJOGA(long HBCPJJJHDAN, long KIBMHJEFMKG, string APOLELLKJLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2DABF00", Offset = "0x2DAA700", VA = "0x182DABF00")]
	public static LCMHJBMHMJN JLAKJAPJOGA(long HBCPJJJHDAN, long KIBMHJEFMKG, EFENBEKLEHO IKHHHDILDNK, long PJBAEAJLHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2DABAE0", Offset = "0x2DAA2E0", VA = "0x182DABAE0")]
	public static LCMHJBMHMJN JLAKJAPJOGA(LPCDCAILFOA GLAABCHHFKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2DABC20", Offset = "0x2DAA420", VA = "0x182DABC20")]
	public static LCMHJBMHMJN JLAKJAPJOGA(IEMLKNOFDEG FFKPMIAJOHJ, BNNPCINDEGK HKLLDLGPABG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB9D0", Offset = "0x2DAA1D0", VA = "0x182DAB9D0")]
	public static LCMHJBMHMJN GGHJIOOPGLA(this LCMHJBMHMJN MEKBNGFFPML, IEMLKNOFDEG APOIMGJBMKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB840", Offset = "0x2DAA040", VA = "0x182DAB840")]
	public static LCMHJBMHMJN EPOEALFJPJP(this LCMHJBMHMJN MEKBNGFFPML, BNNPCINDEGK MOOJINHAHPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum GHLDFOEBGAC
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum NBGKOOKNBGP
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NKHBPCPCMLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly long HBCPJJJHDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly long KIBMHJEFMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly GHLDFOEBGAC FIJCKHKKDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[CanBeNull]
	public readonly Exception BLBJGIOFENG;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x34910F0", Offset = "0x348F8F0", VA = "0x1834910F0")]
	public NKHBPCPCMLJ(long HBCPJJJHDAN, long KIBMHJEFMKG, GHLDFOEBGAC FIJCKHKKDCC, [CanBeNull] Exception BLBJGIOFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x34910A0", Offset = "0x348F8A0", VA = "0x1834910A0")]
	public static NKHBPCPCMLJ JNBBBKKOJHD(MHKEFJDKLJN KADFJBDLABD, GHLDFOEBGAC FIJCKHKKDCC, [Optional] Exception BLBJGIOFENG)
	{
		return default(NKHBPCPCMLJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public delegate void KGMACCFPPHI(NKHBPCPCMLJ LDHNIIPGDGD);
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface LEHKMPCAGKL : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action BOHNLHMBPOI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KGMACCFPPHI FEPFLACKKPC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KGMACCFPPHI GOIAEEEILBP;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KGMACCFPPHI LJENEBHMOMN;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<NBGKOOKNBGP, bool> KFAMNOAKCJD;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DCAJNDNNNCA();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IHKAKCADEFN(NKHBPCPCMLJ LDHNIIPGDGD);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GGHKLMBDLFL(NKHBPCPCMLJ LDHNIIPGDGD);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NECNIDCBHOL(NKHBPCPCMLJ LDHNIIPGDGD);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HGDIGCPPJBC(NBGKOOKNBGP KAINKNJPFIL, bool GGKLFMPBGIO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[UnityEngine.Scripting.Preserve]
internal class IBFLGIGODFN : NNIOHMBOJFJ, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DDCDIGKHNIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IBFLGIGODFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private global::JAPPGKMKBNF<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private AALOEEPNEOP <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private HALPBDECPOJ <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DDCDIGKHNIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x42ACFF0", Offset = "0x42AB7F0", VA = "0x1842ACFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private BEIIGIJBNMM EAABFFOLONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private EPOJINPDBDE KELDMIFJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KHCNMJFIKHK MNLFCPGNLLN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9B60", Offset = "0x2DA8360", VA = "0x182DA9B60", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9900", Offset = "0x2DA8100", VA = "0x182DA9900", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2DA97B0", Offset = "0x2DA7FB0", VA = "0x182DA97B0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDCDIGKHNIP))]
	public Task DBEOFEALEMN(string FMALCPACLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9950", Offset = "0x2DA8150", VA = "0x182DA9950", Slot = "4")]
	public IDIFMABCDLA IGGGLNHPCKG(IGGCDPKBFGF AEEBHLKEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9A10", Offset = "0x2DA8210", VA = "0x182DA9A10")]
	private HALPBDECPOJ NFBENPIHNDC(string FMALCPACLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public IBFLGIGODFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface NCFBJHOACDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KADKOGACMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FLGKFOOFBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Task IIGHKFMPNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OAEILIIIPED OJJPFGNKGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action BOHNLHMBPOI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event KGMACCFPPHI FEPFLACKKPC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event KGMACCFPPHI GOIAEEEILBP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event KGMACCFPPHI LJENEBHMOMN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<NBGKOOKNBGP, bool> KFAMNOAKCJD;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DEAHNGCCEOM();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DHFMLFOJIHC IFEAAGJHLFK();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AMGCDJKPHHE CKEIFGMIKGA();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<IDIFMABCDLA> MFMFNNPHECC(HCKACEFMPCF IPKBJACGFCO);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task HNCAHLLFAMO(CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface NABGKEIJMLK : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IDIFMABCDLA> MFMFNNPHECC(HCKACEFMPCF ANGBHDDNJKO);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HNCAHLLFAMO(CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[RecRoom.NoEngine.Common.Preserve]
internal class FGJHIEFNNDA : LKGOGFHLDFK, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class PBBILOGKEDA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class GGEOEAPOGFE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public PBBILOGKEDA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private long <currentTime>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public GGEOEAPOGFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x59799D0", Offset = "0x59781D0", VA = "0x1859799D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool GHKACLCDPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly int DHAJPGNAMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly long JOLFLBLCNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly CancellationTokenSource BDONFEGNADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Stopwatch NGBOPHHNHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly List<(long addedAtTicks, float frameTime)> HHLJIEPAJLE;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x49755F0", Offset = "0x4973DF0", VA = "0x1849755F0")]
		public LJGOPKDOKIE KKGBFAEMGOJ()
		{
			return default(LJGOPKDOKIE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4975880", Offset = "0x4974080", VA = "0x184975880")]
		public PBBILOGKEDA(TimeSpan HFMONGJPHGM, int DHAJPGNAMFJ = int.MaxValue, [Optional] CancellationToken KHEICKPBIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x49754A0", Offset = "0x4973CA0", VA = "0x1849754A0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(GGEOEAPOGFE))]
		private Task EBDHDHCPNAJ(CancellationToken GFFFFCALMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4975430", Offset = "0x4973C30", VA = "0x184975430", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x49757B0", Offset = "0x4973FB0", VA = "0x1849757B0")]
		private void LJAIMEDLAKA(long MLJIAJKDCFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IKLDFDIBKPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public OAEILIIIPED customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Task <task>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IKLDFDIBKPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x496F200", Offset = "0x496DA00", VA = "0x18496F200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CFEFEBAGGBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public OAEILIIIPED customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private PBBILOGKEDA <frameTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private global::JAPPGKMKBNF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private AALOEEPNEOP <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private FFLEKJBGAJJ <joinRoomInstancePauseToken>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private LHNHBKFIDPL <analyticsData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private LJGOPKDOKIE <frameTimeStats>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private OperationCanceledException <oce>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CFEFEBAGGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4966690", Offset = "0x4964E90", VA = "0x184966690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OOCDNBNGECG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Matchmaking.AHFAIMKOKJA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public MCJHCEJFKNC errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OOCDNBNGECG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4975380", Offset = "0x4973B80", VA = "0x184975380")]
		internal object OHKMOIGJCOE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class MLBNNAJNBLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Task<LCMHJBMHMJN> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MLBNNAJNBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		internal Task<LCMHJBMHMJN> AKPBEMHJNJB(AALOEEPNEOP _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class AICIFAHFEPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public OAEILIIIPED customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public FFLEKJBGAJJ joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private EIBOJBKNGCC <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private AALOEEPNEOP <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private MLBNNAJNBLK <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private JJMPNGLGHEG <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Task<Matchmaking.MDKPNMHIPCM> <serverConnectionInfoTask>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IAEAGHMOCOM <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private Matchmaking.MDKPNMHIPCM <serverConnectionInfo>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private AALOEEPNEOP <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private CancellationTokenSource <loadingScreenCts>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private AALOEEPNEOP <loadingScreenScope>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Matchmaking.MDKPNMHIPCM <>s__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private CancellationTokenSource <photonJoinedTokenSource>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private CancellationToken <photonJoinedToken>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private LCMHJBMHMJN <initialRoomLoadPayload>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Task <roomLoadTask>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private LCMHJBMHMJN <>s__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private AALOEEPNEOP <>s__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter<Matchmaking.MDKPNMHIPCM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<LCMHJBMHMJN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AICIFAHFEPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4962D90", Offset = "0x4961590", VA = "0x184962D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class OFFHFGMOAHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AALOEEPNEOP <disconnectTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private object <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Exception <ex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private AALOEEPNEOP <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OFFHFGMOAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x49747C0", Offset = "0x4972FC0", VA = "0x1849747C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class NLKCGHDOFNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private MHOBEFMLEFD <roomContainer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NLKCGHDOFNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4973E90", Offset = "0x4972690", VA = "0x184973E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FJECICJHCCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder<Matchmaking.MDKPNMHIPCM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private AALOEEPNEOP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private Matchmaking.MDKPNMHIPCM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<Matchmaking.MDKPNMHIPCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FJECICJHCCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x496ADE0", Offset = "0x49695E0", VA = "0x18496ADE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KJPDOGHJNDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Matchmaking.MDKPNMHIPCM serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public FFLEKJBGAJJ joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private AALOEEPNEOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private ALKMAGMAGJP <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<ALKMAGMAGJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KJPDOGHJNDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4971A40", Offset = "0x4970240", VA = "0x184971A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class EAGGOHAHLHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public EAGGOHAHLHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class FHLKDIHBFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public EAGGOHAHLHO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FHLKDIHBFHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x496ABD0", Offset = "0x49693D0", VA = "0x18496ABD0")]
		internal object DPJFJFDJNML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x496ACD0", Offset = "0x49694D0", VA = "0x18496ACD0")]
		internal string FKNBAHPGOBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ECCJHJAENAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private EAGGOHAHLHO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private FHLKDIHBFHD <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ECCJHJAENAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4969230", Offset = "0x4967A30", VA = "0x184969230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class MJGNCFPGMKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public LCMHJBMHMJN initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public EIBOJBKNGCC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public MHKEFJDKLJN targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public FFLEKJBGAJJ joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private AALOEEPNEOP <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private FFLEKJBGAJJ <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private GNPGFJFMNHD <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MJGNCFPGMKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4973620", Offset = "0x4971E20", VA = "0x184973620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PGELJMKKLFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private AALOEEPNEOP <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private AALOEEPNEOP <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private AALOEEPNEOP <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public PGELJMKKLFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4976020", Offset = "0x4974820", VA = "0x184976020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HOMPGAIKKJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <version>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private bool <canUpdateRoom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private bool <shouldSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6E")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter<IDIFMABCDLA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HOMPGAIKKJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x496DD80", Offset = "0x496C580", VA = "0x18496DD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class ECDHAOKOLCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ECDHAOKOLCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4969E30", Offset = "0x4968630", VA = "0x184969E30")]
		internal object EKJPFBHMGOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class BJJKBBMKDGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BJJKBBMKDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4965BF0", Offset = "0x49643F0", VA = "0x184965BF0")]
		internal void EPOENJKLLOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class KFPPHNLEOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KFPPHNLEOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4971990", Offset = "0x4970190", VA = "0x184971990")]
		internal object CBMOLFNGPDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class OCCLHIHDHIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OCCLHIHDHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x49746C0", Offset = "0x4972EC0", VA = "0x1849746C0")]
		internal string IFLGJCNNEHJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly string KEJKFDACPEP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly string FENDOLHJKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly string FCHPMLDJFDG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly Guid LCHEMBEANGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private KFDAFKKLOKJ BBMCDOFLCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private GHOMLKKKKHM IIJBBPIGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private LFPKDNNPHDE MOCPAILNIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private HLDCIPKGMNF CPNGNGPKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private LEHKMPCAGKL EOHAACKOPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PILPGHODDIG DCLPNPGHFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private JHNNJFGCKHO OPAKEBPNBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private IDisposable IGMACGPPKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly PKHKKGNCOIB KJAJPGJGEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PKHKKGNCOIB CDBPFIOMIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private IAEAGHMOCOM FEPDAJCNOGC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TaskStatus HEHIDPGEMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA89C70", Offset = "0xA88470", VA = "0x180A89C70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA89E50", Offset = "0xA88650", VA = "0x180A89E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2D9DC80", Offset = "0x2D9C480", VA = "0x182D9DC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2D9EAD0", Offset = "0x2D9D2D0", VA = "0x182D9EAD0", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C230", Offset = "0x2D9AA30", VA = "0x182D9C230", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E240", Offset = "0x2D9CA40", VA = "0x182D9E240", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKLDFDIBKPF))]
	public Task MHKIGANIEGO(MHKEFJDKLJN FKMIOMCKJNF, OAEILIIIPED LBJHHPLDPCI, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B080", Offset = "0x2D99880", VA = "0x182D9B080")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CFEFEBAGGBN))]
	private Task CGIPLDAAFAH(MHKEFJDKLJN FKMIOMCKJNF, OAEILIIIPED LBJHHPLDPCI, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2D9DCD0", Offset = "0x2D9C4D0", VA = "0x182D9DCD0")]
	private static void KPBAOOGCADH(PILPGHODDIG DCLPNPGHFLG, MHKEFJDKLJN FKMIOMCKJNF, Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B7C0", Offset = "0x2D99FC0", VA = "0x182D9B7C0")]
	private static void DIEMECHABJC(LHNHBKFIDPL AMMNKIJKPDJ, Exception BPFOEEABMGN, [Optional] List<int> JACAFHEHNAG, int ABAHDMMJMOJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C280", Offset = "0x2D9AA80", VA = "0x182D9C280")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AICIFAHFEPG))]
	private Task EDNHHFMPDPN(AALOEEPNEOP IDIJCJCNEPO, MHKEFJDKLJN FKMIOMCKJNF, OAEILIIIPED LBJHHPLDPCI, FFLEKJBGAJJ AKKJBLMHLIA, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D150", Offset = "0x2D9B950", VA = "0x182D9D150")]
	private void HMOBBLALHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D850", Offset = "0x2D9C050", VA = "0x182D9D850")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OFFHFGMOAHL))]
	private Task JCNGLBIDPLK(AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C790", Offset = "0x2D9AF90", VA = "0x182D9C790")]
	private void GHADILLMHAE(MHKEFJDKLJN FKMIOMCKJNF, CancellationToken KHEICKPBIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E3E0", Offset = "0x2D9CBE0", VA = "0x182D9E3E0")]
	private void MKONBMMDEPH(MHKEFJDKLJN FKMIOMCKJNF, FFLEKJBGAJJ AKKJBLMHLIA, OperationCanceledException ADBKJDGABDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E6A0", Offset = "0x2D9CEA0", VA = "0x182D9E6A0")]
	private void NOGAPIEKDIK(MHKEFJDKLJN FKMIOMCKJNF, FFLEKJBGAJJ AKKJBLMHLIA, Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CEB0", Offset = "0x2D9B6B0", VA = "0x182D9CEB0")]
	private void HEBPEAEIBII(MHKEFJDKLJN FKMIOMCKJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C460", Offset = "0x2D9AC60", VA = "0x182D9C460")]
	private static NKHBPCPCMLJ FKJINFCCHJK(MHKEFJDKLJN FKMIOMCKJNF)
	{
		return default(NKHBPCPCMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E120", Offset = "0x2D9C920", VA = "0x182D9E120")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NLKCGHDOFNE))]
	private Task LDHEDJCKKNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B590", Offset = "0x2D99D90", VA = "0x182D9B590")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FJECICJHCCB))]
	private Task<Matchmaking.MDKPNMHIPCM> DFLBCCECPHL(MHKEFJDKLJN FKMIOMCKJNF, AALOEEPNEOP IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C4A0", Offset = "0x2D9ACA0", VA = "0x182D9C4A0")]
	private static ALKMAGMAGJP GCINHMJMIBO(MHKEFJDKLJN FKMIOMCKJNF, Matchmaking.MDKPNMHIPCM DBNNJNHMJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D2A0", Offset = "0x2D9BAA0", VA = "0x182D9D2A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KJPDOGHJNDI))]
	private Task HONKCHJMJNF(MHKEFJDKLJN FKMIOMCKJNF, Matchmaking.MDKPNMHIPCM DBNNJNHMJEO, FFLEKJBGAJJ AKKJBLMHLIA, AALOEEPNEOP IDIJCJCNEPO, CancellationToken FFDAINFFMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C5F0", Offset = "0x2D9ADF0", VA = "0x182D9C5F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ECCJHJAENAG))]
	private Task GENDOCHGIOJ(MHKEFJDKLJN FKMIOMCKJNF, CancellationTokenSource DNBLDELONJP, Task ACMLNKHHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B220", Offset = "0x2D99A20", VA = "0x182D9B220")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MJGNCFPGMKJ))]
	private Task CHALEMKNDHH(LCMHJBMHMJN CMKABAANNAK, EIBOJBKNGCC OOKFEKMLPEH, MHKEFJDKLJN NPDJMDFNEOF, FFLEKJBGAJJ ACHLGGINKLE, AALOEEPNEOP IDIJCJCNEPO, CancellationToken FJDDBFFNBFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CC60", Offset = "0x2D9B460", VA = "0x182D9CC60")]
	private FFLEKJBGAJJ HDHABNEMDJJ(FFLEKJBGAJJ ACHLGGINKLE, ref CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B420", Offset = "0x2D99C20", VA = "0x182D9B420")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PGELJMKKLFM))]
	private Task CHKBFLMHBLG(AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CAF0", Offset = "0x2D9B2F0", VA = "0x182D9CAF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HOMPGAIKKJI))]
	private Task GHEDFKBBANB(MOMCOKAPMLC PHBHEFAPHDL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E960", Offset = "0x2D9D160", VA = "0x182D9E960")]
	private static void ONPCOIPELPC(MHKEFJDKLJN FKMIOMCKJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D9DAB0", Offset = "0x2D9C2B0", VA = "0x182D9DAB0")]
	private void JMHGEGDHJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B730", Offset = "0x2D99F30", VA = "0x182D9B730")]
	private void DFMLOGALDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D480", Offset = "0x2D9BC80", VA = "0x182D9D480")]
	private void HONNJFFJNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D510", Offset = "0x2D9BD10", VA = "0x182D9D510")]
	private void IAEKDAJDLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2D9AEF0", Offset = "0x2D996F0", VA = "0x182D9AEF0")]
	private static void CDKDGAGHKDN(MHKEFJDKLJN FKMIOMCKJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D9AE30", Offset = "0x2D99630", VA = "0x182D9AE30")]
	private static void BNHJKHBFKON(MHKEFJDKLJN FKMIOMCKJNF, CancellationToken FFDAINFFMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2D9EF00", Offset = "0x2D9D700", VA = "0x182D9EF00")]
	private static void PPIELFOOPOD(MHKEFJDKLJN FKMIOMCKJNF, Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D610", Offset = "0x2D9BE10", VA = "0x182D9D610")]
	private void IOFDGLJIDCH(MHKEFJDKLJN FKMIOMCKJNF, Task ACMLNKHHEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D9C0", Offset = "0x2D9C1C0", VA = "0x182D9D9C0")]
	private static void JGIMFEIAGIB(Func<string> BAMBEECFNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F190", Offset = "0x2D9D990", VA = "0x182D9F190")]
	public FGJHIEFNNDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D5A0", Offset = "0x2D9BDA0", VA = "0x182D9D5A0")]
	[CompilerGenerated]
	internal static (int, int?) IKOFKBLKLGH(MCJHCEJFKNC EGMEOIADPFI)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MHMLFGJNJKA
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> EGAAIFMLOKP(string OPOLKMBAJBK, long BFNOJMGJLFG, MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class LNLKNBEENCP : global::CDLOOCIEHKO<FHMBHNPINBI>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class PDOIMKEBDKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public FHMBHNPINBI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public PDOIMKEBDKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x597D910", Offset = "0x597C110", VA = "0x18597D910")]
		internal object GFMPDMHHECN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static readonly LNLKNBEENCP EABDDJEADPB;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private const string GLOKGMEJOAH = "pl";

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x348BB30", Offset = "0x348A330", VA = "0x18348BB30")]
	public ExitGames.Client.Photon.Hashtable ECCPKOGLKLF(FHMBHNPINBI DKIECHCHJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x348B9F0", Offset = "0x348A1F0", VA = "0x18348B9F0", Slot = "5")]
	protected override void AENAENLCIAI(FHMBHNPINBI DKIECHCHJFL, IDictionary<object, object> PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x348BD40", Offset = "0x348A540", VA = "0x18348BD40", Slot = "6")]
	public override FHMBHNPINBI NLJPEOGMFGO(IDictionary<object, object> PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x348BBB0", Offset = "0x348A3B0", VA = "0x18348BBB0")]
	private static void JGIMFEIAGIB(string NOLEELEJNKJ, FHMBHNPINBI DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x348BFC0", Offset = "0x348A7C0", VA = "0x18348BFC0")]
	public LNLKNBEENCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x348B6F0", Offset = "0x3489EF0", VA = "0x18348B6F0")]
	[CompilerGenerated]
	internal static string ACLKACENCGK(LCMHJBMHMJN MEKBNGFFPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface FNOEIOAGCPK<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::PKJAENHCLMN<byte[], CMPFHAIKIAN>> BJBOOMBCAED(TGetDataArg AIMHDAMIMIL, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::PKJAENHCLMN<global::HCLLLJEDILH<TData>, CMPFHAIKIAN> KCDPDOMNJNH(byte[] PHBHEFAPHDL);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface DPADKKHLKLF : CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDIFMABCDLA KDJGBCGJOCG(IGGCDPKBFGF AOLFPABEEKC);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class FENLOLGCABO : JHDNGKJANJJ, CCNJKCGJAJP, GNOLCLOPLMD, CAJCLGONHEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly CCNJKCGJAJP OMBHPIGDLKI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IGGCDPKBFGF AGOBILJIDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2D99740", Offset = "0x2D97F40", VA = "0x182D99740", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NFFGMOGMHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2D997F0", Offset = "0x2D97FF0", VA = "0x182D997F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KEPCAECPIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2D993C0", Offset = "0x2D97BC0", VA = "0x182D993C0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool LHAPCIJBDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int CIFGLBNPOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F2890", Offset = "0x7F1090", VA = "0x1807F2890", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event CPDEDBIILFH.OFBOMJAMPKF HAHFPDLJMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event FJKGHOIPBKO HGAIJHBEINL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D996A0", Offset = "0x2D97EA0", VA = "0x182D996A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2D99410", Offset = "0x2D97C10", VA = "0x182D99410", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> IOFGIAHKHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<IGGCDPKBFGF> AEKDKGLIMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action OKONGAFFGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2D99220", Offset = "0x2D97A20", VA = "0x182D99220", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2D994B0", Offset = "0x2D97CB0", VA = "0x182D994B0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xF3BA30", Offset = "0xF3A230", VA = "0x180F3BA30")]
	public FENLOLGCABO(CCNJKCGJAJP OMBHPIGDLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2D995F0", Offset = "0x2D97DF0", VA = "0x182D995F0", Slot = "8")]
	public bool OAMKKLLHMCJ(byte PJPMIHPOMIA, ExitGames.Client.Photon.Hashtable LPNMAPPAKIO, EBKGAFDELBK NAOEDGLNDNC, SendOptions PPCDNDPNNDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2D99550", Offset = "0x2D97D50", VA = "0x182D99550", Slot = "29")]
	public IGGCDPKBFGF LOOGDOFAGGL(int KEAMKJPMALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2D992C0", Offset = "0x2D97AC0", VA = "0x182D992C0", Slot = "16")]
	public IGGCDPKBFGF DNGDHJDCGCA(int AGMAMFDBLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "19")]
	public void ILNAGFHCFLP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "20")]
	public void BBNPAOAMKNC(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "21")]
	public void GBOFAFGNPKK(object FLDJLPKNKKO, bool ALPKOFENEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2D99790", Offset = "0x2D97F90", VA = "0x182D99790", Slot = "22")]
	public IDisposable PAOHMNBKIOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "23")]
	private bool CGEGBBJAMFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "24")]
	public void LNOIMNGJBMF(StringBuilder OJPAJPKNCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2D993A0", Offset = "0x2D97BA0", VA = "0x182D993A0", Slot = "25")]
	public bool FKEFOKOCIDM(bool INOACBMBDNM, out string FKPBDLDGFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public void AHKBAGIPMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x18FB8D0", Offset = "0x18FA0D0", VA = "0x1818FB8D0", Slot = "28")]
	public void CCOFHBPEINO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct KJLLMJJEGBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly TaskCompletionSource<(IDIFMABCDLA, Task)> JAGALAEBKOD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Task<(IDIFMABCDLA, Task)> KCIAOCJILBB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x34885F0", Offset = "0x3486DF0", VA = "0x1834885F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x34887A0", Offset = "0x3486FA0", VA = "0x1834887A0")]
	public KJLLMJJEGBB(TimeSpan OJHABJHLHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3488500", Offset = "0x3486D00", VA = "0x183488500")]
	public void CIPLADFKIMB(Task OIDBJIACCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3488630", Offset = "0x3486E30", VA = "0x183488630")]
	public void EHBECJGDFJG(IDIFMABCDLA NPAEKAKKGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3488750", Offset = "0x3486F50", VA = "0x183488750")]
	public void MHDHMJHADME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x34886C0", Offset = "0x3486EC0", VA = "0x1834886C0")]
	internal void FEEBNMABKGC(string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class MCGNJCCHDHF : MHPAJLBPAGC, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private bool OJPMHILIPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private GOMGBFEPMOD ALNIEHFFCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private AIMHFJMEAKL CEHJOFICIAM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GOMGBFEPMOD PFLGINGMBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x348CE30", Offset = "0x348B630", VA = "0x18348CE30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x348CEA0", Offset = "0x348B6A0", VA = "0x18348CEA0", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x348CBF0", Offset = "0x348B3F0", VA = "0x18348CBF0", Slot = "5")]
	public void DGGMFLBIDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x348CBB0", Offset = "0x348B3B0", VA = "0x18348CBB0", Slot = "6")]
	public void ALFOAEHHOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x348CDB0", Offset = "0x348B5B0", VA = "0x18348CDB0")]
	private Task JGBBPKBNPBD(MLLLMININAO HDCPFIKNJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x348CBB0", Offset = "0x348B3B0", VA = "0x18348CBB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x10C9550", Offset = "0x10C7D50", VA = "0x1810C9550")]
	public MCGNJCCHDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal struct FBJPNKAEOIC
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NJKBNBHFCPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public IFNNJAAOEDN manager;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NJKBNBHFCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4973E50", Offset = "0x4972650", VA = "0x184973E50")]
		internal Task GGBNEKFPFPM(MOMCOKAPMLC data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class BDJKMKOJHND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public FBJPNKAEOIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private HCKACEFMPCF <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private JLOOFCOEEHE <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private JLOOFCOEEHE <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private JLOOFCOEEHE <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter<JLOOFCOEEHE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private TaskAwaiter<IDIFMABCDLA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BDJKMKOJHND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4965640", Offset = "0x4963E40", VA = "0x184965640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class OLLCODFLLBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public FBJPNKAEOIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OLLCODFLLBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4975120", Offset = "0x4973920", VA = "0x184975120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly CancellationToken GFFFFCALMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly IFNNJAAOEDN GAICNONPFPG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private EPJFONLPCOB HOCOJIBIFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2D98DD0", Offset = "0x2D975D0", VA = "0x182D98DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2D991D0", Offset = "0x2D979D0", VA = "0x182D991D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2D98F40", Offset = "0x2D97740", VA = "0x182D98F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private NABGKEIJMLK ILDDDNKPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2D989D0", Offset = "0x2D971D0", VA = "0x182D989D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x167BF80", Offset = "0x167A780", VA = "0x18167BF80")]
	public FBJPNKAEOIC(CancellationToken GFFFFCALMCA, IFNNJAAOEDN GAICNONPFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2D98D20", Offset = "0x2D97520", VA = "0x182D98D20")]
	public static NDLLDLNNGKD GBOIJDALJEA(IFNNJAAOEDN GAICNONPFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2D98BD0", Offset = "0x2D973D0", VA = "0x182D98BD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BDJKMKOJHND))]
	public Task<bool> EBDHDHCPNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2D98FC0", Offset = "0x2D977C0", VA = "0x182D98FC0")]
	private bool LDNEGFOJHDC(out HCKACEFMPCF ANGBHDDNJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2D98E20", Offset = "0x2D97620", VA = "0x182D98E20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OLLCODFLLBB))]
	private Task KIKPDFAMBCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2D98A20", Offset = "0x2D97220", VA = "0x182D98A20")]
	private Task<JLOOFCOEEHE> CBJNCOAONJC(HCKACEFMPCF ANKEKAMEAAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class IIEHMOMCDEB : AIMHFJMEAKL
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class FFKLCHMOGNH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly LALKFIOPJMN HNFNHEGHMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private readonly string BDFCACLHAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private readonly T IGBKLJLDCLC;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public T MHGNIJCIFFL
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8116F0", Offset = "0x80FEF0", VA = "0x1808116F0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8B1630", Offset = "0x8AFE30", VA = "0x1808B1630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x35EA520", Offset = "0x35E8D20", VA = "0x1835EA520")]
		public FFKLCHMOGNH(LALKFIOPJMN HNFNHEGHMIL, string BDFCACLHAFA, T IGBKLJLDCLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x35EA1B0", Offset = "0x35E89B0", VA = "0x1835EA1B0")]
		private void ODJBEAKLNPD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly LALKFIOPJMN HNFNHEGHMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly FFKLCHMOGNH<TimeSpan> AKNBKBCEEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly FFKLCHMOGNH<TimeSpan> PPGIMDGJPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly FFKLCHMOGNH<TimeSpan> CHOEAEJFIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly FFKLCHMOGNH<TimeSpan> DCIICEAAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly FFKLCHMOGNH<TimeSpan> KKEHLFMKFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly FFKLCHMOGNH<TimeSpan> DHHDLNGGBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly FFKLCHMOGNH<bool> ONGAONCHJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly FFKLCHMOGNH<bool> DFIOOFAGDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly FFKLCHMOGNH<bool> OJACFMKGPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly FFKLCHMOGNH<TimeSpan> NDPNPIBCDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly FFKLCHMOGNH<int> PHPHPKEKIED;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan LHJNNILLFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAEF0", Offset = "0x2DA96F0", VA = "0x182DAAEF0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan EPCMOJLJLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAE70", Offset = "0x2DA9670", VA = "0x182DAAE70", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public TimeSpan DAOBFAELEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAFF0", Offset = "0x2DA97F0", VA = "0x182DAAFF0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public TimeSpan DPGCFHMEEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAF30", Offset = "0x2DA9730", VA = "0x182DAAF30", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public TimeSpan PJBMKHDPPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB030", Offset = "0x2DA9830", VA = "0x182DAB030", Slot = "11")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan PLNLHBFIMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAFB0", Offset = "0x2DA97B0", VA = "0x182DAAFB0", Slot = "12")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan CIKCDCEOKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAE30", Offset = "0x2DA9630", VA = "0x182DAAE30", Slot = "13")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int KOCDOHPCCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2DAADF0", Offset = "0x2DA95F0", VA = "0x182DAADF0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool OFDCHEPEDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAEB0", Offset = "0x2DA96B0", VA = "0x182DAAEB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool HKOPKHIHGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB070", Offset = "0x2DA9870", VA = "0x182DAB070", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JFNNLIFPDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAF70", Offset = "0x2DA9770", VA = "0x182DAAF70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB0B0", Offset = "0x2DA98B0", VA = "0x182DAB0B0")]
	[UnityEngine.Scripting.Preserve]
	public IIEHMOMCDEB([ACEKLAKDMBL(null)] LALKFIOPJMN HNFNHEGHMIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal struct EMOAKECFAIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class MKOIIBEAJME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public EMOAKECFAIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MKOIIBEAJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4973C80", Offset = "0x4972480", VA = "0x184973C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly CancellationTokenSource MFGBDLCLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private Task GAKDIIFBLNI;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool JDGGFLPNGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2D973E0", Offset = "0x2D95BE0", VA = "0x182D973E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal Task KCIAOCJILBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2D971B0", Offset = "0x2D959B0", VA = "0x182D971B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2D97410", Offset = "0x2D95C10", VA = "0x182D97410")]
	public EMOAKECFAIC(CancellationToken GFFFFCALMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2D97230", Offset = "0x2D95A30", VA = "0x182D97230")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MKOIIBEAJME))]
	public Task DNJBHLPIBHG(Func<CancellationToken, List<Task>> GMABPDCFFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2D97390", Offset = "0x2D95B90", VA = "0x182D97390", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal interface MFHIJBENPCO : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIHFEMBJCAM CAILCKFFJIK(Guid PALLEDHBFCO);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CPPHPNNFPKL(Guid PALLEDHBFCO);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LPGMNPDMPPM(Guid PALLEDHBFCO, Task OIDBJIACCJK);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JJNOGDGBEML(Guid PALLEDHBFCO, IDIFMABCDLA GCGJMEIHMMI);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IHLPPHPEFDP(Guid PALLEDHBFCO);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(IDIFMABCDLA, Task)> PDGJMOLMFLF(Guid PALLEDHBFCO);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal interface EPOJINPDBDE : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDIFMABCDLA NMBCIPOHMGE(IGGCDPKBFGF AEEBHLKEAKN, DLLMEMMHNCB GOKELOIKDPH);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDIFMABCDLA GOENMAPECNC(IGGCDPKBFGF AOLFPABEEKC);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDIFMABCDLA OIGJDPDICNH(IGGCDPKBFGF AOLFPABEEKC);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class JCBCMHDOCKC : HMAILMDEICE
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class JPJGKAFGNII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public JCBCMHDOCKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private MHKEFJDKLJN <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private MHKEFJDKLJN <newPresenceRoomInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private float <timeoutTime>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JPJGKAFGNII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x42B4830", Offset = "0x42B3030", VA = "0x1842B4830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private const float DEKHCELCOFE = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2DAC220", Offset = "0x2DAAA20", VA = "0x182DAC220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8AC4E0", Offset = "0x8AACE0", VA = "0x1808AC4E0")]
	public JCBCMHDOCKC(IFNNJAAOEDN FNIFBLHBOOE, HBPPPIGEKFO FGOMHOJPKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC0B0", Offset = "0x2DAA8B0", VA = "0x182DAC0B0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JPJGKAFGNII))]
	public Task<bool> BFAINGMPNNG(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2DABFD0", Offset = "0x2DAA7D0", VA = "0x182DABFD0")]
	[CompilerGenerated]
	private object AFGHHJNLKAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal interface BNEJDHEIHAG : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEBINCHJHOA(FHMBHNPINBI DKIECHCHJFL);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADAEPOMFIHE(FHMBHNPINBI DKIECHCHJFL);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<DLLMEMMHNCB> ADEHAOCABJJ(CancellationToken BOPCGMCIPKA);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal interface NNIOHMBOJFJ : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDIFMABCDLA IGGGLNHPCKG(IGGCDPKBFGF AEEBHLKEAKN);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DBEOFEALEMN(string FMALCPACLGP);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[UnityEngine.Scripting.Preserve]
internal class KNOCBGHMKHM : HLDCIPKGMNF, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class GFJNNKLOBOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public KNOCBGHMKHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GFJNNKLOBOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x42B0520", Offset = "0x42AED20", VA = "0x1842B0520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly PKHKKGNCOIB GEEPKHIECCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private string ACCFGKLOJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Task NOAJBFJBLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool JHKJEJHMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3488B30", Offset = "0x3487330", VA = "0x183488B30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Task NLFPKAMNLJK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3488910", Offset = "0x3487110", VA = "0x183488910", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x80EE60", Offset = "0x80D660", VA = "0x18080EE60", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3488970", Offset = "0x3487170", VA = "0x183488970", Slot = "6")]
	public void IHJNMAOMFMN(Task GAKDIIFBLNI, string NNLMNOOEFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3488B60", Offset = "0x3487360", VA = "0x183488B60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFJNNKLOBOH))]
	private Task NIKHFNEOBOB(Task PAIGDLJPPOE, string NNLMNOOEFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3488CD0", Offset = "0x34874D0", VA = "0x183488CD0")]
	public KNOCBGHMKHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct LIHFEMBJCAM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly MFHIJBENPCO GAOOEGMBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Guid PALLEDHBFCO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Task<(IDIFMABCDLA, Task)> KCIAOCJILBB
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x348B300", Offset = "0x3489B00", VA = "0x18348B300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x231BAE0", Offset = "0x231A2E0", VA = "0x18231BAE0")]
	public LIHFEMBJCAM(MFHIJBENPCO GAOOEGMBKDI, Guid PALLEDHBFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x348B2B0", Offset = "0x3489AB0", VA = "0x18348B2B0")]
	public TaskAwaiter<(IDIFMABCDLA, Task)> CIAALDMCOFJ()
	{
		return default(TaskAwaiter<(IDIFMABCDLA, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x348B3D0", Offset = "0x3489BD0", VA = "0x18348B3D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[UnityEngine.Scripting.Preserve]
internal sealed class PCFPIMKAMML : NABGKEIJMLK, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class HDOOGEFGAKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public HCKACEFMPCF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private global::JAPPGKMKBNF<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private AALOEEPNEOP <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private ALJGLPODJGB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private AALOEEPNEOP <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private LCMHJBMHMJN <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private IDIFMABCDLA <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter<IDIFMABCDLA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HDOOGEFGAKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5979F00", Offset = "0x5978700", VA = "0x185979F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class EPJKAFEBOKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private CancellationTokenSource <combinedTokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public EPJKAFEBOKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x59783F0", Offset = "0x5976BF0", VA = "0x1859783F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class KKFLPLBDBOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public MOMCOKAPMLC _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KKFLPLBDBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x597C130", Offset = "0x597A930", VA = "0x18597C130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class JLGLICOEPGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private object <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JLGLICOEPGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x597B5C0", Offset = "0x5979DC0", VA = "0x18597B5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class CICIJAPOENM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CICIJAPOENM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x59775F0", Offset = "0x5975DF0", VA = "0x1859775F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class GCBGNPMKGGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private CancellationToken <nextAutosaveToken>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GCBGNPMKGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5979260", Offset = "0x5977A60", VA = "0x185979260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class ICJDJKIENIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private Task <delayTask>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private Task<int> <intervalChangedTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private Task <resultTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ICJDJKIENIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x597A5F0", Offset = "0x5978DF0", VA = "0x18597A5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class FICOEMBJGAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private global::JAPPGKMKBNF<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private AALOEEPNEOP <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private FFLEKJBGAJJ <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private MKKIMDKIEJP <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FICOEMBJGAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x5978AC0", Offset = "0x59772C0", VA = "0x185978AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private KHCNMJFIKHK MNLFCPGNLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private HLDCIPKGMNF CPNGNGPKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private OCAOCNCNOCD OFFFKIOLLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private CancellationTokenSource BDLOFKHMIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Task EDJMJBBPCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private TaskCompletionSource<int> OKINEKEIMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int DKIEPMHFCAG;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3499480", Offset = "0x3497C80", VA = "0x183499480", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1918BE0", Offset = "0x19173E0", VA = "0x181918BE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3499640", Offset = "0x3497E40", VA = "0x183499640")]
	private void PKHJGPDGHIO(float BOKAAPCLKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3499310", Offset = "0x3497B10", VA = "0x183499310", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDOOGEFGAKK))]
	public Task<IDIFMABCDLA> MFMFNNPHECC(HCKACEFMPCF ANGBHDDNJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x34990B0", Offset = "0x34978B0", VA = "0x1834990B0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EPJKAFEBOKG))]
	public Task HNCAHLLFAMO([Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1918BE0", Offset = "0x19173E0", VA = "0x181918BE0")]
	public void DGNGNPHOEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3498990", Offset = "0x3497190", VA = "0x183498990")]
	private ALJGLPODJGB CLANGIJCAOF(HCKACEFMPCF ANGBHDDNJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3498CA0", Offset = "0x34974A0", VA = "0x183498CA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KKFLPLBDBOP))]
	private Task EMEAJHNFMGH(MOMCOKAPMLC HDCPFIKNJDE, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3498F60", Offset = "0x3497760", VA = "0x183498F60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JLGLICOEPGP))]
	private Task HBFDLFFGEBD(CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3499720", Offset = "0x3497F20", VA = "0x183499720")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CICIJAPOENM))]
	private Task PMDEJGJJLLE([Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3498E10", Offset = "0x3497610", VA = "0x183498E10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GCBGNPMKGGH))]
	private Task FLHICCLHICH(CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3498B50", Offset = "0x3497350", VA = "0x183498B50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ICJDJKIENIC))]
	private Task EGIKIACONDF(CancellationToken DEEKJILKBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3498580", Offset = "0x3496D80", VA = "0x183498580")]
	private Task BPMPGNBFDLE(NFBLDIHAPOJ GJGJDNGPKAK, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3498830", Offset = "0x3497030", VA = "0x183498830")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FICOEMBJGAE))]
	private Task CBIGMEGDJGJ(NFBLDIHAPOJ GJGJDNGPKAK, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3499200", Offset = "0x3497A00", VA = "0x183499200")]
	private bool IGGGLNHPCKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PCFPIMKAMML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface BEIIGIJBNMM : CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDIFMABCDLA IGGGLNHPCKG(IGGCDPKBFGF ACJGGEOLANN);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[UnityEngine.Scripting.Preserve]
internal class JNJGFBGKBIM : ANJBBNMCECI, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private class KFJIDCBJEFK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private readonly MHKEFJDKLJN PDOICCGDHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private readonly CancellationTokenSource MFGBDLCLLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public readonly CancellationToken PIIFHPDGBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private bool HPPBEFJNGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private bool GHKACLCDPMJ;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x42B50D0", Offset = "0x42B38D0", VA = "0x1842B50D0")]
		public KFJIDCBJEFK(MHKEFJDKLJN PDOICCGDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x42B4F80", Offset = "0x42B3780", VA = "0x1842B4F80")]
		public void IHLPPHPEFDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x42B4F50", Offset = "0x42B3750", VA = "0x1842B4F50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class FIDMHFNFGNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public MLLLMININAO disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FIDMHFNFGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x42AECC0", Offset = "0x42AD4C0", VA = "0x1842AECC0")]
		internal object CGLBIIFILCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class DMOFBHCHBLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public MLLLMININAO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public JNJGFBGKBIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private FIDMHFNFGNA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DMOFBHCHBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x42ADF30", Offset = "0x42AC730", VA = "0x1842ADF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class FDMKICDEDAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FDMKICDEDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x42AEC50", Offset = "0x42AD450", VA = "0x1842AEC50")]
		internal object JDKMPOEGBKN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class DCMGLEHEFDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public JNJGFBGKBIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private FDMKICDEDAC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private IDisposable <logFlagsScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private IDisposable <logTraceScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private IDisposable <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private MHKEFJDKLJN <newRoomInstance>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private OAEILIIIPED <customRoomLoadPayload>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DCMGLEHEFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x42AC350", Offset = "0x42AAB50", VA = "0x1842AC350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class BDNIIEFOFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public MHKEFJDKLJN newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BDNIIEFOFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x42AB070", Offset = "0x42A9870", VA = "0x1842AB070")]
		internal object BMAGCEHEPGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x42AB030", Offset = "0x42A9830", VA = "0x1842AB030")]
		internal object AFNKKANDJLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x42AB110", Offset = "0x42A9910", VA = "0x1842AB110")]
		internal object GCGMMCCDOPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class CDBIIFDDICB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CDBIIFDDICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x42AB440", Offset = "0x42A9C40", VA = "0x1842AB440")]
		internal void FOBCGGDKIGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class MPNGNLJHLLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public MHKEFJDKLJN newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public OAEILIIIPED customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public JNJGFBGKBIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private BDNIIEFOFDF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private CDBIIFDDICB <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private CancellationToken <token>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private OperationCanceledException <oce>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MPNGNLJHLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x42B8E50", Offset = "0x42B7650", VA = "0x1842B8E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private GHOMLKKKKHM IIJBBPIGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private LFPKDNNPHDE MOCPAILNIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private AIMHFJMEAKL CEHJOFICIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private LKGOGFHLDFK HBHHBLLKCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private long HLICAKNNGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private KFJIDCBJEFK JICPGBHCLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private bool CJKOLCPINHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private Task OEAHMGOHKCA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE4E0", Offset = "0x2DACCE0", VA = "0x182DAE4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool IPGOLLBDNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x12770B0", Offset = "0x12758B0", VA = "0x1812770B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2DADF20", Offset = "0x2DAC720", VA = "0x182DADF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE570", Offset = "0x2DACD70", VA = "0x182DAE570", Slot = "4")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD880", Offset = "0x2DAC080", VA = "0x182DAD880", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE820", Offset = "0x2DAD020", VA = "0x182DAE820")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DMOFBHCHBLK))]
	private Task PBGICECDOOI(MLLLMININAO PNDKKGJBMGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE2C0", Offset = "0x2DACAC0", VA = "0x182DAE2C0")]
	private void KAGCKBPPEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2DADB90", Offset = "0x2DAC390", VA = "0x182DADB90")]
	private void ECKGLJKBMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD4F0", Offset = "0x2DABCF0", VA = "0x182DAD4F0")]
	private void BNPEMOOLAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2DADEA0", Offset = "0x2DAC6A0", VA = "0x182DADEA0")]
	private bool GIDDGKKCPGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2DADDB0", Offset = "0x2DAC5B0", VA = "0x182DADDB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DCMGLEHEFDK))]
	private void EOGPFIDDBOJ(int FNPPFCMGJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2DADF30", Offset = "0x2DAC730", VA = "0x182DADF30")]
	private void IHHBAHINIHN(out IDisposable AHOOBICBHLF, out IDisposable MAPJNBGOHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2DADA00", Offset = "0x2DAC200", VA = "0x182DADA00")]
	private bool ECCGBFBELIE(MHKEFJDKLJN PDOICCGDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE530", Offset = "0x2DACD30", VA = "0x182DAE530")]
	private void MNCMHDBGGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD710", Offset = "0x2DABF10", VA = "0x182DAD710")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MPNGNLJHLLA))]
	private Task CGIPLDAAFAH(MHKEFJDKLJN PDOICCGDHHF, OAEILIIIPED LBJHHPLDPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE960", Offset = "0x2DAD160", VA = "0x182DAE960")]
	public JNJGFBGKBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[UnityEngine.Scripting.Preserve]
internal sealed class OBJHJJMGPAC : MFLEOODBFAO, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GAGCOKAHLMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GAGCOKAHLMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x59791F0", Offset = "0x59779F0", VA = "0x1859791F0")]
		internal object OFFNKDGGGHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class LBKJJHGCJHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LBKJJHGCJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x597C4C0", Offset = "0x597ACC0", VA = "0x18597C4C0")]
		internal object EGFDMPEONFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private EPOJINPDBDE KELDMIFJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private BNEJDHEIHAG KEJOJLBJLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private MFHIJBENPCO GAOOEGMBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private NJCAGKAOHPF DOOFDPAIBFA;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3493600", Offset = "0x3491E00", VA = "0x183493600", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3491400", Offset = "0x348FC00", VA = "0x183491400", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3491D90", Offset = "0x3490590", VA = "0x183491D90", Slot = "4")]
	public LIHFEMBJCAM KEABJGIDHIP(FHMBHNPINBI BOBCMCAMEBH)
	{
		return default(LIHFEMBJCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3492890", Offset = "0x3491090", VA = "0x183492890", Slot = "5")]
	public void MBDNCJBLALE(Guid PALLEDHBFCO, Task OIDBJIACCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3491CC0", Offset = "0x34904C0", VA = "0x183491CC0")]
	private void HJHGFNHOHPM(byte PJPMIHPOMIA, int OEOGPLHHBJF, object FNPKKBLOKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3492E40", Offset = "0x3491640", VA = "0x183492E40")]
	private void OPFLAMIDEKC(GDNNMLKFEHK CBLNAPKAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3492290", Offset = "0x3490A90", VA = "0x183492290")]
	private void KJCGJKABNCF(GDNNMLKFEHK CBLNAPKAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3491700", Offset = "0x348FF00", VA = "0x183491700")]
	private void GFJCEIANGPO(GDNNMLKFEHK CBLNAPKAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3492B20", Offset = "0x3491320", VA = "0x183492B20")]
	private IDIFMABCDLA OGNDPHAOHLC(FHMBHNPINBI IFPNDMLIDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x34914A0", Offset = "0x348FCA0", VA = "0x1834914A0")]
	private void ELDMIMPBLPI(FHMBHNPINBI KAMKHOFOCLH, IDIFMABCDLA NPAEKAKKGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x34911A0", Offset = "0x348F9A0", VA = "0x1834911A0")]
	private bool AEJOMOPEPHO(FHMBHNPINBI KAMKHOFOCLH, IDIFMABCDLA NPAEKAKKGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x34919D0", Offset = "0x34901D0", VA = "0x1834919D0")]
	private bool GLPONHOOAHJ(FHMBHNPINBI CFDLOODJELF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3492580", Offset = "0x3490D80", VA = "0x183492580")]
	private bool KNPDFGFDOIA(byte PJPMIHPOMIA, ExitGames.Client.Photon.Hashtable CBLNAPKAJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public OBJHJJMGPAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[UnityEngine.Scripting.Preserve]
internal sealed class CKMOEBJAOPG : BNEJDHEIHAG, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class KFEFGGLPGCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncTaskMethodBuilder<DLLMEMMHNCB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private DLLMEMMHNCB <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<DLLMEMMHNCB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KFEFGGLPGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3487D90", Offset = "0x3486590", VA = "0x183487D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class BMDICGNLCND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public FHMBHNPINBI message;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BMDICGNLCND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3481CC0", Offset = "0x34804C0", VA = "0x183481CC0")]
		internal object CMEMKNFNPIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class IHCKFCKFJON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public FHMBHNPINBI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IHCKFCKFJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3484B00", Offset = "0x3483300", VA = "0x183484B00")]
		internal object ANGMPJBBEMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class OGFHCAIIDIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OGFHCAIIDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3494F40", Offset = "0x3493740", VA = "0x183494F40")]
		internal object NCKCBCGKJDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class GFKNMMHGBNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private OGFHCAIIDIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private OOCGABPOHBK <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private OOCGABPOHBK <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private TaskAwaiter<OOCGABPOHBK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GFKNMMHGBNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3484400", Offset = "0x3482C00", VA = "0x183484400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class LNKNCCKFBNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public FHMBHNPINBI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LNKNCCKFBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x348B520", Offset = "0x3489D20", VA = "0x18348B520")]
		internal object LKPPLMGGGEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class LFHIHKJIFGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public FHMBHNPINBI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private LNKNCCKFBNK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private FFLEKJBGAJJ <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private FHMBHNPINBI <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private OOCGABPOHBK <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private FHMBHNPINBI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LFHIHKJIFGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x348A270", Offset = "0x3488A70", VA = "0x18348A270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class DAMOLBBFHIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder<OOCGABPOHBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private FFLEKJBGAJJ <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private FHMBHNPINBI <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private FHMBHNPINBI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DAMOLBBFHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3482E40", Offset = "0x3481640", VA = "0x183482E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class LMBNFMHCKPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public OOCGABPOHBK operation;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LMBNFMHCKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x348B4A0", Offset = "0x3489CA0", VA = "0x18348B4A0")]
		internal object JENKBJHLJHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class EJEBGKCEFID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public OOCGABPOHBK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private LMBNFMHCKPG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private global::JAPPGKMKBNF<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private AALOEEPNEOP <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public EJEBGKCEFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3483340", Offset = "0x3481B40", VA = "0x183483340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class GDGIGHPPLCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GDGIGHPPLCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x34843A0", Offset = "0x3482BA0", VA = "0x1834843A0")]
		internal object LFCDLOJAPPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class IOBLMKPDMKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IOBLMKPDMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3485020", Offset = "0x3483820", VA = "0x183485020")]
		internal object GJKPHIKGMAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private HLDCIPKGMNF CPNGNGPKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private MFLEOODBFAO ABDILMEFOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private KHCNMJFIKHK MNLFCPGNLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private TaskCompletionSource<DLLMEMMHNCB> LDDHDADPIHD;

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D93920", Offset = "0x2D92120", VA = "0x182D93920", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D925B0", Offset = "0x2D90DB0", VA = "0x182D925B0", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KFEFGGLPGCA))]
	public Task<DLLMEMMHNCB> ADEHAOCABJJ(CancellationToken BOPCGMCIPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D92D50", Offset = "0x2D91550", VA = "0x182D92D50", Slot = "4")]
	public void KEBINCHJHOA(FHMBHNPINBI DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D92180", Offset = "0x2D90980", VA = "0x182D92180", Slot = "5")]
	public void ADAEPOMFIHE(FHMBHNPINBI FNLNAMAPIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D92720", Offset = "0x2D90F20", VA = "0x182D92720")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFKNMMHGBNC))]
	private Task ALKKOEOLHIB(FHMBHNPINBI PAJPFFIMEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D92C00", Offset = "0x2D91400", VA = "0x182D92C00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LFHIHKJIFGM))]
	private Task HMNJGHCJEIK(FHMBHNPINBI KAMKHOFOCLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D928F0", Offset = "0x2D910F0", VA = "0x182D928F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DAMOLBBFHIJ))]
	private Task<OOCGABPOHBK> BLJCKJJIGLC(FHMBHNPINBI PAJPFFIMEFB, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D92870", Offset = "0x2D91070", VA = "0x182D92870")]
	private FFLEKJBGAJJ APOFHGHCMEO(FHMBHNPINBI IFPNDMLIDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2D92A90", Offset = "0x2D91290", VA = "0x182D92A90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJEBGKCEFID))]
	private Task HIMPBLOIKAI(OOCGABPOHBK CDJHLNAAHGK, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2D93680", Offset = "0x2D91E80", VA = "0x182D93680")]
	private OOCGABPOHBK LNJLMLOCPIM(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x315ACF0", Offset = "0x31594F0", VA = "0x18315ACF0")]
	private T FPDLJJIJEGK<T>(T ECNGHFJBIJL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D931B0", Offset = "0x2D919B0", VA = "0x182D931B0")]
	private OOCGABPOHBK LFPGJKOEKLO(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public CKMOEBJAOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2D93630", Offset = "0x2D91E30", VA = "0x182D93630")]
	[CompilerGenerated]
	private void LLJMPMBCKJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal interface AIMHFJMEAKL
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TimeSpan LHJNNILLFKI
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	TimeSpan EPCMOJLJLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	TimeSpan DAOBFAELEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	TimeSpan DPGCFHMEEJB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool OFDCHEPEDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool HKOPKHIHGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool JFNNLIFPDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	TimeSpan PJBMKHDPPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	TimeSpan PLNLHBFIMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	TimeSpan CIKCDCEOKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int KOCDOHPCCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal interface BNBOHDAMFHI : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LCMHJBMHMJN> KAELPKDAAHM(AALOEEPNEOP LEBCJIHOHHE, MHKEFJDKLJN FKMIOMCKJNF, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal class GMAMNIGHIIF : HMAILMDEICE
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class IDMNADHAMAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public GMAMNIGHIIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Matchmaking.PAFIILGBNBC result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public MHKEFJDKLJN newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IDMNADHAMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x42B2410", Offset = "0x42B0C10", VA = "0x1842B2410")]
		internal object COFPDFNHHKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x42B2600", Offset = "0x42B0E00", VA = "0x1842B2600")]
		internal object KHDMMCIHEGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x42B2560", Offset = "0x42B0D60", VA = "0x1842B2560")]
		internal object HLMNKFDEPCN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class IKBJOJBJOKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public GMAMNIGHIIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private IDMNADHAMAP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private Matchmaking.PAFIILGBNBC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private TaskAwaiter<Matchmaking.PAFIILGBNBC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IKBJOJBJOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x42B2700", Offset = "0x42B0F00", VA = "0x1842B2700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private const float DEKHCELCOFE = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private readonly IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2DA37B0", Offset = "0x2DA1FB0", VA = "0x182DA37B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x8AC4E0", Offset = "0x8AACE0", VA = "0x1808AC4E0")]
	public GMAMNIGHIIF(IFNNJAAOEDN FNIFBLHBOOE, HBPPPIGEKFO FGOMHOJPKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3640", Offset = "0x2DA1E40", VA = "0x182DA3640", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKBJOJBJOKD))]
	public Task<bool> BFAINGMPNNG(CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal interface ANJBBNMCECI : KKHNJDMOGHC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal interface HMAILMDEICE
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> BFAINGMPNNG(CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public interface JHPGNCLFEFD
{
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKJGCJELDBJ(LHNHBKFIDPL CDOIPBLLOCN);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MANOAIPGPIB(LHNHBKFIDPL CDOIPBLLOCN);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNIOAJEFAAL(LHNHBKFIDPL CDOIPBLLOCN);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FDHPCIGKKHH(LHNHBKFIDPL CDOIPBLLOCN);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class LHNHBKFIDPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public readonly MHKEFJDKLJN BGMGCNGONPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Dictionary<string, string> LOJDMHGAGAM;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public global::JAPPGKMKBNF<string> KCGIIBMNCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF10", Offset = "0x8AB710", VA = "0x1808ACF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD20", Offset = "0x8AB520", VA = "0x1808ACD20")]
	public LHNHBKFIDPL(MHKEFJDKLJN BIJBNMHAAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x348B1E0", Offset = "0x34899E0", VA = "0x18348B1E0")]
	public LHNHBKFIDPL MNMFBAAJDPG(string BDFCACLHAFA, string ECNGHFJBIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x348B160", Offset = "0x3489960", VA = "0x18348B160")]
	public bool JBNLINMGPLP(out IEnumerable<KeyValuePair<string, string>> OJGHOIDDGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2F33F70", Offset = "0x2F32770", VA = "0x182F33F70")]
	public LHNHBKFIDPL DCEKJEKIOJL(global::JAPPGKMKBNF<string> IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x348AEB0", Offset = "0x34896B0", VA = "0x18348AEB0")]
	public LHNHBKFIDPL HBBJJMNBDFM(string ICAKNAGPMCM, LJGOPKDOKIE HMIAOOCHGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface PJEIECLNICO
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MHKEFJDKLJN GCAKDALBEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	IEMLKNOFDEG COPPBMJCHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	MPOOILGCDLJ GJAGOJBNJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool OMKCHEEDJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool MKOFNMFHMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	int AHANMDCKNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action KAGCKBPPEKE;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<int> EOGPFIDDBOJ;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GFBCPMLLEKL();

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.MDKPNMHIPCM> DFLBCCECPHL(long BFNOJMGJLFG, [Optional] CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.PAFIILGBNBC> NIBFDLIPPAM();

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task EJCEPMEJCHG();

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(MHKEFJDKLJN, OAEILIIIPED) OJAIJOAJBHC();

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MHBAMGOJMJJ IKCIIPMOMLF();

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HELCKINDJHN(long BFNOJMGJLFG);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal interface KHCNMJFIKHK : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FHMBHNPINBI> NFBKKILHAPB(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FHMBHNPINBI> AMIAFKHFHLG(CancellationToken GFFFFCALMCA, FFLEKJBGAJJ GAEEOLALHAM);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DNKNJNMAMBL PNKJHFEMMMK(OOCGABPOHBK BCJOJLPDGAD, AALOEEPNEOP LEBCJIHOHHE);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DNKNJNMAMBL HHEJOOPBBPE(OOCGABPOHBK BCJOJLPDGAD, AALOEEPNEOP LEBCJIHOHHE);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class HAIGOHNCBOK : IFNNJAAOEDN, NCFBJHOACDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class AOJGMFMCJFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public HCKACEFMPCF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public HAIGOHNCBOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private IDIFMABCDLA <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private IDIFMABCDLA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<IDIFMABCDLA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AOJGMFMCJFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x42AA0A0", Offset = "0x42A88A0", VA = "0x1842AA0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class DIINOIAAFOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public HAIGOHNCBOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private IDIFMABCDLA <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DIINOIAAFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x42AD870", Offset = "0x42AC070", VA = "0x1842AD870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class OOMBEOLIPME : IEnumerable<KKHNJDMOGHC>, IEnumerable, IEnumerator<KKHNJDMOGHC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private KKHNJDMOGHC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public HAIGOHNCBOK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private KKHNJDMOGHC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xB955D0", Offset = "0xB93DD0", VA = "0x180B955D0")]
		[DebuggerHidden]
		public OOMBEOLIPME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x42BB340", Offset = "0x42B9B40", VA = "0x1842BB340", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x42BB7C0", Offset = "0x42B9FC0", VA = "0x1842BB7C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x42BB720", Offset = "0x42B9F20", VA = "0x1842BB720", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KKHNJDMOGHC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x42BB720", Offset = "0x42B9F20", VA = "0x1842BB720", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private readonly CancellationTokenSource EOFDJDMKNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private readonly MHOBEFMLEFD JMIFLNNGBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private MMBBPNPCMOA PKFPFKNCCLP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public EPJFONLPCOB HOCOJIBIFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8C35E0", Offset = "0x8C1DE0", VA = "0x1808C35E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x967730", Offset = "0x965F30", VA = "0x180967730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GHOMLKKKKHM JMGHKJIPIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8ABED0", Offset = "0x8AA6D0", VA = "0x1808ABED0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x9118A0", VA = "0x1809130A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8C35F0", Offset = "0x8C1DF0", VA = "0x1808C35F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x9130B0", Offset = "0x9118B0", VA = "0x1809130B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KDHGMPHKPAM MAEKOJNKJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8C3600", Offset = "0x8C1E00", VA = "0x1808C3600", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x913090", Offset = "0x911890", VA = "0x180913090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DPADKKHLKLF PBNEJPFKDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8C3580", Offset = "0x8C1D80", VA = "0x1808C3580", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5630", Offset = "0x8D3E30", VA = "0x1808D5630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public BEIIGIJBNMM EHLIDEAPHLB
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8C3590", Offset = "0x8C1D90", VA = "0x1808C3590", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B80", Offset = "0x8E3380", VA = "0x1808E4B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public KFDAFKKLOKJ GCFMGMKCIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8E9240", Offset = "0x8E7A40", VA = "0x1808E9240", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B60", Offset = "0x8E3360", VA = "0x1808E4B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public HLDCIPKGMNF ANJLCFPEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8B4140", Offset = "0x8B2940", VA = "0x1808B4140", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x910B70", Offset = "0x90F370", VA = "0x180910B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public NABGKEIJMLK ILDDDNKPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8B41E0", Offset = "0x8B29E0", VA = "0x1808B41E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xAB3C10", Offset = "0xAB2410", VA = "0x180AB3C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LEHKMPCAGKL LBBBKNCGGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8E9210", Offset = "0x8E7A10", VA = "0x1808E9210", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xB02EA0", Offset = "0xB016A0", VA = "0x180B02EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public LFPKDNNPHDE DGJOFOIFJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8C35A0", Offset = "0x8C1DA0", VA = "0x1808C35A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B70", Offset = "0x8E3370", VA = "0x1808E4B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public LKGOGFHLDFK JFMCLHOMNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8C35B0", Offset = "0x8C1DB0", VA = "0x1808C35B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x909C80", Offset = "0x908480", VA = "0x180909C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public OCAOCNCNOCD MOPGLPOHIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8C35D0", Offset = "0x8C1DD0", VA = "0x1808C35D0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA67750", Offset = "0xA65F50", VA = "0x180A67750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public MFHIJBENPCO DHPNGFEFNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8C35C0", Offset = "0x8C1DC0", VA = "0x1808C35C0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B90", Offset = "0x8E3390", VA = "0x1808E4B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public ANJBBNMCECI JPIDCLGLMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA64F10", Offset = "0xA63710", VA = "0x180A64F10", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA65600", Offset = "0xA63E00", VA = "0x180A65600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public BNEJDHEIHAG OCHGGKGDJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9E90F0", Offset = "0x9E78F0", VA = "0x1809E90F0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA64F20", Offset = "0xA63720", VA = "0x180A64F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public MFLEOODBFAO IEAEMFIFNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x90CBB0", Offset = "0x90B3B0", VA = "0x18090CBB0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x90CFD0", Offset = "0x90B7D0", VA = "0x18090CFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public PJKNICMILIO HJIMPJGIBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x808230", Offset = "0x806A30", VA = "0x180808230", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xAB10C0", Offset = "0xAAF8C0", VA = "0x180AB10C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public BNBOHDAMFHI FFNIAEHNKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA65BB0", Offset = "0xA643B0", VA = "0x180A65BB0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xAB1D30", Offset = "0xAB0530", VA = "0x180AB1D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public KHCNMJFIKHK PIIAEDKDFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xA658B0", Offset = "0xA640B0", VA = "0x180A658B0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xA65BE0", Offset = "0xA643E0", VA = "0x180A65BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NNIOHMBOJFJ GDOBLIHPACC
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA65890", Offset = "0xA64090", VA = "0x180A65890", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA65BC0", Offset = "0xA643C0", VA = "0x180A65BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public EPOJINPDBDE BPLFNCLBJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA658A0", Offset = "0xA640A0", VA = "0x180A658A0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA65BD0", Offset = "0xA643D0", VA = "0x180A65BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public JHPGNCLFEFD DBIJAOJGMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xAB1D20", Offset = "0xAB0520", VA = "0x180AB1D20", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xEE6D70", Offset = "0xEE5570", VA = "0x180EE6D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public NJCAGKAOHPF KIHBGBLJHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA65B90", Offset = "0xA64390", VA = "0x180A65B90", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA65D30", Offset = "0xA64530", VA = "0x180A65D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public MHPAJLBPAGC DDKAJHJAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA65BA0", Offset = "0xA643A0", VA = "0x180A65BA0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA65D40", Offset = "0xA64540", VA = "0x180A65D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public AIMHFJMEAKL PAFHFMHEPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xDE2070", Offset = "0xDE0870", VA = "0x180DE2070", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xDE1700", Offset = "0xDDFF00", VA = "0x180DE1700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public JOLNEEIAHIL CMLFECNHKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xDE01D0", Offset = "0xDDE9D0", VA = "0x180DE01D0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xEDFE10", Offset = "0xEDE610", VA = "0x180EDFE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public LCAFMEKLLGH MFKLBOKLKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1837370", Offset = "0x1835B70", VA = "0x181837370", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public JHNNJFGCKHO CPMDHHOFDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x19C4D50", Offset = "0x19C3550", VA = "0x1819C4D50", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public PILPGHODDIG ODNKPAPJJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x11C2FE0", Offset = "0x11C17E0", VA = "0x1811C2FE0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public OAEILIIIPED OJJPFGNKGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xE71B00", Offset = "0xE70300", VA = "0x180E71B00", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xEE0B80", Offset = "0xEDF380", VA = "0x180EE0B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private bool AGMIAFBIBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2DA46B0", Offset = "0x2DA2EB0", VA = "0x182DA46B0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private bool KFILDGILPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4270", Offset = "0x2DA2A70", VA = "0x182DA4270", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Task HCHFNNPCPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4B90", Offset = "0x2DA3390", VA = "0x182DA4B90", Slot = "49")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private CancellationToken COIIPPCEMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4830", Offset = "0x2DA3030", VA = "0x182DA4830", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private MHOBEFMLEFD NBJOOFEEEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action GEHOJIKCEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4AD0", Offset = "0x2DA32D0", VA = "0x182DA4AD0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4BE0", Offset = "0x2DA33E0", VA = "0x182DA4BE0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event KGMACCFPPHI ACEHBDICKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2DA42F0", Offset = "0x2DA2AF0", VA = "0x182DA42F0", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4850", Offset = "0x2DA3050", VA = "0x182DA4850", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event KGMACCFPPHI JDBAEEJBNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4210", Offset = "0x2DA2A10", VA = "0x182DA4210", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4770", Offset = "0x2DA2F70", VA = "0x182DA4770", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event KGMACCFPPHI GACAJPABPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4710", Offset = "0x2DA2F10", VA = "0x182DA4710", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2DA47D0", Offset = "0x2DA2FD0", VA = "0x182DA47D0", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<NBGKOOKNBGP, bool> EMBGOJMNLJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4350", Offset = "0x2DA2B50", VA = "0x182DA4350", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4B30", Offset = "0x2DA3330", VA = "0x182DA4B30", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0xEE0B80", Offset = "0xEDF380", VA = "0x180EE0B80", Slot = "36")]
	public void LGJLJGHOJJN(OAEILIIIPED MDBMLIKFPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x2DA4F50", Offset = "0x2DA3750", VA = "0x182DA4F50")]
	[UnityEngine.Scripting.Preserve]
	internal HAIGOHNCBOK([ACEKLAKDMBL(null)] MHOBEFMLEFD JMIFLNNGBHG, [ACEKLAKDMBL(null)] EPJFONLPCOB EKLPJDMGHDM, [ACEKLAKDMBL(null)] GHOMLKKKKHM IIJBBPIGDIK, [ACEKLAKDMBL(null)] HBPPPIGEKFO FGOMHOJPKFO, [ACEKLAKDMBL(null)] KDHGMPHKPAM CGJJMLHLLBO, [ACEKLAKDMBL(null)] DPADKKHLKLF JKPHNCJANPB, [ACEKLAKDMBL(null)] BEIIGIJBNMM EAABFFOLONM, [ACEKLAKDMBL(null)] KFDAFKKLOKJ BBMCDOFLCKN, [ACEKLAKDMBL(null)] HLDCIPKGMNF CPNGNGPKKKH, [ACEKLAKDMBL(null)] NABGKEIJMLK KALNIKAOMNH, [ACEKLAKDMBL(null)] LEHKMPCAGKL EOHAACKOPMN, [ACEKLAKDMBL(null)] LFPKDNNPHDE MOCPAILNIIE, [ACEKLAKDMBL(null)] LKGOGFHLDFK HBHHBLLKCLC, [ACEKLAKDMBL(null)] OCAOCNCNOCD OFFFKIOLLDO, [ACEKLAKDMBL(null)] MFHIJBENPCO GAOOEGMBKDI, [ACEKLAKDMBL(null)] ANJBBNMCECI HIGLLBHNICP, [ACEKLAKDMBL(null)] BNEJDHEIHAG KEJOJLBJLEK, [ACEKLAKDMBL(null)] MFLEOODBFAO ABDILMEFOOH, [ACEKLAKDMBL(null)] PJKNICMILIO FHPOOOFJELG, [ACEKLAKDMBL(null)] BNBOHDAMFHI CJPJEGMHJHB, [ACEKLAKDMBL(null)] NNIOHMBOJFJ MOAIDCPAIPL, [ACEKLAKDMBL(null)] KHCNMJFIKHK MNLFCPGNLLN, [ACEKLAKDMBL(null)] EPOJINPDBDE KELDMIFJJEC, [ACEKLAKDMBL(null)] JHPGNCLFEFD HHCBJFFAMJN, [ACEKLAKDMBL(null)] NJCAGKAOHPF DOOFDPAIBFA, [ACEKLAKDMBL(null)] AIMHFJMEAKL CEHJOFICIAM, [ACEKLAKDMBL(null)] JOLNEEIAHIL OPFNMBAGLHI, [ACEKLAKDMBL(null)] LCAFMEKLLGH FIKIGKENNBD, [ACEKLAKDMBL(null)] JHNNJFGCKHO OPAKEBPNBDA, [ACEKLAKDMBL(null)] PILPGHODDIG DCLPNPGHFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA4D90", Offset = "0x2DA3590", VA = "0x182DA4D90")]
	private void PBAELFIBGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x2DA4520", Offset = "0x2DA2D20", VA = "0x182DA4520", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x2DA48B0", Offset = "0x2DA30B0", VA = "0x182DA48B0", Slot = "50")]
	private void JBILAOJENGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA40C0", Offset = "0x2DA28C0", VA = "0x182DA40C0", Slot = "51")]
	private DHFMLFOJIHC BCFLMDHIJKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x2DA4900", Offset = "0x2DA3100", VA = "0x182DA4900", Slot = "52")]
	private AMGCDJKPHHE JDHCHGGOBDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x2DA43B0", Offset = "0x2DA2BB0", VA = "0x182DA43B0", Slot = "53")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOJGMFMCJFG))]
	private Task<IDIFMABCDLA> DHEPDNIDHKG(HCKACEFMPCF ANGBHDDNJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x2DA4C40", Offset = "0x2DA3440", VA = "0x182DA4C40", Slot = "54")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DIINOIAAFOA))]
	private Task NFKPOIMPNCN(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2DA4E80", Offset = "0x2DA3680", VA = "0x182DA4E80")]
	[IteratorStateMachine(typeof(OOMBEOLIPME))]
	private IEnumerable<KKHNJDMOGHC> PKNFOCGLILG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x2DA4EF0", Offset = "0x2DA36F0", VA = "0x182DA4EF0")]
	[CompilerGenerated]
	private void POCFFPKPMKH(KKHNJDMOGHC DPLEBJGMEDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class HCMDOEKGEJI : BNBOHDAMFHI, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class GGBNNJMPKNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public AsyncTaskMethodBuilder<LCMHJBMHMJN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public HCMDOEKGEJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private IEMLKNOFDEG <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private IEMLKNOFDEG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<IEMLKNOFDEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GGBNNJMPKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x42B0C70", Offset = "0x42AF470", VA = "0x1842B0C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class FDIFDGHGOLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FDIFDGHGOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x42AEBA0", Offset = "0x42AD3A0", VA = "0x1842AEBA0")]
		internal object OAOGDJOBLOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class MONFPFDKGJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<IEMLKNOFDEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public HCMDOEKGEJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private FDIFDGHGOLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private AALOEEPNEOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private IEMLKNOFDEG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter<IEMLKNOFDEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MONFPFDKGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x42B8890", Offset = "0x42B7090", VA = "0x1842B8890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class JADICDPLBJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JADICDPLBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x108F230", Offset = "0x108DA30", VA = "0x18108F230")]
		internal bool BIBMCNMPDOG(MPOOILGCDLJ sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private static readonly (EFENBEKLEHO superRoomData, long subRoomDataSaveId) MBPJMINBJHC;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2DA67B0", Offset = "0x2DA4FB0", VA = "0x182DA67B0", Slot = "5")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2DA65F0", Offset = "0x2DA4DF0", VA = "0x182DA65F0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GGBNNJMPKNF))]
	public Task<LCMHJBMHMJN> KAELPKDAAHM(AALOEEPNEOP LEBCJIHOHHE, MHKEFJDKLJN FKMIOMCKJNF, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2DA6430", Offset = "0x2DA4C30", VA = "0x182DA6430")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MONFPFDKGJI))]
	private Task<IEMLKNOFDEG> JDHJMGMGKOJ(MHKEFJDKLJN FKMIOMCKJNF, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2DA62E0", Offset = "0x2DA4AE0", VA = "0x182DA62E0")]
	private LCMHJBMHMJN IHGEGPGMIFG(MHKEFJDKLJN FKMIOMCKJNF, IEMLKNOFDEG EAIBLBKOGKO, long BPODGJMCBKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5F50", Offset = "0x2DA4750", VA = "0x182DA5F50")]
	private (EFENBEKLEHO, long) BALNCNBMBEK(MHKEFJDKLJN FKMIOMCKJNF, IEMLKNOFDEG EAIBLBKOGKO, long BPODGJMCBKI)
	{
		return default((EFENBEKLEHO, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public HCMDOEKGEJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface KDHGMPHKPAM
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool GHNADOIKPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	string FEAMCFBADMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIEPJOIBNHB(Scene GNCGLIILAGO);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HPJBMFIAIHB(JGCDJAPPMFN GOAFBLHNKGD, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task INLCAIFIHFN();
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[UnityEngine.Scripting.Preserve]
internal sealed class AHPOMGBOHEB : KHCNMJFIKHK, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class DMGNANCMFIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DMGNANCMFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x34832E0", Offset = "0x3481AE0", VA = "0x1834832E0")]
		internal object CPEEEKHDIGC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class MDDDLLCOOBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public FFLEKJBGAJJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public AHPOMGBOHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private DMGNANCMFIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private FHMBHNPINBI <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private FHMBHNPINBI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MDDDLLCOOBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x348D100", Offset = "0x348B900", VA = "0x18348D100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class BMCEANIHLDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public FFLEKJBGAJJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AHPOMGBOHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private DAMKOIBGCAN <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private DDPPNCDFGCL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private TaskAwaiter<DDPPNCDFGCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BMCEANIHLDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x3481690", Offset = "0x347FE90", VA = "0x183481690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class MKHBHDMFILF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MKHBHDMFILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x348E510", Offset = "0x348CD10", VA = "0x18348E510")]
		internal object MPOEFEOCGNO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class MKMDLAEFOCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public FFLEKJBGAJJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public AHPOMGBOHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private MKHBHDMFILF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private FMEHMMJPLED <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private GPIJANIJAAG <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private DAMKOIBGCAN <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private FHMBHNPINBI <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private FMEHMMJPLED <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private DDPPNCDFGCL <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter<DDPPNCDFGCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MKMDLAEFOCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x348E950", Offset = "0x348D150", VA = "0x18348E950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private MHPAJLBPAGC DLHMJOJPEDH;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private GOMGBFEPMOD PFLGINGMBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F760", Offset = "0x2D8DF60", VA = "0x182D8F760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F9D0", Offset = "0x2D8E1D0", VA = "0x182D8F9D0", Slot = "8")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F810", Offset = "0x2D8E010", VA = "0x182D8F810", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MDDDLLCOOBE))]
	public Task<FHMBHNPINBI> NFBKKILHAPB(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F0C0", Offset = "0x2D8D8C0", VA = "0x182D8F0C0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMCEANIHLDG))]
	public Task<FHMBHNPINBI> AMIAFKHFHLG(CancellationToken GFFFFCALMCA, FFLEKJBGAJJ GAEEOLALHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2D8FA60", Offset = "0x2D8E260", VA = "0x182D8FA60", Slot = "6")]
	public DNKNJNMAMBL PNKJHFEMMMK(OOCGABPOHBK BCJOJLPDGAD, AALOEEPNEOP LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F430", Offset = "0x2D8DC30", VA = "0x182D8F430", Slot = "7")]
	public DNKNJNMAMBL HHEJOOPBBPE(OOCGABPOHBK BCJOJLPDGAD, AALOEEPNEOP LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F270", Offset = "0x2D8DA70", VA = "0x182D8F270")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MKMDLAEFOCP))]
	private Task<FHMBHNPINBI> FMFBKAMPGHL(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F260", Offset = "0x2D8DA60", VA = "0x182D8F260")]
	private static byte[] FEHBCCIIIBD(FHMBHNPINBI DKIECHCHJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F660", Offset = "0x2D8DE60", VA = "0x182D8F660")]
	private static string JPGMKADLJAN(byte[] AIMHDAMIMIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public AHPOMGBOHEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public readonly struct OOIGBDNKEMF<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class GECCFJOPNCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public AsyncTaskMethodBuilder<global::PKJAENHCLMN<global::HCLLLJEDILH<TData>, CMPFHAIKIAN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public global::OOIGBDNKEMF<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private AALOEEPNEOP <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private global::PKJAENHCLMN<byte[], CMPFHAIKIAN> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private global::PKJAENHCLMN<byte[], CMPFHAIKIAN> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<global::PKJAENHCLMN<byte[], CMPFHAIKIAN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public GECCFJOPNCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8070", Offset = "0x2BD6870", VA = "0x182BD8070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private readonly global::FNOEIOAGCPK<TGetDataArg, TData> PNGKFALBFEP;

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0xB91230", Offset = "0xB8FA30", VA = "0x180B91230")]
	internal OOIGBDNKEMF(global::FNOEIOAGCPK<TGetDataArg, TData> LHPOMNBICEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF3B0", Offset = "0x3FEDBB0", VA = "0x183FEF3B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::OOIGBDNKEMF<, >.GECCFJOPNCB))]
	public Task<global::PKJAENHCLMN<global::HCLLLJEDILH<TData>, CMPFHAIKIAN>> FMMAEMCOBJJ(TGetDataArg AIMHDAMIMIL, string AJJPNCELFOK, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class AJGLMMMEGAJ
{
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1C428D0", Offset = "0x1C410D0", VA = "0x181C428D0")]
	public static global::OOIGBDNKEMF<TGetDataArg, TData> DOBPLOGGNLM<TGetDataArg, TData>(global::FNOEIOAGCPK<TGetDataArg, TData> LHPOMNBICEN)
	{
		return default(global::OOIGBDNKEMF<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[UnityEngine.Scripting.Preserve]
internal sealed class HBIFBBIEEDF : PJKNICMILIO, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class DOJODKJDBCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public DLLMEMMHNCB operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public HBIFBBIEEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DOJODKJDBCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x42AE450", Offset = "0x42ACC50", VA = "0x1842AE450")]
		internal object DAGJCDDHHCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x42AE320", Offset = "0x42ACB20", VA = "0x1842AE320")]
		internal object ADBOEBGPJOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class IDAGABMBDJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public HBIFBBIEEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private DOJODKJDBCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private IDIFMABCDLA <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private IDIFMABCDLA <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter<IDIFMABCDLA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IDAGABMBDJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x42B1E00", Offset = "0x42B0600", VA = "0x1842B1E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class PDPJCAIDOCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public DLLMEMMHNCB operationType;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public PDPJCAIDOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x42BB800", Offset = "0x42BA000", VA = "0x1842BB800")]
		internal object NIEMLIEKAPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class GAIMGEONPNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GAIMGEONPNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x42B03A0", Offset = "0x42AEBA0", VA = "0x1842B03A0")]
		internal object OEEANEFBCJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x42B04A0", Offset = "0x42AECA0", VA = "0x1842B04A0")]
		internal object PPNMJDPHAKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x42B0420", Offset = "0x42AEC20", VA = "0x1842B0420")]
		internal object PELHJCGOIMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class CPFBJMKGFIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public HBIFBBIEEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private GAIMGEONPNF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private LIHFEMBJCAM <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private IDIFMABCDLA <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private (IDIFMABCDLA validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private (IDIFMABCDLA validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter<(IDIFMABCDLA validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CPFBJMKGFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x42ABB80", Offset = "0x42AA380", VA = "0x1842ABB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private EPOJINPDBDE KELDMIFJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private MFLEOODBFAO ABDILMEFOOH;

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5EA0", Offset = "0x2DA46A0", VA = "0x182DA5EA0", Slot = "5")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5D30", Offset = "0x2DA4530", VA = "0x182DA5D30", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IDAGABMBDJA))]
	private Task<IDIFMABCDLA> JJKEIIMBAMH(FHMBHNPINBI IFPNDMLIDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5940", Offset = "0x2DA4140", VA = "0x182DA5940")]
	private bool GJCJOJDLELC(DLLMEMMHNCB KAINKNJPFIL, out IDIFMABCDLA IIMBBHEIGGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5BC0", Offset = "0x2DA43C0", VA = "0x182DA5BC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPFBJMKGFIB))]
	private Task<IDIFMABCDLA> IOGHKNBIIKI(FHMBHNPINBI PAJPFFIMEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public HBIFBBIEEDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public static class MDMPMBPEFDA
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public static IDIFMABCDLA GBIFOJKCEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x348D630", Offset = "0x348BE30", VA = "0x18348D630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x348D700", Offset = "0x348BF00", VA = "0x18348D700")]
	public static bool EGDIGIIHPIG(this IDIFMABCDLA NPAEKAKKGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x348D690", Offset = "0x348BE90", VA = "0x18348D690")]
	public static IDIFMABCDLA DCMADGLAFJL(BOHAGPJNCEM BBMNNPEOJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x348D730", Offset = "0x348BF30", VA = "0x18348D730")]
	public static IDIFMABCDLA EKDFEDAKBMJ(params IDIFMABCDLA[] EJEMMKODELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x348D9F0", Offset = "0x348C1F0", VA = "0x18348D9F0")]
	public static IDIFMABCDLA MFIOCBBOOJP(IEnumerable<IDIFMABCDLA> EJEMMKODELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x348D740", Offset = "0x348BF40", VA = "0x18348D740")]
	public static string FFEBHLOMHAI(this IDIFMABCDLA IIMBBHEIGGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class NFOAMOJDGHO : EPOJINPDBDE, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private DPADKKHLKLF JKPHNCJANPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private HLDCIPKGMNF CPNGNGPKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private NNIOHMBOJFJ MOAIDCPAIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private LKGOGFHLDFK HBHHBLLKCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private OCAOCNCNOCD OFFFKIOLLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private AIMHFJMEAKL CEHJOFICIAM;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x34904D0", Offset = "0x348ECD0", VA = "0x1834904D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private static IDIFMABCDLA GBIFOJKCEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x348D630", Offset = "0x348BE30", VA = "0x18348D630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x3490900", Offset = "0x348F100", VA = "0x183490900", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x3490520", Offset = "0x348ED20", VA = "0x183490520", Slot = "4")]
	public IDIFMABCDLA NMBCIPOHMGE(IGGCDPKBFGF AEEBHLKEAKN, DLLMEMMHNCB GOKELOIKDPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x34901E0", Offset = "0x348E9E0", VA = "0x1834901E0", Slot = "5")]
	public IDIFMABCDLA GOENMAPECNC(IGGCDPKBFGF AOLFPABEEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x34906B0", Offset = "0x348EEB0", VA = "0x1834906B0", Slot = "6")]
	public IDIFMABCDLA OIGJDPDICNH(IGGCDPKBFGF AOLFPABEEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x348D690", Offset = "0x348BE90", VA = "0x18348D690")]
	private static IDIFMABCDLA DCMADGLAFJL(BOHAGPJNCEM MDCIFHCDMMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public NFOAMOJDGHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public delegate Task NDLLDLNNGKD(MOMCOKAPMLC CMMCIHFHBLL, CancellationToken FLDJLPKNKKO);
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal interface OCAOCNCNOCD : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool CEMOOCAECHD
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JBCFBBEJPKG(NDLLDLNNGKD JOBDEEONKAE);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface NJCAGKAOHPF
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLMAHHBOPIN(out IEnumerable<int> NJJLJGMKLJE);

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLEDDJNKNMN(PKHKKGNCOIB FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIEIFLDAHLF(PKHKKGNCOIB FLDJLPKNKKO);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface NOKNPGPIPCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OEIPHHEMJBA(IDIFMABCDLA NPAEKAKKGDM);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal interface PJKNICMILIO : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IDIFMABCDLA> HJIMPJGIBJM(FHMBHNPINBI IFPNDMLIDFN);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal interface IFNNJAAOEDN : NCFBJHOACDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	CancellationToken BAPIAIDFBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	MHOBEFMLEFD MLGFLIHDPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	EPJFONLPCOB HOCOJIBIFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	GHOMLKKKKHM JMGHKJIPIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	KDHGMPHKPAM MAEKOJNKJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	DPADKKHLKLF PBNEJPFKDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	BEIIGIJBNMM EHLIDEAPHLB
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	KFDAFKKLOKJ GCFMGMKCIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	HLDCIPKGMNF ANJLCFPEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	NABGKEIJMLK ILDDDNKPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	LEHKMPCAGKL LBBBKNCGGIF
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	LFPKDNNPHDE DGJOFOIFJJP
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	LKGOGFHLDFK JFMCLHOMNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	OCAOCNCNOCD MOPGLPOHIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	MFHIJBENPCO DHPNGFEFNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	ANJBBNMCECI JPIDCLGLMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	BNEJDHEIHAG OCHGGKGDJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	MFLEOODBFAO IEAEMFIFNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	PJKNICMILIO HJIMPJGIBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	BNBOHDAMFHI FFNIAEHNKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	KHCNMJFIKHK PIIAEDKDFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	NNIOHMBOJFJ GDOBLIHPACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	EPOJINPDBDE BPLFNCLBJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	JHPGNCLFEFD DBIJAOJGMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	NJCAGKAOHPF KIHBGBLJHLE
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	MHPAJLBPAGC DDKAJHJAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	AIMHFJMEAKL PAFHFMHEPDE
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	JOLNEEIAHIL CMLFECNHKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	LCAFMEKLLGH MFKLBOKLKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	JHNNJFGCKHO CPMDHHOFDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	PILPGHODDIG ODNKPAPJJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void LGJLJGHOJJN(OAEILIIIPED MDBMLIKFPPB);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal interface LFPKDNNPHDE : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JHKFDEFLOCO();

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEAHNGCCEOM();

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHLPPHPEFDP();
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class EPJAGPDNGNM
{
	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2D987D0", Offset = "0x2D96FD0", VA = "0x182D987D0")]
	public static void LKLABALGDMK(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2D985D0", Offset = "0x2D96DD0", VA = "0x182D985D0")]
	internal static void GOHIKCIPJDG(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2D986F0", Offset = "0x2D96EF0", VA = "0x182D986F0")]
	internal static void HKPEEDJJFCO(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2D98180", Offset = "0x2D96980", VA = "0x182D98180")]
	internal static void BNFBDNFHIIK(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class MIPPFLCEBNN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x348E4D0", Offset = "0x348CCD0", VA = "0x18348E4D0")]
	public MIPPFLCEBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0xAEB100", Offset = "0xAE9900", VA = "0x180AEB100")]
	public MIPPFLCEBNN(string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal interface KKHNJDMOGHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public interface HBPPPIGEKFO
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	int AHANMDCKNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	bool HJDOBAAJFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool CLIDBLGGLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	bool BKKNHNGMOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool BAAOGMEPFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	IGGCDPKBFGF AGOBILJIDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool CMJEGCCGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	float PBHJLDENPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event Action<float> ONCFOLILPLM;

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MHOBEFMLEFD IIAPOLDHLHH(MHOBEFMLEFD EOHDEJOCEFD);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DHGNPHMOAIH(MHOBEFMLEFD JMIFLNNGBHG);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIJGFPCIHPJ();

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task AHAEOEIJNIF(AALOEEPNEOP BNDOBCCDIJF, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IAHIILNMGMK(float HACKJIALAHA);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LNOFDFDCDJE(string FMCIPDNGKPD);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IReadOnlyList<HGGHGJBADJJ> EGAFFNAAALH();

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDisposable JBKIEOAMFHJ(object JFDMKPDIBDL, HGGHGJBADJJ NMPOOPDGJFD);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CIOHJELGAHC JNECGINONDF(IEnumerable<HGNMPOIAAKI> LDOJACGGACG);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PBPAJCOAAJK(int ALCHPPPJPLL);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task DHDLMJMDLLF();

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GMKJGDMMEDE();

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool JEPHPFEOHOC();

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task COJFFAEFDII(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task PMDODLOMCKG(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<JLOOFCOEEHE> OBLJOHKHFAB(DateTime FAPCHPBFJLF, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> DODGHAFOCHH(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PMJNKCJKOIB();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "23")]
	DHJIDMGNJIC PHPEOAJOMNB(GEDJHDMKMOJ GIOCABEBNHM, BNIDNMGAHLD PJDCDPIPHBA, IEnumerable<PersistenceView> DLPOCMMMECH, EKIEPCIPJDM LHNAPAPHKDJ);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ALANBJJMLNA(BNIDNMGAHLD PJDCDPIPHBA);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NNCICCPJLGK(HGNMPOIAAKI EJFGMPEJEDD, in DHJIDMGNJIC AKDAOECFHJI);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task JGAMHBJGIID(BNIDNMGAHLD BBBFCKGLENJ, bool FPJMKDBAJEB, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task DAFGNJPLOPO(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EJJADMJGOCK(long HAMIEGOKEJC, long KIBMHJEFMKG, IEMLKNOFDEG KBEKHLAONIE, BNNPCINDEGK OMPPEPJAKGO, EJCOGPHMIIO NNIPLGKEGFJ, NNENOOPKHPC? IDBNBECJKFH, IEGAONCOOPP? FEBGOIPDFBI);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OBGCAJKMBFN(long HAMIEGOKEJC, long KIBMHJEFMKG, IEGAONCOOPP? FEBGOIPDFBI);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MLLBKCFDACI(PersistenceView FIHOFPLBHGJ);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool NMHHJIPANKH(PersistenceView AFCPDJEIDLD);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool IFKDBCFOFIH(HGNMPOIAAKI EJFGMPEJEDD, HBHNCFJCIKF KJBJOIGGOCH, out GKDPOMOKADP OHHKEBOPNAF);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task ILODAAHACKN(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void DHLEAONJDIN();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable MJKOEHHJIGF();

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void DEMPKIDPOMC(BNIDNMGAHLD BBBFCKGLENJ, HBHNCFJCIKF KJBJOIGGOCH);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> ECHGGKEINGC(EPJFONLPCOB EKLPJDMGHDM, CancellationToken GFFFFCALMCA, AALOEEPNEOP LEBCJIHOHHE);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void EDJMEEDMGOD(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<LPCDCAILFOA> MKIGCNOMKGI(NEBPAIJOJCP PAJPFFIMEFB);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<IEMLKNOFDEG> LLIJKKNNJOP(long HAMIEGOKEJC, bool GCJJOJLIFFI, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<BNNPCINDEGK> CDFBEKELOHD(long HAMIEGOKEJC, long KIBMHJEFMKG, long PJBAEAJLHMO, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<CAIGCNABMEN> LPALFELCAHM(string APOLELLKJLH, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<CAIGCNABMEN> AAHGHJMMPPF(string APOLELLKJLH, long HAMIEGOKEJC, long KIBMHJEFMKG, string OPOLKMBAJBK, NIADFLCAKKJ.BLEDDCONCNO CMMCIHFHBLL, NIADFLCAKKJ.BLEDDCONCNO HOIJLNKGLFK, int DEPJAMELNGJ);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool BPLLMFFJGAA();

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool OGINDCNJOGA();

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool FIFNKADIEEO(IEnumerable<GKDPOMOKADP> IGIOLCOIKFA);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void FMOCKPKCFCD(List<GameObject> EFKKBFKJFPG);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float GLCIIMFBOHN();

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool BPFAPADGDNM(string KPMIPNBJALP, out Scene IKOPIEMNEKF);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> PNEPKELPBPK(string KPMIPNBJALP, LoadSceneMode EMEPBMIHOEO, bool DJJMALJEJII, AALOEEPNEOP IDIJCJCNEPO);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void HFIDDOBGHNG();

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool MJANIBKKGKE(ByteString KNJBCHEFCED);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void EHFPLOBAFBB();

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void LDFJMKEMOEL();

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void HOIIHFLGKFE(MHKEFJDKLJN PDOICCGDHHF);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "62")]
	Task HBEDCFJFEGH(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task NOHPLHNKJCK(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task JBIFFBCHAOI(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void ENEHPOPGJDJ();

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "66")]
	IDisposable KFLOBOCLKHG();

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "67")]
	JKKCGILCDLC HNHMEPILOKF();

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task JELPAAOMODI(CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public interface JKKCGILCDLC
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NGCNLJOBCMB(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ABJLOPKAJKI(CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct DHJIDMGNJIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public HashSet<int> LAGFPCECFEP;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public enum JLOOFCOEEHE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class EADHPHKIDHL
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class KJNIBMJHKAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public HDDCAHBLLEN finalTimerLogFlags;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KJNIBMJHKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x4971A10", Offset = "0x4970210", VA = "0x184971A10")]
		internal void NEKAOOAPCBO(BDPOMAKGMDN t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class LPJEGNEIEKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public global::JAPPGKMKBNF<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LPJEGNEIEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x4973010", Offset = "0x4971810", VA = "0x184973010")]
		internal object PKJFDBMMMDF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public const string BNKFANAMJEE = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public const string NCFIHLMKILH = "END: ";

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2D96830", Offset = "0x2D95030", VA = "0x182D96830")]
	public static global::JAPPGKMKBNF<string> AKLIDLOGNAK([Optional] string EKLNNMKJFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2D969A0", Offset = "0x2D951A0", VA = "0x182D969A0")]
	public static global::JAPPGKMKBNF<string> AKLIDLOGNAK(HDDCAHBLLEN KDJDJIAAKGI, [Optional] string EKLNNMKJFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2D96AB0", Offset = "0x2D952B0", VA = "0x182D96AB0")]
	private static void BEOIMNJHGDJ(string BDFCACLHAFA, AHBCFPPHHDO IDIJCJCNEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2D96BC0", Offset = "0x2D953C0", VA = "0x182D96BC0")]
	private static void DAMIAJAPFJI(string BDFCACLHAFA, AHBCFPPHHDO IDIJCJCNEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2D96DB0", Offset = "0x2D955B0", VA = "0x182D96DB0")]
	public static void NJBCIHNHCDG(global::JAPPGKMKBNF<string> IDIJCJCNEPO, HDDCAHBLLEN ODPKAHOAPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2D96CD0", Offset = "0x2D954D0", VA = "0x182D96CD0")]
	public static string JBLJNPMCAIB(FHMBHNPINBI IFPNDMLIDFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[UnityEngine.Scripting.Preserve]
internal class AEONCJCINHA : OCAOCNCNOCD, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class IICKCEOFGIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public MOMCOKAPMLC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public AEONCJCINHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private Func<CancellationToken, List<Task>> <taskGenerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IICKCEOFGIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3484B60", Offset = "0x3483360", VA = "0x183484B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class JDAMIFBLIGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AEONCJCINHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public MOMCOKAPMLC roomData;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JDAMIFBLIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x3485450", Offset = "0x3483C50", VA = "0x183485450")]
		internal List<Task> LGJEAMKDKJK(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class AHCMIKAGBFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public NDLLDLNNGKD taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public AEONCJCINHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AHCMIKAGBFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x3480CE0", Offset = "0x347F4E0", VA = "0x183480CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class OMJCDDPPIAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public AEONCJCINHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OMJCDDPPIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x3496210", Offset = "0x3494A10", VA = "0x183496210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private readonly HashSet<NDLLDLNNGKD> CFPBFMNDOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private GHOMLKKKKHM IIJBBPIGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private HGGHGJBADJJ PCNABAKEDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private EMOAKECFAIC GJMOIKFOKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private IDisposable IGMACGPPKGM;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool CEMOOCAECHD
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2D8ED70", Offset = "0x2D8D570", VA = "0x182D8ED70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	internal Task KCIAOCJILBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E240", Offset = "0x2D8CA40", VA = "0x182D8E240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2D8EDA0", Offset = "0x2D8D5A0", VA = "0x182D8EDA0", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E250", Offset = "0x2D8CA50", VA = "0x182D8E250", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E870", Offset = "0x2D8D070", VA = "0x182D8E870", Slot = "5")]
	public bool JBCFBBEJPKG(NDLLDLNNGKD JOBDEEONKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E3B0", Offset = "0x2D8CBB0", VA = "0x182D8E3B0")]
	private void HOPGIKLHCMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E8D0", Offset = "0x2D8D0D0", VA = "0x182D8E8D0")]
	private void JBMCGODGAFK(MOMCOKAPMLC CMMCIHFHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2D8DB40", Offset = "0x2D8C340", VA = "0x182D8DB40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IICKCEOFGIF))]
	private Task BNCHPNCJPIE(MOMCOKAPMLC CMMCIHFHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E2D0", Offset = "0x2D8CAD0", VA = "0x182D8E2D0")]
	private Func<CancellationToken, List<Task>> FFNAMDMFGNC(MOMCOKAPMLC CMMCIHFHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x2D8DC90", Offset = "0x2D8C490", VA = "0x182D8DC90")]
	private List<Task> CMPFDJLLOAD(MOMCOKAPMLC CMMCIHFHBLL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2D8EBD0", Offset = "0x2D8D3D0", VA = "0x182D8EBD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AHCMIKAGBFJ))]
	private Task JCKGPKELFGI(NDLLDLNNGKD GALABLGPLIG, MOMCOKAPMLC PHBHEFAPHDL, CancellationToken FLDJLPKNKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E750", Offset = "0x2D8CF50", VA = "0x182D8E750")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMJCDDPPIAG))]
	private Task IMGJEMNFBPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E620", Offset = "0x2D8CE20", VA = "0x182D8E620")]
	private void IHLPPHPEFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F040", Offset = "0x2D8D840", VA = "0x182D8F040")]
	public AEONCJCINHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal interface HLDCIPKGMNF : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool JHKJEJHMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Task NLFPKAMNLJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHJNMAOMFMN(Task GAKDIIFBLNI, string NNLMNOOEFFA);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class BPDCHEJGLEB : HMAILMDEICE
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class JBACILOGPJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public BPDCHEJGLEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JBACILOGPJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x3485080", Offset = "0x3483880", VA = "0x183485080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private readonly IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private readonly HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x8AC4E0", Offset = "0x8AACE0", VA = "0x1808AC4E0")]
	public BPDCHEJGLEB(IFNNJAAOEDN FNIFBLHBOOE, HBPPPIGEKFO FGOMHOJPKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2D91420", Offset = "0x2D8FC20", VA = "0x182D91420", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JBACILOGPJK))]
	public Task<bool> BFAINGMPNNG(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2D91590", Offset = "0x2D8FD90", VA = "0x182D91590")]
	[CompilerGenerated]
	private object MJNFCNHNFBF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class LGGJCNKGNNJ : KBIEMNNHIEA, DPADKKHLKLF, CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class IIINIOJANIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public IDIFMABCDLA result;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IIINIOJANIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x42B26A0", Offset = "0x42B0EA0", VA = "0x1842B26A0")]
		internal object MHIABBOBHCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x348AEA0", Offset = "0x34896A0", VA = "0x18348AEA0")]
	[UnityEngine.Scripting.Preserve]
	public LGGJCNKGNNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x348AD10", Offset = "0x3489510", VA = "0x18348AD10", Slot = "8")]
	public IDIFMABCDLA KDJGBCGJOCG(IGGCDPKBFGF AOLFPABEEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public interface JOLNEEIAHIL
{
	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool AMADDIGKHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	string FIFAJPMPCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFEGFHLPEBL();

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MHMLFGJNJKA IEPMIFNDONP(long BFNOJMGJLFG);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::FNOEIOAGCPK<EFENBEKLEHO, CIOHJELGAHC> ILKGANIKHBB(long BFNOJMGJLFG);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::FNOEIOAGCPK<EFENBEKLEHO, BNIDNMGAHLD> HAFGIPOEOLP(long BFNOJMGJLFG);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::FNOEIOAGCPK<long, DBGKDIDMLDF> PBEEICJIDHJ();

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> IHJFEHBNFBL(byte[] IKHHHDILDNK, byte[] HOIJLNKGLFK, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[UnityEngine.Scripting.Preserve]
internal sealed class OPLKMJPGMHE : MFHIJBENPCO, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class JAHGDBAOKME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JAHGDBAOKME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x597AC10", Offset = "0x5979410", VA = "0x18597AC10")]
		internal object EBEEFKOEAJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class DEOIPINPEPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DEOIPINPEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5977DB0", Offset = "0x59765B0", VA = "0x185977DB0")]
		internal object NBDHKEJKBAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class JHOMONPFIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JHOMONPFIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x597B560", Offset = "0x5979D60", VA = "0x18597B560")]
		internal object BLBCHAJHGFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class KBLLBPHCGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KBLLBPHCGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x597BB70", Offset = "0x597A370", VA = "0x18597BB70")]
		internal object NDIDFMEMLNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class DBJCIKLDBMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DBJCIKLDBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5977D50", Offset = "0x5976550", VA = "0x185977D50")]
		internal object AMJPKDKGJJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private readonly Dictionary<Guid, KJLLMJJEGBB> GAOOEGMBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private readonly TimeSpan MHKBKFFBMGN;

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "10")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x3497AF0", Offset = "0x34962F0", VA = "0x183497AF0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x3497590", Offset = "0x3495D90", VA = "0x183497590", Slot = "4")]
	public LIHFEMBJCAM CAILCKFFJIK(Guid PALLEDHBFCO)
	{
		return default(LIHFEMBJCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3497830", Offset = "0x3496030", VA = "0x183497830", Slot = "5")]
	public bool CPPHPNNFPKL(Guid PALLEDHBFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3497B00", Offset = "0x3496300", VA = "0x183497B00", Slot = "8")]
	public bool IHLPPHPEFDP(Guid PALLEDHBFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3498060", Offset = "0x3496860", VA = "0x183498060", Slot = "6")]
	public bool LPGMNPDMPPM(Guid PALLEDHBFCO, Task OIDBJIACCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3497D90", Offset = "0x3496590", VA = "0x183497D90", Slot = "7")]
	public bool JJNOGDGBEML(Guid PALLEDHBFCO, IDIFMABCDLA NPAEKAKKGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3498430", Offset = "0x3496C30", VA = "0x183498430", Slot = "9")]
	public Task<(IDIFMABCDLA, Task)> PDGJMOLMFLF(Guid PALLEDHBFCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x34972C0", Offset = "0x3495AC0", VA = "0x1834972C0")]
	private void ACCPDGFAFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x34984C0", Offset = "0x3496CC0", VA = "0x1834984C0")]
	public OPLKMJPGMHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class FFJLHIIMOFL : KBIEMNNHIEA, BEIIGIJBNMM, CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class GKKBEOKCBCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public IDIFMABCDLA result;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GKKBEOKCBCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x496D240", Offset = "0x496BA40", VA = "0x18496D240")]
		internal object ALMDFNLKKMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2D999D0", Offset = "0x2D981D0", VA = "0x182D999D0")]
	[UnityEngine.Scripting.Preserve]
	public FFJLHIIMOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2D99840", Offset = "0x2D98040", VA = "0x182D99840", Slot = "8")]
	public IDIFMABCDLA IGGGLNHPCKG(IGGCDPKBFGF ACJGGEOLANN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal interface LKGOGFHLDFK : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	TaskStatus HEHIDPGEMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MHKIGANIEGO(MHKEFJDKLJN FKMIOMCKJNF, OAEILIIIPED LBJHHPLDPCI, CancellationToken KHEICKPBIBD);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal static class IGKJGLPENOO
{
	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2DAA150", Offset = "0x2DA8950", VA = "0x182DAA150")]
	public static bool KADKOGACMKG(this LKGOGFHLDFK HBHHBLLKCLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal static class GLFEJKNHJJP
{
	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2DA33F0", Offset = "0x2DA1BF0", VA = "0x182DA33F0")]
	public static string OFFBBLKFMFL(this MHKEFJDKLJN BIJBNMHAAEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3360", Offset = "0x2DA1B60", VA = "0x182DA3360")]
	public static bool ANNNHOHBBHJ(this MHKEFJDKLJN BIJBNMHAAEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[UnityEngine.Scripting.Preserve]
internal class GBIMIGMJJBK : LFPKDNNPHDE, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class PDCGGKLMGEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public GBIMIGMJJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public PDCGGKLMGEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x4975BC0", Offset = "0x49743C0", VA = "0x184975BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class HAFNPGEIJOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public GBIMIGMJJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private bool <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HAFNPGEIJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x496D2A0", Offset = "0x496BAA0", VA = "0x18496D2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class EDINKMJPCLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public EDINKMJPCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x496A000", Offset = "0x4968800", VA = "0x18496A000")]
		internal object LMCIPKIPBCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class DFNOODHGIEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public GBIMIGMJJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private EDINKMJPCLP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private HMAILMDEICE <provider>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DFNOODHGIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x4967AD0", Offset = "0x49662D0", VA = "0x184967AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class GEJLAEHLBHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GEJLAEHLBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x496BB40", Offset = "0x496A340", VA = "0x18496BB40")]
		internal object DJBENOEIEAM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private HMAILMDEICE[] HNAJPCAIOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private CancellationTokenSource MFGBDLCLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private int ABAHDMMJMOJ;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2DA02F0", Offset = "0x2D9EAF0", VA = "0x182DA02F0", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F560", Offset = "0x2D9DD60", VA = "0x182D9F560", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F850", Offset = "0x2D9E050", VA = "0x182D9F850", Slot = "6")]
	public void IHLPPHPEFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F2F0", Offset = "0x2D9DAF0", VA = "0x182D9F2F0", Slot = "5")]
	public void DEAHNGCCEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F9E0", Offset = "0x2D9E1E0", VA = "0x182D9F9E0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDCGGKLMGEN))]
	public Task JHKFDEFLOCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D9FC50", Offset = "0x2D9E450", VA = "0x182D9FC50")]
	private void NCLKBMEBDPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F570", Offset = "0x2D9DD70", VA = "0x182D9F570")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HAFNPGEIJOK))]
	private Task GKILPCLEHMP(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F6C0", Offset = "0x2D9DEC0", VA = "0x182D9F6C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DFNOODHGIEH))]
	private Task<bool> HOCEBFKAOGC(int NHHNPPKPBIA, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0190", Offset = "0x2D9E990", VA = "0x182DA0190")]
	private void NNCIEJCOMBA(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D9FB00", Offset = "0x2D9E300", VA = "0x182D9FB00")]
	private void KBPKOBDJBJP(int NHHNPPKPBIA, bool GGKLFMPBGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D9FFD0", Offset = "0x2D9E7D0", VA = "0x182D9FFD0")]
	private void NDBCEBKOCNP(int NHHNPPKPBIA, Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F450", Offset = "0x2D9DC50", VA = "0x182D9F450")]
	private void DIHPGJDHNEM(CancellationToken GFFFFCALMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0370", Offset = "0x2D9EB70", VA = "0x182DA0370")]
	public GBIMIGMJJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class AKHFFEBLFLI
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D8FE00", Offset = "0x2D8E600", VA = "0x182D8FE00")]
	public static void LODDLPCJOOC(this EPJFONLPCOB EKLPJDMGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D8FE10", Offset = "0x2D8E610", VA = "0x182D8FE10")]
	public static void NMEJOAFIBFD(this EPJFONLPCOB EKLPJDMGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D8FCF0", Offset = "0x2D8E4F0", VA = "0x182D8FCF0")]
	private static void DEMANJMNJMK(this EPJFONLPCOB EKLPJDMGHDM, bool JKOLNMIPLMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public struct POFGIICIGOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public readonly MCJHCEJFKNC JOOMDEJHLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public readonly string KJLGHJOMLJO;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x349ADB0", Offset = "0x34995B0", VA = "0x18349ADB0")]
	public POFGIICIGOD(string GPMCGMIFIIK, MCJHCEJFKNC EGMEOIADPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x349AD30", Offset = "0x3499530", VA = "0x18349AD30")]
	public string MOMBAAMFHDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x349AC90", Offset = "0x3499490", VA = "0x18349AC90")]
	public string GCAPBBHFANN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public delegate string FKAEOHGBIDG<in T>(T BPFOEEABMGN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public delegate int LIFHOMMNNKM<in T>(T BPFOEEABMGN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class HNGHLPCGIPA : PILPGHODDIG
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private delegate string BHEDJILKDMB(Exception BPFOEEABMGN);

	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private delegate int PHFOMAFIOLI(Exception BPFOEEABMGN);

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class PJAFKBFIKAK<T> : global::BBJCLIHKHGE<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class AIFOCMFFCDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
			public AIFOCMFFCDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
			internal string KCJDHMJIJPJ(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class BNKJALMFEED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78D5E0", Offset = "0x78C9E0")]
			public global::FKAEOHGBIDG<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
			public BNKJALMFEED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x2EFE260", Offset = "0x2EFCA60", VA = "0x182EFE260")]
			internal string BAMOKCHGGHH(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private sealed class MIIBBHMOKKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public int subCode;

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
			public MIIBBHMOKKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
			internal int DGFHLAPIJNB(Exception _)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		[CompilerGenerated]
		private sealed class ONCOAGHDDEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78D640", Offset = "0x78CA40")]
			public global::LIFHOMMNNKM<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
			public ONCOAGHDDEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x2EFE260", Offset = "0x2EFCA60", VA = "0x182EFE260")]
			internal int DJINAFDOFII(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private readonly HNGHLPCGIPA DCLPNPGHFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private readonly Type IHOHJBKPLGC;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x3D58370", Offset = "0x3D56B70", VA = "0x183D58370")]
		internal PJAFKBFIKAK(HNGHLPCGIPA DCLPNPGHFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x3D58220", Offset = "0x3D56A20", VA = "0x183D58220", Slot = "4")]
		public void OFKKPAPNNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x3D58120", Offset = "0x3D56920", VA = "0x183D58120", Slot = "5")]
		public global::BBJCLIHKHGE<T> MNONDJFMJHF(string LJGKGILKHCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x3D57F10", Offset = "0x3D56710", VA = "0x183D57F10", Slot = "6")]
		public global::BBJCLIHKHGE<T> IPJKAHEAOIN(global::FKAEOHGBIDG<T> EMJBJKKPMII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x3D57ED0", Offset = "0x3D566D0", VA = "0x183D57ED0", Slot = "7")]
		public global::BBJCLIHKHGE<T> DJLCCKADJOD(int EGMEOIADPFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x3D58010", Offset = "0x3D56810", VA = "0x183D58010", Slot = "8")]
		public global::BBJCLIHKHGE<T> JPCCKFPDCIL(int EGMEOIADPFI, int IEPBGECFBIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x3D58250", Offset = "0x3D56A50", VA = "0x183D58250", Slot = "9")]
		public global::BBJCLIHKHGE<T> OMLFADBINCK(int EGMEOIADPFI, global::LIFHOMMNNKM<T> HGLLKEAJGLO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	private class IEPENJPADNO<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private bool FICLLNGHBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private readonly List<Type> LKDHDKJNCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private readonly Dictionary<Type, TVal> HFKHBPEFOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private readonly Dictionary<Type, int> CFFFABPLIPM;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public IReadOnlyList<Type> GDALLGCOGJN
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x1CA1B40", Offset = "0x1CA0340", VA = "0x181CA1B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1CA1E10", Offset = "0x1CA0610", VA = "0x181CA1E10")]
		public IEPENJPADNO(Dictionary<Type, int> CFFFABPLIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1CA1890", Offset = "0x1CA0090", VA = "0x181CA1890")]
		public void CAILCKFFJIK(Type BDFCACLHAFA, TVal FOHLJCNEPNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1CA1CC0", Offset = "0x1CA04C0", VA = "0x181CA1CC0")]
		public bool PBFMMEHNOBJ(Type IHOHJBKPLGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1CA19D0", Offset = "0x1CA01D0", VA = "0x181CA19D0")]
		public bool EJCEIGEMLDE(TVal ECNGHFJBIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1CA1CF0", Offset = "0x1CA04F0", VA = "0x181CA1CF0")]
		public TVal PNBJHLBKMLC(Type FIJCKHKKDCC)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1CA1AA0", Offset = "0x1CA02A0", VA = "0x181CA1AA0")]
		[CompilerGenerated]
		private int FKBJGNIOBJL(Type IAKDHNCLOEJ, Type OHFJGMKOBJC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private sealed class KGPFLGOIIHE : IEnumerable<MCJHCEJFKNC>, IEnumerable, IEnumerator<MCJHCEJFKNC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private MCJHCEJFKNC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public HNGHLPCGIPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private AggregateException <aggregateException>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private IEnumerator<Exception> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private Exception <innerException>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private IEnumerator<MCJHCEJFKNC> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private MCJHCEJFKNC <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private MCJHCEJFKNC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x14321C0", Offset = "0x14309C0", VA = "0x1814321C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MCJHCEJFKNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x42B5730", Offset = "0x42B3F30", VA = "0x1842B5730", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xB955D0", Offset = "0xB93DD0", VA = "0x180B955D0")]
		[DebuggerHidden]
		public KGPFLGOIIHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x42B5780", Offset = "0x42B3F80", VA = "0x1842B5780", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x42B51D0", Offset = "0x42B39D0", VA = "0x1842B51D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x42B5180", Offset = "0x42B3980", VA = "0x1842B5180")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x42B55F0", Offset = "0x42B3DF0", VA = "0x1842B55F0")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x42B56F0", Offset = "0x42B3EF0", VA = "0x1842B56F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x42B5640", Offset = "0x42B3E40", VA = "0x1842B5640", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MCJHCEJFKNC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x42B5640", Offset = "0x42B3E40", VA = "0x1842B5640", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	internal const int AFFEALLLJLD = 8700;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private static readonly MCJHCEJFKNC ALHDEFACHLC;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	internal const string FCLEPJLHPJG = "Unknown error loading room";

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	internal const int NBDHGAEMHCP = 8708;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private static readonly Dictionary<Type, int> NOKKENMNDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private readonly HashSet<Type> HGPAECGPHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly IEPENJPADNO<int> IOOKCCHDBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private readonly IEPENJPADNO<PHFOMAFIOLI> NJOGKJHBBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly IEPENJPADNO<BHEDJILKDMB> FFOIOJEFLDF;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8AF0", Offset = "0x2DA72F0", VA = "0x182DA8AF0")]
	[BBAPFPLPODF(EDNJEIFHIMJ.GameOnly)]
	private static void LECKBAIJAMJ(MHOBEFMLEFD EOOGCBGOIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8F00", Offset = "0x2DA7700", VA = "0x182DA8F00")]
	[RecRoom.NoEngine.Common.Preserve]
	public HNGHLPCGIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2325260", Offset = "0x2323A60", VA = "0x182325260", Slot = "4")]
	public global::BBJCLIHKHGE<T> JDOICDLJCNN<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2DA83A0", Offset = "0x2DA6BA0", VA = "0x182DA83A0", Slot = "5")]
	public POFGIICIGOD DBBGDMPPFKL(Exception BPFOEEABMGN)
	{
		return default(POFGIICIGOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8460", Offset = "0x2DA6C60", VA = "0x182DA8460", Slot = "6")]
	public MCJHCEJFKNC EEBNDIDCOOC(Exception? BPFOEEABMGN)
	{
		return default(MCJHCEJFKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x2DA80D0", Offset = "0x2DA68D0", VA = "0x182DA80D0", Slot = "7")]
	[IteratorStateMachine(typeof(KGPFLGOIIHE))]
	public IEnumerable<MCJHCEJFKNC> CKGHHAFBMBP(Exception BPFOEEABMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8B60", Offset = "0x2DA7360", VA = "0x182DA8B60", Slot = "8")]
	public string NPENLAPPDKC(Exception? BPFOEEABMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8770", Offset = "0x2DA6F70", VA = "0x182DA8770")]
	private string IDANJPLNFHD(AggregateException EIOBGNABOHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x2DA7D30", Offset = "0x2DA6530", VA = "0x182DA7D30")]
	private void CDNAIFFDCDP(Type IHOHJBKPLGC, int EGMEOIADPFI, PHFOMAFIOLI? JIJNHOFBOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8160", Offset = "0x2DA6960", VA = "0x182DA8160")]
	private void CMHCMNHACDK(Type IHOHJBKPLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2DA7A70", Offset = "0x2DA6270", VA = "0x182DA7A70")]
	private void AGNOJODIJIO(Type IHOHJBKPLGC, BHEDJILKDMB ABLIDJBMNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8CA0", Offset = "0x2DA74A0", VA = "0x182DA8CA0")]
	private static int PONDELGGKKB(Type IHOHJBKPLGC, Dictionary<Type, int> CFFFABPLIPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD0D0", Offset = "0x2DDB8D0", VA = "0x182DDD0D0")]
	private static bool NAKJALEKHHL<TVal>(IEPENJPADNO<TVal> EFLCMDHDGNO, Type IHOHJBKPLGC, out TVal ECNGHFJBIJL) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8680", Offset = "0x2DA6E80", VA = "0x182DA8680")]
	[CompilerGenerated]
	internal static int FFFICNEALGN(Type APFMAJJJHIL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public struct MCJHCEJFKNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public readonly int PBLPFCGODJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public readonly int? PMFILMJGPLD;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x231BFD0", Offset = "0x231A7D0", VA = "0x18231BFD0")]
	public MCJHCEJFKNC(int ALCHPPPJPLL, [Optional] int? IEPBGECFBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x348D020", Offset = "0x348B820", VA = "0x18348D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface PILPGHODDIG
{
	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::BBJCLIHKHGE<T> JDOICDLJCNN<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "1")]
	POFGIICIGOD DBBGDMPPFKL(Exception BPFOEEABMGN);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MCJHCEJFKNC EEBNDIDCOOC(Exception BPFOEEABMGN);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<MCJHCEJFKNC> CKGHHAFBMBP(Exception BPFOEEABMGN);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string NPENLAPPDKC(Exception BPFOEEABMGN);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public interface BBJCLIHKHGE<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFKKPAPNNEP();

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BBJCLIHKHGE<T> MNONDJFMJHF(string LJGKGILKHCG);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::BBJCLIHKHGE<T> IPJKAHEAOIN(global::FKAEOHGBIDG<T> EMJBJKKPMII);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::BBJCLIHKHGE<T> DJLCCKADJOD(int EGMEOIADPFI);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::BBJCLIHKHGE<T> JPCCKFPDCIL(int EGMEOIADPFI, int IEPBGECFBIF);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::BBJCLIHKHGE<T> OMLFADBINCK(int EGMEOIADPFI, global::LIFHOMMNNKM<T> HGLLKEAJGLO);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class PLKPJMGBMCG
{
	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x3499D00", Offset = "0x3498500", VA = "0x183499D00")]
	[BBAPFPLPODF(EDNJEIFHIMJ.GameOnly)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD EOOGCBGOIGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface HCKACEFMPCF : IEquatable<HCKACEFMPCF>
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	DateTime NAHEEPGPOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOGFBGPCJFE();

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OODKEBIOIGI(long HAMIEGOKEJC, long BPODGJMCBKI, out EJCOGPHMIIO NNIPLGKEGFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal class PLNJOEPHKBI : LCAFMEKLLGH
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class ILAJAIKNOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ILAJAIKNOAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class LMEMCAGEHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public ILAJAIKNOAM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LMEMCAGEHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x597D420", Offset = "0x597BC20", VA = "0x18597D420")]
		internal object MAJIHGKLAPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly GFOFIPPNDLA JDHPBKJGAKB;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private const int FOGLCLBBAPI = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<HCKACEFMPCF> APNHNBKPOIP
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x349A020", Offset = "0x3498820", VA = "0x18349A020", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x349A170", Offset = "0x3498970", VA = "0x18349A170", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD20", Offset = "0x8AB520", VA = "0x1808ACD20")]
	[UnityEngine.Scripting.Preserve]
	public PLNJOEPHKBI([ACEKLAKDMBL(null)] GFOFIPPNDLA JDHPBKJGAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x349A820", Offset = "0x3499020", VA = "0x18349A820", Slot = "6")]
	public bool NECCIEOBFKO(long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ, NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x349A780", Offset = "0x3498F80", VA = "0x18349A780")]
	private void JPIBCGPDDPM(HCKACEFMPCF IPKBJACGFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x349A600", Offset = "0x3498E00", VA = "0x18349A600", Slot = "7")]
	public bool JLPGPOOMIFG(long HAMIEGOKEJC, long BPODGJMCBKI, out HCKACEFMPCF ANGBHDDNJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x349A0C0", Offset = "0x34988C0", VA = "0x18349A0C0", Slot = "8")]
	public bool DGKKMEKKLFM(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, out HCKACEFMPCF ANGBHDDNJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x349A210", Offset = "0x3498A10", VA = "0x18349A210")]
	private void HANDJCNDOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x349AB70", Offset = "0x3499370", VA = "0x18349AB70", Slot = "9")]
	public void NIGPPAMDDAN(long HAMIEGOKEJC, long BPODGJMCBKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public enum KEFDFHALGBD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal sealed class JDGNMBGDALO : ANAIMAOJPDB
{
	[Cpp2IlInjected.Token(Token = "0x4000374")]
	private static readonly byte[] BDFCACLHAFA;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	private const string DGDMFPEBCOO = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	private const string CODHELJOPDL = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private const string OBHHBBFHABC = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private readonly byte[] IIKMCOGMLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private readonly byte[] GDHEFGLCJLB;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public override KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x9EA910", Offset = "0x9E9110", VA = "0x1809EA910", Slot = "8")]
		get
		{
			return default(KEFDFHALGBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD200", Offset = "0x2DABA00", VA = "0x182DAD200")]
	public JDGNMBGDALO([Optional] string OCNGBBKIHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2DACB50", Offset = "0x2DAB350", VA = "0x182DACB50", Slot = "9")]
	internal override void IHGHDLEMING(Stream KLJHBBOMDPF, long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC270", Offset = "0x2DAAA70", VA = "0x182DAC270", Slot = "10")]
	internal override bool FDCEHBPPHBP(Stream AADDFDBIEHK, long HAMIEGOKEJC, long BPODGJMCBKI, NAFNDJJJCJL PPBPOHDFOAA, out EJCOGPHMIIO NNIPLGKEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2DACE20", Offset = "0x2DAB620", VA = "0x182DACE20")]
	private void IKFDOOENNCH(byte[] ENEAOCDMOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2DACF30", Offset = "0x2DAB730", VA = "0x182DACF30", Slot = "11")]
	protected override FileInfo LPAKNDMHHJP(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD060", Offset = "0x2DAB860", VA = "0x182DAD060", Slot = "12")]
	protected override DirectoryInfo PLFMCDHHBCL(NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal class ENLFGFJFMAL : ANAIMAOJPDB
{
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private const string KMHBNCMOHDN = "V2";

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private const string DGDMFPEBCOO = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private const string CODHELJOPDL = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public override KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x17ED1C0", Offset = "0x17EB9C0", VA = "0x1817ED1C0", Slot = "8")]
		get
		{
			return default(KEFDFHALGBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2D980D0", Offset = "0x2D968D0", VA = "0x182D980D0")]
	public ENLFGFJFMAL([Optional] string OCNGBBKIHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2D97BB0", Offset = "0x2D963B0", VA = "0x182D97BB0")]
	private void HFHGPDNAOIF(NFBLDIHAPOJ GJGJDNGPKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x2D97C40", Offset = "0x2D96440", VA = "0x182D97C40", Slot = "9")]
	internal override void IHGHDLEMING(Stream KLJHBBOMDPF, long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2D97530", Offset = "0x2D95D30", VA = "0x182D97530", Slot = "10")]
	internal override bool FDCEHBPPHBP(Stream AADDFDBIEHK, long HAMIEGOKEJC, long BPODGJMCBKI, NAFNDJJJCJL PPBPOHDFOAA, out EJCOGPHMIIO NNIPLGKEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2D97ED0", Offset = "0x2D966D0", VA = "0x182D97ED0", Slot = "11")]
	protected override FileInfo LPAKNDMHHJP(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x2D97FC0", Offset = "0x2D967C0", VA = "0x182D97FC0", Slot = "12")]
	protected override DirectoryInfo PLFMCDHHBCL(NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal abstract class ANAIMAOJPDB : GFOFIPPNDLA
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	protected enum NMAAMKHLHLG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class JIADGPIKPFP : IEnumerable<HCKACEFMPCF>, IEnumerable, IEnumerator<HCKACEFMPCF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private HCKACEFMPCF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public NFBLDIHAPOJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public ANAIMAOJPDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private DirectoryInfo <autosaveDirectory>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private FileInfo[] <files>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private FileInfo[] <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private FileInfo <file>5__5;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private HCKACEFMPCF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xB955D0", Offset = "0xB93DD0", VA = "0x180B955D0")]
		[DebuggerHidden]
		public JIADGPIKPFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x3485480", Offset = "0x3483C80", VA = "0x183485480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x34857A0", Offset = "0x3483FA0", VA = "0x1834857A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x34856F0", Offset = "0x3483EF0", VA = "0x1834856F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HCKACEFMPCF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x34856F0", Offset = "0x3483EF0", VA = "0x1834856F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class COCKNNNFBPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public COCKNNNFBPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x3482640", Offset = "0x3480E40", VA = "0x183482640")]
		internal object DDNCFPLJPHH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class NJMOBPAAEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public ANAIMAOJPDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NJMOBPAAEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x3491070", Offset = "0x348F870", VA = "0x183491070")]
		internal void GFHMNIEDHJE(CAIMCDALKCM.KILBMHIFLCG ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	protected readonly string GGPDPGDFDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private readonly object CBCJPCHPPCF;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public abstract KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x2D90E90", Offset = "0x2D8F690", VA = "0x182D90E90")]
	protected ANAIMAOJPDB([CanBeNull] string OCNGBBKIHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x2D90660", Offset = "0x2D8EE60", VA = "0x182D90660", Slot = "5")]
	public bool AKHOODPCDID(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, out HCKACEFMPCF IPKBJACGFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x2D90E10", Offset = "0x2D8F610", VA = "0x182D90E10", Slot = "6")]
	[IteratorStateMachine(typeof(JIADGPIKPFP))]
	public IEnumerable<HCKACEFMPCF> LFJJEAPOAKA(NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void IHGHDLEMING(Stream KLJHBBOMDPF, long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool FDCEHBPPHBP(Stream AADDFDBIEHK, long HAMIEGOKEJC, long BPODGJMCBKI, NAFNDJJJCJL PPBPOHDFOAA, out EJCOGPHMIIO NNIPLGKEGFJ);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x2D90B30", Offset = "0x2D8F330", VA = "0x182D90B30", Slot = "7")]
	public HCKACEFMPCF FPLPAECHFDP(long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ, NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo LPAKNDMHHJP(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo PLFMCDHHBCL(NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2D90AC0", Offset = "0x2D8F2C0", VA = "0x182D90AC0")]
	protected void DPDGGJOMCGI(CAIMCDALKCM.KILBMHIFLCG BMNHBAEKDJF, string BAMBEECFNAE, FileInfo FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2D90810", Offset = "0x2D8F010", VA = "0x182D90810")]
	internal bool BEPEKNNMMCD(FileInfo CLHKKIBAGBL, long HAMIEGOKEJC, long BPODGJMCBKI, out EJCOGPHMIIO NNIPLGKEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	private void GGEJJPKENJD(Exception LNDIIAIJNMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal interface GFOFIPPNDLA
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AKHOODPCDID(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, out HCKACEFMPCF IPKBJACGFCO);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<HCKACEFMPCF> LFJJEAPOAKA(NFBLDIHAPOJ GJGJDNGPKAK);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HCKACEFMPCF FPLPAECHFDP(long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ, NFBLDIHAPOJ GJGJDNGPKAK);
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal class MEGOIKJNOJE : GFOFIPPNDLA
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class KHPAOJHDIFE : IEnumerable<HCKACEFMPCF>, IEnumerable, IEnumerator<HCKACEFMPCF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private HCKACEFMPCF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public NFBLDIHAPOJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public MEGOIKJNOJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private KEFDFHALGBD[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private KEFDFHALGBD <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private GFOFIPPNDLA <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private IEnumerable<HCKACEFMPCF> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private IEnumerator<HCKACEFMPCF> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private HCKACEFMPCF <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private HCKACEFMPCF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xB955D0", Offset = "0xB93DD0", VA = "0x180B955D0")]
		[DebuggerHidden]
		public KHPAOJHDIFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x597C0A0", Offset = "0x597A8A0", VA = "0x18597C0A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x597BC60", Offset = "0x597A460", VA = "0x18597BC60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x597BC10", Offset = "0x597A410", VA = "0x18597BC10")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x597C060", Offset = "0x597A860", VA = "0x18597C060", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x597BFB0", Offset = "0x597A7B0", VA = "0x18597BFB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HCKACEFMPCF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x597BFB0", Offset = "0x597A7B0", VA = "0x18597BFB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private readonly KEFDFHALGBD[] JCKIOCFKJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private readonly Dictionary<KEFDFHALGBD, GFOFIPPNDLA> NOJPIBMPNCI;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x348DEE0", Offset = "0x348C6E0", VA = "0x18348DEE0", Slot = "4")]
		get
		{
			return default(KEFDFHALGBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x348E160", Offset = "0x348C960", VA = "0x18348E160")]
	[UnityEngine.Scripting.Preserve]
	public MEGOIKJNOJE(params GFOFIPPNDLA[] BMGONLEPFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x348DC10", Offset = "0x348C410", VA = "0x18348DC10", Slot = "5")]
	public bool AKHOODPCDID(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, out HCKACEFMPCF IPKBJACGFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x348DF20", Offset = "0x348C720", VA = "0x18348DF20")]
	private void MNLAMOGCOHJ(int HDCGHJJAEJH, long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x348DE60", Offset = "0x348C660", VA = "0x18348DE60", Slot = "6")]
	[IteratorStateMachine(typeof(KHPAOJHDIFE))]
	public IEnumerable<HCKACEFMPCF> LFJJEAPOAKA(NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x348DD70", Offset = "0x348C570", VA = "0x18348DD70", Slot = "7")]
	public HCKACEFMPCF FPLPAECHFDP(long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ, NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal static class ILPADHPMCMF
{
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	internal const int LIKHOLMOGCI = 32;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB7A0", Offset = "0x2DA9FA0", VA = "0x182DAB7A0")]
	internal static byte[] LIJKACPPNKD(byte[] ENEAOCDMOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB720", Offset = "0x2DA9F20", VA = "0x182DAB720")]
	public static void KJMEKNOJFLL(Stream NEOJHOCIJKI, byte[] KAMCEBCIEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB540", Offset = "0x2DA9D40", VA = "0x182DAB540")]
	public static bool GJAJGCIGAPI(Stream NEOJHOCIJKI, long CBKDEHFIPHJ, NAFNDJJJCJL MOJOLKEAMOM, out byte[] EOEHMAFBCHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public delegate void NAFNDJJJCJL(CAIMCDALKCM.KILBMHIFLCG JPIEJIAKMEN, string DKIECHCHJFL);
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal sealed class POIPJLMNDLN : HCKACEFMPCF, IEquatable<HCKACEFMPCF>, IEquatable<POIPJLMNDLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	private readonly ANAIMAOJPDB DFELGBGBDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly FileInfo OJIJENHCKAD;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xE50790", Offset = "0xE4EF90", VA = "0x180E50790", Slot = "4")]
		get
		{
			return default(KEFDFHALGBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public DateTime NAHEEPGPOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x349ADD0", Offset = "0x34995D0", VA = "0x18349ADD0", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x349B340", Offset = "0x3499B40", VA = "0x18349B340")]
	public POIPJLMNDLN(ANAIMAOJPDB ELFANDMPEIC, FileInfo CLHKKIBAGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x349B290", Offset = "0x3499A90", VA = "0x18349B290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x349B1E0", Offset = "0x34999E0", VA = "0x18349B1E0", Slot = "6")]
	public void OOGFBGPCJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x349B1A0", Offset = "0x34999A0", VA = "0x18349B1A0", Slot = "7")]
	public bool OODKEBIOIGI(long HAMIEGOKEJC, long BPODGJMCBKI, out EJCOGPHMIIO NNIPLGKEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x349B020", Offset = "0x3499820", VA = "0x18349B020", Slot = "8")]
	public bool Equals(HCKACEFMPCF MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x349AF70", Offset = "0x3499770", VA = "0x18349AF70", Slot = "9")]
	public bool Equals(POIPJLMNDLN MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x349AE70", Offset = "0x3499670", VA = "0x18349AE70", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x349B100", Offset = "0x3499900", VA = "0x18349B100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x1949400", Offset = "0x1947C00", VA = "0x181949400")]
	public static bool FMMDKFLNNFA(POIPJLMNDLN FDMHBFLJJHC, POIPJLMNDLN DNGDHCADJJH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x1948FD0", Offset = "0x19477D0", VA = "0x181948FD0")]
	public static bool BDPOAMCDIDB(POIPJLMNDLN FDMHBFLJJHC, POIPJLMNDLN DNGDHCADJJH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct IDIAHGMFNCH
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class EDJJICHBNBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private IFNNJAAOEDN <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private AALOEEPNEOP <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public EDJJICHBNBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x42AE6F0", Offset = "0x42ACEF0", VA = "0x1842AE6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9FB0", Offset = "0x2DA87B0", VA = "0x182DA9FB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDJJICHBNBB))]
	public static Task EBDHDHCPNAJ(DNKNJNMAMBL GIOAKJNONKE, MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal struct JMCMENJMMNC
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class OCNOGDHDBAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public OOCGABPOHBK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private IFNNJAAOEDN <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private HBPPPIGEKFO <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private HBHNCFJCIKF <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private List<(PersistenceView, HGNMPOIAAKI)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private HGNMPOIAAKI <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OCNOGDHDBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x42BA980", Offset = "0x42B9180", VA = "0x1842BA980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD350", Offset = "0x2DABB50", VA = "0x182DAD350")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OCNOGDHDBAP))]
	public static Task EBDHDHCPNAJ(OOCGABPOHBK CDJHLNAAHGK, MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal struct DJCJAIPOLNB
{
	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0")]
	public static DJCJAIPOLNB JLAKJAPJOGA()
	{
		return default(DJCJAIPOLNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void PHOGHLAAEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void NNBMICFFJJF(MOMCOKAPMLC PHBHEFAPHDL, object EJFGMPEJEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void KECDHBFGDIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal struct BAIOMEALKFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x2D91230", Offset = "0x2D8FA30", VA = "0x182D91230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x2D90F20", Offset = "0x2D8F720", VA = "0x182D90F20")]
	public static Task EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D90FC0", Offset = "0x2D8F7C0", VA = "0x182D90FC0")]
	private void EBDHDHCPNAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class HALPBDECPOJ : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class HOOOOLJDKPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public HALPBDECPOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private ODEOHNPPJCE <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private GEDJHDMKMOJ <serializeType>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private EJCOGPHMIIO <data>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EJCOGPHMIIO <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private TaskAwaiter<EJCOGPHMIIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HOOOOLJDKPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x42B1420", Offset = "0x42AFC20", VA = "0x1842B1420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly string OMCOJEIPFBM;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5890", Offset = "0x2DA4090", VA = "0x182DA5890")]
	public HALPBDECPOJ(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, string OMCOJEIPFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2DA56F0", Offset = "0x2DA3EF0", VA = "0x182DA56F0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HOOOOLJDKPK))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class FGCIPEMNFIB
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class FPFKGKIMLDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public FEEJMENJLIJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public MOMCOKAPMLC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FPFKGKIMLDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x496B7B0", Offset = "0x4969FB0", VA = "0x18496B7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class HOKBGJMLPJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HOKBGJMLPJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class AEFOMBJCECP
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		private sealed class <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public AEFOMBJCECP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x59809A0", Offset = "0x597F1A0", VA = "0x1859809A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public AALOEEPNEOP handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public HOKBGJMLPJO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AEFOMBJCECP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x4962C40", Offset = "0x4961440", VA = "0x184962C40")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task GFHFLIFEECL(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class EDMFOCENIMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private HOKBGJMLPJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private AEFOMBJCECP <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public EDMFOCENIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x496A070", Offset = "0x4968870", VA = "0x18496A070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class IKAMJMIHKMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private AALOEEPNEOP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private Dictionary<Guid, List<LOHABELNFDM>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private KeyValuePair<Guid, List<LOHABELNFDM>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IKAMJMIHKMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x496ED30", Offset = "0x496D530", VA = "0x18496ED30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class MFABEIDHFNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private EPJFONLPCOB <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private AALOEEPNEOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private Dictionary<Guid, List<LOHABELNFDM>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private KeyValuePair<Guid, List<LOHABELNFDM>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MFABEIDHFNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x4973090", Offset = "0x4971890", VA = "0x184973090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class FHANDLFJBHN
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private sealed class <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			public LOHABELNFDM handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public FHANDLFJBHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0x597E1A0", Offset = "0x597C9A0", VA = "0x18597E1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public CCBIIAGKKBF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public List<LOHABELNFDM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FHANDLFJBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x496AAE0", Offset = "0x49692E0", VA = "0x18496AAE0")]
		internal object OOCPHPCALMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x496A990", Offset = "0x4969190", VA = "0x18496A990")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task LJMLNNODJOI(LOHABELNFDM handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x496A8A0", Offset = "0x49690A0", VA = "0x18496A8A0")]
		internal object FGFDNIDPODJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class KAEGMPFOKFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public List<LOHABELNFDM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public CCBIIAGKKBF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private FHANDLFJBHN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private IEnumerable<Task> <handlerTasks>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KAEGMPFOKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x4970F30", Offset = "0x496F730", VA = "0x184970F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class DPLDGBHGKKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DPLDGBHGKKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x49688F0", Offset = "0x49670F0", VA = "0x1849688F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class FKHADMDJNNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FKHADMDJNNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x496B1A0", Offset = "0x49699A0", VA = "0x18496B1A0")]
		internal object JCIHNDINDGA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class DGFHLDINIPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private FKHADMDJNNJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private EPJFONLPCOB <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private List<LOHABELNFDM> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DGFHLDINIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x4968050", Offset = "0x4966850", VA = "0x184968050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class FKODLABGDGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FKODLABGDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x496B210", Offset = "0x4969A10", VA = "0x18496B210")]
		internal object IDJGMCAOGCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class GICFOPPJBMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private FKODLABGDGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private FHMBHNPINBI <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private FHMBHNPINBI <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private FHMBHNPINBI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GICFOPPJBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x496BD90", Offset = "0x496A590", VA = "0x18496BD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class JEFJPLMMIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JEFJPLMMIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x496FE10", Offset = "0x496E610", VA = "0x18496FE10")]
		internal object CIGJJJMKAON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private NHOCFNNGHPA PDJAPHGOJJO;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private OOCGABPOHBK JMLCEDJKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA89C90", Offset = "0xA88490", VA = "0x180A89C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD20", Offset = "0x8AB520", VA = "0x1808ACD20")]
	public FGCIPEMNFIB(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2D99D50", Offset = "0x2D98550", VA = "0x182D99D50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPFKGKIMLDE))]
	public Task EBDHDHCPNAJ(FEEJMENJLIJ ANPIEEIPNGA, MOMCOKAPMLC LPFGOIILFCI, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A5E0", Offset = "0x2D98DE0", VA = "0x182D9A5E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDMFOCENIMJ))]
	private Task MDBDAHGPHLI(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A780", Offset = "0x2D98F80", VA = "0x182D9A780")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKAMJMIHKMJ))]
	private Task NFEOFNICAPL(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A920", Offset = "0x2D99120", VA = "0x182D9A920")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFABEIDHFNA))]
	private Task ODLJCAKAKJF(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2D99A50", Offset = "0x2D98250", VA = "0x182D99A50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KAEGMPFOKFN))]
	private Task BADLLBBHBPG(Guid LHPBOIAGPAE, List<LOHABELNFDM> AGGDAPBJMLG, CCBIIAGKKBF KGEBDJDHLNM, MOMCOKAPMLC PHBHEFAPHDL, CancellationToken FLDJLPKNKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2D9AC90", Offset = "0x2D99490", VA = "0x182D9AC90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPLDGBHGKKI))]
	private Task PGNMNKPPBNP(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A0B0", Offset = "0x2D988B0", VA = "0x182D9A0B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DGFHLDINIPD))]
	private Task INKOGJEKMAK(Guid HFCGDHHIMNG, MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x2D99F10", Offset = "0x2D98710", VA = "0x182D99F10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GICFOPPJBMK))]
	private Task HNEFEANOHEL(Guid HFCGDHHIMNG, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A440", Offset = "0x2D98C40", VA = "0x182D9A440")]
	private void LFPLGDKICKH(Guid HFCGDHHIMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x2D99C20", Offset = "0x2D98420", VA = "0x182D99C20")]
	private void DFKPCMHLPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A270", Offset = "0x2D98A70", VA = "0x182D9A270")]
	public Guid KHIPIIGIPHJ(FEEJMENJLIJ JCEEBLIDOHD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2D9AAC0", Offset = "0x2D992C0", VA = "0x182D9AAC0")]
	[CompilerGenerated]
	private object OKHGFMAGDMG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
internal struct HPDLGGGIPCI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly Guid DGPMAIKFGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private bool GGKLFMPBGIO;

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9700", Offset = "0x2DA7F00", VA = "0x182DA9700")]
	public static HPDLGGGIPCI HMNMIJCBGAE(DNKNJNMAMBL GIOAKJNONKE)
	{
		return default(HPDLGGGIPCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x19EC730", Offset = "0x19EAF30", VA = "0x1819EC730")]
	public void GCNHMDLKOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9300", Offset = "0x2DA7B00", VA = "0x182DA9300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9760", Offset = "0x2DA7F60", VA = "0x182DA9760")]
	private HPDLGGGIPCI(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9310", Offset = "0x2DA7B10", VA = "0x182DA9310")]
	private void FNEOFEGLMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9650", Offset = "0x2DA7E50", VA = "0x182DA9650")]
	private Func<Guid, bool> GGOOKBJFPAH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal struct GHMJGCHLAMJ
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class OCAPNIKIGKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public AsyncTaskMethodBuilder<HOAOFNBBEKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public GHMJGCHLAMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private AALOEEPNEOP <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private HOAOFNBBEKI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private TaskAwaiter<HOAOFNBBEKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OCAPNIKIGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x49742C0", Offset = "0x4972AC0", VA = "0x1849742C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class CMCDKECJNFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public AsyncTaskMethodBuilder<HOAOFNBBEKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public GHMJGCHLAMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private HOAOFNBBEKI <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private HOAOFNBBEKI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private TaskAwaiter<HOAOFNBBEKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CMCDKECJNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x49677F0", Offset = "0x4965FF0", VA = "0x1849677F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class CKIHIOIOIKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CKIHIOIOIKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x108F230", Offset = "0x108DA30", VA = "0x18108F230")]
		internal bool LNEIIDGCIHH(MPOOILGCDLJ sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class GJFMNLKEGFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public AsyncTaskMethodBuilder<HOAOFNBBEKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public HBPPPIGEKFO callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public EFENBEKLEHO superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private CKIHIOIOIKD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private IEMLKNOFDEG <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private MPOOILGCDLJ <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private EFENBEKLEHO <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private EFENBEKLEHO <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private AALOEEPNEOP <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private IEMLKNOFDEG <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private AALOEEPNEOP <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private CAIGCNABMEN <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private CAIGCNABMEN <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private AALOEEPNEOP <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private BNNPCINDEGK <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private BNNPCINDEGK <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter<IEMLKNOFDEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private TaskAwaiter<CAIGCNABMEN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private TaskAwaiter<BNNPCINDEGK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GJFMNLKEGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x496C460", Offset = "0x496AC60", VA = "0x18496C460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private KFDAFKKLOKJ BBMCDOFLCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private AALOEEPNEOP IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private long HAMIEGOKEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	private long BPODGJMCBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	private long PJBAEAJLHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	private string APOLELLKJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	private EFENBEKLEHO MCALOEENHGB;

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0750", Offset = "0x2D9EF50", VA = "0x182DA0750")]
	public static Task<HOAOFNBBEKI> AHEFPBBKFFG(IFNNJAAOEDN FNIFBLHBOOE, LCMHJBMHMJN PAJPFFIMEFB, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0990", Offset = "0x2D9F190", VA = "0x182DA0990")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OCAPNIKIGKA))]
	private Task<HOAOFNBBEKI> EBDHDHCPNAJ(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0B50", Offset = "0x2D9F350", VA = "0x182DA0B50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CMCDKECJNFC))]
	private Task<HOAOFNBBEKI> PKKFKJPCEJM(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0D10", Offset = "0x2D9F510", VA = "0x182DA0D10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GJFMNLKEGFN))]
	private static Task<HOAOFNBBEKI> PKKFKJPCEJM(HBPPPIGEKFO FGOMHOJPKFO, long HAMIEGOKEJC, long BPODGJMCBKI, long PJBAEAJLHMO, string APOLELLKJLH, EFENBEKLEHO MCALOEENHGB, CancellationToken GFFFFCALMCA, AALOEEPNEOP LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0B20", Offset = "0x2D9F320", VA = "0x182DA0B20")]
	private void LPAPCMDMINF(IEMLKNOFDEG KBEKHLAONIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal struct CPIAHEMPDLH
{
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class BMNCHDCGPHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public IFNNJAAOEDN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BMNCHDCGPHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x3481D20", Offset = "0x3480520", VA = "0x183481D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class PFHEKBMPLGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public CPIAHEMPDLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public PFHEKBMPLGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x3499870", Offset = "0x3498070", VA = "0x183499870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private ByteString EPBBCHCFEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private bool KFPBILIFIBE;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x2D94350", Offset = "0x2D92B50", VA = "0x182D94350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private bool CMJEGCCGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2D93ED0", Offset = "0x2D926D0", VA = "0x182D93ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private bool GHKKGJHEJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2D942C0", Offset = "0x2D92AC0", VA = "0x182D942C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x2D940E0", Offset = "0x2D928E0", VA = "0x182D940E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMNCHDCGPHA))]
	public static Task EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, DNKNJNMAMBL GIOAKJNONKE, bool KFPBILIFIBE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x2D93F50", Offset = "0x2D92750", VA = "0x182D93F50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PFHEKBMPLGI))]
	private Task EBDHDHCPNAJ(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal static class IBJOFFOKACF
{
	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9E60", Offset = "0x2DA8660", VA = "0x182DA9E60")]
	public static void PCHJIMFINCP(this MHBAMGOJMJJ EMBLDIHCMDD, MHKEFJDKLJN IKINGJFLMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9D80", Offset = "0x2DA8580", VA = "0x182DA9D80")]
	public static void ONPCOIPELPC(this MHKEFJDKLJN BIJBNMHAAEB, [Optional] string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct KDOBEABEJCC
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class AMCFCMFCJDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public KDOBEABEJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private AALOEEPNEOP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AMCFCMFCJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x42A9C70", Offset = "0x42A8470", VA = "0x1842A9C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private const int IONIJIHONCB = 20;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private const float ODNMBOGAIGP = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private AALOEEPNEOP IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private float HIGFILGGHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private float NOIPBOGFHJO;

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x3486700", Offset = "0x3484F00", VA = "0x183486700")]
	public static Task OKJLIDIOPDP(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x3486160", Offset = "0x3484960", VA = "0x183486160")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMCFCMFCJDF))]
	public Task EBDHDHCPNAJ(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x3486490", Offset = "0x3484C90", VA = "0x183486490")]
	private static void LCNEGKJELNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x34862B0", Offset = "0x3484AB0", VA = "0x1834862B0")]
	private void GDANKPGCFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x3486640", Offset = "0x3484E40", VA = "0x183486640")]
	private static float NDBEBOAFCNO(HBPPPIGEKFO FGOMHOJPKFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x3486140", Offset = "0x3484940", VA = "0x183486140")]
	private static float BDPLCDDDLOM()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class DNKNJNMAMBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private sealed class DOBNPFEKFGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private AALOEEPNEOP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private FHMBHNPINBI <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private DAMKOIBGCAN <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private TaskAwaiter<DAMKOIBGCAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DOBNPFEKFGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x4968590", Offset = "0x4966D90", VA = "0x184968590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct FJHJBJJDJBO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class EBDNOJNGGFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public EBDNOJNGGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x4968BA0", Offset = "0x49673A0", VA = "0x184968BA0")]
		internal FHMBHNPINBI LEODIPOBJPJ(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class CAPHFHKELHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public AsyncTaskMethodBuilder<DAMKOIBGCAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private EBDNOJNGGFI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private FMEHMMJPLED <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private DAMKOIBGCAN <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private FMEHMMJPLED <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private DAMKOIBGCAN <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private string <errorMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private ByteString <actualOperationId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private string <errorMessage>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private TaskAwaiter<DAMKOIBGCAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CAPHFHKELHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x4965D00", Offset = "0x4964500", VA = "0x184965D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class CGAABHDLBCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CGAABHDLBCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x4967660", Offset = "0x4965E60", VA = "0x184967660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class KMDLHFGAEGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KMDLHFGAEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x4972E30", Offset = "0x4971630", VA = "0x184972E30")]
		internal object DGMFOAMKODM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x4972E90", Offset = "0x4971690", VA = "0x184972E90")]
		internal bool JLBECBGGGHD(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private sealed class ACDAKAILNCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ACDAKAILNCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x4962BE0", Offset = "0x49613E0", VA = "0x184962BE0")]
		internal object KFDAPPMDKLC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private sealed class KPMMMFPAAFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KPMMMFPAAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x4972FA0", Offset = "0x49717A0", VA = "0x184972FA0")]
		internal object KFKIOBBMGPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class BMJJEMONBFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BMJJEMONBFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x4965C90", Offset = "0x4964490", VA = "0x184965C90")]
		internal object NNBHOGNNNAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class EEHNALOIMMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public EEHNALOIMMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x496A4E0", Offset = "0x4968CE0", VA = "0x18496A4E0")]
		internal object GFMPDMHHECN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class PNCBCFLBIPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public PNCBCFLBIPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x4976AB0", Offset = "0x49752B0", VA = "0x184976AB0")]
		internal object GFMPDMHHECN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private static readonly Guid DJJMHBANOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly OOCGABPOHBK JMLCEDJKPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private readonly GOMGBFEPMOD BFLJPKHGFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private readonly GNOLCLOPLMD EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	private readonly CAJCLGONHEA NFAOIEDIDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private bool LAOELOOGMGA;

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2D96620", Offset = "0x2D94E20", VA = "0x182D96620")]
	public DNKNJNMAMBL(OOCGABPOHBK CDJHLNAAHGK, GOMGBFEPMOD BFLJPKHGFDA, GNOLCLOPLMD EKLPJDMGHDM, CAJCLGONHEA NFAOIEDIDLK, AALOEEPNEOP LEBCJIHOHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2D95220", Offset = "0x2D93A20", VA = "0x182D95220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2D95220", Offset = "0x2D93A20", VA = "0x182D95220")]
	public void GHEFBDNHOFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2D95640", Offset = "0x2D93E40", VA = "0x182D95640")]
	public void GFHHOGMKBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2D963C0", Offset = "0x2D94BC0", VA = "0x182D963C0")]
	public void OIJBFLBKEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2D959C0", Offset = "0x2D941C0", VA = "0x182D959C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DOBNPFEKFGA))]
	internal Task<FHMBHNPINBI> HOMHGOLOBKD(AALOEEPNEOP LEBCJIHOHHE, FHMBHNPINBI IFPNDMLIDFN, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F260", Offset = "0x2D8DA60", VA = "0x182D8F260")]
	private static byte[] FFJHDGFFCLL<T>(T DKIECHCHJFL) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x3B452A0", Offset = "0x3B43AA0", VA = "0x183B452A0")]
	private static T KLHCJOAGOJC<T>(MessageParser<T> IBLLODJKIEB, byte[] DKIECHCHJFL, T FKDPHGEANKE) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2D94FE0", Offset = "0x2D937E0", VA = "0x182D94FE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CAPHFHKELHD))]
	private Task<DAMKOIBGCAN> CBLDPLEGMFH(FHMBHNPINBI IFPNDMLIDFN, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x3B44AB0", Offset = "0x3B432B0", VA = "0x183B44AB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HCPFLFMCDKD))]
	internal Task<T> AAMJCEBHNLK<T>(CancellationToken KHEICKPBIBD, Func<CancellationToken, Task<T>> BGOAFADLINP, int HKJHFGACIPJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2D94D50", Offset = "0x2D93550", VA = "0x182D94D50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGAABHDLBCC))]
	internal Task AAMJCEBHNLK(CancellationToken KHEICKPBIBD, Func<CancellationToken, Task> BGOAFADLINP, int HKJHFGACIPJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x2D96520", Offset = "0x2D94D20", VA = "0x182D96520")]
	public FHMBHNPINBI PNMFOCFOMAB(FMEHMMJPLED NFBFKALKFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x2D953D0", Offset = "0x2D93BD0", VA = "0x182D953D0")]
	public CHIPOCIBCNK EEEFAHLJBNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x2D951B0", Offset = "0x2D939B0", VA = "0x182D951B0")]
	public GKJHOLDCGPO DGPOEEDKGHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x2D94EE0", Offset = "0x2D936E0", VA = "0x182D94EE0")]
	public ODEOHNPPJCE AIPAJGCCMHD([Optional] HDDCAHBLLEN? ODPKAHOAPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x2D95180", Offset = "0x2D93980", VA = "0x182D95180")]
	public void CLIKLGEOLOI(Func<Guid, bool> GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x2D961E0", Offset = "0x2D949E0", VA = "0x182D961E0")]
	public void MJACCIELGLP(Func<Guid, bool> MDEPBBGHKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x2D95B80", Offset = "0x2D94380", VA = "0x182D95B80")]
	public void IHBJGKALJNH(Func<Guid, bool> GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2D957A0", Offset = "0x2D93FA0", VA = "0x182D957A0")]
	public Guid HMNMIJCBGAE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x2D954A0", Offset = "0x2D93CA0", VA = "0x182D954A0")]
	public void FNEOFEGLMFJ(Guid DGPMAIKFGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x2D96040", Offset = "0x2D94840", VA = "0x182D96040")]
	public void JLIDAKAHHGF(FHMBHNPINBI CJNGOOMCDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2D95EB0", Offset = "0x2D946B0", VA = "0x182D95EB0")]
	public void JGIMFEIAGIB(string AENODGLJKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2D95D20", Offset = "0x2D94520", VA = "0x182D95D20")]
	public void JGIMFEIAGIB(Func<string> ANINAIMKMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x3B44EB0", Offset = "0x3B436B0", VA = "0x183B44EB0")]
	private T FPDLJJIJEGK<T>(T ECNGHFJBIJL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2D96190", Offset = "0x2D94990", VA = "0x182D96190")]
	public void JONFDFHMGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x3B44F90", Offset = "0x3B43790", VA = "0x183B44F90")]
	[CompilerGenerated]
	internal static string GNMOIDNMBHF<T>(byte[] ENEAOCDMOME, int NHAAHCAPBBL, ref FJHJBJJDJBO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal struct HJFCIFBFFAN
{
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class BNJECNBBNDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public IFNNJAAOEDN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BNJECNBBNDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x42AB290", Offset = "0x42A9A90", VA = "0x1842AB290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class OLJCAIFMKKA
	{
		[Cpp2IlInjected.Token(Token = "0x200012C")]
		private sealed class <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			public AALOEEPNEOP timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004EA")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			public OLJCAIFMKKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			private AALOEEPNEOP <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x5980B00", Offset = "0x597F300", VA = "0x185980B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OLJCAIFMKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x42BB1D0", Offset = "0x42B99D0", VA = "0x1842BB1D0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task GLEEEHPILGD(AALOEEPNEOP timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private sealed class NBDKEECBGFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public HJFCIFBFFAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private OLJCAIFMKKA <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private FHMBHNPINBI <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NBDKEECBGFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x42B9D00", Offset = "0x42B8500", VA = "0x1842B9D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private sealed class APLOCNLEJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public HBHNCFJCIKF version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public APLOCNLEJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x42AA3C0", Offset = "0x42A8BC0", VA = "0x1842AA3C0")]
		internal object LFDGDHKDBPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x42AA4A0", Offset = "0x42A8CA0", VA = "0x1842AA4A0")]
		internal object PANLPDDAKNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	private DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private bool AHCBJBINNOD;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private static readonly ByteString PNEAAGKPJOA;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x2DA79A0", Offset = "0x2DA61A0", VA = "0x182DA79A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x2DA7920", Offset = "0x2DA6120", VA = "0x182DA7920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x2DA6E20", Offset = "0x2DA5620", VA = "0x182DA6E20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BNJECNBBNDK))]
	public static Task EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA, bool AHCBJBINNOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA7000", Offset = "0x2DA5800", VA = "0x182DA7000")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NBDKEECBGFM))]
	private Task EBDHDHCPNAJ(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2DA7180", Offset = "0x2DA5980", VA = "0x182DA7180")]
	private void HBLHPLJNDNE([NotNull] BNIDNMGAHLD BBBFCKGLENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x2DA78C0", Offset = "0x2DA60C0", VA = "0x182DA78C0")]
	private bool IAMNLMMFKKN(HBHNCFJCIKF FPBNFBFIPHI, BNIDNMGAHLD BBBFCKGLENJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal abstract class MMDFDPPJLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public readonly OOCGABPOHBK JMLCEDJKPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public readonly DNKNJNMAMBL LJLPJFLHKIG;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x348F5C0", Offset = "0x348DDC0", VA = "0x18348F5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x348F530", Offset = "0x348DD30", VA = "0x18348F530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x348F610", Offset = "0x348DE10", VA = "0x18348F610")]
	protected MMDFDPPJLGH(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x348F4F0", Offset = "0x348DCF0", VA = "0x18348F4F0")]
	protected void JGIMFEIAGIB(string AENODGLJKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x348F510", Offset = "0x348DD10", VA = "0x18348F510")]
	public void JGIMFEIAGIB(Func<string> ANINAIMKMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal class GKJHOLDCGPO : MMDFDPPJLGH, IJBBBDBCHDL
{
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	public delegate Task<FEEJMENJLIJ> EBIHPHKNPFJ(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO HDMIPHANIGM, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class KOBADOPLEPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private HPDLGGGIPCI <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private FHMBHNPINBI <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private FHMBHNPINBI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KOBADOPLEPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x42B58A0", Offset = "0x42B40A0", VA = "0x1842B58A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class ALIADCLFAPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private AALOEEPNEOP <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private FHMBHNPINBI <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private FHMBHNPINBI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ALIADCLFAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x49652E0", Offset = "0x4963AE0", VA = "0x1849652E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private sealed class PLHFNMLBOOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private AALOEEPNEOP <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public PLHFNMLBOOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x42BBA90", Offset = "0x42BA290", VA = "0x1842BBA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private sealed class KDPLHADDPBM
	{
		[Cpp2IlInjected.Token(Token = "0x2000136")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public AsyncTaskMethodBuilder<HOAOFNBBEKI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public KDPLHADDPBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private HOAOFNBBEKI <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private HOAOFNBBEKI <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter<FEEJMENJLIJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private TaskAwaiter<HOAOFNBBEKI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x597F6C0", Offset = "0x597DEC0", VA = "0x18597F6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000137")]
		private sealed class <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			public AsyncTaskMethodBuilder<MOMCOKAPMLC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			public KDPLHADDPBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private MOMCOKAPMLC <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private MOMCOKAPMLC <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			private TaskAwaiter<FEEJMENJLIJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			private TaskAwaiter<MOMCOKAPMLC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x597FE00", Offset = "0x597E600", VA = "0x18597FE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000138")]
		private sealed class <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			public KDPLHADDPBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private bool <isReloadingSceneForObjectModel>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private bool <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			private KBOEHLEJIFO <timedYielder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			private TaskAwaiter<FEEJMENJLIJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x597E2F0", Offset = "0x597CAF0", VA = "0x18597E2F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public JJMPNGLGHEG preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public JJMPNGLGHEG downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public HOAOFNBBEKI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public JJMPNGLGHEG postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public MOMCOKAPMLC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public MCNPFMNGCKP.DIKEJOLIKNG <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KDPLHADDPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x4971820", Offset = "0x4970020", VA = "0x184971820")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<HOAOFNBBEKI> OLFNNBMAJBB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x49716B0", Offset = "0x496FEB0", VA = "0x1849716B0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<MOMCOKAPMLC> MPFJOIFDDBL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x4971520", Offset = "0x496FD20", VA = "0x184971520")]
		internal void AFJKHOJOJAB(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x4971560", Offset = "0x496FD60", VA = "0x184971560")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task LNEKNOECPKF(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class KKLKNCNGHPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private KDPLHADDPBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private HOAOFNBBEKI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private MOMCOKAPMLC <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private TaskAwaiter<HOAOFNBBEKI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter<MOMCOKAPMLC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KKLKNCNGHPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x4972120", Offset = "0x4970920", VA = "0x184972120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class HKHHGLJAHFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HKHHGLJAHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x496D690", Offset = "0x496BE90", VA = "0x18496D690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class KOJHPIJFHMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private AALOEEPNEOP <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KOJHPIJFHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x42B5C90", Offset = "0x42B4490", VA = "0x1842B5C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class LNNNDJNBBAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private AALOEEPNEOP <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LNNNDJNBBAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x42B6EF0", Offset = "0x42B56F0", VA = "0x1842B6EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class JPCBMGCNAPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private AALOEEPNEOP <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JPCBMGCNAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x4970270", Offset = "0x496EA70", VA = "0x184970270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class PIHBPJAJPAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public FEEJMENJLIJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public MOMCOKAPMLC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private FEEJMENJLIJ <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private FEEJMENJLIJ <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public PIHBPJAJPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x42BB870", Offset = "0x42BA070", VA = "0x1842BB870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class MNOCNAOEPAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public EBIHPHKNPFJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MNOCNAOEPAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class LFONGKNJCPM
	{
		[Cpp2IlInjected.Token(Token = "0x2000142")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public LFONGKNJCPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			private FEEJMENJLIJ <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			private FEEJMENJLIJ <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			private TaskAwaiter<FEEJMENJLIJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x59803E0", Offset = "0x597EBE0", VA = "0x1859803E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public FEEJMENJLIJ originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public MNOCNAOEPAN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LFONGKNJCPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x42B6830", Offset = "0x42B5030", VA = "0x1842B6830")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<FEEJMENJLIJ> LIKNGLIGDOM(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class IJMNEIPANCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public EBIHPHKNPFJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private MNOCNAOEPAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private LFONGKNJCPM <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private FEEJMENJLIJ <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IJMNEIPANCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x496E740", Offset = "0x496CF40", VA = "0x18496E740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class JGCCMPKDMFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private FEEJMENJLIJ <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private IEnumerator<FEEJMENJLIJ> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private FEEJMENJLIJ <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JGCCMPKDMFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x496FE80", Offset = "0x496E680", VA = "0x18496FE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class GIAHGDCIJFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GIAHGDCIJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x496BBB0", Offset = "0x496A3B0", VA = "0x18496BBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class ELMNNEENDDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ELMNNEENDDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x496A760", Offset = "0x4968F60", VA = "0x18496A760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class NNPDCLHELGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public IEMLKNOFDEG roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NNPDCLHELGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x42BA6F0", Offset = "0x42B8EF0", VA = "0x1842BA6F0")]
		internal object MCNFNPAMGDJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	private readonly PKHKKGNCOIB PHDNNMDDLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private readonly PKHKKGNCOIB JLNPINILEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	private readonly KFDAFKKLOKJ BBMCDOFLCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private readonly FGCIPEMNFIB PDJAPHGOJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private readonly MMKBCFLLNID AMMLOCNKDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private readonly EIBOJBKNGCC KBDOFCNIKNN;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float NCJOEPAECEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1FA0", Offset = "0x2DA07A0", VA = "0x182DA1FA0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private IFNNJAAOEDN MIDAOOLAHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x2D91670", Offset = "0x2D8FE70", VA = "0x182D91670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event BGAINELODGO MFBLCLAEJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x2DA19D0", Offset = "0x2DA01D0", VA = "0x182DA19D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1FC0", Offset = "0x2DA07C0", VA = "0x182DA1FC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3160", Offset = "0x2DA1960", VA = "0x182DA3160")]
	public GKJHOLDCGPO(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0FA0", Offset = "0x2D9F7A0", VA = "0x182DA0FA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KOBADOPLEPC))]
	public Task AFBDNMFFNNO(LCMHJBMHMJN PAJPFFIMEFB, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2DA24E0", Offset = "0x2DA0CE0", VA = "0x182DA24E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ALIADCLFAPI))]
	private Task<FHMBHNPINBI> MNKHHEFFBHJ(LCMHJBMHMJN PAJPFFIMEFB, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2A00", Offset = "0x2DA1200", VA = "0x182DA2A00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PLHFNMLBOOG))]
	private Task OGNADIILDPL(LCMHJBMHMJN PAJPFFIMEFB, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1140", Offset = "0x2D9F940", VA = "0x182DA1140")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KKLKNCNGHPL))]
	private Task ALNDMCJPOAB(LCMHJBMHMJN PAJPFFIMEFB, AALOEEPNEOP LEBCJIHOHHE, CancellationToken ABPHAFIBLFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1A70", Offset = "0x2DA0270", VA = "0x182DA1A70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HKHHGLJAHFP))]
	private Task HBEDCFJFEGH(AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2DD0", Offset = "0x2DA15D0", VA = "0x182DA2DD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KOJHPIJFHMB))]
	private Task PAMMEKNKFJI(MOMCOKAPMLC PHBHEFAPHDL, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2BC0", Offset = "0x2DA13C0", VA = "0x182DA2BC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNNNDJNBBAH))]
	private Task<FEEJMENJLIJ> OJMFFDBOLEH(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1D90", Offset = "0x2DA0590", VA = "0x182DA1D90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JPCBMGCNAPF))]
	private Task<FEEJMENJLIJ> JOHLFMHMGPF(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x2DA12E0", Offset = "0x2D9FAE0", VA = "0x182DA12E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PIHBPJAJPAN))]
	private Task<FEEJMENJLIJ> CFNBNMAGJAI(FEEJMENJLIJ ANPIEEIPNGA, MOMCOKAPMLC LPFGOIILFCI, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA, bool AEACNEFJOGB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1730", Offset = "0x2D9FF30", VA = "0x182DA1730")]
	private bool EOBOKBAFAHA(MOMCOKAPMLC BDIHDHOFGCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1500", Offset = "0x2D9FD00", VA = "0x182DA1500")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IJMNEIPANCG))]
	protected Task<FEEJMENJLIJ> CPHJEKLBCIA(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA, EBIHPHKNPFJ KOHPCLOMMME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2320", Offset = "0x2DA0B20", VA = "0x182DA2320")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGCCMPKDMFC))]
	private Task LHDPOJEDCCH(MOMCOKAPMLC PHBHEFAPHDL, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1A20", Offset = "0x2DA0220", VA = "0x182DA1A20")]
	private void GODJEHFDFLK(FEEJMENJLIJ JCEEBLIDOHD, JJMPNGLGHEG OOKFEKMLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1BE0", Offset = "0x2DA03E0", VA = "0x182DA1BE0")]
	private void HIMGBBKEHLL(FEEJMENJLIJ PNPIHEBMMAF, out FEEJMENJLIJ NIJDJEIKOHG, out FEEJMENJLIJ PGPPIMDDDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2F90", Offset = "0x2DA1790", VA = "0x182DA2F90")]
	private Task<HOAOFNBBEKI> PKKFKJPCEJM(LCMHJBMHMJN PAJPFFIMEFB, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1FE0", Offset = "0x2DA07E0", VA = "0x182DA1FE0")]
	private Task<MOMCOKAPMLC> LBGGPNKPEGI(HOAOFNBBEKI PHBHEFAPHDL, MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2DA26A0", Offset = "0x2DA0EA0", VA = "0x182DA26A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GIAHGDCIJFI))]
	private Task NKKGJGLDCND(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA, bool AHCBJBINNOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1C20", Offset = "0x2DA0420", VA = "0x182DA1C20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ELMNNEENDDE))]
	private Task INICKHECGBO(MOMCOKAPMLC PHBHEFAPHDL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2DA19F0", Offset = "0x2DA01F0", VA = "0x182DA19F0")]
	private Task GHJJBNNJIJH(MOMCOKAPMLC PHBHEFAPHDL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2020", Offset = "0x2DA0820", VA = "0x182DA2020")]
	private Task LFPFADFFFOD(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2860", Offset = "0x2DA1060", VA = "0x182DA2860")]
	private Task NOHMJANJBLO(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2BA0", Offset = "0x2DA13A0", VA = "0x182DA2BA0")]
	private Task OIJPJEJGECB(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x2DA14F0", Offset = "0x2D9FCF0", VA = "0x182DA14F0")]
	private static Task CMPFMOKIHJM(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1830", Offset = "0x2DA0030", VA = "0x182DA1830")]
	private Task FLNALACEMCA(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2FD0", Offset = "0x2DA17D0", VA = "0x182DA2FD0")]
	private Task PMDGJLMKDEO(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0F40", Offset = "0x2D9F740", VA = "0x182DA0F40")]
	private void ADDCJIACHFB(LCMHJBMHMJN PAJPFFIMEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x2DA21B0", Offset = "0x2DA09B0", VA = "0x182DA21B0")]
	private static void LHBDBMCPEID(IEMLKNOFDEG KBEKHLAONIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal abstract class OOCGABPOHBK : IJBBBDBCHDL
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public delegate Task CCKHPCNCINE(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class GOOPIPHKBGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public AALOEEPNEOP operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public OOCGABPOHBK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GOOPIPHKBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x5979C50", Offset = "0x5978450", VA = "0x185979C50")]
		internal Task KFBCMDIONEB(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class NCGFODONIBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public GOOPIPHKBGO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NCGFODONIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x597D7D0", Offset = "0x597BFD0", VA = "0x18597D7D0")]
		internal object LIAABDJAIFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x597D710", Offset = "0x597BF10", VA = "0x18597D710")]
		internal object DEOHCKBFELK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class LDKEPLLJLBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public Func<OOCGABPOHBK, AALOEEPNEOP, DNKNJNMAMBL> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public OOCGABPOHBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private GOOPIPHKBGO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private DNKNJNMAMBL <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private FHMBHNPINBI <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private NCGFODONIBG <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter<FHMBHNPINBI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LDKEPLLJLBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x597C530", Offset = "0x597AD30", VA = "0x18597C530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class FPEEOOMFCLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public OOCGABPOHBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private CCKHPCNCINE <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FPEEOOMFCLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x5978F00", Offset = "0x5977700", VA = "0x185978F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	public readonly Guid ECPEBOBBOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	public readonly ByteString EFOLDDOJBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	public readonly FFLEKJBGAJJ GNCPOEKCNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	protected readonly string ENKPPJMNOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private readonly IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private readonly bool NKALOKKDEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private readonly Queue<CCKHPCNCINE> CKEJOMFOFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private readonly JJMPNGLGHEG KHIMDJKCMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private readonly NBGKOOKNBGP KAINKNJPFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private bool KELEEIEIJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	public FEEJMENJLIJ MEKBPOFNJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	public FEEJMENJLIJ CCPIJDABOGH;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public IFNNJAAOEDN MIDAOOLAHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F3660", Offset = "0x7F1E60", VA = "0x1807F3660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x3496D10", Offset = "0x3495510", VA = "0x183496D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public KDHGMPHKPAM MAEKOJNKJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x3496490", Offset = "0x3494C90", VA = "0x183496490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x3496A80", Offset = "0x3495280", VA = "0x183496A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public float NCJOEPAECEI
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x3496A60", Offset = "0x3495260", VA = "0x183496A60", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event BGAINELODGO MFBLCLAEJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x34967F0", Offset = "0x3494FF0", VA = "0x1834967F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x3496B00", Offset = "0x3495300", VA = "0x183496B00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x3496E30", Offset = "0x3495630", VA = "0x183496E30")]
	protected OOCGABPOHBK(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, string GLKMDMPJGOE, NBGKOOKNBGP KAINKNJPFIL, bool NKALOKKDEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x3496D60", Offset = "0x3495560", VA = "0x183496D60", Slot = "7")]
	protected virtual string OGMLKJNLLDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x3496CB0", Offset = "0x34954B0", VA = "0x183496CB0")]
	public void NHPPAEELKCK(CCKHPCNCINE GALABLGPLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x3496470", Offset = "0x3494C70", VA = "0x183496470")]
	protected void BCPEPPDCJKH(float CJLBHCOPODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x34964E0", Offset = "0x3494CE0", VA = "0x1834964E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LDKEPLLJLBI))]
	public Task EBDHDHCPNAJ(CancellationToken GFFFFCALMCA, AALOEEPNEOP LEBCJIHOHHE, [Optional] Func<OOCGABPOHBK, AALOEEPNEOP, DNKNJNMAMBL> BGBLFFHKMNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x3496B20", Offset = "0x3495320", VA = "0x183496B20")]
	private void MMAADBGCIOJ(bool GGKLFMPBGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x3496680", Offset = "0x3494E80", VA = "0x183496680")]
	private void EJJLPNLDKJF(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x34968F0", Offset = "0x34950F0", VA = "0x1834968F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPEEOOMFCLF))]
	private Task KIPAPEBLLFA(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x3496DA0", Offset = "0x34955A0", VA = "0x183496DA0")]
	public FHMBHNPINBI PNMFOCFOMAB(FMEHMMJPLED NFBFKALKFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x3496810", Offset = "0x3495010", VA = "0x183496810")]
	[CompilerGenerated]
	private Task INKIGFIEKNB(CancellationToken NFOHJNABMAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal abstract class HALIFADCDEK : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class ODGPPHCBEIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public HALIFADCDEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public JKKCGILCDLC playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ODGPPHCBEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x42BB190", Offset = "0x42B9990", VA = "0x1842BB190")]
		internal Task JDIGKAGBKKG(AALOEEPNEOP postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x42BB110", Offset = "0x42B9910", VA = "0x1842BB110")]
		internal object DFADCLAMOEJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class ADKLKAGGMBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public HALIFADCDEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private ODGPPHCBEIG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private FJHFJBECMEA <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ADKLKAGGMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x42A94F0", Offset = "0x42A7CF0", VA = "0x1842A94F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class FKKENGMBJHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public JKKCGILCDLC playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public HALIFADCDEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private AALOEEPNEOP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private AALOEEPNEOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FKKENGMBJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x42AF1F0", Offset = "0x42AD9F0", VA = "0x1842AF1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x2DA56A0", Offset = "0x2DA3EA0", VA = "0x182DA56A0")]
	public HALIFADCDEK(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, string GLKMDMPJGOE, NBGKOOKNBGP KAINKNJPFIL, bool NKALOKKDEMD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5360", Offset = "0x2DA3B60", VA = "0x182DA5360", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ADKLKAGGMBI))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task FKNGBCPGLCB(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5500", Offset = "0x2DA3D00", VA = "0x182DA5500")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FKKENGMBJHN))]
	private Task FGELCBKCCBC(IDisposable EMPFBCPNLOM, JKKCGILCDLC DAAJGDLADDK, AALOEEPNEOP IDIJCJCNEPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
public readonly struct EJCOGPHMIIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	public readonly BNIDNMGAHLD? DGLPPFDBOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	public readonly HMMFOJPJNIB GNMDELMPCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	public readonly string? ANPLPHIDDDD;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public IReadOnlyCollection<string> AKNGEHCHFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2D97090", Offset = "0x2D95890", VA = "0x182D97090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public IReadOnlyDictionary<long, int> BFHLGIBMCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2D97070", Offset = "0x2D95870", VA = "0x182D97070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x2D970B0", Offset = "0x2D958B0", VA = "0x182D970B0")]
	public EJCOGPHMIIO(BNIDNMGAHLD? CMMCIHFHBLL, HMMFOJPJNIB BAKFLNODNMF, string? OPOLKMBAJBK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct DAKNPDIODMG
{
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class DAHIOEPMHEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private OOCGABPOHBK <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private IFNNJAAOEDN <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private MCGDFABKIDE.CJJHBHDMDGF <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DAHIOEPMHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x34826D0", Offset = "0x3480ED0", VA = "0x1834826D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class ICBGILBPKLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private OFOJCNIGMKF.DIFMDKNFLDE <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ICBGILBPKLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x496E470", Offset = "0x496CC70", VA = "0x18496E470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x2D943A0", Offset = "0x2D92BA0", VA = "0x182D943A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DAHIOEPMHEI))]
	public static Task EBDHDHCPNAJ(DNKNJNMAMBL GIOAKJNONKE, MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x2D94640", Offset = "0x2D92E40", VA = "0x182D94640")]
	private static Task<FHMBHNPINBI> HOPFINEJIFM(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x2D94540", Offset = "0x2D92D40", VA = "0x182D94540")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ICBGILBPKLB))]
	private static Task HDKKLIHOIED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal class ALJGLPODJGB : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class JLDHJELDELH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public ALJGLPODJGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private ObscuredInt <localPlayerAccountId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private CHIPOCIBCNK <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private EJCOGPHMIIO <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private AALOEEPNEOP <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private AALOEEPNEOP <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private NNENOOPKHPC <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private LPCDCAILFOA <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private TaskAwaiter<LPCDCAILFOA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JLDHJELDELH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x34857E0", Offset = "0x3483FE0", VA = "0x1834857E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private readonly int GHGOMENDEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private readonly HCKACEFMPCF IPKBJACGFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	public readonly long DAGKDGGNPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	public readonly long LIHCFOABGDD;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public LPCDCAILFOA FKHLJHDJBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x8B4140", Offset = "0x8B2940", VA = "0x1808B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x910B70", Offset = "0x90F370", VA = "0x180910B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x2D8FFC0", Offset = "0x2D8E7C0", VA = "0x182D8FFC0")]
	public ALJGLPODJGB(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, int GHGOMENDEDC, HCKACEFMPCF IPKBJACGFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x2D8FE20", Offset = "0x2D8E620", VA = "0x182D8FE20", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JLDHJELDELH))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct MMKBCFLLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private sealed class CKHECKBOOCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public FEEJMENJLIJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public MOMCOKAPMLC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public MMKBCFLLNID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private AALOEEPNEOP <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private FEEJMENJLIJ <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CKHECKBOOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x5977740", Offset = "0x5975F40", VA = "0x185977740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class EEIEBBKOHCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public FEEJMENJLIJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public MMKBCFLLNID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private FHMBHNPINBI <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private FHMBHNPINBI <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private FEEJMENJLIJ <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private FHMBHNPINBI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public EEIEBBKOHCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x5978010", Offset = "0x5976810", VA = "0x185978010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	private readonly DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private readonly KFDAFKKLOKJ BBMCDOFLCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private readonly FGCIPEMNFIB PDJAPHGOJJO;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private OOCGABPOHBK JMLCEDJKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xC40860", Offset = "0xC3F060", VA = "0x180C40860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x348FA90", Offset = "0x348E290", VA = "0x18348FA90")]
	public MMKBCFLLNID(DNKNJNMAMBL GIOAKJNONKE, KFDAFKKLOKJ BBMCDOFLCKN, FGCIPEMNFIB PDJAPHGOJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x348F890", Offset = "0x348E090", VA = "0x18348F890")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKHECKBOOCL))]
	public Task<FEEJMENJLIJ> ODOLNCDCMAM(FEEJMENJLIJ NLMOCMPGOJG, MOMCOKAPMLC LPFGOIILFCI, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA, bool AEACNEFJOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x348F6C0", Offset = "0x348DEC0", VA = "0x18348F6C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EEIEBBKOHCO))]
	private Task<FEEJMENJLIJ> JPLBJBAIGLB(AALOEEPNEOP LEBCJIHOHHE, FEEJMENJLIJ LLBKKANHBEL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x348F670", Offset = "0x348DE70", VA = "0x18348F670")]
	private bool IDDEHCKMEOE(FEEJMENJLIJ PFCONCOBCPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x348F6A0", Offset = "0x348DEA0", VA = "0x18348F6A0")]
	private void JGIMFEIAGIB(string BAMBEECFNAE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct LEMBBABKCMD
{
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class JGICAPHJDJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private OOCGABPOHBK <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private FEEJMENJLIJ <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private IFNNJAAOEDN <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private HBPPPIGEKFO <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		private DJCJAIPOLNB <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private List<(PersistenceView, HGNMPOIAAKI)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private HGNMPOIAAKI <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JGICAPHJDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x42B3ED0", Offset = "0x42B26D0", VA = "0x1842B3ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x3489E40", Offset = "0x3488640", VA = "0x183489E40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGICAPHJDJM))]
	public static Task EBDHDHCPNAJ(DNKNJNMAMBL GIOAKJNONKE, MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x348A000", Offset = "0x3488800", VA = "0x18348A000")]
	private static void GPJDDHKDCEH(PersistenceView AFCPDJEIDLD, HGNMPOIAAKI EJFGMPEJEDD, MOMCOKAPMLC PHBHEFAPHDL, FEEJMENJLIJ ANPIEEIPNGA, bool FPJMKDBAJEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal class ODEOHNPPJCE : MMDFDPPJLGH
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class PNIIAJKOJJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public AsyncTaskMethodBuilder<EJCOGPHMIIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public GEDJHDMKMOJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public ODEOHNPPJCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private StringBuilder <outputBuilder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public PNIIAJKOJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x597DCE0", Offset = "0x597C4E0", VA = "0x18597DCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class AKMOPGEKCBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public GEDJHDMKMOJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public ODEOHNPPJCE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AKMOPGEKCBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x59766C0", Offset = "0x5974EC0", VA = "0x1859766C0")]
		internal Task IPCOIKAEFCP(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x59765E0", Offset = "0x5974DE0", VA = "0x1859765E0")]
		internal Task FLNANOFJGAF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class CAEMKKCFOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AKMOPGEKCBI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CAEMKKCFOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x5977020", Offset = "0x5975820", VA = "0x185977020")]
		internal object EDMGLJGPCAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class KCDLEBKFKAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public AKMOPGEKCBI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KCDLEBKFKAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x597BBD0", Offset = "0x597A3D0", VA = "0x18597BBD0")]
		internal Task IMBPIJANEMN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class JHMCEHBCHMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public GEDJHDMKMOJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public ODEOHNPPJCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private AKMOPGEKCBI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private CAEMKKCFOBA <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JHMCEHBCHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x597AC70", Offset = "0x5979470", VA = "0x18597AC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400065C")]
	private readonly HDDCAHBLLEN ODPKAHOAPPJ;

	[Cpp2IlInjected.Token(Token = "0x400065D")]
	private static readonly TimeSpan MDINOJPLKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private readonly PMBFCJLIGBB NILLNCDAMFL;

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x3494A70", Offset = "0x3493270", VA = "0x183494A70")]
	public ODEOHNPPJCE(DNKNJNMAMBL GIOAKJNONKE, PMBFCJLIGBB NILLNCDAMFL, [Optional] HDDCAHBLLEN? ODPKAHOAPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x34938F0", Offset = "0x34920F0", VA = "0x1834938F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PNIIAJKOJJP))]
	public Task<EJCOGPHMIIO> ECCPKOGLKLF(long BPODGJMCBKI, string OPOLKMBAJBK, GEDJHDMKMOJ GIOCABEBNHM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x34940C0", Offset = "0x34928C0", VA = "0x1834940C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JHMCEHBCHMA))]
	private Task GABMMOLFOOI(GEDJHDMKMOJ GIOCABEBNHM, IEnumerable<PersistenceView> DLPOCMMMECH, StringBuilder LEMKHGBBJGF, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x3493AC0", Offset = "0x34922C0", VA = "0x183493AC0")]
	private EJCOGPHMIIO FLPDHPEMPDO(long BPODGJMCBKI, string OPOLKMBAJBK, GEDJHDMKMOJ GIOCABEBNHM, IEnumerable<PersistenceView> DLPOCMMMECH, StringBuilder LEMKHGBBJGF)
	{
		return default(EJCOGPHMIIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x3493770", Offset = "0x3491F70", VA = "0x183493770")]
	private BNIDNMGAHLD EBEMJAMFINA(long BPODGJMCBKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x3494280", Offset = "0x3492A80", VA = "0x183494280")]
	private void GHBMEODOLDG(BNIDNMGAHLD PJDCDPIPHBA, StringBuilder LEMKHGBBJGF, IEnumerable<PersistenceView> DLPOCMMMECH, in DHJIDMGNJIC AKDAOECFHJI, EKIEPCIPJDM LHNAPAPHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x3494490", Offset = "0x3492C90", VA = "0x183494490")]
	private void JHJPBFNLODM(BNIDNMGAHLD PJDCDPIPHBA, StringBuilder LEMKHGBBJGF, PersistenceView AFCPDJEIDLD, ref EKIEPCIPJDM LHNAPAPHKDJ, in DHJIDMGNJIC AKDAOECFHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal class MKKIMDKIEJP : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class BKDBAOGEJEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public MKKIMDKIEJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private string <unityAssetId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private ODEOHNPPJCE <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private GEDJHDMKMOJ <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private EJCOGPHMIIO <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private EJCOGPHMIIO <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private TaskAwaiter<EJCOGPHMIIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BKDBAOGEJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x59769B0", Offset = "0x59751B0", VA = "0x1859769B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private readonly NFBLDIHAPOJ GJGJDNGPKAK;

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x348E7F0", Offset = "0x348CFF0", VA = "0x18348E7F0")]
	public MKKIMDKIEJP(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, NFBLDIHAPOJ GJGJDNGPKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x348E710", Offset = "0x348CF10", VA = "0x18348E710", Slot = "7")]
	protected override string OGMLKJNLLDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x348E570", Offset = "0x348CD70", VA = "0x18348E570", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BKDBAOGEJEB))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct NHOCFNNGHPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	public Dictionary<Guid, List<LOHABELNFDM>> LMICAEJEHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	public Dictionary<Guid, List<LOHABELNFDM>> KNILAHAGHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	public Dictionary<Guid, List<LOHABELNFDM>> NPHBJECFANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	public List<Guid> MDEIBJCFAKB;

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x3490A60", Offset = "0x348F260", VA = "0x183490A60")]
	public static NHOCFNNGHPA PNBJHLBKMLC(HBPPPIGEKFO FGOMHOJPKFO, FEEJMENJLIJ ANPIEEIPNGA, MOMCOKAPMLC LPFGOIILFCI)
	{
		return default(NHOCFNNGHPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public readonly struct IEGAONCOOPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	public readonly bool IFOBDMNOJDF;

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x156E150", Offset = "0x156C950", VA = "0x18156E150")]
	public IEGAONCOOPP(bool MKAIJMBKJCH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct BFGPKLGDCDD
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class NFKAOJCGFOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public OOCGABPOHBK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private FEEJMENJLIJ <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private List<(PersistenceView, HGNMPOIAAKI)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private (PersistenceView, HGNMPOIAAKI) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private CKGIIPHAJBG <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NFKAOJCGFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x348FC10", Offset = "0x348E410", VA = "0x18348FC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x2D91280", Offset = "0x2D8FA80", VA = "0x182D91280")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NFKAOJCGFOD))]
	public static Task EBDHDHCPNAJ(OOCGABPOHBK CDJHLNAAHGK, MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal struct KPGCBEAGKPL
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class IKGBMMJPPDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public AsyncTaskMethodBuilder<MOMCOKAPMLC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public MCNPFMNGCKP.DIKEJOLIKNG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public KPGCBEAGKPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private AALOEEPNEOP <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private Task<global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private Task<global::PKJAENHCLMN<global::HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private Task<global::PKJAENHCLMN<global::HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private Task<global::PKJAENHCLMN<global::HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private Task<(global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private global::PKJAENHCLMN<global::HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private global::PKJAENHCLMN<global::HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private global::PKJAENHCLMN<global::HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private global::HCLLLJEDILH<BNIDNMGAHLD> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private (global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private (global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private TaskAwaiter<(global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IKGBMMJPPDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x42B3050", Offset = "0x42B1850", VA = "0x1842B3050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class LNFOAOHAJON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public AsyncTaskMethodBuilder<global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public MCNPFMNGCKP.DIKEJOLIKNG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public AALOEEPNEOP downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public KPGCBEAGKPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private AALOEEPNEOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private TaskAwaiter<global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LNFOAOHAJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x42B69A0", Offset = "0x42B51A0", VA = "0x1842B69A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private global::OOIGBDNKEMF<EFENBEKLEHO, CIOHJELGAHC> KFFNOKPJFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private global::OOIGBDNKEMF<EFENBEKLEHO, BNIDNMGAHLD> ICPMNAKBCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private global::OOIGBDNKEMF<long, DBGKDIDMLDF> KPGLGGKCHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private MHMLFGJNJKA CEKKHHEGJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private IEMLKNOFDEG KBEKHLAONIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	private MPOOILGCDLJ CJNLJKIIPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006AF")]
	private string OPOLKMBAJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	private EFENBEKLEHO IKHHHDILDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006B1")]
	private EFENBEKLEHO HOIJLNKGLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private long BFNOJMGJLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private AALOEEPNEOP IDIJCJCNEPO;

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x3489200", Offset = "0x3487A00", VA = "0x183489200")]
	public static Task<MOMCOKAPMLC> AHEFPBBKFFG(IFNNJAAOEDN FNIFBLHBOOE, in HOAOFNBBEKI PHBHEFAPHDL, MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x3489560", Offset = "0x3487D60", VA = "0x183489560")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKGBMMJPPDH))]
	private Task<MOMCOKAPMLC> EBDHDHCPNAJ(MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x3489730", Offset = "0x3487F30", VA = "0x183489730")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNFOAOHAJON))]
	private Task<global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> HELNJIFFEFO(string OPOLKMBAJBK, long BFNOJMGJLFG, MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, AALOEEPNEOP HFLKGMILCJP, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
public class KFDAFKKLOKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private readonly IIDHLOGLACP BAMBFEPJLPN;

	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private const string GIAMHDNKEAP = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private const string DMBJPNEBJEJ = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private const string MNPGAGOECKJ = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private const string MLOFNDALOOG = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private const string LALOJOMALCC = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private string OFLFEFGNIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private long? NJFMODCOJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private long? LDCCGHGDLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private FEEJMENJLIJ KFPNBOHHNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private long? HKCOOAJECGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private bool DKEAICPBKBM;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string EILJMPEIPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public long HLECCCFMNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x34875C0", Offset = "0x3485DC0", VA = "0x1834875C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public long PCBENBOPEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x3487210", Offset = "0x3485A10", VA = "0x183487210")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public FEEJMENJLIJ PIKEIPINLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2B0", Offset = "0x8F8AB0", VA = "0x1808FA2B0")]
		get
		{
			return default(FEEJMENJLIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x34879B0", Offset = "0x34861B0", VA = "0x1834879B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public long DIKEHAFBGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x3487560", Offset = "0x3485D60", VA = "0x183487560")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x3487D40", Offset = "0x3486540", VA = "0x183487D40")]
	[UnityEngine.Scripting.Preserve]
	public KFDAFKKLOKJ([ACEKLAKDMBL(null)] IIDHLOGLACP BAMBFEPJLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x3487B90", Offset = "0x3486390", VA = "0x183487B90")]
	private void OEOEIGOFALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x3487620", Offset = "0x3485E20", VA = "0x183487620")]
	public void MCMIDIJEJCB(long HAMIEGOKEJC, long BPODGJMCBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x3487AA0", Offset = "0x34862A0", VA = "0x183487AA0")]
	public void NFPBNAAPLIL(string AGJEHAHDINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x3487270", Offset = "0x3485A70", VA = "0x183487270")]
	public void EMKEIDOFNDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal sealed class GNPGFJFMNHD : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class AMMBJEENPIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AMMBJEENPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x42AA030", Offset = "0x42A8830", VA = "0x1842AA030")]
		internal object CMOMFNDMDFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class DJDFNOFMHNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public GNPGFJFMNHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private MHBAMGOJMJJ <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private GKJHOLDCGPO <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DJDFNOFMHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x42ADAB0", Offset = "0x42AC2B0", VA = "0x1842ADAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class BJNKPLCCOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public MHBAMGOJMJJ presence;

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BJNKPLCCOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x42AB150", Offset = "0x42A9950", VA = "0x1842AB150")]
		internal object BLHEAHAEIPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private readonly LCMHJBMHMJN CMKABAANNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private readonly MHKEFJDKLJN IKINGJFLMDI;

	[Cpp2IlInjected.Token(Token = "0x40006E2")]
	private const bool OGJKDAEGPEA = false;

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3DF0", Offset = "0x2DA25F0", VA = "0x182DA3DF0")]
	public GNPGFJFMNHD(LCMHJBMHMJN CMKABAANNAK, MHKEFJDKLJN IKINGJFLMDI, Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3800", Offset = "0x2DA2000", VA = "0x182DA3800", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJDFNOFMHNJ))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x2DA39A0", Offset = "0x2DA21A0", VA = "0x182DA39A0")]
	private MHBAMGOJMJJ IKCIIPMOMLF()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct LNLHCJMIMGG
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class FIHCBNIJKOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public IFNNJAAOEDN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private bool <isMaster>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FIHCBNIJKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x42AED70", Offset = "0x42AD570", VA = "0x1842AED70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x348B580", Offset = "0x3489D80", VA = "0x18348B580")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FIHCBNIJKOO))]
	public static Task EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal struct KOKAOIFOHAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class DDKDKNPGDEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public KOKAOIFOHAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private GNIKGJEJAOC <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		private AALOEEPNEOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private string <sceneName>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private Scene <mainScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DDKDKNPGDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x42AD3F0", Offset = "0x42ABBF0", VA = "0x1842AD3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class KKMIJCLINOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KKMIJCLINOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x42B5850", Offset = "0x42B4050", VA = "0x1842B5850")]
		internal object NJELHEMJBFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class KPHINNJLMBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public KOKAOIFOHAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private KKMIJCLINOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private NFEMKDMIHPG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KPHINNJLMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x42B6260", Offset = "0x42B4A60", VA = "0x1842B6260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	private GNIKGJEJAOC FEEHPDIFFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	private AALOEEPNEOP IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F9")]
	private bool HCPCHHEKOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006FA")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x3488D60", Offset = "0x3487560", VA = "0x183488D60")]
	public static Task<Scene> CAIIMFNAGLL(IFNNJAAOEDN FNIFBLHBOOE, GNIKGJEJAOC EPLEEMFCMME, AALOEEPNEOP IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x3488F40", Offset = "0x3487740", VA = "0x183488F40")]
	public static Task<Scene> EFMJPDDAKLA(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x3488DE0", Offset = "0x34875E0", VA = "0x183488DE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDKDKNPGDEO))]
	private Task<Scene> EBDHDHCPNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x3488FE0", Offset = "0x34877E0", VA = "0x183488FE0")]
	private bool GFFGKMPPLDL(MOMCOKAPMLC PHBHEFAPHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x3489010", Offset = "0x3487810", VA = "0x183489010")]
	private void HFIDDOBGHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x3489080", Offset = "0x3487880", VA = "0x183489080")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KPHINNJLMBM))]
	private Task<Scene> LABLIJDEDLP(string KPMIPNBJALP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public abstract class GHNMALNFIIN<T> where T : global::GHNMALNFIIN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	internal readonly IFNNJAAOEDN AEOAMPMHMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private int? LAGKBBBLPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	protected readonly Guid ECPEBOBBOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000711")]
	protected readonly DLLMEMMHNCB POGILKKOKAG;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	protected T CFDIOCDOGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFDD0", Offset = "0x2BDE5D0", VA = "0x182BDFDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0130", Offset = "0x2BDE930", VA = "0x182BE0130")]
	internal GHNMALNFIIN(IFNNJAAOEDN BAFFLKMLODH, DLLMEMMHNCB GOKELOIKDPH, [Optional] Guid? PALLEDHBFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0040", Offset = "0x2BDE840", VA = "0x182BE0040")]
	private FHMBHNPINBI PNDMPGBACPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "4")]
	protected virtual void FNKFGHEALCA(FHMBHNPINBI DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFE30", Offset = "0x2BDE630", VA = "0x182BDFE30")]
	public T EPOBKLBKCBE(IGGCDPKBFGF ACJGGEOLANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFEC0", Offset = "0x2BDE6C0", VA = "0x182BDFEC0")]
	public T JOBANKHALDL(int APBFHMCACOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFF40", Offset = "0x2BDE740", VA = "0x182BDFF40", Slot = "5")]
	public virtual Task<IDIFMABCDLA> NLNPDPINDNM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
public class DHFMLFOJIHC : global::GHNMALNFIIN<DHFMLFOJIHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000712")]
	private LCMHJBMHMJN MEKBNGFFPML;

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x2D94900", Offset = "0x2D93100", VA = "0x182D94900")]
	internal DHFMLFOJIHC(IFNNJAAOEDN BAFFLKMLODH, DLLMEMMHNCB GOKELOIKDPH, [Optional] Guid? PALLEDHBFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x2D948E0", Offset = "0x2D930E0", VA = "0x182D948E0")]
	public DHFMLFOJIHC PEKKCJNPFHN(LCMHJBMHMJN MEKBNGFFPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x2D94820", Offset = "0x2D93020", VA = "0x182D94820", Slot = "4")]
	protected override void FNKFGHEALCA(FHMBHNPINBI DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
public class AMGCDJKPHHE : global::GHNMALNFIIN<AMGCDJKPHHE>
{
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	internal enum JFNGBDOKEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		RecNet
	}

	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class KEPEDBDJOEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public AMGCDJKPHHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private IDIFMABCDLA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		private TaskAwaiter<IDIFMABCDLA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KEPEDBDJOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x3486E80", Offset = "0x3485680", VA = "0x183486E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000713")]
	private JFNGBDOKEFJ LIGEIHFKLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000714")]
	private string GELGNLNNMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	private NNENOOPKHPC MEKBNGFFPML;

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x2D904B0", Offset = "0x2D8ECB0", VA = "0x182D904B0")]
	internal AMGCDJKPHHE(IFNNJAAOEDN BAFFLKMLODH, DLLMEMMHNCB GOKELOIKDPH, [Optional] Guid? PALLEDHBFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x2D90300", Offset = "0x2D8EB00", VA = "0x182D90300")]
	public AMGCDJKPHHE MOMLKGOFEHD(string IDCNODJDCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x2D90260", Offset = "0x2D8EA60", VA = "0x182D90260")]
	public AMGCDJKPHHE GFJGJDJKNBJ(bool DNDPJAPBJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x2D902D0", Offset = "0x2D8EAD0", VA = "0x182D902D0")]
	public AMGCDJKPHHE JCGLBPMKPIA(string FMALCPACLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2D90480", Offset = "0x2D8EC80", VA = "0x182D90480")]
	public AMGCDJKPHHE OLFKAAGMGMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x2D900F0", Offset = "0x2D8E8F0", VA = "0x182D900F0", Slot = "4")]
	protected override void FNKFGHEALCA(FHMBHNPINBI DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x2D90330", Offset = "0x2D8EB30", VA = "0x182D90330", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KEPEDBDJOEK))]
	public override Task<IDIFMABCDLA> NLNPDPINDNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x2D90290", Offset = "0x2D8EA90", VA = "0x182D90290")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<IDIFMABCDLA> ICDBEDNLODH()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal struct OMGEIFGLMDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private sealed class BEHNKGKPPMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public MCGDFABKIDE.CJJHBHDMDGF instantiations;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BEHNKGKPPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x5976900", Offset = "0x5975100", VA = "0x185976900")]
		internal object GLEEEHPILGD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class EMBJHKDGIAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public EMBJHKDGIAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x5978360", Offset = "0x5976B60", VA = "0x185978360")]
		internal object KFBCMDIONEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x3494FA0", Offset = "0x34937A0", VA = "0x183494FA0")]
	public static void EBDHDHCPNAJ(OOCGABPOHBK CDJHLNAAHGK, MOMCOKAPMLC PHBHEFAPHDL, MCGDFABKIDE.CJJHBHDMDGF KNICAFCALMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct MCGDFABKIDE
{
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	public struct CJJHBHDMDGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public List<GKDPOMOKADP> MKBFFOFCAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public List<HGNMPOIAAKI> GEDPMAOKDAN;

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x9E1370", Offset = "0x9DFB70", VA = "0x1809E1370")]
		public CJJHBHDMDGF(List<GKDPOMOKADP> MKBFFOFCAEK, List<HGNMPOIAAKI> GEDPMAOKDAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class NOCEIFMLEIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public IEnumerable<GKDPOMOKADP> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NOCEIFMLEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x597D890", Offset = "0x597C090", VA = "0x18597D890")]
		internal object CDIEBDEOHJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x348CB60", Offset = "0x348B360", VA = "0x18348CB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x348C000", Offset = "0x348A800", VA = "0x18348C000")]
	public static CJJHBHDMDGF EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL)
	{
		return default(CJJHBHDMDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x348C070", Offset = "0x348A870", VA = "0x18348C070")]
	private CJJHBHDMDGF EBDHDHCPNAJ()
	{
		return default(CJJHBHDMDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x348C5E0", Offset = "0x348ADE0", VA = "0x18348C5E0")]
	private CJJHBHDMDGF NJGIGKHCMCP(BNIDNMGAHLD BBBFCKGLENJ, HBHNCFJCIKF KJBJOIGGOCH)
	{
		return default(CJJHBHDMDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x348C390", Offset = "0x348AB90", VA = "0x18348C390")]
	private bool KHIEFGMBIHG(IEnumerable<GKDPOMOKADP> MKBFFOFCAEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal struct DICNKJMABAF
{
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class FLIJPGHBNPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public DICNKJMABAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private AALOEEPNEOP <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private AALOEEPNEOP <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FLIJPGHBNPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x496B280", Offset = "0x4969A80", VA = "0x18496B280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class IPFCBDKKIIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IPFCBDKKIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x496F7B0", Offset = "0x496DFB0", VA = "0x18496F7B0")]
		internal object NJELHEMJBFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class JBCHCLNGGLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public DICNKJMABAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		private IPFCBDKKIIB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private NFEMKDMIHPG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JBCHCLNGGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x496F830", Offset = "0x496E030", VA = "0x18496F830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private bool HALMHNMILGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	private AALOEEPNEOP IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private CancellationToken GFFFFCALMCA;

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x2D94B70", Offset = "0x2D93370", VA = "0x182D94B70")]
	public static Task JAGJNBNMDNL(IFNNJAAOEDN FNIFBLHBOOE, bool HALMHNMILGE, AALOEEPNEOP IDIJCJCNEPO, CancellationToken FFDAINFFMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D94A40", Offset = "0x2D93240", VA = "0x182D94A40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FLIJPGHBNPP))]
	private Task EBDHDHCPNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D94BE0", Offset = "0x2D933E0", VA = "0x182D94BE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JBCHCLNGGLI))]
	private Task LABLIJDEDLP(bool DJJMALJEJII, string KPMIPNBJALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0")]
	private bool JPNFMNLDNFA(bool HALMHNMILGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal struct HOAOFNBBEKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	public readonly IEMLKNOFDEG KBEKHLAONIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000741")]
	public readonly MPOOILGCDLJ CJNLJKIIPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000742")]
	public readonly string OPOLKMBAJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	public readonly EFENBEKLEHO IKHHHDILDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000744")]
	public readonly EFENBEKLEHO HOIJLNKGLFK;

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9280", Offset = "0x2DA7A80", VA = "0x182DA9280")]
	public HOAOFNBBEKI(IEMLKNOFDEG KBEKHLAONIE, MPOOILGCDLJ CJNLJKIIPKB, string OPOLKMBAJBK, EFENBEKLEHO IKHHHDILDNK, EFENBEKLEHO HOIJLNKGLFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal sealed class CHMKLKMLENN : HALIFADCDEK
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class BAKBIPMEGBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public CHMKLKMLENN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private NKHBPCPCMLJ <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private GKJHOLDCGPO <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BAKBIPMEGBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x3481090", Offset = "0x347F890", VA = "0x183481090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000745")]
	private readonly LCMHJBMHMJN NHMBOCGMBGD;

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D920D0", Offset = "0x2D908D0", VA = "0x182D920D0")]
	public CHMKLKMLENN(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, LCMHJBMHMJN NHMBOCGMBGD, FFLEKJBGAJJ KPFEABGPNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x2D91F30", Offset = "0x2D90730", VA = "0x182D91F30", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BAKBIPMEGBI))]
	protected override Task FKNGBCPGLCB(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018C")]
internal struct KGAFFLMMDHL
{
	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x3488010", Offset = "0x3486810", VA = "0x183488010")]
	public static Task EBDHDHCPNAJ(CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
internal struct HEKFJEICGBI
{
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private sealed class ECGAKJCABNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public IFNNJAAOEDN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		private bool <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ECGAKJCABNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x42AE4C0", Offset = "0x42ACCC0", VA = "0x1842AE4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private sealed class IACELMBHJEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public HEKFJEICGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private bool <shouldObjectModelBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		private bool <isOMFlagChanging>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		private bool <reloadSceneForObjectModel>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IACELMBHJEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x42B1860", Offset = "0x42B0060", VA = "0x1842B1860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400074F")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000750")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private ByteString EPBBCHCFEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2DA6DD0", Offset = "0x2DA55D0", VA = "0x182DA6DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool CMJEGCCGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2DA68F0", Offset = "0x2DA50F0", VA = "0x182DA68F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool GHKKGJHEJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2DA6D40", Offset = "0x2DA5540", VA = "0x182DA6D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private bool BCBGHHFAELE
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2DA6970", Offset = "0x2DA5170", VA = "0x182DA6970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2DA6B50", Offset = "0x2DA5350", VA = "0x182DA6B50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ECGAKJCABNI))]
	public static Task<bool> EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x2DA69B0", Offset = "0x2DA51B0", VA = "0x182DA69B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IACELMBHJEH))]
	private Task<bool> EBDHDHCPNAJ(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public static class EDKMEFHOBIG
{
	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D96EF0", Offset = "0x2D956F0", VA = "0x182D96EF0")]
	public static EFENBEKLEHO BMNPIDDJJNL(this HAPEDGBDDDG MJJEAGOMNNL)
	{
		return default(EFENBEKLEHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D96FB0", Offset = "0x2D957B0", VA = "0x182D96FB0")]
	public static HAPEDGBDDDG KFALNGGMHPP(this EFENBEKLEHO ANGPFHAPFPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
internal class CHIPOCIBCNK : MMDFDPPJLGH
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class FKHMOGPFCED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public NIADFLCAKKJ.BLEDDCONCNO roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FKHMOGPFCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x3484310", Offset = "0x3482B10", VA = "0x183484310")]
		internal object PNDOAICHBLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x3484010", Offset = "0x3482810", VA = "0x183484010")]
		internal object GAENOLKHDLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x3484060", Offset = "0x3482860", VA = "0x183484060")]
		internal object GKMIMNBLPLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x34840D0", Offset = "0x34828D0", VA = "0x1834840D0")]
		internal object GLFGLBPEBLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class OMICCKOFGJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public AsyncTaskMethodBuilder<(NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		private FKHMOGPFCED <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		private CIOHJELGAHC <roomMetadata>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private NIADFLCAKKJ.BLEDDCONCNO <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private NIADFLCAKKJ.BLEDDCONCNO <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private TaskAwaiter<NIADFLCAKKJ.BLEDDCONCNO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OMICCKOFGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x3495670", Offset = "0x3493E70", VA = "0x183495670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class BOJFPPBKBBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public AsyncTaskMethodBuilder<LPCDCAILFOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public NNENOOPKHPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		private NIADFLCAKKJ.BLEDDCONCNO <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		private NIADFLCAKKJ.BLEDDCONCNO <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		private int <persistenceVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private NEBPAIJOJCP <request>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private LPCDCAILFOA <response>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private (NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private (NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private LPCDCAILFOA <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		private TaskAwaiter<(NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		private TaskAwaiter<LPCDCAILFOA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BOJFPPBKBBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x3481F10", Offset = "0x3480710", VA = "0x183481F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class EJNPFODKFCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public AsyncTaskMethodBuilder<CAIGCNABMEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		private NIADFLCAKKJ.BLEDDCONCNO <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		private NIADFLCAKKJ.BLEDDCONCNO <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		private CAIGCNABMEN <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		private (NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		private (NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		private CAIGCNABMEN <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		private TaskAwaiter<(NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		private TaskAwaiter<CAIGCNABMEN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public EJNPFODKFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x3483AD0", Offset = "0x34822D0", VA = "0x183483AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class ADFANEGODOA
	{
		[Cpp2IlInjected.Token(Token = "0x2000197")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007A4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007A5")]
			public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007A6")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007A7")]
			public ADFANEGODOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007A8")]
			private FHMBHNPINBI <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007A9")]
			private RepeatedField<HGNMPOIAAKI> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007AA")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78FC70", Offset = "0x78F070")]
			private IEnumerable<HGNMPOIAAKI> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007AB")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			private CAIGCNABMEN <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			private CAIGCNABMEN <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			private LPCDCAILFOA <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			private LPCDCAILFOA <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			private FHMBHNPINBI <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			private TaskAwaiter<CAIGCNABMEN> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private TaskAwaiter<LPCDCAILFOA> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			private TaskAwaiter<FHMBHNPINBI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x59811B0", Offset = "0x597F9B0", VA = "0x1859811B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public NNENOOPKHPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public IEGAONCOOPP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78FBA0", Offset = "0x78EFA0")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ADFANEGODOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x3480B70", Offset = "0x347F370", VA = "0x183480B70")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<FHMBHNPINBI> JCKBHPJJBCP(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class ODKABEEKPHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public NNENOOPKHPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public IEGAONCOOPP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78FCD0", Offset = "0x78F0D0")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		private ADFANEGODOA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		private FHMBHNPINBI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ODKABEEKPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x3494B80", Offset = "0x3493380", VA = "0x183494B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000766")]
	private const float HOJEBHBGLMK = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000767")]
	private readonly BNBOHDAMFHI CJPJEGMHJHB;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private IFNNJAAOEDN MIDAOOLAHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2D91670", Offset = "0x2D8FE70", VA = "0x182D91670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D91EA0", Offset = "0x2D906A0", VA = "0x182D91EA0")]
	public CHIPOCIBCNK(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D91CE0", Offset = "0x2D904E0", VA = "0x182D91CE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMICCKOFGJC))]
	private Task<(NIADFLCAKKJ.BLEDDCONCNO, NIADFLCAKKJ.BLEDDCONCNO)> MKBBIAPKPGD(EJCOGPHMIIO NNIPLGKEGFJ, long HAMIEGOKEJC, long KIBMHJEFMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D91AF0", Offset = "0x2D902F0", VA = "0x182D91AF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BOJFPPBKBBB))]
	public Task<LPCDCAILFOA> FLEHEHANDKI(int DEPJAMELNGJ, [CanBeNull] NNENOOPKHPC IDBNBECJKFH, EJCOGPHMIIO NNIPLGKEGFJ, long HAMIEGOKEJC, long KIBMHJEFMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D916A0", Offset = "0x2D8FEA0", VA = "0x182D916A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJNPFODKFCC))]
	private Task<CAIGCNABMEN> EKKOIDDDLEH(string APOLELLKJLH, int DEPJAMELNGJ, EJCOGPHMIIO NNIPLGKEGFJ, long HAMIEGOKEJC, long KIBMHJEFMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D918A0", Offset = "0x2D900A0", VA = "0x182D918A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ODKABEEKPHI))]
	public Task<FHMBHNPINBI> FCKBKOIHOBA(int DEPJAMELNGJ, NNENOOPKHPC? IDBNBECJKFH, EJCOGPHMIIO NNIPLGKEGFJ, long HAMIEGOKEJC, long KIBMHJEFMKG, IEGAONCOOPP FEBGOIPDFBI, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal class LCLBBEMHFDA : HALIFADCDEK
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class MFCMCIEHPBF
	{
		[Cpp2IlInjected.Token(Token = "0x200019B")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007CF")]
			public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007D0")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007D1")]
			public MFCMCIEHPBF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007D2")]
			private EJCOGPHMIIO <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			private FHMBHNPINBI <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			private EJCOGPHMIIO <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007D5")]
			private FHMBHNPINBI <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007D6")]
			private TaskAwaiter<EJCOGPHMIIO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007D7")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78FE10", Offset = "0x78F210")]
			private TaskAwaiter<FHMBHNPINBI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x5980D60", Offset = "0x597F560", VA = "0x185980D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		public LCLBBEMHFDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public ODEOHNPPJCE serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		public CHIPOCIBCNK uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public IEGAONCOOPP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MFCMCIEHPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x42B8720", Offset = "0x42B6F20", VA = "0x1842B8720")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<FHMBHNPINBI> PCEIDODDIHH(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class FMDBOPNMOGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		public LCLBBEMHFDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		private MFCMCIEHPBF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		private NKHBPCPCMLJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		private BNNPCINDEGK <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		private GKJHOLDCGPO <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		private FHMBHNPINBI <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private FHMBHNPINBI <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FMDBOPNMOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x42AF6D0", Offset = "0x42ADED0", VA = "0x1842AF6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007C4")]
	private readonly int DEPJAMELNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007C5")]
	[CanBeNull]
	private readonly NNENOOPKHPC IDBNBECJKFH;

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x3489D90", Offset = "0x3488590", VA = "0x183489D90")]
	public LCLBBEMHFDA(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, int DEPJAMELNGJ, NNENOOPKHPC IDBNBECJKFH, FFLEKJBGAJJ KPFEABGPNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x3489960", Offset = "0x3488160", VA = "0x183489960", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FMDBOPNMOGD))]
	protected override Task FKNGBCPGLCB(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x3489CA0", Offset = "0x34884A0", VA = "0x183489CA0")]
	private void JPHFHFFKPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x3489B00", Offset = "0x3488300", VA = "0x183489B00")]
	private void HKGIIPEFMJN(AALOEEPNEOP LEBCJIHOHHE, NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200019E")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007EC")]
			public BOHAGPJNCEM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007ED")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007EE")]
			public BOHAGPJNCEM HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007EF")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007F0")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007F1")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		private static BOHAGPJNCEM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		private Dictionary<BOHAGPJNCEM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x349B4D0", Offset = "0x3499CD0", VA = "0x18349B4D0")]
		public bool NAAMKNMDFAH(BOHAGPJNCEM BBMNNPEOJDE, out ResultConfig CEHJOFICIAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x349BCC0", Offset = "0x349A4C0", VA = "0x18349BCC0")]
		public ResultConfig PLBLPCLNKFG(BOHAGPJNCEM MDCIFHCDMMF, [Optional] HashSet<BOHAGPJNCEM> OFHNCJNEKJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x349BAC0", Offset = "0x349A2C0", VA = "0x18349BAC0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x349B540", Offset = "0x3499D40", VA = "0x18349B540", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xBBBD50", Offset = "0xBBA550", VA = "0x180BBBD50")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public class FJHFJBECMEA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F270", Offset = "0x2D9DA70", VA = "0x182D9F270")]
	public FJHFJBECMEA(string DKIECHCHJFL, Exception NCFNHKNLKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public class KEOPDAFDAHG
{
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	private sealed class IPCMFCLNHIL : BLPMDLHIELF, IEquatable<BLPMDLHIELF>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A3")]
		[CompilerGenerated]
		private sealed class CHPMLPJPPLJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007FF")]
			public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			public IPCMFCLNHIL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			private NCFBJHOACDL <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			private IEMLKNOFDEG <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			private LCMHJBMHMJN <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000804")]
			private IEMLKNOFDEG <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000805")]
			private IDIFMABCDLA <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000806")]
			private TaskAwaiter<IEMLKNOFDEG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			private TaskAwaiter<IDIFMABCDLA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public CHPMLPJPPLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x5977120", Offset = "0x5975920", VA = "0x185977120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		private readonly BNNPCINDEGK OPEBBEJDEPM;

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public int EECDPPIJLCA
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x8AD980", Offset = "0x8AC180", VA = "0x1808AD980", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public JPNGCEFMBEO LMALIKDMCJD
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		private DateTime IDCJKOENPIG
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x42B3AE0", Offset = "0x42B22E0", VA = "0x1842B3AE0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public ELODCOFCJAF? KAEGAPFLFGA
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xA35FF0", Offset = "0xA347F0", VA = "0x180A35FF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public PPBPIDGBPHI? ALGACNOOCCH
		{
			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x18CF630", Offset = "0x18CDE30", VA = "0x1818CF630", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public GAOMACELHLE KMHICIJNHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x7F2890", Offset = "0x7F1090", VA = "0x1807F2890", Slot = "10")]
			get
			{
				return default(GAOMACELHLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x42B3B00", Offset = "0x42B2300", VA = "0x1842B3B00", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(CHPMLPJPPLJ))]
		public Task<IDIFMABCDLA> BEIHBPAMODO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x42B3E70", Offset = "0x42B2670", VA = "0x1842B3E70")]
		public IPCMFCLNHIL(int LMMJHNPOCPO, JPNGCEFMBEO IDOMIIDIAPH, BNNPCINDEGK OPEBBEJDEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x42B3CF0", Offset = "0x42B24F0", VA = "0x1842B3CF0", Slot = "11")]
		public bool Equals(BLPMDLHIELF MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x42B3C50", Offset = "0x42B2450", VA = "0x1842B3C50", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x42B3E20", Offset = "0x42B2620", VA = "0x1842B3E20")]
		private bool OCDFPFBBPDN(IPCMFCLNHIL MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x42B3D90", Offset = "0x42B2590", VA = "0x1842B3D90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	private sealed class HCAOPLFDEKA : BLPMDLHIELF, IEquatable<BLPMDLHIELF>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A5")]
		[CompilerGenerated]
		private sealed class MEGAMAFHOJO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400080B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400080C")]
			public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400080D")]
			public HCAOPLFDEKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400080E")]
			private IDIFMABCDLA <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400080F")]
			private TaskAwaiter<IDIFMABCDLA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public MEGAMAFHOJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x597D4A0", Offset = "0x597BCA0", VA = "0x18597D4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		private readonly HCKACEFMPCF GAPOOPBJCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000809")]
		private readonly ELODCOFCJAF IKLIILIFHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		private readonly PPBPIDGBPHI PGKCKACBLMK;

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public int EECDPPIJLCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x42B12D0", Offset = "0x42AFAD0", VA = "0x1842B12D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public JPNGCEFMBEO LMALIKDMCJD
		{
			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x42B0F00", Offset = "0x42AF700", VA = "0x1842B0F00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		private DateTime IDCJKOENPIG
		{
			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x42B0F50", Offset = "0x42AF750", VA = "0x1842B0F50", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public ELODCOFCJAF? KAEGAPFLFGA
		{
			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x42B1320", Offset = "0x42AFB20", VA = "0x1842B1320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public PPBPIDGBPHI? ALGACNOOCCH
		{
			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x42B1370", Offset = "0x42AFB70", VA = "0x1842B1370", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public GAOMACELHLE KMHICIJNHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x8C80F0", Offset = "0x8C68F0", VA = "0x1808C80F0", Slot = "10")]
			get
			{
				return default(GAOMACELHLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x9D6680", Offset = "0x9D4E80", VA = "0x1809D6680")]
		public HCAOPLFDEKA(HCKACEFMPCF IPKBJACGFCO, ELODCOFCJAF KEEOJFLMHOO, PPBPIDGBPHI HNLBDKLBBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x42B0FA0", Offset = "0x42AF7A0", VA = "0x1842B0FA0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MEGAMAFHOJO))]
		public Task<IDIFMABCDLA> BEIHBPAMODO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x42B11A0", Offset = "0x42AF9A0", VA = "0x1842B11A0", Slot = "11")]
		public bool Equals(BLPMDLHIELF MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x42B10F0", Offset = "0x42AF8F0", VA = "0x1842B10F0", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x42B13C0", Offset = "0x42AFBC0", VA = "0x1842B13C0")]
		private bool OCDFPFBBPDN(HCAOPLFDEKA MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x42B1240", Offset = "0x42AFA40", VA = "0x1842B1240", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	private sealed class COPIGHDKAHJ : BLPMDLHIELF, IEquatable<BLPMDLHIELF>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A7")]
		[CompilerGenerated]
		private sealed class DHODAFONGEN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000813")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000814")]
			public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000815")]
			public COPIGHDKAHJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000816")]
			private IDIFMABCDLA <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000817")]
			private TaskAwaiter<IDIFMABCDLA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public DHODAFONGEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x5977E10", Offset = "0x5976610", VA = "0x185977E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000810")]
		private readonly JPNGCEFMBEO FPKDIDHPIAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		private readonly ELODCOFCJAF IKLIILIFHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private readonly PPBPIDGBPHI PGKCKACBLMK;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public int EECDPPIJLCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x42AB950", Offset = "0x42AA150", VA = "0x1842AB950", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		[NotNull]
		public JPNGCEFMBEO LMALIKDMCJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private DateTime IDCJKOENPIG
		{
			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F1E10", VA = "0x1807F3610", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public ELODCOFCJAF? KAEGAPFLFGA
		{
			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x42AB9D0", Offset = "0x42AA1D0", VA = "0x1842AB9D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public PPBPIDGBPHI? ALGACNOOCCH
		{
			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x42ABA20", Offset = "0x42AA220", VA = "0x1842ABA20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public GAOMACELHLE KMHICIJNHNL
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F1E10", VA = "0x1807F3610", Slot = "10")]
			get
			{
				return default(GAOMACELHLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x9D6680", Offset = "0x9D4E80", VA = "0x1809D6680")]
		public COPIGHDKAHJ(JPNGCEFMBEO IDOMIIDIAPH, ELODCOFCJAF KEEOJFLMHOO, PPBPIDGBPHI HNLBDKLBBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x42AB4E0", Offset = "0x42A9CE0", VA = "0x1842AB4E0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(DHODAFONGEN))]
		public Task<IDIFMABCDLA> BEIHBPAMODO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x42AB770", Offset = "0x42A9F70", VA = "0x1842AB770", Slot = "11")]
		public bool Equals(BLPMDLHIELF MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x42AB630", Offset = "0x42A9E30", VA = "0x1842AB630", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x42AB8A0", Offset = "0x42AA0A0", VA = "0x1842AB8A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x42ABA70", Offset = "0x42AA270", VA = "0x1842ABA70")]
		private bool OCDFPFBBPDN(COPIGHDKAHJ MDHJAFNLPON)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class MCDNHJEANGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		public AsyncTaskMethodBuilder<IList<BLPMDLHIELF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		public KEOPDAFDAHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		private IReadOnlyList<BNNPCINDEGK> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		private IReadOnlyList<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		private List<BLPMDLHIELF> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		private HCKACEFMPCF <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private IReadOnlyList<BNNPCINDEGK> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private IReadOnlyList<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		private IEnumerator<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400082D")]
		private (int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400082E")]
		private HCAOPLFDEKA <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400082F")]
		private TaskAwaiter<IReadOnlyList<BNNPCINDEGK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000830")]
		private TaskAwaiter<IReadOnlyList<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MCDNHJEANGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x42B7AA0", Offset = "0x42B62A0", VA = "0x1842B7AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private sealed class APNOHBHKDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000831")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000832")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000833")]
		public IReadOnlyList<BNNPCINDEGK> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000834")]
		public KEOPDAFDAHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000835")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000836")]
		private IReadOnlyList<JPNGCEFMBEO> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000837")]
		private Dictionary<ObscuredInt, JPNGCEFMBEO> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		private List<(int, JPNGCEFMBEO, BNNPCINDEGK)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000839")]
		private IReadOnlyList<JPNGCEFMBEO> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400083A")]
		private IEnumerator<BNNPCINDEGK> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400083B")]
		private BNNPCINDEGK <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400083C")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400083D")]
		private JPNGCEFMBEO <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400083E")]
		private JPNGCEFMBEO <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		private TaskAwaiter<IReadOnlyList<JPNGCEFMBEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public APNOHBHKDBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x42AA550", Offset = "0x42A8D50", VA = "0x1842AA550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F7")]
	private readonly GJANOCFHBPK CMNEEKOFKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F8")]
	private readonly DENCMPHLPHJ LHNLEFIGMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	private readonly LCAFMEKLLGH MFKMPKPAPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40007FA")]
	private readonly global::PBGCPGFJPND<(long, long), IReadOnlyList<BNNPCINDEGK>> DCHEGGFINJM;

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x3486D60", Offset = "0x3485560", VA = "0x183486D60")]
	[UnityEngine.Scripting.Preserve]
	public KEOPDAFDAHG([ACEKLAKDMBL(null)] DENCMPHLPHJ FLKNEJKHELK, [ACEKLAKDMBL(null)] LCAFMEKLLGH POCJMJBNADK, [ACEKLAKDMBL(null)] GJANOCFHBPK MPDJMFEEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x34868A0", Offset = "0x34850A0", VA = "0x1834868A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MCDNHJEANGP))]
	public Task<IList<BLPMDLHIELF>> BDKEOJFGKDI(long HAMIEGOKEJC, long BPODGJMCBKI, bool MPBKGNHECHB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x3486A40", Offset = "0x3485240", VA = "0x183486A40")]
	private bool GMIOAFCEBPH(DateTime? ELKAIOOFKHB, long HAMIEGOKEJC, long BPODGJMCBKI, out HCKACEFMPCF ANGBHDDNJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x3486BF0", Offset = "0x34853F0", VA = "0x183486BF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(APNOHBHKDBE))]
	private Task<IReadOnlyList<(int, JPNGCEFMBEO, BNNPCINDEGK)>> ICKPHPMDOBP(IReadOnlyList<BNNPCINDEGK> BJLMLGFPNLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal class OPCFEDDKIDK : DENCMPHLPHJ
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private sealed class HCKLADHBMLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000840")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000841")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BNNPCINDEGK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000842")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000843")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000844")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000845")]
		public OPCFEDDKIDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000846")]
		private global::LFEMLMBOIIA<BNNPCINDEGK> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000847")]
		private global::LFEMLMBOIIA<BNNPCINDEGK> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000848")]
		private TaskAwaiter<global::LFEMLMBOIIA<BNNPCINDEGK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HCKLADHBMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x5979C80", Offset = "0x5978480", VA = "0x185979C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class ILEBKOFIMIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000849")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400084A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<JPNGCEFMBEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400084B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400084C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400084D")]
		public OPCFEDDKIDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400084E")]
		private List<JPNGCEFMBEO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400084F")]
		private TaskAwaiter<List<JPNGCEFMBEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ILEBKOFIMIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x597AA30", Offset = "0x5979230", VA = "0x18597AA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	[UnityEngine.Scripting.Preserve]
	public OPCFEDDKIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x3496F70", Offset = "0x3495770", VA = "0x183496F70", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HCKLADHBMLA))]
	public Task<IReadOnlyList<BNNPCINDEGK>> JFNDJCEHLNG(long HAMIEGOKEJC, long KIBMHJEFMKG, [Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x3497120", Offset = "0x3495920", VA = "0x183497120", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ILEBKOFIMIJ))]
	public Task<IReadOnlyList<JPNGCEFMBEO>> MEOGEJOBDCB(IReadOnlyList<int> IJNHKBOELBC, [Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public interface DENCMPHLPHJ
{
	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<BNNPCINDEGK>> JFNDJCEHLNG(long HAMIEGOKEJC, long KIBMHJEFMKG, [Optional] CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<JPNGCEFMBEO>> MEOGEJOBDCB(IReadOnlyList<int> IJNHKBOELBC, [Optional] CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public interface BLPMDLHIELF : IEquatable<BLPMDLHIELF>
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	int EECDPPIJLCA
	{
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	[CanBeNull]
	JPNGCEFMBEO LMALIKDMCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	DateTime NNFBFGJNNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	ELODCOFCJAF? KAEGAPFLFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	PPBPIDGBPHI? ALGACNOOCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	[CanBeNull]
	GAOMACELHLE KMHICIJNHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000764")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IDIFMABCDLA> BEIHBPAMODO();
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public enum GAOMACELHLE
{
	[Cpp2IlInjected.Token(Token = "0x4000851")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000852")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000853")]
	DiskAutosave
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000766")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
	{
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
