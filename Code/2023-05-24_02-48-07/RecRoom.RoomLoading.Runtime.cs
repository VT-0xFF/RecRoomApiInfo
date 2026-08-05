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
		[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
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
		[Cpp2IlInjected.Address(RVA = "0x326CC30", Offset = "0x326B830", VA = "0x18326CC30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x852750", Offset = "0x851350", VA = "0x180852750")]
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
		[Cpp2IlInjected.Address(RVA = "0xC81930", Offset = "0xC80530", VA = "0x180C81930")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JLJHFIHPDNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F7DBE0", Offset = "0x3F7C7E0", VA = "0x183F7DBE0")]
		internal object KCDDEDEMLNP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BOHNLHMBPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF250", Offset = "0x2ADDE50", VA = "0x182ADF250", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFB80", Offset = "0x2ADE780", VA = "0x182ADFB80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KGMACCFPPHI FEPFLACKKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF1B0", Offset = "0x2ADDDB0", VA = "0x182ADF1B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF560", Offset = "0x2ADE160", VA = "0x182ADF560", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event KGMACCFPPHI GOIAEEEILBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFAE0", Offset = "0x2ADE6E0", VA = "0x182ADFAE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF110", Offset = "0x2ADDD10", VA = "0x182ADF110", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event KGMACCFPPHI LJENEBHMOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFCC0", Offset = "0x2ADE8C0", VA = "0x182ADFCC0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFC20", Offset = "0x2ADE820", VA = "0x182ADFC20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NBGKOOKNBGP, bool> KFAMNOAKCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF7B0", Offset = "0x2ADE3B0", VA = "0x182ADF7B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF600", Offset = "0x2ADE200", VA = "0x182ADF600", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "19")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF2F0", Offset = "0x2ADDEF0", VA = "0x182ADF2F0", Slot = "14")]
	public void DCAJNDNNNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF780", Offset = "0x2ADE380", VA = "0x182ADF780", Slot = "15")]
	public void IHKAKCADEFN(NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF6A0", Offset = "0x2ADE2A0", VA = "0x182ADF6A0", Slot = "16")]
	public void GGHKLMBDLFL(NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2ADFAB0", Offset = "0x2ADE6B0", VA = "0x182ADFAB0", Slot = "17")]
	public void NECNIDCBHOL(NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF6D0", Offset = "0x2ADE2D0", VA = "0x182ADF6D0", Slot = "18")]
	public void HGDIGCPPJBC(NBGKOOKNBGP KAINKNJPFIL, bool GGKLFMPBGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF850", Offset = "0x2ADE450", VA = "0x182ADF850")]
	private void MKOHINBGHOB(KGMACCFPPHI NMPOOPDGJFD, NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB601A0", Offset = "0xB5EDA0", VA = "0x180B601A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xAF3280", Offset = "0xAF1E80", VA = "0x180AF3280")]
	public GDNNMLKFEHK(IDictionary<object, object> CBLNAPKAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5430", Offset = "0x2AD4030", VA = "0x182AD5430")]
	public bool EHMCOLBLMFF(out FHMBHNPINBI DKIECHCHJFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD55E0", Offset = "0x2AD41E0", VA = "0x182AD55E0")]
	public Guid LDBDBOFBKGH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5320", Offset = "0x2AD3F20", VA = "0x182AD5320")]
	public IDIFMABCDLA DLABMAIJNIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2AD54F0", Offset = "0x2AD40F0", VA = "0x182AD54F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IFFEFMAKIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3F7BB20", Offset = "0x3F7A720", VA = "0x183F7BB20")]
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
	[Cpp2IlInjected.Address(RVA = "0x2AE3A80", Offset = "0x2AE2680", VA = "0x182AE3A80", Slot = "4")]
	public void IAAGAGMBLDF(KCEEEPMPGFI JNHEDBAKBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3AE0", Offset = "0x2AE26E0", VA = "0x182AE3AE0", Slot = "5")]
	public void KNLMDMHCHJC(KCEEEPMPGFI JNHEDBAKBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3810", Offset = "0x2AE2410", VA = "0x182AE3810", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3860", Offset = "0x2AE2460", VA = "0x182AE3860")]
	protected IDIFMABCDLA HMEFICDIDBP(IGGCDPKBFGF AOLFPABEEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE980", Offset = "0x2ACD580", VA = "0x182ACE980")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GHOCBABIKGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A380", Offset = "0x3F78F80", VA = "0x183F7A380")]
		internal bool GDIHPPBMEEH(MPOOILGCDLJ s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0C90", Offset = "0x2ADF890", VA = "0x182AE0C90")]
	public static LCMHJBMHMJN JLAKJAPJOGA(long HBCPJJJHDAN, long KIBMHJEFMKG, string APOLELLKJLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0D30", Offset = "0x2ADF930", VA = "0x182AE0D30")]
	public static LCMHJBMHMJN JLAKJAPJOGA(long HBCPJJJHDAN, long KIBMHJEFMKG, EFENBEKLEHO IKHHHDILDNK, long PJBAEAJLHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0910", Offset = "0x2ADF510", VA = "0x182AE0910")]
	public static LCMHJBMHMJN JLAKJAPJOGA(LPCDCAILFOA GLAABCHHFKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0A50", Offset = "0x2ADF650", VA = "0x182AE0A50")]
	public static LCMHJBMHMJN JLAKJAPJOGA(IEMLKNOFDEG FFKPMIAJOHJ, BNNPCINDEGK HKLLDLGPABG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0800", Offset = "0x2ADF400", VA = "0x182AE0800")]
	public static LCMHJBMHMJN GGHJIOOPGLA(this LCMHJBMHMJN MEKBNGFFPML, IEMLKNOFDEG APOIMGJBMKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0670", Offset = "0x2ADF270", VA = "0x182AE0670")]
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
	[Cpp2IlInjected.Address(RVA = "0x326CC10", Offset = "0x326B810", VA = "0x18326CC10")]
	public NKHBPCPCMLJ(long HBCPJJJHDAN, long KIBMHJEFMKG, GHLDFOEBGAC FIJCKHKKDCC, [CanBeNull] Exception BLBJGIOFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x326CBC0", Offset = "0x326B7C0", VA = "0x18326CBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DDCDIGKHNIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3F764A0", Offset = "0x3F750A0", VA = "0x183F764A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2ADEAD0", Offset = "0x2ADD6D0", VA = "0x182ADEAD0", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE870", Offset = "0x2ADD470", VA = "0x182ADE870", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE720", Offset = "0x2ADD320", VA = "0x182ADE720", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDCDIGKHNIP))]
	public Task DBEOFEALEMN(string FMALCPACLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE8C0", Offset = "0x2ADD4C0", VA = "0x182ADE8C0", Slot = "4")]
	public IDIFMABCDLA IGGGLNHPCKG(IGGCDPKBFGF AEEBHLKEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE980", Offset = "0x2ADD580", VA = "0x182ADE980")]
	private HALPBDECPOJ NFBENPIHNDC(string FMALCPACLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
	[CompilerGenerated]
	private sealed class IKLDFDIBKPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public OAEILIIIPED customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Task <task>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IKLDFDIBKPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x489FF90", Offset = "0x489EB90", VA = "0x18489FF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CFEFEBAGGBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public OAEILIIIPED customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private global::JAPPGKMKBNF<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private AALOEEPNEOP <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private FFLEKJBGAJJ <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private LHNHBKFIDPL <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private OperationCanceledException <oce>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CFEFEBAGGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4899900", Offset = "0x4898500", VA = "0x184899900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MDLDCNFIHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Matchmaking.AHFAIMKOKJA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public MCJHCEJFKNC errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MDLDCNFIHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x48A5220", Offset = "0x48A3E20", VA = "0x1848A5220")]
		internal object OHKMOIGJCOE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HGAJGKPKEMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Task<LCMHJBMHMJN> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HGAJGKPKEMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
		internal Task<LCMHJBMHMJN> AKPBEMHJNJB(AALOEEPNEOP _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MLODGCFIPNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public OAEILIIIPED customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FFLEKJBGAJJ joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private EIBOJBKNGCC <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private AALOEEPNEOP <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private HGAJGKPKEMC <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private JJMPNGLGHEG <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private Task<Matchmaking.MDKPNMHIPCM> <serverConnectionInfoTask>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private IAEAGHMOCOM <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private Matchmaking.MDKPNMHIPCM <serverConnectionInfo>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private AALOEEPNEOP <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private CancellationTokenSource <loadingScreenCts>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private AALOEEPNEOP <loadingScreenScope>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Matchmaking.MDKPNMHIPCM <>s__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private CancellationTokenSource <photonJoinedTokenSource>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private CancellationToken <photonJoinedToken>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private LCMHJBMHMJN <initialRoomLoadPayload>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private Task <roomLoadTask>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private LCMHJBMHMJN <>s__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private AALOEEPNEOP <>s__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Matchmaking.MDKPNMHIPCM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<LCMHJBMHMJN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MLODGCFIPNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x48A5A30", Offset = "0x48A4630", VA = "0x1848A5A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class IPPENAIOHFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private AALOEEPNEOP <disconnectTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private object <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private Exception <ex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private AALOEEPNEOP <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IPPENAIOHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x48A05C0", Offset = "0x489F1C0", VA = "0x1848A05C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class ONPEJEJFHPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private MHOBEFMLEFD <roomContainer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ONPEJEJFHPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x48A9C90", Offset = "0x48A8890", VA = "0x1848A9C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class NJHAKGNJFEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<Matchmaking.MDKPNMHIPCM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AALOEEPNEOP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Matchmaking.MDKPNMHIPCM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<Matchmaking.MDKPNMHIPCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NJHAKGNJFEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x48A8B40", Offset = "0x48A7740", VA = "0x1848A8B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class LGAJEOKPIGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Matchmaking.MDKPNMHIPCM serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public FFLEKJBGAJJ joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private AALOEEPNEOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private ALKMAGMAGJP <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<ALKMAGMAGJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LGAJEOKPIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x48A4AC0", Offset = "0x48A36C0", VA = "0x1848A4AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EBPCMKIGLEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public EBPCMKIGLEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class PNGENAHCBPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public EBPCMKIGLEF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public PNGENAHCBPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x48AA7C0", Offset = "0x48A93C0", VA = "0x1848AA7C0")]
		internal object DPJFJFDJNML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x48AA8C0", Offset = "0x48A94C0", VA = "0x1848AA8C0")]
		internal string FKNBAHPGOBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NIMIIEEPIHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private EBPCMKIGLEF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private PNGENAHCBPI <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NIMIIEEPIHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x48A7F40", Offset = "0x48A6B40", VA = "0x1848A7F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class ACPNDFGMPKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public LCMHJBMHMJN initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public EIBOJBKNGCC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public MHKEFJDKLJN targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public FFLEKJBGAJJ joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private AALOEEPNEOP <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private FFLEKJBGAJJ <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private GNPGFJFMNHD <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ACPNDFGMPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4897330", Offset = "0x4895F30", VA = "0x184897330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class BMDNEALEOMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private AALOEEPNEOP <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private AALOEEPNEOP <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private AALOEEPNEOP <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BMDNEALEOMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4898470", Offset = "0x4897070", VA = "0x184898470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NMPOKEMLAAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <version>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private bool <canUpdateRoom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private bool <shouldSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6E")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter<IDIFMABCDLA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NMPOKEMLAAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x48A8F40", Offset = "0x48A7B40", VA = "0x1848A8F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class ECDFMAIKKAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ECDFMAIKKAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x489BFE0", Offset = "0x489ABE0", VA = "0x18489BFE0")]
		internal object EKJPFBHMGOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class ECDHAOKOLCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ECDHAOKOLCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x489C1B0", Offset = "0x489ADB0", VA = "0x18489C1B0")]
		internal void EPOENJKLLOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BJJKBBMKDGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BJJKBBMKDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x48983F0", Offset = "0x4896FF0", VA = "0x1848983F0")]
		internal object CBMOLFNGPDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class KFPPHNLEOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KFPPHNLEOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x48A30E0", Offset = "0x48A1CE0", VA = "0x1848A30E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA14130", Offset = "0xA12D30", VA = "0x180A14130", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA14310", Offset = "0xA12F10", VA = "0x180A14310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2AD2BF0", Offset = "0x2AD17F0", VA = "0x182AD2BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2AD3A40", Offset = "0x2AD2640", VA = "0x182AD3A40", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1210", Offset = "0x2ACFE10", VA = "0x182AD1210", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2AD31B0", Offset = "0x2AD1DB0", VA = "0x182AD31B0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKLDFDIBKPF))]
	public Task MHKIGANIEGO(MHKEFJDKLJN FKMIOMCKJNF, OAEILIIIPED LBJHHPLDPCI, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2AD00A0", Offset = "0x2ACECA0", VA = "0x182AD00A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CFEFEBAGGBN))]
	private Task CGIPLDAAFAH(MHKEFJDKLJN FKMIOMCKJNF, OAEILIIIPED LBJHHPLDPCI, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2C40", Offset = "0x2AD1840", VA = "0x182AD2C40")]
	private static void KPBAOOGCADH(PILPGHODDIG DCLPNPGHFLG, MHKEFJDKLJN FKMIOMCKJNF, Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2AD07E0", Offset = "0x2ACF3E0", VA = "0x182AD07E0")]
	private static void DIEMECHABJC(LHNHBKFIDPL AMMNKIJKPDJ, Exception BPFOEEABMGN, [Optional] List<int> JACAFHEHNAG, int ABAHDMMJMOJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1260", Offset = "0x2ACFE60", VA = "0x182AD1260")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MLODGCFIPNH))]
	private Task EDNHHFMPDPN(AALOEEPNEOP IDIJCJCNEPO, MHKEFJDKLJN FKMIOMCKJNF, OAEILIIIPED LBJHHPLDPCI, FFLEKJBGAJJ AKKJBLMHLIA, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2130", Offset = "0x2AD0D30", VA = "0x182AD2130")]
	private void HMOBBLALHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2AD27C0", Offset = "0x2AD13C0", VA = "0x182AD27C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IPPENAIOHFD))]
	private Task JCNGLBIDPLK(AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1770", Offset = "0x2AD0370", VA = "0x182AD1770")]
	private void GHADILLMHAE(MHKEFJDKLJN FKMIOMCKJNF, CancellationToken KHEICKPBIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD3350", Offset = "0x2AD1F50", VA = "0x182AD3350")]
	private void MKONBMMDEPH(MHKEFJDKLJN FKMIOMCKJNF, FFLEKJBGAJJ AKKJBLMHLIA, OperationCanceledException ADBKJDGABDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2AD3610", Offset = "0x2AD2210", VA = "0x182AD3610")]
	private void NOGAPIEKDIK(MHKEFJDKLJN FKMIOMCKJNF, FFLEKJBGAJJ AKKJBLMHLIA, Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1E90", Offset = "0x2AD0A90", VA = "0x182AD1E90")]
	private void HEBPEAEIBII(MHKEFJDKLJN FKMIOMCKJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1440", Offset = "0x2AD0040", VA = "0x182AD1440")]
	private static NKHBPCPCMLJ FKJINFCCHJK(MHKEFJDKLJN FKMIOMCKJNF)
	{
		return default(NKHBPCPCMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2AD3090", Offset = "0x2AD1C90", VA = "0x182AD3090")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ONPEJEJFHPL))]
	private Task LDHEDJCKKNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD05B0", Offset = "0x2ACF1B0", VA = "0x182AD05B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NJHAKGNJFEK))]
	private Task<Matchmaking.MDKPNMHIPCM> DFLBCCECPHL(MHKEFJDKLJN FKMIOMCKJNF, AALOEEPNEOP IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1480", Offset = "0x2AD0080", VA = "0x182AD1480")]
	private static ALKMAGMAGJP GCINHMJMIBO(MHKEFJDKLJN FKMIOMCKJNF, Matchmaking.MDKPNMHIPCM DBNNJNHMJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2280", Offset = "0x2AD0E80", VA = "0x182AD2280")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LGAJEOKPIGE))]
	private Task HONKCHJMJNF(MHKEFJDKLJN FKMIOMCKJNF, Matchmaking.MDKPNMHIPCM DBNNJNHMJEO, FFLEKJBGAJJ AKKJBLMHLIA, AALOEEPNEOP IDIJCJCNEPO, CancellationToken FFDAINFFMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2AD15D0", Offset = "0x2AD01D0", VA = "0x182AD15D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NIMIIEEPIHN))]
	private Task GENDOCHGIOJ(MHKEFJDKLJN FKMIOMCKJNF, CancellationTokenSource DNBLDELONJP, Task ACMLNKHHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2AD0240", Offset = "0x2ACEE40", VA = "0x182AD0240")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ACPNDFGMPKI))]
	private Task CHALEMKNDHH(LCMHJBMHMJN CMKABAANNAK, EIBOJBKNGCC OOKFEKMLPEH, MHKEFJDKLJN NPDJMDFNEOF, FFLEKJBGAJJ ACHLGGINKLE, AALOEEPNEOP IDIJCJCNEPO, CancellationToken FJDDBFFNBFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1C40", Offset = "0x2AD0840", VA = "0x182AD1C40")]
	private FFLEKJBGAJJ HDHABNEMDJJ(FFLEKJBGAJJ ACHLGGINKLE, ref CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2AD0440", Offset = "0x2ACF040", VA = "0x182AD0440")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMDNEALEOMN))]
	private Task CHKBFLMHBLG(AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1AD0", Offset = "0x2AD06D0", VA = "0x182AD1AD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NMPOKEMLAAF))]
	private Task GHEDFKBBANB(MOMCOKAPMLC PHBHEFAPHDL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2AD38D0", Offset = "0x2AD24D0", VA = "0x182AD38D0")]
	private static void ONPCOIPELPC(MHKEFJDKLJN FKMIOMCKJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2A20", Offset = "0x2AD1620", VA = "0x182AD2A20")]
	private void JMHGEGDHJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2AD0750", Offset = "0x2ACF350", VA = "0x182AD0750")]
	private void DFMLOGALDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2460", Offset = "0x2AD1060", VA = "0x182AD2460")]
	private void HONNJFFJNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2AD24F0", Offset = "0x2AD10F0", VA = "0x182AD24F0")]
	private void IAEKDAJDLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2ACFF10", Offset = "0x2ACEB10", VA = "0x182ACFF10")]
	private static void CDKDGAGHKDN(MHKEFJDKLJN FKMIOMCKJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2ACFE50", Offset = "0x2ACEA50", VA = "0x182ACFE50")]
	private static void BNHJKHBFKON(MHKEFJDKLJN FKMIOMCKJNF, CancellationToken FFDAINFFMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2AD3E70", Offset = "0x2AD2A70", VA = "0x182AD3E70")]
	private static void PPIELFOOPOD(MHKEFJDKLJN FKMIOMCKJNF, Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2580", Offset = "0x2AD1180", VA = "0x182AD2580")]
	private void IOFDGLJIDCH(MHKEFJDKLJN FKMIOMCKJNF, Task ACMLNKHHEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2930", Offset = "0x2AD1530", VA = "0x182AD2930")]
	private static void JGIMFEIAGIB(Func<string> BAMBEECFNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4100", Offset = "0x2AD2D00", VA = "0x182AD4100")]
	public FGJHIEFNNDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2ACFDE0", Offset = "0x2ACE9E0", VA = "0x182ACFDE0")]
	[CompilerGenerated]
	internal static (int, int?) BEJDIGKINMC(MCJHCEJFKNC EGMEOIADPFI)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MHMLFGJNJKA
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> EGAAIFMLOKP(string OPOLKMBAJBK, long BFNOJMGJLFG, MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class LNLKNBEENCP : global::CDLOOCIEHKO<FHMBHNPINBI>
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class PDOIMKEBDKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public FHMBHNPINBI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public PDOIMKEBDKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F84890", Offset = "0x3F83490", VA = "0x183F84890")]
		internal object GFMPDMHHECN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly LNLKNBEENCP EABDDJEADPB;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private const string GLOKGMEJOAH = "pl";

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3267650", Offset = "0x3266250", VA = "0x183267650")]
	public ExitGames.Client.Photon.Hashtable ECCPKOGLKLF(FHMBHNPINBI DKIECHCHJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3267510", Offset = "0x3266110", VA = "0x183267510", Slot = "5")]
	protected override void AENAENLCIAI(FHMBHNPINBI DKIECHCHJFL, IDictionary<object, object> PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3267860", Offset = "0x3266460", VA = "0x183267860", Slot = "6")]
	public override FHMBHNPINBI NLJPEOGMFGO(IDictionary<object, object> PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x32676D0", Offset = "0x32662D0", VA = "0x1832676D0")]
	private static void JGIMFEIAGIB(string NOLEELEJNKJ, FHMBHNPINBI DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3267AE0", Offset = "0x32666E0", VA = "0x183267AE0")]
	public LNLKNBEENCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3267210", Offset = "0x3265E10", VA = "0x183267210")]
	[CompilerGenerated]
	internal static string ACLKACENCGK(LCMHJBMHMJN MEKBNGFFPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FNOEIOAGCPK<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::PKJAENHCLMN<byte[], CMPFHAIKIAN>> BJBOOMBCAED(TGetDataArg AIMHDAMIMIL, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::PKJAENHCLMN<global::HCLLLJEDILH<TData>, CMPFHAIKIAN> KCDPDOMNJNH(byte[] PHBHEFAPHDL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DPADKKHLKLF : CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDIFMABCDLA KDJGBCGJOCG(IGGCDPKBFGF AOLFPABEEKC);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class FENLOLGCABO : JHDNGKJANJJ, CCNJKCGJAJP, GNOLCLOPLMD, CAJCLGONHEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly CCNJKCGJAJP OMBHPIGDLKI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IGGCDPKBFGF AGOBILJIDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE6F0", Offset = "0x2ACD2F0", VA = "0x182ACE6F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NFFGMOGMHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE7A0", Offset = "0x2ACD3A0", VA = "0x182ACE7A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KEPCAECPIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE370", Offset = "0x2ACCF70", VA = "0x182ACE370", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool LHAPCIJBDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D00", Offset = "0x7F1900", VA = "0x1807F2D00", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int CIFGLBNPOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x85DA90", Offset = "0x85C690", VA = "0x18085DA90", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event CPDEDBIILFH.OFBOMJAMPKF HAHFPDLJMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event FJKGHOIPBKO HGAIJHBEINL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE650", Offset = "0x2ACD250", VA = "0x182ACE650", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE3C0", Offset = "0x2ACCFC0", VA = "0x182ACE3C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> IOFGIAHKHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<IGGCDPKBFGF> AEKDKGLIMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action OKONGAFFGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE1D0", Offset = "0x2ACCDD0", VA = "0x182ACE1D0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE460", Offset = "0x2ACD060", VA = "0x182ACE460", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xE22BE0", Offset = "0xE217E0", VA = "0x180E22BE0")]
	public FENLOLGCABO(CCNJKCGJAJP OMBHPIGDLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE5A0", Offset = "0x2ACD1A0", VA = "0x182ACE5A0", Slot = "8")]
	public bool OAMKKLLHMCJ(byte PJPMIHPOMIA, ExitGames.Client.Photon.Hashtable LPNMAPPAKIO, EBKGAFDELBK NAOEDGLNDNC, SendOptions PPCDNDPNNDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE500", Offset = "0x2ACD100", VA = "0x182ACE500", Slot = "29")]
	public IGGCDPKBFGF LOOGDOFAGGL(int KEAMKJPMALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE270", Offset = "0x2ACCE70", VA = "0x182ACE270", Slot = "16")]
	public IGGCDPKBFGF DNGDHJDCGCA(int AGMAMFDBLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "19")]
	public void ILNAGFHCFLP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "20")]
	public void BBNPAOAMKNC(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "21")]
	public void GBOFAFGNPKK(object FLDJLPKNKKO, bool ALPKOFENEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE740", Offset = "0x2ACD340", VA = "0x182ACE740", Slot = "22")]
	public IDisposable PAOHMNBKIOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "23")]
	private bool CGEGBBJAMFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "24")]
	public void LNOIMNGJBMF(StringBuilder OJPAJPKNCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE350", Offset = "0x2ACCF50", VA = "0x182ACE350", Slot = "25")]
	public bool FKEFOKOCIDM(bool INOACBMBDNM, out string FKPBDLDGFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public void AHKBAGIPMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x161F010", Offset = "0x161DC10", VA = "0x18161F010", Slot = "28")]
	public void CCOFHBPEINO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal struct KJLLMJJEGBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly TaskCompletionSource<(IDIFMABCDLA, Task)> JAGALAEBKOD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Task<(IDIFMABCDLA, Task)> KCIAOCJILBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x32643C0", Offset = "0x3262FC0", VA = "0x1832643C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3264570", Offset = "0x3263170", VA = "0x183264570")]
	public KJLLMJJEGBB(TimeSpan OJHABJHLHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x32642D0", Offset = "0x3262ED0", VA = "0x1832642D0")]
	public void CIPLADFKIMB(Task OIDBJIACCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3264400", Offset = "0x3263000", VA = "0x183264400")]
	public void EHBECJGDFJG(IDIFMABCDLA NPAEKAKKGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3264520", Offset = "0x3263120", VA = "0x183264520")]
	public void MHDHMJHADME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3264490", Offset = "0x3263090", VA = "0x183264490")]
	internal void FEEBNMABKGC(string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class MCGNJCCHDHF : MHPAJLBPAGC, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool OJPMHILIPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private GOMGBFEPMOD ALNIEHFFCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private AIMHFJMEAKL CEHJOFICIAM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GOMGBFEPMOD PFLGINGMBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3268950", Offset = "0x3267550", VA = "0x183268950", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x32689C0", Offset = "0x32675C0", VA = "0x1832689C0", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3268710", Offset = "0x3267310", VA = "0x183268710", Slot = "5")]
	public void DGGMFLBIDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x32686D0", Offset = "0x32672D0", VA = "0x1832686D0", Slot = "6")]
	public void ALFOAEHHOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x32688D0", Offset = "0x32674D0", VA = "0x1832688D0")]
	private Task JGBBPKBNPBD(MLLLMININAO HDCPFIKNJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x32686D0", Offset = "0x32672D0", VA = "0x1832686D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1341480", Offset = "0x1340080", VA = "0x181341480")]
	public MCGNJCCHDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct FBJPNKAEOIC
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class NJKBNBHFCPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public IFNNJAAOEDN manager;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NJKBNBHFCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x48A8F00", Offset = "0x48A7B00", VA = "0x1848A8F00")]
		internal Task GGBNEKFPFPM(MOMCOKAPMLC data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class BDJKMKOJHND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public FBJPNKAEOIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private HCKACEFMPCF <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private JLOOFCOEEHE <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private JLOOFCOEEHE <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private JLOOFCOEEHE <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private TaskAwaiter<JLOOFCOEEHE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter<IDIFMABCDLA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BDJKMKOJHND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4897E40", Offset = "0x4896A40", VA = "0x184897E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class OLLCODFLLBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public FBJPNKAEOIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public OLLCODFLLBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x48A9A30", Offset = "0x48A8630", VA = "0x1848A9A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly CancellationToken GFFFFCALMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly IFNNJAAOEDN GAICNONPFPG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private EPJFONLPCOB HOCOJIBIFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDD40", Offset = "0x2ACC940", VA = "0x182ACDD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE140", Offset = "0x2ACCD40", VA = "0x182ACE140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDEB0", Offset = "0x2ACCAB0", VA = "0x182ACDEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private NABGKEIJMLK ILDDDNKPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD940", Offset = "0x2ACC540", VA = "0x182ACD940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE190", Offset = "0x2ACCD90", VA = "0x182ACE190")]
	public FBJPNKAEOIC(CancellationToken GFFFFCALMCA, IFNNJAAOEDN GAICNONPFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDC90", Offset = "0x2ACC890", VA = "0x182ACDC90")]
	public static NDLLDLNNGKD GBOIJDALJEA(IFNNJAAOEDN GAICNONPFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDB40", Offset = "0x2ACC740", VA = "0x182ACDB40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BDJKMKOJHND))]
	public Task<bool> EBDHDHCPNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDF30", Offset = "0x2ACCB30", VA = "0x182ACDF30")]
	private bool LDNEGFOJHDC(out HCKACEFMPCF ANGBHDDNJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDD90", Offset = "0x2ACC990", VA = "0x182ACDD90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OLLCODFLLBB))]
	private Task KIKPDFAMBCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2ACD990", Offset = "0x2ACC590", VA = "0x182ACD990")]
	private Task<JLOOFCOEEHE> CBJNCOAONJC(HCKACEFMPCF ANKEKAMEAAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class IIEHMOMCDEB : AIMHFJMEAKL
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class FFKLCHMOGNH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly LALKFIOPJMN HNFNHEGHMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly string BDFCACLHAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly T IGBKLJLDCLC;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T MHGNIJCIFFL
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CB0", Offset = "0x7F18B0", VA = "0x1807F2CB0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x83B800", Offset = "0x83A400", VA = "0x18083B800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5100", Offset = "0x2BE3D00", VA = "0x182BE5100")]
		public FFKLCHMOGNH(LALKFIOPJMN HNFNHEGHMIL, string BDFCACLHAFA, T IGBKLJLDCLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4D90", Offset = "0x2BE3990", VA = "0x182BE4D90")]
		private void ODJBEAKLNPD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly LALKFIOPJMN HNFNHEGHMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly FFKLCHMOGNH<TimeSpan> AKNBKBCEEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly FFKLCHMOGNH<TimeSpan> PPGIMDGJPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly FFKLCHMOGNH<TimeSpan> CHOEAEJFIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly FFKLCHMOGNH<TimeSpan> DCIICEAAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly FFKLCHMOGNH<TimeSpan> KKEHLFMKFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly FFKLCHMOGNH<TimeSpan> DHHDLNGGBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly FFKLCHMOGNH<bool> ONGAONCHJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly FFKLCHMOGNH<bool> DFIOOFAGDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly FFKLCHMOGNH<bool> OJACFMKGPMF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan LHJNNILLFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFDE0", Offset = "0x2ADE9E0", VA = "0x182ADFDE0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan EPCMOJLJLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFD60", Offset = "0x2ADE960", VA = "0x182ADFD60", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public TimeSpan DAOBFAELEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFEE0", Offset = "0x2ADEAE0", VA = "0x182ADFEE0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public TimeSpan DPGCFHMEEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFE20", Offset = "0x2ADEA20", VA = "0x182ADFE20", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public TimeSpan PJBMKHDPPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFF20", Offset = "0x2ADEB20", VA = "0x182ADFF20", Slot = "11")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan PLNLHBFIMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFEA0", Offset = "0x2ADEAA0", VA = "0x182ADFEA0", Slot = "12")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool OFDCHEPEDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFDA0", Offset = "0x2ADE9A0", VA = "0x182ADFDA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool HKOPKHIHGKN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFF60", Offset = "0x2ADEB60", VA = "0x182ADFF60", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool JFNNLIFPDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFE60", Offset = "0x2ADEA60", VA = "0x182ADFE60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2ADFFA0", Offset = "0x2ADEBA0", VA = "0x182ADFFA0")]
	[UnityEngine.Scripting.Preserve]
	public IIEHMOMCDEB([ACEKLAKDMBL(null)] LALKFIOPJMN HNFNHEGHMIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal struct EMOAKECFAIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MKOIIBEAJME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public EMOAKECFAIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MKOIIBEAJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x48A5860", Offset = "0x48A4460", VA = "0x1848A5860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly CancellationTokenSource MFGBDLCLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private Task GAKDIIFBLNI;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JDGGFLPNGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC350", Offset = "0x2ACAF50", VA = "0x182ACC350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal Task KCIAOCJILBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC120", Offset = "0x2ACAD20", VA = "0x182ACC120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2ACC380", Offset = "0x2ACAF80", VA = "0x182ACC380")]
	public EMOAKECFAIC(CancellationToken GFFFFCALMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2ACC1A0", Offset = "0x2ACADA0", VA = "0x182ACC1A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MKOIIBEAJME))]
	public Task DNJBHLPIBHG(Func<CancellationToken, List<Task>> GMABPDCFFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2ACC300", Offset = "0x2ACAF00", VA = "0x182ACC300", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal interface MFHIJBENPCO : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIHFEMBJCAM CAILCKFFJIK(Guid PALLEDHBFCO);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CPPHPNNFPKL(Guid PALLEDHBFCO);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LPGMNPDMPPM(Guid PALLEDHBFCO, Task OIDBJIACCJK);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JJNOGDGBEML(Guid PALLEDHBFCO, IDIFMABCDLA GCGJMEIHMMI);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IHLPPHPEFDP(Guid PALLEDHBFCO);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(IDIFMABCDLA, Task)> PDGJMOLMFLF(Guid PALLEDHBFCO);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal interface EPOJINPDBDE : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDIFMABCDLA NMBCIPOHMGE(IGGCDPKBFGF AEEBHLKEAKN, DLLMEMMHNCB GOKELOIKDPH);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDIFMABCDLA GOENMAPECNC(IGGCDPKBFGF AOLFPABEEKC);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDIFMABCDLA OIGJDPDICNH(IGGCDPKBFGF AOLFPABEEKC);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class JCBCMHDOCKC : HMAILMDEICE
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class JPJGKAFGNII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public JCBCMHDOCKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private MHKEFJDKLJN <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private MHKEFJDKLJN <newPresenceRoomInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private float <timeoutTime>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JPJGKAFGNII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3F7DCE0", Offset = "0x3F7C8E0", VA = "0x183F7DCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private const float DEKHCELCOFE = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1050", Offset = "0x2ADFC50", VA = "0x182AE1050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x8366A0", Offset = "0x8352A0", VA = "0x1808366A0")]
	public JCBCMHDOCKC(IFNNJAAOEDN FNIFBLHBOOE, HBPPPIGEKFO FGOMHOJPKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0EE0", Offset = "0x2ADFAE0", VA = "0x182AE0EE0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JPJGKAFGNII))]
	public Task<bool> BFAINGMPNNG(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0E00", Offset = "0x2ADFA00", VA = "0x182AE0E00")]
	[CompilerGenerated]
	private object AFGHHJNLKAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal interface BNEJDHEIHAG : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEBINCHJHOA(FHMBHNPINBI DKIECHCHJFL);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADAEPOMFIHE(FHMBHNPINBI DKIECHCHJFL);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<DLLMEMMHNCB> ADEHAOCABJJ(CancellationToken BOPCGMCIPKA);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal interface NNIOHMBOJFJ : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDIFMABCDLA IGGGLNHPCKG(IGGCDPKBFGF AEEBHLKEAKN);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DBEOFEALEMN(string FMALCPACLGP);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[UnityEngine.Scripting.Preserve]
internal class KNOCBGHMKHM : HLDCIPKGMNF, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class GFJNNKLOBOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public KNOCBGHMKHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GFJNNKLOBOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3F799D0", Offset = "0x3F785D0", VA = "0x183F799D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly PKHKKGNCOIB GEEPKHIECCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private string ACCFGKLOJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private Task NOAJBFJBLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool JHKJEJHMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3264900", Offset = "0x3263500", VA = "0x183264900", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Task NLFPKAMNLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x32646E0", Offset = "0x32632E0", VA = "0x1832646E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7F0400", Offset = "0x7EF000", VA = "0x1807F0400", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3264740", Offset = "0x3263340", VA = "0x183264740", Slot = "6")]
	public void IHJNMAOMFMN(Task GAKDIIFBLNI, string NNLMNOOEFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3264930", Offset = "0x3263530", VA = "0x183264930")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFJNNKLOBOH))]
	private Task NIKHFNEOBOB(Task PAIGDLJPPOE, string NNLMNOOEFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3264AA0", Offset = "0x32636A0", VA = "0x183264AA0")]
	public KNOCBGHMKHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal struct LIHFEMBJCAM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly MFHIJBENPCO GAOOEGMBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly Guid PALLEDHBFCO;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private Task<(IDIFMABCDLA, Task)> KCIAOCJILBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3266E20", Offset = "0x3265A20", VA = "0x183266E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2680EF0", Offset = "0x267FAF0", VA = "0x182680EF0")]
	public LIHFEMBJCAM(MFHIJBENPCO GAOOEGMBKDI, Guid PALLEDHBFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3266DD0", Offset = "0x32659D0", VA = "0x183266DD0")]
	public TaskAwaiter<(IDIFMABCDLA, Task)> CIAALDMCOFJ()
	{
		return default(TaskAwaiter<(IDIFMABCDLA, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3266EF0", Offset = "0x3265AF0", VA = "0x183266EF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[UnityEngine.Scripting.Preserve]
internal sealed class PCFPIMKAMML : NABGKEIJMLK, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class HDOOGEFGAKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public HCKACEFMPCF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private global::JAPPGKMKBNF<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private AALOEEPNEOP <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private ALJGLPODJGB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private AALOEEPNEOP <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private LCMHJBMHMJN <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private IDIFMABCDLA <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter<IDIFMABCDLA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HDOOGEFGAKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B7C0", Offset = "0x5E1A3C0", VA = "0x185E1B7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class EPJKAFEBOKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private CancellationTokenSource <combinedTokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public EPJKAFEBOKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5E19F30", Offset = "0x5E18B30", VA = "0x185E19F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class KKFLPLBDBOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public MOMCOKAPMLC _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KKFLPLBDBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D4D0", Offset = "0x5E1C0D0", VA = "0x185E1D4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class JLGLICOEPGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private object <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JLGLICOEPGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CE80", Offset = "0x5E1BA80", VA = "0x185E1CE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CICIJAPOENM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CICIJAPOENM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5E19130", Offset = "0x5E17D30", VA = "0x185E19130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class GCBGNPMKGGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private CancellationToken <nextAutosaveToken>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GCBGNPMKGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5E1ADA0", Offset = "0x5E199A0", VA = "0x185E1ADA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class ICJDJKIENIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private Task <delayTask>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Task<int> <intervalChangedTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Task <resultTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ICJDJKIENIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5E1BEB0", Offset = "0x5E1AAB0", VA = "0x185E1BEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class FICOEMBJGAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private global::JAPPGKMKBNF<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private AALOEEPNEOP <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private FFLEKJBGAJJ <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private MKKIMDKIEJP <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FICOEMBJGAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A600", Offset = "0x5E19200", VA = "0x185E1A600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private KHCNMJFIKHK MNLFCPGNLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private HLDCIPKGMNF CPNGNGPKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private OCAOCNCNOCD OFFFKIOLLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private CancellationTokenSource BDLOFKHMIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Task EDJMJBBPCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private TaskCompletionSource<int> OKINEKEIMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int DKIEPMHFCAG;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3274FA0", Offset = "0x3273BA0", VA = "0x183274FA0", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x163C320", Offset = "0x163AF20", VA = "0x18163C320", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3275160", Offset = "0x3273D60", VA = "0x183275160")]
	private void PKHJGPDGHIO(float BOKAAPCLKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3274E30", Offset = "0x3273A30", VA = "0x183274E30", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDOOGEFGAKK))]
	public Task<IDIFMABCDLA> MFMFNNPHECC(HCKACEFMPCF ANGBHDDNJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3274BD0", Offset = "0x32737D0", VA = "0x183274BD0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EPJKAFEBOKG))]
	public Task HNCAHLLFAMO([Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x163C320", Offset = "0x163AF20", VA = "0x18163C320")]
	public void DGNGNPHOEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x32744B0", Offset = "0x32730B0", VA = "0x1832744B0")]
	private ALJGLPODJGB CLANGIJCAOF(HCKACEFMPCF ANGBHDDNJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x32747C0", Offset = "0x32733C0", VA = "0x1832747C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KKFLPLBDBOP))]
	private Task EMEAJHNFMGH(MOMCOKAPMLC HDCPFIKNJDE, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3274A80", Offset = "0x3273680", VA = "0x183274A80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JLGLICOEPGP))]
	private Task HBFDLFFGEBD(CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3275240", Offset = "0x3273E40", VA = "0x183275240")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CICIJAPOENM))]
	private Task PMDEJGJJLLE([Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3274930", Offset = "0x3273530", VA = "0x183274930")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GCBGNPMKGGH))]
	private Task FLHICCLHICH(CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3274670", Offset = "0x3273270", VA = "0x183274670")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ICJDJKIENIC))]
	private Task EGIKIACONDF(CancellationToken DEEKJILKBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x32740A0", Offset = "0x3272CA0", VA = "0x1832740A0")]
	private Task BPMPGNBFDLE(NFBLDIHAPOJ GJGJDNGPKAK, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3274350", Offset = "0x3272F50", VA = "0x183274350")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FICOEMBJGAE))]
	private Task CBIGMEGDJGJ(NFBLDIHAPOJ GJGJDNGPKAK, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3274D20", Offset = "0x3273920", VA = "0x183274D20")]
	private bool IGGGLNHPCKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PCFPIMKAMML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface BEIIGIJBNMM : CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDIFMABCDLA IGGGLNHPCKG(IGGCDPKBFGF ACJGGEOLANN);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class JNJGFBGKBIM : ANJBBNMCECI, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class KFJIDCBJEFK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private readonly MHKEFJDKLJN PDOICCGDHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly CancellationTokenSource MFGBDLCLLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public readonly CancellationToken PIIFHPDGBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private bool HPPBEFJNGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private bool GHKACLCDPMJ;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E580", Offset = "0x3F7D180", VA = "0x183F7E580")]
		public KFJIDCBJEFK(MHKEFJDKLJN PDOICCGDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E430", Offset = "0x3F7D030", VA = "0x183F7E430")]
		public void IHLPPHPEFDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E400", Offset = "0x3F7D000", VA = "0x183F7E400", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class FIDMHFNFGNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public MLLLMININAO disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FIDMHFNFGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3F78170", Offset = "0x3F76D70", VA = "0x183F78170")]
		internal object CGLBIIFILCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class DMOFBHCHBLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public MLLLMININAO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public JNJGFBGKBIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private FIDMHFNFGNA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DMOFBHCHBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F773E0", Offset = "0x3F75FE0", VA = "0x183F773E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class FDMKICDEDAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FDMKICDEDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F78100", Offset = "0x3F76D00", VA = "0x183F78100")]
		internal object JDKMPOEGBKN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class DCMGLEHEFDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public JNJGFBGKBIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private FDMKICDEDAC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private IDisposable <logFlagsScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private IDisposable <logTraceScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IDisposable <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private MHKEFJDKLJN <newRoomInstance>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private OAEILIIIPED <customRoomLoadPayload>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DCMGLEHEFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F75800", Offset = "0x3F74400", VA = "0x183F75800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class BDNIIEFOFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public MHKEFJDKLJN newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BDNIIEFOFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F73EB0", Offset = "0x3F72AB0", VA = "0x183F73EB0")]
		internal object BMAGCEHEPGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3F73E70", Offset = "0x3F72A70", VA = "0x183F73E70")]
		internal object AFNKKANDJLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F73F50", Offset = "0x3F72B50", VA = "0x183F73F50")]
		internal object GCGMMCCDOPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class CDBIIFDDICB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CDBIIFDDICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F748F0", Offset = "0x3F734F0", VA = "0x183F748F0")]
		internal void FOBCGGDKIGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MPNGNLJHLLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public MHKEFJDKLJN newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public OAEILIIIPED customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public JNJGFBGKBIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private BDNIIEFOFDF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private CDBIIFDDICB <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private CancellationToken <token>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private OperationCanceledException <oce>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MPNGNLJHLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3F81E60", Offset = "0x3F80A60", VA = "0x183F81E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private GHOMLKKKKHM IIJBBPIGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private LFPKDNNPHDE MOCPAILNIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private AIMHFJMEAKL CEHJOFICIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private LKGOGFHLDFK HBHHBLLKCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private long HLICAKNNGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private KFJIDCBJEFK JICPGBHCLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private bool CJKOLCPINHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private Task OEAHMGOHKCA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3310", Offset = "0x2AE1F10", VA = "0x182AE3310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool IPGOLLBDNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1201930", Offset = "0x1200530", VA = "0x181201930")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2D50", Offset = "0x2AE1950", VA = "0x182AE2D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2AE33A0", Offset = "0x2AE1FA0", VA = "0x182AE33A0", Slot = "4")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2AE26B0", Offset = "0x2AE12B0", VA = "0x182AE26B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3650", Offset = "0x2AE2250", VA = "0x182AE3650")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DMOFBHCHBLK))]
	private Task PBGICECDOOI(MLLLMININAO PNDKKGJBMGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2AE30F0", Offset = "0x2AE1CF0", VA = "0x182AE30F0")]
	private void KAGCKBPPEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2AE29C0", Offset = "0x2AE15C0", VA = "0x182AE29C0")]
	private void ECKGLJKBMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2320", Offset = "0x2AE0F20", VA = "0x182AE2320")]
	private void BNPEMOOLAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2CD0", Offset = "0x2AE18D0", VA = "0x182AE2CD0")]
	private bool GIDDGKKCPGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2BE0", Offset = "0x2AE17E0", VA = "0x182AE2BE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DCMGLEHEFDK))]
	private void EOGPFIDDBOJ(int FNPPFCMGJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2D60", Offset = "0x2AE1960", VA = "0x182AE2D60")]
	private void IHHBAHINIHN(out IDisposable AHOOBICBHLF, out IDisposable MAPJNBGOHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2830", Offset = "0x2AE1430", VA = "0x182AE2830")]
	private bool ECCGBFBELIE(MHKEFJDKLJN PDOICCGDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3360", Offset = "0x2AE1F60", VA = "0x182AE3360")]
	private void MNCMHDBGGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2540", Offset = "0x2AE1140", VA = "0x182AE2540")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MPNGNLJHLLA))]
	private Task CGIPLDAAFAH(MHKEFJDKLJN PDOICCGDHHF, OAEILIIIPED LBJHHPLDPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3790", Offset = "0x2AE2390", VA = "0x182AE3790")]
	public JNJGFBGKBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal sealed class OBJHJJMGPAC : MFLEOODBFAO, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class GAGCOKAHLMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GAGCOKAHLMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AD30", Offset = "0x5E19930", VA = "0x185E1AD30")]
		internal object OFFNKDGGGHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class LBKJJHGCJHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LBKJJHGCJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D860", Offset = "0x5E1C460", VA = "0x185E1D860")]
		internal object EGFDMPEONFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private EPOJINPDBDE KELDMIFJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private BNEJDHEIHAG KEJOJLBJLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private MFHIJBENPCO GAOOEGMBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private NJCAGKAOHPF DOOFDPAIBFA;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x326F120", Offset = "0x326DD20", VA = "0x18326F120", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x326CF20", Offset = "0x326BB20", VA = "0x18326CF20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x326D8B0", Offset = "0x326C4B0", VA = "0x18326D8B0", Slot = "4")]
	public LIHFEMBJCAM KEABJGIDHIP(FHMBHNPINBI BOBCMCAMEBH)
	{
		return default(LIHFEMBJCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x326E3B0", Offset = "0x326CFB0", VA = "0x18326E3B0", Slot = "5")]
	public void MBDNCJBLALE(Guid PALLEDHBFCO, Task OIDBJIACCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x326D7E0", Offset = "0x326C3E0", VA = "0x18326D7E0")]
	private void HJHGFNHOHPM(byte PJPMIHPOMIA, int OEOGPLHHBJF, object FNPKKBLOKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x326E960", Offset = "0x326D560", VA = "0x18326E960")]
	private void OPFLAMIDEKC(GDNNMLKFEHK CBLNAPKAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x326DDB0", Offset = "0x326C9B0", VA = "0x18326DDB0")]
	private void KJCGJKABNCF(GDNNMLKFEHK CBLNAPKAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x326D220", Offset = "0x326BE20", VA = "0x18326D220")]
	private void GFJCEIANGPO(GDNNMLKFEHK CBLNAPKAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x326E640", Offset = "0x326D240", VA = "0x18326E640")]
	private IDIFMABCDLA OGNDPHAOHLC(FHMBHNPINBI IFPNDMLIDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x326CFC0", Offset = "0x326BBC0", VA = "0x18326CFC0")]
	private void ELDMIMPBLPI(FHMBHNPINBI KAMKHOFOCLH, IDIFMABCDLA NPAEKAKKGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x326CCC0", Offset = "0x326B8C0", VA = "0x18326CCC0")]
	private bool AEJOMOPEPHO(FHMBHNPINBI KAMKHOFOCLH, IDIFMABCDLA NPAEKAKKGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x326D4F0", Offset = "0x326C0F0", VA = "0x18326D4F0")]
	private bool GLPONHOOAHJ(FHMBHNPINBI CFDLOODJELF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x326E0A0", Offset = "0x326CCA0", VA = "0x18326E0A0")]
	private bool KNPDFGFDOIA(byte PJPMIHPOMIA, ExitGames.Client.Photon.Hashtable CBLNAPKAJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public OBJHJJMGPAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[UnityEngine.Scripting.Preserve]
internal sealed class CKMOEBJAOPG : BNEJDHEIHAG, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class KFEFGGLPGCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder<DLLMEMMHNCB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private DLLMEMMHNCB <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private TaskAwaiter<DLLMEMMHNCB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KFEFGGLPGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3263B60", Offset = "0x3262760", VA = "0x183263B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class BMDICGNLCND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public FHMBHNPINBI message;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BMDICGNLCND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x325DB40", Offset = "0x325C740", VA = "0x18325DB40")]
		internal object CMEMKNFNPIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class IHCKFCKFJON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public FHMBHNPINBI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IHCKFCKFJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3261030", Offset = "0x325FC30", VA = "0x183261030")]
		internal object ANGMPJBBEMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class OGFHCAIIDIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public OGFHCAIIDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3270A60", Offset = "0x326F660", VA = "0x183270A60")]
		internal object NCKCBCGKJDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class GFKNMMHGBNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private OGFHCAIIDIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private OOCGABPOHBK <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private OOCGABPOHBK <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private TaskAwaiter<OOCGABPOHBK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GFKNMMHGBNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3260660", Offset = "0x325F260", VA = "0x183260660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class LNKNCCKFBNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public FHMBHNPINBI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LNKNCCKFBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3267040", Offset = "0x3265C40", VA = "0x183267040")]
		internal object LKPPLMGGGEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class LFHIHKJIFGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public FHMBHNPINBI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private LNKNCCKFBNK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private FFLEKJBGAJJ <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private FHMBHNPINBI <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private OOCGABPOHBK <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private FHMBHNPINBI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LFHIHKJIFGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3266040", Offset = "0x3264C40", VA = "0x183266040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class DAMOLBBFHIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder<OOCGABPOHBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private FFLEKJBGAJJ <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private FHMBHNPINBI <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private FHMBHNPINBI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DAMOLBBFHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x325EB70", Offset = "0x325D770", VA = "0x18325EB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class LMBNFMHCKPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public OOCGABPOHBK operation;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LMBNFMHCKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3266FC0", Offset = "0x3265BC0", VA = "0x183266FC0")]
		internal object JENKBJHLJHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class EJEBGKCEFID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public OOCGABPOHBK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private LMBNFMHCKPG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private global::JAPPGKMKBNF<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private AALOEEPNEOP <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public EJEBGKCEFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x325F070", Offset = "0x325DC70", VA = "0x18325F070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class GDGIGHPPLCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GDGIGHPPLCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3260600", Offset = "0x325F200", VA = "0x183260600")]
		internal object LFCDLOJAPPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class IOBLMKPDMKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IOBLMKPDMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3261550", Offset = "0x3260150", VA = "0x183261550")]
		internal object GJKPHIKGMAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private HLDCIPKGMNF CPNGNGPKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private MFLEOODBFAO ABDILMEFOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private KHCNMJFIKHK MNLFCPGNLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private TaskCompletionSource<DLLMEMMHNCB> LDDHDADPIHD;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8890", Offset = "0x2AC7490", VA = "0x182AC8890", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7520", Offset = "0x2AC6120", VA = "0x182AC7520", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KFEFGGLPGCA))]
	public Task<DLLMEMMHNCB> ADEHAOCABJJ(CancellationToken BOPCGMCIPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7CC0", Offset = "0x2AC68C0", VA = "0x182AC7CC0", Slot = "4")]
	public void KEBINCHJHOA(FHMBHNPINBI DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2AC70F0", Offset = "0x2AC5CF0", VA = "0x182AC70F0", Slot = "5")]
	public void ADAEPOMFIHE(FHMBHNPINBI FNLNAMAPIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7690", Offset = "0x2AC6290", VA = "0x182AC7690")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFKNMMHGBNC))]
	private Task ALKKOEOLHIB(FHMBHNPINBI PAJPFFIMEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7B70", Offset = "0x2AC6770", VA = "0x182AC7B70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LFHIHKJIFGM))]
	private Task HMNJGHCJEIK(FHMBHNPINBI KAMKHOFOCLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7860", Offset = "0x2AC6460", VA = "0x182AC7860")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DAMOLBBFHIJ))]
	private Task<OOCGABPOHBK> BLJCKJJIGLC(FHMBHNPINBI PAJPFFIMEFB, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AC77E0", Offset = "0x2AC63E0", VA = "0x182AC77E0")]
	private FFLEKJBGAJJ APOFHGHCMEO(FHMBHNPINBI IFPNDMLIDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7A00", Offset = "0x2AC6600", VA = "0x182AC7A00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJEBGKCEFID))]
	private Task HIMPBLOIKAI(OOCGABPOHBK CDJHLNAAHGK, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AC85F0", Offset = "0x2AC71F0", VA = "0x182AC85F0")]
	private OOCGABPOHBK LNJLMLOCPIM(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B9A0", Offset = "0x2E5A5A0", VA = "0x182E5B9A0")]
	private T FPDLJJIJEGK<T>(T ECNGHFJBIJL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8120", Offset = "0x2AC6D20", VA = "0x182AC8120")]
	private OOCGABPOHBK LFPGJKOEKLO(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public CKMOEBJAOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AC85A0", Offset = "0x2AC71A0", VA = "0x182AC85A0")]
	[CompilerGenerated]
	private void LLJMPMBCKJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal interface AIMHFJMEAKL
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TimeSpan LHJNNILLFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	TimeSpan EPCMOJLJLIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TimeSpan DAOBFAELEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	TimeSpan DPGCFHMEEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OFDCHEPEDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool HKOPKHIHGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool JFNNLIFPDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	TimeSpan PJBMKHDPPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	TimeSpan PLNLHBFIMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal interface BNBOHDAMFHI : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LCMHJBMHMJN> KAELPKDAAHM(AALOEEPNEOP LEBCJIHOHHE, MHKEFJDKLJN FKMIOMCKJNF, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class GMAMNIGHIIF : HMAILMDEICE
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class IDMNADHAMAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public GMAMNIGHIIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Matchmaking.PAFIILGBNBC result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public MHKEFJDKLJN newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IDMNADHAMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3F7B8C0", Offset = "0x3F7A4C0", VA = "0x183F7B8C0")]
		internal object COFPDFNHHKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3F7BAB0", Offset = "0x3F7A6B0", VA = "0x183F7BAB0")]
		internal object KHDMMCIHEGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3F7BA10", Offset = "0x3F7A610", VA = "0x183F7BA10")]
		internal object HLMNKFDEPCN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class IKBJOJBJOKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public GMAMNIGHIIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private IDMNADHAMAP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private Matchmaking.PAFIILGBNBC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<Matchmaking.PAFIILGBNBC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IKBJOJBJOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3F7BBB0", Offset = "0x3F7A7B0", VA = "0x183F7BBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private const float DEKHCELCOFE = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private readonly IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8720", Offset = "0x2AD7320", VA = "0x182AD8720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8366A0", Offset = "0x8352A0", VA = "0x1808366A0")]
	public GMAMNIGHIIF(IFNNJAAOEDN FNIFBLHBOOE, HBPPPIGEKFO FGOMHOJPKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD85B0", Offset = "0x2AD71B0", VA = "0x182AD85B0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKBJOJBJOKD))]
	public Task<bool> BFAINGMPNNG(CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal interface ANJBBNMCECI : KKHNJDMOGHC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal interface HMAILMDEICE
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> BFAINGMPNNG(CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface JHPGNCLFEFD
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKJGCJELDBJ(LHNHBKFIDPL CDOIPBLLOCN);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MANOAIPGPIB(LHNHBKFIDPL CDOIPBLLOCN);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNIOAJEFAAL(LHNHBKFIDPL CDOIPBLLOCN);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FDHPCIGKKHH(LHNHBKFIDPL CDOIPBLLOCN);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LHNHBKFIDPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public readonly MHKEFJDKLJN BGMGCNGONPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private Dictionary<string, string> LOJDMHGAGAM;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::JAPPGKMKBNF<string> KCGIIBMNCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8370D0", Offset = "0x835CD0", VA = "0x1808370D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x836EE0", Offset = "0x835AE0", VA = "0x180836EE0")]
	public LHNHBKFIDPL(MHKEFJDKLJN BIJBNMHAAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x3266D00", Offset = "0x3265900", VA = "0x183266D00")]
	public LHNHBKFIDPL MNMFBAAJDPG(string BDFCACLHAFA, string ECNGHFJBIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3266C80", Offset = "0x3265880", VA = "0x183266C80")]
	public bool JBNLINMGPLP(out IEnumerable<KeyValuePair<string, string>> OJGHOIDDGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2C74200", Offset = "0x2C72E00", VA = "0x182C74200")]
	public LHNHBKFIDPL DCEKJEKIOJL(global::JAPPGKMKBNF<string> IDIJCJCNEPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface PJEIECLNICO
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	MHKEFJDKLJN GCAKDALBEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	IEMLKNOFDEG COPPBMJCHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	MPOOILGCDLJ GJAGOJBNJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool OMKCHEEDJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool MKOFNMFHMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int AHANMDCKNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action KAGCKBPPEKE;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<int> EOGPFIDDBOJ;

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GFBCPMLLEKL();

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.MDKPNMHIPCM> DFLBCCECPHL(long BFNOJMGJLFG, [Optional] CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.PAFIILGBNBC> NIBFDLIPPAM();

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task EJCEPMEJCHG();

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(MHKEFJDKLJN, OAEILIIIPED) OJAIJOAJBHC();

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MHBAMGOJMJJ IKCIIPMOMLF();

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HELCKINDJHN(long BFNOJMGJLFG);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal interface KHCNMJFIKHK : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FHMBHNPINBI> NFBKKILHAPB(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FHMBHNPINBI> AMIAFKHFHLG(CancellationToken GFFFFCALMCA, FFLEKJBGAJJ GAEEOLALHAM);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DNKNJNMAMBL PNKJHFEMMMK(OOCGABPOHBK BCJOJLPDGAD, AALOEEPNEOP LEBCJIHOHHE);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DNKNJNMAMBL HHEJOOPBBPE(OOCGABPOHBK BCJOJLPDGAD, AALOEEPNEOP LEBCJIHOHHE);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal sealed class HAIGOHNCBOK : IFNNJAAOEDN, NCFBJHOACDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class AOJGMFMCJFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public HCKACEFMPCF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public HAIGOHNCBOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private IDIFMABCDLA <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private IDIFMABCDLA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<IDIFMABCDLA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public AOJGMFMCJFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3F72EE0", Offset = "0x3F71AE0", VA = "0x183F72EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class DIINOIAAFOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public HAIGOHNCBOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private IDIFMABCDLA <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DIINOIAAFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3F76D20", Offset = "0x3F75920", VA = "0x183F76D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class OOMBEOLIPME : IEnumerable<KKHNJDMOGHC>, IEnumerable, IEnumerator<KKHNJDMOGHC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private KKHNJDMOGHC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public HAIGOHNCBOK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private KKHNJDMOGHC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xAF7620", Offset = "0xAF6220", VA = "0x180AF7620")]
		[DebuggerHidden]
		public OOMBEOLIPME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3F843D0", Offset = "0x3F82FD0", VA = "0x183F843D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3F84850", Offset = "0x3F83450", VA = "0x183F84850", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3F847B0", Offset = "0x3F833B0", VA = "0x183F847B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KKHNJDMOGHC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3F847B0", Offset = "0x3F833B0", VA = "0x183F847B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private readonly CancellationTokenSource EOFDJDMKNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly MHOBEFMLEFD JMIFLNNGBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private MMBBPNPCMOA PKFPFKNCCLP;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public EPJFONLPCOB HOCOJIBIFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x84D7F0", Offset = "0x84C3F0", VA = "0x18084D7F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8F1BC0", Offset = "0x8F07C0", VA = "0x1808F1BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public GHOMLKKKKHM JMGHKJIPIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x836080", Offset = "0x834C80", VA = "0x180836080", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x89D530", Offset = "0x89C130", VA = "0x18089D530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x84D800", Offset = "0x84C400", VA = "0x18084D800", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x89D540", Offset = "0x89C140", VA = "0x18089D540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public KDHGMPHKPAM MAEKOJNKJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x84D810", Offset = "0x84C410", VA = "0x18084D810", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x89D520", Offset = "0x89C120", VA = "0x18089D520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DPADKKHLKLF PBNEJPFKDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x84D790", Offset = "0x84C390", VA = "0x18084D790", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x85F850", Offset = "0x85E450", VA = "0x18085F850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BEIIGIJBNMM EHLIDEAPHLB
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x84D7A0", Offset = "0x84C3A0", VA = "0x18084D7A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x86EDA0", Offset = "0x86D9A0", VA = "0x18086EDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public KFDAFKKLOKJ GCFMGMKCIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8736C0", Offset = "0x8722C0", VA = "0x1808736C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x86ED80", Offset = "0x86D980", VA = "0x18086ED80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public HLDCIPKGMNF ANJLCFPEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x83E310", Offset = "0x83CF10", VA = "0x18083E310", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x89B000", Offset = "0x899C00", VA = "0x18089B000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NABGKEIJMLK ILDDDNKPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x83E3B0", Offset = "0x83CFB0", VA = "0x18083E3B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0E0", Offset = "0xA3CCE0", VA = "0x180A3E0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LEHKMPCAGKL LBBBKNCGGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x873690", Offset = "0x872290", VA = "0x180873690", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xABEE70", Offset = "0xABDA70", VA = "0x180ABEE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public LFPKDNNPHDE DGJOFOIFJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x84D7B0", Offset = "0x84C3B0", VA = "0x18084D7B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x86ED90", Offset = "0x86D990", VA = "0x18086ED90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LKGOGFHLDFK JFMCLHOMNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x84D7C0", Offset = "0x84C3C0", VA = "0x18084D7C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x894110", Offset = "0x892D10", VA = "0x180894110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public OCAOCNCNOCD MOPGLPOHIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x84D7E0", Offset = "0x84C3E0", VA = "0x18084D7E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1C10", Offset = "0x9F0810", VA = "0x1809F1C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public MFHIJBENPCO DHPNGFEFNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x84D7D0", Offset = "0x84C3D0", VA = "0x18084D7D0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x86EDB0", Offset = "0x86D9B0", VA = "0x18086EDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public ANJBBNMCECI JPIDCLGLMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9EF3D0", Offset = "0x9EDFD0", VA = "0x1809EF3D0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9EFAC0", Offset = "0x9EE6C0", VA = "0x1809EFAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public BNEJDHEIHAG OCHGGKGDJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9735B0", Offset = "0x9721B0", VA = "0x1809735B0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9EF3E0", Offset = "0x9EDFE0", VA = "0x1809EF3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public MFLEOODBFAO IEAEMFIFNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x897040", Offset = "0x895C40", VA = "0x180897040", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x897460", Offset = "0x896060", VA = "0x180897460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public PJKNICMILIO HJIMPJGIBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA3B4B0", Offset = "0xA3A0B0", VA = "0x180A3B4B0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA3B590", Offset = "0xA3A190", VA = "0x180A3B590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BNBOHDAMFHI FFNIAEHNKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x9F0070", Offset = "0x9EEC70", VA = "0x1809F0070", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA3C200", Offset = "0xA3AE00", VA = "0x180A3C200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public KHCNMJFIKHK PIIAEDKDFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9EFD70", Offset = "0x9EE970", VA = "0x1809EFD70", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9F00A0", Offset = "0x9EECA0", VA = "0x1809F00A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NNIOHMBOJFJ GDOBLIHPACC
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9EFD50", Offset = "0x9EE950", VA = "0x1809EFD50", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0080", Offset = "0x9EEC80", VA = "0x1809F0080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public EPOJINPDBDE BPLFNCLBJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9EFD60", Offset = "0x9EE960", VA = "0x1809EFD60", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0090", Offset = "0x9EEC90", VA = "0x1809F0090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JHPGNCLFEFD DBIJAOJGMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1F0", Offset = "0xA3ADF0", VA = "0x180A3C1F0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xDEEF20", Offset = "0xDEDB20", VA = "0x180DEEF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NJCAGKAOHPF KIHBGBLJHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9F0050", Offset = "0x9EEC50", VA = "0x1809F0050", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9F01F0", Offset = "0x9EEDF0", VA = "0x1809F01F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public MHPAJLBPAGC DDKAJHJAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9F0060", Offset = "0x9EEC60", VA = "0x1809F0060", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9F0200", Offset = "0x9EEE00", VA = "0x1809F0200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public AIMHFJMEAKL PAFHFMHEPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xCEA040", Offset = "0xCE8C40", VA = "0x180CEA040", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xCE96D0", Offset = "0xCE82D0", VA = "0x180CE96D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public JOLNEEIAHIL CMLFECNHKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xCE81A0", Offset = "0xCE6DA0", VA = "0x180CE81A0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xDE7F70", Offset = "0xDE6B70", VA = "0x180DE7F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public LCAFMEKLLGH MFKLBOKLKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x156D8B0", Offset = "0x156C4B0", VA = "0x18156D8B0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public JHNNJFGCKHO CPMDHHOFDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1715960", Offset = "0x1714560", VA = "0x181715960", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public PILPGHODDIG ODNKPAPJJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x1022EF0", Offset = "0x1021AF0", VA = "0x181022EF0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public OAEILIIIPED OJJPFGNKGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xD79B80", Offset = "0xD78780", VA = "0x180D79B80", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8CF0", Offset = "0xDE78F0", VA = "0x180DE8CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private bool AGMIAFBIBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9620", Offset = "0x2AD8220", VA = "0x182AD9620", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private bool KFILDGILPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD91E0", Offset = "0x2AD7DE0", VA = "0x182AD91E0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private Task HCHFNNPCPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9B00", Offset = "0x2AD8700", VA = "0x182AD9B00", Slot = "49")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	private CancellationToken COIIPPCEMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2AD97A0", Offset = "0x2AD83A0", VA = "0x182AD97A0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private MHOBEFMLEFD NBJOOFEEEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action GEHOJIKCEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9A40", Offset = "0x2AD8640", VA = "0x182AD9A40", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9B50", Offset = "0x2AD8750", VA = "0x182AD9B50", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event KGMACCFPPHI ACEHBDICKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9260", Offset = "0x2AD7E60", VA = "0x182AD9260", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2AD97C0", Offset = "0x2AD83C0", VA = "0x182AD97C0", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event KGMACCFPPHI JDBAEEJBNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9180", Offset = "0x2AD7D80", VA = "0x182AD9180", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2AD96E0", Offset = "0x2AD82E0", VA = "0x182AD96E0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event KGMACCFPPHI GACAJPABPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9680", Offset = "0x2AD8280", VA = "0x182AD9680", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9740", Offset = "0x2AD8340", VA = "0x182AD9740", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<NBGKOOKNBGP, bool> EMBGOJMNLJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2AD92C0", Offset = "0x2AD7EC0", VA = "0x182AD92C0", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9AA0", Offset = "0x2AD86A0", VA = "0x182AD9AA0", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xDE8CF0", Offset = "0xDE78F0", VA = "0x180DE8CF0", Slot = "36")]
	public void LGJLJGHOJJN(OAEILIIIPED MDBMLIKFPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9EC0", Offset = "0x2AD8AC0", VA = "0x182AD9EC0")]
	[UnityEngine.Scripting.Preserve]
	internal HAIGOHNCBOK([ACEKLAKDMBL(null)] MHOBEFMLEFD JMIFLNNGBHG, [ACEKLAKDMBL(null)] EPJFONLPCOB EKLPJDMGHDM, [ACEKLAKDMBL(null)] GHOMLKKKKHM IIJBBPIGDIK, [ACEKLAKDMBL(null)] HBPPPIGEKFO FGOMHOJPKFO, [ACEKLAKDMBL(null)] KDHGMPHKPAM CGJJMLHLLBO, [ACEKLAKDMBL(null)] DPADKKHLKLF JKPHNCJANPB, [ACEKLAKDMBL(null)] BEIIGIJBNMM EAABFFOLONM, [ACEKLAKDMBL(null)] KFDAFKKLOKJ BBMCDOFLCKN, [ACEKLAKDMBL(null)] HLDCIPKGMNF CPNGNGPKKKH, [ACEKLAKDMBL(null)] NABGKEIJMLK KALNIKAOMNH, [ACEKLAKDMBL(null)] LEHKMPCAGKL EOHAACKOPMN, [ACEKLAKDMBL(null)] LFPKDNNPHDE MOCPAILNIIE, [ACEKLAKDMBL(null)] LKGOGFHLDFK HBHHBLLKCLC, [ACEKLAKDMBL(null)] OCAOCNCNOCD OFFFKIOLLDO, [ACEKLAKDMBL(null)] MFHIJBENPCO GAOOEGMBKDI, [ACEKLAKDMBL(null)] ANJBBNMCECI HIGLLBHNICP, [ACEKLAKDMBL(null)] BNEJDHEIHAG KEJOJLBJLEK, [ACEKLAKDMBL(null)] MFLEOODBFAO ABDILMEFOOH, [ACEKLAKDMBL(null)] PJKNICMILIO FHPOOOFJELG, [ACEKLAKDMBL(null)] BNBOHDAMFHI CJPJEGMHJHB, [ACEKLAKDMBL(null)] NNIOHMBOJFJ MOAIDCPAIPL, [ACEKLAKDMBL(null)] KHCNMJFIKHK MNLFCPGNLLN, [ACEKLAKDMBL(null)] EPOJINPDBDE KELDMIFJJEC, [ACEKLAKDMBL(null)] JHPGNCLFEFD HHCBJFFAMJN, [ACEKLAKDMBL(null)] NJCAGKAOHPF DOOFDPAIBFA, [ACEKLAKDMBL(null)] AIMHFJMEAKL CEHJOFICIAM, [ACEKLAKDMBL(null)] JOLNEEIAHIL OPFNMBAGLHI, [ACEKLAKDMBL(null)] LCAFMEKLLGH FIKIGKENNBD, [ACEKLAKDMBL(null)] JHNNJFGCKHO OPAKEBPNBDA, [ACEKLAKDMBL(null)] PILPGHODDIG DCLPNPGHFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9D00", Offset = "0x2AD8900", VA = "0x182AD9D00")]
	private void PBAELFIBGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9490", Offset = "0x2AD8090", VA = "0x182AD9490", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9820", Offset = "0x2AD8420", VA = "0x182AD9820", Slot = "50")]
	private void JBILAOJENGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9030", Offset = "0x2AD7C30", VA = "0x182AD9030", Slot = "51")]
	private DHFMLFOJIHC BCFLMDHIJKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9870", Offset = "0x2AD8470", VA = "0x182AD9870", Slot = "52")]
	private AMGCDJKPHHE JDHCHGGOBDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9320", Offset = "0x2AD7F20", VA = "0x182AD9320", Slot = "53")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOJGMFMCJFG))]
	private Task<IDIFMABCDLA> DHEPDNIDHKG(HCKACEFMPCF ANGBHDDNJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9BB0", Offset = "0x2AD87B0", VA = "0x182AD9BB0", Slot = "54")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DIINOIAAFOA))]
	private Task NFKPOIMPNCN(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9DF0", Offset = "0x2AD89F0", VA = "0x182AD9DF0")]
	[IteratorStateMachine(typeof(OOMBEOLIPME))]
	private IEnumerable<KKHNJDMOGHC> PKNFOCGLILG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9E60", Offset = "0x2AD8A60", VA = "0x182AD9E60")]
	[CompilerGenerated]
	private void POCFFPKPMKH(KKHNJDMOGHC DPLEBJGMEDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class HCMDOEKGEJI : BNBOHDAMFHI, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class GGBNNJMPKNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<LCMHJBMHMJN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public HCMDOEKGEJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private IEMLKNOFDEG <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private IEMLKNOFDEG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<IEMLKNOFDEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GGBNNJMPKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A120", Offset = "0x3F78D20", VA = "0x183F7A120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class FDIFDGHGOLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FDIFDGHGOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F78050", Offset = "0x3F76C50", VA = "0x183F78050")]
		internal object OAOGDJOBLOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class MONFPFDKGJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public AsyncTaskMethodBuilder<IEMLKNOFDEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public HCMDOEKGEJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private FDIFDGHGOLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private AALOEEPNEOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private IEMLKNOFDEG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<IEMLKNOFDEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MONFPFDKGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F818A0", Offset = "0x3F804A0", VA = "0x183F818A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class JADICDPLBJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JADICDPLBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1267E30", Offset = "0x1266A30", VA = "0x181267E30")]
		internal bool BIBMCNMPDOG(MPOOILGCDLJ sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private static readonly (EFENBEKLEHO superRoomData, long subRoomDataSaveId) MBPJMINBJHC;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB720", Offset = "0x2ADA320", VA = "0x182ADB720", Slot = "5")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB560", Offset = "0x2ADA160", VA = "0x182ADB560", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GGBNNJMPKNF))]
	public Task<LCMHJBMHMJN> KAELPKDAAHM(AALOEEPNEOP LEBCJIHOHHE, MHKEFJDKLJN FKMIOMCKJNF, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB3A0", Offset = "0x2AD9FA0", VA = "0x182ADB3A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MONFPFDKGJI))]
	private Task<IEMLKNOFDEG> JDHJMGMGKOJ(MHKEFJDKLJN FKMIOMCKJNF, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB250", Offset = "0x2AD9E50", VA = "0x182ADB250")]
	private LCMHJBMHMJN IHGEGPGMIFG(MHKEFJDKLJN FKMIOMCKJNF, IEMLKNOFDEG EAIBLBKOGKO, long BPODGJMCBKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2ADAEC0", Offset = "0x2AD9AC0", VA = "0x182ADAEC0")]
	private (EFENBEKLEHO, long) BALNCNBMBEK(MHKEFJDKLJN FKMIOMCKJNF, IEMLKNOFDEG EAIBLBKOGKO, long BPODGJMCBKI)
	{
		return default((EFENBEKLEHO, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public HCMDOEKGEJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface KDHGMPHKPAM
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool GHNADOIKPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	string FEAMCFBADMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIEPJOIBNHB(Scene GNCGLIILAGO);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HPJBMFIAIHB(JGCDJAPPMFN GOAFBLHNKGD, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task INLCAIFIHFN();
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[UnityEngine.Scripting.Preserve]
internal sealed class AHPOMGBOHEB : KHCNMJFIKHK, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class DMGNANCMFIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DMGNANCMFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x325F010", Offset = "0x325DC10", VA = "0x18325F010")]
		internal object CPEEEKHDIGC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class MDDDLLCOOBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public FFLEKJBGAJJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AHPOMGBOHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private DMGNANCMFIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private FHMBHNPINBI <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private FHMBHNPINBI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MDDDLLCOOBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3268C20", Offset = "0x3267820", VA = "0x183268C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class BMCEANIHLDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public FFLEKJBGAJJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public AHPOMGBOHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private DAMKOIBGCAN <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private DDPPNCDFGCL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter<DDPPNCDFGCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BMCEANIHLDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x325D510", Offset = "0x325C110", VA = "0x18325D510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class MKHBHDMFILF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MKHBHDMFILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x326A030", Offset = "0x3268C30", VA = "0x18326A030")]
		internal object MPOEFEOCGNO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class MKMDLAEFOCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public FFLEKJBGAJJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AHPOMGBOHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private MKHBHDMFILF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private FMEHMMJPLED <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private GPIJANIJAAG <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private DAMKOIBGCAN <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private FHMBHNPINBI <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private FMEHMMJPLED <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private DDPPNCDFGCL <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter<DDPPNCDFGCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MKMDLAEFOCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x326A470", Offset = "0x3269070", VA = "0x18326A470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private MHPAJLBPAGC DLHMJOJPEDH;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private GOMGBFEPMOD PFLGINGMBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2AC46D0", Offset = "0x2AC32D0", VA = "0x182AC46D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4940", Offset = "0x2AC3540", VA = "0x182AC4940", Slot = "8")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4780", Offset = "0x2AC3380", VA = "0x182AC4780", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MDDDLLCOOBE))]
	public Task<FHMBHNPINBI> NFBKKILHAPB(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4030", Offset = "0x2AC2C30", VA = "0x182AC4030", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMCEANIHLDG))]
	public Task<FHMBHNPINBI> AMIAFKHFHLG(CancellationToken GFFFFCALMCA, FFLEKJBGAJJ GAEEOLALHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2AC49D0", Offset = "0x2AC35D0", VA = "0x182AC49D0", Slot = "6")]
	public DNKNJNMAMBL PNKJHFEMMMK(OOCGABPOHBK BCJOJLPDGAD, AALOEEPNEOP LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2AC43A0", Offset = "0x2AC2FA0", VA = "0x182AC43A0", Slot = "7")]
	public DNKNJNMAMBL HHEJOOPBBPE(OOCGABPOHBK BCJOJLPDGAD, AALOEEPNEOP LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2AC41E0", Offset = "0x2AC2DE0", VA = "0x182AC41E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MKMDLAEFOCP))]
	private Task<FHMBHNPINBI> FMFBKAMPGHL(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2AC41D0", Offset = "0x2AC2DD0", VA = "0x182AC41D0")]
	private static byte[] FEHBCCIIIBD(FHMBHNPINBI DKIECHCHJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2AC45D0", Offset = "0x2AC31D0", VA = "0x182AC45D0")]
	private static string JPGMKADLJAN(byte[] AIMHDAMIMIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public AHPOMGBOHEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public readonly struct OOIGBDNKEMF<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class GECCFJOPNCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public AsyncTaskMethodBuilder<global::PKJAENHCLMN<global::HCLLLJEDILH<TData>, CMPFHAIKIAN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public global::OOIGBDNKEMF<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private AALOEEPNEOP <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private global::PKJAENHCLMN<byte[], CMPFHAIKIAN> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private global::PKJAENHCLMN<byte[], CMPFHAIKIAN> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<global::PKJAENHCLMN<byte[], CMPFHAIKIAN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public GECCFJOPNCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x48DF760", Offset = "0x48DE360", VA = "0x1848DF760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly global::FNOEIOAGCPK<TGetDataArg, TData> PNGKFALBFEP;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xAF3280", Offset = "0xAF1E80", VA = "0x180AF3280")]
	internal OOIGBDNKEMF(global::FNOEIOAGCPK<TGetDataArg, TData> LHPOMNBICEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x31CA730", Offset = "0x31C9330", VA = "0x1831CA730")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::OOIGBDNKEMF<, >.GECCFJOPNCB))]
	public Task<global::PKJAENHCLMN<global::HCLLLJEDILH<TData>, CMPFHAIKIAN>> FMMAEMCOBJJ(TGetDataArg AIMHDAMIMIL, string AJJPNCELFOK, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class AJGLMMMEGAJ
{
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x195A7C0", Offset = "0x19593C0", VA = "0x18195A7C0")]
	public static global::OOIGBDNKEMF<TGetDataArg, TData> DOBPLOGGNLM<TGetDataArg, TData>(global::FNOEIOAGCPK<TGetDataArg, TData> LHPOMNBICEN)
	{
		return default(global::OOIGBDNKEMF<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[UnityEngine.Scripting.Preserve]
internal sealed class HBIFBBIEEDF : PJKNICMILIO, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class DOJODKJDBCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public DLLMEMMHNCB operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public HBIFBBIEEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DOJODKJDBCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F77900", Offset = "0x3F76500", VA = "0x183F77900")]
		internal object DAGJCDDHHCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F777D0", Offset = "0x3F763D0", VA = "0x183F777D0")]
		internal object ADBOEBGPJOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class IDAGABMBDJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public HBIFBBIEEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private DOJODKJDBCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private IDIFMABCDLA <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private IDIFMABCDLA <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private TaskAwaiter<IDIFMABCDLA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IDAGABMBDJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x3F7B2B0", Offset = "0x3F79EB0", VA = "0x183F7B2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class PDPJCAIDOCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public DLLMEMMHNCB operationType;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public PDPJCAIDOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F84C60", Offset = "0x3F83860", VA = "0x183F84C60")]
		internal object NIEMLIEKAPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class GAIMGEONPNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GAIMGEONPNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x3F79850", Offset = "0x3F78450", VA = "0x183F79850")]
		internal object OEEANEFBCJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x3F79950", Offset = "0x3F78550", VA = "0x183F79950")]
		internal object PPNMJDPHAKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x3F798D0", Offset = "0x3F784D0", VA = "0x183F798D0")]
		internal object PELHJCGOIMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class CPFBJMKGFIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public HBIFBBIEEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private GAIMGEONPNF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private LIHFEMBJCAM <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private IDIFMABCDLA <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private (IDIFMABCDLA validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private (IDIFMABCDLA validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<(IDIFMABCDLA validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CPFBJMKGFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F75030", Offset = "0x3F73C30", VA = "0x183F75030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private EPOJINPDBDE KELDMIFJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private MFLEOODBFAO ABDILMEFOOH;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2ADAE10", Offset = "0x2AD9A10", VA = "0x182ADAE10", Slot = "5")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2ADACA0", Offset = "0x2AD98A0", VA = "0x182ADACA0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IDAGABMBDJA))]
	private Task<IDIFMABCDLA> JJKEIIMBAMH(FHMBHNPINBI IFPNDMLIDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA8B0", Offset = "0x2AD94B0", VA = "0x182ADA8B0")]
	private bool GJCJOJDLELC(DLLMEMMHNCB KAINKNJPFIL, out IDIFMABCDLA IIMBBHEIGGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2ADAB30", Offset = "0x2AD9730", VA = "0x182ADAB30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPFBJMKGFIB))]
	private Task<IDIFMABCDLA> IOGHKNBIIKI(FHMBHNPINBI PAJPFFIMEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public HBIFBBIEEDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class MDMPMBPEFDA
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public static IDIFMABCDLA GBIFOJKCEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x3269150", Offset = "0x3267D50", VA = "0x183269150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3269220", Offset = "0x3267E20", VA = "0x183269220")]
	public static bool EGDIGIIHPIG(this IDIFMABCDLA NPAEKAKKGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x32691B0", Offset = "0x3267DB0", VA = "0x1832691B0")]
	public static IDIFMABCDLA DCMADGLAFJL(BOHAGPJNCEM BBMNNPEOJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x3269250", Offset = "0x3267E50", VA = "0x183269250")]
	public static IDIFMABCDLA EKDFEDAKBMJ(params IDIFMABCDLA[] EJEMMKODELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x3269510", Offset = "0x3268110", VA = "0x183269510")]
	public static IDIFMABCDLA MFIOCBBOOJP(IEnumerable<IDIFMABCDLA> EJEMMKODELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x3269260", Offset = "0x3267E60", VA = "0x183269260")]
	public static string FFEBHLOMHAI(this IDIFMABCDLA IIMBBHEIGGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[UnityEngine.Scripting.Preserve]
internal sealed class NFOAMOJDGHO : EPOJINPDBDE, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private DPADKKHLKLF JKPHNCJANPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private HLDCIPKGMNF CPNGNGPKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private NNIOHMBOJFJ MOAIDCPAIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private LKGOGFHLDFK HBHHBLLKCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private OCAOCNCNOCD OFFFKIOLLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private AIMHFJMEAKL CEHJOFICIAM;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x326BFF0", Offset = "0x326ABF0", VA = "0x18326BFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private static IDIFMABCDLA GBIFOJKCEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x3269150", Offset = "0x3267D50", VA = "0x183269150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x326C420", Offset = "0x326B020", VA = "0x18326C420", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x326C040", Offset = "0x326AC40", VA = "0x18326C040", Slot = "4")]
	public IDIFMABCDLA NMBCIPOHMGE(IGGCDPKBFGF AEEBHLKEAKN, DLLMEMMHNCB GOKELOIKDPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x326BD00", Offset = "0x326A900", VA = "0x18326BD00", Slot = "5")]
	public IDIFMABCDLA GOENMAPECNC(IGGCDPKBFGF AOLFPABEEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x326C1D0", Offset = "0x326ADD0", VA = "0x18326C1D0", Slot = "6")]
	public IDIFMABCDLA OIGJDPDICNH(IGGCDPKBFGF AOLFPABEEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x32691B0", Offset = "0x3267DB0", VA = "0x1832691B0")]
	private static IDIFMABCDLA DCMADGLAFJL(BOHAGPJNCEM MDCIFHCDMMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public NFOAMOJDGHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public delegate Task NDLLDLNNGKD(MOMCOKAPMLC CMMCIHFHBLL, CancellationToken FLDJLPKNKKO);
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal interface OCAOCNCNOCD : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool CEMOOCAECHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JBCFBBEJPKG(NDLLDLNNGKD JOBDEEONKAE);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface NJCAGKAOHPF
{
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLMAHHBOPIN(out IEnumerable<int> NJJLJGMKLJE);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLEDDJNKNMN(PKHKKGNCOIB FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIEIFLDAHLF(PKHKKGNCOIB FLDJLPKNKKO);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface NOKNPGPIPCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OEIPHHEMJBA(IDIFMABCDLA NPAEKAKKGDM);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal interface PJKNICMILIO : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IDIFMABCDLA> HJIMPJGIBJM(FHMBHNPINBI IFPNDMLIDFN);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal interface IFNNJAAOEDN : NCFBJHOACDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	CancellationToken BAPIAIDFBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	MHOBEFMLEFD MLGFLIHDPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	EPJFONLPCOB HOCOJIBIFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	GHOMLKKKKHM JMGHKJIPIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	KDHGMPHKPAM MAEKOJNKJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	DPADKKHLKLF PBNEJPFKDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	BEIIGIJBNMM EHLIDEAPHLB
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	KFDAFKKLOKJ GCFMGMKCIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	HLDCIPKGMNF ANJLCFPEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	NABGKEIJMLK ILDDDNKPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	LEHKMPCAGKL LBBBKNCGGIF
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	LFPKDNNPHDE DGJOFOIFJJP
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	LKGOGFHLDFK JFMCLHOMNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	OCAOCNCNOCD MOPGLPOHIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	MFHIJBENPCO DHPNGFEFNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	ANJBBNMCECI JPIDCLGLMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	BNEJDHEIHAG OCHGGKGDJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	MFLEOODBFAO IEAEMFIFNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	PJKNICMILIO HJIMPJGIBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	BNBOHDAMFHI FFNIAEHNKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	KHCNMJFIKHK PIIAEDKDFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	NNIOHMBOJFJ GDOBLIHPACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	EPOJINPDBDE BPLFNCLBJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	JHPGNCLFEFD DBIJAOJGMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	NJCAGKAOHPF KIHBGBLJHLE
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	MHPAJLBPAGC DDKAJHJAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	AIMHFJMEAKL PAFHFMHEPDE
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	JOLNEEIAHIL CMLFECNHKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	LCAFMEKLLGH MFKLBOKLKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	JHNNJFGCKHO CPMDHHOFDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	PILPGHODDIG ODNKPAPJJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void LGJLJGHOJJN(OAEILIIIPED MDBMLIKFPPB);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal interface LFPKDNNPHDE : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JHKFDEFLOCO();

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEAHNGCCEOM();

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHLPPHPEFDP();
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class EPJAGPDNGNM
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2ACD740", Offset = "0x2ACC340", VA = "0x182ACD740")]
	public static void LKLABALGDMK(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2ACD540", Offset = "0x2ACC140", VA = "0x182ACD540")]
	internal static void GOHIKCIPJDG(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2ACD660", Offset = "0x2ACC260", VA = "0x182ACD660")]
	internal static void HKPEEDJJFCO(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2ACD0F0", Offset = "0x2ACBCF0", VA = "0x182ACD0F0")]
	internal static void BNFBDNFHIIK(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class MIPPFLCEBNN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3269FF0", Offset = "0x3268BF0", VA = "0x183269FF0")]
	public MIPPFLCEBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0xCEE030", Offset = "0xCECC30", VA = "0x180CEE030")]
	public MIPPFLCEBNN(string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal interface KKHNJDMOGHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface HBPPPIGEKFO
{
	[Cpp2IlInjected.Token(Token = "0x17000084")]
	PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	int AHANMDCKNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool HJDOBAAJFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool CLIDBLGGLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool BKKNHNGMOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	bool BAAOGMEPFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	IGGCDPKBFGF AGOBILJIDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool CMJEGCCGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	float PBHJLDENPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event Action<float> ONCFOLILPLM;

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MHOBEFMLEFD IIAPOLDHLHH(MHOBEFMLEFD EOHDEJOCEFD);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DHGNPHMOAIH(MHOBEFMLEFD JMIFLNNGBHG);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIJGFPCIHPJ();

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task AHAEOEIJNIF(AALOEEPNEOP BNDOBCCDIJF, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IAHIILNMGMK(float HACKJIALAHA);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LNOFDFDCDJE(string FMCIPDNGKPD);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IReadOnlyList<HGGHGJBADJJ> EGAFFNAAALH();

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDisposable JBKIEOAMFHJ(object JFDMKPDIBDL, HGGHGJBADJJ NMPOOPDGJFD);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CIOHJELGAHC JNECGINONDF(IEnumerable<HGNMPOIAAKI> LDOJACGGACG);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PBPAJCOAAJK(int ALCHPPPJPLL);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task DHDLMJMDLLF();

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GMKJGDMMEDE();

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool JEPHPFEOHOC();

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task COJFFAEFDII(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task PMDODLOMCKG(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<JLOOFCOEEHE> OBLJOHKHFAB(DateTime FAPCHPBFJLF, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> DODGHAFOCHH(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PMJNKCJKOIB();

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "23")]
	DHJIDMGNJIC PHPEOAJOMNB(GEDJHDMKMOJ GIOCABEBNHM, BNIDNMGAHLD PJDCDPIPHBA, IEnumerable<PersistenceView> DLPOCMMMECH, EKIEPCIPJDM LHNAPAPHKDJ);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ALANBJJMLNA(BNIDNMGAHLD PJDCDPIPHBA);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NNCICCPJLGK(HGNMPOIAAKI EJFGMPEJEDD, in DHJIDMGNJIC AKDAOECFHJI);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task JGAMHBJGIID(BNIDNMGAHLD BBBFCKGLENJ, bool FPJMKDBAJEB, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task DAFGNJPLOPO(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EJJADMJGOCK(long HAMIEGOKEJC, long KIBMHJEFMKG, IEMLKNOFDEG KBEKHLAONIE, BNNPCINDEGK OMPPEPJAKGO, EJCOGPHMIIO NNIPLGKEGFJ, NNENOOPKHPC? IDBNBECJKFH, IEGAONCOOPP? FEBGOIPDFBI);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OBGCAJKMBFN(long HAMIEGOKEJC, long KIBMHJEFMKG, IEGAONCOOPP? FEBGOIPDFBI);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MLLBKCFDACI(PersistenceView FIHOFPLBHGJ);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool NMHHJIPANKH(PersistenceView AFCPDJEIDLD);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool IFKDBCFOFIH(HGNMPOIAAKI EJFGMPEJEDD, HBHNCFJCIKF KJBJOIGGOCH, out GKDPOMOKADP OHHKEBOPNAF);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task ILODAAHACKN(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void DHLEAONJDIN();

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable MJKOEHHJIGF();

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void DEMPKIDPOMC(BNIDNMGAHLD BBBFCKGLENJ, HBHNCFJCIKF KJBJOIGGOCH);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> ECHGGKEINGC(EPJFONLPCOB EKLPJDMGHDM, CancellationToken GFFFFCALMCA, AALOEEPNEOP LEBCJIHOHHE);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void EDJMEEDMGOD(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<LPCDCAILFOA> MKIGCNOMKGI(NEBPAIJOJCP PAJPFFIMEFB);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<IEMLKNOFDEG> LLIJKKNNJOP(long HAMIEGOKEJC, bool GCJJOJLIFFI, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<BNNPCINDEGK> CDFBEKELOHD(long HAMIEGOKEJC, long KIBMHJEFMKG, long PJBAEAJLHMO, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<CAIGCNABMEN> LPALFELCAHM(string APOLELLKJLH, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<CAIGCNABMEN> AAHGHJMMPPF(string APOLELLKJLH, long HAMIEGOKEJC, long KIBMHJEFMKG, string OPOLKMBAJBK, NIADFLCAKKJ.BLEDDCONCNO CMMCIHFHBLL, NIADFLCAKKJ.BLEDDCONCNO HOIJLNKGLFK, int DEPJAMELNGJ);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool BPLLMFFJGAA();

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool OGINDCNJOGA();

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool FIFNKADIEEO(IEnumerable<GKDPOMOKADP> IGIOLCOIKFA);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void FMOCKPKCFCD(List<GameObject> EFKKBFKJFPG);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float GLCIIMFBOHN();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool BPFAPADGDNM(string KPMIPNBJALP, out Scene IKOPIEMNEKF);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> PNEPKELPBPK(string KPMIPNBJALP, LoadSceneMode EMEPBMIHOEO, bool DJJMALJEJII, AALOEEPNEOP IDIJCJCNEPO);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void HFIDDOBGHNG();

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool MJANIBKKGKE(ByteString KNJBCHEFCED);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void EHFPLOBAFBB();

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void LDFJMKEMOEL();

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void HOIIHFLGKFE(MHKEFJDKLJN PDOICCGDHHF);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "62")]
	Task HBEDCFJFEGH(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task NOHPLHNKJCK(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task JBIFFBCHAOI(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void ENEHPOPGJDJ();

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "66")]
	IDisposable KFLOBOCLKHG();

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "67")]
	JKKCGILCDLC HNHMEPILOKF();

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task JELPAAOMODI(CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface JKKCGILCDLC
{
	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NGCNLJOBCMB(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ABJLOPKAJKI(CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct DHJIDMGNJIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public HashSet<int> LAGFPCECFEP;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public enum JLOOFCOEEHE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class EADHPHKIDHL
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class KJNIBMJHKAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public HDDCAHBLLEN finalTimerLogFlags;

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KJNIBMJHKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x48A31E0", Offset = "0x48A1DE0", VA = "0x1848A31E0")]
		internal void NEKAOOAPCBO(BDPOMAKGMDN t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class LPJEGNEIEKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public global::JAPPGKMKBNF<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LPJEGNEIEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x48A51A0", Offset = "0x48A3DA0", VA = "0x1848A51A0")]
		internal object PKJFDBMMMDF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public const string BNKFANAMJEE = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public const string NCFIHLMKILH = "END: ";

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB7A0", Offset = "0x2ACA3A0", VA = "0x182ACB7A0")]
	public static global::JAPPGKMKBNF<string> AKLIDLOGNAK([Optional] string EKLNNMKJFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB910", Offset = "0x2ACA510", VA = "0x182ACB910")]
	public static global::JAPPGKMKBNF<string> AKLIDLOGNAK(HDDCAHBLLEN KDJDJIAAKGI, [Optional] string EKLNNMKJFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2ACBA20", Offset = "0x2ACA620", VA = "0x182ACBA20")]
	private static void BEOIMNJHGDJ(string BDFCACLHAFA, AHBCFPPHHDO IDIJCJCNEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2ACBB30", Offset = "0x2ACA730", VA = "0x182ACBB30")]
	private static void DAMIAJAPFJI(string BDFCACLHAFA, AHBCFPPHHDO IDIJCJCNEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2ACBD20", Offset = "0x2ACA920", VA = "0x182ACBD20")]
	public static void NJBCIHNHCDG(global::JAPPGKMKBNF<string> IDIJCJCNEPO, HDDCAHBLLEN ODPKAHOAPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2ACBC40", Offset = "0x2ACA840", VA = "0x182ACBC40")]
	public static string JBLJNPMCAIB(FHMBHNPINBI IFPNDMLIDFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal class AEONCJCINHA : OCAOCNCNOCD, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class IICKCEOFGIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public MOMCOKAPMLC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AEONCJCINHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private Func<CancellationToken, List<Task>> <taskGenerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IICKCEOFGIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x3261090", Offset = "0x325FC90", VA = "0x183261090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class JDAMIFBLIGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AEONCJCINHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public MOMCOKAPMLC roomData;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JDAMIFBLIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3261980", Offset = "0x3260580", VA = "0x183261980")]
		internal List<Task> LGJEAMKDKJK(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class AHCMIKAGBFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public NDLLDLNNGKD taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public AEONCJCINHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public AHCMIKAGBFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x325CB60", Offset = "0x325B760", VA = "0x18325CB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class OMJCDDPPIAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public AEONCJCINHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public OMJCDDPPIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x3271D30", Offset = "0x3270930", VA = "0x183271D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly HashSet<NDLLDLNNGKD> CFPBFMNDOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private GHOMLKKKKHM IIJBBPIGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private HGGHGJBADJJ PCNABAKEDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private EMOAKECFAIC GJMOIKFOKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private IDisposable IGMACGPPKGM;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool CEMOOCAECHD
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3CE0", Offset = "0x2AC28E0", VA = "0x182AC3CE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	internal Task KCIAOCJILBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x2AC31B0", Offset = "0x2AC1DB0", VA = "0x182AC31B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3D10", Offset = "0x2AC2910", VA = "0x182AC3D10", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2AC31C0", Offset = "0x2AC1DC0", VA = "0x182AC31C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2AC37E0", Offset = "0x2AC23E0", VA = "0x182AC37E0", Slot = "5")]
	public bool JBCFBBEJPKG(NDLLDLNNGKD JOBDEEONKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3320", Offset = "0x2AC1F20", VA = "0x182AC3320")]
	private void HOPGIKLHCMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3840", Offset = "0x2AC2440", VA = "0x182AC3840")]
	private void JBMCGODGAFK(MOMCOKAPMLC CMMCIHFHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2AC2AB0", Offset = "0x2AC16B0", VA = "0x182AC2AB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IICKCEOFGIF))]
	private Task BNCHPNCJPIE(MOMCOKAPMLC CMMCIHFHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3240", Offset = "0x2AC1E40", VA = "0x182AC3240")]
	private Func<CancellationToken, List<Task>> FFNAMDMFGNC(MOMCOKAPMLC CMMCIHFHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2AC2C00", Offset = "0x2AC1800", VA = "0x182AC2C00")]
	private List<Task> CMPFDJLLOAD(MOMCOKAPMLC CMMCIHFHBLL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3B40", Offset = "0x2AC2740", VA = "0x182AC3B40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AHCMIKAGBFJ))]
	private Task JCKGPKELFGI(NDLLDLNNGKD GALABLGPLIG, MOMCOKAPMLC PHBHEFAPHDL, CancellationToken FLDJLPKNKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC36C0", Offset = "0x2AC22C0", VA = "0x182AC36C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMJCDDPPIAG))]
	private Task IMGJEMNFBPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3590", Offset = "0x2AC2190", VA = "0x182AC3590")]
	private void IHLPPHPEFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3FB0", Offset = "0x2AC2BB0", VA = "0x182AC3FB0")]
	public AEONCJCINHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal interface HLDCIPKGMNF : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool JHKJEJHMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Task NLFPKAMNLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHJNMAOMFMN(Task GAKDIIFBLNI, string NNLMNOOEFFA);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class BPDCHEJGLEB : HMAILMDEICE
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class JBACILOGPJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public BPDCHEJGLEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JBACILOGPJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x32615B0", Offset = "0x32601B0", VA = "0x1832615B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private readonly IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private readonly HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x8366A0", Offset = "0x8352A0", VA = "0x1808366A0")]
	public BPDCHEJGLEB(IFNNJAAOEDN FNIFBLHBOOE, HBPPPIGEKFO FGOMHOJPKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6390", Offset = "0x2AC4F90", VA = "0x182AC6390", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JBACILOGPJK))]
	public Task<bool> BFAINGMPNNG(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6500", Offset = "0x2AC5100", VA = "0x182AC6500")]
	[CompilerGenerated]
	private object MJNFCNHNFBF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class LGGJCNKGNNJ : KBIEMNNHIEA, DPADKKHLKLF, CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class IIINIOJANIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public IDIFMABCDLA result;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IIINIOJANIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F7BB50", Offset = "0x3F7A750", VA = "0x183F7BB50")]
		internal object MHIABBOBHCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3266C70", Offset = "0x3265870", VA = "0x183266C70")]
	[UnityEngine.Scripting.Preserve]
	public LGGJCNKGNNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x3266AE0", Offset = "0x32656E0", VA = "0x183266AE0", Slot = "8")]
	public IDIFMABCDLA KDJGBCGJOCG(IGGCDPKBFGF AOLFPABEEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface JOLNEEIAHIL
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool AMADDIGKHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	string FIFAJPMPCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFEGFHLPEBL();

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MHMLFGJNJKA IEPMIFNDONP(long BFNOJMGJLFG);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::FNOEIOAGCPK<EFENBEKLEHO, CIOHJELGAHC> ILKGANIKHBB(long BFNOJMGJLFG);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::FNOEIOAGCPK<EFENBEKLEHO, BNIDNMGAHLD> HAFGIPOEOLP(long BFNOJMGJLFG);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::FNOEIOAGCPK<long, DBGKDIDMLDF> PBEEICJIDHJ();

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> IHJFEHBNFBL(byte[] IKHHHDILDNK, byte[] HOIJLNKGLFK, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class OPLKMJPGMHE : MFHIJBENPCO, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class JAHGDBAOKME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JAHGDBAOKME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C4D0", Offset = "0x5E1B0D0", VA = "0x185E1C4D0")]
		internal object EBEEFKOEAJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class DEOIPINPEPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DEOIPINPEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E198F0", Offset = "0x5E184F0", VA = "0x185E198F0")]
		internal object NBDHKEJKBAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class JHOMONPFIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JHOMONPFIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CE20", Offset = "0x5E1BA20", VA = "0x185E1CE20")]
		internal object BLBCHAJHGFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class KBLLBPHCGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KBLLBPHCGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D430", Offset = "0x5E1C030", VA = "0x185E1D430")]
		internal object NDIDFMEMLNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class DBJCIKLDBMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DBJCIKLDBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E19890", Offset = "0x5E18490", VA = "0x185E19890")]
		internal object AMJPKDKGJJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private readonly Dictionary<Guid, KJLLMJJEGBB> GAOOEGMBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly TimeSpan MHKBKFFBMGN;

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "10")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x3273610", Offset = "0x3272210", VA = "0x183273610", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x32730B0", Offset = "0x3271CB0", VA = "0x1832730B0", Slot = "4")]
	public LIHFEMBJCAM CAILCKFFJIK(Guid PALLEDHBFCO)
	{
		return default(LIHFEMBJCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3273350", Offset = "0x3271F50", VA = "0x183273350", Slot = "5")]
	public bool CPPHPNNFPKL(Guid PALLEDHBFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3273620", Offset = "0x3272220", VA = "0x183273620", Slot = "8")]
	public bool IHLPPHPEFDP(Guid PALLEDHBFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3273B80", Offset = "0x3272780", VA = "0x183273B80", Slot = "6")]
	public bool LPGMNPDMPPM(Guid PALLEDHBFCO, Task OIDBJIACCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x32738B0", Offset = "0x32724B0", VA = "0x1832738B0", Slot = "7")]
	public bool JJNOGDGBEML(Guid PALLEDHBFCO, IDIFMABCDLA NPAEKAKKGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3273F50", Offset = "0x3272B50", VA = "0x183273F50", Slot = "9")]
	public Task<(IDIFMABCDLA, Task)> PDGJMOLMFLF(Guid PALLEDHBFCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3272DE0", Offset = "0x32719E0", VA = "0x183272DE0")]
	private void ACCPDGFAFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3273FE0", Offset = "0x3272BE0", VA = "0x183273FE0")]
	public OPLKMJPGMHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public class FFJLHIIMOFL : KBIEMNNHIEA, BEIIGIJBNMM, CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class GKKBEOKCBCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public IDIFMABCDLA result;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GKKBEOKCBCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x489E990", Offset = "0x489D590", VA = "0x18489E990")]
		internal object ALMDFNLKKMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE980", Offset = "0x2ACD580", VA = "0x182ACE980")]
	[UnityEngine.Scripting.Preserve]
	public FFJLHIIMOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE7F0", Offset = "0x2ACD3F0", VA = "0x182ACE7F0", Slot = "8")]
	public IDIFMABCDLA IGGGLNHPCKG(IGGCDPKBFGF ACJGGEOLANN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal interface LKGOGFHLDFK : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	TaskStatus HEHIDPGEMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MHKIGANIEGO(MHKEFJDKLJN FKMIOMCKJNF, OAEILIIIPED LBJHHPLDPCI, CancellationToken KHEICKPBIBD);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal static class IGKJGLPENOO
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF0C0", Offset = "0x2ADDCC0", VA = "0x182ADF0C0")]
	public static bool KADKOGACMKG(this LKGOGFHLDFK HBHHBLLKCLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class GLFEJKNHJJP
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8360", Offset = "0x2AD6F60", VA = "0x182AD8360")]
	public static string OFFBBLKFMFL(this MHKEFJDKLJN BIJBNMHAAEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AD82D0", Offset = "0x2AD6ED0", VA = "0x182AD82D0")]
	public static bool ANNNHOHBBHJ(this MHKEFJDKLJN BIJBNMHAAEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[UnityEngine.Scripting.Preserve]
internal class GBIMIGMJJBK : LFPKDNNPHDE, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class PDCGGKLMGEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public GBIMIGMJJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public PDCGGKLMGEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x48AA0C0", Offset = "0x48A8CC0", VA = "0x1848AA0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class HAFNPGEIJOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public GBIMIGMJJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private bool <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HAFNPGEIJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x489E9F0", Offset = "0x489D5F0", VA = "0x18489E9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class EDINKMJPCLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public EDINKMJPCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x489C250", Offset = "0x489AE50", VA = "0x18489C250")]
		internal object LMCIPKIPBCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class DFNOODHGIEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public GBIMIGMJJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private EDINKMJPCLP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private HMAILMDEICE <provider>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DFNOODHGIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x489A880", Offset = "0x4899480", VA = "0x18489A880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class GEJLAEHLBHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GEJLAEHLBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x489D290", Offset = "0x489BE90", VA = "0x18489D290")]
		internal object DJBENOEIEAM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private HMAILMDEICE[] HNAJPCAIOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private CancellationTokenSource MFGBDLCLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private int ABAHDMMJMOJ;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5260", Offset = "0x2AD3E60", VA = "0x182AD5260", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2AD44D0", Offset = "0x2AD30D0", VA = "0x182AD44D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2AD47C0", Offset = "0x2AD33C0", VA = "0x182AD47C0", Slot = "6")]
	public void IHLPPHPEFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4260", Offset = "0x2AD2E60", VA = "0x182AD4260", Slot = "5")]
	public void DEAHNGCCEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4950", Offset = "0x2AD3550", VA = "0x182AD4950", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDCGGKLMGEN))]
	public Task JHKFDEFLOCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4BC0", Offset = "0x2AD37C0", VA = "0x182AD4BC0")]
	private void NCLKBMEBDPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2AD44E0", Offset = "0x2AD30E0", VA = "0x182AD44E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HAFNPGEIJOK))]
	private Task GKILPCLEHMP(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4630", Offset = "0x2AD3230", VA = "0x182AD4630")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DFNOODHGIEH))]
	private Task<bool> HOCEBFKAOGC(int NHHNPPKPBIA, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5100", Offset = "0x2AD3D00", VA = "0x182AD5100")]
	private void NNCIEJCOMBA(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4A70", Offset = "0x2AD3670", VA = "0x182AD4A70")]
	private void KBPKOBDJBJP(int NHHNPPKPBIA, bool GGKLFMPBGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4F40", Offset = "0x2AD3B40", VA = "0x182AD4F40")]
	private void NDBCEBKOCNP(int NHHNPPKPBIA, Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x2AD43C0", Offset = "0x2AD2FC0", VA = "0x182AD43C0")]
	private void DIHPGJDHNEM(CancellationToken GFFFFCALMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x2AD52E0", Offset = "0x2AD3EE0", VA = "0x182AD52E0")]
	public GBIMIGMJJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class AKHFFEBLFLI
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4D70", Offset = "0x2AC3970", VA = "0x182AC4D70")]
	public static void LODDLPCJOOC(this EPJFONLPCOB EKLPJDMGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4D80", Offset = "0x2AC3980", VA = "0x182AC4D80")]
	public static void NMEJOAFIBFD(this EPJFONLPCOB EKLPJDMGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4C60", Offset = "0x2AC3860", VA = "0x182AC4C60")]
	private static void DEMANJMNJMK(this EPJFONLPCOB EKLPJDMGHDM, bool JKOLNMIPLMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public struct POFGIICIGOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public readonly MCJHCEJFKNC JOOMDEJHLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public readonly string KJLGHJOMLJO;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x32768D0", Offset = "0x32754D0", VA = "0x1832768D0")]
	public POFGIICIGOD(string GPMCGMIFIIK, MCJHCEJFKNC EGMEOIADPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x3276850", Offset = "0x3275450", VA = "0x183276850")]
	public string MOMBAAMFHDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x32767B0", Offset = "0x32753B0", VA = "0x1832767B0")]
	public string GCAPBBHFANN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public delegate string FKAEOHGBIDG<in T>(T BPFOEEABMGN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public delegate int LIFHOMMNNKM<in T>(T BPFOEEABMGN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class HNGHLPCGIPA : PILPGHODDIG
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private delegate string BHEDJILKDMB(Exception BPFOEEABMGN);

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private delegate int PHFOMAFIOLI(Exception BPFOEEABMGN);

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class PJAFKBFIKAK<T> : global::BBJCLIHKHGE<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class AIFOCMFFCDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
			public AIFOCMFFCDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
			internal string KCJDHMJIJPJ(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class BNKJALMFEED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x77CE70", Offset = "0x77C270")]
			public global::FKAEOHGBIDG<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
			public BNKJALMFEED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x2CAEC60", Offset = "0x2CAD860", VA = "0x182CAEC60")]
			internal string BAMOKCHGGHH(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class MIIBBHMOKKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public int subCode;

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
			public MIIBBHMOKKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x7F0000", Offset = "0x7EEC00", VA = "0x1807F0000")]
			internal int DGFHLAPIJNB(Exception _)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class ONCOAGHDDEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x77CED0", Offset = "0x77C2D0")]
			public global::LIFHOMMNNKM<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
			public ONCOAGHDDEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x2CAEC60", Offset = "0x2CAD860", VA = "0x182CAEC60")]
			internal int DJINAFDOFII(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private readonly HNGHLPCGIPA DCLPNPGHFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly Type IHOHJBKPLGC;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x3A8D9A0", Offset = "0x3A8C5A0", VA = "0x183A8D9A0")]
		internal PJAFKBFIKAK(HNGHLPCGIPA DCLPNPGHFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x3A8D850", Offset = "0x3A8C450", VA = "0x183A8D850", Slot = "4")]
		public void OFKKPAPNNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x3A8D750", Offset = "0x3A8C350", VA = "0x183A8D750", Slot = "5")]
		public global::BBJCLIHKHGE<T> MNONDJFMJHF(string LJGKGILKHCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x3A8D540", Offset = "0x3A8C140", VA = "0x183A8D540", Slot = "6")]
		public global::BBJCLIHKHGE<T> IPJKAHEAOIN(global::FKAEOHGBIDG<T> EMJBJKKPMII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x3A8D500", Offset = "0x3A8C100", VA = "0x183A8D500", Slot = "7")]
		public global::BBJCLIHKHGE<T> DJLCCKADJOD(int EGMEOIADPFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3A8D640", Offset = "0x3A8C240", VA = "0x183A8D640", Slot = "8")]
		public global::BBJCLIHKHGE<T> JPCCKFPDCIL(int EGMEOIADPFI, int IEPBGECFBIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x3A8D880", Offset = "0x3A8C480", VA = "0x183A8D880", Slot = "9")]
		public global::BBJCLIHKHGE<T> OMLFADBINCK(int EGMEOIADPFI, global::LIFHOMMNNKM<T> HGLLKEAJGLO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	private class IEPENJPADNO<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private bool FICLLNGHBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private readonly List<Type> LKDHDKJNCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly Dictionary<Type, TVal> HFKHBPEFOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private readonly Dictionary<Type, int> CFFFABPLIPM;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<Type> GDALLGCOGJN
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x1A0D870", Offset = "0x1A0C470", VA = "0x181A0D870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1A0DB40", Offset = "0x1A0C740", VA = "0x181A0DB40")]
		public IEPENJPADNO(Dictionary<Type, int> CFFFABPLIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D5C0", Offset = "0x1A0C1C0", VA = "0x181A0D5C0")]
		public void CAILCKFFJIK(Type BDFCACLHAFA, TVal FOHLJCNEPNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D9F0", Offset = "0x1A0C5F0", VA = "0x181A0D9F0")]
		public bool PBFMMEHNOBJ(Type IHOHJBKPLGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D700", Offset = "0x1A0C300", VA = "0x181A0D700")]
		public bool EJCEIGEMLDE(TVal ECNGHFJBIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x1A0DA20", Offset = "0x1A0C620", VA = "0x181A0DA20")]
		public TVal PNBJHLBKMLC(Type FIJCKHKKDCC)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D7D0", Offset = "0x1A0C3D0", VA = "0x181A0D7D0")]
		[CompilerGenerated]
		private int FKBJGNIOBJL(Type IAKDHNCLOEJ, Type OHFJGMKOBJC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private sealed class KGPFLGOIIHE : IEnumerable<MCJHCEJFKNC>, IEnumerable, IEnumerator<MCJHCEJFKNC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private MCJHCEJFKNC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public HNGHLPCGIPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private AggregateException <aggregateException>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private IEnumerator<Exception> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private Exception <innerException>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private IEnumerator<MCJHCEJFKNC> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private MCJHCEJFKNC <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private MCJHCEJFKNC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x11C4AB0", Offset = "0x11C36B0", VA = "0x1811C4AB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MCJHCEJFKNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x3F7EBE0", Offset = "0x3F7D7E0", VA = "0x183F7EBE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xAF7620", Offset = "0xAF6220", VA = "0x180AF7620")]
		[DebuggerHidden]
		public KGPFLGOIIHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x3F7EC30", Offset = "0x3F7D830", VA = "0x183F7EC30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E680", Offset = "0x3F7D280", VA = "0x183F7E680", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E630", Offset = "0x3F7D230", VA = "0x183F7E630")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x3F7EAA0", Offset = "0x3F7D6A0", VA = "0x183F7EAA0")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x3F7EBA0", Offset = "0x3F7D7A0", VA = "0x183F7EBA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x3F7EAF0", Offset = "0x3F7D6F0", VA = "0x183F7EAF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MCJHCEJFKNC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x3F7EAF0", Offset = "0x3F7D6F0", VA = "0x183F7EAF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	internal const int AFFEALLLJLD = 8700;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private static readonly MCJHCEJFKNC ALHDEFACHLC;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	internal const string FCLEPJLHPJG = "Unknown error loading room";

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	internal const int NBDHGAEMHCP = 8708;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static readonly Dictionary<Type, int> NOKKENMNDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private readonly HashSet<Type> HGPAECGPHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private readonly IEPENJPADNO<int> IOOKCCHDBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly IEPENJPADNO<PHFOMAFIOLI> NJOGKJHBBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly IEPENJPADNO<BHEDJILKDMB> FFOIOJEFLDF;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDA60", Offset = "0x2ADC660", VA = "0x182ADDA60")]
	[BBAPFPLPODF(EDNJEIFHIMJ.GameOnly)]
	private static void LECKBAIJAMJ(MHOBEFMLEFD EOOGCBGOIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDE70", Offset = "0x2ADCA70", VA = "0x182ADDE70")]
	[RecRoom.NoEngine.Common.Preserve]
	public HNGHLPCGIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2058240", Offset = "0x2056E40", VA = "0x182058240", Slot = "4")]
	public global::BBJCLIHKHGE<T> JDOICDLJCNN<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD310", Offset = "0x2ADBF10", VA = "0x182ADD310", Slot = "5")]
	public POFGIICIGOD DBBGDMPPFKL(Exception BPFOEEABMGN)
	{
		return default(POFGIICIGOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD3D0", Offset = "0x2ADBFD0", VA = "0x182ADD3D0", Slot = "6")]
	public MCJHCEJFKNC EEBNDIDCOOC(Exception? BPFOEEABMGN)
	{
		return default(MCJHCEJFKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD040", Offset = "0x2ADBC40", VA = "0x182ADD040", Slot = "7")]
	[IteratorStateMachine(typeof(KGPFLGOIIHE))]
	public IEnumerable<MCJHCEJFKNC> CKGHHAFBMBP(Exception BPFOEEABMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDAD0", Offset = "0x2ADC6D0", VA = "0x182ADDAD0", Slot = "8")]
	public string NPENLAPPDKC(Exception? BPFOEEABMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD6E0", Offset = "0x2ADC2E0", VA = "0x182ADD6E0")]
	private string IDANJPLNFHD(AggregateException EIOBGNABOHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x2ADCCA0", Offset = "0x2ADB8A0", VA = "0x182ADCCA0")]
	private void CDNAIFFDCDP(Type IHOHJBKPLGC, int EGMEOIADPFI, PHFOMAFIOLI? JIJNHOFBOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD0D0", Offset = "0x2ADBCD0", VA = "0x182ADD0D0")]
	private void CMHCMNHACDK(Type IHOHJBKPLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC9E0", Offset = "0x2ADB5E0", VA = "0x182ADC9E0")]
	private void AGNOJODIJIO(Type IHOHJBKPLGC, BHEDJILKDMB ABLIDJBMNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDC10", Offset = "0x2ADC810", VA = "0x182ADDC10")]
	private static int PONDELGGKKB(Type IHOHJBKPLGC, Dictionary<Type, int> CFFFABPLIPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D6B0", Offset = "0x2B7C2B0", VA = "0x182B7D6B0")]
	private static bool NAKJALEKHHL<TVal>(IEPENJPADNO<TVal> EFLCMDHDGNO, Type IHOHJBKPLGC, out TVal ECNGHFJBIJL) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD5F0", Offset = "0x2ADC1F0", VA = "0x182ADD5F0")]
	[CompilerGenerated]
	internal static int FFFICNEALGN(Type APFMAJJJHIL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct MCJHCEJFKNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public readonly int PBLPFCGODJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly int? PMFILMJGPLD;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x26814D0", Offset = "0x26800D0", VA = "0x1826814D0")]
	public MCJHCEJFKNC(int ALCHPPPJPLL, [Optional] int? IEPBGECFBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x3268B40", Offset = "0x3267740", VA = "0x183268B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface PILPGHODDIG
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::BBJCLIHKHGE<T> JDOICDLJCNN<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "1")]
	POFGIICIGOD DBBGDMPPFKL(Exception BPFOEEABMGN);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MCJHCEJFKNC EEBNDIDCOOC(Exception BPFOEEABMGN);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<MCJHCEJFKNC> CKGHHAFBMBP(Exception BPFOEEABMGN);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string NPENLAPPDKC(Exception BPFOEEABMGN);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface BBJCLIHKHGE<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFKKPAPNNEP();

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BBJCLIHKHGE<T> MNONDJFMJHF(string LJGKGILKHCG);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::BBJCLIHKHGE<T> IPJKAHEAOIN(global::FKAEOHGBIDG<T> EMJBJKKPMII);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::BBJCLIHKHGE<T> DJLCCKADJOD(int EGMEOIADPFI);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::BBJCLIHKHGE<T> JPCCKFPDCIL(int EGMEOIADPFI, int IEPBGECFBIF);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::BBJCLIHKHGE<T> OMLFADBINCK(int EGMEOIADPFI, global::LIFHOMMNNKM<T> HGLLKEAJGLO);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class PLKPJMGBMCG
{
	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x3275820", Offset = "0x3274420", VA = "0x183275820")]
	[BBAPFPLPODF(EDNJEIFHIMJ.GameOnly)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD EOOGCBGOIGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface HCKACEFMPCF : IEquatable<HCKACEFMPCF>
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	DateTime NAHEEPGPOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOGFBGPCJFE();

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OODKEBIOIGI(long HAMIEGOKEJC, long BPODGJMCBKI, out EJCOGPHMIIO NNIPLGKEGFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal class PLNJOEPHKBI : LCAFMEKLLGH
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class ILAJAIKNOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ILAJAIKNOAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class LMEMCAGEHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public ILAJAIKNOAM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LMEMCAGEHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E7C0", Offset = "0x5E1D3C0", VA = "0x185E1E7C0")]
		internal object MAJIHGKLAPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly GFOFIPPNDLA JDHPBKJGAKB;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private const int FOGLCLBBAPI = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<HCKACEFMPCF> APNHNBKPOIP
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x3275B40", Offset = "0x3274740", VA = "0x183275B40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x3275C90", Offset = "0x3274890", VA = "0x183275C90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x836EE0", Offset = "0x835AE0", VA = "0x180836EE0")]
	[UnityEngine.Scripting.Preserve]
	public PLNJOEPHKBI([ACEKLAKDMBL(null)] GFOFIPPNDLA JDHPBKJGAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x3276340", Offset = "0x3274F40", VA = "0x183276340", Slot = "6")]
	public bool NECCIEOBFKO(long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ, NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x32762A0", Offset = "0x3274EA0", VA = "0x1832762A0")]
	private void JPIBCGPDDPM(HCKACEFMPCF IPKBJACGFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x3276120", Offset = "0x3274D20", VA = "0x183276120", Slot = "7")]
	public bool JLPGPOOMIFG(long HAMIEGOKEJC, long BPODGJMCBKI, out HCKACEFMPCF ANGBHDDNJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x3275BE0", Offset = "0x32747E0", VA = "0x183275BE0", Slot = "8")]
	public bool DGKKMEKKLFM(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, out HCKACEFMPCF ANGBHDDNJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x3275D30", Offset = "0x3274930", VA = "0x183275D30")]
	private void HANDJCNDOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x3276690", Offset = "0x3275290", VA = "0x183276690", Slot = "9")]
	public void NIGPPAMDDAN(long HAMIEGOKEJC, long BPODGJMCBKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public enum KEFDFHALGBD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal sealed class JDGNMBGDALO : ANAIMAOJPDB
{
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly byte[] BDFCACLHAFA;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private const string DGDMFPEBCOO = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private const string CODHELJOPDL = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private const string OBHHBBFHABC = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private readonly byte[] IIKMCOGMLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private readonly byte[] GDHEFGLCJLB;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public override KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x974DD0", Offset = "0x9739D0", VA = "0x180974DD0", Slot = "8")]
		get
		{
			return default(KEFDFHALGBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2030", Offset = "0x2AE0C30", VA = "0x182AE2030")]
	public JDGNMBGDALO([Optional] string OCNGBBKIHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1980", Offset = "0x2AE0580", VA = "0x182AE1980", Slot = "9")]
	internal override void IHGHDLEMING(Stream KLJHBBOMDPF, long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2AE10A0", Offset = "0x2ADFCA0", VA = "0x182AE10A0", Slot = "10")]
	internal override bool FDCEHBPPHBP(Stream AADDFDBIEHK, long HAMIEGOKEJC, long BPODGJMCBKI, NAFNDJJJCJL PPBPOHDFOAA, out EJCOGPHMIIO NNIPLGKEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1C50", Offset = "0x2AE0850", VA = "0x182AE1C50")]
	private void IKFDOOENNCH(byte[] ENEAOCDMOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1D60", Offset = "0x2AE0960", VA = "0x182AE1D60", Slot = "11")]
	protected override FileInfo LPAKNDMHHJP(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1E90", Offset = "0x2AE0A90", VA = "0x182AE1E90", Slot = "12")]
	protected override DirectoryInfo PLFMCDHHBCL(NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal class ENLFGFJFMAL : ANAIMAOJPDB
{
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private const string KMHBNCMOHDN = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private const string DGDMFPEBCOO = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private const string CODHELJOPDL = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public override KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x15236C0", Offset = "0x15222C0", VA = "0x1815236C0", Slot = "8")]
		get
		{
			return default(KEFDFHALGBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2ACD040", Offset = "0x2ACBC40", VA = "0x182ACD040")]
	public ENLFGFJFMAL([Optional] string OCNGBBKIHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2ACCB20", Offset = "0x2ACB720", VA = "0x182ACCB20")]
	private void HFHGPDNAOIF(NFBLDIHAPOJ GJGJDNGPKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2ACCBB0", Offset = "0x2ACB7B0", VA = "0x182ACCBB0", Slot = "9")]
	internal override void IHGHDLEMING(Stream KLJHBBOMDPF, long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2ACC4A0", Offset = "0x2ACB0A0", VA = "0x182ACC4A0", Slot = "10")]
	internal override bool FDCEHBPPHBP(Stream AADDFDBIEHK, long HAMIEGOKEJC, long BPODGJMCBKI, NAFNDJJJCJL PPBPOHDFOAA, out EJCOGPHMIIO NNIPLGKEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2ACCE40", Offset = "0x2ACBA40", VA = "0x182ACCE40", Slot = "11")]
	protected override FileInfo LPAKNDMHHJP(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2ACCF30", Offset = "0x2ACBB30", VA = "0x182ACCF30", Slot = "12")]
	protected override DirectoryInfo PLFMCDHHBCL(NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal abstract class ANAIMAOJPDB : GFOFIPPNDLA
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	protected enum NMAAMKHLHLG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class JIADGPIKPFP : IEnumerable<HCKACEFMPCF>, IEnumerable, IEnumerator<HCKACEFMPCF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private HCKACEFMPCF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public NFBLDIHAPOJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public ANAIMAOJPDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private DirectoryInfo <autosaveDirectory>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private FileInfo[] <files>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private FileInfo[] <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private FileInfo <file>5__5;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		private HCKACEFMPCF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xAF7620", Offset = "0xAF6220", VA = "0x180AF7620")]
		[DebuggerHidden]
		public JIADGPIKPFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x32619B0", Offset = "0x32605B0", VA = "0x1832619B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x3261CD0", Offset = "0x32608D0", VA = "0x183261CD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x3261C20", Offset = "0x3260820", VA = "0x183261C20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HCKACEFMPCF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x3261C20", Offset = "0x3260820", VA = "0x183261C20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class COCKNNNFBPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public COCKNNNFBPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x325E4C0", Offset = "0x325D0C0", VA = "0x18325E4C0")]
		internal object DDNCFPLJPHH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class NJMOBPAAEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public ANAIMAOJPDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NJMOBPAAEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x326CB90", Offset = "0x326B790", VA = "0x18326CB90")]
		internal void GFHMNIEDHJE(CAIMCDALKCM.KILBMHIFLCG ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	protected readonly string GGPDPGDFDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly object CBCJPCHPPCF;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public abstract KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5E00", Offset = "0x2AC4A00", VA = "0x182AC5E00")]
	protected ANAIMAOJPDB([CanBeNull] string OCNGBBKIHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC55D0", Offset = "0x2AC41D0", VA = "0x182AC55D0", Slot = "5")]
	public bool AKHOODPCDID(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, out HCKACEFMPCF IPKBJACGFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5D80", Offset = "0x2AC4980", VA = "0x182AC5D80", Slot = "6")]
	[IteratorStateMachine(typeof(JIADGPIKPFP))]
	public IEnumerable<HCKACEFMPCF> LFJJEAPOAKA(NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void IHGHDLEMING(Stream KLJHBBOMDPF, long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool FDCEHBPPHBP(Stream AADDFDBIEHK, long HAMIEGOKEJC, long BPODGJMCBKI, NAFNDJJJCJL PPBPOHDFOAA, out EJCOGPHMIIO NNIPLGKEGFJ);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5AA0", Offset = "0x2AC46A0", VA = "0x182AC5AA0", Slot = "7")]
	public HCKACEFMPCF FPLPAECHFDP(long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ, NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo LPAKNDMHHJP(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo PLFMCDHHBCL(NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5A30", Offset = "0x2AC4630", VA = "0x182AC5A30")]
	protected void DPDGGJOMCGI(CAIMCDALKCM.KILBMHIFLCG BMNHBAEKDJF, string BAMBEECFNAE, FileInfo FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5780", Offset = "0x2AC4380", VA = "0x182AC5780")]
	internal bool BEPEKNNMMCD(FileInfo CLHKKIBAGBL, long HAMIEGOKEJC, long BPODGJMCBKI, out EJCOGPHMIIO NNIPLGKEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	private void GGEJJPKENJD(Exception LNDIIAIJNMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal interface GFOFIPPNDLA
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AKHOODPCDID(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, out HCKACEFMPCF IPKBJACGFCO);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<HCKACEFMPCF> LFJJEAPOAKA(NFBLDIHAPOJ GJGJDNGPKAK);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HCKACEFMPCF FPLPAECHFDP(long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ, NFBLDIHAPOJ GJGJDNGPKAK);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class MEGOIKJNOJE : GFOFIPPNDLA
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class KHPAOJHDIFE : IEnumerable<HCKACEFMPCF>, IEnumerable, IEnumerator<HCKACEFMPCF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private HCKACEFMPCF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public NFBLDIHAPOJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public MEGOIKJNOJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private KEFDFHALGBD[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private KEFDFHALGBD <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private GFOFIPPNDLA <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private IEnumerable<HCKACEFMPCF> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private IEnumerator<HCKACEFMPCF> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private HCKACEFMPCF <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private HCKACEFMPCF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xAF7620", Offset = "0xAF6220", VA = "0x180AF7620")]
		[DebuggerHidden]
		public KHPAOJHDIFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F190", Offset = "0x3F7DD90", VA = "0x183F7F190", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x3F7ED50", Offset = "0x3F7D950", VA = "0x183F7ED50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x3F7ED00", Offset = "0x3F7D900", VA = "0x183F7ED00")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F150", Offset = "0x3F7DD50", VA = "0x183F7F150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F0A0", Offset = "0x3F7DCA0", VA = "0x183F7F0A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HCKACEFMPCF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F0A0", Offset = "0x3F7DCA0", VA = "0x183F7F0A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private readonly KEFDFHALGBD[] JCKIOCFKJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private readonly Dictionary<KEFDFHALGBD, GFOFIPPNDLA> NOJPIBMPNCI;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x3269A00", Offset = "0x3268600", VA = "0x183269A00", Slot = "4")]
		get
		{
			return default(KEFDFHALGBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x3269C80", Offset = "0x3268880", VA = "0x183269C80")]
	[UnityEngine.Scripting.Preserve]
	public MEGOIKJNOJE(params GFOFIPPNDLA[] BMGONLEPFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x3269730", Offset = "0x3268330", VA = "0x183269730", Slot = "5")]
	public bool AKHOODPCDID(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, out HCKACEFMPCF IPKBJACGFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x3269A40", Offset = "0x3268640", VA = "0x183269A40")]
	private void MNLAMOGCOHJ(int HDCGHJJAEJH, long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x3269980", Offset = "0x3268580", VA = "0x183269980", Slot = "6")]
	[IteratorStateMachine(typeof(KHPAOJHDIFE))]
	public IEnumerable<HCKACEFMPCF> LFJJEAPOAKA(NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x3269890", Offset = "0x3268490", VA = "0x183269890", Slot = "7")]
	public HCKACEFMPCF FPLPAECHFDP(long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ, NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class ILPADHPMCMF
{
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	internal const int LIKHOLMOGCI = 32;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE05D0", Offset = "0x2ADF1D0", VA = "0x182AE05D0")]
	internal static byte[] LIJKACPPNKD(byte[] ENEAOCDMOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0550", Offset = "0x2ADF150", VA = "0x182AE0550")]
	public static void KJMEKNOJFLL(Stream NEOJHOCIJKI, byte[] KAMCEBCIEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0370", Offset = "0x2ADEF70", VA = "0x182AE0370")]
	public static bool GJAJGCIGAPI(Stream NEOJHOCIJKI, long CBKDEHFIPHJ, NAFNDJJJCJL MOJOLKEAMOM, out byte[] EOEHMAFBCHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public delegate void NAFNDJJJCJL(CAIMCDALKCM.KILBMHIFLCG JPIEJIAKMEN, string DKIECHCHJFL);
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal sealed class POIPJLMNDLN : HCKACEFMPCF, IEquatable<HCKACEFMPCF>, IEquatable<POIPJLMNDLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private readonly ANAIMAOJPDB DFELGBGBDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public readonly FileInfo OJIJENHCKAD;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xD587D0", Offset = "0xD573D0", VA = "0x180D587D0", Slot = "4")]
		get
		{
			return default(KEFDFHALGBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public DateTime NAHEEPGPOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x32768F0", Offset = "0x32754F0", VA = "0x1832768F0", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3276E60", Offset = "0x3275A60", VA = "0x183276E60")]
	public POIPJLMNDLN(ANAIMAOJPDB ELFANDMPEIC, FileInfo CLHKKIBAGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x3276DB0", Offset = "0x32759B0", VA = "0x183276DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x3276D00", Offset = "0x3275900", VA = "0x183276D00", Slot = "6")]
	public void OOGFBGPCJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x3276CC0", Offset = "0x32758C0", VA = "0x183276CC0", Slot = "7")]
	public bool OODKEBIOIGI(long HAMIEGOKEJC, long BPODGJMCBKI, out EJCOGPHMIIO NNIPLGKEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x3276B40", Offset = "0x3275740", VA = "0x183276B40", Slot = "8")]
	public bool Equals(HCKACEFMPCF MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x3276A90", Offset = "0x3275690", VA = "0x183276A90", Slot = "9")]
	public bool Equals(POIPJLMNDLN MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x3276990", Offset = "0x3275590", VA = "0x183276990", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x3276C20", Offset = "0x3275820", VA = "0x183276C20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x166CB90", Offset = "0x166B790", VA = "0x18166CB90")]
	public static bool FMMDKFLNNFA(POIPJLMNDLN FDMHBFLJJHC, POIPJLMNDLN DNGDHCADJJH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x166C760", Offset = "0x166B360", VA = "0x18166C760")]
	public static bool BDPOAMCDIDB(POIPJLMNDLN FDMHBFLJJHC, POIPJLMNDLN DNGDHCADJJH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal struct IDIAHGMFNCH
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class EDJJICHBNBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private IFNNJAAOEDN <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private AALOEEPNEOP <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public EDJJICHBNBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x3F77BA0", Offset = "0x3F767A0", VA = "0x183F77BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEF20", Offset = "0x2ADDB20", VA = "0x182ADEF20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDJJICHBNBB))]
	public static Task EBDHDHCPNAJ(DNKNJNMAMBL GIOAKJNONKE, MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct JMCMENJMMNC
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class OCNOGDHDBAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public OOCGABPOHBK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private IFNNJAAOEDN <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private HBPPPIGEKFO <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private HBHNCFJCIKF <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private List<(PersistenceView, HGNMPOIAAKI)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private HGNMPOIAAKI <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public OCNOGDHDBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F83A10", Offset = "0x3F82610", VA = "0x183F83A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2180", Offset = "0x2AE0D80", VA = "0x182AE2180")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OCNOGDHDBAP))]
	public static Task EBDHDHCPNAJ(OOCGABPOHBK CDJHLNAAHGK, MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal struct DJCJAIPOLNB
{
	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0")]
	public static DJCJAIPOLNB JLAKJAPJOGA()
	{
		return default(DJCJAIPOLNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void PHOGHLAAEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void NNBMICFFJJF(MOMCOKAPMLC PHBHEFAPHDL, object EJFGMPEJEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void KECDHBFGDIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal struct BAIOMEALKFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x2AC61A0", Offset = "0x2AC4DA0", VA = "0x182AC61A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5E90", Offset = "0x2AC4A90", VA = "0x182AC5E90")]
	public static Task EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5F30", Offset = "0x2AC4B30", VA = "0x182AC5F30")]
	private void EBDHDHCPNAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal class HALPBDECPOJ : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class HOOOOLJDKPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public HALPBDECPOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private ODEOHNPPJCE <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private GEDJHDMKMOJ <serializeType>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private EJCOGPHMIIO <data>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private EJCOGPHMIIO <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter<EJCOGPHMIIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HOOOOLJDKPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A8D0", Offset = "0x3F794D0", VA = "0x183F7A8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private readonly string OMCOJEIPFBM;

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA800", Offset = "0x2AD9400", VA = "0x182ADA800")]
	public HALPBDECPOJ(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, string OMCOJEIPFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA660", Offset = "0x2AD9260", VA = "0x182ADA660", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HOOOOLJDKPK))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal class FGCIPEMNFIB
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class FPFKGKIMLDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public FEEJMENJLIJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public MOMCOKAPMLC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FPFKGKIMLDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x489CF00", Offset = "0x489BB00", VA = "0x18489CF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class HOKBGJMLPJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HOKBGJMLPJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class AEFOMBJCECP
	{
		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		private sealed class <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public AEFOMBJCECP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x5E218F0", Offset = "0x5E204F0", VA = "0x185E218F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public AALOEEPNEOP handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public HOKBGJMLPJO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public AEFOMBJCECP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x4897990", Offset = "0x4896590", VA = "0x184897990")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task GFHFLIFEECL(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class EDMFOCENIMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private HOKBGJMLPJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private AEFOMBJCECP <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public EDMFOCENIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x489C2C0", Offset = "0x489AEC0", VA = "0x18489C2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class IKAMJMIHKMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private AALOEEPNEOP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private Dictionary<Guid, List<LOHABELNFDM>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private KeyValuePair<Guid, List<LOHABELNFDM>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IKAMJMIHKMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x489FAC0", Offset = "0x489E6C0", VA = "0x18489FAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class MFABEIDHFNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private EPJFONLPCOB <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private AALOEEPNEOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private Dictionary<Guid, List<LOHABELNFDM>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private KeyValuePair<Guid, List<LOHABELNFDM>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MFABEIDHFNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x48A52D0", Offset = "0x48A3ED0", VA = "0x1848A52D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class FHANDLFJBHN
	{
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		private sealed class <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public LOHABELNFDM handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public FHANDLFJBHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x5E1F0F0", Offset = "0x5E1DCF0", VA = "0x185E1F0F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public CCBIIAGKKBF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public List<LOHABELNFDM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FHANDLFJBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x489CD30", Offset = "0x489B930", VA = "0x18489CD30")]
		internal object OOCPHPCALMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x489CBE0", Offset = "0x489B7E0", VA = "0x18489CBE0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task LJMLNNODJOI(LOHABELNFDM handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x489CAF0", Offset = "0x489B6F0", VA = "0x18489CAF0")]
		internal object FGFDNIDPODJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class KAEGMPFOKFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public List<LOHABELNFDM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public CCBIIAGKKBF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private FHANDLFJBHN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private IEnumerable<Task> <handlerTasks>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KAEGMPFOKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x48A2680", Offset = "0x48A1280", VA = "0x1848A2680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class DPLDGBHGKKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DPLDGBHGKKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x489B6A0", Offset = "0x489A2A0", VA = "0x18489B6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class FKHADMDJNNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FKHADMDJNNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x489CE20", Offset = "0x489BA20", VA = "0x18489CE20")]
		internal object JCIHNDINDGA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class DGFHLDINIPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private FKHADMDJNNJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private EPJFONLPCOB <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private List<LOHABELNFDM> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DGFHLDINIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x489AE00", Offset = "0x4899A00", VA = "0x18489AE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class FKODLABGDGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FKODLABGDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x489CE90", Offset = "0x489BA90", VA = "0x18489CE90")]
		internal object IDJGMCAOGCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class GICFOPPJBMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private FKODLABGDGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private FHMBHNPINBI <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private FHMBHNPINBI <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private FHMBHNPINBI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GICFOPPJBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x489D4E0", Offset = "0x489C0E0", VA = "0x18489D4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class JEFJPLMMIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JEFJPLMMIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x48A1500", Offset = "0x48A0100", VA = "0x1848A1500")]
		internal object CIGJJJMKAON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private readonly DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private NHOCFNNGHPA PDJAPHGOJJO;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private OOCGABPOHBK JMLCEDJKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xA14150", Offset = "0xA12D50", VA = "0x180A14150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x836EE0", Offset = "0x835AE0", VA = "0x180836EE0")]
	public FGCIPEMNFIB(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2ACED00", Offset = "0x2ACD900", VA = "0x182ACED00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPFKGKIMLDE))]
	public Task EBDHDHCPNAJ(FEEJMENJLIJ ANPIEEIPNGA, MOMCOKAPMLC LPFGOIILFCI, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x2ACF590", Offset = "0x2ACE190", VA = "0x182ACF590")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDMFOCENIMJ))]
	private Task MDBDAHGPHLI(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x2ACF730", Offset = "0x2ACE330", VA = "0x182ACF730")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKAMJMIHKMJ))]
	private Task NFEOFNICAPL(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x2ACF8D0", Offset = "0x2ACE4D0", VA = "0x182ACF8D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFABEIDHFNA))]
	private Task ODLJCAKAKJF(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2ACEA00", Offset = "0x2ACD600", VA = "0x182ACEA00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KAEGMPFOKFN))]
	private Task BADLLBBHBPG(Guid LHPBOIAGPAE, List<LOHABELNFDM> AGGDAPBJMLG, CCBIIAGKKBF KGEBDJDHLNM, MOMCOKAPMLC PHBHEFAPHDL, CancellationToken FLDJLPKNKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x2ACFC40", Offset = "0x2ACE840", VA = "0x182ACFC40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPLDGBHGKKI))]
	private Task PGNMNKPPBNP(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x2ACF060", Offset = "0x2ACDC60", VA = "0x182ACF060")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DGFHLDINIPD))]
	private Task INKOGJEKMAK(Guid HFCGDHHIMNG, MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x2ACEEC0", Offset = "0x2ACDAC0", VA = "0x182ACEEC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GICFOPPJBMK))]
	private Task HNEFEANOHEL(Guid HFCGDHHIMNG, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x2ACF3F0", Offset = "0x2ACDFF0", VA = "0x182ACF3F0")]
	private void LFPLGDKICKH(Guid HFCGDHHIMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2ACEBD0", Offset = "0x2ACD7D0", VA = "0x182ACEBD0")]
	private void DFKPCMHLPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2ACF220", Offset = "0x2ACDE20", VA = "0x182ACF220")]
	public Guid KHIPIIGIPHJ(FEEJMENJLIJ JCEEBLIDOHD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2ACFA70", Offset = "0x2ACE670", VA = "0x182ACFA70")]
	[CompilerGenerated]
	private object OKHGFMAGDMG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal struct HPDLGGGIPCI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	private readonly DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private readonly Guid DGPMAIKFGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private bool GGKLFMPBGIO;

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE670", Offset = "0x2ADD270", VA = "0x182ADE670")]
	public static HPDLGGGIPCI HMNMIJCBGAE(DNKNJNMAMBL GIOAKJNONKE)
	{
		return default(HPDLGGGIPCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x173D350", Offset = "0x173BF50", VA = "0x18173D350")]
	public void GCNHMDLKOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE270", Offset = "0x2ADCE70", VA = "0x182ADE270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE6D0", Offset = "0x2ADD2D0", VA = "0x182ADE6D0")]
	private HPDLGGGIPCI(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE280", Offset = "0x2ADCE80", VA = "0x182ADE280")]
	private void FNEOFEGLMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE5C0", Offset = "0x2ADD1C0", VA = "0x182ADE5C0")]
	private Func<Guid, bool> GGOOKBJFPAH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal struct GHMJGCHLAMJ
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class OCAPNIKIGKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public AsyncTaskMethodBuilder<HOAOFNBBEKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public GHMJGCHLAMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private AALOEEPNEOP <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private HOAOFNBBEKI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter<HOAOFNBBEKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public OCAPNIKIGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x48A9630", Offset = "0x48A8230", VA = "0x1848A9630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class CMCDKECJNFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public AsyncTaskMethodBuilder<HOAOFNBBEKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public GHMJGCHLAMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private HOAOFNBBEKI <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private HOAOFNBBEKI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private TaskAwaiter<HOAOFNBBEKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CMCDKECJNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x489A5A0", Offset = "0x48991A0", VA = "0x18489A5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class CKIHIOIOIKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CKIHIOIOIKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x1267E30", Offset = "0x1266A30", VA = "0x181267E30")]
		internal bool LNEIIDGCIHH(MPOOILGCDLJ sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class GJFMNLKEGFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public AsyncTaskMethodBuilder<HOAOFNBBEKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public HBPPPIGEKFO callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public EFENBEKLEHO superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private CKIHIOIOIKD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private IEMLKNOFDEG <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private MPOOILGCDLJ <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private EFENBEKLEHO <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private EFENBEKLEHO <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private AALOEEPNEOP <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private IEMLKNOFDEG <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private AALOEEPNEOP <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private CAIGCNABMEN <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private CAIGCNABMEN <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private AALOEEPNEOP <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private BNNPCINDEGK <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private BNNPCINDEGK <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TaskAwaiter<IEMLKNOFDEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter<CAIGCNABMEN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter<BNNPCINDEGK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GJFMNLKEGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x489DBB0", Offset = "0x489C7B0", VA = "0x18489DBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private KFDAFKKLOKJ BBMCDOFLCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private AALOEEPNEOP IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private long HAMIEGOKEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private long BPODGJMCBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private long PJBAEAJLHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private string APOLELLKJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private EFENBEKLEHO MCALOEENHGB;

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2AD56C0", Offset = "0x2AD42C0", VA = "0x182AD56C0")]
	public static Task<HOAOFNBBEKI> AHEFPBBKFFG(IFNNJAAOEDN FNIFBLHBOOE, LCMHJBMHMJN PAJPFFIMEFB, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5900", Offset = "0x2AD4500", VA = "0x182AD5900")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OCAPNIKIGKA))]
	private Task<HOAOFNBBEKI> EBDHDHCPNAJ(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5AC0", Offset = "0x2AD46C0", VA = "0x182AD5AC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CMCDKECJNFC))]
	private Task<HOAOFNBBEKI> PKKFKJPCEJM(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5C80", Offset = "0x2AD4880", VA = "0x182AD5C80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GJFMNLKEGFN))]
	private static Task<HOAOFNBBEKI> PKKFKJPCEJM(HBPPPIGEKFO FGOMHOJPKFO, long HAMIEGOKEJC, long BPODGJMCBKI, long PJBAEAJLHMO, string APOLELLKJLH, EFENBEKLEHO MCALOEENHGB, CancellationToken GFFFFCALMCA, AALOEEPNEOP LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5A90", Offset = "0x2AD4690", VA = "0x182AD5A90")]
	private void LPAPCMDMINF(IEMLKNOFDEG KBEKHLAONIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal struct CPIAHEMPDLH
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class BMNCHDCGPHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public IFNNJAAOEDN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BMNCHDCGPHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x325DBA0", Offset = "0x325C7A0", VA = "0x18325DBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class PFHEKBMPLGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public CPIAHEMPDLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public PFHEKBMPLGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x3275390", Offset = "0x3273F90", VA = "0x183275390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private ByteString EPBBCHCFEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private bool KFPBILIFIBE;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x2AC92C0", Offset = "0x2AC7EC0", VA = "0x182AC92C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private bool CMJEGCCGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8E40", Offset = "0x2AC7A40", VA = "0x182AC8E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private bool GHKKGJHEJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9230", Offset = "0x2AC7E30", VA = "0x182AC9230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9050", Offset = "0x2AC7C50", VA = "0x182AC9050")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMNCHDCGPHA))]
	public static Task EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, DNKNJNMAMBL GIOAKJNONKE, bool KFPBILIFIBE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8EC0", Offset = "0x2AC7AC0", VA = "0x182AC8EC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PFHEKBMPLGI))]
	private Task EBDHDHCPNAJ(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal static class IBJOFFOKACF
{
	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEDD0", Offset = "0x2ADD9D0", VA = "0x182ADEDD0")]
	public static void PCHJIMFINCP(this MHBAMGOJMJJ EMBLDIHCMDD, MHKEFJDKLJN IKINGJFLMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2ADECF0", Offset = "0x2ADD8F0", VA = "0x182ADECF0")]
	public static void ONPCOIPELPC(this MHKEFJDKLJN BIJBNMHAAEB, [Optional] string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal struct KDOBEABEJCC
{
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class AMCFCMFCJDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public KDOBEABEJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private AALOEEPNEOP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public AMCFCMFCJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x3F72AB0", Offset = "0x3F716B0", VA = "0x183F72AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private const int IONIJIHONCB = 20;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private const float ODNMBOGAIGP = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private AALOEEPNEOP IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private float HIGFILGGHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private float NOIPBOGFHJO;

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4100", Offset = "0x2AE2D00", VA = "0x182AE4100")]
	public static Task OKJLIDIOPDP(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3B60", Offset = "0x2AE2760", VA = "0x182AE3B60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMCFCMFCJDF))]
	public Task EBDHDHCPNAJ(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3E90", Offset = "0x2AE2A90", VA = "0x182AE3E90")]
	private static void LCNEGKJELNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3CB0", Offset = "0x2AE28B0", VA = "0x182AE3CB0")]
	private void GDANKPGCFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4040", Offset = "0x2AE2C40", VA = "0x182AE4040")]
	private static float NDBEBOAFCNO(HBPPPIGEKFO FGOMHOJPKFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3B40", Offset = "0x2AE2740", VA = "0x182AE3B40")]
	private static float BDPLCDDDLOM()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class DNKNJNMAMBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class DOBNPFEKFGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private AALOEEPNEOP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private FHMBHNPINBI <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private DAMKOIBGCAN <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter<DAMKOIBGCAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DOBNPFEKFGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x489B340", Offset = "0x4899F40", VA = "0x18489B340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct FJHJBJJDJBO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private sealed class EBDNOJNGGFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public EBDNOJNGGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x489B950", Offset = "0x489A550", VA = "0x18489B950")]
		internal FHMBHNPINBI LEODIPOBJPJ(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class CAPHFHKELHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AsyncTaskMethodBuilder<DAMKOIBGCAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private EBDNOJNGGFI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private FMEHMMJPLED <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private DAMKOIBGCAN <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private FMEHMMJPLED <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private DAMKOIBGCAN <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private string <errorMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private ByteString <actualOperationId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private string <errorMessage>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter<DAMKOIBGCAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CAPHFHKELHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x4898F70", Offset = "0x4897B70", VA = "0x184898F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class CGAABHDLBCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CGAABHDLBCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x489A410", Offset = "0x4899010", VA = "0x18489A410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class KMDLHFGAEGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KMDLHFGAEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x48A3F20", Offset = "0x48A2B20", VA = "0x1848A3F20")]
		internal object DGMFOAMKODM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x48A3F80", Offset = "0x48A2B80", VA = "0x1848A3F80")]
		internal bool JLBECBGGGHD(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class ACDAKAILNCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ACDAKAILNCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x48972D0", Offset = "0x4895ED0", VA = "0x1848972D0")]
		internal object KFDAPPMDKLC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class KPMMMFPAAFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KPMMMFPAAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x48A4A50", Offset = "0x48A3650", VA = "0x1848A4A50")]
		internal object KFKIOBBMGPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class BMJJEMONBFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BMJJEMONBFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x4898F00", Offset = "0x4897B00", VA = "0x184898F00")]
		internal object NNBHOGNNNAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private sealed class EEHNALOIMMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public EEHNALOIMMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x489C730", Offset = "0x489B330", VA = "0x18489C730")]
		internal object GFMPDMHHECN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class PNCBCFLBIPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public PNCBCFLBIPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x48AA520", Offset = "0x48A9120", VA = "0x1848AA520")]
		internal object GFMPDMHHECN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private static readonly Guid DJJMHBANOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public readonly OOCGABPOHBK JMLCEDJKPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly GOMGBFEPMOD BFLJPKHGFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private readonly GNOLCLOPLMD EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private readonly CAJCLGONHEA NFAOIEDIDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private bool LAOELOOGMGA;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB590", Offset = "0x2ACA190", VA = "0x182ACB590")]
	public DNKNJNMAMBL(OOCGABPOHBK CDJHLNAAHGK, GOMGBFEPMOD BFLJPKHGFDA, GNOLCLOPLMD EKLPJDMGHDM, CAJCLGONHEA NFAOIEDIDLK, AALOEEPNEOP LEBCJIHOHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA190", Offset = "0x2AC8D90", VA = "0x182ACA190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA190", Offset = "0x2AC8D90", VA = "0x182ACA190")]
	public void GHEFBDNHOFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA5B0", Offset = "0x2AC91B0", VA = "0x182ACA5B0")]
	public void GFHHOGMKBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB330", Offset = "0x2AC9F30", VA = "0x182ACB330")]
	public void OIJBFLBKEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA930", Offset = "0x2AC9530", VA = "0x182ACA930")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DOBNPFEKFGA))]
	internal Task<FHMBHNPINBI> HOMHGOLOBKD(AALOEEPNEOP LEBCJIHOHHE, FHMBHNPINBI IFPNDMLIDFN, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2AC41D0", Offset = "0x2AC2DD0", VA = "0x182AC41D0")]
	private static byte[] FFJHDGFFCLL<T>(T DKIECHCHJFL) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x39A8960", Offset = "0x39A7560", VA = "0x1839A8960")]
	private static T KLHCJOAGOJC<T>(MessageParser<T> IBLLODJKIEB, byte[] DKIECHCHJFL, T FKDPHGEANKE) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9F50", Offset = "0x2AC8B50", VA = "0x182AC9F50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CAPHFHKELHD))]
	private Task<DAMKOIBGCAN> CBLDPLEGMFH(FHMBHNPINBI IFPNDMLIDFN, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x39A8170", Offset = "0x39A6D70", VA = "0x1839A8170")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HCPFLFMCDKD))]
	internal Task<T> AAMJCEBHNLK<T>(CancellationToken KHEICKPBIBD, Func<CancellationToken, Task<T>> BGOAFADLINP, int HKJHFGACIPJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9CC0", Offset = "0x2AC88C0", VA = "0x182AC9CC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGAABHDLBCC))]
	internal Task AAMJCEBHNLK(CancellationToken KHEICKPBIBD, Func<CancellationToken, Task> BGOAFADLINP, int HKJHFGACIPJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB490", Offset = "0x2ACA090", VA = "0x182ACB490")]
	public FHMBHNPINBI PNMFOCFOMAB(FMEHMMJPLED NFBFKALKFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA340", Offset = "0x2AC8F40", VA = "0x182ACA340")]
	public CHIPOCIBCNK EEEFAHLJBNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA120", Offset = "0x2AC8D20", VA = "0x182ACA120")]
	public GKJHOLDCGPO DGPOEEDKGHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9E50", Offset = "0x2AC8A50", VA = "0x182AC9E50")]
	public ODEOHNPPJCE AIPAJGCCMHD([Optional] HDDCAHBLLEN? ODPKAHOAPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA0F0", Offset = "0x2AC8CF0", VA = "0x182ACA0F0")]
	public void CLIKLGEOLOI(Func<Guid, bool> GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB150", Offset = "0x2AC9D50", VA = "0x182ACB150")]
	public void MJACCIELGLP(Func<Guid, bool> MDEPBBGHKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2ACAAF0", Offset = "0x2AC96F0", VA = "0x182ACAAF0")]
	public void IHBJGKALJNH(Func<Guid, bool> GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA710", Offset = "0x2AC9310", VA = "0x182ACA710")]
	public Guid HMNMIJCBGAE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA410", Offset = "0x2AC9010", VA = "0x182ACA410")]
	public void FNEOFEGLMFJ(Guid DGPMAIKFGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2ACAFB0", Offset = "0x2AC9BB0", VA = "0x182ACAFB0")]
	public void JLIDAKAHHGF(FHMBHNPINBI CJNGOOMCDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2ACAE20", Offset = "0x2AC9A20", VA = "0x182ACAE20")]
	public void JGIMFEIAGIB(string AENODGLJKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x2ACAC90", Offset = "0x2AC9890", VA = "0x182ACAC90")]
	public void JGIMFEIAGIB(Func<string> ANINAIMKMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x39A8570", Offset = "0x39A7170", VA = "0x1839A8570")]
	private T FPDLJJIJEGK<T>(T ECNGHFJBIJL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB100", Offset = "0x2AC9D00", VA = "0x182ACB100")]
	public void JONFDFHMGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x39A8650", Offset = "0x39A7250", VA = "0x1839A8650")]
	[CompilerGenerated]
	internal static string GNMOIDNMBHF<T>(byte[] ENEAOCDMOME, int NHAAHCAPBBL, ref FJHJBJJDJBO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal struct HJFCIFBFFAN
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class BNJECNBBNDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public IFNNJAAOEDN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BNJECNBBNDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x3F74740", Offset = "0x3F73340", VA = "0x183F74740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class OLJCAIFMKKA
	{
		[Cpp2IlInjected.Token(Token = "0x2000129")]
		private sealed class <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D7")]
			public AALOEEPNEOP timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			public OLJCAIFMKKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			private AALOEEPNEOP <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x5E21A50", Offset = "0x5E20650", VA = "0x185E21A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public OLJCAIFMKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x3F84260", Offset = "0x3F82E60", VA = "0x183F84260")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task GLEEEHPILGD(AALOEEPNEOP timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class NBDKEECBGFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public HJFCIFBFFAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private OLJCAIFMKKA <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private FHMBHNPINBI <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NBDKEECBGFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x3F82D10", Offset = "0x3F81910", VA = "0x183F82D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class APLOCNLEJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public HBHNCFJCIKF version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public APLOCNLEJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x3F73200", Offset = "0x3F71E00", VA = "0x183F73200")]
		internal object LFDGDHKDBPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x3F732E0", Offset = "0x3F71EE0", VA = "0x183F732E0")]
		internal object PANLPDDAKNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private bool AHCBJBINNOD;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private static readonly ByteString PNEAAGKPJOA;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC910", Offset = "0x2ADB510", VA = "0x182ADC910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC890", Offset = "0x2ADB490", VA = "0x182ADC890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x2ADBD90", Offset = "0x2ADA990", VA = "0x182ADBD90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BNJECNBBNDK))]
	public static Task EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA, bool AHCBJBINNOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x2ADBF70", Offset = "0x2ADAB70", VA = "0x182ADBF70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NBDKEECBGFM))]
	private Task EBDHDHCPNAJ(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC0F0", Offset = "0x2ADACF0", VA = "0x182ADC0F0")]
	private void HBLHPLJNDNE([NotNull] BNIDNMGAHLD BBBFCKGLENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC830", Offset = "0x2ADB430", VA = "0x182ADC830")]
	private bool IAMNLMMFKKN(HBHNCFJCIKF FPBNFBFIPHI, BNIDNMGAHLD BBBFCKGLENJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal abstract class MMDFDPPJLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public readonly OOCGABPOHBK JMLCEDJKPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly DNKNJNMAMBL LJLPJFLHKIG;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x326B0E0", Offset = "0x3269CE0", VA = "0x18326B0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x326B050", Offset = "0x3269C50", VA = "0x18326B050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x326B130", Offset = "0x3269D30", VA = "0x18326B130")]
	protected MMDFDPPJLGH(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x326B010", Offset = "0x3269C10", VA = "0x18326B010")]
	protected void JGIMFEIAGIB(string AENODGLJKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x326B030", Offset = "0x3269C30", VA = "0x18326B030")]
	public void JGIMFEIAGIB(Func<string> ANINAIMKMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal class GKJHOLDCGPO : MMDFDPPJLGH, IJBBBDBCHDL
{
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	public delegate Task<FEEJMENJLIJ> EBIHPHKNPFJ(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO HDMIPHANIGM, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class KOBADOPLEPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private HPDLGGGIPCI <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private FHMBHNPINBI <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private FHMBHNPINBI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KOBADOPLEPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x48A4090", Offset = "0x48A2C90", VA = "0x1848A4090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class ALIADCLFAPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private AALOEEPNEOP <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private FHMBHNPINBI <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private FHMBHNPINBI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ALIADCLFAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x4897AE0", Offset = "0x48966E0", VA = "0x184897AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class PLHFNMLBOOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private AALOEEPNEOP <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public PLHFNMLBOOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F84EF0", Offset = "0x3F83AF0", VA = "0x183F84EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class KDPLHADDPBM
	{
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			public AsyncTaskMethodBuilder<HOAOFNBBEKI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			public KDPLHADDPBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			private HOAOFNBBEKI <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private HOAOFNBBEKI <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			private TaskAwaiter<FEEJMENJLIJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			private TaskAwaiter<HOAOFNBBEKI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x5E20610", Offset = "0x5E1F210", VA = "0x185E20610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000134")]
		private sealed class <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000524")]
			public AsyncTaskMethodBuilder<MOMCOKAPMLC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public KDPLHADDPBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			private MOMCOKAPMLC <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			private MOMCOKAPMLC <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			private TaskAwaiter<FEEJMENJLIJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			private TaskAwaiter<MOMCOKAPMLC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x5E20D50", Offset = "0x5E1F950", VA = "0x185E20D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000135")]
		private sealed class <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public KDPLHADDPBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			private bool <isReloadingSceneForObjectModel>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private bool <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private KBOEHLEJIFO <timedYielder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter<FEEJMENJLIJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x5E1F240", Offset = "0x5E1DE40", VA = "0x185E1F240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public JJMPNGLGHEG preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public JJMPNGLGHEG downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public HOAOFNBBEKI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public JJMPNGLGHEG postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public MOMCOKAPMLC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public MCNPFMNGCKP.DIKEJOLIKNG <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KDPLHADDPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x48A2F70", Offset = "0x48A1B70", VA = "0x1848A2F70")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<HOAOFNBBEKI> OLFNNBMAJBB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x48A2E00", Offset = "0x48A1A00", VA = "0x1848A2E00")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<MOMCOKAPMLC> MPFJOIFDDBL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x48A2C70", Offset = "0x48A1870", VA = "0x1848A2C70")]
		internal void AFJKHOJOJAB(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x48A2CB0", Offset = "0x48A18B0", VA = "0x1848A2CB0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task LNEKNOECPKF(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private sealed class KKLKNCNGHPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private KDPLHADDPBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private HOAOFNBBEKI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private MOMCOKAPMLC <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private TaskAwaiter<HOAOFNBBEKI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter<MOMCOKAPMLC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KKLKNCNGHPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x48A3210", Offset = "0x48A1E10", VA = "0x1848A3210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class HKHHGLJAHFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HKHHGLJAHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x489EDE0", Offset = "0x489D9E0", VA = "0x18489EDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class KOJHPIJFHMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private AALOEEPNEOP <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KOJHPIJFHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x48A4480", Offset = "0x48A3080", VA = "0x1848A4480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class LNNNDJNBBAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private AALOEEPNEOP <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LNNNDJNBBAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x3F7FF00", Offset = "0x3F7EB00", VA = "0x183F7FF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class JPCBMGCNAPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private AALOEEPNEOP <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JPCBMGCNAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x48A19C0", Offset = "0x48A05C0", VA = "0x1848A19C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class PIHBPJAJPAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public FEEJMENJLIJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public MOMCOKAPMLC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private FEEJMENJLIJ <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private FEEJMENJLIJ <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public PIHBPJAJPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x3F84CD0", Offset = "0x3F838D0", VA = "0x183F84CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class MNOCNAOEPAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public EBIHPHKNPFJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MNOCNAOEPAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class LFONGKNJCPM
	{
		[Cpp2IlInjected.Token(Token = "0x200013F")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public LFONGKNJCPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			private FEEJMENJLIJ <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			private FEEJMENJLIJ <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			private TaskAwaiter<FEEJMENJLIJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x5E21330", Offset = "0x5E1FF30", VA = "0x185E21330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public FEEJMENJLIJ originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public MNOCNAOEPAN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LFONGKNJCPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F840", Offset = "0x3F7E440", VA = "0x183F7F840")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<FEEJMENJLIJ> LIKNGLIGDOM(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class IJMNEIPANCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public EBIHPHKNPFJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private MNOCNAOEPAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private LFONGKNJCPM <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private FEEJMENJLIJ <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IJMNEIPANCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x489F4D0", Offset = "0x489E0D0", VA = "0x18489F4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class JGCCMPKDMFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private FEEJMENJLIJ <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private IEnumerator<FEEJMENJLIJ> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private FEEJMENJLIJ <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JGCCMPKDMFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x48A1570", Offset = "0x48A0170", VA = "0x1848A1570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class GIAHGDCIJFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GIAHGDCIJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x489D300", Offset = "0x489BF00", VA = "0x18489D300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class ELMNNEENDDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ELMNNEENDDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x489C9B0", Offset = "0x489B5B0", VA = "0x18489C9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class NNPDCLHELGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public IEMLKNOFDEG roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NNPDCLHELGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F83700", Offset = "0x3F82300", VA = "0x183F83700")]
		internal object MCNFNPAMGDJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private readonly PKHKKGNCOIB PHDNNMDDLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private readonly PKHKKGNCOIB JLNPINILEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private readonly KFDAFKKLOKJ BBMCDOFLCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private readonly FGCIPEMNFIB PDJAPHGOJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	private readonly MMKBCFLLNID AMMLOCNKDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private readonly EIBOJBKNGCC KBDOFCNIKNN;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float NCJOEPAECEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6F10", Offset = "0x2AD5B10", VA = "0x182AD6F10", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private IFNNJAAOEDN MIDAOOLAHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x2AC65E0", Offset = "0x2AC51E0", VA = "0x182AC65E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event BGAINELODGO MFBLCLAEJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6940", Offset = "0x2AD5540", VA = "0x182AD6940", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6F30", Offset = "0x2AD5B30", VA = "0x182AD6F30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD80D0", Offset = "0x2AD6CD0", VA = "0x182AD80D0")]
	public GKJHOLDCGPO(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5F10", Offset = "0x2AD4B10", VA = "0x182AD5F10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KOBADOPLEPC))]
	public Task AFBDNMFFNNO(LCMHJBMHMJN PAJPFFIMEFB, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7450", Offset = "0x2AD6050", VA = "0x182AD7450")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ALIADCLFAPI))]
	private Task<FHMBHNPINBI> MNKHHEFFBHJ(LCMHJBMHMJN PAJPFFIMEFB, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7970", Offset = "0x2AD6570", VA = "0x182AD7970")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PLHFNMLBOOG))]
	private Task OGNADIILDPL(LCMHJBMHMJN PAJPFFIMEFB, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x2AD60B0", Offset = "0x2AD4CB0", VA = "0x182AD60B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KKLKNCNGHPL))]
	private Task ALNDMCJPOAB(LCMHJBMHMJN PAJPFFIMEFB, AALOEEPNEOP LEBCJIHOHHE, CancellationToken ABPHAFIBLFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD69E0", Offset = "0x2AD55E0", VA = "0x182AD69E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HKHHGLJAHFP))]
	private Task HBEDCFJFEGH(AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7D40", Offset = "0x2AD6940", VA = "0x182AD7D40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KOJHPIJFHMB))]
	private Task PAMMEKNKFJI(MOMCOKAPMLC PHBHEFAPHDL, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7B30", Offset = "0x2AD6730", VA = "0x182AD7B30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNNNDJNBBAH))]
	private Task<FEEJMENJLIJ> OJMFFDBOLEH(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6D00", Offset = "0x2AD5900", VA = "0x182AD6D00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JPCBMGCNAPF))]
	private Task<FEEJMENJLIJ> JOHLFMHMGPF(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6250", Offset = "0x2AD4E50", VA = "0x182AD6250")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PIHBPJAJPAN))]
	private Task<FEEJMENJLIJ> CFNBNMAGJAI(FEEJMENJLIJ ANPIEEIPNGA, MOMCOKAPMLC LPFGOIILFCI, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA, bool AEACNEFJOGB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2AD66A0", Offset = "0x2AD52A0", VA = "0x182AD66A0")]
	private bool EOBOKBAFAHA(MOMCOKAPMLC BDIHDHOFGCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6470", Offset = "0x2AD5070", VA = "0x182AD6470")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IJMNEIPANCG))]
	protected Task<FEEJMENJLIJ> CPHJEKLBCIA(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA, EBIHPHKNPFJ KOHPCLOMMME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7290", Offset = "0x2AD5E90", VA = "0x182AD7290")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGCCMPKDMFC))]
	private Task LHDPOJEDCCH(MOMCOKAPMLC PHBHEFAPHDL, JJMPNGLGHEG OOKFEKMLPEH, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6990", Offset = "0x2AD5590", VA = "0x182AD6990")]
	private void GODJEHFDFLK(FEEJMENJLIJ JCEEBLIDOHD, JJMPNGLGHEG OOKFEKMLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6B50", Offset = "0x2AD5750", VA = "0x182AD6B50")]
	private void HIMGBBKEHLL(FEEJMENJLIJ PNPIHEBMMAF, out FEEJMENJLIJ NIJDJEIKOHG, out FEEJMENJLIJ PGPPIMDDDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7F00", Offset = "0x2AD6B00", VA = "0x182AD7F00")]
	private Task<HOAOFNBBEKI> PKKFKJPCEJM(LCMHJBMHMJN PAJPFFIMEFB, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6F50", Offset = "0x2AD5B50", VA = "0x182AD6F50")]
	private Task<MOMCOKAPMLC> LBGGPNKPEGI(HOAOFNBBEKI PHBHEFAPHDL, MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7610", Offset = "0x2AD6210", VA = "0x182AD7610")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GIAHGDCIJFI))]
	private Task NKKGJGLDCND(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA, bool AHCBJBINNOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6B90", Offset = "0x2AD5790", VA = "0x182AD6B90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ELMNNEENDDE))]
	private Task INICKHECGBO(MOMCOKAPMLC PHBHEFAPHDL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6960", Offset = "0x2AD5560", VA = "0x182AD6960")]
	private Task GHJJBNNJIJH(MOMCOKAPMLC PHBHEFAPHDL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6F90", Offset = "0x2AD5B90", VA = "0x182AD6F90")]
	private Task LFPFADFFFOD(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD77D0", Offset = "0x2AD63D0", VA = "0x182AD77D0")]
	private Task NOHMJANJBLO(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7B10", Offset = "0x2AD6710", VA = "0x182AD7B10")]
	private Task OIJPJEJGECB(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6460", Offset = "0x2AD5060", VA = "0x182AD6460")]
	private static Task CMPFMOKIHJM(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x2AD67A0", Offset = "0x2AD53A0", VA = "0x182AD67A0")]
	private Task FLNALACEMCA(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7F40", Offset = "0x2AD6B40", VA = "0x182AD7F40")]
	private Task PMDGJLMKDEO(MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5EB0", Offset = "0x2AD4AB0", VA = "0x182AD5EB0")]
	private void ADDCJIACHFB(LCMHJBMHMJN PAJPFFIMEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7120", Offset = "0x2AD5D20", VA = "0x182AD7120")]
	private static void LHBDBMCPEID(IEMLKNOFDEG KBEKHLAONIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
internal abstract class OOCGABPOHBK : IJBBBDBCHDL
{
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	public delegate Task CCKHPCNCINE(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class GOOPIPHKBGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public AALOEEPNEOP operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public OOCGABPOHBK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GOOPIPHKBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B510", Offset = "0x5E1A110", VA = "0x185E1B510")]
		internal Task KFBCMDIONEB(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class NCGFODONIBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public GOOPIPHKBGO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NCGFODONIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EB70", Offset = "0x5E1D770", VA = "0x185E1EB70")]
		internal object LIAABDJAIFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EAB0", Offset = "0x5E1D6B0", VA = "0x185E1EAB0")]
		internal object DEOHCKBFELK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class LDKEPLLJLBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public Func<OOCGABPOHBK, AALOEEPNEOP, DNKNJNMAMBL> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public OOCGABPOHBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private GOOPIPHKBGO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private DNKNJNMAMBL <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private FHMBHNPINBI <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private NCGFODONIBG <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private TaskAwaiter<FHMBHNPINBI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LDKEPLLJLBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D8D0", Offset = "0x5E1C4D0", VA = "0x185E1D8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class FPEEOOMFCLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public OOCGABPOHBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private CCKHPCNCINE <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FPEEOOMFCLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AA40", Offset = "0x5E19640", VA = "0x185E1AA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	public readonly Guid ECPEBOBBOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	public readonly ByteString EFOLDDOJBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005B4")]
	public readonly FFLEKJBGAJJ GNCPOEKCNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005B5")]
	protected readonly string ENKPPJMNOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005B6")]
	private readonly IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	private readonly bool NKALOKKDEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	private readonly Queue<CCKHPCNCINE> CKEJOMFOFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private readonly JJMPNGLGHEG KHIMDJKCMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private readonly NBGKOOKNBGP KAINKNJPFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private bool KELEEIEIJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	public FEEJMENJLIJ MEKBPOFNJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	public FEEJMENJLIJ CCPIJDABOGH;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public IFNNJAAOEDN MIDAOOLAHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x83EB00", Offset = "0x83D700", VA = "0x18083EB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x3272830", Offset = "0x3271430", VA = "0x183272830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public KDHGMPHKPAM MAEKOJNKJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x3271FB0", Offset = "0x3270BB0", VA = "0x183271FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x32725A0", Offset = "0x32711A0", VA = "0x1832725A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public float NCJOEPAECEI
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x3272580", Offset = "0x3271180", VA = "0x183272580", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event BGAINELODGO MFBLCLAEJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x3272310", Offset = "0x3270F10", VA = "0x183272310", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x3272620", Offset = "0x3271220", VA = "0x183272620", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x3272950", Offset = "0x3271550", VA = "0x183272950")]
	protected OOCGABPOHBK(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, string GLKMDMPJGOE, NBGKOOKNBGP KAINKNJPFIL, bool NKALOKKDEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x3272880", Offset = "0x3271480", VA = "0x183272880", Slot = "7")]
	protected virtual string OGMLKJNLLDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x32727D0", Offset = "0x32713D0", VA = "0x1832727D0")]
	public void NHPPAEELKCK(CCKHPCNCINE GALABLGPLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x3271F90", Offset = "0x3270B90", VA = "0x183271F90")]
	protected void BCPEPPDCJKH(float CJLBHCOPODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x3272000", Offset = "0x3270C00", VA = "0x183272000")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LDKEPLLJLBI))]
	public Task EBDHDHCPNAJ(CancellationToken GFFFFCALMCA, AALOEEPNEOP LEBCJIHOHHE, [Optional] Func<OOCGABPOHBK, AALOEEPNEOP, DNKNJNMAMBL> BGBLFFHKMNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x3272640", Offset = "0x3271240", VA = "0x183272640")]
	private void MMAADBGCIOJ(bool GGKLFMPBGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x32721A0", Offset = "0x3270DA0", VA = "0x1832721A0")]
	private void EJJLPNLDKJF(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x3272410", Offset = "0x3271010", VA = "0x183272410")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPEEOOMFCLF))]
	private Task KIPAPEBLLFA(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x32728C0", Offset = "0x32714C0", VA = "0x1832728C0")]
	public FHMBHNPINBI PNMFOCFOMAB(FMEHMMJPLED NFBFKALKFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x3272330", Offset = "0x3270F30", VA = "0x183272330")]
	[CompilerGenerated]
	private Task INKIGFIEKNB(CancellationToken NFOHJNABMAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal abstract class HALIFADCDEK : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class ODGPPHCBEIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public HALIFADCDEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public JKKCGILCDLC playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ODGPPHCBEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x3F84220", Offset = "0x3F82E20", VA = "0x183F84220")]
		internal Task JDIGKAGBKKG(AALOEEPNEOP postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x3F841A0", Offset = "0x3F82DA0", VA = "0x183F841A0")]
		internal object DFADCLAMOEJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class ADKLKAGGMBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public HALIFADCDEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private ODGPPHCBEIG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private FJHFJBECMEA <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ADKLKAGGMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x3F72330", Offset = "0x3F70F30", VA = "0x183F72330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class FKKENGMBJHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public JKKCGILCDLC playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public AALOEEPNEOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public HALIFADCDEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private AALOEEPNEOP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private AALOEEPNEOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FKKENGMBJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x3F786A0", Offset = "0x3F772A0", VA = "0x183F786A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA610", Offset = "0x2AD9210", VA = "0x182ADA610")]
	public HALIFADCDEK(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, string GLKMDMPJGOE, NBGKOOKNBGP KAINKNJPFIL, bool NKALOKKDEMD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA2D0", Offset = "0x2AD8ED0", VA = "0x182ADA2D0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ADKLKAGGMBI))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task FKNGBCPGLCB(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA470", Offset = "0x2AD9070", VA = "0x182ADA470")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FKKENGMBJHN))]
	private Task FGELCBKCCBC(IDisposable EMPFBCPNLOM, JKKCGILCDLC DAAJGDLADDK, AALOEEPNEOP IDIJCJCNEPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
public readonly struct EJCOGPHMIIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	public readonly BNIDNMGAHLD? DGLPPFDBOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	public readonly HMMFOJPJNIB GNMDELMPCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	public readonly string? ANPLPHIDDDD;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public IReadOnlyCollection<string> AKNGEHCHFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2ACC000", Offset = "0x2ACAC00", VA = "0x182ACC000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public IReadOnlyDictionary<long, int> BFHLGIBMCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBFE0", Offset = "0x2ACABE0", VA = "0x182ACBFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x2ACC020", Offset = "0x2ACAC20", VA = "0x182ACC020")]
	public EJCOGPHMIIO(BNIDNMGAHLD? CMMCIHFHBLL, HMMFOJPJNIB BAKFLNODNMF, string? OPOLKMBAJBK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct DAKNPDIODMG
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class DAHIOEPMHEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private OOCGABPOHBK <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private IFNNJAAOEDN <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private MCGDFABKIDE.CJJHBHDMDGF <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DAHIOEPMHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x325E550", Offset = "0x325D150", VA = "0x18325E550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class ICBGILBPKLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private OFOJCNIGMKF.DIFMDKNFLDE <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ICBGILBPKLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x3260D60", Offset = "0x325F960", VA = "0x183260D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9310", Offset = "0x2AC7F10", VA = "0x182AC9310")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DAHIOEPMHEI))]
	public static Task EBDHDHCPNAJ(DNKNJNMAMBL GIOAKJNONKE, MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC95B0", Offset = "0x2AC81B0", VA = "0x182AC95B0")]
	private static Task<FHMBHNPINBI> HOPFINEJIFM(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x2AC94B0", Offset = "0x2AC80B0", VA = "0x182AC94B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ICBGILBPKLB))]
	private static Task HDKKLIHOIED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal class ALJGLPODJGB : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class JLDHJELDELH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public ALJGLPODJGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private ObscuredInt <localPlayerAccountId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private CHIPOCIBCNK <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private EJCOGPHMIIO <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private AALOEEPNEOP <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private AALOEEPNEOP <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private NNENOOPKHPC <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private LPCDCAILFOA <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private TaskAwaiter<LPCDCAILFOA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JLDHJELDELH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x3261D10", Offset = "0x3260910", VA = "0x183261D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private readonly int GHGOMENDEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private readonly HCKACEFMPCF IPKBJACGFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	public readonly long DAGKDGGNPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	public readonly long LIHCFOABGDD;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public LPCDCAILFOA FKHLJHDJBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x83E310", Offset = "0x83CF10", VA = "0x18083E310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x89B000", Offset = "0x899C00", VA = "0x18089B000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4F30", Offset = "0x2AC3B30", VA = "0x182AC4F30")]
	public ALJGLPODJGB(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, int GHGOMENDEDC, HCKACEFMPCF IPKBJACGFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4D90", Offset = "0x2AC3990", VA = "0x182AC4D90", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JLDHJELDELH))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct MMKBCFLLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private sealed class CKHECKBOOCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public FEEJMENJLIJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public MOMCOKAPMLC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public MMKBCFLLNID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private AALOEEPNEOP <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private FEEJMENJLIJ <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CKHECKBOOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x5E19280", Offset = "0x5E17E80", VA = "0x185E19280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class EEIEBBKOHCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public FEEJMENJLIJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public MMKBCFLLNID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private FHMBHNPINBI <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private FHMBHNPINBI <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private FEEJMENJLIJ <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private FHMBHNPINBI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public EEIEBBKOHCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x5E19B50", Offset = "0x5E18750", VA = "0x185E19B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private readonly DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private readonly KFDAFKKLOKJ BBMCDOFLCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private readonly FGCIPEMNFIB PDJAPHGOJJO;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private OOCGABPOHBK JMLCEDJKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xB91ED0", Offset = "0xB90AD0", VA = "0x180B91ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x326B5B0", Offset = "0x326A1B0", VA = "0x18326B5B0")]
	public MMKBCFLLNID(DNKNJNMAMBL GIOAKJNONKE, KFDAFKKLOKJ BBMCDOFLCKN, FGCIPEMNFIB PDJAPHGOJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x326B3B0", Offset = "0x3269FB0", VA = "0x18326B3B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKHECKBOOCL))]
	public Task<FEEJMENJLIJ> ODOLNCDCMAM(FEEJMENJLIJ NLMOCMPGOJG, MOMCOKAPMLC LPFGOIILFCI, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA, bool AEACNEFJOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x326B1E0", Offset = "0x3269DE0", VA = "0x18326B1E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EEIEBBKOHCO))]
	private Task<FEEJMENJLIJ> JPLBJBAIGLB(AALOEEPNEOP LEBCJIHOHHE, FEEJMENJLIJ LLBKKANHBEL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x326B190", Offset = "0x3269D90", VA = "0x18326B190")]
	private bool IDDEHCKMEOE(FEEJMENJLIJ PFCONCOBCPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x326B1C0", Offset = "0x3269DC0", VA = "0x18326B1C0")]
	private void JGIMFEIAGIB(string BAMBEECFNAE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct LEMBBABKCMD
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private sealed class JGICAPHJDJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private OOCGABPOHBK <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private FEEJMENJLIJ <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private IFNNJAAOEDN <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private HBPPPIGEKFO <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		private DJCJAIPOLNB <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private List<(PersistenceView, HGNMPOIAAKI)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private HGNMPOIAAKI <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JGICAPHJDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D380", Offset = "0x3F7BF80", VA = "0x183F7D380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x3265C10", Offset = "0x3264810", VA = "0x183265C10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGICAPHJDJM))]
	public static Task EBDHDHCPNAJ(DNKNJNMAMBL GIOAKJNONKE, MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x3265DD0", Offset = "0x32649D0", VA = "0x183265DD0")]
	private static void GPJDDHKDCEH(PersistenceView AFCPDJEIDLD, HGNMPOIAAKI EJFGMPEJEDD, MOMCOKAPMLC PHBHEFAPHDL, FEEJMENJLIJ ANPIEEIPNGA, bool FPJMKDBAJEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal class ODEOHNPPJCE : MMDFDPPJLGH
{
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class PNIIAJKOJJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public AsyncTaskMethodBuilder<EJCOGPHMIIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public GEDJHDMKMOJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public ODEOHNPPJCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private StringBuilder <outputBuilder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public PNIIAJKOJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EC30", Offset = "0x5E1D830", VA = "0x185E1EC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private sealed class AKMOPGEKCBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public GEDJHDMKMOJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public ODEOHNPPJCE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public AKMOPGEKCBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x5E18870", Offset = "0x5E17470", VA = "0x185E18870")]
		internal Task IPCOIKAEFCP(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x5E18790", Offset = "0x5E17390", VA = "0x185E18790")]
		internal Task FLNANOFJGAF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class CAEMKKCFOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public AKMOPGEKCBI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CAEMKKCFOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x5E18B60", Offset = "0x5E17760", VA = "0x185E18B60")]
		internal object EDMGLJGPCAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class KCDLEBKFKAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public AKMOPGEKCBI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KCDLEBKFKAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D490", Offset = "0x5E1C090", VA = "0x185E1D490")]
		internal Task IMBPIJANEMN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class JHMCEHBCHMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public GEDJHDMKMOJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public ODEOHNPPJCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private AKMOPGEKCBI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private CAEMKKCFOBA <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JHMCEHBCHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C530", Offset = "0x5E1B130", VA = "0x185E1C530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400064A")]
	private readonly HDDCAHBLLEN ODPKAHOAPPJ;

	[Cpp2IlInjected.Token(Token = "0x400064B")]
	private static readonly TimeSpan MDINOJPLKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	private readonly PMBFCJLIGBB NILLNCDAMFL;

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x3270590", Offset = "0x326F190", VA = "0x183270590")]
	public ODEOHNPPJCE(DNKNJNMAMBL GIOAKJNONKE, PMBFCJLIGBB NILLNCDAMFL, [Optional] HDDCAHBLLEN? ODPKAHOAPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x326F410", Offset = "0x326E010", VA = "0x18326F410")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PNIIAJKOJJP))]
	public Task<EJCOGPHMIIO> ECCPKOGLKLF(long BPODGJMCBKI, string OPOLKMBAJBK, GEDJHDMKMOJ GIOCABEBNHM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x326FBE0", Offset = "0x326E7E0", VA = "0x18326FBE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JHMCEHBCHMA))]
	private Task GABMMOLFOOI(GEDJHDMKMOJ GIOCABEBNHM, IEnumerable<PersistenceView> DLPOCMMMECH, StringBuilder LEMKHGBBJGF, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x326F5E0", Offset = "0x326E1E0", VA = "0x18326F5E0")]
	private EJCOGPHMIIO FLPDHPEMPDO(long BPODGJMCBKI, string OPOLKMBAJBK, GEDJHDMKMOJ GIOCABEBNHM, IEnumerable<PersistenceView> DLPOCMMMECH, StringBuilder LEMKHGBBJGF)
	{
		return default(EJCOGPHMIIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x326F290", Offset = "0x326DE90", VA = "0x18326F290")]
	private BNIDNMGAHLD EBEMJAMFINA(long BPODGJMCBKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x326FDA0", Offset = "0x326E9A0", VA = "0x18326FDA0")]
	private void GHBMEODOLDG(BNIDNMGAHLD PJDCDPIPHBA, StringBuilder LEMKHGBBJGF, IEnumerable<PersistenceView> DLPOCMMMECH, in DHJIDMGNJIC AKDAOECFHJI, EKIEPCIPJDM LHNAPAPHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x326FFB0", Offset = "0x326EBB0", VA = "0x18326FFB0")]
	private void JHJPBFNLODM(BNIDNMGAHLD PJDCDPIPHBA, StringBuilder LEMKHGBBJGF, PersistenceView AFCPDJEIDLD, ref EKIEPCIPJDM LHNAPAPHKDJ, in DHJIDMGNJIC AKDAOECFHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal class MKKIMDKIEJP : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class BKDBAOGEJEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public MKKIMDKIEJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private string <unityAssetId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private ODEOHNPPJCE <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private GEDJHDMKMOJ <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private EJCOGPHMIIO <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private EJCOGPHMIIO <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private TaskAwaiter<EJCOGPHMIIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BKDBAOGEJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x3F740D0", Offset = "0x3F72CD0", VA = "0x183F740D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private readonly NFBLDIHAPOJ GJGJDNGPKAK;

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x326A310", Offset = "0x3268F10", VA = "0x18326A310")]
	public MKKIMDKIEJP(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, NFBLDIHAPOJ GJGJDNGPKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x326A230", Offset = "0x3268E30", VA = "0x18326A230", Slot = "7")]
	protected override string OGMLKJNLLDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x326A090", Offset = "0x3268C90", VA = "0x18326A090", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BKDBAOGEJEB))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal struct NHOCFNNGHPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	public Dictionary<Guid, List<LOHABELNFDM>> LMICAEJEHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	public Dictionary<Guid, List<LOHABELNFDM>> KNILAHAGHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	public Dictionary<Guid, List<LOHABELNFDM>> NPHBJECFANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	public List<Guid> MDEIBJCFAKB;

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x326C580", Offset = "0x326B180", VA = "0x18326C580")]
	public static NHOCFNNGHPA PNBJHLBKMLC(HBPPPIGEKFO FGOMHOJPKFO, FEEJMENJLIJ ANPIEEIPNGA, MOMCOKAPMLC LPFGOIILFCI)
	{
		return default(NHOCFNNGHPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public readonly struct IEGAONCOOPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	public readonly bool IFOBDMNOJDF;

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x1376CB0", Offset = "0x13758B0", VA = "0x181376CB0")]
	public IEGAONCOOPP(bool MKAIJMBKJCH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct BFGPKLGDCDD
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class NFKAOJCGFOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public OOCGABPOHBK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private FEEJMENJLIJ <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private List<(PersistenceView, HGNMPOIAAKI)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private (PersistenceView, HGNMPOIAAKI) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private CKGIIPHAJBG <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NFKAOJCGFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x326B730", Offset = "0x326A330", VA = "0x18326B730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x2AC61F0", Offset = "0x2AC4DF0", VA = "0x182AC61F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NFKAOJCGFOD))]
	public static Task EBDHDHCPNAJ(OOCGABPOHBK CDJHLNAAHGK, MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
internal struct KPGCBEAGKPL
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class IKGBMMJPPDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public AsyncTaskMethodBuilder<MOMCOKAPMLC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public MCNPFMNGCKP.DIKEJOLIKNG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public KPGCBEAGKPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private AALOEEPNEOP <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private Task<global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private Task<global::PKJAENHCLMN<global::HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private Task<global::PKJAENHCLMN<global::HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private Task<global::PKJAENHCLMN<global::HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private Task<(global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private global::PKJAENHCLMN<global::HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private global::PKJAENHCLMN<global::HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private global::PKJAENHCLMN<global::HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private global::HCLLLJEDILH<BNIDNMGAHLD> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private (global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private (global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private TaskAwaiter<(global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>, global::PKJAENHCLMN<global::HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IKGBMMJPPDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x3F7C500", Offset = "0x3F7B100", VA = "0x183F7C500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class LNFOAOHAJON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public AsyncTaskMethodBuilder<global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public MCNPFMNGCKP.DIKEJOLIKNG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public AALOEEPNEOP downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public KPGCBEAGKPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private AALOEEPNEOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private TaskAwaiter<global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LNFOAOHAJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F9B0", Offset = "0x3F7E5B0", VA = "0x183F7F9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private global::OOIGBDNKEMF<EFENBEKLEHO, CIOHJELGAHC> KFFNOKPJFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private global::OOIGBDNKEMF<EFENBEKLEHO, BNIDNMGAHLD> ICPMNAKBCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private global::OOIGBDNKEMF<long, DBGKDIDMLDF> KPGLGGKCHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private MHMLFGJNJKA CEKKHHEGJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private IEMLKNOFDEG KBEKHLAONIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private MPOOILGCDLJ CJNLJKIIPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private string OPOLKMBAJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private EFENBEKLEHO IKHHHDILDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private EFENBEKLEHO HOIJLNKGLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private long BFNOJMGJLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private AALOEEPNEOP IDIJCJCNEPO;

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x3264FD0", Offset = "0x3263BD0", VA = "0x183264FD0")]
	public static Task<MOMCOKAPMLC> AHEFPBBKFFG(IFNNJAAOEDN FNIFBLHBOOE, in HOAOFNBBEKI PHBHEFAPHDL, MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, AALOEEPNEOP IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x3265330", Offset = "0x3263F30", VA = "0x183265330")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKGBMMJPPDH))]
	private Task<MOMCOKAPMLC> EBDHDHCPNAJ(MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x3265500", Offset = "0x3264100", VA = "0x183265500")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNFOAOHAJON))]
	private Task<global::PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> HELNJIFFEFO(string OPOLKMBAJBK, long BFNOJMGJLFG, MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, AALOEEPNEOP HFLKGMILCJP, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
public class KFDAFKKLOKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private readonly IIDHLOGLACP BAMBFEPJLPN;

	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private const string GIAMHDNKEAP = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private const string DMBJPNEBJEJ = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private const string MNPGAGOECKJ = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private const string MLOFNDALOOG = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private const string LALOJOMALCC = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private string OFLFEFGNIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private long? NJFMODCOJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private long? LDCCGHGDLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private FEEJMENJLIJ KFPNBOHHNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private long? HKCOOAJECGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private bool DKEAICPBKBM;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string EILJMPEIPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long HLECCCFMNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x3263390", Offset = "0x3261F90", VA = "0x183263390")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long PCBENBOPEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x3262FE0", Offset = "0x3261BE0", VA = "0x183262FE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public FEEJMENJLIJ PIKEIPINLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x884740", Offset = "0x883340", VA = "0x180884740")]
		get
		{
			return default(FEEJMENJLIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x3263780", Offset = "0x3262380", VA = "0x183263780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public long DIKEHAFBGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x3263330", Offset = "0x3261F30", VA = "0x183263330")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x3263B10", Offset = "0x3262710", VA = "0x183263B10")]
	[UnityEngine.Scripting.Preserve]
	public KFDAFKKLOKJ([ACEKLAKDMBL(null)] IIDHLOGLACP BAMBFEPJLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x3263960", Offset = "0x3262560", VA = "0x183263960")]
	private void OEOEIGOFALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x32633F0", Offset = "0x3261FF0", VA = "0x1832633F0")]
	public void MCMIDIJEJCB(long HAMIEGOKEJC, long BPODGJMCBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x3263870", Offset = "0x3262470", VA = "0x183263870")]
	public void NFPBNAAPLIL(string AGJEHAHDINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x3263040", Offset = "0x3261C40", VA = "0x183263040")]
	public void EMKEIDOFNDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
internal sealed class GNPGFJFMNHD : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class AMMBJEENPIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public AMMBJEENPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x3F72E70", Offset = "0x3F71A70", VA = "0x183F72E70")]
		internal object CMOMFNDMDFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class DJDFNOFMHNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public GNPGFJFMNHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private MHBAMGOJMJJ <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private GKJHOLDCGPO <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DJDFNOFMHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x3F76F60", Offset = "0x3F75B60", VA = "0x183F76F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class BJNKPLCCOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public MHBAMGOJMJJ presence;

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BJNKPLCCOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x3F73F90", Offset = "0x3F72B90", VA = "0x183F73F90")]
		internal object BLHEAHAEIPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private readonly LCMHJBMHMJN CMKABAANNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private readonly MHKEFJDKLJN IKINGJFLMDI;

	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private const bool OGJKDAEGPEA = false;

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8D60", Offset = "0x2AD7960", VA = "0x182AD8D60")]
	public GNPGFJFMNHD(LCMHJBMHMJN CMKABAANNAK, MHKEFJDKLJN IKINGJFLMDI, Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8770", Offset = "0x2AD7370", VA = "0x182AD8770", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJDFNOFMHNJ))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8910", Offset = "0x2AD7510", VA = "0x182AD8910")]
	private MHBAMGOJMJJ IKCIIPMOMLF()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal struct LNLHCJMIMGG
{
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class FIHCBNIJKOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public IFNNJAAOEDN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private bool <isMaster>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FIHCBNIJKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x3F78220", Offset = "0x3F76E20", VA = "0x183F78220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x32670A0", Offset = "0x3265CA0", VA = "0x1832670A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FIHCBNIJKOO))]
	public static Task EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal struct KOKAOIFOHAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private sealed class DDKDKNPGDEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public KOKAOIFOHAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private GNIKGJEJAOC <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private AALOEEPNEOP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		private string <sceneName>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private Scene <mainScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DDKDKNPGDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x3F768A0", Offset = "0x3F754A0", VA = "0x183F768A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class KKMIJCLINOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KKMIJCLINOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F220", Offset = "0x3F7DE20", VA = "0x183F7F220")]
		internal object NJELHEMJBFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class KPHINNJLMBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public KOKAOIFOHAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		private KKMIJCLINOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		private NFEMKDMIHPG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KPHINNJLMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F270", Offset = "0x3F7DE70", VA = "0x183F7F270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E4")]
	private GNIKGJEJAOC FEEHPDIFFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006E5")]
	private AALOEEPNEOP IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006E6")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006E7")]
	private bool HCPCHHEKOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006E8")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x3264B30", Offset = "0x3263730", VA = "0x183264B30")]
	public static Task<Scene> CAIIMFNAGLL(IFNNJAAOEDN FNIFBLHBOOE, GNIKGJEJAOC EPLEEMFCMME, AALOEEPNEOP IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x3264D10", Offset = "0x3263910", VA = "0x183264D10")]
	public static Task<Scene> EFMJPDDAKLA(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, AALOEEPNEOP IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x3264BB0", Offset = "0x32637B0", VA = "0x183264BB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDKDKNPGDEO))]
	private Task<Scene> EBDHDHCPNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x3264DB0", Offset = "0x32639B0", VA = "0x183264DB0")]
	private bool GFFGKMPPLDL(MOMCOKAPMLC PHBHEFAPHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x3264DE0", Offset = "0x32639E0", VA = "0x183264DE0")]
	private void HFIDDOBGHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x3264E50", Offset = "0x3263A50", VA = "0x183264E50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KPHINNJLMBM))]
	private Task<Scene> LABLIJDEDLP(string KPMIPNBJALP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
public abstract class GHNMALNFIIN<T> where T : global::GHNMALNFIIN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006FC")]
	internal readonly IFNNJAAOEDN AEOAMPMHMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	private int? LAGKBBBLPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	protected readonly Guid ECPEBOBBOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006FF")]
	protected readonly DLLMEMMHNCB POGILKKOKAG;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	protected T CFDIOCDOGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x28BC080", Offset = "0x28BAC80", VA = "0x1828BC080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x28BC3E0", Offset = "0x28BAFE0", VA = "0x1828BC3E0")]
	internal GHNMALNFIIN(IFNNJAAOEDN BAFFLKMLODH, DLLMEMMHNCB GOKELOIKDPH, [Optional] Guid? PALLEDHBFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x28BC2F0", Offset = "0x28BAEF0", VA = "0x1828BC2F0")]
	private FHMBHNPINBI PNDMPGBACPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "4")]
	protected virtual void FNKFGHEALCA(FHMBHNPINBI DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x28BC0E0", Offset = "0x28BACE0", VA = "0x1828BC0E0")]
	public T EPOBKLBKCBE(IGGCDPKBFGF ACJGGEOLANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x28BC170", Offset = "0x28BAD70", VA = "0x1828BC170")]
	public T JOBANKHALDL(int APBFHMCACOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x28BC1F0", Offset = "0x28BADF0", VA = "0x1828BC1F0", Slot = "5")]
	public virtual Task<IDIFMABCDLA> NLNPDPINDNM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public class DHFMLFOJIHC : global::GHNMALNFIIN<DHFMLFOJIHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000700")]
	private LCMHJBMHMJN MEKBNGFFPML;

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9870", Offset = "0x2AC8470", VA = "0x182AC9870")]
	internal DHFMLFOJIHC(IFNNJAAOEDN BAFFLKMLODH, DLLMEMMHNCB GOKELOIKDPH, [Optional] Guid? PALLEDHBFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9850", Offset = "0x2AC8450", VA = "0x182AC9850")]
	public DHFMLFOJIHC PEKKCJNPFHN(LCMHJBMHMJN MEKBNGFFPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9790", Offset = "0x2AC8390", VA = "0x182AC9790", Slot = "4")]
	protected override void FNKFGHEALCA(FHMBHNPINBI DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public class AMGCDJKPHHE : global::GHNMALNFIIN<AMGCDJKPHHE>
{
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	internal enum JFNGBDOKEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		RecNet
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class KEPEDBDJOEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public AMGCDJKPHHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private IDIFMABCDLA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private TaskAwaiter<IDIFMABCDLA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KEPEDBDJOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x3262C50", Offset = "0x3261850", VA = "0x183262C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	private JFNGBDOKEFJ LIGEIHFKLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	private string GELGNLNNMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	private NNENOOPKHPC MEKBNGFFPML;

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5420", Offset = "0x2AC4020", VA = "0x182AC5420")]
	internal AMGCDJKPHHE(IFNNJAAOEDN BAFFLKMLODH, DLLMEMMHNCB GOKELOIKDPH, [Optional] Guid? PALLEDHBFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5270", Offset = "0x2AC3E70", VA = "0x182AC5270")]
	public AMGCDJKPHHE MOMLKGOFEHD(string IDCNODJDCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x2AC51D0", Offset = "0x2AC3DD0", VA = "0x182AC51D0")]
	public AMGCDJKPHHE GFJGJDJKNBJ(bool DNDPJAPBJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5240", Offset = "0x2AC3E40", VA = "0x182AC5240")]
	public AMGCDJKPHHE JCGLBPMKPIA(string FMALCPACLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x2AC53F0", Offset = "0x2AC3FF0", VA = "0x182AC53F0")]
	public AMGCDJKPHHE OLFKAAGMGMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5060", Offset = "0x2AC3C60", VA = "0x182AC5060", Slot = "4")]
	protected override void FNKFGHEALCA(FHMBHNPINBI DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x2AC52A0", Offset = "0x2AC3EA0", VA = "0x182AC52A0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KEPEDBDJOEK))]
	public override Task<IDIFMABCDLA> NLNPDPINDNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5200", Offset = "0x2AC3E00", VA = "0x182AC5200")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<IDIFMABCDLA> ICDBEDNLODH()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct OMGEIFGLMDJ
{
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class BEHNKGKPPMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public MCGDFABKIDE.CJJHBHDMDGF instantiations;

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BEHNKGKPPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E18AB0", Offset = "0x5E176B0", VA = "0x185E18AB0")]
		internal object GLEEEHPILGD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class EMBJHKDGIAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public EMBJHKDGIAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E19EA0", Offset = "0x5E18AA0", VA = "0x185E19EA0")]
		internal object KFBCMDIONEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x3270AC0", Offset = "0x326F6C0", VA = "0x183270AC0")]
	public static void EBDHDHCPNAJ(OOCGABPOHBK CDJHLNAAHGK, MOMCOKAPMLC PHBHEFAPHDL, MCGDFABKIDE.CJJHBHDMDGF KNICAFCALMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal struct MCGDFABKIDE
{
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	public struct CJJHBHDMDGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public List<GKDPOMOKADP> MKBFFOFCAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public List<HGNMPOIAAKI> GEDPMAOKDAN;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x96B830", Offset = "0x96A430", VA = "0x18096B830")]
		public CJJHBHDMDGF(List<GKDPOMOKADP> MKBFFOFCAEK, List<HGNMPOIAAKI> GEDPMAOKDAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class NOCEIFMLEIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public IEnumerable<GKDPOMOKADP> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NOCEIFMLEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F83990", Offset = "0x3F82590", VA = "0x183F83990")]
		internal object CDIEBDEOHJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000711")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000712")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x3268680", Offset = "0x3267280", VA = "0x183268680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x3267B20", Offset = "0x3266720", VA = "0x183267B20")]
	public static CJJHBHDMDGF EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL)
	{
		return default(CJJHBHDMDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x3267B90", Offset = "0x3266790", VA = "0x183267B90")]
	private CJJHBHDMDGF EBDHDHCPNAJ()
	{
		return default(CJJHBHDMDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x3268100", Offset = "0x3266D00", VA = "0x183268100")]
	private CJJHBHDMDGF NJGIGKHCMCP(BNIDNMGAHLD BBBFCKGLENJ, HBHNCFJCIKF KJBJOIGGOCH)
	{
		return default(CJJHBHDMDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x3267EB0", Offset = "0x3266AB0", VA = "0x183267EB0")]
	private bool KHIEFGMBIHG(IEnumerable<GKDPOMOKADP> MKBFFOFCAEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct DICNKJMABAF
{
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class FLIJPGHBNPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public DICNKJMABAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		private AALOEEPNEOP <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		private AALOEEPNEOP <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FLIJPGHBNPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x32600D0", Offset = "0x325ECD0", VA = "0x1832600D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class IPFCBDKKIIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IPFCBDKKIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x48A0540", Offset = "0x489F140", VA = "0x1848A0540")]
		internal object NJELHEMJBFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class JBCHCLNGGLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public DICNKJMABAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private IPFCBDKKIIB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private NFEMKDMIHPG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public JBCHCLNGGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x48A0F20", Offset = "0x489FB20", VA = "0x1848A0F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private bool HALMHNMILGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private AALOEEPNEOP IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private CancellationToken GFFFFCALMCA;

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9AE0", Offset = "0x2AC86E0", VA = "0x182AC9AE0")]
	public static Task JAGJNBNMDNL(IFNNJAAOEDN FNIFBLHBOOE, bool HALMHNMILGE, AALOEEPNEOP IDIJCJCNEPO, CancellationToken FFDAINFFMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x2AC99B0", Offset = "0x2AC85B0", VA = "0x182AC99B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FLIJPGHBNPP))]
	private Task EBDHDHCPNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9B50", Offset = "0x2AC8750", VA = "0x182AC9B50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JBCHCLNGGLI))]
	private Task LABLIJDEDLP(bool DJJMALJEJII, string KPMIPNBJALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F0460", Offset = "0x7EF060", VA = "0x1807F0460")]
	private bool JPNFMNLDNFA(bool HALMHNMILGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal struct HOAOFNBBEKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	public readonly IEMLKNOFDEG KBEKHLAONIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	public readonly MPOOILGCDLJ CJNLJKIIPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	public readonly string OPOLKMBAJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000731")]
	public readonly EFENBEKLEHO IKHHHDILDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	public readonly EFENBEKLEHO HOIJLNKGLFK;

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE1F0", Offset = "0x2ADCDF0", VA = "0x182ADE1F0")]
	public HOAOFNBBEKI(IEMLKNOFDEG KBEKHLAONIE, MPOOILGCDLJ CJNLJKIIPKB, string OPOLKMBAJBK, EFENBEKLEHO IKHHHDILDNK, EFENBEKLEHO HOIJLNKGLFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal sealed class CHMKLKMLENN : HALIFADCDEK
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class BAKBIPMEGBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public CHMKLKMLENN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private NKHBPCPCMLJ <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private GKJHOLDCGPO <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BAKBIPMEGBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x325CF10", Offset = "0x325BB10", VA = "0x18325CF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	private readonly LCMHJBMHMJN NHMBOCGMBGD;

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7040", Offset = "0x2AC5C40", VA = "0x182AC7040")]
	public CHMKLKMLENN(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, LCMHJBMHMJN NHMBOCGMBGD, FFLEKJBGAJJ KPFEABGPNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6EA0", Offset = "0x2AC5AA0", VA = "0x182AC6EA0", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BAKBIPMEGBI))]
	protected override Task FKNGBCPGLCB(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal struct KGAFFLMMDHL
{
	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x3263DE0", Offset = "0x32629E0", VA = "0x183263DE0")]
	public static Task EBDHDHCPNAJ(CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct HEKFJEICGBI
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class ECGAKJCABNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public IFNNJAAOEDN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private bool <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ECGAKJCABNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x3F77970", Offset = "0x3F76570", VA = "0x183F77970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class IACELMBHJEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public HEKFJEICGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		private bool <shouldObjectModelBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private bool <isOMFlagChanging>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private bool <reloadSceneForObjectModel>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public IACELMBHJEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F7AD10", Offset = "0x3F79910", VA = "0x183F7AD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400073E")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400073F")]
	private ByteString EPBBCHCFEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	private DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBD40", Offset = "0x2ADA940", VA = "0x182ADBD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private bool CMJEGCCGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB860", Offset = "0x2ADA460", VA = "0x182ADB860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool GHKKGJHEJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBCB0", Offset = "0x2ADA8B0", VA = "0x182ADBCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private bool BCBGHHFAELE
	{
		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB8E0", Offset = "0x2ADA4E0", VA = "0x182ADB8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2ADBAC0", Offset = "0x2ADA6C0", VA = "0x182ADBAC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ECGAKJCABNI))]
	public static Task<bool> EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB920", Offset = "0x2ADA520", VA = "0x182ADB920")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IACELMBHJEH))]
	private Task<bool> EBDHDHCPNAJ(AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
public static class EDKMEFHOBIG
{
	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x2ACBE60", Offset = "0x2ACAA60", VA = "0x182ACBE60")]
	public static EFENBEKLEHO BMNPIDDJJNL(this HAPEDGBDDDG MJJEAGOMNNL)
	{
		return default(EFENBEKLEHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x2ACBF20", Offset = "0x2ACAB20", VA = "0x182ACBF20")]
	public static HAPEDGBDDDG KFALNGGMHPP(this EFENBEKLEHO ANGPFHAPFPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
internal class CHIPOCIBCNK : MMDFDPPJLGH
{
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private sealed class FKHMOGPFCED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public NIADFLCAKKJ.BLEDDCONCNO roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FKHMOGPFCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x3260040", Offset = "0x325EC40", VA = "0x183260040")]
		internal object PNDOAICHBLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x325FD40", Offset = "0x325E940", VA = "0x18325FD40")]
		internal object GAENOLKHDLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x325FD90", Offset = "0x325E990", VA = "0x18325FD90")]
		internal object GKMIMNBLPLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x325FE00", Offset = "0x325EA00", VA = "0x18325FE00")]
		internal object GLFGLBPEBLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class OMICCKOFGJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public AsyncTaskMethodBuilder<(NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private FKHMOGPFCED <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		private CIOHJELGAHC <roomMetadata>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		private NIADFLCAKKJ.BLEDDCONCNO <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		private NIADFLCAKKJ.BLEDDCONCNO <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		private TaskAwaiter<NIADFLCAKKJ.BLEDDCONCNO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public OMICCKOFGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x3271190", Offset = "0x326FD90", VA = "0x183271190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class BOJFPPBKBBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public AsyncTaskMethodBuilder<LPCDCAILFOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public NNENOOPKHPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		private NIADFLCAKKJ.BLEDDCONCNO <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private NIADFLCAKKJ.BLEDDCONCNO <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private int <persistenceVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		private NEBPAIJOJCP <request>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private LPCDCAILFOA <response>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		private (NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private (NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private LPCDCAILFOA <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private TaskAwaiter<(NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private TaskAwaiter<LPCDCAILFOA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BOJFPPBKBBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x325DD90", Offset = "0x325C990", VA = "0x18325DD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class EJNPFODKFCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public AsyncTaskMethodBuilder<CAIGCNABMEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public int savingPlayerAccountId;

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
		private CAIGCNABMEN <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private (NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private (NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private CAIGCNABMEN <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private TaskAwaiter<(NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private TaskAwaiter<CAIGCNABMEN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public EJNPFODKFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x325F800", Offset = "0x325E400", VA = "0x18325F800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class ADFANEGODOA
	{
		[Cpp2IlInjected.Token(Token = "0x2000194")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000792")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000793")]
			public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000794")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000795")]
			public ADFANEGODOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000796")]
			private FHMBHNPINBI <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000797")]
			private RepeatedField<HGNMPOIAAKI> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000798")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x77F500", Offset = "0x77E900")]
			private IEnumerable<HGNMPOIAAKI> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			private CAIGCNABMEN <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			private CAIGCNABMEN <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			private LPCDCAILFOA <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			private LPCDCAILFOA <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			private FHMBHNPINBI <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			private TaskAwaiter<CAIGCNABMEN> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			private TaskAwaiter<LPCDCAILFOA> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			private TaskAwaiter<FHMBHNPINBI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x5E22100", Offset = "0x5E20D00", VA = "0x185E22100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public NNENOOPKHPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public IEGAONCOOPP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x77F430", Offset = "0x77E830")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ADFANEGODOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x325C9F0", Offset = "0x325B5F0", VA = "0x18325C9F0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<FHMBHNPINBI> JCKBHPJJBCP(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class ODKABEEKPHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public NNENOOPKHPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public IEGAONCOOPP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x77F560", Offset = "0x77E960")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		private ADFANEGODOA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private FHMBHNPINBI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ODKABEEKPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x32706A0", Offset = "0x326F2A0", VA = "0x1832706A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000754")]
	private const float HOJEBHBGLMK = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000755")]
	private readonly BNBOHDAMFHI CJPJEGMHJHB;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private IFNNJAAOEDN MIDAOOLAHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AC65E0", Offset = "0x2AC51E0", VA = "0x182AC65E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6E10", Offset = "0x2AC5A10", VA = "0x182AC6E10")]
	public CHIPOCIBCNK(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6C50", Offset = "0x2AC5850", VA = "0x182AC6C50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMICCKOFGJC))]
	private Task<(NIADFLCAKKJ.BLEDDCONCNO, NIADFLCAKKJ.BLEDDCONCNO)> MKBBIAPKPGD(EJCOGPHMIIO NNIPLGKEGFJ, long HAMIEGOKEJC, long KIBMHJEFMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6A60", Offset = "0x2AC5660", VA = "0x182AC6A60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BOJFPPBKBBB))]
	public Task<LPCDCAILFOA> FLEHEHANDKI(int DEPJAMELNGJ, [CanBeNull] NNENOOPKHPC IDBNBECJKFH, EJCOGPHMIIO NNIPLGKEGFJ, long HAMIEGOKEJC, long KIBMHJEFMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6610", Offset = "0x2AC5210", VA = "0x182AC6610")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJNPFODKFCC))]
	private Task<CAIGCNABMEN> EKKOIDDDLEH(string APOLELLKJLH, int DEPJAMELNGJ, EJCOGPHMIIO NNIPLGKEGFJ, long HAMIEGOKEJC, long KIBMHJEFMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6810", Offset = "0x2AC5410", VA = "0x182AC6810")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ODKABEEKPHI))]
	public Task<FHMBHNPINBI> FCKBKOIHOBA(int DEPJAMELNGJ, NNENOOPKHPC? IDBNBECJKFH, EJCOGPHMIIO NNIPLGKEGFJ, long HAMIEGOKEJC, long KIBMHJEFMKG, IEGAONCOOPP FEBGOIPDFBI, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
internal class LCLBBEMHFDA : HALIFADCDEK
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class MFCMCIEHPBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007BD")]
			public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007BE")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007BF")]
			public MFCMCIEHPBF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007C0")]
			private EJCOGPHMIIO <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007C1")]
			private FHMBHNPINBI <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007C2")]
			private EJCOGPHMIIO <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			private FHMBHNPINBI <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			private TaskAwaiter<EJCOGPHMIIO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007C5")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x77F6A0", Offset = "0x77EAA0")]
			private TaskAwaiter<FHMBHNPINBI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x5E21CB0", Offset = "0x5E208B0", VA = "0x185E21CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		public LCLBBEMHFDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		public ODEOHNPPJCE serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		public CHIPOCIBCNK uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public IEGAONCOOPP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MFCMCIEHPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F81730", Offset = "0x3F80330", VA = "0x183F81730")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<FHMBHNPINBI> PCEIDODDIHH(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class FMDBOPNMOGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		public AALOEEPNEOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		public LCLBBEMHFDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		private MFCMCIEHPBF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		private NKHBPCPCMLJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		private BNNPCINDEGK <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		private GKJHOLDCGPO <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private FHMBHNPINBI <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		private FHMBHNPINBI <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FMDBOPNMOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F78B80", Offset = "0x3F77780", VA = "0x183F78B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007B2")]
	private readonly int DEPJAMELNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007B3")]
	[CanBeNull]
	private readonly NNENOOPKHPC IDBNBECJKFH;

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x3265B60", Offset = "0x3264760", VA = "0x183265B60")]
	public LCLBBEMHFDA(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, int DEPJAMELNGJ, NNENOOPKHPC IDBNBECJKFH, FFLEKJBGAJJ KPFEABGPNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x3265730", Offset = "0x3264330", VA = "0x183265730", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FMDBOPNMOGD))]
	protected override Task FKNGBCPGLCB(DNKNJNMAMBL GIOAKJNONKE, AALOEEPNEOP LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x3265A70", Offset = "0x3264670", VA = "0x183265A70")]
	private void JPHFHFFKPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x32658D0", Offset = "0x32644D0", VA = "0x1832658D0")]
	private void HKGIIPEFMJN(AALOEEPNEOP LEBCJIHOHHE, NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200019B")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public BOHAGPJNCEM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public BOHAGPJNCEM HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DF")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private static BOHAGPJNCEM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		private Dictionary<BOHAGPJNCEM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x3276FF0", Offset = "0x3275BF0", VA = "0x183276FF0")]
		public bool NAAMKNMDFAH(BOHAGPJNCEM BBMNNPEOJDE, out ResultConfig CEHJOFICIAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x32777E0", Offset = "0x32763E0", VA = "0x1832777E0")]
		public ResultConfig PLBLPCLNKFG(BOHAGPJNCEM MDCIFHCDMMF, [Optional] HashSet<BOHAGPJNCEM> OFHNCJNEKJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x32775E0", Offset = "0x32761E0", VA = "0x1832775E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x3277060", Offset = "0x3275C60", VA = "0x183277060", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x12EAAC0", Offset = "0x12E96C0", VA = "0x1812EAAC0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public class FJHFJBECMEA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x2AD41E0", Offset = "0x2AD2DE0", VA = "0x182AD41E0")]
	public FJHFJBECMEA(string DKIECHCHJFL, Exception NCFNHKNLKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public class KEOPDAFDAHG
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	private sealed class IPCMFCLNHIL : BLPMDLHIELF, IEquatable<BLPMDLHIELF>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		[CompilerGenerated]
		private sealed class CHPMLPJPPLJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007EC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007ED")]
			public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007EE")]
			public IPCMFCLNHIL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007EF")]
			private NCFBJHOACDL <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007F0")]
			private IEMLKNOFDEG <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007F1")]
			private LCMHJBMHMJN <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007F2")]
			private IEMLKNOFDEG <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007F3")]
			private IDIFMABCDLA <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007F4")]
			private TaskAwaiter<IEMLKNOFDEG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007F5")]
			private TaskAwaiter<IDIFMABCDLA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public CHPMLPJPPLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0x5E18C60", Offset = "0x5E17860", VA = "0x185E18C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		private readonly BNNPCINDEGK OPEBBEJDEPM;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public int EECDPPIJLCA
		{
			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0x837B50", Offset = "0x836750", VA = "0x180837B50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public JPNGCEFMBEO LMALIKDMCJD
		{
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		private DateTime IDCJKOENPIG
		{
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0x3F7CF90", Offset = "0x3F7BB90", VA = "0x183F7CF90", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public ELODCOFCJAF? KAEGAPFLFGA
		{
			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x9C04B0", Offset = "0x9BF0B0", VA = "0x1809C04B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public PPBPIDGBPHI? ALGACNOOCCH
		{
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x15F2D40", Offset = "0x15F1940", VA = "0x1815F2D40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public GAOMACELHLE KMHICIJNHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x85DA90", Offset = "0x85C690", VA = "0x18085DA90", Slot = "10")]
			get
			{
				return default(GAOMACELHLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x3F7CFB0", Offset = "0x3F7BBB0", VA = "0x183F7CFB0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(CHPMLPJPPLJ))]
		public Task<IDIFMABCDLA> BEIHBPAMODO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D320", Offset = "0x3F7BF20", VA = "0x183F7D320")]
		public IPCMFCLNHIL(int LMMJHNPOCPO, JPNGCEFMBEO IDOMIIDIAPH, BNNPCINDEGK OPEBBEJDEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D1A0", Offset = "0x3F7BDA0", VA = "0x183F7D1A0", Slot = "11")]
		public bool Equals(BLPMDLHIELF MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D100", Offset = "0x3F7BD00", VA = "0x183F7D100", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D2D0", Offset = "0x3F7BED0", VA = "0x183F7D2D0")]
		private bool OCDFPFBBPDN(IPCMFCLNHIL MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D240", Offset = "0x3F7BE40", VA = "0x183F7D240", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	private sealed class HCAOPLFDEKA : BLPMDLHIELF, IEquatable<BLPMDLHIELF>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A2")]
		[CompilerGenerated]
		private sealed class MEGAMAFHOJO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007FA")]
			public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007FB")]
			public HCAOPLFDEKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007FC")]
			private IDIFMABCDLA <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007FD")]
			private TaskAwaiter<IDIFMABCDLA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public MEGAMAFHOJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x5E1E840", Offset = "0x5E1D440", VA = "0x185E1E840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		private readonly HCKACEFMPCF GAPOOPBJCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private readonly ELODCOFCJAF IKLIILIFHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private readonly PPBPIDGBPHI PGKCKACBLMK;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public int EECDPPIJLCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0x3F7A780", Offset = "0x3F79380", VA = "0x183F7A780", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public JPNGCEFMBEO LMALIKDMCJD
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x3F7A3B0", Offset = "0x3F78FB0", VA = "0x183F7A3B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		private DateTime IDCJKOENPIG
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x3F7A400", Offset = "0x3F79000", VA = "0x183F7A400", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public ELODCOFCJAF? KAEGAPFLFGA
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x3F7A7D0", Offset = "0x3F793D0", VA = "0x183F7A7D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public PPBPIDGBPHI? ALGACNOOCCH
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x3F7A820", Offset = "0x3F79420", VA = "0x183F7A820", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public GAOMACELHLE KMHICIJNHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x852300", Offset = "0x850F00", VA = "0x180852300", Slot = "10")]
			get
			{
				return default(GAOMACELHLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x960B40", Offset = "0x95F740", VA = "0x180960B40")]
		public HCAOPLFDEKA(HCKACEFMPCF IPKBJACGFCO, ELODCOFCJAF KEEOJFLMHOO, PPBPIDGBPHI HNLBDKLBBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A450", Offset = "0x3F79050", VA = "0x183F7A450", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MEGAMAFHOJO))]
		public Task<IDIFMABCDLA> BEIHBPAMODO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A650", Offset = "0x3F79250", VA = "0x183F7A650", Slot = "11")]
		public bool Equals(BLPMDLHIELF MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A5A0", Offset = "0x3F791A0", VA = "0x183F7A5A0", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A870", Offset = "0x3F79470", VA = "0x183F7A870")]
		private bool OCDFPFBBPDN(HCAOPLFDEKA MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A6F0", Offset = "0x3F792F0", VA = "0x183F7A6F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	private sealed class COPIGHDKAHJ : BLPMDLHIELF, IEquatable<BLPMDLHIELF>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A4")]
		[CompilerGenerated]
		private sealed class DHODAFONGEN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			public COPIGHDKAHJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000804")]
			private IDIFMABCDLA <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000805")]
			private TaskAwaiter<IDIFMABCDLA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public DHODAFONGEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x5E19950", Offset = "0x5E18550", VA = "0x185E19950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private readonly JPNGCEFMBEO FPKDIDHPIAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private readonly ELODCOFCJAF IKLIILIFHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		private readonly PPBPIDGBPHI PGKCKACBLMK;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public int EECDPPIJLCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x3F74E00", Offset = "0x3F73A00", VA = "0x183F74E00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		[NotNull]
		public JPNGCEFMBEO LMALIKDMCJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private DateTime IDCJKOENPIG
		{
			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x83E700", Offset = "0x83D300", VA = "0x18083E700", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public ELODCOFCJAF? KAEGAPFLFGA
		{
			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x3F74E80", Offset = "0x3F73A80", VA = "0x183F74E80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public PPBPIDGBPHI? ALGACNOOCCH
		{
			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x3F74ED0", Offset = "0x3F73AD0", VA = "0x183F74ED0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public GAOMACELHLE KMHICIJNHNL
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x83E700", Offset = "0x83D300", VA = "0x18083E700", Slot = "10")]
			get
			{
				return default(GAOMACELHLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x960B40", Offset = "0x95F740", VA = "0x180960B40")]
		public COPIGHDKAHJ(JPNGCEFMBEO IDOMIIDIAPH, ELODCOFCJAF KEEOJFLMHOO, PPBPIDGBPHI HNLBDKLBBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x3F74990", Offset = "0x3F73590", VA = "0x183F74990", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(DHODAFONGEN))]
		public Task<IDIFMABCDLA> BEIHBPAMODO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x3F74C20", Offset = "0x3F73820", VA = "0x183F74C20", Slot = "11")]
		public bool Equals(BLPMDLHIELF MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x3F74AE0", Offset = "0x3F736E0", VA = "0x183F74AE0", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x3F74D50", Offset = "0x3F73950", VA = "0x183F74D50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x3F74F20", Offset = "0x3F73B20", VA = "0x183F74F20")]
		private bool OCDFPFBBPDN(COPIGHDKAHJ MDHJAFNLPON)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class MCDNHJEANGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400080C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400080D")]
		public AsyncTaskMethodBuilder<IList<BLPMDLHIELF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400080E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400080F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000810")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		public KEOPDAFDAHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		private IReadOnlyList<BNNPCINDEGK> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		private IReadOnlyList<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		private List<BLPMDLHIELF> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		private HCKACEFMPCF <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private IReadOnlyList<BNNPCINDEGK> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private IReadOnlyList<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private IEnumerator<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		private (int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private HCAOPLFDEKA <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		private TaskAwaiter<IReadOnlyList<BNNPCINDEGK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private TaskAwaiter<IReadOnlyList<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MCDNHJEANGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x3F80AB0", Offset = "0x3F7F6B0", VA = "0x183F80AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class APNOHBHKDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		public IReadOnlyList<BNNPCINDEGK> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		public KEOPDAFDAHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private IReadOnlyList<JPNGCEFMBEO> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		private Dictionary<ObscuredInt, JPNGCEFMBEO> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		private List<(int, JPNGCEFMBEO, BNNPCINDEGK)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		private IReadOnlyList<JPNGCEFMBEO> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		private IEnumerator<BNNPCINDEGK> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		private BNNPCINDEGK <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private JPNGCEFMBEO <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		private JPNGCEFMBEO <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400082D")]
		private TaskAwaiter<IReadOnlyList<JPNGCEFMBEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public APNOHBHKDBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x3F73390", Offset = "0x3F71F90", VA = "0x183F73390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E5")]
	private readonly GJANOCFHBPK CMNEEKOFKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007E6")]
	private readonly DENCMPHLPHJ LHNLEFIGMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007E7")]
	private readonly LCAFMEKLLGH MFKMPKPAPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40007E8")]
	private readonly global::PBGCPGFJPND<(long, long), IReadOnlyList<BNNPCINDEGK>> DCHEGGFINJM;

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x3262B30", Offset = "0x3261730", VA = "0x183262B30")]
	[UnityEngine.Scripting.Preserve]
	public KEOPDAFDAHG([ACEKLAKDMBL(null)] DENCMPHLPHJ FLKNEJKHELK, [ACEKLAKDMBL(null)] LCAFMEKLLGH POCJMJBNADK, [ACEKLAKDMBL(null)] GJANOCFHBPK MPDJMFEEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x3262670", Offset = "0x3261270", VA = "0x183262670")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MCDNHJEANGP))]
	public Task<IList<BLPMDLHIELF>> BDKEOJFGKDI(long HAMIEGOKEJC, long BPODGJMCBKI, bool MPBKGNHECHB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x3262810", Offset = "0x3261410", VA = "0x183262810")]
	private bool GMIOAFCEBPH(DateTime? ELKAIOOFKHB, long HAMIEGOKEJC, long BPODGJMCBKI, out HCKACEFMPCF ANGBHDDNJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x32629C0", Offset = "0x32615C0", VA = "0x1832629C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(APNOHBHKDBE))]
	private Task<IReadOnlyList<(int, JPNGCEFMBEO, BNNPCINDEGK)>> ICKPHPMDOBP(IReadOnlyList<BNNPCINDEGK> BJLMLGFPNLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class OPCFEDDKIDK : DENCMPHLPHJ
{
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class HCKLADHBMLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400082E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400082F")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BNNPCINDEGK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000830")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000831")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000832")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000833")]
		public OPCFEDDKIDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000834")]
		private global::LFEMLMBOIIA<BNNPCINDEGK> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000835")]
		private global::LFEMLMBOIIA<BNNPCINDEGK> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000836")]
		private TaskAwaiter<global::LFEMLMBOIIA<BNNPCINDEGK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HCKLADHBMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B540", Offset = "0x5E1A140", VA = "0x185E1B540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private sealed class ILEBKOFIMIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000837")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		public AsyncTaskMethodBuilder<IReadOnlyList<JPNGCEFMBEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000839")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400083A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400083B")]
		public OPCFEDDKIDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400083C")]
		private List<JPNGCEFMBEO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400083D")]
		private TaskAwaiter<List<JPNGCEFMBEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ILEBKOFIMIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C2F0", Offset = "0x5E1AEF0", VA = "0x185E1C2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	[UnityEngine.Scripting.Preserve]
	public OPCFEDDKIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x3272A90", Offset = "0x3271690", VA = "0x183272A90", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HCKLADHBMLA))]
	public Task<IReadOnlyList<BNNPCINDEGK>> JFNDJCEHLNG(long HAMIEGOKEJC, long KIBMHJEFMKG, [Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x3272C40", Offset = "0x3271840", VA = "0x183272C40", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ILEBKOFIMIJ))]
	public Task<IReadOnlyList<JPNGCEFMBEO>> MEOGEJOBDCB(IReadOnlyList<int> IJNHKBOELBC, [Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public interface DENCMPHLPHJ
{
	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<BNNPCINDEGK>> JFNDJCEHLNG(long HAMIEGOKEJC, long KIBMHJEFMKG, [Optional] CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<JPNGCEFMBEO>> MEOGEJOBDCB(IReadOnlyList<int> IJNHKBOELBC, [Optional] CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public interface BLPMDLHIELF : IEquatable<BLPMDLHIELF>
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	int EECDPPIJLCA
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	[CanBeNull]
	JPNGCEFMBEO LMALIKDMCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	DateTime NNFBFGJNNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	ELODCOFCJAF? KAEGAPFLFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	PPBPIDGBPHI? ALGACNOOCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	[CanBeNull]
	GAOMACELHLE KMHICIJNHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IDIFMABCDLA> BEIHBPAMODO();
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public enum GAOMACELHLE
{
	[Cpp2IlInjected.Token(Token = "0x400083F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000840")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000841")]
	DiskAutosave
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
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
