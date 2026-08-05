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
		[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
		[Cpp2IlInjected.Address(RVA = "0x30AF0E0", Offset = "0x30ADCE0", VA = "0x1830AF0E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83E010", Offset = "0x83CC10", VA = "0x18083E010")]
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
		[Cpp2IlInjected.Address(RVA = "0xBF6D90", Offset = "0xBF5990", VA = "0x180BF6D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JLJHFIHPDNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E17770", Offset = "0x3E16370", VA = "0x183E17770")]
		internal object KCDDEDEMLNP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BOHNLHMBPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28BBAD0", Offset = "0x28BA6D0", VA = "0x1828BBAD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28BC400", Offset = "0x28BB000", VA = "0x1828BC400", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KGMACCFPPHI FEPFLACKKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28BBA30", Offset = "0x28BA630", VA = "0x1828BBA30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28BBDE0", Offset = "0x28BA9E0", VA = "0x1828BBDE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event KGMACCFPPHI GOIAEEEILBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28BC360", Offset = "0x28BAF60", VA = "0x1828BC360", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28BB990", Offset = "0x28BA590", VA = "0x1828BB990", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event KGMACCFPPHI LJENEBHMOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28BC540", Offset = "0x28BB140", VA = "0x1828BC540", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28BC4A0", Offset = "0x28BB0A0", VA = "0x1828BC4A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NBGKOOKNBGP, bool> KFAMNOAKCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28BC030", Offset = "0x28BAC30", VA = "0x1828BC030", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28BBE80", Offset = "0x28BAA80", VA = "0x1828BBE80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "19")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x28BBB70", Offset = "0x28BA770", VA = "0x1828BBB70", Slot = "14")]
	public void DCAJNDNNNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x28BC000", Offset = "0x28BAC00", VA = "0x1828BC000", Slot = "15")]
	public void IHKAKCADEFN(NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28BBF20", Offset = "0x28BAB20", VA = "0x1828BBF20", Slot = "16")]
	public void GGHKLMBDLFL(NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x28BC330", Offset = "0x28BAF30", VA = "0x1828BC330", Slot = "17")]
	public void NECNIDCBHOL(NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x28BBF50", Offset = "0x28BAB50", VA = "0x1828BBF50", Slot = "18")]
	public void HGDIGCPPJBC(NBGKOOKNBGP KAINKNJPFIL, bool GGKLFMPBGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x28BC0D0", Offset = "0x28BACD0", VA = "0x1828BC0D0")]
	private void MKOHINBGHOB(KGMACCFPPHI NMPOOPDGJFD, NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE97F0", Offset = "0xAE83F0", VA = "0x180AE97F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xB1CC20", Offset = "0xB1B820", VA = "0x180B1CC20")]
	public GDNNMLKFEHK(IDictionary<object, object> CBLNAPKAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x28B1C70", Offset = "0x28B0870", VA = "0x1828B1C70")]
	public bool EHMCOLBLMFF(out FHMBHNPINBI DKIECHCHJFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x28B1E20", Offset = "0x28B0A20", VA = "0x1828B1E20")]
	public Guid LDBDBOFBKGH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x28B1B60", Offset = "0x28B0760", VA = "0x1828B1B60")]
	public IDIFMABCDLA DLABMAIJNIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x28B1D30", Offset = "0x28B0930", VA = "0x1828B1D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IFFEFMAKIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E156B0", Offset = "0x3E142B0", VA = "0x183E156B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x28C0410", Offset = "0x28BF010", VA = "0x1828C0410", Slot = "4")]
	public void IAAGAGMBLDF(KCEEEPMPGFI JNHEDBAKBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x28C0470", Offset = "0x28BF070", VA = "0x1828C0470", Slot = "5")]
	public void KNLMDMHCHJC(KCEEEPMPGFI JNHEDBAKBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28C01A0", Offset = "0x28BEDA0", VA = "0x1828C01A0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x28C01F0", Offset = "0x28BEDF0", VA = "0x1828C01F0")]
	protected IDIFMABCDLA HMEFICDIDBP(IGGCDPKBFGF AOLFPABEEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x28AB360", Offset = "0x28A9F60", VA = "0x1828AB360")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GHOCBABIKGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3E13F10", Offset = "0x3E12B10", VA = "0x183E13F10")]
		internal bool GDIHPPBMEEH(MPOOILGCDLJ s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28BD620", Offset = "0x28BC220", VA = "0x1828BD620")]
	public static LCMHJBMHMJN JLAKJAPJOGA(long HBCPJJJHDAN, long KIBMHJEFMKG, string APOLELLKJLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28BD6C0", Offset = "0x28BC2C0", VA = "0x1828BD6C0")]
	public static LCMHJBMHMJN JLAKJAPJOGA(long HBCPJJJHDAN, long KIBMHJEFMKG, EFENBEKLEHO IKHHHDILDNK, long PJBAEAJLHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x28BD2A0", Offset = "0x28BBEA0", VA = "0x1828BD2A0")]
	public static LCMHJBMHMJN JLAKJAPJOGA(LPCDCAILFOA GLAABCHHFKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x28BD3E0", Offset = "0x28BBFE0", VA = "0x1828BD3E0")]
	public static LCMHJBMHMJN JLAKJAPJOGA(IEMLKNOFDEG FFKPMIAJOHJ, BNNPCINDEGK HKLLDLGPABG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x28BD190", Offset = "0x28BBD90", VA = "0x1828BD190")]
	public static LCMHJBMHMJN GGHJIOOPGLA(this LCMHJBMHMJN MEKBNGFFPML, IEMLKNOFDEG APOIMGJBMKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28BD000", Offset = "0x28BBC00", VA = "0x1828BD000")]
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
	[Cpp2IlInjected.Address(RVA = "0x30AF0C0", Offset = "0x30ADCC0", VA = "0x1830AF0C0")]
	public NKHBPCPCMLJ(long HBCPJJJHDAN, long KIBMHJEFMKG, GHLDFOEBGAC FIJCKHKKDCC, [CanBeNull] Exception BLBJGIOFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x30AF070", Offset = "0x30ADC70", VA = "0x1830AF070")]
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
		private JAPPGKMKBNF<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private HALPBDECPOJ <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DDCDIGKHNIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FFE0", Offset = "0x3E0EBE0", VA = "0x183E0FFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x28BB350", Offset = "0x28B9F50", VA = "0x1828BB350", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x28BB0F0", Offset = "0x28B9CF0", VA = "0x1828BB0F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28BAFA0", Offset = "0x28B9BA0", VA = "0x1828BAFA0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDCDIGKHNIP))]
	public Task DBEOFEALEMN(string FMALCPACLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28BB140", Offset = "0x28B9D40", VA = "0x1828BB140", Slot = "4")]
	public IDIFMABCDLA IGGGLNHPCKG(IGGCDPKBFGF AEEBHLKEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28BB200", Offset = "0x28B9E00", VA = "0x1828BB200")]
	private HALPBDECPOJ NFBENPIHNDC(string FMALCPACLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IKLDFDIBKPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4628A50", Offset = "0x4627650", VA = "0x184628A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		private JAPPGKMKBNF<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <timerScope>5__3;

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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CFEFEBAGGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4621BC0", Offset = "0x46207C0", VA = "0x184621BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MDLDCNFIHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x462D320", Offset = "0x462BF20", VA = "0x18462D320")]
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
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Task<LCMHJBMHMJN> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HGAJGKPKEMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		internal Task<LCMHJBMHMJN> AKPBEMHJNJB(JAPPGKMKBNF<string>.KLCBHAGBNOA _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MLODGCFIPNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public OAEILIIIPED customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public FFLEKJBGAJJ joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private EIBOJBKNGCC <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private HGAJGKPKEMC <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private JJMPNGLGHEG <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Task<Matchmaking.MDKPNMHIPCM> <serverConnectionInfoTask>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IAEAGHMOCOM <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private Matchmaking.MDKPNMHIPCM <serverConnectionInfo>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private CancellationTokenSource <loadingScreenCts>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <loadingScreenScope>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Matchmaking.MDKPNMHIPCM <>s__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private CancellationTokenSource <photonJoinedTokenSource>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private CancellationToken <photonJoinedToken>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private LCMHJBMHMJN <initialRoomLoadPayload>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private Task <roomLoadTask>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private LCMHJBMHMJN <>s__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Matchmaking.MDKPNMHIPCM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<LCMHJBMHMJN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MLODGCFIPNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x462DB30", Offset = "0x462C730", VA = "0x18462DB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

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
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <disconnectTimerScope>5__2;

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
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IPPENAIOHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4629080", Offset = "0x4627C80", VA = "0x184629080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ONPEJEJFHPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4631F00", Offset = "0x4630B00", VA = "0x184631F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Matchmaking.MDKPNMHIPCM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<Matchmaking.MDKPNMHIPCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NJHAKGNJFEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4630DB0", Offset = "0x462F9B0", VA = "0x184630DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

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
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private ALKMAGMAGJP <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<ALKMAGMAGJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LGAJEOKPIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x462CBC0", Offset = "0x462B7C0", VA = "0x18462CBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public PNGENAHCBPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4632A30", Offset = "0x4631630", VA = "0x184632A30")]
		internal object DPJFJFDJNML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4632B30", Offset = "0x4631730", VA = "0x184632B30")]
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

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NIMIIEEPIHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x46301B0", Offset = "0x462EDB0", VA = "0x1846301B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private FFLEKJBGAJJ <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private GNPGFJFMNHD <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ACPNDFGMPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x461F390", Offset = "0x461DF90", VA = "0x18461F390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private CancellationTokenSource <timeoutTcs>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private CancellationToken <timeoutToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BMDNEALEOMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x46204D0", Offset = "0x461F0D0", VA = "0x1846204D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public FGJHIEFNNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private int <version>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private bool <canUpdateRoom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool <shouldSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6E")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter<IDIFMABCDLA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NMPOKEMLAAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x46311B0", Offset = "0x462FDB0", VA = "0x1846311B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ECDFMAIKKAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x46242A0", Offset = "0x4622EA0", VA = "0x1846242A0")]
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
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ECDHAOKOLCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4624470", Offset = "0x4623070", VA = "0x184624470")]
		internal void EPOENJKLLOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BJJKBBMKDGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BJJKBBMKDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4620450", Offset = "0x461F050", VA = "0x184620450")]
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
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KFPPHNLEOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x462BBA0", Offset = "0x462A7A0", VA = "0x18462BBA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C72B0", Offset = "0x9C5EB0", VA = "0x1809C72B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9C7490", Offset = "0x9C6090", VA = "0x1809C7490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28AF430", Offset = "0x28AE030", VA = "0x1828AF430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x28B0280", Offset = "0x28AEE80", VA = "0x1828B0280", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x28ADA00", Offset = "0x28AC600", VA = "0x1828ADA00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x28AF9F0", Offset = "0x28AE5F0", VA = "0x1828AF9F0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKLDFDIBKPF))]
	public Task MHKIGANIEGO(MHKEFJDKLJN FKMIOMCKJNF, OAEILIIIPED LBJHHPLDPCI, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x28ACA80", Offset = "0x28AB680", VA = "0x1828ACA80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CFEFEBAGGBN))]
	private Task CGIPLDAAFAH(MHKEFJDKLJN FKMIOMCKJNF, OAEILIIIPED LBJHHPLDPCI, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x28AF480", Offset = "0x28AE080", VA = "0x1828AF480")]
	private static void KPBAOOGCADH(PILPGHODDIG DCLPNPGHFLG, MHKEFJDKLJN FKMIOMCKJNF, Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x28AD1C0", Offset = "0x28ABDC0", VA = "0x1828AD1C0")]
	private static void DIEMECHABJC(LHNHBKFIDPL AMMNKIJKPDJ, Exception BPFOEEABMGN, [Optional] List<int> JACAFHEHNAG, int ABAHDMMJMOJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x28ADA50", Offset = "0x28AC650", VA = "0x1828ADA50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MLODGCFIPNH))]
	private Task EDNHHFMPDPN(JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, MHKEFJDKLJN FKMIOMCKJNF, OAEILIIIPED LBJHHPLDPCI, FFLEKJBGAJJ AKKJBLMHLIA, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x28AE970", Offset = "0x28AD570", VA = "0x1828AE970")]
	private void HMOBBLALHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x28AF000", Offset = "0x28ADC00", VA = "0x1828AF000")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IPPENAIOHFD))]
	private Task JCNGLBIDPLK(JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x28ADF60", Offset = "0x28ACB60", VA = "0x1828ADF60")]
	private void GHADILLMHAE(MHKEFJDKLJN FKMIOMCKJNF, CancellationToken KHEICKPBIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x28AFB90", Offset = "0x28AE790", VA = "0x1828AFB90")]
	private void MKONBMMDEPH(MHKEFJDKLJN FKMIOMCKJNF, FFLEKJBGAJJ AKKJBLMHLIA, OperationCanceledException ADBKJDGABDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x28AFE50", Offset = "0x28AEA50", VA = "0x1828AFE50")]
	private void NOGAPIEKDIK(MHKEFJDKLJN FKMIOMCKJNF, FFLEKJBGAJJ AKKJBLMHLIA, Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x28AE6D0", Offset = "0x28AD2D0", VA = "0x1828AE6D0")]
	private void HEBPEAEIBII(MHKEFJDKLJN FKMIOMCKJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x28ADC30", Offset = "0x28AC830", VA = "0x1828ADC30")]
	private static NKHBPCPCMLJ FKJINFCCHJK(MHKEFJDKLJN FKMIOMCKJNF)
	{
		return default(NKHBPCPCMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x28AF8D0", Offset = "0x28AE4D0", VA = "0x1828AF8D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ONPEJEJFHPL))]
	private Task LDHEDJCKKNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x28ACF90", Offset = "0x28ABB90", VA = "0x1828ACF90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NJHAKGNJFEK))]
	private Task<Matchmaking.MDKPNMHIPCM> DFLBCCECPHL(MHKEFJDKLJN FKMIOMCKJNF, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x28ADC70", Offset = "0x28AC870", VA = "0x1828ADC70")]
	private static ALKMAGMAGJP GCINHMJMIBO(MHKEFJDKLJN FKMIOMCKJNF, Matchmaking.MDKPNMHIPCM DBNNJNHMJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x28AEAC0", Offset = "0x28AD6C0", VA = "0x1828AEAC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LGAJEOKPIGE))]
	private Task HONKCHJMJNF(MHKEFJDKLJN FKMIOMCKJNF, Matchmaking.MDKPNMHIPCM DBNNJNHMJEO, FFLEKJBGAJJ AKKJBLMHLIA, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken FFDAINFFMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x28ADDC0", Offset = "0x28AC9C0", VA = "0x1828ADDC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NIMIIEEPIHN))]
	private Task GENDOCHGIOJ(MHKEFJDKLJN FKMIOMCKJNF, CancellationTokenSource DNBLDELONJP, Task ACMLNKHHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x28ACC20", Offset = "0x28AB820", VA = "0x1828ACC20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ACPNDFGMPKI))]
	private Task CHALEMKNDHH(LCMHJBMHMJN CMKABAANNAK, EIBOJBKNGCC OOKFEKMLPEH, MHKEFJDKLJN NPDJMDFNEOF, FFLEKJBGAJJ ACHLGGINKLE, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken FJDDBFFNBFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x28AE480", Offset = "0x28AD080", VA = "0x1828AE480")]
	private FFLEKJBGAJJ HDHABNEMDJJ(FFLEKJBGAJJ ACHLGGINKLE, ref CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x28ACE20", Offset = "0x28ABA20", VA = "0x1828ACE20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMDNEALEOMN))]
	private Task CHKBFLMHBLG(JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x28AE310", Offset = "0x28ACF10", VA = "0x1828AE310")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NMPOKEMLAAF))]
	private Task GHEDFKBBANB(MOMCOKAPMLC PHBHEFAPHDL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x28B0110", Offset = "0x28AED10", VA = "0x1828B0110")]
	private static void ONPCOIPELPC(MHKEFJDKLJN FKMIOMCKJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x28AF260", Offset = "0x28ADE60", VA = "0x1828AF260")]
	private void JMHGEGDHJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x28AD130", Offset = "0x28ABD30", VA = "0x1828AD130")]
	private void DFMLOGALDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x28AECA0", Offset = "0x28AD8A0", VA = "0x1828AECA0")]
	private void HONNJFFJNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x28AED30", Offset = "0x28AD930", VA = "0x1828AED30")]
	private void IAEKDAJDLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x28AC8F0", Offset = "0x28AB4F0", VA = "0x1828AC8F0")]
	private static void CDKDGAGHKDN(MHKEFJDKLJN FKMIOMCKJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x28AC830", Offset = "0x28AB430", VA = "0x1828AC830")]
	private static void BNHJKHBFKON(MHKEFJDKLJN FKMIOMCKJNF, CancellationToken FFDAINFFMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x28B06B0", Offset = "0x28AF2B0", VA = "0x1828B06B0")]
	private static void PPIELFOOPOD(MHKEFJDKLJN FKMIOMCKJNF, Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x28AEDC0", Offset = "0x28AD9C0", VA = "0x1828AEDC0")]
	private void IOFDGLJIDCH(MHKEFJDKLJN FKMIOMCKJNF, Task ACMLNKHHEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x28AF170", Offset = "0x28ADD70", VA = "0x1828AF170")]
	private static void JGIMFEIAGIB(Func<string> BAMBEECFNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x28B0940", Offset = "0x28AF540", VA = "0x1828B0940")]
	public FGJHIEFNNDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x28AC7C0", Offset = "0x28AB3C0", VA = "0x1828AC7C0")]
	[CompilerGenerated]
	internal static (int, int?) BEJDIGKINMC(MCJHCEJFKNC EGMEOIADPFI)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MHMLFGJNJKA
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> EGAAIFMLOKP(string OPOLKMBAJBK, long BFNOJMGJLFG, MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class LNLKNBEENCP : CDLOOCIEHKO<FHMBHNPINBI>
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class PDOIMKEBDKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public FHMBHNPINBI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public PDOIMKEBDKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x582DDC0", Offset = "0x582C9C0", VA = "0x18582DDC0")]
		internal object GFMPDMHHECN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly LNLKNBEENCP EABDDJEADPB;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private const string GLOKGMEJOAH = "pl";

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x30A9660", Offset = "0x30A8260", VA = "0x1830A9660")]
	public ExitGames.Client.Photon.Hashtable ECCPKOGLKLF(FHMBHNPINBI DKIECHCHJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x30A9520", Offset = "0x30A8120", VA = "0x1830A9520", Slot = "5")]
	protected override void AENAENLCIAI(FHMBHNPINBI DKIECHCHJFL, IDictionary<object, object> PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x30A9870", Offset = "0x30A8470", VA = "0x1830A9870", Slot = "6")]
	public override FHMBHNPINBI NLJPEOGMFGO(IDictionary<object, object> PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x30A96E0", Offset = "0x30A82E0", VA = "0x1830A96E0")]
	private static void JGIMFEIAGIB(string NOLEELEJNKJ, FHMBHNPINBI DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x30A9AF0", Offset = "0x30A86F0", VA = "0x1830A9AF0")]
	public LNLKNBEENCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x30A9220", Offset = "0x30A7E20", VA = "0x1830A9220")]
	[CompilerGenerated]
	internal static string ACLKACENCGK(LCMHJBMHMJN MEKBNGFFPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FNOEIOAGCPK<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PKJAENHCLMN<byte[], CMPFHAIKIAN>> BJBOOMBCAED(TGetDataArg AIMHDAMIMIL, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PKJAENHCLMN<HCLLLJEDILH<TData>, CMPFHAIKIAN> KCDPDOMNJNH(byte[] PHBHEFAPHDL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DPADKKHLKLF : CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDIFMABCDLA KDJGBCGJOCG(IGGCDPKBFGF AOLFPABEEKC);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class FENLOLGCABO : JHDNGKJANJJ, CCNJKCGJAJP, GNOLCLOPLMD, CAJCLGONHEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly CCNJKCGJAJP OMBHPIGDLKI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IGGCDPKBFGF AGOBILJIDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28AB0D0", Offset = "0x28A9CD0", VA = "0x1828AB0D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NFFGMOGMHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x28AB180", Offset = "0x28A9D80", VA = "0x1828AB180", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KEPCAECPIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x28AAD50", Offset = "0x28A9950", VA = "0x1828AAD50", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool LHAPCIJBDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D00", Offset = "0x7F4900", VA = "0x1807F5D00", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int CIFGLBNPOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event CPDEDBIILFH.OFBOMJAMPKF HAHFPDLJMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event FJKGHOIPBKO HGAIJHBEINL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28AB030", Offset = "0x28A9C30", VA = "0x1828AB030", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28AADA0", Offset = "0x28A99A0", VA = "0x1828AADA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> IOFGIAHKHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<IGGCDPKBFGF> AEKDKGLIMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action OKONGAFFGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28AABB0", Offset = "0x28A97B0", VA = "0x1828AABB0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28AAE40", Offset = "0x28A9A40", VA = "0x1828AAE40", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xD51F30", Offset = "0xD50B30", VA = "0x180D51F30")]
	public FENLOLGCABO(CCNJKCGJAJP OMBHPIGDLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x28AAF80", Offset = "0x28A9B80", VA = "0x1828AAF80", Slot = "8")]
	public bool OAMKKLLHMCJ(byte PJPMIHPOMIA, ExitGames.Client.Photon.Hashtable LPNMAPPAKIO, EBKGAFDELBK NAOEDGLNDNC, SendOptions PPCDNDPNNDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x28AAEE0", Offset = "0x28A9AE0", VA = "0x1828AAEE0", Slot = "29")]
	public IGGCDPKBFGF LOOGDOFAGGL(int KEAMKJPMALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x28AAC50", Offset = "0x28A9850", VA = "0x1828AAC50", Slot = "16")]
	public IGGCDPKBFGF DNGDHJDCGCA(int AGMAMFDBLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "19")]
	public void ILNAGFHCFLP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "20")]
	public void BBNPAOAMKNC(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "21")]
	public void GBOFAFGNPKK(object FLDJLPKNKKO, bool ALPKOFENEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x28AB120", Offset = "0x28A9D20", VA = "0x1828AB120", Slot = "22")]
	public IDisposable PAOHMNBKIOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CA0", Offset = "0x7F48A0", VA = "0x1807F5CA0", Slot = "23")]
	private bool CGEGBBJAMFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "24")]
	public void LNOIMNGJBMF(StringBuilder OJPAJPKNCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x28AAD30", Offset = "0x28A9930", VA = "0x1828AAD30", Slot = "25")]
	public bool FKEFOKOCIDM(bool INOACBMBDNM, out string FKPBDLDGFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public void AHKBAGIPMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x13B8E40", Offset = "0x13B7A40", VA = "0x1813B8E40", Slot = "28")]
	public void CCOFHBPEINO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal struct KJLLMJJEGBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly TaskCompletionSource<(IDIFMABCDLA, Task)> JAGALAEBKOD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Task<(IDIFMABCDLA, Task)> KCIAOCJILBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x30A63D0", Offset = "0x30A4FD0", VA = "0x1830A63D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x30A6580", Offset = "0x30A5180", VA = "0x1830A6580")]
	public KJLLMJJEGBB(TimeSpan OJHABJHLHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x30A62E0", Offset = "0x30A4EE0", VA = "0x1830A62E0")]
	public void CIPLADFKIMB(Task OIDBJIACCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x30A6410", Offset = "0x30A5010", VA = "0x1830A6410")]
	public void EHBECJGDFJG(IDIFMABCDLA NPAEKAKKGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x30A6530", Offset = "0x30A5130", VA = "0x1830A6530")]
	public void MHDHMJHADME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x30A64A0", Offset = "0x30A50A0", VA = "0x1830A64A0")]
	internal void FEEBNMABKGC(string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class MCGNJCCHDHF : MHPAJLBPAGC, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private bool OJPMHILIPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GOMGBFEPMOD ALNIEHFFCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private AIMHFJMEAKL CEHJOFICIAM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GOMGBFEPMOD PFLGINGMBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x30AA960", Offset = "0x30A9560", VA = "0x1830AA960", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x30AA9D0", Offset = "0x30A95D0", VA = "0x1830AA9D0", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x30AA720", Offset = "0x30A9320", VA = "0x1830AA720", Slot = "5")]
	public void DGGMFLBIDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x30AA6E0", Offset = "0x30A92E0", VA = "0x1830AA6E0", Slot = "6")]
	public void ALFOAEHHOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x30AA8E0", Offset = "0x30A94E0", VA = "0x1830AA8E0")]
	private Task JGBBPKBNPBD(MLLLMININAO HDCPFIKNJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x30AA6E0", Offset = "0x30A92E0", VA = "0x1830AA6E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1110480", Offset = "0x110F080", VA = "0x181110480")]
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
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public IFNNJAAOEDN manager;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NJKBNBHFCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4631170", Offset = "0x462FD70", VA = "0x184631170")]
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
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public FBJPNKAEOIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private HCKACEFMPCF <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private JLOOFCOEEHE <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private JLOOFCOEEHE <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private JLOOFCOEEHE <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter<JLOOFCOEEHE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter<IDIFMABCDLA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BDJKMKOJHND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x461FEA0", Offset = "0x461EAA0", VA = "0x18461FEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public FBJPNKAEOIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public OLLCODFLLBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4631CA0", Offset = "0x46308A0", VA = "0x184631CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly CancellationToken GFFFFCALMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly IFNNJAAOEDN GAICNONPFPG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private EPJFONLPCOB HOCOJIBIFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x28AA720", Offset = "0x28A9320", VA = "0x1828AA720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x28AAB20", Offset = "0x28A9720", VA = "0x1828AAB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28AA890", Offset = "0x28A9490", VA = "0x1828AA890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private NABGKEIJMLK ILDDDNKPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x28AA320", Offset = "0x28A8F20", VA = "0x1828AA320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x28AAB70", Offset = "0x28A9770", VA = "0x1828AAB70")]
	public FBJPNKAEOIC(CancellationToken GFFFFCALMCA, IFNNJAAOEDN GAICNONPFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x28AA670", Offset = "0x28A9270", VA = "0x1828AA670")]
	public static NDLLDLNNGKD GBOIJDALJEA(IFNNJAAOEDN GAICNONPFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x28AA520", Offset = "0x28A9120", VA = "0x1828AA520")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BDJKMKOJHND))]
	public Task<bool> EBDHDHCPNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x28AA910", Offset = "0x28A9510", VA = "0x1828AA910")]
	private bool LDNEGFOJHDC(out HCKACEFMPCF ANGBHDDNJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x28AA770", Offset = "0x28A9370", VA = "0x1828AA770")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OLLCODFLLBB))]
	private Task KIKPDFAMBCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x28AA370", Offset = "0x28A8F70", VA = "0x1828AA370")]
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
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly LALKFIOPJMN HNFNHEGHMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly string BDFCACLHAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly T IGBKLJLDCLC;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T MHGNIJCIFFL
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7F5CB0", Offset = "0x7F48B0", VA = "0x1807F5CB0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x913A80", Offset = "0x912680", VA = "0x180913A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x32B1010", Offset = "0x32AFC10", VA = "0x1832B1010")]
		public FFKLCHMOGNH(LALKFIOPJMN HNFNHEGHMIL, string BDFCACLHAFA, T IGBKLJLDCLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x32B0B50", Offset = "0x32AF750", VA = "0x1832B0B50")]
		private void ODJBEAKLNPD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly LALKFIOPJMN HNFNHEGHMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly FFKLCHMOGNH<TimeSpan> AKNBKBCEEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly FFKLCHMOGNH<TimeSpan> PPGIMDGJPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly FFKLCHMOGNH<TimeSpan> CHOEAEJFIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly FFKLCHMOGNH<TimeSpan> DCIICEAAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly FFKLCHMOGNH<bool> ONGAONCHJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly FFKLCHMOGNH<bool> DFIOOFAGDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly FFKLCHMOGNH<bool> OJACFMKGPMF;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const string PECMMBBBANO = "RoomLoadCameraFadeTimeout";

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan LHJNNILLFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x28BC7B0", Offset = "0x28BB3B0", VA = "0x1828BC7B0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan EPCMOJLJLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x28BC5E0", Offset = "0x28BB1E0", VA = "0x1828BC5E0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public TimeSpan DAOBFAELEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x28BC870", Offset = "0x28BB470", VA = "0x1828BC870", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public TimeSpan DPGCFHMEEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x28BC7F0", Offset = "0x28BB3F0", VA = "0x1828BC7F0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool OFDCHEPEDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x28BC770", Offset = "0x28BB370", VA = "0x1828BC770", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HKOPKHIHGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x28BC8B0", Offset = "0x28BB4B0", VA = "0x1828BC8B0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool JFNNLIFPDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x28BC830", Offset = "0x28BB430", VA = "0x1828BC830", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool BJCOOEOHCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28BC8F0", Offset = "0x28BB4F0", VA = "0x1828BC8F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TimeSpan MHNHPDJHJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x28BC620", Offset = "0x28BB220", VA = "0x1828BC620", Slot = "12")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x28BC9F0", Offset = "0x28BB5F0", VA = "0x1828BC9F0")]
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
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public EMOAKECFAIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MKOIIBEAJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x462D960", Offset = "0x462C560", VA = "0x18462D960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly CancellationTokenSource MFGBDLCLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private Task GAKDIIFBLNI;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JDGGFLPNGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x28A8D30", Offset = "0x28A7930", VA = "0x1828A8D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal Task KCIAOCJILBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x28A8B00", Offset = "0x28A7700", VA = "0x1828A8B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x28A8D60", Offset = "0x28A7960", VA = "0x1828A8D60")]
	public EMOAKECFAIC(CancellationToken GFFFFCALMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x28A8B80", Offset = "0x28A7780", VA = "0x1828A8B80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MKOIIBEAJME))]
	public Task DNJBHLPIBHG(Func<CancellationToken, List<Task>> GMABPDCFFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x28A8CE0", Offset = "0x28A78E0", VA = "0x1828A8CE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal interface MFHIJBENPCO : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIHFEMBJCAM CAILCKFFJIK(Guid PALLEDHBFCO);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CPPHPNNFPKL(Guid PALLEDHBFCO);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LPGMNPDMPPM(Guid PALLEDHBFCO, Task OIDBJIACCJK);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JJNOGDGBEML(Guid PALLEDHBFCO, IDIFMABCDLA GCGJMEIHMMI);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IHLPPHPEFDP(Guid PALLEDHBFCO);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(IDIFMABCDLA, Task)> PDGJMOLMFLF(Guid PALLEDHBFCO);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal interface EPOJINPDBDE : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDIFMABCDLA NMBCIPOHMGE(IGGCDPKBFGF AEEBHLKEAKN, DLLMEMMHNCB GOKELOIKDPH);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDIFMABCDLA GOENMAPECNC(IGGCDPKBFGF AOLFPABEEKC);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
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
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public JCBCMHDOCKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private MHKEFJDKLJN <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private MHKEFJDKLJN <newPresenceRoomInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private float <timeoutTime>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JPJGKAFGNII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3E17870", Offset = "0x3E16470", VA = "0x183E17870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private const float DEKHCELCOFE = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x28BD9E0", Offset = "0x28BC5E0", VA = "0x1828BD9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x9138A0", Offset = "0x9124A0", VA = "0x1809138A0")]
	public JCBCMHDOCKC(IFNNJAAOEDN FNIFBLHBOOE, HBPPPIGEKFO FGOMHOJPKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x28BD870", Offset = "0x28BC470", VA = "0x1828BD870", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JPJGKAFGNII))]
	public Task<bool> BFAINGMPNNG(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x28BD790", Offset = "0x28BC390", VA = "0x1828BD790")]
	[CompilerGenerated]
	private object AFGHHJNLKAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal interface BNEJDHEIHAG : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEBINCHJHOA(FHMBHNPINBI DKIECHCHJFL);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADAEPOMFIHE(FHMBHNPINBI DKIECHCHJFL);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<DLLMEMMHNCB> ADEHAOCABJJ(CancellationToken BOPCGMCIPKA);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal interface NNIOHMBOJFJ : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDIFMABCDLA IGGGLNHPCKG(IGGCDPKBFGF AEEBHLKEAKN);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
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
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public KNOCBGHMKHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GFJNNKLOBOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3E13560", Offset = "0x3E12160", VA = "0x183E13560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly PKHKKGNCOIB GEEPKHIECCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private string ACCFGKLOJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private Task NOAJBFJBLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool JHKJEJHMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x30A6910", Offset = "0x30A5510", VA = "0x1830A6910", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Task NLFPKAMNLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x30A66F0", Offset = "0x30A52F0", VA = "0x1830A66F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7F3400", Offset = "0x7F2000", VA = "0x1807F3400", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x30A6750", Offset = "0x30A5350", VA = "0x1830A6750", Slot = "6")]
	public void IHJNMAOMFMN(Task GAKDIIFBLNI, string NNLMNOOEFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x30A6940", Offset = "0x30A5540", VA = "0x1830A6940")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFJNNKLOBOH))]
	private Task NIKHFNEOBOB(Task PAIGDLJPPOE, string NNLMNOOEFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x30A6AB0", Offset = "0x30A56B0", VA = "0x1830A6AB0")]
	public KNOCBGHMKHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal struct LIHFEMBJCAM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly MFHIJBENPCO GAOOEGMBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Guid PALLEDHBFCO;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private Task<(IDIFMABCDLA, Task)> KCIAOCJILBB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x30A8E30", Offset = "0x30A7A30", VA = "0x1830A8E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x29AEB80", Offset = "0x29AD780", VA = "0x1829AEB80")]
	public LIHFEMBJCAM(MFHIJBENPCO GAOOEGMBKDI, Guid PALLEDHBFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x30A8DE0", Offset = "0x30A79E0", VA = "0x1830A8DE0")]
	public TaskAwaiter<(IDIFMABCDLA, Task)> CIAALDMCOFJ()
	{
		return default(TaskAwaiter<(IDIFMABCDLA, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x30A8F00", Offset = "0x30A7B00", VA = "0x1830A8F00", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public HCKACEFMPCF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private JAPPGKMKBNF<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ALJGLPODJGB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private LCMHJBMHMJN <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private IDIFMABCDLA <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter<IDIFMABCDLA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HDOOGEFGAKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x582A3B0", Offset = "0x5828FB0", VA = "0x18582A3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private CancellationTokenSource <combinedTokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public EPJKAFEBOKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x5828B20", Offset = "0x5827720", VA = "0x185828B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public MOMCOKAPMLC _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KKFLPLBDBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x582C5E0", Offset = "0x582B1E0", VA = "0x18582C5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private object <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JLGLICOEPGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x582BA70", Offset = "0x582A670", VA = "0x18582BA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CICIJAPOENM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5827D20", Offset = "0x5826920", VA = "0x185827D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private CancellationToken <nextAutosaveToken>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GCBGNPMKGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5829990", Offset = "0x5828590", VA = "0x185829990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Task <delayTask>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Task<int> <intervalChangedTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private Task <resultTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ICJDJKIENIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x582AAA0", Offset = "0x58296A0", VA = "0x18582AAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public PCFPIMKAMML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private JAPPGKMKBNF<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private FFLEKJBGAJJ <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private MKKIMDKIEJP <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FICOEMBJGAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x58291F0", Offset = "0x5827DF0", VA = "0x1858291F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private KHCNMJFIKHK MNLFCPGNLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private HLDCIPKGMNF CPNGNGPKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private OCAOCNCNOCD OFFFKIOLLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private CancellationTokenSource BDLOFKHMIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Task EDJMJBBPCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private TaskCompletionSource<int> OKINEKEIMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int DKIEPMHFCAG;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x30B7450", Offset = "0x30B6050", VA = "0x1830B7450", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x196D7F0", Offset = "0x196C3F0", VA = "0x18196D7F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x30B7610", Offset = "0x30B6210", VA = "0x1830B7610")]
	private void PKHJGPDGHIO(float BOKAAPCLKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x30B72E0", Offset = "0x30B5EE0", VA = "0x1830B72E0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDOOGEFGAKK))]
	public Task<IDIFMABCDLA> MFMFNNPHECC(HCKACEFMPCF ANGBHDDNJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x30B7080", Offset = "0x30B5C80", VA = "0x1830B7080", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EPJKAFEBOKG))]
	public Task HNCAHLLFAMO([Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x196D7F0", Offset = "0x196C3F0", VA = "0x18196D7F0")]
	public void DGNGNPHOEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x30B6960", Offset = "0x30B5560", VA = "0x1830B6960")]
	private ALJGLPODJGB CLANGIJCAOF(HCKACEFMPCF ANGBHDDNJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x30B6C70", Offset = "0x30B5870", VA = "0x1830B6C70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KKFLPLBDBOP))]
	private Task EMEAJHNFMGH(MOMCOKAPMLC HDCPFIKNJDE, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x30B6F30", Offset = "0x30B5B30", VA = "0x1830B6F30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JLGLICOEPGP))]
	private Task HBFDLFFGEBD(CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x30B76F0", Offset = "0x30B62F0", VA = "0x1830B76F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CICIJAPOENM))]
	private Task PMDEJGJJLLE([Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x30B6DE0", Offset = "0x30B59E0", VA = "0x1830B6DE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GCBGNPMKGGH))]
	private Task FLHICCLHICH(CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x30B6B20", Offset = "0x30B5720", VA = "0x1830B6B20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ICJDJKIENIC))]
	private Task EGIKIACONDF(CancellationToken DEEKJILKBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x30B6550", Offset = "0x30B5150", VA = "0x1830B6550")]
	private Task BPMPGNBFDLE(NFBLDIHAPOJ GJGJDNGPKAK, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x30B6800", Offset = "0x30B5400", VA = "0x1830B6800")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FICOEMBJGAE))]
	private Task CBIGMEGDJGJ(NFBLDIHAPOJ GJGJDNGPKAK, CancellationToken KHEICKPBIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x30B71D0", Offset = "0x30B5DD0", VA = "0x1830B71D0")]
	private bool IGGGLNHPCKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PCFPIMKAMML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface BEIIGIJBNMM : CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
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
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly MHKEFJDKLJN PDOICCGDHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly CancellationTokenSource MFGBDLCLLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public readonly CancellationToken PIIFHPDGBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private bool HPPBEFJNGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private bool GHKACLCDPMJ;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3E18110", Offset = "0x3E16D10", VA = "0x183E18110")]
		public KFJIDCBJEFK(MHKEFJDKLJN PDOICCGDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3E17FC0", Offset = "0x3E16BC0", VA = "0x183E17FC0")]
		public void IHLPPHPEFDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3E17F90", Offset = "0x3E16B90", VA = "0x183E17F90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class FIDMHFNFGNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public MLLLMININAO disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FIDMHFNFGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E11D00", Offset = "0x3E10900", VA = "0x183E11D00")]
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
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public MLLLMININAO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public JNJGFBGKBIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private FIDMHFNFGNA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DMOFBHCHBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3E10F70", Offset = "0x3E0FB70", VA = "0x183E10F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FDMKICDEDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E11C90", Offset = "0x3E10890", VA = "0x183E11C90")]
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
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public JNJGFBGKBIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private FDMKICDEDAC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private IDisposable <logFlagsScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IDisposable <logTraceScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private IDisposable <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private MHKEFJDKLJN <newRoomInstance>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private OAEILIIIPED <customRoomLoadPayload>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DCMGLEHEFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F340", Offset = "0x3E0DF40", VA = "0x183E0F340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public MHKEFJDKLJN newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BDNIIEFOFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E060", Offset = "0x3E0CC60", VA = "0x183E0E060")]
		internal object BMAGCEHEPGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E020", Offset = "0x3E0CC20", VA = "0x183E0E020")]
		internal object AFNKKANDJLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E100", Offset = "0x3E0CD00", VA = "0x183E0E100")]
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
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CDBIIFDDICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E430", Offset = "0x3E0D030", VA = "0x183E0E430")]
		internal void FOBCGGDKIGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MPNGNLJHLLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public MHKEFJDKLJN newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public OAEILIIIPED customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public JNJGFBGKBIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private BDNIIEFOFDF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private CDBIIFDDICB <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private CancellationToken <token>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private OperationCanceledException <oce>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MPNGNLJHLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3E1BE90", Offset = "0x3E1AA90", VA = "0x183E1BE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private GHOMLKKKKHM IIJBBPIGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private LFPKDNNPHDE MOCPAILNIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private AIMHFJMEAKL CEHJOFICIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private LKGOGFHLDFK HBHHBLLKCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private long HLICAKNNGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private KFJIDCBJEFK JICPGBHCLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool CJKOLCPINHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private Task OEAHMGOHKCA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x28BFCA0", Offset = "0x28BE8A0", VA = "0x1828BFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool IPGOLLBDNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1324150", Offset = "0x1322D50", VA = "0x181324150")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x28BF6E0", Offset = "0x28BE2E0", VA = "0x1828BF6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x28BFD30", Offset = "0x28BE930", VA = "0x1828BFD30", Slot = "4")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x28BF040", Offset = "0x28BDC40", VA = "0x1828BF040", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x28BFFE0", Offset = "0x28BEBE0", VA = "0x1828BFFE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DMOFBHCHBLK))]
	private Task PBGICECDOOI(MLLLMININAO PNDKKGJBMGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x28BFA80", Offset = "0x28BE680", VA = "0x1828BFA80")]
	private void KAGCKBPPEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x28BF350", Offset = "0x28BDF50", VA = "0x1828BF350")]
	private void ECKGLJKBMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x28BECB0", Offset = "0x28BD8B0", VA = "0x1828BECB0")]
	private void BNPEMOOLAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x28BF660", Offset = "0x28BE260", VA = "0x1828BF660")]
	private bool GIDDGKKCPGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x28BF570", Offset = "0x28BE170", VA = "0x1828BF570")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DCMGLEHEFDK))]
	private void EOGPFIDDBOJ(int FNPPFCMGJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x28BF6F0", Offset = "0x28BE2F0", VA = "0x1828BF6F0")]
	private void IHHBAHINIHN(out IDisposable AHOOBICBHLF, out IDisposable MAPJNBGOHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x28BF1C0", Offset = "0x28BDDC0", VA = "0x1828BF1C0")]
	private bool ECCGBFBELIE(MHKEFJDKLJN PDOICCGDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x28BFCF0", Offset = "0x28BE8F0", VA = "0x1828BFCF0")]
	private void MNCMHDBGGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x28BEED0", Offset = "0x28BDAD0", VA = "0x1828BEED0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MPNGNLJHLLA))]
	private Task CGIPLDAAFAH(MHKEFJDKLJN PDOICCGDHHF, OAEILIIIPED LBJHHPLDPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x28C0120", Offset = "0x28BED20", VA = "0x1828C0120")]
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
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GAGCOKAHLMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5829920", Offset = "0x5828520", VA = "0x185829920")]
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
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LBKJJHGCJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x582C970", Offset = "0x582B570", VA = "0x18582C970")]
		internal object EGFDMPEONFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private EPOJINPDBDE KELDMIFJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private BNEJDHEIHAG KEJOJLBJLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private MFHIJBENPCO GAOOEGMBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private NJCAGKAOHPF DOOFDPAIBFA;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x30B15D0", Offset = "0x30B01D0", VA = "0x1830B15D0", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x30AF3D0", Offset = "0x30ADFD0", VA = "0x1830AF3D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x30AFD60", Offset = "0x30AE960", VA = "0x1830AFD60", Slot = "4")]
	public LIHFEMBJCAM KEABJGIDHIP(FHMBHNPINBI BOBCMCAMEBH)
	{
		return default(LIHFEMBJCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x30B0860", Offset = "0x30AF460", VA = "0x1830B0860", Slot = "5")]
	public void MBDNCJBLALE(Guid PALLEDHBFCO, Task OIDBJIACCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x30AFC90", Offset = "0x30AE890", VA = "0x1830AFC90")]
	private void HJHGFNHOHPM(byte PJPMIHPOMIA, int OEOGPLHHBJF, object FNPKKBLOKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x30B0E10", Offset = "0x30AFA10", VA = "0x1830B0E10")]
	private void OPFLAMIDEKC(GDNNMLKFEHK CBLNAPKAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x30B0260", Offset = "0x30AEE60", VA = "0x1830B0260")]
	private void KJCGJKABNCF(GDNNMLKFEHK CBLNAPKAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x30AF6D0", Offset = "0x30AE2D0", VA = "0x1830AF6D0")]
	private void GFJCEIANGPO(GDNNMLKFEHK CBLNAPKAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x30B0AF0", Offset = "0x30AF6F0", VA = "0x1830B0AF0")]
	private IDIFMABCDLA OGNDPHAOHLC(FHMBHNPINBI IFPNDMLIDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x30AF470", Offset = "0x30AE070", VA = "0x1830AF470")]
	private void ELDMIMPBLPI(FHMBHNPINBI KAMKHOFOCLH, IDIFMABCDLA NPAEKAKKGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x30AF170", Offset = "0x30ADD70", VA = "0x1830AF170")]
	private bool AEJOMOPEPHO(FHMBHNPINBI KAMKHOFOCLH, IDIFMABCDLA NPAEKAKKGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x30AF9A0", Offset = "0x30AE5A0", VA = "0x1830AF9A0")]
	private bool GLPONHOOAHJ(FHMBHNPINBI CFDLOODJELF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x30B0550", Offset = "0x30AF150", VA = "0x1830B0550")]
	private bool KNPDFGFDOIA(byte PJPMIHPOMIA, ExitGames.Client.Photon.Hashtable CBLNAPKAJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
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
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder<DLLMEMMHNCB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private DLLMEMMHNCB <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter<DLLMEMMHNCB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KFEFGGLPGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x30A5B70", Offset = "0x30A4770", VA = "0x1830A5B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public FHMBHNPINBI message;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BMDICGNLCND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x30A0080", Offset = "0x309EC80", VA = "0x1830A0080")]
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
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public FHMBHNPINBI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IHCKFCKFJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x30A2DB0", Offset = "0x30A19B0", VA = "0x1830A2DB0")]
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
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public OGFHCAIIDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x30B2F10", Offset = "0x30B1B10", VA = "0x1830B2F10")]
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
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private OGFHCAIIDIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private OOCGABPOHBK <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private OOCGABPOHBK <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter<OOCGABPOHBK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GFKNMMHGBNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x30A26B0", Offset = "0x30A12B0", VA = "0x1830A26B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public FHMBHNPINBI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LNKNCCKFBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x30A9050", Offset = "0x30A7C50", VA = "0x1830A9050")]
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
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public FHMBHNPINBI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private LNKNCCKFBNK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private FFLEKJBGAJJ <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private FHMBHNPINBI <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private OOCGABPOHBK <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private FHMBHNPINBI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LFHIHKJIFGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x30A8050", Offset = "0x30A6C50", VA = "0x1830A8050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder<OOCGABPOHBK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private FFLEKJBGAJJ <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private FHMBHNPINBI <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private FHMBHNPINBI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DAMOLBBFHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x30A10F0", Offset = "0x309FCF0", VA = "0x1830A10F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public OOCGABPOHBK operation;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LMBNFMHCKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x30A8FD0", Offset = "0x30A7BD0", VA = "0x1830A8FD0")]
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
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public OOCGABPOHBK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public CKMOEBJAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private LMBNFMHCKPG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private JAPPGKMKBNF<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public EJEBGKCEFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x30A15F0", Offset = "0x30A01F0", VA = "0x1830A15F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GDGIGHPPLCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x30A2650", Offset = "0x30A1250", VA = "0x1830A2650")]
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
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IOBLMKPDMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x30A32D0", Offset = "0x30A1ED0", VA = "0x1830A32D0")]
		internal object GJKPHIKGMAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private HLDCIPKGMNF CPNGNGPKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private MFLEOODBFAO ABDILMEFOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private KHCNMJFIKHK MNLFCPGNLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private TaskCompletionSource<DLLMEMMHNCB> LDDHDADPIHD;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x28A5270", Offset = "0x28A3E70", VA = "0x1828A5270", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x28A3F00", Offset = "0x28A2B00", VA = "0x1828A3F00", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KFEFGGLPGCA))]
	public Task<DLLMEMMHNCB> ADEHAOCABJJ(CancellationToken BOPCGMCIPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x28A46A0", Offset = "0x28A32A0", VA = "0x1828A46A0", Slot = "4")]
	public void KEBINCHJHOA(FHMBHNPINBI DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x28A3AD0", Offset = "0x28A26D0", VA = "0x1828A3AD0", Slot = "5")]
	public void ADAEPOMFIHE(FHMBHNPINBI FNLNAMAPIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x28A4070", Offset = "0x28A2C70", VA = "0x1828A4070")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFKNMMHGBNC))]
	private Task ALKKOEOLHIB(FHMBHNPINBI PAJPFFIMEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x28A4550", Offset = "0x28A3150", VA = "0x1828A4550")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LFHIHKJIFGM))]
	private Task HMNJGHCJEIK(FHMBHNPINBI KAMKHOFOCLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x28A4240", Offset = "0x28A2E40", VA = "0x1828A4240")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DAMOLBBFHIJ))]
	private Task<OOCGABPOHBK> BLJCKJJIGLC(FHMBHNPINBI PAJPFFIMEFB, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x28A41C0", Offset = "0x28A2DC0", VA = "0x1828A41C0")]
	private FFLEKJBGAJJ APOFHGHCMEO(FHMBHNPINBI IFPNDMLIDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x28A43E0", Offset = "0x28A2FE0", VA = "0x1828A43E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJEBGKCEFID))]
	private Task HIMPBLOIKAI(OOCGABPOHBK CDJHLNAAHGK, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x28A4FD0", Offset = "0x28A3BD0", VA = "0x1828A4FD0")]
	private OOCGABPOHBK LNJLMLOCPIM(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FC00", Offset = "0x2C6E800", VA = "0x182C6FC00")]
	private T FPDLJJIJEGK<T>(T ECNGHFJBIJL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x28A4B00", Offset = "0x28A3700", VA = "0x1828A4B00")]
	private OOCGABPOHBK LFPGJKOEKLO(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public CKMOEBJAOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x28A4F80", Offset = "0x28A3B80", VA = "0x1828A4F80")]
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
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	TimeSpan EPCMOJLJLIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TimeSpan DAOBFAELEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	TimeSpan DPGCFHMEEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OFDCHEPEDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool HKOPKHIHGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool JFNNLIFPDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool BJCOOEOHCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	TimeSpan MHNHPDJHJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal interface BNBOHDAMFHI : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LCMHJBMHMJN> KAELPKDAAHM(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, MHKEFJDKLJN FKMIOMCKJNF, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class GMAMNIGHIIF : HMAILMDEICE
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class IDMNADHAMAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public GMAMNIGHIIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public Matchmaking.PAFIILGBNBC result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public MHKEFJDKLJN newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IDMNADHAMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3E15450", Offset = "0x3E14050", VA = "0x183E15450")]
		internal object COFPDFNHHKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3E15640", Offset = "0x3E14240", VA = "0x183E15640")]
		internal object KHDMMCIHEGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3E155A0", Offset = "0x3E141A0", VA = "0x183E155A0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public GMAMNIGHIIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private IDMNADHAMAP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private Matchmaking.PAFIILGBNBC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter<Matchmaking.PAFIILGBNBC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IKBJOJBJOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3E15740", Offset = "0x3E14340", VA = "0x183E15740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private const float DEKHCELCOFE = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x28B4FA0", Offset = "0x28B3BA0", VA = "0x1828B4FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x9138A0", Offset = "0x9124A0", VA = "0x1809138A0")]
	public GMAMNIGHIIF(IFNNJAAOEDN FNIFBLHBOOE, HBPPPIGEKFO FGOMHOJPKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x28B4E30", Offset = "0x28B3A30", VA = "0x1828B4E30", Slot = "4")]
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
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> BFAINGMPNNG(CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface JHPGNCLFEFD
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKJGCJELDBJ(LHNHBKFIDPL CDOIPBLLOCN);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MANOAIPGPIB(LHNHBKFIDPL CDOIPBLLOCN);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNIOAJEFAAL(LHNHBKFIDPL CDOIPBLLOCN);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FDHPCIGKKHH(LHNHBKFIDPL CDOIPBLLOCN);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LHNHBKFIDPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public readonly MHKEFJDKLJN BGMGCNGONPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private Dictionary<string, string> LOJDMHGAGAM;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public JAPPGKMKBNF<string> KCGIIBMNCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x85E2C0", Offset = "0x85CEC0", VA = "0x18085E2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
	public LHNHBKFIDPL(MHKEFJDKLJN BIJBNMHAAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x30A8D10", Offset = "0x30A7910", VA = "0x1830A8D10")]
	public LHNHBKFIDPL MNMFBAAJDPG(string BDFCACLHAFA, string ECNGHFJBIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x30A8C90", Offset = "0x30A7890", VA = "0x1830A8C90")]
	public bool JBNLINMGPLP(out IEnumerable<KeyValuePair<string, string>> OJGHOIDDGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DEF0", Offset = "0x2A6CAF0", VA = "0x182A6DEF0")]
	public LHNHBKFIDPL DCEKJEKIOJL(JAPPGKMKBNF<string> IDIJCJCNEPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class DLKHPEAIEMF : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x13C34A0", Offset = "0x13C20A0", VA = "0x1813C34A0")]
	public DLKHPEAIEMF(string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
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
[Cpp2IlInjected.Token(Token = "0x200007E")]
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
	DNKNJNMAMBL PNKJHFEMMMK(OOCGABPOHBK BCJOJLPDGAD, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DNKNJNMAMBL HHEJOOPBBPE(OOCGABPOHBK BCJOJLPDGAD, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class HAIGOHNCBOK : IFNNJAAOEDN, NCFBJHOACDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class AOJGMFMCJFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public HCKACEFMPCF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public HAIGOHNCBOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private IDIFMABCDLA <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private IDIFMABCDLA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter<IDIFMABCDLA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public AOJGMFMCJFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D090", Offset = "0x3E0BC90", VA = "0x183E0D090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class DIINOIAAFOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public HAIGOHNCBOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private IDIFMABCDLA <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DIINOIAAFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3E10860", Offset = "0x3E0F460", VA = "0x183E10860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class OOMBEOLIPME : IEnumerable<KKHNJDMOGHC>, IEnumerable, IEnumerator<KKHNJDMOGHC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private KKHNJDMOGHC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public HAIGOHNCBOK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private KKHNJDMOGHC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xC9F550", Offset = "0xC9E150", VA = "0x180C9F550")]
		[DebuggerHidden]
		public OOMBEOLIPME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E380", Offset = "0x3E1CF80", VA = "0x183E1E380", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E800", Offset = "0x3E1D400", VA = "0x183E1E800", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E760", Offset = "0x3E1D360", VA = "0x183E1E760", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KKHNJDMOGHC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E760", Offset = "0x3E1D360", VA = "0x183E1E760", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly CancellationTokenSource EOFDJDMKNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private readonly MHOBEFMLEFD JMIFLNNGBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private MMBBPNPCMOA PKFPFKNCCLP;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public EPJFONLPCOB HOCOJIBIFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x839070", Offset = "0x837C70", VA = "0x180839070", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8C60B0", Offset = "0x8C4CB0", VA = "0x1808C60B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public GHOMLKKKKHM JMGHKJIPIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8390A0", Offset = "0x837CA0", VA = "0x1808390A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x888F10", Offset = "0x887B10", VA = "0x180888F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x839080", Offset = "0x837C80", VA = "0x180839080", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x888F20", Offset = "0x887B20", VA = "0x180888F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public KDHGMPHKPAM MAEKOJNKJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x839090", Offset = "0x837C90", VA = "0x180839090", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x888F00", Offset = "0x887B00", VA = "0x180888F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DPADKKHLKLF PBNEJPFKDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x839010", Offset = "0x837C10", VA = "0x180839010", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x84B170", Offset = "0x849D70", VA = "0x18084B170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BEIIGIJBNMM EHLIDEAPHLB
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x839020", Offset = "0x837C20", VA = "0x180839020", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x85A6F0", Offset = "0x8592F0", VA = "0x18085A6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public KFDAFKKLOKJ GCFMGMKCIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x85F070", Offset = "0x85DC70", VA = "0x18085F070", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x85A6D0", Offset = "0x8592D0", VA = "0x18085A6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public HLDCIPKGMNF ANJLCFPEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x9A4AD0", Offset = "0x9A36D0", VA = "0x1809A4AD0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x8855D0", VA = "0x1808869D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NABGKEIJMLK ILDDDNKPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x886AE0", Offset = "0x8856E0", VA = "0x180886AE0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9F1260", Offset = "0x9EFE60", VA = "0x1809F1260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LEHKMPCAGKL LBBBKNCGGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x85F040", Offset = "0x85DC40", VA = "0x18085F040", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA5B070", Offset = "0xA59C70", VA = "0x180A5B070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public LFPKDNNPHDE DGJOFOIFJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x839030", Offset = "0x837C30", VA = "0x180839030", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8592E0", VA = "0x18085A6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LKGOGFHLDFK JFMCLHOMNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x839040", Offset = "0x837C40", VA = "0x180839040", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x87FAE0", Offset = "0x87E6E0", VA = "0x18087FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public OCAOCNCNOCD MOPGLPOHIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x839060", Offset = "0x837C60", VA = "0x180839060", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9A4D50", Offset = "0x9A3950", VA = "0x1809A4D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public MFHIJBENPCO DHPNGFEFNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x839050", Offset = "0x837C50", VA = "0x180839050", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x85A700", Offset = "0x859300", VA = "0x18085A700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public ANJBBNMCECI JPIDCLGLMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1100", VA = "0x1809A2500", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9A2BF0", Offset = "0x9A17F0", VA = "0x1809A2BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public BNEJDHEIHAG OCHGGKGDJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9262A0", Offset = "0x924EA0", VA = "0x1809262A0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9A2510", Offset = "0x9A1110", VA = "0x1809A2510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public MFLEOODBFAO IEAEMFIFNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x882A10", Offset = "0x881610", VA = "0x180882A10", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x882E30", Offset = "0x881A30", VA = "0x180882E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public PJKNICMILIO HJIMPJGIBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9EE630", Offset = "0x9ED230", VA = "0x1809EE630", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9EE710", Offset = "0x9ED310", VA = "0x1809EE710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BNBOHDAMFHI FFNIAEHNKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x9A31A0", Offset = "0x9A1DA0", VA = "0x1809A31A0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9EF380", Offset = "0x9EDF80", VA = "0x1809EF380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public KHCNMJFIKHK PIIAEDKDFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9A2EA0", Offset = "0x9A1AA0", VA = "0x1809A2EA0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9A31D0", Offset = "0x9A1DD0", VA = "0x1809A31D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NNIOHMBOJFJ GDOBLIHPACC
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2E80", Offset = "0x9A1A80", VA = "0x1809A2E80", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9A31B0", Offset = "0x9A1DB0", VA = "0x1809A31B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public EPOJINPDBDE BPLFNCLBJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9A2E90", Offset = "0x9A1A90", VA = "0x1809A2E90", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9A31C0", Offset = "0x9A1DC0", VA = "0x1809A31C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JHPGNCLFEFD DBIJAOJGMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9EF370", Offset = "0x9EDF70", VA = "0x1809EF370", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x12E9B60", Offset = "0x12E8760", VA = "0x1812E9B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NJCAGKAOHPF KIHBGBLJHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9A3180", Offset = "0x9A1D80", VA = "0x1809A3180", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9A3320", Offset = "0x9A1F20", VA = "0x1809A3320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public MHPAJLBPAGC DDKAJHJAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9A3190", Offset = "0x9A1D90", VA = "0x1809A3190", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9A3330", Offset = "0x9A1F30", VA = "0x1809A3330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public AIMHFJMEAKL PAFHFMHEPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xC5F510", Offset = "0xC5E110", VA = "0x180C5F510", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xC5EBA0", Offset = "0xC5D7A0", VA = "0x180C5EBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public JOLNEEIAHIL CMLFECNHKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xC5D670", Offset = "0xC5C270", VA = "0x180C5D670", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xD545B0", Offset = "0xD531B0", VA = "0x180D545B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public LCAFMEKLLGH MFKLBOKLKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x12E0760", Offset = "0x12DF360", VA = "0x1812E0760", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C20A0", Offset = "0x14C0CA0", VA = "0x1814C20A0", Slot = "34")]
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
		[Cpp2IlInjected.Address(RVA = "0xF005B0", Offset = "0xEFF1B0", VA = "0x180F005B0", Slot = "35")]
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
		[Cpp2IlInjected.Address(RVA = "0x1838B10", Offset = "0x1837710", VA = "0x181838B10", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x134ED70", Offset = "0x134D970", VA = "0x18134ED70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private bool AGMIAFBIBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x28B5EA0", Offset = "0x28B4AA0", VA = "0x1828B5EA0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private bool KFILDGILPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x28B5A60", Offset = "0x28B4660", VA = "0x1828B5A60", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private Task HCHFNNPCPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x28B6380", Offset = "0x28B4F80", VA = "0x1828B6380", Slot = "49")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	private CancellationToken COIIPPCEMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x28B6020", Offset = "0x28B4C20", VA = "0x1828B6020", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private MHOBEFMLEFD NBJOOFEEEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action GEHOJIKCEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x28B62C0", Offset = "0x28B4EC0", VA = "0x1828B62C0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x28B63D0", Offset = "0x28B4FD0", VA = "0x1828B63D0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event KGMACCFPPHI ACEHBDICKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x28B5AE0", Offset = "0x28B46E0", VA = "0x1828B5AE0", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x28B6040", Offset = "0x28B4C40", VA = "0x1828B6040", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event KGMACCFPPHI JDBAEEJBNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x28B5A00", Offset = "0x28B4600", VA = "0x1828B5A00", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x28B5F60", Offset = "0x28B4B60", VA = "0x1828B5F60", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event KGMACCFPPHI GACAJPABPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x28B5F00", Offset = "0x28B4B00", VA = "0x1828B5F00", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x28B5FC0", Offset = "0x28B4BC0", VA = "0x1828B5FC0", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<NBGKOOKNBGP, bool> EMBGOJMNLJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x28B5B40", Offset = "0x28B4740", VA = "0x1828B5B40", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x28B6320", Offset = "0x28B4F20", VA = "0x1828B6320", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x134ED70", Offset = "0x134D970", VA = "0x18134ED70", Slot = "36")]
	public void LGJLJGHOJJN(OAEILIIIPED MDBMLIKFPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x28B6740", Offset = "0x28B5340", VA = "0x1828B6740")]
	[UnityEngine.Scripting.Preserve]
	internal HAIGOHNCBOK([ACEKLAKDMBL(null)] MHOBEFMLEFD JMIFLNNGBHG, [ACEKLAKDMBL(null)] EPJFONLPCOB EKLPJDMGHDM, [ACEKLAKDMBL(null)] GHOMLKKKKHM IIJBBPIGDIK, [ACEKLAKDMBL(null)] HBPPPIGEKFO FGOMHOJPKFO, [ACEKLAKDMBL(null)] KDHGMPHKPAM CGJJMLHLLBO, [ACEKLAKDMBL(null)] DPADKKHLKLF JKPHNCJANPB, [ACEKLAKDMBL(null)] BEIIGIJBNMM EAABFFOLONM, [ACEKLAKDMBL(null)] KFDAFKKLOKJ BBMCDOFLCKN, [ACEKLAKDMBL(null)] HLDCIPKGMNF CPNGNGPKKKH, [ACEKLAKDMBL(null)] NABGKEIJMLK KALNIKAOMNH, [ACEKLAKDMBL(null)] LEHKMPCAGKL EOHAACKOPMN, [ACEKLAKDMBL(null)] LFPKDNNPHDE MOCPAILNIIE, [ACEKLAKDMBL(null)] LKGOGFHLDFK HBHHBLLKCLC, [ACEKLAKDMBL(null)] OCAOCNCNOCD OFFFKIOLLDO, [ACEKLAKDMBL(null)] MFHIJBENPCO GAOOEGMBKDI, [ACEKLAKDMBL(null)] ANJBBNMCECI HIGLLBHNICP, [ACEKLAKDMBL(null)] BNEJDHEIHAG KEJOJLBJLEK, [ACEKLAKDMBL(null)] MFLEOODBFAO ABDILMEFOOH, [ACEKLAKDMBL(null)] PJKNICMILIO FHPOOOFJELG, [ACEKLAKDMBL(null)] BNBOHDAMFHI CJPJEGMHJHB, [ACEKLAKDMBL(null)] NNIOHMBOJFJ MOAIDCPAIPL, [ACEKLAKDMBL(null)] KHCNMJFIKHK MNLFCPGNLLN, [ACEKLAKDMBL(null)] EPOJINPDBDE KELDMIFJJEC, [ACEKLAKDMBL(null)] JHPGNCLFEFD HHCBJFFAMJN, [ACEKLAKDMBL(null)] NJCAGKAOHPF DOOFDPAIBFA, [ACEKLAKDMBL(null)] AIMHFJMEAKL CEHJOFICIAM, [ACEKLAKDMBL(null)] JOLNEEIAHIL OPFNMBAGLHI, [ACEKLAKDMBL(null)] LCAFMEKLLGH FIKIGKENNBD, [ACEKLAKDMBL(null)] JHNNJFGCKHO OPAKEBPNBDA, [ACEKLAKDMBL(null)] PILPGHODDIG DCLPNPGHFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x28B6580", Offset = "0x28B5180", VA = "0x1828B6580")]
	private void PBAELFIBGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x28B5D10", Offset = "0x28B4910", VA = "0x1828B5D10", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x28B60A0", Offset = "0x28B4CA0", VA = "0x1828B60A0", Slot = "50")]
	private void JBILAOJENGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x28B58B0", Offset = "0x28B44B0", VA = "0x1828B58B0", Slot = "51")]
	private DHFMLFOJIHC BCFLMDHIJKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x28B60F0", Offset = "0x28B4CF0", VA = "0x1828B60F0", Slot = "52")]
	private AMGCDJKPHHE JDHCHGGOBDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x28B5BA0", Offset = "0x28B47A0", VA = "0x1828B5BA0", Slot = "53")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOJGMFMCJFG))]
	private Task<IDIFMABCDLA> DHEPDNIDHKG(HCKACEFMPCF ANGBHDDNJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x28B6430", Offset = "0x28B5030", VA = "0x1828B6430", Slot = "54")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DIINOIAAFOA))]
	private Task NFKPOIMPNCN(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x28B6670", Offset = "0x28B5270", VA = "0x1828B6670")]
	[IteratorStateMachine(typeof(OOMBEOLIPME))]
	private IEnumerable<KKHNJDMOGHC> PKNFOCGLILG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x28B66E0", Offset = "0x28B52E0", VA = "0x1828B66E0")]
	[CompilerGenerated]
	private void POCFFPKPMKH(KKHNJDMOGHC DPLEBJGMEDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class HCMDOEKGEJI : BNBOHDAMFHI, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class GGBNNJMPKNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AsyncTaskMethodBuilder<LCMHJBMHMJN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public HCMDOEKGEJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private IEMLKNOFDEG <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private IEMLKNOFDEG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<IEMLKNOFDEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GGBNNJMPKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E13CB0", Offset = "0x3E128B0", VA = "0x183E13CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class FDIFDGHGOLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FDIFDGHGOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3E11BE0", Offset = "0x3E107E0", VA = "0x183E11BE0")]
		internal object OAOGDJOBLOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class MONFPFDKGJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public AsyncTaskMethodBuilder<IEMLKNOFDEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public MHKEFJDKLJN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public HCMDOEKGEJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private FDIFDGHGOLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private IEMLKNOFDEG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private TaskAwaiter<IEMLKNOFDEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MONFPFDKGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B8D0", Offset = "0x3E1A4D0", VA = "0x183E1B8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class JADICDPLBJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JADICDPLBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x10546F0", Offset = "0x10532F0", VA = "0x1810546F0")]
		internal bool BIBMCNMPDOG(MPOOILGCDLJ sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static readonly (EFENBEKLEHO superRoomData, long subRoomDataSaveId) MBPJMINBJHC;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x28B7FA0", Offset = "0x28B6BA0", VA = "0x1828B7FA0", Slot = "5")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x28B7DE0", Offset = "0x28B69E0", VA = "0x1828B7DE0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GGBNNJMPKNF))]
	public Task<LCMHJBMHMJN> KAELPKDAAHM(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, MHKEFJDKLJN FKMIOMCKJNF, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x28B7C20", Offset = "0x28B6820", VA = "0x1828B7C20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MONFPFDKGJI))]
	private Task<IEMLKNOFDEG> JDHJMGMGKOJ(MHKEFJDKLJN FKMIOMCKJNF, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x28B7AD0", Offset = "0x28B66D0", VA = "0x1828B7AD0")]
	private LCMHJBMHMJN IHGEGPGMIFG(MHKEFJDKLJN FKMIOMCKJNF, IEMLKNOFDEG EAIBLBKOGKO, long BPODGJMCBKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x28B7740", Offset = "0x28B6340", VA = "0x1828B7740")]
	private (EFENBEKLEHO, long) BALNCNBMBEK(MHKEFJDKLJN FKMIOMCKJNF, IEMLKNOFDEG EAIBLBKOGKO, long BPODGJMCBKI)
	{
		return default((EFENBEKLEHO, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public HCMDOEKGEJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
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
[Cpp2IlInjected.Token(Token = "0x200008A")]
[UnityEngine.Scripting.Preserve]
internal sealed class AHPOMGBOHEB : KHCNMJFIKHK, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class DMGNANCMFIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DMGNANCMFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x30A1590", Offset = "0x30A0190", VA = "0x1830A1590")]
		internal object CPEEEKHDIGC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class MDDDLLCOOBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public FFLEKJBGAJJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public AHPOMGBOHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private DMGNANCMFIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private FHMBHNPINBI <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private FHMBHNPINBI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MDDDLLCOOBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x30AAC30", Offset = "0x30A9830", VA = "0x1830AAC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class BMCEANIHLDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public FFLEKJBGAJJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AHPOMGBOHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private GOMGBFEPMOD.DAMKOIBGCAN<FHMBHNPINBI> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private DDPPNCDFGCL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<DDPPNCDFGCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BMCEANIHLDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x309FA50", Offset = "0x309E650", VA = "0x18309FA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class MKHBHDMFILF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MKHBHDMFILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x30AC040", Offset = "0x30AAC40", VA = "0x1830AC040")]
		internal object MPOEFEOCGNO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class MKMDLAEFOCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public FFLEKJBGAJJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AHPOMGBOHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private MKHBHDMFILF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private FMEHMMJPLED <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private GPIJANIJAAG <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private GOMGBFEPMOD.DAMKOIBGCAN<FHMBHNPINBI> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private FHMBHNPINBI <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private FMEHMMJPLED <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private DDPPNCDFGCL <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<DDPPNCDFGCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MKMDLAEFOCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x30AC480", Offset = "0x30AB080", VA = "0x1830AC480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private MHPAJLBPAGC DLHMJOJPEDH;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private GOMGBFEPMOD PFLGINGMBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x28A10B0", Offset = "0x289FCB0", VA = "0x1828A10B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x28A1320", Offset = "0x289FF20", VA = "0x1828A1320", Slot = "8")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x28A1160", Offset = "0x289FD60", VA = "0x1828A1160", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MDDDLLCOOBE))]
	public Task<FHMBHNPINBI> NFBKKILHAPB(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x28A0A10", Offset = "0x289F610", VA = "0x1828A0A10", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMCEANIHLDG))]
	public Task<FHMBHNPINBI> AMIAFKHFHLG(CancellationToken GFFFFCALMCA, FFLEKJBGAJJ GAEEOLALHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x28A13B0", Offset = "0x289FFB0", VA = "0x1828A13B0", Slot = "6")]
	public DNKNJNMAMBL PNKJHFEMMMK(OOCGABPOHBK BCJOJLPDGAD, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x28A0D80", Offset = "0x289F980", VA = "0x1828A0D80", Slot = "7")]
	public DNKNJNMAMBL HHEJOOPBBPE(OOCGABPOHBK BCJOJLPDGAD, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x28A0BC0", Offset = "0x289F7C0", VA = "0x1828A0BC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MKMDLAEFOCP))]
	private Task<FHMBHNPINBI> FMFBKAMPGHL(FHMBHNPINBI PAJPFFIMEFB, FFLEKJBGAJJ GAEEOLALHAM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x28A0BB0", Offset = "0x289F7B0", VA = "0x1828A0BB0")]
	private static byte[] FEHBCCIIIBD(FHMBHNPINBI DKIECHCHJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x28A0FB0", Offset = "0x289FBB0", VA = "0x1828A0FB0")]
	private static string JPGMKADLJAN(byte[] AIMHDAMIMIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public AHPOMGBOHEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public readonly struct OOIGBDNKEMF<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class NCMCGIHBNHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder<PKJAENHCLMN<HCLLLJEDILH<TData>, CMPFHAIKIAN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public OOIGBDNKEMF<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private PKJAENHCLMN<byte[], CMPFHAIKIAN> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private PKJAENHCLMN<byte[], CMPFHAIKIAN> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter<PKJAENHCLMN<byte[], CMPFHAIKIAN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public NCMCGIHBNHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1FB92C0", Offset = "0x1FB7EC0", VA = "0x181FB92C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private readonly FNOEIOAGCPK<TGetDataArg, TData> PNGKFALBFEP;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xB1CC20", Offset = "0xB1B820", VA = "0x180B1CC20")]
	internal OOIGBDNKEMF(FNOEIOAGCPK<TGetDataArg, TData> LHPOMNBICEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x489CD10", Offset = "0x489B910", VA = "0x18489CD10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OOIGBDNKEMF<, >.NCMCGIHBNHA))]
	public Task<PKJAENHCLMN<HCLLLJEDILH<TData>, CMPFHAIKIAN>> FMMAEMCOBJJ(TGetDataArg AIMHDAMIMIL, string AJJPNCELFOK, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class AJGLMMMEGAJ
{
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x1750BB0", Offset = "0x174F7B0", VA = "0x181750BB0")]
	public static OOIGBDNKEMF<TGetDataArg, TData> DOBPLOGGNLM<TGetDataArg, TData>(FNOEIOAGCPK<TGetDataArg, TData> LHPOMNBICEN)
	{
		return default(OOIGBDNKEMF<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[UnityEngine.Scripting.Preserve]
internal sealed class HBIFBBIEEDF : PJKNICMILIO, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class DOJODKJDBCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public DLLMEMMHNCB operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public HBIFBBIEEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DOJODKJDBCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E11490", Offset = "0x3E10090", VA = "0x183E11490")]
		internal object DAGJCDDHHCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x3E11360", Offset = "0x3E0FF60", VA = "0x183E11360")]
		internal object ADBOEBGPJOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class IDAGABMBDJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public HBIFBBIEEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private DOJODKJDBCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private IDIFMABCDLA <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private IDIFMABCDLA <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter<IDIFMABCDLA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IDAGABMBDJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E14E40", Offset = "0x3E13A40", VA = "0x183E14E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class PDPJCAIDOCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public DLLMEMMHNCB operationType;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public PDPJCAIDOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E840", Offset = "0x3E1D440", VA = "0x183E1E840")]
		internal object NIEMLIEKAPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class GAIMGEONPNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GAIMGEONPNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x3E133E0", Offset = "0x3E11FE0", VA = "0x183E133E0")]
		internal object OEEANEFBCJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x3E134E0", Offset = "0x3E120E0", VA = "0x183E134E0")]
		internal object PPNMJDPHAKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x3E13460", Offset = "0x3E12060", VA = "0x183E13460")]
		internal object PELHJCGOIMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class CPFBJMKGFIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public FHMBHNPINBI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public HBIFBBIEEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private GAIMGEONPNF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private LIHFEMBJCAM <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private IDIFMABCDLA <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private (IDIFMABCDLA validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private (IDIFMABCDLA validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<(IDIFMABCDLA validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CPFBJMKGFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x3E0EB70", Offset = "0x3E0D770", VA = "0x183E0EB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private EPOJINPDBDE KELDMIFJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private MFLEOODBFAO ABDILMEFOOH;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x28B7690", Offset = "0x28B6290", VA = "0x1828B7690", Slot = "5")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x28B7520", Offset = "0x28B6120", VA = "0x1828B7520", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IDAGABMBDJA))]
	private Task<IDIFMABCDLA> JJKEIIMBAMH(FHMBHNPINBI IFPNDMLIDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x28B7130", Offset = "0x28B5D30", VA = "0x1828B7130")]
	private bool GJCJOJDLELC(DLLMEMMHNCB KAINKNJPFIL, out IDIFMABCDLA IIMBBHEIGGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x28B73B0", Offset = "0x28B5FB0", VA = "0x1828B73B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPFBJMKGFIB))]
	private Task<IDIFMABCDLA> IOGHKNBIIKI(FHMBHNPINBI PAJPFFIMEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public HBIFBBIEEDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class MDMPMBPEFDA
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public static IDIFMABCDLA GBIFOJKCEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x30AB160", Offset = "0x30A9D60", VA = "0x1830AB160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x30AB230", Offset = "0x30A9E30", VA = "0x1830AB230")]
	public static bool EGDIGIIHPIG(this IDIFMABCDLA NPAEKAKKGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x30AB1C0", Offset = "0x30A9DC0", VA = "0x1830AB1C0")]
	public static IDIFMABCDLA DCMADGLAFJL(BOHAGPJNCEM BBMNNPEOJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x30AB260", Offset = "0x30A9E60", VA = "0x1830AB260")]
	public static IDIFMABCDLA EKDFEDAKBMJ(params IDIFMABCDLA[] EJEMMKODELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x30AB520", Offset = "0x30AA120", VA = "0x1830AB520")]
	public static IDIFMABCDLA MFIOCBBOOJP(IEnumerable<IDIFMABCDLA> EJEMMKODELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x30AB270", Offset = "0x30A9E70", VA = "0x1830AB270")]
	public static string FFEBHLOMHAI(this IDIFMABCDLA IIMBBHEIGGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[UnityEngine.Scripting.Preserve]
internal sealed class NFOAMOJDGHO : EPOJINPDBDE, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private DPADKKHLKLF JKPHNCJANPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private HLDCIPKGMNF CPNGNGPKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private NNIOHMBOJFJ MOAIDCPAIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private LKGOGFHLDFK HBHHBLLKCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private OCAOCNCNOCD OFFFKIOLLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private AIMHFJMEAKL CEHJOFICIAM;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x30AE4A0", Offset = "0x30AD0A0", VA = "0x1830AE4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private static IDIFMABCDLA GBIFOJKCEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x30AB160", Offset = "0x30A9D60", VA = "0x1830AB160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x30AE8D0", Offset = "0x30AD4D0", VA = "0x1830AE8D0", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x30AE4F0", Offset = "0x30AD0F0", VA = "0x1830AE4F0", Slot = "4")]
	public IDIFMABCDLA NMBCIPOHMGE(IGGCDPKBFGF AEEBHLKEAKN, DLLMEMMHNCB GOKELOIKDPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x30AE1B0", Offset = "0x30ACDB0", VA = "0x1830AE1B0", Slot = "5")]
	public IDIFMABCDLA GOENMAPECNC(IGGCDPKBFGF AOLFPABEEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x30AE680", Offset = "0x30AD280", VA = "0x1830AE680", Slot = "6")]
	public IDIFMABCDLA OIGJDPDICNH(IGGCDPKBFGF AOLFPABEEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x30AB1C0", Offset = "0x30A9DC0", VA = "0x1830AB1C0")]
	private static IDIFMABCDLA DCMADGLAFJL(BOHAGPJNCEM MDCIFHCDMMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public NFOAMOJDGHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public delegate Task NDLLDLNNGKD(MOMCOKAPMLC CMMCIHFHBLL, CancellationToken FLDJLPKNKKO);
[Cpp2IlInjected.Token(Token = "0x200009E")]
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
[Cpp2IlInjected.Token(Token = "0x200009F")]
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
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface NOKNPGPIPCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OEIPHHEMJBA(IDIFMABCDLA NPAEKAKKGDM);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal interface PJKNICMILIO : KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IDIFMABCDLA> HJIMPJGIBJM(FHMBHNPINBI IFPNDMLIDFN);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
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
[Cpp2IlInjected.Token(Token = "0x20000A3")]
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
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class EPJAGPDNGNM
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x28AA120", Offset = "0x28A8D20", VA = "0x1828AA120")]
	public static void LKLABALGDMK(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x28A9F20", Offset = "0x28A8B20", VA = "0x1828A9F20")]
	internal static void GOHIKCIPJDG(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x28AA040", Offset = "0x28A8C40", VA = "0x1828AA040")]
	internal static void HKPEEDJJFCO(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x28A9AD0", Offset = "0x28A86D0", VA = "0x1828A9AD0")]
	internal static void BNFBDNFHIIK(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class MIPPFLCEBNN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x30AC000", Offset = "0x30AAC00", VA = "0x1830AC000")]
	public MIPPFLCEBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2D50500", Offset = "0x2D4F100", VA = "0x182D50500")]
	public MIPPFLCEBNN(string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal interface KKHNJDMOGHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
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
	Task AHAEOEIJNIF(JAPPGKMKBNF<string>.KLCBHAGBNOA BNDOBCCDIJF, CancellationToken GFFFFCALMCA);

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
	Task<bool> ECHGGKEINGC(EPJFONLPCOB EKLPJDMGHDM, CancellationToken GFFFFCALMCA, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE);

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
	Task<Scene> PNEPKELPBPK(string KPMIPNBJALP, LoadSceneMode EMEPBMIHOEO, bool DJJMALJEJII, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO);

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
	Task HBEDCFJFEGH(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task NOHPLHNKJCK(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task JBIFFBCHAOI(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

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
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public interface JKKCGILCDLC
{
	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NGCNLJOBCMB(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ABJLOPKAJKI(CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct DHJIDMGNJIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public HashSet<int> LAGFPCECFEP;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum JLOOFCOEEHE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class EADHPHKIDHL
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class KJNIBMJHKAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public HDDCAHBLLEN finalTimerLogFlags;

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KJNIBMJHKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x462BCA0", Offset = "0x462A8A0", VA = "0x18462BCA0")]
		internal void NEKAOOAPCBO(BDPOMAKGMDN t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class LPJEGNEIEKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public JAPPGKMKBNF<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LPJEGNEIEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x462D2A0", Offset = "0x462BEA0", VA = "0x18462D2A0")]
		internal object PKJFDBMMMDF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public const string BNKFANAMJEE = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public const string NCFIHLMKILH = "END: ";

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x28A8290", Offset = "0x28A6E90", VA = "0x1828A8290")]
	public static JAPPGKMKBNF<string> AKLIDLOGNAK([Optional] string EKLNNMKJFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x28A8180", Offset = "0x28A6D80", VA = "0x1828A8180")]
	public static JAPPGKMKBNF<string> AKLIDLOGNAK(HDDCAHBLLEN KDJDJIAAKGI, [Optional] string EKLNNMKJFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x28A8400", Offset = "0x28A7000", VA = "0x1828A8400")]
	private static void BEOIMNJHGDJ(string BDFCACLHAFA, JAPPGKMKBNF<string>.PKDKPIIHBOC IDIJCJCNEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x28A8510", Offset = "0x28A7110", VA = "0x1828A8510")]
	private static void DAMIAJAPFJI(string BDFCACLHAFA, JAPPGKMKBNF<string>.PKDKPIIHBOC IDIJCJCNEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x28A8700", Offset = "0x28A7300", VA = "0x1828A8700")]
	public static void NJBCIHNHCDG(JAPPGKMKBNF<string> IDIJCJCNEPO, HDDCAHBLLEN ODPKAHOAPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x28A8620", Offset = "0x28A7220", VA = "0x1828A8620")]
	public static string JBLJNPMCAIB(FHMBHNPINBI IFPNDMLIDFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[UnityEngine.Scripting.Preserve]
internal class AEONCJCINHA : OCAOCNCNOCD, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class IICKCEOFGIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public MOMCOKAPMLC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public AEONCJCINHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private Func<CancellationToken, List<Task>> <taskGenerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IICKCEOFGIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x30A2E10", Offset = "0x30A1A10", VA = "0x1830A2E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class JDAMIFBLIGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AEONCJCINHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public MOMCOKAPMLC roomData;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JDAMIFBLIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x30A3700", Offset = "0x30A2300", VA = "0x1830A3700")]
		internal List<Task> LGJEAMKDKJK(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class AHCMIKAGBFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public NDLLDLNNGKD taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AEONCJCINHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public AHCMIKAGBFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x309F0A0", Offset = "0x309DCA0", VA = "0x18309F0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class OMJCDDPPIAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public AEONCJCINHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public OMJCDDPPIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x30B41E0", Offset = "0x30B2DE0", VA = "0x1830B41E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly HashSet<NDLLDLNNGKD> CFPBFMNDOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private GHOMLKKKKHM IIJBBPIGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private HGGHGJBADJJ PCNABAKEDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private EMOAKECFAIC GJMOIKFOKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private IDisposable IGMACGPPKGM;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool CEMOOCAECHD
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x28A06C0", Offset = "0x289F2C0", VA = "0x1828A06C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	internal Task KCIAOCJILBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x289FB90", Offset = "0x289E790", VA = "0x18289FB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x28A06F0", Offset = "0x289F2F0", VA = "0x1828A06F0", Slot = "6")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x289FBA0", Offset = "0x289E7A0", VA = "0x18289FBA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x28A01C0", Offset = "0x289EDC0", VA = "0x1828A01C0", Slot = "5")]
	public bool JBCFBBEJPKG(NDLLDLNNGKD JOBDEEONKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x289FD00", Offset = "0x289E900", VA = "0x18289FD00")]
	private void HOPGIKLHCMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x28A0220", Offset = "0x289EE20", VA = "0x1828A0220")]
	private void JBMCGODGAFK(MOMCOKAPMLC CMMCIHFHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x289F490", Offset = "0x289E090", VA = "0x18289F490")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IICKCEOFGIF))]
	private Task BNCHPNCJPIE(MOMCOKAPMLC CMMCIHFHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x289FC20", Offset = "0x289E820", VA = "0x18289FC20")]
	private Func<CancellationToken, List<Task>> FFNAMDMFGNC(MOMCOKAPMLC CMMCIHFHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x289F5E0", Offset = "0x289E1E0", VA = "0x18289F5E0")]
	private List<Task> CMPFDJLLOAD(MOMCOKAPMLC CMMCIHFHBLL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x28A0520", Offset = "0x289F120", VA = "0x1828A0520")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AHCMIKAGBFJ))]
	private Task JCKGPKELFGI(NDLLDLNNGKD GALABLGPLIG, MOMCOKAPMLC PHBHEFAPHDL, CancellationToken FLDJLPKNKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x28A00A0", Offset = "0x289ECA0", VA = "0x1828A00A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMJCDDPPIAG))]
	private Task IMGJEMNFBPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x289FF70", Offset = "0x289EB70", VA = "0x18289FF70")]
	private void IHLPPHPEFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x28A0990", Offset = "0x289F590", VA = "0x1828A0990")]
	public AEONCJCINHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
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
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class BPDCHEJGLEB : HMAILMDEICE
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class JBACILOGPJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public BPDCHEJGLEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JBACILOGPJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x30A3330", Offset = "0x30A1F30", VA = "0x1830A3330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private readonly IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private readonly HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x9138A0", Offset = "0x9124A0", VA = "0x1809138A0")]
	public BPDCHEJGLEB(IFNNJAAOEDN FNIFBLHBOOE, HBPPPIGEKFO FGOMHOJPKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x28A2D70", Offset = "0x28A1970", VA = "0x1828A2D70", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JBACILOGPJK))]
	public Task<bool> BFAINGMPNNG(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x28A2EE0", Offset = "0x28A1AE0", VA = "0x1828A2EE0")]
	[CompilerGenerated]
	private object MJNFCNHNFBF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class LGGJCNKGNNJ : KBIEMNNHIEA, DPADKKHLKLF, CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class IIINIOJANIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public IDIFMABCDLA result;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IIINIOJANIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x3E156E0", Offset = "0x3E142E0", VA = "0x183E156E0")]
		internal object MHIABBOBHCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x30A8C80", Offset = "0x30A7880", VA = "0x1830A8C80")]
	[UnityEngine.Scripting.Preserve]
	public LGGJCNKGNNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x30A8AF0", Offset = "0x30A76F0", VA = "0x1830A8AF0", Slot = "8")]
	public IDIFMABCDLA KDJGBCGJOCG(IGGCDPKBFGF AOLFPABEEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
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
	FNOEIOAGCPK<EFENBEKLEHO, CIOHJELGAHC> ILKGANIKHBB(long BFNOJMGJLFG);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FNOEIOAGCPK<EFENBEKLEHO, BNIDNMGAHLD> HAFGIPOEOLP(long BFNOJMGJLFG);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FNOEIOAGCPK<long, DBGKDIDMLDF> PBEEICJIDHJ();

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> IHJFEHBNFBL(byte[] IKHHHDILDNK, byte[] HOIJLNKGLFK, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class OPLKMJPGMHE : MFHIJBENPCO, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class JAHGDBAOKME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JAHGDBAOKME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x582B0C0", Offset = "0x5829CC0", VA = "0x18582B0C0")]
		internal object EBEEFKOEAJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class DEOIPINPEPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DEOIPINPEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x58284E0", Offset = "0x58270E0", VA = "0x1858284E0")]
		internal object NBDHKEJKBAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class JHOMONPFIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JHOMONPFIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x582BA10", Offset = "0x582A610", VA = "0x18582BA10")]
		internal object BLBCHAJHGFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class KBLLBPHCGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KBLLBPHCGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x582C020", Offset = "0x582AC20", VA = "0x18582C020")]
		internal object NDIDFMEMLNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class DBJCIKLDBMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DBJCIKLDBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5828480", Offset = "0x5827080", VA = "0x185828480")]
		internal object AMJPKDKGJJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly Dictionary<Guid, KJLLMJJEGBB> GAOOEGMBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly TimeSpan MHKBKFFBMGN;

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "10")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x30B5AC0", Offset = "0x30B46C0", VA = "0x1830B5AC0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x30B5560", Offset = "0x30B4160", VA = "0x1830B5560", Slot = "4")]
	public LIHFEMBJCAM CAILCKFFJIK(Guid PALLEDHBFCO)
	{
		return default(LIHFEMBJCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x30B5800", Offset = "0x30B4400", VA = "0x1830B5800", Slot = "5")]
	public bool CPPHPNNFPKL(Guid PALLEDHBFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x30B5AD0", Offset = "0x30B46D0", VA = "0x1830B5AD0", Slot = "8")]
	public bool IHLPPHPEFDP(Guid PALLEDHBFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x30B6030", Offset = "0x30B4C30", VA = "0x1830B6030", Slot = "6")]
	public bool LPGMNPDMPPM(Guid PALLEDHBFCO, Task OIDBJIACCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x30B5D60", Offset = "0x30B4960", VA = "0x1830B5D60", Slot = "7")]
	public bool JJNOGDGBEML(Guid PALLEDHBFCO, IDIFMABCDLA NPAEKAKKGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x30B6400", Offset = "0x30B5000", VA = "0x1830B6400", Slot = "9")]
	public Task<(IDIFMABCDLA, Task)> PDGJMOLMFLF(Guid PALLEDHBFCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x30B5290", Offset = "0x30B3E90", VA = "0x1830B5290")]
	private void ACCPDGFAFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x30B6490", Offset = "0x30B5090", VA = "0x1830B6490")]
	public OPLKMJPGMHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class FFJLHIIMOFL : KBIEMNNHIEA, BEIIGIJBNMM, CJBKIJKLHJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class GKKBEOKCBCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public IDIFMABCDLA result;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GKKBEOKCBCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x4627180", Offset = "0x4625D80", VA = "0x184627180")]
		internal object ALMDFNLKKMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x28AB360", Offset = "0x28A9F60", VA = "0x1828AB360")]
	[UnityEngine.Scripting.Preserve]
	public FFJLHIIMOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x28AB1D0", Offset = "0x28A9DD0", VA = "0x1828AB1D0", Slot = "8")]
	public IDIFMABCDLA IGGGLNHPCKG(IGGCDPKBFGF ACJGGEOLANN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
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
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class IGKJGLPENOO
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x28BB940", Offset = "0x28BA540", VA = "0x1828BB940")]
	public static bool KADKOGACMKG(this LKGOGFHLDFK HBHHBLLKCLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal static class GLFEJKNHJJP
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x28B4BE0", Offset = "0x28B37E0", VA = "0x1828B4BE0")]
	public static string OFFBBLKFMFL(this MHKEFJDKLJN BIJBNMHAAEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x28B4B50", Offset = "0x28B3750", VA = "0x1828B4B50")]
	public static bool ANNNHOHBBHJ(this MHKEFJDKLJN BIJBNMHAAEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[UnityEngine.Scripting.Preserve]
internal class GBIMIGMJJBK : LFPKDNNPHDE, KKHNJDMOGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class PDCGGKLMGEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public GBIMIGMJJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public PDCGGKLMGEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x4632330", Offset = "0x4630F30", VA = "0x184632330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class HAFNPGEIJOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public GBIMIGMJJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private bool <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HAFNPGEIJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x46271E0", Offset = "0x4625DE0", VA = "0x1846271E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class EDINKMJPCLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public EDINKMJPCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x4624510", Offset = "0x4623110", VA = "0x184624510")]
		internal object LMCIPKIPBCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class DFNOODHGIEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public GBIMIGMJJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private EDINKMJPCLP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private HMAILMDEICE <provider>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DFNOODHGIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x4622B40", Offset = "0x4621740", VA = "0x184622B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class GEJLAEHLBHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GEJLAEHLBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x4625A80", Offset = "0x4624680", VA = "0x184625A80")]
		internal object DJBENOEIEAM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private HMAILMDEICE[] HNAJPCAIOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private CancellationTokenSource MFGBDLCLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private int ABAHDMMJMOJ;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x28B1AA0", Offset = "0x28B06A0", VA = "0x1828B1AA0", Slot = "7")]
	public void PBAELFIBGFO(IFNNJAAOEDN FNIFBLHBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x28B0D10", Offset = "0x28AF910", VA = "0x1828B0D10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x28B1000", Offset = "0x28AFC00", VA = "0x1828B1000", Slot = "6")]
	public void IHLPPHPEFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x28B0AA0", Offset = "0x28AF6A0", VA = "0x1828B0AA0", Slot = "5")]
	public void DEAHNGCCEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x28B1190", Offset = "0x28AFD90", VA = "0x1828B1190", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDCGGKLMGEN))]
	public Task JHKFDEFLOCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x28B1400", Offset = "0x28B0000", VA = "0x1828B1400")]
	private void NCLKBMEBDPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x28B0D20", Offset = "0x28AF920", VA = "0x1828B0D20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HAFNPGEIJOK))]
	private Task GKILPCLEHMP(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x28B0E70", Offset = "0x28AFA70", VA = "0x1828B0E70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DFNOODHGIEH))]
	private Task<bool> HOCEBFKAOGC(int NHHNPPKPBIA, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x28B1940", Offset = "0x28B0540", VA = "0x1828B1940")]
	private void NNCIEJCOMBA(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x28B12B0", Offset = "0x28AFEB0", VA = "0x1828B12B0")]
	private void KBPKOBDJBJP(int NHHNPPKPBIA, bool GGKLFMPBGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x28B1780", Offset = "0x28B0380", VA = "0x1828B1780")]
	private void NDBCEBKOCNP(int NHHNPPKPBIA, Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x28B0C00", Offset = "0x28AF800", VA = "0x1828B0C00")]
	private void DIHPGJDHNEM(CancellationToken GFFFFCALMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x28B1B20", Offset = "0x28B0720", VA = "0x1828B1B20")]
	public GBIMIGMJJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class AKHFFEBLFLI
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x28A1750", Offset = "0x28A0350", VA = "0x1828A1750")]
	public static void LODDLPCJOOC(this EPJFONLPCOB EKLPJDMGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x28A1760", Offset = "0x28A0360", VA = "0x1828A1760")]
	public static void NMEJOAFIBFD(this EPJFONLPCOB EKLPJDMGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x28A1640", Offset = "0x28A0240", VA = "0x1828A1640")]
	private static void DEMANJMNJMK(this EPJFONLPCOB EKLPJDMGHDM, bool JKOLNMIPLMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct POFGIICIGOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public readonly MCJHCEJFKNC JOOMDEJHLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public readonly string KJLGHJOMLJO;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x30B8D80", Offset = "0x30B7980", VA = "0x1830B8D80")]
	public POFGIICIGOD(string GPMCGMIFIIK, MCJHCEJFKNC EGMEOIADPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x30B8D00", Offset = "0x30B7900", VA = "0x1830B8D00")]
	public string MOMBAAMFHDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x30B8C60", Offset = "0x30B7860", VA = "0x1830B8C60")]
	public string GCAPBBHFANN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public delegate string FKAEOHGBIDG<in T>(T BPFOEEABMGN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public delegate int LIFHOMMNNKM<in T>(T BPFOEEABMGN) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class HNGHLPCGIPA : PILPGHODDIG
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private delegate string BHEDJILKDMB(Exception BPFOEEABMGN);

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private delegate int PHFOMAFIOLI(Exception BPFOEEABMGN);

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class PJAFKBFIKAK<T> : BBJCLIHKHGE<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class JFLFKJPGKHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
			public JFLFKJPGKHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
			internal string KCJDHMJIJPJ(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class BGKKKLDEJLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x761540", Offset = "0x760940")]
			public FKAEOHGBIDG<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
			public BGKKKLDEJLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x26DEF70", Offset = "0x26DDB70", VA = "0x1826DEF70")]
			internal string BAMOKCHGGHH(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class MJEACJLGKDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public int subCode;

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
			public MJEACJLGKDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
			internal int DGFHLAPIJNB(Exception _)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class ONCDMGMGKAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7615A0", Offset = "0x7609A0")]
			public LIFHOMMNNKM<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
			public ONCDMGMGKAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x26DEF70", Offset = "0x26DDB70", VA = "0x1826DEF70")]
			internal int DJINAFDOFII(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly HNGHLPCGIPA DCLPNPGHFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly Type IHOHJBKPLGC;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x42EA870", Offset = "0x42E9470", VA = "0x1842EA870")]
		internal PJAFKBFIKAK(HNGHLPCGIPA DCLPNPGHFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x42EA720", Offset = "0x42E9320", VA = "0x1842EA720", Slot = "4")]
		public void OFKKPAPNNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x42EA620", Offset = "0x42E9220", VA = "0x1842EA620", Slot = "5")]
		public BBJCLIHKHGE<T> MNONDJFMJHF(string LJGKGILKHCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x42EA410", Offset = "0x42E9010", VA = "0x1842EA410", Slot = "6")]
		public BBJCLIHKHGE<T> IPJKAHEAOIN(FKAEOHGBIDG<T> EMJBJKKPMII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x42EA3D0", Offset = "0x42E8FD0", VA = "0x1842EA3D0", Slot = "7")]
		public BBJCLIHKHGE<T> DJLCCKADJOD(int EGMEOIADPFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x42EA510", Offset = "0x42E9110", VA = "0x1842EA510", Slot = "8")]
		public BBJCLIHKHGE<T> JPCCKFPDCIL(int EGMEOIADPFI, int IEPBGECFBIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x42EA750", Offset = "0x42E9350", VA = "0x1842EA750", Slot = "9")]
		public BBJCLIHKHGE<T> OMLFADBINCK(int EGMEOIADPFI, LIFHOMMNNKM<T> HGLLKEAJGLO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class IEPENJPADNO<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private bool FICLLNGHBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly List<Type> LKDHDKJNCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private readonly Dictionary<Type, TVal> HFKHBPEFOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private readonly Dictionary<Type, int> CFFFABPLIPM;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<Type> GDALLGCOGJN
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x1C74FA0", Offset = "0x1C73BA0", VA = "0x181C74FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1C750C0", Offset = "0x1C73CC0", VA = "0x181C750C0")]
		public IEPENJPADNO(Dictionary<Type, int> CFFFABPLIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x1C74C30", Offset = "0x1C73830", VA = "0x181C74C30")]
		public void CAILCKFFJIK(Type BDFCACLHAFA, TVal FOHLJCNEPNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1C75060", Offset = "0x1C73C60", VA = "0x181C75060")]
		public bool PBFMMEHNOBJ(Type IHOHJBKPLGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1C74D70", Offset = "0x1C73970", VA = "0x181C74D70")]
		public bool EJCEIGEMLDE(TVal ECNGHFJBIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x1C75090", Offset = "0x1C73C90", VA = "0x181C75090")]
		public TVal PNBJHLBKMLC(Type FIJCKHKKDCC)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1C74E40", Offset = "0x1C73A40", VA = "0x181C74E40")]
		[CompilerGenerated]
		private int FKBJGNIOBJL(Type IAKDHNCLOEJ, Type OHFJGMKOBJC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private sealed class KGPFLGOIIHE : IEnumerable<MCJHCEJFKNC>, IEnumerable, IEnumerator<MCJHCEJFKNC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private MCJHCEJFKNC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public HNGHLPCGIPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private AggregateException <aggregateException>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private IEnumerator<Exception> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private Exception <innerException>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private IEnumerator<MCJHCEJFKNC> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private MCJHCEJFKNC <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private MCJHCEJFKNC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x29B2900", Offset = "0x29B1500", VA = "0x1829B2900", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E18770", Offset = "0x3E17370", VA = "0x183E18770", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xC9F550", Offset = "0xC9E150", VA = "0x180C9F550")]
		[DebuggerHidden]
		public KGPFLGOIIHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x3E187C0", Offset = "0x3E173C0", VA = "0x183E187C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x3E18210", Offset = "0x3E16E10", VA = "0x183E18210", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x3E181C0", Offset = "0x3E16DC0", VA = "0x183E181C0")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x3E18630", Offset = "0x3E17230", VA = "0x183E18630")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x3E18730", Offset = "0x3E17330", VA = "0x183E18730", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x3E18680", Offset = "0x3E17280", VA = "0x183E18680", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MCJHCEJFKNC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x3E18680", Offset = "0x3E17280", VA = "0x183E18680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	internal const int AFFEALLLJLD = 8700;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly MCJHCEJFKNC ALHDEFACHLC;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	internal const string FCLEPJLHPJG = "Unknown error loading room";

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	internal const int NBDHGAEMHCP = 8708;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly Dictionary<Type, int> NOKKENMNDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private readonly HashSet<Type> HGPAECGPHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly IEPENJPADNO<int> IOOKCCHDBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly IEPENJPADNO<PHFOMAFIOLI> NJOGKJHBBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly IEPENJPADNO<BHEDJILKDMB> FFOIOJEFLDF;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x28BA2E0", Offset = "0x28B8EE0", VA = "0x1828BA2E0")]
	[BBAPFPLPODF(EDNJEIFHIMJ.GameOnly)]
	private static void LECKBAIJAMJ(MHOBEFMLEFD EOOGCBGOIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x28BA6F0", Offset = "0x28B92F0", VA = "0x1828BA6F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HNGHLPCGIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x1E70190", Offset = "0x1E6ED90", VA = "0x181E70190", Slot = "4")]
	public BBJCLIHKHGE<T> JDOICDLJCNN<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x28B9B90", Offset = "0x28B8790", VA = "0x1828B9B90", Slot = "5")]
	public POFGIICIGOD DBBGDMPPFKL(Exception BPFOEEABMGN)
	{
		return default(POFGIICIGOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x28B9C50", Offset = "0x28B8850", VA = "0x1828B9C50", Slot = "6")]
	public MCJHCEJFKNC EEBNDIDCOOC(Exception? BPFOEEABMGN)
	{
		return default(MCJHCEJFKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x28B98C0", Offset = "0x28B84C0", VA = "0x1828B98C0", Slot = "7")]
	[IteratorStateMachine(typeof(KGPFLGOIIHE))]
	public IEnumerable<MCJHCEJFKNC> CKGHHAFBMBP(Exception BPFOEEABMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x28BA350", Offset = "0x28B8F50", VA = "0x1828BA350", Slot = "8")]
	public string NPENLAPPDKC(Exception? BPFOEEABMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x28B9F60", Offset = "0x28B8B60", VA = "0x1828B9F60")]
	private string IDANJPLNFHD(AggregateException EIOBGNABOHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x28B9520", Offset = "0x28B8120", VA = "0x1828B9520")]
	private void CDNAIFFDCDP(Type IHOHJBKPLGC, int EGMEOIADPFI, PHFOMAFIOLI? JIJNHOFBOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x28B9950", Offset = "0x28B8550", VA = "0x1828B9950")]
	private void CMHCMNHACDK(Type IHOHJBKPLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x28B9260", Offset = "0x28B7E60", VA = "0x1828B9260")]
	private void AGNOJODIJIO(Type IHOHJBKPLGC, BHEDJILKDMB ABLIDJBMNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x28BA490", Offset = "0x28B9090", VA = "0x1828BA490")]
	private static int PONDELGGKKB(Type IHOHJBKPLGC, Dictionary<Type, int> CFFFABPLIPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x291CFC0", Offset = "0x291BBC0", VA = "0x18291CFC0")]
	private static bool NAKJALEKHHL<TVal>(IEPENJPADNO<TVal> EFLCMDHDGNO, Type IHOHJBKPLGC, out TVal ECNGHFJBIJL) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x28B9E70", Offset = "0x28B8A70", VA = "0x1828B9E70")]
	[CompilerGenerated]
	internal static int FFFICNEALGN(Type APFMAJJJHIL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct MCJHCEJFKNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly int PBLPFCGODJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public readonly int? PMFILMJGPLD;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2904BE0", Offset = "0x29037E0", VA = "0x182904BE0")]
	public MCJHCEJFKNC(int ALCHPPPJPLL, [Optional] int? IEPBGECFBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x30AAB50", Offset = "0x30A9750", VA = "0x1830AAB50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface PILPGHODDIG
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BBJCLIHKHGE<T> JDOICDLJCNN<T>() where T : Exception;

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
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface BBJCLIHKHGE<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFKKPAPNNEP();

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BBJCLIHKHGE<T> MNONDJFMJHF(string LJGKGILKHCG);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BBJCLIHKHGE<T> IPJKAHEAOIN(FKAEOHGBIDG<T> EMJBJKKPMII);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BBJCLIHKHGE<T> DJLCCKADJOD(int EGMEOIADPFI);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BBJCLIHKHGE<T> JPCCKFPDCIL(int EGMEOIADPFI, int IEPBGECFBIF);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BBJCLIHKHGE<T> OMLFADBINCK(int EGMEOIADPFI, LIFHOMMNNKM<T> HGLLKEAJGLO);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class PLKPJMGBMCG
{
	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x30B7CD0", Offset = "0x30B68D0", VA = "0x1830B7CD0")]
	[BBAPFPLPODF(EDNJEIFHIMJ.GameOnly)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD EOOGCBGOIGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
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
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class PLNJOEPHKBI : LCAFMEKLLGH
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class ILAJAIKNOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ILAJAIKNOAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class LMEMCAGEHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public ILAJAIKNOAM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LMEMCAGEHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x582D8D0", Offset = "0x582C4D0", VA = "0x18582D8D0")]
		internal object MAJIHGKLAPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly GFOFIPPNDLA JDHPBKJGAKB;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private const int FOGLCLBBAPI = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<HCKACEFMPCF> APNHNBKPOIP
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x30B7FF0", Offset = "0x30B6BF0", VA = "0x1830B7FF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x30B8140", Offset = "0x30B6D40", VA = "0x1830B8140", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
	[UnityEngine.Scripting.Preserve]
	public PLNJOEPHKBI([ACEKLAKDMBL(null)] GFOFIPPNDLA JDHPBKJGAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x30B87F0", Offset = "0x30B73F0", VA = "0x1830B87F0", Slot = "6")]
	public bool NECCIEOBFKO(long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ, NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x30B8750", Offset = "0x30B7350", VA = "0x1830B8750")]
	private void JPIBCGPDDPM(HCKACEFMPCF IPKBJACGFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x30B85D0", Offset = "0x30B71D0", VA = "0x1830B85D0", Slot = "7")]
	public bool JLPGPOOMIFG(long HAMIEGOKEJC, long BPODGJMCBKI, out HCKACEFMPCF ANGBHDDNJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x30B8090", Offset = "0x30B6C90", VA = "0x1830B8090", Slot = "8")]
	public bool DGKKMEKKLFM(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, out HCKACEFMPCF ANGBHDDNJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x30B81E0", Offset = "0x30B6DE0", VA = "0x1830B81E0")]
	private void HANDJCNDOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x30B8B40", Offset = "0x30B7740", VA = "0x1830B8B40", Slot = "9")]
	public void NIGPPAMDDAN(long HAMIEGOKEJC, long BPODGJMCBKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public enum KEFDFHALGBD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal sealed class JDGNMBGDALO : ANAIMAOJPDB
{
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private static readonly byte[] BDFCACLHAFA;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private const string DGDMFPEBCOO = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private const string CODHELJOPDL = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private const string OBHHBBFHABC = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private readonly byte[] IIKMCOGMLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly byte[] GDHEFGLCJLB;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public override KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x927AC0", Offset = "0x9266C0", VA = "0x180927AC0", Slot = "8")]
		get
		{
			return default(KEFDFHALGBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x28BE9C0", Offset = "0x28BD5C0", VA = "0x1828BE9C0")]
	public JDGNMBGDALO([Optional] string OCNGBBKIHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x28BE310", Offset = "0x28BCF10", VA = "0x1828BE310", Slot = "9")]
	internal override void IHGHDLEMING(Stream KLJHBBOMDPF, long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x28BDA30", Offset = "0x28BC630", VA = "0x1828BDA30", Slot = "10")]
	internal override bool FDCEHBPPHBP(Stream AADDFDBIEHK, long HAMIEGOKEJC, long BPODGJMCBKI, NAFNDJJJCJL PPBPOHDFOAA, out EJCOGPHMIIO NNIPLGKEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x28BE5E0", Offset = "0x28BD1E0", VA = "0x1828BE5E0")]
	private void IKFDOOENNCH(byte[] ENEAOCDMOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x28BE6F0", Offset = "0x28BD2F0", VA = "0x1828BE6F0", Slot = "11")]
	protected override FileInfo LPAKNDMHHJP(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x28BE820", Offset = "0x28BD420", VA = "0x1828BE820", Slot = "12")]
	protected override DirectoryInfo PLFMCDHHBCL(NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class ENLFGFJFMAL : ANAIMAOJPDB
{
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private const string KMHBNCMOHDN = "V2";

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private const string DGDMFPEBCOO = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private const string CODHELJOPDL = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public override KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x12B24A0", Offset = "0x12B10A0", VA = "0x1812B24A0", Slot = "8")]
		get
		{
			return default(KEFDFHALGBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x28A9A20", Offset = "0x28A8620", VA = "0x1828A9A20")]
	public ENLFGFJFMAL([Optional] string OCNGBBKIHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x28A9500", Offset = "0x28A8100", VA = "0x1828A9500")]
	private void HFHGPDNAOIF(NFBLDIHAPOJ GJGJDNGPKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x28A9590", Offset = "0x28A8190", VA = "0x1828A9590", Slot = "9")]
	internal override void IHGHDLEMING(Stream KLJHBBOMDPF, long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x28A8E80", Offset = "0x28A7A80", VA = "0x1828A8E80", Slot = "10")]
	internal override bool FDCEHBPPHBP(Stream AADDFDBIEHK, long HAMIEGOKEJC, long BPODGJMCBKI, NAFNDJJJCJL PPBPOHDFOAA, out EJCOGPHMIIO NNIPLGKEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x28A9820", Offset = "0x28A8420", VA = "0x1828A9820", Slot = "11")]
	protected override FileInfo LPAKNDMHHJP(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x28A9910", Offset = "0x28A8510", VA = "0x1828A9910", Slot = "12")]
	protected override DirectoryInfo PLFMCDHHBCL(NFBLDIHAPOJ GJGJDNGPKAK, NMAAMKHLHLG MADBMHGKPBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal abstract class ANAIMAOJPDB : GFOFIPPNDLA
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	protected enum NMAAMKHLHLG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class JIADGPIKPFP : IEnumerable<HCKACEFMPCF>, IEnumerable, IEnumerator<HCKACEFMPCF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private HCKACEFMPCF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public NFBLDIHAPOJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public ANAIMAOJPDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private DirectoryInfo <autosaveDirectory>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private FileInfo[] <files>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private FileInfo[] <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private FileInfo <file>5__5;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		private HCKACEFMPCF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xC9F550", Offset = "0xC9E150", VA = "0x180C9F550")]
		[DebuggerHidden]
		public JIADGPIKPFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x30A3730", Offset = "0x30A2330", VA = "0x1830A3730", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x30A3A50", Offset = "0x30A2650", VA = "0x1830A3A50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x30A39A0", Offset = "0x30A25A0", VA = "0x1830A39A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HCKACEFMPCF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x30A39A0", Offset = "0x30A25A0", VA = "0x1830A39A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class COCKNNNFBPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public COCKNNNFBPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x30A0A40", Offset = "0x309F640", VA = "0x1830A0A40")]
		internal object DDNCFPLJPHH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class NJMOBPAAEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public ANAIMAOJPDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NJMOBPAAEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x30AF040", Offset = "0x30ADC40", VA = "0x1830AF040")]
		internal void GFHMNIEDHJE(CAIMCDALKCM.KILBMHIFLCG ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	protected readonly string GGPDPGDFDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private readonly object CBCJPCHPPCF;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public abstract KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x28A27E0", Offset = "0x28A13E0", VA = "0x1828A27E0")]
	protected ANAIMAOJPDB([CanBeNull] string OCNGBBKIHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x28A1FB0", Offset = "0x28A0BB0", VA = "0x1828A1FB0", Slot = "5")]
	public bool AKHOODPCDID(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, out HCKACEFMPCF IPKBJACGFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x28A2760", Offset = "0x28A1360", VA = "0x1828A2760", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x28A2480", Offset = "0x28A1080", VA = "0x1828A2480", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x28A2410", Offset = "0x28A1010", VA = "0x1828A2410")]
	protected void DPDGGJOMCGI(CAIMCDALKCM.KILBMHIFLCG BMNHBAEKDJF, string BAMBEECFNAE, FileInfo FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x28A2160", Offset = "0x28A0D60", VA = "0x1828A2160")]
	internal bool BEPEKNNMMCD(FileInfo CLHKKIBAGBL, long HAMIEGOKEJC, long BPODGJMCBKI, out EJCOGPHMIIO NNIPLGKEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	private void GGEJJPKENJD(Exception LNDIIAIJNMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
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
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class MEGOIKJNOJE : GFOFIPPNDLA
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class KHPAOJHDIFE : IEnumerable<HCKACEFMPCF>, IEnumerable, IEnumerator<HCKACEFMPCF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private HCKACEFMPCF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private NFBLDIHAPOJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public NFBLDIHAPOJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public MEGOIKJNOJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private KEFDFHALGBD[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private KEFDFHALGBD <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private GFOFIPPNDLA <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private IEnumerable<HCKACEFMPCF> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private IEnumerator<HCKACEFMPCF> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private HCKACEFMPCF <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private HCKACEFMPCF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xC9F550", Offset = "0xC9E150", VA = "0x180C9F550")]
		[DebuggerHidden]
		public KHPAOJHDIFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x582C550", Offset = "0x582B150", VA = "0x18582C550", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x582C110", Offset = "0x582AD10", VA = "0x18582C110", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x582C0C0", Offset = "0x582ACC0", VA = "0x18582C0C0")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x582C510", Offset = "0x582B110", VA = "0x18582C510", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x582C460", Offset = "0x582B060", VA = "0x18582C460", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HCKACEFMPCF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x582C460", Offset = "0x582B060", VA = "0x18582C460", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private readonly KEFDFHALGBD[] JCKIOCFKJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private readonly Dictionary<KEFDFHALGBD, GFOFIPPNDLA> NOJPIBMPNCI;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x30ABA10", Offset = "0x30AA610", VA = "0x1830ABA10", Slot = "4")]
		get
		{
			return default(KEFDFHALGBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x30ABC90", Offset = "0x30AA890", VA = "0x1830ABC90")]
	[UnityEngine.Scripting.Preserve]
	public MEGOIKJNOJE(params GFOFIPPNDLA[] BMGONLEPFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x30AB740", Offset = "0x30AA340", VA = "0x1830AB740", Slot = "5")]
	public bool AKHOODPCDID(long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK, out HCKACEFMPCF IPKBJACGFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x30ABA50", Offset = "0x30AA650", VA = "0x1830ABA50")]
	private void MNLAMOGCOHJ(int HDCGHJJAEJH, long HAMIEGOKEJC, long BPODGJMCBKI, NFBLDIHAPOJ GJGJDNGPKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x30AB990", Offset = "0x30AA590", VA = "0x1830AB990", Slot = "6")]
	[IteratorStateMachine(typeof(KHPAOJHDIFE))]
	public IEnumerable<HCKACEFMPCF> LFJJEAPOAKA(NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x30AB8A0", Offset = "0x30AA4A0", VA = "0x1830AB8A0", Slot = "7")]
	public HCKACEFMPCF FPLPAECHFDP(long HAMIEGOKEJC, long BPODGJMCBKI, EJCOGPHMIIO NNIPLGKEGFJ, NFBLDIHAPOJ GJGJDNGPKAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal static class ILPADHPMCMF
{
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	internal const int LIKHOLMOGCI = 32;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x28BCF60", Offset = "0x28BBB60", VA = "0x1828BCF60")]
	internal static byte[] LIJKACPPNKD(byte[] ENEAOCDMOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x28BCEE0", Offset = "0x28BBAE0", VA = "0x1828BCEE0")]
	public static void KJMEKNOJFLL(Stream NEOJHOCIJKI, byte[] KAMCEBCIEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x28BCD00", Offset = "0x28BB900", VA = "0x1828BCD00")]
	public static bool GJAJGCIGAPI(Stream NEOJHOCIJKI, long CBKDEHFIPHJ, NAFNDJJJCJL MOJOLKEAMOM, out byte[] EOEHMAFBCHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public delegate void NAFNDJJJCJL(CAIMCDALKCM.KILBMHIFLCG JPIEJIAKMEN, string DKIECHCHJFL);
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class POIPJLMNDLN : HCKACEFMPCF, IEquatable<HCKACEFMPCF>, IEquatable<POIPJLMNDLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private readonly ANAIMAOJPDB DFELGBGBDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public readonly FileInfo OJIJENHCKAD;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public KEFDFHALGBD GNJAIECKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xCAD360", Offset = "0xCABF60", VA = "0x180CAD360", Slot = "4")]
		get
		{
			return default(KEFDFHALGBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public DateTime NAHEEPGPOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x30B8DA0", Offset = "0x30B79A0", VA = "0x1830B8DA0", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x30B9310", Offset = "0x30B7F10", VA = "0x1830B9310")]
	public POIPJLMNDLN(ANAIMAOJPDB ELFANDMPEIC, FileInfo CLHKKIBAGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x30B9260", Offset = "0x30B7E60", VA = "0x1830B9260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x30B91B0", Offset = "0x30B7DB0", VA = "0x1830B91B0", Slot = "6")]
	public void OOGFBGPCJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x30B9170", Offset = "0x30B7D70", VA = "0x1830B9170", Slot = "7")]
	public bool OODKEBIOIGI(long HAMIEGOKEJC, long BPODGJMCBKI, out EJCOGPHMIIO NNIPLGKEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x30B8FF0", Offset = "0x30B7BF0", VA = "0x1830B8FF0", Slot = "8")]
	public bool Equals(HCKACEFMPCF MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x30B8F40", Offset = "0x30B7B40", VA = "0x1830B8F40", Slot = "9")]
	public bool Equals(POIPJLMNDLN MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x30B8E40", Offset = "0x30B7A40", VA = "0x1830B8E40", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x30B90D0", Offset = "0x30B7CD0", VA = "0x1830B90D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x14071B0", Offset = "0x1405DB0", VA = "0x1814071B0")]
	public static bool FMMDKFLNNFA(POIPJLMNDLN FDMHBFLJJHC, POIPJLMNDLN DNGDHCADJJH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x1406D80", Offset = "0x1405980", VA = "0x181406D80")]
	public static bool BDPOAMCDIDB(POIPJLMNDLN FDMHBFLJJHC, POIPJLMNDLN DNGDHCADJJH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct IDIAHGMFNCH
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class EDJJICHBNBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private IFNNJAAOEDN <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public EDJJICHBNBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x3E11730", Offset = "0x3E10330", VA = "0x183E11730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x28BB7A0", Offset = "0x28BA3A0", VA = "0x1828BB7A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDJJICHBNBB))]
	public static Task EBDHDHCPNAJ(DNKNJNMAMBL GIOAKJNONKE, MOMCOKAPMLC PHBHEFAPHDL, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct JMCMENJMMNC
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class OCNOGDHDBAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public OOCGABPOHBK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private IFNNJAAOEDN <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private HBPPPIGEKFO <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private HBHNCFJCIKF <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private List<(PersistenceView, HGNMPOIAAKI)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private HGNMPOIAAKI <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public OCNOGDHDBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D9C0", Offset = "0x3E1C5C0", VA = "0x183E1D9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x28BEB10", Offset = "0x28BD710", VA = "0x1828BEB10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OCNOGDHDBAP))]
	public static Task EBDHDHCPNAJ(OOCGABPOHBK CDJHLNAAHGK, MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal struct DJCJAIPOLNB
{
	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CA0", Offset = "0x7F48A0", VA = "0x1807F5CA0")]
	public static DJCJAIPOLNB JLAKJAPJOGA()
	{
		return default(DJCJAIPOLNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void PHOGHLAAEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void NNBMICFFJJF(MOMCOKAPMLC PHBHEFAPHDL, object EJFGMPEJEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void KECDHBFGDIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal struct BAIOMEALKFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x28A2B80", Offset = "0x28A1780", VA = "0x1828A2B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x28A2870", Offset = "0x28A1470", VA = "0x1828A2870")]
	public static Task EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x28A2910", Offset = "0x28A1510", VA = "0x1828A2910")]
	private void EBDHDHCPNAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class HALPBDECPOJ : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class HOOOOLJDKPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public HALPBDECPOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private ODEOHNPPJCE <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private GEDJHDMKMOJ <serializeType>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private EJCOGPHMIIO <data>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private EJCOGPHMIIO <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<EJCOGPHMIIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HOOOOLJDKPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x3E14460", Offset = "0x3E13060", VA = "0x183E14460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly string OMCOJEIPFBM;

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x28B7080", Offset = "0x28B5C80", VA = "0x1828B7080")]
	public HALPBDECPOJ(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, string OMCOJEIPFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x28B6EE0", Offset = "0x28B5AE0", VA = "0x1828B6EE0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HOOOOLJDKPK))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class FGCIPEMNFIB
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class FPFKGKIMLDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public FEEJMENJLIJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public MOMCOKAPMLC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FPFKGKIMLDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x46256F0", Offset = "0x46242F0", VA = "0x1846256F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class HOKBGJMLPJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HOKBGJMLPJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class AEFOMBJCECP
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private sealed class <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public AEFOMBJCECP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x5830E50", Offset = "0x582FA50", VA = "0x185830E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public HOKBGJMLPJO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public AEFOMBJCECP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x461F9F0", Offset = "0x461E5F0", VA = "0x18461F9F0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task GFHFLIFEECL(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class EDMFOCENIMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private HOKBGJMLPJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private AEFOMBJCECP <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public EDMFOCENIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x4624580", Offset = "0x4623180", VA = "0x184624580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class IKAMJMIHKMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private Dictionary<Guid, List<LOHABELNFDM>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private KeyValuePair<Guid, List<LOHABELNFDM>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IKAMJMIHKMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x4628580", Offset = "0x4627180", VA = "0x184628580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class MFABEIDHFNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private EPJFONLPCOB <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private Dictionary<Guid, List<LOHABELNFDM>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private KeyValuePair<Guid, List<LOHABELNFDM>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MFABEIDHFNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x462D3D0", Offset = "0x462BFD0", VA = "0x18462D3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class FHANDLFJBHN
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		private sealed class <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public LOHABELNFDM handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public FHANDLFJBHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x582E650", Offset = "0x582D250", VA = "0x18582E650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public CCBIIAGKKBF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public List<LOHABELNFDM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FHANDLFJBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x4624FF0", Offset = "0x4623BF0", VA = "0x184624FF0")]
		internal object OOCPHPCALMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x4624EA0", Offset = "0x4623AA0", VA = "0x184624EA0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task LJMLNNODJOI(LOHABELNFDM handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x4624DB0", Offset = "0x46239B0", VA = "0x184624DB0")]
		internal object FGFDNIDPODJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class KAEGMPFOKFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public List<LOHABELNFDM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public CCBIIAGKKBF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private FHANDLFJBHN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private IEnumerable<Task> <handlerTasks>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KAEGMPFOKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x462B140", Offset = "0x4629D40", VA = "0x18462B140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class DPLDGBHGKKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DPLDGBHGKKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x4623960", Offset = "0x4622560", VA = "0x184623960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class FKHADMDJNNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FKHADMDJNNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x46250E0", Offset = "0x4623CE0", VA = "0x1846250E0")]
		internal object JCIHNDINDGA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class DGFHLDINIPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private FKHADMDJNNJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private EPJFONLPCOB <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private List<LOHABELNFDM> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DGFHLDINIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x46230C0", Offset = "0x4621CC0", VA = "0x1846230C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class FKODLABGDGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FKODLABGDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x4625150", Offset = "0x4623D50", VA = "0x184625150")]
		internal object IDJGMCAOGCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class GICFOPPJBMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public FGCIPEMNFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private FKODLABGDGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private FHMBHNPINBI <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private FHMBHNPINBI <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private FHMBHNPINBI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GICFOPPJBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x4625CD0", Offset = "0x46248D0", VA = "0x184625CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class JEFJPLMMIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JEFJPLMMIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x4629FC0", Offset = "0x4628BC0", VA = "0x184629FC0")]
		internal object CIGJJJMKAON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private readonly DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private NHOCFNNGHPA PDJAPHGOJJO;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private OOCGABPOHBK JMLCEDJKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x9C72D0", Offset = "0x9C5ED0", VA = "0x1809C72D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
	public FGCIPEMNFIB(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x28AB6E0", Offset = "0x28AA2E0", VA = "0x1828AB6E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPFKGKIMLDE))]
	public Task EBDHDHCPNAJ(FEEJMENJLIJ ANPIEEIPNGA, MOMCOKAPMLC LPFGOIILFCI, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x28ABF70", Offset = "0x28AAB70", VA = "0x1828ABF70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDMFOCENIMJ))]
	private Task MDBDAHGPHLI(MOMCOKAPMLC PHBHEFAPHDL, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x28AC110", Offset = "0x28AAD10", VA = "0x1828AC110")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKAMJMIHKMJ))]
	private Task NFEOFNICAPL(MOMCOKAPMLC PHBHEFAPHDL, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x28AC2B0", Offset = "0x28AAEB0", VA = "0x1828AC2B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFABEIDHFNA))]
	private Task ODLJCAKAKJF(MOMCOKAPMLC PHBHEFAPHDL, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x28AB3E0", Offset = "0x28A9FE0", VA = "0x1828AB3E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KAEGMPFOKFN))]
	private Task BADLLBBHBPG(Guid LHPBOIAGPAE, List<LOHABELNFDM> AGGDAPBJMLG, CCBIIAGKKBF KGEBDJDHLNM, MOMCOKAPMLC PHBHEFAPHDL, CancellationToken FLDJLPKNKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x28AC620", Offset = "0x28AB220", VA = "0x1828AC620")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPLDGBHGKKI))]
	private Task PGNMNKPPBNP(MOMCOKAPMLC PHBHEFAPHDL, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x28ABA40", Offset = "0x28AA640", VA = "0x1828ABA40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DGFHLDINIPD))]
	private Task INKOGJEKMAK(Guid HFCGDHHIMNG, MOMCOKAPMLC PHBHEFAPHDL, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x28AB8A0", Offset = "0x28AA4A0", VA = "0x1828AB8A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GICFOPPJBMK))]
	private Task HNEFEANOHEL(Guid HFCGDHHIMNG, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x28ABDD0", Offset = "0x28AA9D0", VA = "0x1828ABDD0")]
	private void LFPLGDKICKH(Guid HFCGDHHIMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x28AB5B0", Offset = "0x28AA1B0", VA = "0x1828AB5B0")]
	private void DFKPCMHLPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x28ABC00", Offset = "0x28AA800", VA = "0x1828ABC00")]
	public Guid KHIPIIGIPHJ(FEEJMENJLIJ JCEEBLIDOHD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x28AC450", Offset = "0x28AB050", VA = "0x1828AC450")]
	[CompilerGenerated]
	private object OKHGFMAGDMG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal struct HPDLGGGIPCI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private readonly DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private readonly Guid DGPMAIKFGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private bool GGKLFMPBGIO;

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x28BAEF0", Offset = "0x28B9AF0", VA = "0x1828BAEF0")]
	public static HPDLGGGIPCI HMNMIJCBGAE(DNKNJNMAMBL GIOAKJNONKE)
	{
		return default(HPDLGGGIPCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x14AC510", Offset = "0x14AB110", VA = "0x1814AC510")]
	public void GCNHMDLKOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x28BAAF0", Offset = "0x28B96F0", VA = "0x1828BAAF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x28BAF50", Offset = "0x28B9B50", VA = "0x1828BAF50")]
	private HPDLGGGIPCI(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x28BAB00", Offset = "0x28B9700", VA = "0x1828BAB00")]
	private void FNEOFEGLMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x28BAE40", Offset = "0x28B9A40", VA = "0x1828BAE40")]
	private Func<Guid, bool> GGOOKBJFPAH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal struct GHMJGCHLAMJ
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class OCAPNIKIGKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public AsyncTaskMethodBuilder<HOAOFNBBEKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public GHMJGCHLAMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private HOAOFNBBEKI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private TaskAwaiter<HOAOFNBBEKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public OCAPNIKIGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x46318A0", Offset = "0x46304A0", VA = "0x1846318A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class CMCDKECJNFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public AsyncTaskMethodBuilder<HOAOFNBBEKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public GHMJGCHLAMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private HOAOFNBBEKI <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private HOAOFNBBEKI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter<HOAOFNBBEKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CMCDKECJNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x4622860", Offset = "0x4621460", VA = "0x184622860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class CKIHIOIOIKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CKIHIOIOIKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x10546F0", Offset = "0x10532F0", VA = "0x1810546F0")]
		internal bool LNEIIDGCIHH(MPOOILGCDLJ sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class GJFMNLKEGFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public AsyncTaskMethodBuilder<HOAOFNBBEKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public HBPPPIGEKFO callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public EFENBEKLEHO superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private CKIHIOIOIKD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private IEMLKNOFDEG <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private MPOOILGCDLJ <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private EFENBEKLEHO <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private EFENBEKLEHO <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private IEMLKNOFDEG <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private CAIGCNABMEN <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private CAIGCNABMEN <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private BNNPCINDEGK <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private BNNPCINDEGK <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter<IEMLKNOFDEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter<CAIGCNABMEN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private TaskAwaiter<BNNPCINDEGK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GJFMNLKEGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x46263A0", Offset = "0x4624FA0", VA = "0x1846263A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private KFDAFKKLOKJ BBMCDOFLCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private long HAMIEGOKEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private long BPODGJMCBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private long PJBAEAJLHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private string APOLELLKJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private EFENBEKLEHO MCALOEENHGB;

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x28B1F00", Offset = "0x28B0B00", VA = "0x1828B1F00")]
	public static Task<HOAOFNBBEKI> AHEFPBBKFFG(IFNNJAAOEDN FNIFBLHBOOE, LCMHJBMHMJN PAJPFFIMEFB, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x28B2140", Offset = "0x28B0D40", VA = "0x1828B2140")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OCAPNIKIGKA))]
	private Task<HOAOFNBBEKI> EBDHDHCPNAJ(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x28B2300", Offset = "0x28B0F00", VA = "0x1828B2300")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CMCDKECJNFC))]
	private Task<HOAOFNBBEKI> PKKFKJPCEJM(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x28B24C0", Offset = "0x28B10C0", VA = "0x1828B24C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GJFMNLKEGFN))]
	private static Task<HOAOFNBBEKI> PKKFKJPCEJM(HBPPPIGEKFO FGOMHOJPKFO, long HAMIEGOKEJC, long BPODGJMCBKI, long PJBAEAJLHMO, string APOLELLKJLH, EFENBEKLEHO MCALOEENHGB, CancellationToken GFFFFCALMCA, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x28B22D0", Offset = "0x28B0ED0", VA = "0x1828B22D0")]
	private void LPAPCMDMINF(IEMLKNOFDEG KBEKHLAONIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal struct CPIAHEMPDLH
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class BMNCHDCGPHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public IFNNJAAOEDN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BMNCHDCGPHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x30A00E0", Offset = "0x309ECE0", VA = "0x1830A00E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class PFHEKBMPLGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CPIAHEMPDLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public PFHEKBMPLGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x30B7840", Offset = "0x30B6440", VA = "0x1830B7840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private ByteString EPBBCHCFEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private bool KFPBILIFIBE;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x28A5CA0", Offset = "0x28A48A0", VA = "0x1828A5CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private bool CMJEGCCGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x28A5820", Offset = "0x28A4420", VA = "0x1828A5820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private bool GHKKGJHEJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x28A5C10", Offset = "0x28A4810", VA = "0x1828A5C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x28A5A30", Offset = "0x28A4630", VA = "0x1828A5A30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMNCHDCGPHA))]
	public static Task EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, DNKNJNMAMBL GIOAKJNONKE, bool KFPBILIFIBE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x28A58A0", Offset = "0x28A44A0", VA = "0x1828A58A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PFHEKBMPLGI))]
	private Task EBDHDHCPNAJ(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal static class IBJOFFOKACF
{
	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x28BB650", Offset = "0x28BA250", VA = "0x1828BB650")]
	public static void PCHJIMFINCP(this MHBAMGOJMJJ EMBLDIHCMDD, MHKEFJDKLJN IKINGJFLMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x28BB570", Offset = "0x28BA170", VA = "0x1828BB570")]
	public static void ONPCOIPELPC(this MHKEFJDKLJN BIJBNMHAAEB, [Optional] string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct KDOBEABEJCC
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class AMCFCMFCJDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public KDOBEABEJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public AMCFCMFCJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x3E0CC60", Offset = "0x3E0B860", VA = "0x183E0CC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private const int IONIJIHONCB = 20;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private const float ODNMBOGAIGP = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private HBPPPIGEKFO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private float HIGFILGGHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private float NOIPBOGFHJO;

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x28C0A90", Offset = "0x28BF690", VA = "0x1828C0A90")]
	public static Task OKJLIDIOPDP(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x28C04F0", Offset = "0x28BF0F0", VA = "0x1828C04F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMCFCMFCJDF))]
	public Task EBDHDHCPNAJ(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x28C0820", Offset = "0x28BF420", VA = "0x1828C0820")]
	private static void LCNEGKJELNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x28C0640", Offset = "0x28BF240", VA = "0x1828C0640")]
	private void GDANKPGCFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x28C09D0", Offset = "0x28BF5D0", VA = "0x1828C09D0")]
	private static float NDBEBOAFCNO(HBPPPIGEKFO FGOMHOJPKFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x28C04D0", Offset = "0x28BF0D0", VA = "0x1828C04D0")]
	private static float BDPLCDDDLOM()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal class DNKNJNMAMBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class DOBNPFEKFGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private FHMBHNPINBI <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private GOMGBFEPMOD.DAMKOIBGCAN<FHMBHNPINBI> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private TaskAwaiter<GOMGBFEPMOD.DAMKOIBGCAN<FHMBHNPINBI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DOBNPFEKFGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x4623600", Offset = "0x4622200", VA = "0x184623600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct FJHJBJJDJBO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class EBDNOJNGGFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public EBDNOJNGGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x4623C10", Offset = "0x4622810", VA = "0x184623C10")]
		internal FHMBHNPINBI LEODIPOBJPJ(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class CAPHFHKELHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AsyncTaskMethodBuilder<GOMGBFEPMOD.DAMKOIBGCAN<FHMBHNPINBI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public FHMBHNPINBI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private EBDNOJNGGFI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private FMEHMMJPLED <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private GOMGBFEPMOD.DAMKOIBGCAN<FHMBHNPINBI> <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private FMEHMMJPLED <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private GOMGBFEPMOD.DAMKOIBGCAN<FHMBHNPINBI> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private string <errorMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private ByteString <actualOperationId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private string <errorMessage>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter<GOMGBFEPMOD.DAMKOIBGCAN<FHMBHNPINBI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CAPHFHKELHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x4621230", Offset = "0x461FE30", VA = "0x184621230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class HCPFLFMCDKD<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private T <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public HCPFLFMCDKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x3324F20", Offset = "0x3323B20", VA = "0x183324F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class CGAABHDLBCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CGAABHDLBCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x46226D0", Offset = "0x46212D0", VA = "0x1846226D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class KMDLHFGAEGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KMDLHFGAEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x462C9E0", Offset = "0x462B5E0", VA = "0x18462C9E0")]
		internal object DGMFOAMKODM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x462CA40", Offset = "0x462B640", VA = "0x18462CA40")]
		internal bool JLBECBGGGHD(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class ACDAKAILNCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ACDAKAILNCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x461F330", Offset = "0x461DF30", VA = "0x18461F330")]
		internal object KFDAPPMDKLC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class KPMMMFPAAFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KPMMMFPAAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x462CB50", Offset = "0x462B750", VA = "0x18462CB50")]
		internal object KFKIOBBMGPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private sealed class BMJJEMONBFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BMJJEMONBFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x46211C0", Offset = "0x461FDC0", VA = "0x1846211C0")]
		internal object NNBHOGNNNAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class EEHNALOIMMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public EEHNALOIMMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x46249F0", Offset = "0x46235F0", VA = "0x1846249F0")]
		internal object GFMPDMHHECN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class PNCBCFLBIPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public DNKNJNMAMBL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public PNCBCFLBIPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x4632790", Offset = "0x4631390", VA = "0x184632790")]
		internal object GFMPDMHHECN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly Guid DJJMHBANOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public readonly OOCGABPOHBK JMLCEDJKPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private readonly GOMGBFEPMOD BFLJPKHGFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private readonly GNOLCLOPLMD EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private readonly CAJCLGONHEA NFAOIEDIDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private bool LAOELOOGMGA;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x28A7F70", Offset = "0x28A6B70", VA = "0x1828A7F70")]
	public DNKNJNMAMBL(OOCGABPOHBK CDJHLNAAHGK, GOMGBFEPMOD BFLJPKHGFDA, GNOLCLOPLMD EKLPJDMGHDM, CAJCLGONHEA NFAOIEDIDLK, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x28A6B70", Offset = "0x28A5770", VA = "0x1828A6B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x28A6B70", Offset = "0x28A5770", VA = "0x1828A6B70")]
	public void GHEFBDNHOFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x28A6F90", Offset = "0x28A5B90", VA = "0x1828A6F90")]
	public void GFHHOGMKBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x28A7D10", Offset = "0x28A6910", VA = "0x1828A7D10")]
	public void OIJBFLBKEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x28A7310", Offset = "0x28A5F10", VA = "0x1828A7310")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DOBNPFEKFGA))]
	internal Task<FHMBHNPINBI> HOMHGOLOBKD(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, FHMBHNPINBI IFPNDMLIDFN, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x28A0BB0", Offset = "0x289F7B0", VA = "0x1828A0BB0")]
	private static byte[] FFJHDGFFCLL<T>(T DKIECHCHJFL) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x36DBD30", Offset = "0x36DA930", VA = "0x1836DBD30")]
	private static T KLHCJOAGOJC<T>(MessageParser<T> IBLLODJKIEB, byte[] DKIECHCHJFL, T FKDPHGEANKE) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x28A6930", Offset = "0x28A5530", VA = "0x1828A6930")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CAPHFHKELHD))]
	private Task<GOMGBFEPMOD.DAMKOIBGCAN<FHMBHNPINBI>> CBLDPLEGMFH(FHMBHNPINBI IFPNDMLIDFN, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x36DB540", Offset = "0x36DA140", VA = "0x1836DB540")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HCPFLFMCDKD<>))]
	internal Task<T> AAMJCEBHNLK<T>(CancellationToken KHEICKPBIBD, Func<CancellationToken, Task<T>> BGOAFADLINP, int HKJHFGACIPJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x28A66A0", Offset = "0x28A52A0", VA = "0x1828A66A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGAABHDLBCC))]
	internal Task AAMJCEBHNLK(CancellationToken KHEICKPBIBD, Func<CancellationToken, Task> BGOAFADLINP, int HKJHFGACIPJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x28A7E70", Offset = "0x28A6A70", VA = "0x1828A7E70")]
	public FHMBHNPINBI PNMFOCFOMAB(FMEHMMJPLED NFBFKALKFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x28A6D20", Offset = "0x28A5920", VA = "0x1828A6D20")]
	public CHIPOCIBCNK EEEFAHLJBNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x28A6B00", Offset = "0x28A5700", VA = "0x1828A6B00")]
	public GKJHOLDCGPO DGPOEEDKGHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x28A6830", Offset = "0x28A5430", VA = "0x1828A6830")]
	public ODEOHNPPJCE AIPAJGCCMHD([Optional] HDDCAHBLLEN? ODPKAHOAPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x28A6AD0", Offset = "0x28A56D0", VA = "0x1828A6AD0")]
	public void CLIKLGEOLOI(Func<Guid, bool> GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x28A7B30", Offset = "0x28A6730", VA = "0x1828A7B30")]
	public void MJACCIELGLP(Func<Guid, bool> MDEPBBGHKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x28A74D0", Offset = "0x28A60D0", VA = "0x1828A74D0")]
	public void IHBJGKALJNH(Func<Guid, bool> GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x28A70F0", Offset = "0x28A5CF0", VA = "0x1828A70F0")]
	public Guid HMNMIJCBGAE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x28A6DF0", Offset = "0x28A59F0", VA = "0x1828A6DF0")]
	public void FNEOFEGLMFJ(Guid DGPMAIKFGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x28A7990", Offset = "0x28A6590", VA = "0x1828A7990")]
	public void JLIDAKAHHGF(FHMBHNPINBI CJNGOOMCDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x28A7800", Offset = "0x28A6400", VA = "0x1828A7800")]
	public void JGIMFEIAGIB(string AENODGLJKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x28A7670", Offset = "0x28A6270", VA = "0x1828A7670")]
	public void JGIMFEIAGIB(Func<string> ANINAIMKMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x36DB940", Offset = "0x36DA540", VA = "0x1836DB940")]
	private T FPDLJJIJEGK<T>(T ECNGHFJBIJL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x28A7AE0", Offset = "0x28A66E0", VA = "0x1828A7AE0")]
	public void JONFDFHMGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x36DBA20", Offset = "0x36DA620", VA = "0x1836DBA20")]
	[CompilerGenerated]
	internal static string GNMOIDNMBHF<T>(byte[] ENEAOCDMOME, int NHAAHCAPBBL, ref FJHJBJJDJBO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal struct HJFCIFBFFAN
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class BNJECNBBNDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public IFNNJAAOEDN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BNJECNBBNDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E280", Offset = "0x3E0CE80", VA = "0x183E0E280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class OLJCAIFMKKA
	{
		[Cpp2IlInjected.Token(Token = "0x200012A")]
		private sealed class <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			public OLJCAIFMKKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x5830FB0", Offset = "0x582FBB0", VA = "0x185830FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public OLJCAIFMKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E210", Offset = "0x3E1CE10", VA = "0x183E1E210")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task GLEEEHPILGD(JAPPGKMKBNF<string>.KLCBHAGBNOA timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class NBDKEECBGFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public HJFCIFBFFAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private OLJCAIFMKKA <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private FHMBHNPINBI <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NBDKEECBGFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x3E1CD40", Offset = "0x3E1B940", VA = "0x183E1CD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class APLOCNLEJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public HBHNCFJCIKF version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public APLOCNLEJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D3B0", Offset = "0x3E0BFB0", VA = "0x183E0D3B0")]
		internal object LFDGDHKDBPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D490", Offset = "0x3E0C090", VA = "0x183E0D490")]
		internal object PANLPDDAKNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private bool AHCBJBINNOD;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private static readonly ByteString PNEAAGKPJOA;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x28B9190", Offset = "0x28B7D90", VA = "0x1828B9190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x28B9110", Offset = "0x28B7D10", VA = "0x1828B9110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x28B8790", Offset = "0x28B7390", VA = "0x1828B8790")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BNJECNBBNDK))]
	public static Task EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, DNKNJNMAMBL GIOAKJNONKE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA, bool AHCBJBINNOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x28B8610", Offset = "0x28B7210", VA = "0x1828B8610")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NBDKEECBGFM))]
	private Task EBDHDHCPNAJ(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x28B8970", Offset = "0x28B7570", VA = "0x1828B8970")]
	private void HBLHPLJNDNE([NotNull] BNIDNMGAHLD BBBFCKGLENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x28B90B0", Offset = "0x28B7CB0", VA = "0x1828B90B0")]
	private bool IAMNLMMFKKN(HBHNCFJCIKF FPBNFBFIPHI, BNIDNMGAHLD BBBFCKGLENJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal abstract class MMDFDPPJLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly OOCGABPOHBK JMLCEDJKPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly DNKNJNMAMBL LJLPJFLHKIG;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x30AD0F0", Offset = "0x30ABCF0", VA = "0x1830AD0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x30AD060", Offset = "0x30ABC60", VA = "0x1830AD060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x30AD140", Offset = "0x30ABD40", VA = "0x1830AD140")]
	protected MMDFDPPJLGH(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x30AD020", Offset = "0x30ABC20", VA = "0x1830AD020")]
	protected void JGIMFEIAGIB(string AENODGLJKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x30AD040", Offset = "0x30ABC40", VA = "0x1830AD040")]
	public void JGIMFEIAGIB(Func<string> ANINAIMKMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class GKJHOLDCGPO : MMDFDPPJLGH, IJBBBDBCHDL
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	public delegate Task<FEEJMENJLIJ> EBIHPHKNPFJ(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO HDMIPHANIGM, JJMPNGLGHEG OOKFEKMLPEH, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class KOBADOPLEPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private HPDLGGGIPCI <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private FHMBHNPINBI <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private FHMBHNPINBI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KOBADOPLEPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x3E188E0", Offset = "0x3E174E0", VA = "0x183E188E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class ALIADCLFAPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private FHMBHNPINBI <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private FHMBHNPINBI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ALIADCLFAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x461FB40", Offset = "0x461E740", VA = "0x18461FB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class PLHFNMLBOOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public PLHFNMLBOOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x3E1EAD0", Offset = "0x3E1D6D0", VA = "0x183E1EAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class KDPLHADDPBM
	{
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			public AsyncTaskMethodBuilder<HOAOFNBBEKI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			public KDPLHADDPBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private HOAOFNBBEKI <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			private HOAOFNBBEKI <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			private TaskAwaiter<FEEJMENJLIJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			private TaskAwaiter<HOAOFNBBEKI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0x582FB70", Offset = "0x582E770", VA = "0x18582FB70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000135")]
		private sealed class <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000524")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public AsyncTaskMethodBuilder<MOMCOKAPMLC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			public KDPLHADDPBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			private MOMCOKAPMLC <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			private MOMCOKAPMLC <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			private TaskAwaiter<FEEJMENJLIJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			private TaskAwaiter<MOMCOKAPMLC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x58302B0", Offset = "0x582EEB0", VA = "0x1858302B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000136")]
		private sealed class <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public KDPLHADDPBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private bool <isReloadingSceneForObjectModel>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private bool <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private KBOEHLEJIFO <timedYielder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private TaskAwaiter<FEEJMENJLIJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x582E7A0", Offset = "0x582D3A0", VA = "0x18582E7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public JJMPNGLGHEG preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public JJMPNGLGHEG downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public HOAOFNBBEKI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public JJMPNGLGHEG postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public MOMCOKAPMLC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public MCNPFMNGCKP.DIKEJOLIKNG <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KDPLHADDPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x462BA30", Offset = "0x462A630", VA = "0x18462BA30")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<HOAOFNBBEKI> OLFNNBMAJBB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x462B8C0", Offset = "0x462A4C0", VA = "0x18462B8C0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<MOMCOKAPMLC> MPFJOIFDDBL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x462B730", Offset = "0x462A330", VA = "0x18462B730")]
		internal void AFJKHOJOJAB(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x462B770", Offset = "0x462A370", VA = "0x18462B770")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task LNEKNOECPKF(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class KKLKNCNGHPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public LCMHJBMHMJN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private KDPLHADDPBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private HOAOFNBBEKI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private MOMCOKAPMLC <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter<HOAOFNBBEKI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private TaskAwaiter<MOMCOKAPMLC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KKLKNCNGHPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x462BCD0", Offset = "0x462A8D0", VA = "0x18462BCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class HKHHGLJAHFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HKHHGLJAHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x46275D0", Offset = "0x46261D0", VA = "0x1846275D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class KOJHPIJFHMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KOJHPIJFHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x3E18CD0", Offset = "0x3E178D0", VA = "0x183E18CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class LNNNDJNBBAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LNNNDJNBBAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E19F30", Offset = "0x3E18B30", VA = "0x183E19F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class JPCBMGCNAPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JPCBMGCNAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x462A480", Offset = "0x4629080", VA = "0x18462A480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class PIHBPJAJPAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public FEEJMENJLIJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public MOMCOKAPMLC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private FEEJMENJLIJ <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private FEEJMENJLIJ <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public PIHBPJAJPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E8B0", Offset = "0x3E1D4B0", VA = "0x183E1E8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class MNOCNAOEPAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public EBIHPHKNPFJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MNOCNAOEPAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class LFONGKNJCPM
	{
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			public LFONGKNJCPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			private FEEJMENJLIJ <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			private FEEJMENJLIJ <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			private TaskAwaiter<FEEJMENJLIJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x5830890", Offset = "0x582F490", VA = "0x185830890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public FEEJMENJLIJ originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public MNOCNAOEPAN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LFONGKNJCPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x3E19870", Offset = "0x3E18470", VA = "0x183E19870")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<FEEJMENJLIJ> LIKNGLIGDOM(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class IJMNEIPANCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public EBIHPHKNPFJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private MNOCNAOEPAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private LFONGKNJCPM <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private FEEJMENJLIJ <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IJMNEIPANCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x4627F90", Offset = "0x4626B90", VA = "0x184627F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class JGCCMPKDMFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public JJMPNGLGHEG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private FEEJMENJLIJ <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private IEnumerator<FEEJMENJLIJ> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private FEEJMENJLIJ <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JGCCMPKDMFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x462A030", Offset = "0x4628C30", VA = "0x18462A030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class GIAHGDCIJFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GIAHGDCIJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x4625AF0", Offset = "0x46246F0", VA = "0x184625AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class ELMNNEENDDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public GKJHOLDCGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ELMNNEENDDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x4624C70", Offset = "0x4623870", VA = "0x184624C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class OADHHJMCKAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public IEMLKNOFDEG roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public OADHHJMCKAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D730", Offset = "0x3E1C330", VA = "0x183E1D730")]
		internal object MCNFNPAMGDJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private readonly PKHKKGNCOIB PHDNNMDDLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private readonly PKHKKGNCOIB JLNPINILEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private readonly KFDAFKKLOKJ BBMCDOFLCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	private readonly FGCIPEMNFIB PDJAPHGOJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private readonly MMKBCFLLNID AMMLOCNKDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private readonly EIBOJBKNGCC KBDOFCNIKNN;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float NCJOEPAECEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x28B3770", Offset = "0x28B2370", VA = "0x1828B3770", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private IFNNJAAOEDN MIDAOOLAHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x28A2FC0", Offset = "0x28A1BC0", VA = "0x1828A2FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event BGAINELODGO MFBLCLAEJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x28B31A0", Offset = "0x28B1DA0", VA = "0x1828B31A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x28B3790", Offset = "0x28B2390", VA = "0x1828B3790", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x28B4950", Offset = "0x28B3550", VA = "0x1828B4950")]
	public GKJHOLDCGPO(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x28B2770", Offset = "0x28B1370", VA = "0x1828B2770")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KOBADOPLEPC))]
	public Task AFBDNMFFNNO(LCMHJBMHMJN PAJPFFIMEFB, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x28B3CB0", Offset = "0x28B28B0", VA = "0x1828B3CB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ALIADCLFAPI))]
	private Task<FHMBHNPINBI> MNKHHEFFBHJ(LCMHJBMHMJN PAJPFFIMEFB, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x28B41F0", Offset = "0x28B2DF0", VA = "0x1828B41F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PLHFNMLBOOG))]
	private Task OGNADIILDPL(LCMHJBMHMJN PAJPFFIMEFB, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x28B2910", Offset = "0x28B1510", VA = "0x1828B2910")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KKLKNCNGHPL))]
	private Task ALNDMCJPOAB(LCMHJBMHMJN PAJPFFIMEFB, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken ABPHAFIBLFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x28B3240", Offset = "0x28B1E40", VA = "0x1828B3240")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HKHHGLJAHFP))]
	private Task HBEDCFJFEGH(JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x28B45C0", Offset = "0x28B31C0", VA = "0x1828B45C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KOJHPIJFHMB))]
	private Task PAMMEKNKFJI(MOMCOKAPMLC PHBHEFAPHDL, JJMPNGLGHEG OOKFEKMLPEH, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x28B43B0", Offset = "0x28B2FB0", VA = "0x1828B43B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNNNDJNBBAH))]
	private Task<FEEJMENJLIJ> OJMFFDBOLEH(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JJMPNGLGHEG OOKFEKMLPEH, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x28B3560", Offset = "0x28B2160", VA = "0x1828B3560")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JPCBMGCNAPF))]
	private Task<FEEJMENJLIJ> JOHLFMHMGPF(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JJMPNGLGHEG OOKFEKMLPEH, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x28B2AB0", Offset = "0x28B16B0", VA = "0x1828B2AB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PIHBPJAJPAN))]
	private Task<FEEJMENJLIJ> CFNBNMAGJAI(FEEJMENJLIJ ANPIEEIPNGA, MOMCOKAPMLC LPFGOIILFCI, JJMPNGLGHEG OOKFEKMLPEH, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA, bool AEACNEFJOGB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x28B2F00", Offset = "0x28B1B00", VA = "0x1828B2F00")]
	private bool EOBOKBAFAHA(MOMCOKAPMLC BDIHDHOFGCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x28B2CD0", Offset = "0x28B18D0", VA = "0x1828B2CD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IJMNEIPANCG))]
	protected Task<FEEJMENJLIJ> CPHJEKLBCIA(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JJMPNGLGHEG OOKFEKMLPEH, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA, EBIHPHKNPFJ KOHPCLOMMME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x28B3AF0", Offset = "0x28B26F0", VA = "0x1828B3AF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGCCMPKDMFC))]
	private Task LHDPOJEDCCH(MOMCOKAPMLC PHBHEFAPHDL, JJMPNGLGHEG OOKFEKMLPEH, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x28B31F0", Offset = "0x28B1DF0", VA = "0x1828B31F0")]
	private void GODJEHFDFLK(FEEJMENJLIJ JCEEBLIDOHD, JJMPNGLGHEG OOKFEKMLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x28B33B0", Offset = "0x28B1FB0", VA = "0x1828B33B0")]
	private void HIMGBBKEHLL(FEEJMENJLIJ PNPIHEBMMAF, out FEEJMENJLIJ NIJDJEIKOHG, out FEEJMENJLIJ PGPPIMDDDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x28B4780", Offset = "0x28B3380", VA = "0x1828B4780")]
	private Task<HOAOFNBBEKI> PKKFKJPCEJM(LCMHJBMHMJN PAJPFFIMEFB, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x28B37B0", Offset = "0x28B23B0", VA = "0x1828B37B0")]
	private Task<MOMCOKAPMLC> LBGGPNKPEGI(HOAOFNBBEKI PHBHEFAPHDL, MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x28B3E70", Offset = "0x28B2A70", VA = "0x1828B3E70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GIAHGDCIJFI))]
	private Task NKKGJGLDCND(MOMCOKAPMLC PHBHEFAPHDL, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA, bool AHCBJBINNOD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x28B33F0", Offset = "0x28B1FF0", VA = "0x1828B33F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ELMNNEENDDE))]
	private Task INICKHECGBO(MOMCOKAPMLC PHBHEFAPHDL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x28B31C0", Offset = "0x28B1DC0", VA = "0x1828B31C0")]
	private Task GHJJBNNJIJH(MOMCOKAPMLC PHBHEFAPHDL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x28B37F0", Offset = "0x28B23F0", VA = "0x1828B37F0")]
	private Task LFPFADFFFOD(MOMCOKAPMLC PHBHEFAPHDL, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x28B4050", Offset = "0x28B2C50", VA = "0x1828B4050")]
	private Task NOHMJANJBLO(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x28B4390", Offset = "0x28B2F90", VA = "0x1828B4390")]
	private Task OIJPJEJGECB(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x28B2CC0", Offset = "0x28B18C0", VA = "0x1828B2CC0")]
	private static Task CMPFMOKIHJM(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x28B3000", Offset = "0x28B1C00", VA = "0x1828B3000")]
	private Task FLNALACEMCA(MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x28B47C0", Offset = "0x28B33C0", VA = "0x1828B47C0")]
	private Task PMDGJLMKDEO(MOMCOKAPMLC PHBHEFAPHDL, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x28B26F0", Offset = "0x28B12F0", VA = "0x1828B26F0")]
	private void ADDCJIACHFB(LCMHJBMHMJN PAJPFFIMEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x28B4030", Offset = "0x28B2C30", VA = "0x1828B4030")]
	public void NMDPBHDBMCB(long BFNOJMGJLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x28B3980", Offset = "0x28B2580", VA = "0x1828B3980")]
	private static void LHBDBMCPEID(IEMLKNOFDEG KBEKHLAONIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class OOCGABPOHBK : IJBBBDBCHDL
{
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public delegate Task CCKHPCNCINE(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class GOOPIPHKBGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public OOCGABPOHBK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GOOPIPHKBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x582A100", Offset = "0x5828D00", VA = "0x18582A100")]
		internal Task KFBCMDIONEB(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class NCGFODONIBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public GOOPIPHKBGO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NCGFODONIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x582DC80", Offset = "0x582C880", VA = "0x18582DC80")]
		internal object LIAABDJAIFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x582DBC0", Offset = "0x582C7C0", VA = "0x18582DBC0")]
		internal object DEOHCKBFELK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class LDKEPLLJLBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public Func<OOCGABPOHBK, JAPPGKMKBNF<string>.KLCBHAGBNOA, DNKNJNMAMBL> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public OOCGABPOHBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private GOOPIPHKBGO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private DNKNJNMAMBL <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private FHMBHNPINBI <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private NCGFODONIBG <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private TaskAwaiter<FHMBHNPINBI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LDKEPLLJLBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x582C9E0", Offset = "0x582B5E0", VA = "0x18582C9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class FPEEOOMFCLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public OOCGABPOHBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private CCKHPCNCINE <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FPEEOOMFCLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x5829630", Offset = "0x5828230", VA = "0x185829630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	public readonly Guid ECPEBOBBOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005B4")]
	public readonly ByteString EFOLDDOJBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005B5")]
	public readonly FFLEKJBGAJJ GNCPOEKCNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005B6")]
	protected readonly string ENKPPJMNOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	private readonly IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	private readonly bool NKALOKKDEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private readonly Queue<CCKHPCNCINE> CKEJOMFOFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private readonly JJMPNGLGHEG KHIMDJKCMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private readonly NBGKOOKNBGP KAINKNJPFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private bool KELEEIEIJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	public FEEJMENJLIJ MEKBPOFNJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	public FEEJMENJLIJ CCPIJDABOGH;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public IFNNJAAOEDN MIDAOOLAHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x843910", Offset = "0x842510", VA = "0x180843910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x30B4CE0", Offset = "0x30B38E0", VA = "0x1830B4CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public KDHGMPHKPAM MAEKOJNKJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x30B4460", Offset = "0x30B3060", VA = "0x1830B4460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public PJEIECLNICO IKICDODJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x30B4A50", Offset = "0x30B3650", VA = "0x1830B4A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public float NCJOEPAECEI
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x30B4A30", Offset = "0x30B3630", VA = "0x1830B4A30", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event BGAINELODGO MFBLCLAEJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x30B47C0", Offset = "0x30B33C0", VA = "0x1830B47C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x30B4AD0", Offset = "0x30B36D0", VA = "0x1830B4AD0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x30B4E00", Offset = "0x30B3A00", VA = "0x1830B4E00")]
	protected OOCGABPOHBK(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, string GLKMDMPJGOE, NBGKOOKNBGP KAINKNJPFIL, bool NKALOKKDEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x30B4D30", Offset = "0x30B3930", VA = "0x1830B4D30", Slot = "7")]
	protected virtual string OGMLKJNLLDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x30B4C80", Offset = "0x30B3880", VA = "0x1830B4C80")]
	public void NHPPAEELKCK(CCKHPCNCINE GALABLGPLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x30B4440", Offset = "0x30B3040", VA = "0x1830B4440")]
	protected void BCPEPPDCJKH(float CJLBHCOPODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x30B44B0", Offset = "0x30B30B0", VA = "0x1830B44B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LDKEPLLJLBI))]
	public Task EBDHDHCPNAJ(CancellationToken GFFFFCALMCA, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, [Optional] Func<OOCGABPOHBK, JAPPGKMKBNF<string>.KLCBHAGBNOA, DNKNJNMAMBL> BGBLFFHKMNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x30B4AF0", Offset = "0x30B36F0", VA = "0x1830B4AF0")]
	private void MMAADBGCIOJ(bool GGKLFMPBGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x30B4650", Offset = "0x30B3250", VA = "0x1830B4650")]
	private void EJJLPNLDKJF(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x30B48C0", Offset = "0x30B34C0", VA = "0x1830B48C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPEEOOMFCLF))]
	private Task KIPAPEBLLFA(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x30B4D70", Offset = "0x30B3970", VA = "0x1830B4D70")]
	public FHMBHNPINBI PNMFOCFOMAB(FMEHMMJPLED NFBFKALKFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x30B47E0", Offset = "0x30B33E0", VA = "0x1830B47E0")]
	[CompilerGenerated]
	private Task INKIGFIEKNB(CancellationToken NFOHJNABMAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal abstract class HALIFADCDEK : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class ODGPPHCBEIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public HALIFADCDEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public JKKCGILCDLC playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ODGPPHCBEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E1D0", Offset = "0x3E1CDD0", VA = "0x183E1E1D0")]
		internal Task JDIGKAGBKKG(JAPPGKMKBNF<string>.KLCBHAGBNOA postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E150", Offset = "0x3E1CD50", VA = "0x183E1E150")]
		internal object DFADCLAMOEJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class ADKLKAGGMBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public HALIFADCDEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private ODGPPHCBEIG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private FJHFJBECMEA <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ADKLKAGGMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C4E0", Offset = "0x3E0B0E0", VA = "0x183E0C4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class FKKENGMBJHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public JKKCGILCDLC playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public HALIFADCDEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FKKENGMBJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x3E12230", Offset = "0x3E10E30", VA = "0x183E12230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x28B6E90", Offset = "0x28B5A90", VA = "0x1828B6E90")]
	public HALIFADCDEK(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, string GLKMDMPJGOE, NBGKOOKNBGP KAINKNJPFIL, bool NKALOKKDEMD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x28B6B50", Offset = "0x28B5750", VA = "0x1828B6B50", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ADKLKAGGMBI))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task FKNGBCPGLCB(DNKNJNMAMBL GIOAKJNONKE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x28B6CF0", Offset = "0x28B58F0", VA = "0x1828B6CF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FKKENGMBJHN))]
	private Task FGELCBKCCBC(IDisposable EMPFBCPNLOM, JKKCGILCDLC DAAJGDLADDK, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public readonly struct EJCOGPHMIIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	public readonly BNIDNMGAHLD? DGLPPFDBOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	public readonly HMMFOJPJNIB GNMDELMPCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	public readonly string? ANPLPHIDDDD;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public IReadOnlyCollection<string> AKNGEHCHFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x28A89E0", Offset = "0x28A75E0", VA = "0x1828A89E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public IReadOnlyDictionary<long, int> BFHLGIBMCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x28A89C0", Offset = "0x28A75C0", VA = "0x1828A89C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x28A8A00", Offset = "0x28A7600", VA = "0x1828A8A00")]
	public EJCOGPHMIIO(BNIDNMGAHLD? CMMCIHFHBLL, HMMFOJPJNIB BAKFLNODNMF, string? OPOLKMBAJBK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct DAKNPDIODMG
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class DAHIOEPMHEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private OOCGABPOHBK <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private IFNNJAAOEDN <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private MCGDFABKIDE.CJJHBHDMDGF <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DAHIOEPMHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x30A0AD0", Offset = "0x309F6D0", VA = "0x1830A0AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class ICBGILBPKLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private OFOJCNIGMKF.DIFMDKNFLDE <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ICBGILBPKLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x4627CC0", Offset = "0x46268C0", VA = "0x184627CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x28A5CF0", Offset = "0x28A48F0", VA = "0x1828A5CF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DAHIOEPMHEI))]
	public static Task EBDHDHCPNAJ(DNKNJNMAMBL GIOAKJNONKE, MOMCOKAPMLC PHBHEFAPHDL, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x28A5F90", Offset = "0x28A4B90", VA = "0x1828A5F90")]
	private static Task<FHMBHNPINBI> HOPFINEJIFM(DNKNJNMAMBL GIOAKJNONKE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x28A5E90", Offset = "0x28A4A90", VA = "0x1828A5E90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ICBGILBPKLB))]
	private static Task HDKKLIHOIED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal class ALJGLPODJGB : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class JLDHJELDELH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public ALJGLPODJGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private ObscuredInt <localPlayerAccountId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private CHIPOCIBCNK <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private EJCOGPHMIIO <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private NNENOOPKHPC <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private LPCDCAILFOA <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private TaskAwaiter<LPCDCAILFOA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JLDHJELDELH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x30A3A90", Offset = "0x30A2690", VA = "0x1830A3A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private readonly int GHGOMENDEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private readonly HCKACEFMPCF IPKBJACGFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	public readonly long DAGKDGGNPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	public readonly long LIHCFOABGDD;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public LPCDCAILFOA FKHLJHDJBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x9A4AD0", Offset = "0x9A36D0", VA = "0x1809A4AD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x8855D0", VA = "0x1808869D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x28A1910", Offset = "0x28A0510", VA = "0x1828A1910")]
	public ALJGLPODJGB(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, int GHGOMENDEDC, HCKACEFMPCF IPKBJACGFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x28A1770", Offset = "0x28A0370", VA = "0x1828A1770", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JLDHJELDELH))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct MMKBCFLLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class CKHECKBOOCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public FEEJMENJLIJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public MOMCOKAPMLC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public MMKBCFLLNID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private FEEJMENJLIJ <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private TaskAwaiter<FEEJMENJLIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CKHECKBOOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x5827E70", Offset = "0x5826A70", VA = "0x185827E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class EEIEBBKOHCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder<FEEJMENJLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public FEEJMENJLIJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public MMKBCFLLNID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private FHMBHNPINBI <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private FHMBHNPINBI <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private FEEJMENJLIJ <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private FHMBHNPINBI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public EEIEBBKOHCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x5828740", Offset = "0x5827340", VA = "0x185828740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private readonly DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private readonly KFDAFKKLOKJ BBMCDOFLCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	private readonly FGCIPEMNFIB PDJAPHGOJJO;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private OOCGABPOHBK JMLCEDJKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xB1B5D0", Offset = "0xB1A1D0", VA = "0x180B1B5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x30AD5C0", Offset = "0x30AC1C0", VA = "0x1830AD5C0")]
	public MMKBCFLLNID(DNKNJNMAMBL GIOAKJNONKE, KFDAFKKLOKJ BBMCDOFLCKN, FGCIPEMNFIB PDJAPHGOJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x30AD3C0", Offset = "0x30ABFC0", VA = "0x1830AD3C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKHECKBOOCL))]
	public Task<FEEJMENJLIJ> ODOLNCDCMAM(FEEJMENJLIJ NLMOCMPGOJG, MOMCOKAPMLC LPFGOIILFCI, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA, bool AEACNEFJOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x30AD1F0", Offset = "0x30ABDF0", VA = "0x1830AD1F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EEIEBBKOHCO))]
	private Task<FEEJMENJLIJ> JPLBJBAIGLB(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, FEEJMENJLIJ LLBKKANHBEL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x30AD1A0", Offset = "0x30ABDA0", VA = "0x1830AD1A0")]
	private bool IDDEHCKMEOE(FEEJMENJLIJ PFCONCOBCPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x30AD1D0", Offset = "0x30ABDD0", VA = "0x1830AD1D0")]
	private void JGIMFEIAGIB(string BAMBEECFNAE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct LEMBBABKCMD
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class JGICAPHJDJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private OOCGABPOHBK <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private FEEJMENJLIJ <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private IFNNJAAOEDN <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		private HBPPPIGEKFO <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private DJCJAIPOLNB <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private List<(PersistenceView, HGNMPOIAAKI)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private HGNMPOIAAKI <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JGICAPHJDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x3E16F10", Offset = "0x3E15B10", VA = "0x183E16F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x30A7C20", Offset = "0x30A6820", VA = "0x1830A7C20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGICAPHJDJM))]
	public static Task EBDHDHCPNAJ(DNKNJNMAMBL GIOAKJNONKE, MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x30A7DE0", Offset = "0x30A69E0", VA = "0x1830A7DE0")]
	private static void GPJDDHKDCEH(PersistenceView AFCPDJEIDLD, HGNMPOIAAKI EJFGMPEJEDD, MOMCOKAPMLC PHBHEFAPHDL, FEEJMENJLIJ ANPIEEIPNGA, bool FPJMKDBAJEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal class ODEOHNPPJCE : MMDFDPPJLGH
{
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private sealed class PNIIAJKOJJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public AsyncTaskMethodBuilder<EJCOGPHMIIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public GEDJHDMKMOJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public ODEOHNPPJCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private StringBuilder <outputBuilder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public PNIIAJKOJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x582E190", Offset = "0x582CD90", VA = "0x18582E190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class AKMOPGEKCBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public GEDJHDMKMOJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public ODEOHNPPJCE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public AKMOPGEKCBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x5826DF0", Offset = "0x58259F0", VA = "0x185826DF0")]
		internal Task IPCOIKAEFCP(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x5826D10", Offset = "0x5825910", VA = "0x185826D10")]
		internal Task FLNANOFJGAF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class CAEMKKCFOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public AKMOPGEKCBI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CAEMKKCFOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x5827750", Offset = "0x5826350", VA = "0x185827750")]
		internal object EDMGLJGPCAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class KCDLEBKFKAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public AKMOPGEKCBI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KCDLEBKFKAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x582C080", Offset = "0x582AC80", VA = "0x18582C080")]
		internal Task IMBPIJANEMN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class JHMCEHBCHMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public GEDJHDMKMOJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public ODEOHNPPJCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private AKMOPGEKCBI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private CAEMKKCFOBA <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JHMCEHBCHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x582B120", Offset = "0x5829D20", VA = "0x18582B120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	private readonly HDDCAHBLLEN ODPKAHOAPPJ;

	[Cpp2IlInjected.Token(Token = "0x400064C")]
	private static readonly TimeSpan MDINOJPLKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	private readonly PMBFCJLIGBB NILLNCDAMFL;

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x30B2A40", Offset = "0x30B1640", VA = "0x1830B2A40")]
	public ODEOHNPPJCE(DNKNJNMAMBL GIOAKJNONKE, PMBFCJLIGBB NILLNCDAMFL, [Optional] HDDCAHBLLEN? ODPKAHOAPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x30B18C0", Offset = "0x30B04C0", VA = "0x1830B18C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PNIIAJKOJJP))]
	public Task<EJCOGPHMIIO> ECCPKOGLKLF(long BPODGJMCBKI, string OPOLKMBAJBK, GEDJHDMKMOJ GIOCABEBNHM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x30B2090", Offset = "0x30B0C90", VA = "0x1830B2090")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JHMCEHBCHMA))]
	private Task GABMMOLFOOI(GEDJHDMKMOJ GIOCABEBNHM, IEnumerable<PersistenceView> DLPOCMMMECH, StringBuilder LEMKHGBBJGF, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x30B1A90", Offset = "0x30B0690", VA = "0x1830B1A90")]
	private EJCOGPHMIIO FLPDHPEMPDO(long BPODGJMCBKI, string OPOLKMBAJBK, GEDJHDMKMOJ GIOCABEBNHM, IEnumerable<PersistenceView> DLPOCMMMECH, StringBuilder LEMKHGBBJGF)
	{
		return default(EJCOGPHMIIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x30B1740", Offset = "0x30B0340", VA = "0x1830B1740")]
	private BNIDNMGAHLD EBEMJAMFINA(long BPODGJMCBKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x30B2250", Offset = "0x30B0E50", VA = "0x1830B2250")]
	private void GHBMEODOLDG(BNIDNMGAHLD PJDCDPIPHBA, StringBuilder LEMKHGBBJGF, IEnumerable<PersistenceView> DLPOCMMMECH, in DHJIDMGNJIC AKDAOECFHJI, EKIEPCIPJDM LHNAPAPHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x30B2460", Offset = "0x30B1060", VA = "0x1830B2460")]
	private void JHJPBFNLODM(BNIDNMGAHLD PJDCDPIPHBA, StringBuilder LEMKHGBBJGF, PersistenceView AFCPDJEIDLD, ref EKIEPCIPJDM LHNAPAPHKDJ, in DHJIDMGNJIC AKDAOECFHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal class MKKIMDKIEJP : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class BKDBAOGEJEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public MKKIMDKIEJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private string <unityAssetId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private ODEOHNPPJCE <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private GEDJHDMKMOJ <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private EJCOGPHMIIO <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private EJCOGPHMIIO <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private TaskAwaiter<EJCOGPHMIIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BKDBAOGEJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x58270E0", Offset = "0x5825CE0", VA = "0x1858270E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private readonly NFBLDIHAPOJ GJGJDNGPKAK;

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x30AC320", Offset = "0x30AAF20", VA = "0x1830AC320")]
	public MKKIMDKIEJP(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB, NFBLDIHAPOJ GJGJDNGPKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x30AC240", Offset = "0x30AAE40", VA = "0x1830AC240", Slot = "7")]
	protected override string OGMLKJNLLDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x30AC0A0", Offset = "0x30AACA0", VA = "0x1830AC0A0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BKDBAOGEJEB))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct NHOCFNNGHPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	public Dictionary<Guid, List<LOHABELNFDM>> LMICAEJEHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	public Dictionary<Guid, List<LOHABELNFDM>> KNILAHAGHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	public Dictionary<Guid, List<LOHABELNFDM>> NPHBJECFANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	public List<Guid> MDEIBJCFAKB;

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x30AEA30", Offset = "0x30AD630", VA = "0x1830AEA30")]
	public static NHOCFNNGHPA PNBJHLBKMLC(HBPPPIGEKFO FGOMHOJPKFO, FEEJMENJLIJ ANPIEEIPNGA, MOMCOKAPMLC LPFGOIILFCI)
	{
		return default(NHOCFNNGHPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
public readonly struct IEGAONCOOPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	public readonly bool IFOBDMNOJDF;

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x1133470", Offset = "0x1132070", VA = "0x181133470")]
	public IEGAONCOOPP(bool MKAIJMBKJCH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct BFGPKLGDCDD
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class NFKAOJCGFOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public OOCGABPOHBK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public KBOEHLEJIFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private FEEJMENJLIJ <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private List<(PersistenceView, HGNMPOIAAKI)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private (PersistenceView, HGNMPOIAAKI) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private CKGIIPHAJBG <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NFKAOJCGFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x30ADBE0", Offset = "0x30AC7E0", VA = "0x1830ADBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x28A2BD0", Offset = "0x28A17D0", VA = "0x1828A2BD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NFKAOJCGFOD))]
	public static Task EBDHDHCPNAJ(OOCGABPOHBK CDJHLNAAHGK, MOMCOKAPMLC PHBHEFAPHDL, KBOEHLEJIFO ELADCHKIOOE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct KPGCBEAGKPL
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class IKGBMMJPPDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public AsyncTaskMethodBuilder<MOMCOKAPMLC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public MCNPFMNGCKP.DIKEJOLIKNG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public KPGCBEAGKPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private Task<PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private Task<PKJAENHCLMN<HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private Task<PKJAENHCLMN<HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private Task<PKJAENHCLMN<HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private Task<(PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>, PKJAENHCLMN<HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>, PKJAENHCLMN<HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>, PKJAENHCLMN<HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private PKJAENHCLMN<HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private PKJAENHCLMN<HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private PKJAENHCLMN<HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private HCLLLJEDILH<BNIDNMGAHLD> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private (PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>, PKJAENHCLMN<HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>, PKJAENHCLMN<HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>, PKJAENHCLMN<HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private (PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>, PKJAENHCLMN<HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>, PKJAENHCLMN<HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>, PKJAENHCLMN<HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private TaskAwaiter<(PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>, PKJAENHCLMN<HCLLLJEDILH<BNIDNMGAHLD>, CMPFHAIKIAN>, PKJAENHCLMN<HCLLLJEDILH<CIOHJELGAHC>, CMPFHAIKIAN>, PKJAENHCLMN<HCLLLJEDILH<DBGKDIDMLDF>, CMPFHAIKIAN>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IKGBMMJPPDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x3E16090", Offset = "0x3E14C90", VA = "0x183E16090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class LNFOAOHAJON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public AsyncTaskMethodBuilder<PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public MCNPFMNGCKP.DIKEJOLIKNG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public KPGCBEAGKPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private TaskAwaiter<PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LNFOAOHAJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x3E199E0", Offset = "0x3E185E0", VA = "0x183E199E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private OOIGBDNKEMF<EFENBEKLEHO, CIOHJELGAHC> KFFNOKPJFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private OOIGBDNKEMF<EFENBEKLEHO, BNIDNMGAHLD> ICPMNAKBCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private OOIGBDNKEMF<long, DBGKDIDMLDF> KPGLGGKCHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private MHMLFGJNJKA CEKKHHEGJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private IEMLKNOFDEG KBEKHLAONIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private MPOOILGCDLJ CJNLJKIIPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private string OPOLKMBAJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private EFENBEKLEHO IKHHHDILDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private EFENBEKLEHO HOIJLNKGLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private long BFNOJMGJLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO;

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x30A6FE0", Offset = "0x30A5BE0", VA = "0x1830A6FE0")]
	public static Task<MOMCOKAPMLC> AHEFPBBKFFG(IFNNJAAOEDN FNIFBLHBOOE, in HOAOFNBBEKI PHBHEFAPHDL, MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x30A7340", Offset = "0x30A5F40", VA = "0x1830A7340")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKGBMMJPPDH))]
	private Task<MOMCOKAPMLC> EBDHDHCPNAJ(MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x30A7510", Offset = "0x30A6110", VA = "0x1830A7510")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNFOAOHAJON))]
	private Task<PKJAENHCLMN<JGCDJAPPMFN, CMPFHAIKIAN>> HELNJIFFEFO(string OPOLKMBAJBK, long BFNOJMGJLFG, MCNPFMNGCKP.DIKEJOLIKNG MKMLBPHFHCO, JAPPGKMKBNF<string>.KLCBHAGBNOA HFLKGMILCJP, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class KFDAFKKLOKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private readonly IIDHLOGLACP BAMBFEPJLPN;

	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private const string GIAMHDNKEAP = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private const string DMBJPNEBJEJ = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private const string MNPGAGOECKJ = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private const string MLOFNDALOOG = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private const string GKMHMCAEMPL = "RL_LastLoadedRoomInstanceId";

	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private const string AJJOGMFIAHG = "RL_LastHeartbeatSessionData";

	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private const string LALOJOMALCC = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private string OFLFEFGNIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private long? NJFMODCOJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private long? LDCCGHGDLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private long? DCJMGGBECLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private string GHGIFDLBFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private FEEJMENJLIJ KFPNBOHHNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private long? HKCOOAJECGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private bool DKEAICPBKBM;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string EILJMPEIPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long HLECCCFMNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x30A5270", Offset = "0x30A3E70", VA = "0x1830A5270")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long PCBENBOPEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x30A4D60", Offset = "0x30A3960", VA = "0x1830A4D60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public long NOPAHOEMOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x30A5890", Offset = "0x30A4490", VA = "0x1830A5890")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string NMLEDOPBNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x30A5190", Offset = "0x30A3D90", VA = "0x1830A5190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public FEEJMENJLIJ PIKEIPINLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x973820", Offset = "0x972420", VA = "0x180973820")]
		get
		{
			return default(FEEJMENJLIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x30A5720", Offset = "0x30A4320", VA = "0x1830A5720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public long DIKEHAFBGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x30A5130", Offset = "0x30A3D30", VA = "0x1830A5130")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x30A5B00", Offset = "0x30A4700", VA = "0x1830A5B00")]
	[UnityEngine.Scripting.Preserve]
	public KFDAFKKLOKJ([ACEKLAKDMBL(null)] IIDHLOGLACP BAMBFEPJLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x30A58F0", Offset = "0x30A44F0", VA = "0x1830A58F0")]
	private void OEOEIGOFALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x30A52D0", Offset = "0x30A3ED0", VA = "0x1830A52D0")]
	public void MCMIDIJEJCB(long HAMIEGOKEJC, long BPODGJMCBKI, [Optional] long? BFNOJMGJLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x30A51D0", Offset = "0x30A3DD0", VA = "0x1830A51D0")]
	public void JHAIMICONOM(long BFNOJMGJLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x30A5810", Offset = "0x30A4410", VA = "0x1830A5810")]
	public void NFPBNAAPLIL(string AGJEHAHDINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x30A4DC0", Offset = "0x30A39C0", VA = "0x1830A4DC0")]
	public void EMKEIDOFNDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal sealed class GNPGFJFMNHD : OOCGABPOHBK
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class AMMBJEENPIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public AMMBJEENPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D020", Offset = "0x3E0BC20", VA = "0x183E0D020")]
		internal object CMOMFNDMDFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class DJDFNOFMHNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public GNPGFJFMNHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private MHBAMGOJMJJ <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		private GKJHOLDCGPO <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DJDFNOFMHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x3E10AA0", Offset = "0x3E0F6A0", VA = "0x183E10AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class BJNKPLCCOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public MHBAMGOJMJJ presence;

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BJNKPLCCOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E140", Offset = "0x3E0CD40", VA = "0x183E0E140")]
		internal object BLHEAHAEIPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private readonly LCMHJBMHMJN CMKABAANNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private readonly MHKEFJDKLJN IKINGJFLMDI;

	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private const bool OGJKDAEGPEA = false;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x28B55E0", Offset = "0x28B41E0", VA = "0x1828B55E0")]
	public GNPGFJFMNHD(LCMHJBMHMJN CMKABAANNAK, MHKEFJDKLJN IKINGJFLMDI, Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, FFLEKJBGAJJ KPFEABGPNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x28B4FF0", Offset = "0x28B3BF0", VA = "0x1828B4FF0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJDFNOFMHNJ))]
	protected override Task EHIJJBAOCHH(DNKNJNMAMBL GIOAKJNONKE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x28B5190", Offset = "0x28B3D90", VA = "0x1828B5190")]
	private MHBAMGOJMJJ IKCIIPMOMLF()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal struct LNLHCJMIMGG
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class FIHCBNIJKOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public IFNNJAAOEDN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private bool <isMaster>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FIHCBNIJKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x3E11DB0", Offset = "0x3E109B0", VA = "0x183E11DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x30A90B0", Offset = "0x30A7CB0", VA = "0x1830A90B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FIHCBNIJKOO))]
	public static Task EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct KOKAOIFOHAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class DDKDKNPGDEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public KOKAOIFOHAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private GNIKGJEJAOC <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private string <sceneName>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private Scene <mainScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DDKDKNPGDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x3E103E0", Offset = "0x3E0EFE0", VA = "0x183E103E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class KKMIJCLINOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KKMIJCLINOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x3E18890", Offset = "0x3E17490", VA = "0x183E18890")]
		internal object NJELHEMJBFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class KPHINNJLMBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public KOKAOIFOHAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private KKMIJCLINOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private NFEMKDMIHPG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KPHINNJLMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x3E192A0", Offset = "0x3E17EA0", VA = "0x183E192A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private GNIKGJEJAOC FEEHPDIFFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EB")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	private bool HCPCHHEKOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006ED")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x30A6B40", Offset = "0x30A5740", VA = "0x1830A6B40")]
	public static Task<Scene> CAIIMFNAGLL(IFNNJAAOEDN FNIFBLHBOOE, GNIKGJEJAOC EPLEEMFCMME, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x30A6D20", Offset = "0x30A5920", VA = "0x1830A6D20")]
	public static Task<Scene> EFMJPDDAKLA(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x30A6BC0", Offset = "0x30A57C0", VA = "0x1830A6BC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDKDKNPGDEO))]
	private Task<Scene> EBDHDHCPNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x30A6DC0", Offset = "0x30A59C0", VA = "0x1830A6DC0")]
	private bool GFFGKMPPLDL(MOMCOKAPMLC PHBHEFAPHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x30A6DF0", Offset = "0x30A59F0", VA = "0x1830A6DF0")]
	private void HFIDDOBGHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x30A6E60", Offset = "0x30A5A60", VA = "0x1830A6E60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KPHINNJLMBM))]
	private Task<Scene> LABLIJDEDLP(string KPMIPNBJALP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public abstract class GHNMALNFIIN<T> where T : GHNMALNFIIN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	internal readonly IFNNJAAOEDN AEOAMPMHMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	private int? LAGKBBBLPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	protected readonly Guid ECPEBOBBOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000704")]
	protected readonly DLLMEMMHNCB POGILKKOKAG;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	protected T CFDIOCDOGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x2607150", Offset = "0x2605D50", VA = "0x182607150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x26074B0", Offset = "0x26060B0", VA = "0x1826074B0")]
	internal GHNMALNFIIN(IFNNJAAOEDN BAFFLKMLODH, DLLMEMMHNCB GOKELOIKDPH, [Optional] Guid? PALLEDHBFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x26073C0", Offset = "0x2605FC0", VA = "0x1826073C0")]
	private FHMBHNPINBI PNDMPGBACPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "4")]
	protected virtual void FNKFGHEALCA(FHMBHNPINBI DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x26071B0", Offset = "0x2605DB0", VA = "0x1826071B0")]
	public T EPOBKLBKCBE(IGGCDPKBFGF ACJGGEOLANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x2607240", Offset = "0x2605E40", VA = "0x182607240")]
	public T JOBANKHALDL(int APBFHMCACOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x26072C0", Offset = "0x2605EC0", VA = "0x1826072C0", Slot = "5")]
	public virtual Task<IDIFMABCDLA> NLNPDPINDNM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public class DHFMLFOJIHC : GHNMALNFIIN<DHFMLFOJIHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000705")]
	private LCMHJBMHMJN MEKBNGFFPML;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x28A6250", Offset = "0x28A4E50", VA = "0x1828A6250")]
	internal DHFMLFOJIHC(IFNNJAAOEDN BAFFLKMLODH, DLLMEMMHNCB GOKELOIKDPH, [Optional] Guid? PALLEDHBFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x28A6230", Offset = "0x28A4E30", VA = "0x1828A6230")]
	public DHFMLFOJIHC PEKKCJNPFHN(LCMHJBMHMJN MEKBNGFFPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x28A6170", Offset = "0x28A4D70", VA = "0x1828A6170", Slot = "4")]
	protected override void FNKFGHEALCA(FHMBHNPINBI DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public class AMGCDJKPHHE : GHNMALNFIIN<AMGCDJKPHHE>
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal enum JFNGBDOKEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		RecNet
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class KEPEDBDJOEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public AMGCDJKPHHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private IDIFMABCDLA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private TaskAwaiter<IDIFMABCDLA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KEPEDBDJOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x30A49D0", Offset = "0x30A35D0", VA = "0x1830A49D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000706")]
	private JFNGBDOKEFJ LIGEIHFKLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000707")]
	private string GELGNLNNMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000708")]
	private NNENOOPKHPC MEKBNGFFPML;

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x28A1E00", Offset = "0x28A0A00", VA = "0x1828A1E00")]
	internal AMGCDJKPHHE(IFNNJAAOEDN BAFFLKMLODH, DLLMEMMHNCB GOKELOIKDPH, [Optional] Guid? PALLEDHBFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x28A1C50", Offset = "0x28A0850", VA = "0x1828A1C50")]
	public AMGCDJKPHHE MOMLKGOFEHD(string IDCNODJDCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x28A1BB0", Offset = "0x28A07B0", VA = "0x1828A1BB0")]
	public AMGCDJKPHHE GFJGJDJKNBJ(bool DNDPJAPBJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x28A1C20", Offset = "0x28A0820", VA = "0x1828A1C20")]
	public AMGCDJKPHHE JCGLBPMKPIA(string FMALCPACLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x28A1DD0", Offset = "0x28A09D0", VA = "0x1828A1DD0")]
	public AMGCDJKPHHE OLFKAAGMGMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x28A1A40", Offset = "0x28A0640", VA = "0x1828A1A40", Slot = "4")]
	protected override void FNKFGHEALCA(FHMBHNPINBI DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x28A1C80", Offset = "0x28A0880", VA = "0x1828A1C80", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KEPEDBDJOEK))]
	public override Task<IDIFMABCDLA> NLNPDPINDNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x28A1BE0", Offset = "0x28A07E0", VA = "0x1828A1BE0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<IDIFMABCDLA> ICDBEDNLODH()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct OMGEIFGLMDJ
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class BEHNKGKPPMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public MCGDFABKIDE.CJJHBHDMDGF instantiations;

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BEHNKGKPPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x5827030", Offset = "0x5825C30", VA = "0x185827030")]
		internal object GLEEEHPILGD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class EMBJHKDGIAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public EMBJHKDGIAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x5828A90", Offset = "0x5827690", VA = "0x185828A90")]
		internal object KFBCMDIONEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x30B2F70", Offset = "0x30B1B70", VA = "0x1830B2F70")]
	public static void EBDHDHCPNAJ(OOCGABPOHBK CDJHLNAAHGK, MOMCOKAPMLC PHBHEFAPHDL, MCGDFABKIDE.CJJHBHDMDGF KNICAFCALMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct MCGDFABKIDE
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public struct CJJHBHDMDGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public List<GKDPOMOKADP> MKBFFOFCAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public List<HGNMPOIAAKI> GEDPMAOKDAN;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D0D0", VA = "0x18091E4D0")]
		public CJJHBHDMDGF(List<GKDPOMOKADP> MKBFFOFCAEK, List<HGNMPOIAAKI> GEDPMAOKDAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class NOCEIFMLEIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public IEnumerable<GKDPOMOKADP> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NOCEIFMLEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x582DD40", Offset = "0x582C940", VA = "0x18582DD40")]
		internal object CDIEBDEOHJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x30AA690", Offset = "0x30A9290", VA = "0x1830AA690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x30A9B30", Offset = "0x30A8730", VA = "0x1830A9B30")]
	public static CJJHBHDMDGF EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL)
	{
		return default(CJJHBHDMDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x30A9BA0", Offset = "0x30A87A0", VA = "0x1830A9BA0")]
	private CJJHBHDMDGF EBDHDHCPNAJ()
	{
		return default(CJJHBHDMDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x30AA110", Offset = "0x30A8D10", VA = "0x1830AA110")]
	private CJJHBHDMDGF NJGIGKHCMCP(BNIDNMGAHLD BBBFCKGLENJ, HBHNCFJCIKF KJBJOIGGOCH)
	{
		return default(CJJHBHDMDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x30A9EC0", Offset = "0x30A8AC0", VA = "0x1830A9EC0")]
	private bool KHIEFGMBIHG(IEnumerable<GKDPOMOKADP> MKBFFOFCAEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct DICNKJMABAF
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class FLIJPGHBNPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public DICNKJMABAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private JAPPGKMKBNF<string>.KLCBHAGBNOA <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FLIJPGHBNPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x46251C0", Offset = "0x4623DC0", VA = "0x1846251C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class IPFCBDKKIIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IPFCBDKKIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x4629000", Offset = "0x4627C00", VA = "0x184629000")]
		internal object NJELHEMJBFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class JBCHCLNGGLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public DICNKJMABAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private IPFCBDKKIIB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private NFEMKDMIHPG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public JBCHCLNGGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x46299E0", Offset = "0x46285E0", VA = "0x1846299E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private bool HALMHNMILGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400071C")]
	private JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	private CancellationToken GFFFFCALMCA;

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x28A64C0", Offset = "0x28A50C0", VA = "0x1828A64C0")]
	public static Task JAGJNBNMDNL(IFNNJAAOEDN FNIFBLHBOOE, bool HALMHNMILGE, JAPPGKMKBNF<string>.KLCBHAGBNOA IDIJCJCNEPO, CancellationToken FFDAINFFMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x28A6390", Offset = "0x28A4F90", VA = "0x1828A6390")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FLIJPGHBNPP))]
	private Task EBDHDHCPNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x28A6530", Offset = "0x28A5130", VA = "0x1828A6530")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JBCHCLNGGLI))]
	private Task LABLIJDEDLP(bool DJJMALJEJII, string KPMIPNBJALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F3460", Offset = "0x7F2060", VA = "0x1807F3460")]
	private bool JPNFMNLDNFA(bool HALMHNMILGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct HOAOFNBBEKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	public readonly IEMLKNOFDEG KBEKHLAONIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	public readonly MPOOILGCDLJ CJNLJKIIPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000735")]
	public readonly string OPOLKMBAJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	public readonly EFENBEKLEHO IKHHHDILDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	public readonly EFENBEKLEHO HOIJLNKGLFK;

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x28BAA70", Offset = "0x28B9670", VA = "0x1828BAA70")]
	public HOAOFNBBEKI(IEMLKNOFDEG KBEKHLAONIE, MPOOILGCDLJ CJNLJKIIPKB, string OPOLKMBAJBK, EFENBEKLEHO IKHHHDILDNK, EFENBEKLEHO HOIJLNKGLFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal sealed class CHMKLKMLENN : HALIFADCDEK
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class BAKBIPMEGBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public CHMKLKMLENN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private NKHBPCPCMLJ <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private GKJHOLDCGPO <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BAKBIPMEGBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x309F450", Offset = "0x309E050", VA = "0x18309F450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private readonly LCMHJBMHMJN NHMBOCGMBGD;

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x28A3A20", Offset = "0x28A2620", VA = "0x1828A3A20")]
	public CHMKLKMLENN(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, LCMHJBMHMJN NHMBOCGMBGD, FFLEKJBGAJJ KPFEABGPNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x28A3880", Offset = "0x28A2480", VA = "0x1828A3880", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BAKBIPMEGBI))]
	protected override Task FKNGBCPGLCB(DNKNJNMAMBL GIOAKJNONKE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct KGAFFLMMDHL
{
	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x30A5DF0", Offset = "0x30A49F0", VA = "0x1830A5DF0")]
	public static Task EBDHDHCPNAJ(CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct HEKFJEICGBI
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class ECGAKJCABNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public IFNNJAAOEDN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public MOMCOKAPMLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private bool <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ECGAKJCABNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x3E11500", Offset = "0x3E10100", VA = "0x183E11500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class IACELMBHJEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public HEKFJEICGBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private OFOJCNIGMKF.HOIAMFPJIGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private bool <shouldObjectModelBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		private bool <isOMFlagChanging>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private bool <reloadSceneForObjectModel>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IACELMBHJEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x3E148A0", Offset = "0x3E134A0", VA = "0x183E148A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000742")]
	private IFNNJAAOEDN FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	private MOMCOKAPMLC PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000744")]
	private ByteString EPBBCHCFEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000745")]
	private DNKNJNMAMBL GIOAKJNONKE;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private HBPPPIGEKFO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x28B85C0", Offset = "0x28B71C0", VA = "0x1828B85C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private bool CMJEGCCGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x28B80E0", Offset = "0x28B6CE0", VA = "0x1828B80E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool GHKKGJHEJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x28B8530", Offset = "0x28B7130", VA = "0x1828B8530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool BCBGHHFAELE
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x28B8160", Offset = "0x28B6D60", VA = "0x1828B8160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x28B8340", Offset = "0x28B6F40", VA = "0x1828B8340")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ECGAKJCABNI))]
	public static Task<bool> EBDHDHCPNAJ(IFNNJAAOEDN FNIFBLHBOOE, MOMCOKAPMLC PHBHEFAPHDL, DNKNJNMAMBL GIOAKJNONKE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x28B81A0", Offset = "0x28B6DA0", VA = "0x1828B81A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IACELMBHJEH))]
	private Task<bool> EBDHDHCPNAJ(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class EDKMEFHOBIG
{
	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x28A8840", Offset = "0x28A7440", VA = "0x1828A8840")]
	public static EFENBEKLEHO BMNPIDDJJNL(this HAPEDGBDDDG MJJEAGOMNNL)
	{
		return default(EFENBEKLEHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x28A8900", Offset = "0x28A7500", VA = "0x1828A8900")]
	public static HAPEDGBDDDG KFALNGGMHPP(this EFENBEKLEHO ANGPFHAPFPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal class CHIPOCIBCNK : MMDFDPPJLGH
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class FKHMOGPFCED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public NIADFLCAKKJ.BLEDDCONCNO roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FKHMOGPFCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x30A25C0", Offset = "0x30A11C0", VA = "0x1830A25C0")]
		internal object PNDOAICHBLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x30A22C0", Offset = "0x30A0EC0", VA = "0x1830A22C0")]
		internal object GAENOLKHDLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x30A2310", Offset = "0x30A0F10", VA = "0x1830A2310")]
		internal object GKMIMNBLPLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x30A2380", Offset = "0x30A0F80", VA = "0x1830A2380")]
		internal object GLFGLBPEBLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class OMICCKOFGJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		public AsyncTaskMethodBuilder<(NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		private FKHMOGPFCED <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		private CIOHJELGAHC <roomMetadata>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		private NIADFLCAKKJ.BLEDDCONCNO <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private NIADFLCAKKJ.BLEDDCONCNO <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private TaskAwaiter<NIADFLCAKKJ.BLEDDCONCNO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public OMICCKOFGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x30B3640", Offset = "0x30B2240", VA = "0x1830B3640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class BOJFPPBKBBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public AsyncTaskMethodBuilder<LPCDCAILFOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public NNENOOPKHPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		private NIADFLCAKKJ.BLEDDCONCNO <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private NIADFLCAKKJ.BLEDDCONCNO <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private int <persistenceVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private byte <omVersion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private NEBPAIJOJCP <request>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private LPCDCAILFOA <response>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		private (NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private (NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload) <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		private LPCDCAILFOA <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		private TaskAwaiter<(NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private TaskAwaiter<LPCDCAILFOA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BOJFPPBKBBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x30A02D0", Offset = "0x309EED0", VA = "0x1830A02D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class EJNPFODKFCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public AsyncTaskMethodBuilder<CAIGCNABMEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private NIADFLCAKKJ.BLEDDCONCNO <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private NIADFLCAKKJ.BLEDDCONCNO <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		private CAIGCNABMEN <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		private (NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		private (NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		private CAIGCNABMEN <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		private TaskAwaiter<(NIADFLCAKKJ.BLEDDCONCNO roomDataUpload, NIADFLCAKKJ.BLEDDCONCNO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		private TaskAwaiter<CAIGCNABMEN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public EJNPFODKFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x30A1D80", Offset = "0x30A0980", VA = "0x1830A1D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class ADFANEGODOA
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000798")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			public ADFANEGODOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			private FHMBHNPINBI <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			private RepeatedField<HGNMPOIAAKI> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763BD0", Offset = "0x762FD0")]
			private IEnumerable<HGNMPOIAAKI> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			private CAIGCNABMEN <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			private CAIGCNABMEN <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			private LPCDCAILFOA <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007A4")]
			private LPCDCAILFOA <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007A5")]
			private FHMBHNPINBI <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007A6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007A7")]
			private TaskAwaiter<CAIGCNABMEN> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40007A8")]
			private TaskAwaiter<LPCDCAILFOA> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40007A9")]
			private TaskAwaiter<FHMBHNPINBI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x5831660", Offset = "0x5830260", VA = "0x185831660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public NNENOOPKHPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public IEGAONCOOPP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763B00", Offset = "0x762F00")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ADFANEGODOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x309EF30", Offset = "0x309DB30", VA = "0x18309EF30")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<FHMBHNPINBI> JCKBHPJJBCP(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class ODKABEEKPHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public NNENOOPKHPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public EJCOGPHMIIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		public IEGAONCOOPP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763C30", Offset = "0x763030")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		public CHIPOCIBCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		private ADFANEGODOA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		private FHMBHNPINBI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ODKABEEKPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x30B2B50", Offset = "0x30B1750", VA = "0x1830B2B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000759")]
	private const float HOJEBHBGLMK = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400075A")]
	private readonly BNBOHDAMFHI CJPJEGMHJHB;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private IFNNJAAOEDN MIDAOOLAHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x28A2FC0", Offset = "0x28A1BC0", VA = "0x1828A2FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x28A37F0", Offset = "0x28A23F0", VA = "0x1828A37F0")]
	public CHIPOCIBCNK(DNKNJNMAMBL GIOAKJNONKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x28A3630", Offset = "0x28A2230", VA = "0x1828A3630")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMICCKOFGJC))]
	private Task<(NIADFLCAKKJ.BLEDDCONCNO, NIADFLCAKKJ.BLEDDCONCNO)> MKBBIAPKPGD(EJCOGPHMIIO NNIPLGKEGFJ, long HAMIEGOKEJC, long KIBMHJEFMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x28A3440", Offset = "0x28A2040", VA = "0x1828A3440")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BOJFPPBKBBB))]
	public Task<LPCDCAILFOA> FLEHEHANDKI(int DEPJAMELNGJ, [CanBeNull] NNENOOPKHPC IDBNBECJKFH, EJCOGPHMIIO NNIPLGKEGFJ, long HAMIEGOKEJC, long KIBMHJEFMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x28A2FF0", Offset = "0x28A1BF0", VA = "0x1828A2FF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJNPFODKFCC))]
	private Task<CAIGCNABMEN> EKKOIDDDLEH(string APOLELLKJLH, int DEPJAMELNGJ, EJCOGPHMIIO NNIPLGKEGFJ, long HAMIEGOKEJC, long KIBMHJEFMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x28A31F0", Offset = "0x28A1DF0", VA = "0x1828A31F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ODKABEEKPHI))]
	public Task<FHMBHNPINBI> FCKBKOIHOBA(int DEPJAMELNGJ, NNENOOPKHPC? IDBNBECJKFH, EJCOGPHMIIO NNIPLGKEGFJ, long HAMIEGOKEJC, long KIBMHJEFMKG, IEGAONCOOPP FEBGOIPDFBI, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
internal class LCLBBEMHFDA : HALIFADCDEK
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class MFCMCIEHPBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			public AsyncTaskMethodBuilder<FHMBHNPINBI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007C5")]
			public MFCMCIEHPBF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007C6")]
			private EJCOGPHMIIO <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007C7")]
			private FHMBHNPINBI <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007C8")]
			private EJCOGPHMIIO <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007C9")]
			private FHMBHNPINBI <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007CA")]
			private TaskAwaiter<EJCOGPHMIIO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007CB")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x763D70", Offset = "0x763170")]
			private TaskAwaiter<FHMBHNPINBI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x5831210", Offset = "0x582FE10", VA = "0x185831210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public LCLBBEMHFDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public ODEOHNPPJCE serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public CHIPOCIBCNK uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public IEGAONCOOPP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MFCMCIEHPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B760", Offset = "0x3E1A360", VA = "0x183E1B760")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<FHMBHNPINBI> PCEIDODDIHH(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class FMDBOPNMOGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		public DNKNJNMAMBL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		public JAPPGKMKBNF<string>.KLCBHAGBNOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public LCLBBEMHFDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private MFCMCIEHPBF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		private NKHBPCPCMLJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private BNNPCINDEGK <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private GKJHOLDCGPO <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private FHMBHNPINBI <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		private FHMBHNPINBI <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		private TaskAwaiter<FHMBHNPINBI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FMDBOPNMOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E12710", Offset = "0x3E11310", VA = "0x183E12710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007B8")]
	private readonly int DEPJAMELNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007B9")]
	[CanBeNull]
	private readonly NNENOOPKHPC IDBNBECJKFH;

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x30A7B70", Offset = "0x30A6770", VA = "0x1830A7B70")]
	public LCLBBEMHFDA(Guid PALLEDHBFCO, IFNNJAAOEDN FNIFBLHBOOE, int DEPJAMELNGJ, NNENOOPKHPC IDBNBECJKFH, FFLEKJBGAJJ KPFEABGPNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x30A7740", Offset = "0x30A6340", VA = "0x1830A7740", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FMDBOPNMOGD))]
	protected override Task FKNGBCPGLCB(DNKNJNMAMBL GIOAKJNONKE, JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x30A7A80", Offset = "0x30A6680", VA = "0x1830A7A80")]
	private void JPHFHFFKPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x30A78E0", Offset = "0x30A64E0", VA = "0x1830A78E0")]
	private void HKGIIPEFMJN(JAPPGKMKBNF<string>.KLCBHAGBNOA LEBCJIHOHHE, NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200019C")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007E0")]
			public BOHAGPJNCEM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007E1")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007E2")]
			public BOHAGPJNCEM HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007E3")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007E4")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007E5")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		private static BOHAGPJNCEM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		private Dictionary<BOHAGPJNCEM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x30B94A0", Offset = "0x30B80A0", VA = "0x1830B94A0")]
		public bool NAAMKNMDFAH(BOHAGPJNCEM BBMNNPEOJDE, out ResultConfig CEHJOFICIAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x30B9C90", Offset = "0x30B8890", VA = "0x1830B9C90")]
		public ResultConfig PLBLPCLNKFG(BOHAGPJNCEM MDCIFHCDMMF, [Optional] HashSet<BOHAGPJNCEM> OFHNCJNEKJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x30B9A90", Offset = "0x30B8690", VA = "0x1830B9A90", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x30B9510", Offset = "0x30B8110", VA = "0x1830B9510", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x10C7230", Offset = "0x10C5E30", VA = "0x1810C7230")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public class FJHFJBECMEA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x28B0A20", Offset = "0x28AF620", VA = "0x1828B0A20")]
	public FJHFJBECMEA(string DKIECHCHJFL, Exception NCFNHKNLKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public class KEOPDAFDAHG
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	private sealed class IPCMFCLNHIL : BLPMDLHIELF, IEquatable<BLPMDLHIELF>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A1")]
		[CompilerGenerated]
		private sealed class CHPMLPJPPLJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007F3")]
			public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007F4")]
			public IPCMFCLNHIL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007F5")]
			private NCFBJHOACDL <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007F6")]
			private IEMLKNOFDEG <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007F7")]
			private LCMHJBMHMJN <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007F8")]
			private IEMLKNOFDEG <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007F9")]
			private IDIFMABCDLA <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007FA")]
			private TaskAwaiter<IEMLKNOFDEG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007FB")]
			private TaskAwaiter<IDIFMABCDLA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public CHPMLPJPPLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x5827850", Offset = "0x5826450", VA = "0x185827850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private readonly BNNPCINDEGK OPEBBEJDEPM;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public int EECDPPIJLCA
		{
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x87CCA0", Offset = "0x87B8A0", VA = "0x18087CCA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public JPNGCEFMBEO LMALIKDMCJD
		{
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		private DateTime IDCJKOENPIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x20AEF50", Offset = "0x20ADB50", VA = "0x1820AEF50", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public ELODCOFCJAF? KAEGAPFLFGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x13A8A90", Offset = "0x13A7690", VA = "0x1813A8A90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public PPBPIDGBPHI? ALGACNOOCCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x3E16E40", Offset = "0x3E15A40", VA = "0x183E16E40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public GAOMACELHLE KMHICIJNHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0", Slot = "10")]
			get
			{
				return default(GAOMACELHLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x3E16B20", Offset = "0x3E15720", VA = "0x183E16B20", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(CHPMLPJPPLJ))]
		public Task<IDIFMABCDLA> BEIHBPAMODO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x3E16EB0", Offset = "0x3E15AB0", VA = "0x183E16EB0")]
		public IPCMFCLNHIL(int LMMJHNPOCPO, JPNGCEFMBEO IDOMIIDIAPH, BNNPCINDEGK OPEBBEJDEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x3E16D10", Offset = "0x3E15910", VA = "0x183E16D10", Slot = "11")]
		public bool Equals(BLPMDLHIELF MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x3E16C70", Offset = "0x3E15870", VA = "0x183E16C70", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x3E16E60", Offset = "0x3E15A60", VA = "0x183E16E60")]
		private bool OCDFPFBBPDN(IPCMFCLNHIL MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x3E16DB0", Offset = "0x3E159B0", VA = "0x183E16DB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	private sealed class HCAOPLFDEKA : BLPMDLHIELF, IEquatable<BLPMDLHIELF>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A3")]
		[CompilerGenerated]
		private sealed class MEGAMAFHOJO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			public HCAOPLFDEKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			private IDIFMABCDLA <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			private TaskAwaiter<IDIFMABCDLA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public MEGAMAFHOJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x582D950", Offset = "0x582C550", VA = "0x18582D950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		private readonly HCKACEFMPCF GAPOOPBJCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private readonly ELODCOFCJAF IKLIILIFHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private readonly PPBPIDGBPHI PGKCKACBLMK;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public int EECDPPIJLCA
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x3E14310", Offset = "0x3E12F10", VA = "0x183E14310", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public JPNGCEFMBEO LMALIKDMCJD
		{
			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x3E13F40", Offset = "0x3E12B40", VA = "0x183E13F40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		private DateTime IDCJKOENPIG
		{
			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x3E13F90", Offset = "0x3E12B90", VA = "0x183E13F90", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public ELODCOFCJAF? KAEGAPFLFGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x3E14360", Offset = "0x3E12F60", VA = "0x183E14360", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public PPBPIDGBPHI? ALGACNOOCCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x3E143B0", Offset = "0x3E12FB0", VA = "0x183E143B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public GAOMACELHLE KMHICIJNHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x83DBC0", Offset = "0x83C7C0", VA = "0x18083DBC0", Slot = "10")]
			get
			{
				return default(GAOMACELHLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x9136D0", Offset = "0x9122D0", VA = "0x1809136D0")]
		public HCAOPLFDEKA(HCKACEFMPCF IPKBJACGFCO, ELODCOFCJAF KEEOJFLMHOO, PPBPIDGBPHI HNLBDKLBBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x3E13FE0", Offset = "0x3E12BE0", VA = "0x183E13FE0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MEGAMAFHOJO))]
		public Task<IDIFMABCDLA> BEIHBPAMODO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x3E141E0", Offset = "0x3E12DE0", VA = "0x183E141E0", Slot = "11")]
		public bool Equals(BLPMDLHIELF MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x3E14130", Offset = "0x3E12D30", VA = "0x183E14130", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x3E14400", Offset = "0x3E13000", VA = "0x183E14400")]
		private bool OCDFPFBBPDN(HCAOPLFDEKA MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x3E14280", Offset = "0x3E12E80", VA = "0x183E14280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	private sealed class COPIGHDKAHJ : BLPMDLHIELF, IEquatable<BLPMDLHIELF>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A5")]
		[CompilerGenerated]
		private sealed class DHODAFONGEN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			public AsyncTaskMethodBuilder<IDIFMABCDLA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000809")]
			public COPIGHDKAHJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400080A")]
			private IDIFMABCDLA <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400080B")]
			private TaskAwaiter<IDIFMABCDLA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public DHODAFONGEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x5828540", Offset = "0x5827140", VA = "0x185828540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private readonly JPNGCEFMBEO FPKDIDHPIAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private readonly ELODCOFCJAF IKLIILIFHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		private readonly PPBPIDGBPHI PGKCKACBLMK;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public int EECDPPIJLCA
		{
			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x3E0E940", Offset = "0x3E0D540", VA = "0x183E0E940", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		[NotNull]
		public JPNGCEFMBEO LMALIKDMCJD
		{
			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		private DateTime IDCJKOENPIG
		{
			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x83D520", Offset = "0x83C120", VA = "0x18083D520", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public ELODCOFCJAF? KAEGAPFLFGA
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x3E0E9C0", Offset = "0x3E0D5C0", VA = "0x183E0E9C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public PPBPIDGBPHI? ALGACNOOCCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x3E0EA10", Offset = "0x3E0D610", VA = "0x183E0EA10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public GAOMACELHLE KMHICIJNHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x83D520", Offset = "0x83C120", VA = "0x18083D520", Slot = "10")]
			get
			{
				return default(GAOMACELHLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x9136D0", Offset = "0x9122D0", VA = "0x1809136D0")]
		public COPIGHDKAHJ(JPNGCEFMBEO IDOMIIDIAPH, ELODCOFCJAF KEEOJFLMHOO, PPBPIDGBPHI HNLBDKLBBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E4D0", Offset = "0x3E0D0D0", VA = "0x183E0E4D0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(DHODAFONGEN))]
		public Task<IDIFMABCDLA> BEIHBPAMODO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E760", Offset = "0x3E0D360", VA = "0x183E0E760", Slot = "11")]
		public bool Equals(BLPMDLHIELF MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E620", Offset = "0x3E0D220", VA = "0x183E0E620", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E890", Offset = "0x3E0D490", VA = "0x183E0E890", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x3E0EA60", Offset = "0x3E0D660", VA = "0x183E0EA60")]
		private bool OCDFPFBBPDN(COPIGHDKAHJ MDHJAFNLPON)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class MCDNHJEANGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		public AsyncTaskMethodBuilder<IList<BLPMDLHIELF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		public KEOPDAFDAHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private IReadOnlyList<BNNPCINDEGK> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private IReadOnlyList<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		private List<BLPMDLHIELF> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		private HCKACEFMPCF <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private IReadOnlyList<BNNPCINDEGK> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		private IReadOnlyList<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private IEnumerator<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		private (int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		private HCAOPLFDEKA <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		private TaskAwaiter<IReadOnlyList<BNNPCINDEGK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private TaskAwaiter<IReadOnlyList<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MCDNHJEANGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x3E1AAE0", Offset = "0x3E196E0", VA = "0x183E1AAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class APNOHBHKDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, JPNGCEFMBEO account, BNNPCINDEGK roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		public IReadOnlyList<BNNPCINDEGK> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		public KEOPDAFDAHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private IReadOnlyList<JPNGCEFMBEO> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private Dictionary<ObscuredInt, JPNGCEFMBEO> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		private List<(int, JPNGCEFMBEO, BNNPCINDEGK)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400082D")]
		private IReadOnlyList<JPNGCEFMBEO> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400082E")]
		private IEnumerator<BNNPCINDEGK> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400082F")]
		private BNNPCINDEGK <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000830")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000831")]
		private JPNGCEFMBEO <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000832")]
		private JPNGCEFMBEO <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000833")]
		private TaskAwaiter<IReadOnlyList<JPNGCEFMBEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public APNOHBHKDBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D540", Offset = "0x3E0C140", VA = "0x183E0D540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007EB")]
	private readonly GJANOCFHBPK CMNEEKOFKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007EC")]
	private readonly DENCMPHLPHJ LHNLEFIGMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007ED")]
	private readonly LCAFMEKLLGH MFKMPKPAPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40007EE")]
	private readonly PBGCPGFJPND<(long, long), IReadOnlyList<BNNPCINDEGK>> DCHEGGFINJM;

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x30A48B0", Offset = "0x30A34B0", VA = "0x1830A48B0")]
	[UnityEngine.Scripting.Preserve]
	public KEOPDAFDAHG([ACEKLAKDMBL(null)] DENCMPHLPHJ FLKNEJKHELK, [ACEKLAKDMBL(null)] LCAFMEKLLGH POCJMJBNADK, [ACEKLAKDMBL(null)] GJANOCFHBPK MPDJMFEEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x30A43F0", Offset = "0x30A2FF0", VA = "0x1830A43F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MCDNHJEANGP))]
	public Task<IList<BLPMDLHIELF>> BDKEOJFGKDI(long HAMIEGOKEJC, long BPODGJMCBKI, bool MPBKGNHECHB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x30A4590", Offset = "0x30A3190", VA = "0x1830A4590")]
	private bool GMIOAFCEBPH(DateTime? ELKAIOOFKHB, long HAMIEGOKEJC, long BPODGJMCBKI, out HCKACEFMPCF ANGBHDDNJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x30A4740", Offset = "0x30A3340", VA = "0x1830A4740")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(APNOHBHKDBE))]
	private Task<IReadOnlyList<(int, JPNGCEFMBEO, BNNPCINDEGK)>> ICKPHPMDOBP(IReadOnlyList<BNNPCINDEGK> BJLMLGFPNLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal class OPCFEDDKIDK : DENCMPHLPHJ
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private sealed class HCKLADHBMLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000834")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000835")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BNNPCINDEGK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000836")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000837")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000839")]
		public OPCFEDDKIDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400083A")]
		private LFEMLMBOIIA<BNNPCINDEGK> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400083B")]
		private LFEMLMBOIIA<BNNPCINDEGK> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400083C")]
		private TaskAwaiter<LFEMLMBOIIA<BNNPCINDEGK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HCKLADHBMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x582A130", Offset = "0x5828D30", VA = "0x18582A130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private sealed class ILEBKOFIMIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400083D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400083E")]
		public AsyncTaskMethodBuilder<IReadOnlyList<JPNGCEFMBEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000840")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000841")]
		public OPCFEDDKIDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000842")]
		private List<JPNGCEFMBEO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000843")]
		private TaskAwaiter<List<JPNGCEFMBEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ILEBKOFIMIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x582AEE0", Offset = "0x5829AE0", VA = "0x18582AEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	[UnityEngine.Scripting.Preserve]
	public OPCFEDDKIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x30B4F40", Offset = "0x30B3B40", VA = "0x1830B4F40", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HCKLADHBMLA))]
	public Task<IReadOnlyList<BNNPCINDEGK>> JFNDJCEHLNG(long HAMIEGOKEJC, long KIBMHJEFMKG, [Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x30B50F0", Offset = "0x30B3CF0", VA = "0x1830B50F0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ILEBKOFIMIJ))]
	public Task<IReadOnlyList<JPNGCEFMBEO>> MEOGEJOBDCB(IReadOnlyList<int> IJNHKBOELBC, [Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public interface DENCMPHLPHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<BNNPCINDEGK>> JFNDJCEHLNG(long HAMIEGOKEJC, long KIBMHJEFMKG, [Optional] CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<JPNGCEFMBEO>> MEOGEJOBDCB(IReadOnlyList<int> IJNHKBOELBC, [Optional] CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public interface BLPMDLHIELF : IEquatable<BLPMDLHIELF>
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	int EECDPPIJLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	[CanBeNull]
	JPNGCEFMBEO LMALIKDMCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	DateTime NNFBFGJNNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	ELODCOFCJAF? KAEGAPFLFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	PPBPIDGBPHI? ALGACNOOCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	[CanBeNull]
	GAOMACELHLE KMHICIJNHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IDIFMABCDLA> BEIHBPAMODO();
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public enum GAOMACELHLE
{
	[Cpp2IlInjected.Token(Token = "0x4000845")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000846")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000847")]
	DiskAutosave
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600075A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x1901CE0", Offset = "0x19008E0", VA = "0x181901CE0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
