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
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x271CC50", Offset = "0x271BC50", VA = "0x18271CC50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB40", Offset = "0xA3EB40", VA = "0x180A3FB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF9C40", Offset = "0xCF8C40", VA = "0x180CF9C40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GOGKAJFDJAH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MCFPGIBLJJO> HAGMCBNHNNE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KEBCCECEGCO(long IHGIEILPMCA, long FKNCEBBDENC, JNMBCFANFLA KOBJHMANLPK, FALKJMEJPBK DDBBBGFMPLN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MJHMIFBLPGG(long IHGIEILPMCA, long FKNCEBBDENC, out MCFPGIBLJJO NLDFIJLPMIC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PBPMEOAGANJ(long IHGIEILPMCA, long FKNCEBBDENC, FALKJMEJPBK DDBBBGFMPLN, out MCFPGIBLJJO NLDFIJLPMIC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNJCDBJLNML(long IHGIEILPMCA, long FKNCEBBDENC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[UnityEngine.Scripting.Preserve]
internal class BLFEKNMJBJK : KBCIOEDODBM, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HIEDHCBFANH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public KPECHFMAHBD roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HIEDHCBFANH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2712530", Offset = "0x2711530", VA = "0x182712530")]
		internal object EMMHEGHDAKI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action ABJKFCILOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x20DDFA0", Offset = "0x20DCFA0", VA = "0x1820DDFA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x20DE070", Offset = "0x20DD070", VA = "0x1820DE070", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KHGHBNJHLDD AEIHNHGEEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x20DDCD0", Offset = "0x20DCCD0", VA = "0x1820DDCD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x20DDAF0", Offset = "0x20DCAF0", VA = "0x1820DDAF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event KHGHBNJHLDD JJPGKPMCHKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x20DDB90", Offset = "0x20DCB90", VA = "0x1820DDB90", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x20DDA50", Offset = "0x20DCA50", VA = "0x1820DDA50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event KHGHBNJHLDD NPDOAAOFDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x20DD910", Offset = "0x20DC910", VA = "0x1820DD910", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x20DE110", Offset = "0x20DD110", VA = "0x1820DE110", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NOBDFJFKCAB, bool> OBBCOOGJLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x20DD9B0", Offset = "0x20DC9B0", VA = "0x1820DD9B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x20DDC30", Offset = "0x20DCC30", VA = "0x1820DDC30", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "19")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x20DE1B0", Offset = "0x20DD1B0", VA = "0x1820DE1B0", Slot = "14")]
	public void NBEEHGBPENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x20DDD70", Offset = "0x20DCD70", VA = "0x1820DDD70", Slot = "15")]
	public void JLNMJFONIEJ(KPECHFMAHBD JBAGHENJMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x20DE3C0", Offset = "0x20DD3C0", VA = "0x1820DE3C0", Slot = "16")]
	public void PCHOBMLHGGN(KPECHFMAHBD JBAGHENJMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x20DE040", Offset = "0x20DD040", VA = "0x1820DE040", Slot = "17")]
	public void LBJLFPDKKOD(KPECHFMAHBD JBAGHENJMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x20DD860", Offset = "0x20DC860", VA = "0x1820DD860", Slot = "18")]
	public void AFABNDBFNLN(NOBDFJFKCAB BEAPEJKINEL, bool DHPCHJKOPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x20DDDA0", Offset = "0x20DCDA0", VA = "0x1820DDDA0")]
	private void KAEAMPPMANC(KHGHBNJHLDD BFNKDBHNAAE, KPECHFMAHBD JBAGHENJMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public BLFEKNMJBJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface JLPMGBNKLLC : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GEMMKFJNFAA JDKGJBKDGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOOCEOOBMBO();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNICCIPHLMI();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate PEOGNNHCCMJ PMEIFHGAOHI(PIPFLAHHDDO CIAMEHCABFJ, IOANKPJOPII FHNGDKCLEKI);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface GNNFCDEOEHF : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LCJHGCCKGGO HPCLFKCODFA(OCLNBBADIAK ELLBEBCHLPA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKNKBPAIKDL(Guid MLHJIHFFCGB, Task LDHHKGCGIPG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal struct LODDIGECODM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string NPNEEJLPNML = "v_result";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const string JKEEJCDDBAD = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IDictionary<object, object> NKPHHCMFEAM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MFPCNNNAAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xD1B880", Offset = "0xD1A880", VA = "0x180D1B880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xA2BF10", Offset = "0xA2AF10", VA = "0x180A2BF10")]
	public LODDIGECODM(IDictionary<object, object> NKPHHCMFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2716720", Offset = "0x2715720", VA = "0x182716720")]
	public bool LHMGCMFEFNO(out OCLNBBADIAK HJJLMCEMDKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2716640", Offset = "0x2715640", VA = "0x182716640")]
	public Guid HJMBAGJOLHP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2716440", Offset = "0x2715440", VA = "0x182716440")]
	public PEOGNNHCCMJ BCPEEGAJDKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2716550", Offset = "0x2715550", VA = "0x182716550")]
	public static ExitGames.Client.Photon.Hashtable HFOCJEBDOBL(OCLNBBADIAK HJJLMCEMDKN, PEOGNNHCCMJ PKKDOKCIBNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PBKOKMCFKBA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLEKGJLIEBI(MDLFNDBDIID.ECFENKCNJOJ OKCLOHANPID);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCPPOELNOOM(MDLFNDBDIID.ECFENKCNJOJ OKCLOHANPID);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum CABODNGLNAF
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
public abstract class MDLFNDBDIID : PBKOKMCFKBA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate PEOGNNHCCMJ ECFENKCNJOJ([NotNull] PIPFLAHHDDO AJKECCIHKAK);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class OBCBPDIPKOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public PIPFLAHHDDO photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OBCBPDIPKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B07E40", Offset = "0x3B06E40", VA = "0x183B07E40")]
		internal PEOGNNHCCMJ HCPNGOGBLNO(ECFENKCNJOJ v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool GPPEICIHMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly HashSet<ECFENKCNJOJ> MDILMAOJEDA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2717070", Offset = "0x2716070", VA = "0x182717070", Slot = "4")]
	public void OLEKGJLIEBI(ECFENKCNJOJ OKCLOHANPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2716DA0", Offset = "0x2715DA0", VA = "0x182716DA0", Slot = "5")]
	public void JCPPOELNOOM(ECFENKCNJOJ OKCLOHANPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2716D50", Offset = "0x2715D50", VA = "0x182716D50", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2716E00", Offset = "0x2715E00", VA = "0x182716E00")]
	protected PEOGNNHCCMJ KMLJOGJGJCL(PIPFLAHHDDO KMJAMONBHPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2716CD0", Offset = "0x2715CD0", VA = "0x182716CD0")]
	protected MDLFNDBDIID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MNKHJJCGBIA
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class CCEMCJLNNHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public ONCPNDKMCDI subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CCEMCJLNNHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8F40", Offset = "0x3AF7F40", VA = "0x183AF8F40")]
		internal bool MCCKDOMODOP(MEKHHBDIOBK s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x271A210", Offset = "0x2719210", VA = "0x18271A210")]
	public static CCGGKNOLNJA HFOCJEBDOBL(long MIOIFKGBHHG, long BPCDOJMJPPI, string NELEGDAMKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x271A140", Offset = "0x2719140", VA = "0x18271A140")]
	public static CCGGKNOLNJA HFOCJEBDOBL(long MIOIFKGBHHG, long BPCDOJMJPPI, PLLPALDIOHF PLNEIMJEEFL, long EOFGLMIFIFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x271A2B0", Offset = "0x27192B0", VA = "0x18271A2B0")]
	public static CCGGKNOLNJA HFOCJEBDOBL(CEIPMKNCAPB CFPLOCNJAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2719F00", Offset = "0x2718F00", VA = "0x182719F00")]
	public static CCGGKNOLNJA HFOCJEBDOBL(EAHJJHFFELH NHIPDFKJMBA, ONCPNDKMCDI AGIGJBBPPLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2719E00", Offset = "0x2718E00", VA = "0x182719E00")]
	public static CCGGKNOLNJA AKAOFGJCIHK(this CCGGKNOLNJA EMBONFDCNJA, EAHJJHFFELH LDCKEEOMNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2719C70", Offset = "0x2718C70", VA = "0x182719C70")]
	public static CCGGKNOLNJA AJECIAKAHHL(this CCGGKNOLNJA EMBONFDCNJA, ONCPNDKMCDI BIOIGMONADN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum HBEGDFAMBIJ
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum NOBDFJFKCAB
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
public struct KPECHFMAHBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly long MIOIFKGBHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly long BPCDOJMJPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly HBEGDFAMBIJ DPPJBLOOGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[CanBeNull]
	public readonly Exception HOHKBNBEANO;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2714D10", Offset = "0x2713D10", VA = "0x182714D10")]
	public KPECHFMAHBD(long MIOIFKGBHHG, long BPCDOJMJPPI, HBEGDFAMBIJ DPPJBLOOGOO, [CanBeNull] Exception HOHKBNBEANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2714CC0", Offset = "0x2713CC0", VA = "0x182714CC0")]
	public static KPECHFMAHBD FBIHFGFHMLJ(GDOIHMDILDL KKFLLEINDMP, HBEGDFAMBIJ DPPJBLOOGOO, [Optional] Exception HOHKBNBEANO)
	{
		return default(KPECHFMAHBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public delegate void KHGHBNJHLDD(KPECHFMAHBD JBAGHENJMLO);
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface KBCIOEDODBM : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action ABJKFCILOKK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KHGHBNJHLDD AEIHNHGEEOP;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KHGHBNJHLDD JJPGKPMCHKP;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KHGHBNJHLDD NPDOAAOFDKP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<NOBDFJFKCAB, bool> OBBCOOGJLIE;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NBEEHGBPENI();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JLNMJFONIEJ(KPECHFMAHBD JBAGHENJMLO);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PCHOBMLHGGN(KPECHFMAHBD JBAGHENJMLO);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LBJLFPDKKOD(KPECHFMAHBD JBAGHENJMLO);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AFABNDBFNLN(NOBDFJFKCAB BEAPEJKINEL, bool DHPCHJKOPIB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[UnityEngine.Scripting.Preserve]
internal class KNKILCNAPHA : GFIAEOLPDAA, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KHMLLAOPPPM : IAsyncStateMachine
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
		public KNKILCNAPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private MNKIABAIHBN<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private KABNIFBIBJJ <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KHMLLAOPPPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3B03B20", Offset = "0x3B02B20", VA = "0x183B03B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NDLENNICCHK KMPGOOMEOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private EDCIEFBMDMA ENFILAAAEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ICNMDKOPAPC MAFAKNAOHHM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x20F92C0", Offset = "0x20F82C0", VA = "0x1820F92C0", Slot = "6")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x20F9210", Offset = "0x20F8210", VA = "0x1820F9210", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x20F90C0", Offset = "0x20F80C0", VA = "0x1820F90C0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KHMLLAOPPPM))]
	public Task CPOOMCOFOEP(string CDLBCMHHGDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x20F9260", Offset = "0x20F8260", VA = "0x1820F9260", Slot = "4")]
	public PEOGNNHCCMJ HDEAPIKJOFC(PIPFLAHHDDO CIAMEHCABFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x20F94D0", Offset = "0x20F84D0", VA = "0x1820F94D0")]
	private KABNIFBIBJJ PMKENMNINKG(string CDLBCMHHGDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public KNKILCNAPHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface HIPOKMDFNOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LJHHKPFNHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IONCDNFBKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Task IIBIFMDKDOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LPIFDEEMPOB JFDAOMKHGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action ABJKFCILOKK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event KHGHBNJHLDD AEIHNHGEEOP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event KHGHBNJHLDD JJPGKPMCHKP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event KHGHBNJHLDD NPDOAAOFDKP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<NOBDFJFKCAB, bool> OBBCOOGJLIE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GCCLJDHLHHO();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEELIAJJJHO AAPDNHIMJEB();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HFHJABDNILK MLIBHCMACAE();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<PEOGNNHCCMJ> OJCHDNNMAAB(MCFPGIBLJJO MFDMMJHLBJH);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task OAGELGNEHFB(CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface NFAKBLJLFPN : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PEOGNNHCCMJ> OJCHDNNMAAB(MCFPGIBLJJO NLDFIJLPMIC);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OAGELGNEHFB(CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[RecRoom.NoEngine.Common.Preserve]
internal class KMFGMBELFGO : NEAAGLADJAL, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class BGPLHBGHPGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public GDOIHMDILDL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public LPIFDEEMPOB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public KMFGMBELFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Task <task>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BGPLHBGHPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3AF87C0", Offset = "0x3AF77C0", VA = "0x183AF87C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GMJOCNKPOOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public GDOIHMDILDL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public LPIFDEEMPOB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public KMFGMBELFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private MNKIABAIHBN<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private DMMCOJOPIJA <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private CHFCJEGMBJC <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private OperationCanceledException <oce>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GMJOCNKPOOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF560", Offset = "0x3AFE560", VA = "0x183AFF560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GAKNOFGCBFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Matchmaking.NFHIKJHBHNK result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GECBALHMMKM errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GAKNOFGCBFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE4D0", Offset = "0x3AFD4D0", VA = "0x183AFE4D0")]
		internal object MPEPOENOENN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FOLIMKLLKBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Task<CCGGKNOLNJA> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public FOLIMKLLKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		internal Task<CCGGKNOLNJA> KLFGJMLGEBE(MNKIABAIHBN<string>.JJAEKMMDGKH _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CMJFKPFGDDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public GDOIHMDILDL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public LPIFDEEMPOB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public DMMCOJOPIJA joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public KMFGMBELFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private ILGLECHNODC <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private CancellationTokenRegistration <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private FOLIMKLLKBL <>8__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private KMGKAPJIBHJ <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private Task<Matchmaking.AOEJIFLEEHC> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private BMMMMAEEGKA <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Matchmaking.AOEJIFLEEHC <serverConnectionInfo>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private CancellationTokenSource <cameraFadeCts>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CancellationTokenSource <loadingScreenCts>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <loadingScreenScope>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Matchmaking.AOEJIFLEEHC <>s__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private CancellationTokenSource <photonJoinedTokenSource>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private CancellationToken <photonJoinedToken>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private CCGGKNOLNJA <initialRoomLoadPayload>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private CCGGKNOLNJA <>s__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<Matchmaking.AOEJIFLEEHC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter<CCGGKNOLNJA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CMJFKPFGDDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3AF94F0", Offset = "0x3AF84F0", VA = "0x183AF94F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class OINCHKGEBDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public KMFGMBELFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <disconnectTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private object <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Exception <ex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OINCHKGEBDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B07F90", Offset = "0x3B06F90", VA = "0x183B07F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class DGJACNCAPOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public KMFGMBELFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private CNALHHIKJDD <roomContainer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public DGJACNCAPOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC010", Offset = "0x3AFB010", VA = "0x183AFC010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class IEMADFADLGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder<Matchmaking.AOEJIFLEEHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GDOIHMDILDL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public KMFGMBELFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Matchmaking.AOEJIFLEEHC <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter<Matchmaking.AOEJIFLEEHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IEMADFADLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3B01860", Offset = "0x3B00860", VA = "0x183B01860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class CIGCJBBEBFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Matchmaking.AOEJIFLEEHC serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public DMMCOJOPIJA joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public KMFGMBELFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private HJMJDGNBKDK <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<HJMJDGNBKDK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CIGCJBBEBFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8F70", Offset = "0x3AF7F70", VA = "0x183AF8F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class MPODJEMLJNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public GDOIHMDILDL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MPODJEMLJNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class EGMGKKLEEDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public MPODJEMLJNG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public EGMGKKLEEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC5F0", Offset = "0x3AFB5F0", VA = "0x183AFC5F0")]
		internal object PLGJIOPIPID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC4E0", Offset = "0x3AFB4E0", VA = "0x183AFC4E0")]
		internal string LDGJJPICGLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class FOEDAHKCEDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public GDOIHMDILDL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public KMFGMBELFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private MPODJEMLJNG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private EGMGKKLEEDD <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public FOEDAHKCEDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3AFDA00", Offset = "0x3AFCA00", VA = "0x183AFDA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class IBCNAJKGJAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CCGGKNOLNJA initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public ILGLECHNODC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public GDOIHMDILDL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public DMMCOJOPIJA joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public KMFGMBELFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private DMMCOJOPIJA <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private PPGAOMKJBNI <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IBCNAJKGJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3B00ED0", Offset = "0x3AFFED0", VA = "0x183B00ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class IPIIBALPDPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public KMFGMBELFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private CancellationTokenSource <timeoutTcs>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private CancellationToken <timeoutToken>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IPIIBALPDPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3B02290", Offset = "0x3B01290", VA = "0x183B02290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MMDOOALCCIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public KMFGMBELFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int <version>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private bool <canUpdateRoom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private bool <shouldSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x56")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter<PEOGNNHCCMJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MMDOOALCCIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3B05F70", Offset = "0x3B04F70", VA = "0x183B05F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class OPELJBFBAJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public GDOIHMDILDL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OPELJBFBAJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3B093B0", Offset = "0x3B083B0", VA = "0x183B093B0")]
		internal object CBIGHIKMHJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class EFODPKMANPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public EFODPKMANPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC440", Offset = "0x3AFB440", VA = "0x183AFC440")]
		internal void NLJEDEKILOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LBABGENMCCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public GDOIHMDILDL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LBABGENMCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3B04BA0", Offset = "0x3B03BA0", VA = "0x183B04BA0")]
		internal object KOIJCKEAHCE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class BGGAIENJEHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public GDOIHMDILDL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BGGAIENJEHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3AF86C0", Offset = "0x3AF76C0", VA = "0x183AF86C0")]
		internal string CNJLAIAANKF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly HPPHLHFLMDP EPAIGGNBOJJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly HPPHLHFLMDP NODNNPFDIPD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly HPPHLHFLMDP BKLNEBFJACO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly string HDGDLGGANCA;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly string KFBGGDPJAJJ;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly string GPJJEEHGJIC;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly Guid KLFECPKCBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private KNGIAEBKBLN NEHHPMGHOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private MODHPLENFAK MMHFCCGACDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private JAEAMIMPOOP JOJGGPKEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private HJNEIHJIJJJ IFMMICNCAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private GCNGFCNMOLL EACKCFCOOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private HJIGCIAFGLC BNEICDKJHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private KBCIOEDODBM CDMKNNGLNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private CGIEFEIKFEN LDOPCKOMICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private IEFGNBGNHNN JAEKGMHHFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private IDisposable KGAAGLCPIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly DPLHGKBKOHE MNDDAFLGNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly DPLHGKBKOHE BFCHNJJHOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private BMMMMAEEGKA CGCIPNFKODD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TaskStatus CJNHJBHKBBH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x20F60F0", Offset = "0x20F50F0", VA = "0x1820F60F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x20F7FD0", Offset = "0x20F6FD0", VA = "0x1820F7FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private KCMAHJPHMBH CGILCLDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x20F64A0", Offset = "0x20F54A0", VA = "0x1820F64A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x20F75D0", Offset = "0x20F65D0", VA = "0x1820F75D0", Slot = "6")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x20F5AD0", Offset = "0x20F4AD0", VA = "0x1820F5AD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x20F4A20", Offset = "0x20F3A20", VA = "0x1820F4A20", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BGPLHBGHPGD))]
	public Task BJPHOHNIGAP(GDOIHMDILDL DIOKIHLDBFF, LPIFDEEMPOB EECALEFDDBM, CancellationToken JCAANINIIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x20F6300", Offset = "0x20F5300", VA = "0x1820F6300")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GMJOCNKPOOG))]
	private Task GFGBJBIECNB(GDOIHMDILDL DIOKIHLDBFF, LPIFDEEMPOB EECALEFDDBM, CancellationToken JCAANINIIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x20F4660", Offset = "0x20F3660", VA = "0x1820F4660")]
	private static void BBDMDPBJFCB(CGIEFEIKFEN LDOPCKOMICA, GDOIHMDILDL DIOKIHLDBFF, Exception IKOKPNLPNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x20F5100", Offset = "0x20F4100", VA = "0x1820F5100")]
	private static void DDJCICKPNLF(CHFCJEGMBJC PNEJFPAPIED, Exception IKOKPNLPNJB, [Optional] List<int> ABMKDKNBEPN, int GPKBDBOBCOF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x20F6A50", Offset = "0x20F5A50", VA = "0x1820F6A50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CMJFKPFGDDC))]
	private Task IJEHDJAJBCK(MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, GDOIHMDILDL DIOKIHLDBFF, LPIFDEEMPOB EECALEFDDBM, DMMCOJOPIJA JMKEMIHLGLC, CancellationToken JCAANINIIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x20F4CD0", Offset = "0x20F3CD0", VA = "0x1820F4CD0")]
	private void BPHDGPJALAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x20F68E0", Offset = "0x20F58E0", VA = "0x1820F68E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OINCHKGEBDP))]
	private Task IENGKPJJJJJ(MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x20F5B20", Offset = "0x20F4B20", VA = "0x1820F5B20")]
	private void EFKFFDOKNGP(GDOIHMDILDL DIOKIHLDBFF, CancellationToken JCAANINIIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x20F5E30", Offset = "0x20F4E30", VA = "0x1820F5E30")]
	private void FDDFEDKDBEI(GDOIHMDILDL DIOKIHLDBFF, DMMCOJOPIJA JMKEMIHLGLC, OperationCanceledException OKCLOPCEOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x20F7C80", Offset = "0x20F6C80", VA = "0x1820F7C80")]
	private void OGOCJMLCMKL(GDOIHMDILDL DIOKIHLDBFF, DMMCOJOPIJA JMKEMIHLGLC, Exception IKOKPNLPNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x20F6EC0", Offset = "0x20F5EC0", VA = "0x1820F6EC0")]
	private void KEJEGAMDJHB(GDOIHMDILDL DIOKIHLDBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x20F7500", Offset = "0x20F6500", VA = "0x1820F7500")]
	private static KPECHFMAHBD LGEHPDDGOFH(GDOIHMDILDL DIOKIHLDBFF)
	{
		return default(KPECHFMAHBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x20F7EB0", Offset = "0x20F6EB0", VA = "0x1820F7EB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DGJACNCAPOE))]
	private Task PKPCKJDKKBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x20F5930", Offset = "0x20F4930", VA = "0x1820F5930")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IEMADFADLGK))]
	private Task<Matchmaking.AOEJIFLEEHC> DFMBMDMIJIG(GDOIHMDILDL DIOKIHLDBFF, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x20F4BC0", Offset = "0x20F3BC0", VA = "0x1820F4BC0")]
	private static HJMJDGNBKDK BLNEKHAGIMM(Matchmaking.AOEJIFLEEHC MCANKLEJLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x20F64F0", Offset = "0x20F54F0", VA = "0x1820F64F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CIGCJBBEBFG))]
	private Task GMKLOLPBLAO(Matchmaking.AOEJIFLEEHC MCANKLEJLLA, DMMCOJOPIJA JMKEMIHLGLC, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken CFKODBAEEON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x20F6D20", Offset = "0x20F5D20", VA = "0x1820F6D20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FOEDAHKCEDJ))]
	private Task JPNPJHJFIKH(GDOIHMDILDL DIOKIHLDBFF, CancellationTokenSource IKPOIGKKEDK, Task MGMFNCIOIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x20F6100", Offset = "0x20F5100", VA = "0x1820F6100")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IBCNAJKGJAF))]
	private Task GEBOGHBMIJK(CCGGKNOLNJA CLOCHCJAIEB, ILGLECHNODC HEHNPOGOANF, GDOIHMDILDL PCGCFHDFHBE, DMMCOJOPIJA GALKMMFPJDI, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken IMHLBODKAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x20F70D0", Offset = "0x20F60D0", VA = "0x1820F70D0")]
	private DMMCOJOPIJA KFNDKPBPENJ(DMMCOJOPIJA GALKMMFPJDI, ref CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x20F4F90", Offset = "0x20F3F90", VA = "0x1820F4F90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IPIIBALPDPD))]
	private Task CKOBLACEPGB(MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x20F7290", Offset = "0x20F6290", VA = "0x1820F7290")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MMDOOALCCIC))]
	private Task KPMLOOJMCID(OFIMLBDMAME HHCEHFFEAKN, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x20F4E20", Offset = "0x20F3E20", VA = "0x1820F4E20")]
	private static void CKEFAEJFOJA(GDOIHMDILDL DIOKIHLDBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x20F7960", Offset = "0x20F6960", VA = "0x1820F7960")]
	private void MMAHJHOFLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x20F7BF0", Offset = "0x20F6BF0", VA = "0x1820F7BF0")]
	private void NIACIBLFDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x20F7540", Offset = "0x20F6540", VA = "0x1820F7540")]
	private void LLBNHMKPJEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x20F6060", Offset = "0x20F5060", VA = "0x1820F6060")]
	private void FDLDMAINENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x20F7400", Offset = "0x20F6400", VA = "0x1820F7400")]
	private static void LFBBPGJCJFM(GDOIHMDILDL DIOKIHLDBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x20F6C30", Offset = "0x20F5C30", VA = "0x1820F6C30")]
	private static CancellationTokenRegistration JHEGJCCJJHF(GDOIHMDILDL DIOKIHLDBFF, CancellationToken CFKODBAEEON)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x20F7860", Offset = "0x20F6860", VA = "0x1820F7860")]
	private static void LLLPDGHCFJF(GDOIHMDILDL DIOKIHLDBFF, Exception IKOKPNLPNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x20F66B0", Offset = "0x20F56B0", VA = "0x1820F66B0")]
	private void HNGMPFLJJLF(GDOIHMDILDL DIOKIHLDBFF, Task MGMFNCIOIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x20F45F0", Offset = "0x20F35F0", VA = "0x1820F45F0")]
	private static void AHJGPEGCGMK(Func<string> BKCPGKELHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x20F81D0", Offset = "0x20F71D0", VA = "0x1820F81D0")]
	public KMFGMBELFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x20F7B80", Offset = "0x20F6B80", VA = "0x1820F7B80")]
	[CompilerGenerated]
	internal static (int, int?) NEOHOIIBNAI(GECBALHMMKM LJGEMIIINDB)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PGJBGAMIGNP
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EEONHCOMEMH<MDCFFKCLDEA, JINHIJEHMKF>> JOEIEMLGPEM(string BJIEMONJOEI, long NECHDOJFBMC, LELBODDNBJP.BCEIMCNOHBP JLDFEGPNHDI, CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class EAOGBJCIHGO : HNBGIDPCAHG<OCLNBBADIAK>
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class LOGICHJMOPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public OCLNBBADIAK message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LOGICHJMOPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x27167E0", Offset = "0x27157E0", VA = "0x1827167E0")]
		internal object MAKJOHEBPOG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static readonly EAOGBJCIHGO HIEJPGCOIBA;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const string FLDPFAGNHLL = "pl";

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x20E49A0", Offset = "0x20E39A0", VA = "0x1820E49A0")]
	public ExitGames.Client.Photon.Hashtable IKBIGFALLCH(OCLNBBADIAK HJJLMCEMDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x20E4370", Offset = "0x20E3370", VA = "0x1820E4370", Slot = "5")]
	protected override void DLFNOOFOGFK(OCLNBBADIAK HJJLMCEMDKN, IDictionary<object, object> HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x20E44A0", Offset = "0x20E34A0", VA = "0x1820E44A0", Slot = "6")]
	public override OCLNBBADIAK EILKNJCKJNI(IDictionary<object, object> HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x20E4250", Offset = "0x20E3250", VA = "0x1820E4250")]
	private static void AHJGPEGCGMK(string OIMFHLMMKMO, OCLNBBADIAK HJJLMCEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x20E4AA0", Offset = "0x20E3AA0", VA = "0x1820E4AA0")]
	public EAOGBJCIHGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x20E46A0", Offset = "0x20E36A0", VA = "0x1820E46A0")]
	[CompilerGenerated]
	internal static string FLCDBONBMAH(CCGGKNOLNJA EMBONFDCNJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface OAKPMPALGKI<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EEONHCOMEMH<byte[], JINHIJEHMKF>> PLFFOHEHANL(TGetDataArg IELOEMGHLEA, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EEONHCOMEMH<KDFENHBNPBD<TData>, JINHIJEHMKF> NANPAHNMMCN(byte[] HHCEHFFEAKN);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FHMMJBGMKEF : PBKOKMCFKBA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEOGNNHCCMJ PHNPLOHJNJC(PIPFLAHHDDO KMJAMONBHPD);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class OHFNPHBGPOD : GFCGJHOKPLP, GLLHGJIIOGP, MAMFKBMKCDB, PDMLHPDINJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly GLLHGJIIOGP KDKOMEPNHGI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PIPFLAHHDDO KBJDFGPGPMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2720400", Offset = "0x271F400", VA = "0x182720400", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PIAPFOKPEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2720360", Offset = "0x271F360", VA = "0x182720360", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ODCOJIGGAKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x27203B0", Offset = "0x271F3B0", VA = "0x1827203B0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool ALFIIDEKEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x85F430", Offset = "0x85E430", VA = "0x18085F430", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int INMJOHPPKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x90AF50", Offset = "0x909F50", VA = "0x18090AF50", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event DKAEFIMMGLP.EMGDIKGHLGI HNOPGHEOFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event NANDKONKGJJ BGBCENCILMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2720530", Offset = "0x271F530", VA = "0x182720530", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2720220", Offset = "0x271F220", VA = "0x182720220", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> JDDFDGNFDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<PIPFLAHHDDO> CLBABJLDBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action DJJGCGACPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x27202C0", Offset = "0x271F2C0", VA = "0x1827202C0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2720180", Offset = "0x271F180", VA = "0x182720180", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x18AE620", Offset = "0x18AD620", VA = "0x1818AE620")]
	public OHFNPHBGPOD(GLLHGJIIOGP KDKOMEPNHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2720050", Offset = "0x271F050", VA = "0x182720050", Slot = "8")]
	public bool CBNPEBFEAEF(byte NMBDCPKHMGJ, ExitGames.Client.Photon.Hashtable EDMOCEKFDLH, PBHPNDBCFEA LIFKIAIFMJL, SendOptions GCEDNNAJHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x27205D0", Offset = "0x271F5D0", VA = "0x1827205D0", Slot = "29")]
	public PIPFLAHHDDO PHGGBJMAKLM(int NMEOIAKJCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2720450", Offset = "0x271F450", VA = "0x182720450", Slot = "16")]
	public PIPFLAHHDDO OBCBFOJGJCN(int CPBBCPFIMJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "19")]
	public void DHKCHJGGDGG(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "20")]
	public void FFMIBHAHNJP(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "21")]
	public void IECHOGPGKMD(object FFKJLIDBALM, bool OEILNLDPJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2720120", Offset = "0x271F120", VA = "0x182720120", Slot = "22")]
	public IDisposable DLCMLHNAKEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "23")]
	private bool OOEDDDJDOLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "24")]
	public void MFADABIIPEG(StringBuilder NKJCKCLIHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2720100", Offset = "0x271F100", VA = "0x182720100", Slot = "25")]
	public bool CNDOMMFNJAA(bool PMNHBPBDMFA, out string AOLOOCNDGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public void IHHEDGAADDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x96B0F0", Offset = "0x96A0F0", VA = "0x18096B0F0", Slot = "28")]
	public void KDIDABJOFAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal struct CGBPHMDNPHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly TaskCompletionSource<(PEOGNNHCCMJ, Task)> JLKCEFMEPJL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Task<(PEOGNNHCCMJ, Task)> GMCDBNHDALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x20E0DC0", Offset = "0x20DFDC0", VA = "0x1820E0DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x20E0F70", Offset = "0x20DFF70", VA = "0x1820E0F70")]
	public CGBPHMDNPHP(TimeSpan MLIKJMAKNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x20E0D20", Offset = "0x20DFD20", VA = "0x1820E0D20")]
	public void CLBGIJBBMLN(Task LDHHKGCGIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x20E0E50", Offset = "0x20DFE50", VA = "0x1820E0E50")]
	public void NGEACCDGPPP(PEOGNNHCCMJ PKKDOKCIBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x20E0E00", Offset = "0x20DFE00", VA = "0x1820E0E00")]
	public void JMLBGKDAONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x20E0EE0", Offset = "0x20DFEE0", VA = "0x1820E0EE0")]
	internal void OPENGIAJKPI(string HJJLMCEMDKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class KOELMMBGENH : JLPMGBNKLLC, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool DAMFAHLFNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private GEMMKFJNFAA KKOHLAGNAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private JAEAMIMPOOP JOJGGPKEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private KOBHDJIAOEJ LCFBHAKNLEG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GEMMKFJNFAA JDKGJBKDGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2714C50", Offset = "0x2713C50", VA = "0x182714C50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2714AE0", Offset = "0x2713AE0", VA = "0x182714AE0", Slot = "7")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2714860", Offset = "0x2713860", VA = "0x182714860", Slot = "5")]
	public void AOOCEOOBMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2714A20", Offset = "0x2713A20", VA = "0x182714A20", Slot = "6")]
	public void DNICCIPHLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2714A60", Offset = "0x2713A60", VA = "0x182714A60")]
	private Task IKKBLHPGAEP(FHKEOHGPFBE LPGJKBJMDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2714A20", Offset = "0x2713A20", VA = "0x182714A20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x9BBF50", Offset = "0x9BAF50", VA = "0x1809BBF50")]
	public KOELMMBGENH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct BDNLBKFEPKM
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class FLLGOLALHHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public DICEJLBHJCH manager;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public FLLGOLALHHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2711730", Offset = "0x2710730", VA = "0x182711730")]
		internal Task POFNKBOPHAN(OFIMLBDMAME data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class BNHFKAHHNCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public BDNLBKFEPKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private MCFPGIBLJJO <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private GMMGNMCOLCN <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private GMMGNMCOLCN <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private GMMGNMCOLCN <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter<GMMGNMCOLCN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter<PEOGNNHCCMJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BNHFKAHHNCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x270E200", Offset = "0x270D200", VA = "0x18270E200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JHDKKAHDAAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public BDNLBKFEPKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JHDKKAHDAAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2713340", Offset = "0x2712340", VA = "0x182713340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly CancellationToken OAGBBBCDIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly DICEJLBHJCH ALPIPCHDOEM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private JAEAMIMPOOP DFGGBACJICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x20DC0C0", Offset = "0x20DB0C0", VA = "0x1820DC0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private HJNEIHJIJJJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x20DBBA0", Offset = "0x20DABA0", VA = "0x1820DBBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private KCMAHJPHMBH CGILCLDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x20DBF20", Offset = "0x20DAF20", VA = "0x1820DBF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private NFAKBLJLFPN JPIBCBBLKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x20DC1D0", Offset = "0x20DB1D0", VA = "0x1820DC1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x20DC370", Offset = "0x20DB370", VA = "0x1820DC370")]
	public BDNLBKFEPKM(CancellationToken OAGBBBCDIGC, DICEJLBHJCH ALPIPCHDOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x20DC110", Offset = "0x20DB110", VA = "0x1820DC110")]
	public static DAIHOFLBDLA MDEANEEHLME(DICEJLBHJCH ALPIPCHDOEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x20DC220", Offset = "0x20DB220", VA = "0x1820DC220")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BNHFKAHHNCH))]
	public Task<bool> PLLHAMBOEGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x20DBD20", Offset = "0x20DAD20", VA = "0x1820DBD20")]
	private bool EMEDBDNFBIF(out MCFPGIBLJJO NLDFIJLPMIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x20DBFA0", Offset = "0x20DAFA0", VA = "0x1820DBFA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JHDKKAHDAAH))]
	private Task HAKADAIKHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x20DBBF0", Offset = "0x20DABF0", VA = "0x1820DBBF0")]
	private Task<GMMGNMCOLCN> EIFPOBGMHHP(MCFPGIBLJJO EJFDBCCNDIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class PNKKGDNELCD : KOBHDJIAOEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class LEIEIMHENII<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly IMBCFAJLPLN GGPALPEDDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly string LOHIKDGDMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly T PNJDHPAJOAO;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public T FNCIDNAOCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x9127F0", Offset = "0x9117F0", VA = "0x1809127F0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x912800", Offset = "0x911800", VA = "0x180912800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x268CA60", Offset = "0x268BA60", VA = "0x18268CA60")]
		public LEIEIMHENII(IMBCFAJLPLN GGPALPEDDJN, string LOHIKDGDMPP, T PNJDHPAJOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x268C480", Offset = "0x268B480", VA = "0x18268C480")]
		private void BGBJKHIGGNN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly IMBCFAJLPLN GGPALPEDDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly LEIEIMHENII<TimeSpan> GDKGFOGFDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly LEIEIMHENII<TimeSpan> GINPFLNJLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly LEIEIMHENII<TimeSpan> OECBBABHOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly LEIEIMHENII<TimeSpan> CFOBDCLJHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly LEIEIMHENII<bool> MOOJIMNDIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly LEIEIMHENII<bool> NHDJDDJGLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly LEIEIMHENII<bool> NOLLCALCFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly LEIEIMHENII<int> IMCNEFIIMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly LEIEIMHENII<bool> INNOMMBHKFK;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private const string CHCJEAJGOHF = "RoomLoadCameraFadeTimeout";

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan DLFCNAEHGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2725C10", Offset = "0x2724C10", VA = "0x182725C10", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan MKLJMANAPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2725CD0", Offset = "0x2724CD0", VA = "0x182725CD0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public TimeSpan FOGFMPCCMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2725F50", Offset = "0x2724F50", VA = "0x182725F50", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public TimeSpan ENEBDCHBPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2725F90", Offset = "0x2724F90", VA = "0x182725F90", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool GJEEBJFFCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2725C90", Offset = "0x2724C90", VA = "0x182725C90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool IAIHDCFIBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2726010", Offset = "0x2725010", VA = "0x182726010", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool GLFLCAPGJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2725C50", Offset = "0x2724C50", VA = "0x182725C50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int LNBNLBJMCPI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2725FD0", Offset = "0x2724FD0", VA = "0x182725FD0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool LGHPAENKKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2726050", Offset = "0x2725050", VA = "0x182726050", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool KKFFANDHPKG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2725D10", Offset = "0x2724D10", VA = "0x182725D10", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TimeSpan IJHDGCIGKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2725E00", Offset = "0x2724E00", VA = "0x182725E00", Slot = "12")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2726090", Offset = "0x2725090", VA = "0x182726090")]
	[UnityEngine.Scripting.Preserve]
	public PNKKGDNELCD([JFLEHDEIONF(null)] IMBCFAJLPLN GGPALPEDDJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal struct KKEEEEIJOJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MEGBEIAHAGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public KKEEEEIJOJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MEGBEIAHAGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3B054F0", Offset = "0x3B044F0", VA = "0x183B054F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly CancellationTokenSource IGGNLLGJDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool GPPEICIHMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private Task IJOJNMAHKLB;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MFPCNNNAAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x20F44A0", Offset = "0x20F34A0", VA = "0x1820F44A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal Task GMCDBNHDALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x20F42C0", Offset = "0x20F32C0", VA = "0x1820F42C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x20F44D0", Offset = "0x20F34D0", VA = "0x1820F44D0")]
	public KKEEEEIJOJM(CancellationToken OAGBBBCDIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x20F4340", Offset = "0x20F3340", VA = "0x1820F4340")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MEGBEIAHAGE))]
	public Task NOCACOFFKOO(Func<CancellationToken, List<Task>> MFMGLMHLLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x20F4270", Offset = "0x20F3270", VA = "0x1820F4270", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal interface PLKALHHIPOD : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LCJHGCCKGGO AMLBOIMHPGF(Guid MLHJIHFFCGB);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DNDEJFPIDIA(Guid MLHJIHFFCGB);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DCGDHJNMPEG(Guid MLHJIHFFCGB, Task LDHHKGCGIPG);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KIKLIIBBLEG(Guid MLHJIHFFCGB, PEOGNNHCCMJ LJHLAAEHIME);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HKHNCGFKDLF(Guid MLHJIHFFCGB);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(PEOGNNHCCMJ, Task)> FAEAJJPLLCF(Guid MLHJIHFFCGB);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal interface EDCIEFBMDMA : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEOGNNHCCMJ PFOCDGNMLAM(PIPFLAHHDDO CIAMEHCABFJ, IOANKPJOPII FHNGDKCLEKI);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PEOGNNHCCMJ DJBGDIMMPBI(PIPFLAHHDDO KMJAMONBHPD);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PEOGNNHCCMJ LBELIJNCGGJ(PIPFLAHHDDO KMJAMONBHPD);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class BMGFFDMJILO : AEOBIOGPCNC
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class AGNLLCDFBCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public BMGFFDMJILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private GDOIHMDILDL <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private GDOIHMDILDL <newPresenceRoomInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private float <timeoutTime>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AGNLLCDFBCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x270D790", Offset = "0x270C790", VA = "0x18270D790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private const float KJHHAFJGBLF = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly HJNEIHJIJJJ IFMMICNCAOG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private KCMAHJPHMBH CGILCLDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x20DE640", Offset = "0x20DD640", VA = "0x1820DE640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xAEDF80", Offset = "0xAECF80", VA = "0x180AEDF80")]
	public BMGFFDMJILO(DICEJLBHJCH FGIILGHEHMH, HJNEIHJIJJJ IFMMICNCAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x20DE4D0", Offset = "0x20DD4D0", VA = "0x1820DE4D0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AGNLLCDFBCF))]
	public Task<bool> DNIEJNCHPFL(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x20DE3F0", Offset = "0x20DD3F0", VA = "0x1820DE3F0")]
	[CompilerGenerated]
	private object DNEEJPHJHFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal interface HDMOMFNHLCD : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHFCOMCCCMH(OCLNBBADIAK HJJLMCEMDKN);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NELAFJHAJLB(OCLNBBADIAK HJJLMCEMDKN);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<IOANKPJOPII> DHPCNBDPBFP(CancellationToken MJHMAANKOHC);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal interface GFIAEOLPDAA : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEOGNNHCCMJ HDEAPIKJOFC(PIPFLAHHDDO CIAMEHCABFJ);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CPOOMCOFOEP(string CDLBCMHHGDO);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[UnityEngine.Scripting.Preserve]
internal class NFHIPKJPJBL : HJIGCIAFGLC, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class HAEGFECJPFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public NFHIPKJPJBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HAEGFECJPFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3B00460", Offset = "0x3AFF460", VA = "0x183B00460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly DPLHGKBKOHE ALKABGLCNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private string LJODIGBBACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Task DJCNNIDKINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool NGGJDDOMAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x271AD50", Offset = "0x2719D50", VA = "0x18271AD50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Task BBPFNNOGPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x271ACF0", Offset = "0x2719CF0", VA = "0x18271ACF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9132B0", Offset = "0x9122B0", VA = "0x1809132B0", Slot = "7")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x271AB30", Offset = "0x2719B30", VA = "0x18271AB30", Slot = "6")]
	public void FNHBIJMDADB(Task IJOJNMAHKLB, string LDDNAFEDNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x271A9C0", Offset = "0x27199C0", VA = "0x18271A9C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HAEGFECJPFB))]
	private Task EKDDJMBIAKD(Task GCECGMOKHBF, string LDDNAFEDNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x271AD80", Offset = "0x2719D80", VA = "0x18271AD80")]
	public NFHIPKJPJBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal struct LCJHGCCKGGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly PLKALHHIPOD ABDLBIKBIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly Guid MLHJIHFFCGB;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Task<(PEOGNNHCCMJ, Task)> GMCDBNHDALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2716050", Offset = "0x2715050", VA = "0x182716050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x12EADF0", Offset = "0x12E9DF0", VA = "0x1812EADF0")]
	public LCJHGCCKGGO(PLKALHHIPOD ABDLBIKBIJK, Guid MLHJIHFFCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2716120", Offset = "0x2715120", VA = "0x182716120")]
	public TaskAwaiter<(PEOGNNHCCMJ, Task)> KCKHOOIGOBL()
	{
		return default(TaskAwaiter<(PEOGNNHCCMJ, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2715F80", Offset = "0x2714F80", VA = "0x182715F80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[UnityEngine.Scripting.Preserve]
internal sealed class OMOGDHMODIP : NFAKBLJLFPN, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class ONHJGCDHLIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public AsyncTaskMethodBuilder<PEOGNNHCCMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public MCFPGIBLJJO autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public OMOGDHMODIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private MNKIABAIHBN<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private HBEFAIEENBH <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private CCGGKNOLNJA <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private PEOGNNHCCMJ <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter<PEOGNNHCCMJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ONHJGCDHLIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4430", Offset = "0x4EB3430", VA = "0x184EB4430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class KEELEANHGEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public OMOGDHMODIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private CancellationTokenSource <combinedTokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KEELEANHGEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0890", Offset = "0x4EAF890", VA = "0x184EB0890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class CONBOBLGOFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public OFIMLBDMAME _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public OMOGDHMODIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CONBOBLGOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4EAE390", Offset = "0x4EAD390", VA = "0x184EAE390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class APEELOPJDKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public OMOGDHMODIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private object <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public APEELOPJDKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC940", Offset = "0x4EAB940", VA = "0x184EAC940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class AIHKOLAIKHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public OMOGDHMODIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AIHKOLAIKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC690", Offset = "0x4EAB690", VA = "0x184EAC690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CDICBPNEJBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public OMOGDHMODIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private CancellationToken <nextAutosaveToken>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CDICBPNEJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD890", Offset = "0x4EAC890", VA = "0x184EAD890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class NOBDAGHMHIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public OMOGDHMODIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Task <delayTask>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Task<int> <intervalChangedTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private Task <resultTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NOBDAGHMHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2E60", Offset = "0x4EB1E60", VA = "0x184EB2E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class KNBEKCOAPOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public FALKJMEJPBK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public OMOGDHMODIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private MNKIABAIHBN<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private DMMCOJOPIJA <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private EIKGFPEMACB <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KNBEKCOAPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4EB1280", Offset = "0x4EB0280", VA = "0x184EB1280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private JAEAMIMPOOP JOJGGPKEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private HJNEIHJIJJJ IFMMICNCAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private ICNMDKOPAPC MAFAKNAOHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private HJIGCIAFGLC BNEICDKJHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private DCGNGBDMJOK MBLGJAFGPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private CancellationTokenSource EMLFOJFLJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Task KPDJCPNJILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private TaskCompletionSource<int> KJIGJBNIPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private int AGIAKFHCBFE;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2722C30", Offset = "0x2721C30", VA = "0x182722C30", Slot = "6")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0xD3E1F0", Offset = "0xD3D1F0", VA = "0x180D3E1F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2723500", Offset = "0x2722500", VA = "0x182723500")]
	private void OCPJFJNIGFO(float MGOININMGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x27235E0", Offset = "0x27225E0", VA = "0x1827235E0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ONHJGCDHLIM))]
	public Task<PEOGNNHCCMJ> OJCHDNNMAAB(MCFPGIBLJJO NLDFIJLPMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x27233B0", Offset = "0x27223B0", VA = "0x1827233B0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KEELEANHGEG))]
	public Task OAGELGNEHFB([Optional] CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xD3E1F0", Offset = "0xD3D1F0", VA = "0x180D3E1F0")]
	public void HOGLJCCFDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2723750", Offset = "0x2722750", VA = "0x182723750")]
	private HBEFAIEENBH PHONDAPCIOO(MCFPGIBLJJO NLDFIJLPMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x27226A0", Offset = "0x27216A0", VA = "0x1827226A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CONBOBLGOFN))]
	private Task BJIMOBFHPAL(OFIMLBDMAME LPGJKBJMDHN, CancellationToken JCAANINIIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2722DE0", Offset = "0x2721DE0", VA = "0x182722DE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(APEELOPJDKO))]
	private Task MMHACGDMEMO(CancellationToken JCAANINIIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2722960", Offset = "0x2721960", VA = "0x182722960")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AIHKOLAIKHM))]
	private Task ENJLENMDHDI([Optional] CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2722810", Offset = "0x2721810", VA = "0x182722810")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CDICBPNEJBJ))]
	private Task EEIBAJKLGKL(CancellationToken JCAANINIIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2722550", Offset = "0x2721550", VA = "0x182722550")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NOBDAGHMHIJ))]
	private Task BEDNJBPEODB(CancellationToken LKLPPIOMGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2723090", Offset = "0x2722090", VA = "0x182723090")]
	private Task NMBGIANGHFM(FALKJMEJPBK DDBBBGFMPLN, CancellationToken JCAANINIIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2722F30", Offset = "0x2721F30", VA = "0x182722F30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KNBEKCOAPOD))]
	private Task NBAEJOECEFE(FALKJMEJPBK DDBBBGFMPLN, CancellationToken JCAANINIIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2722AB0", Offset = "0x2721AB0", VA = "0x182722AB0")]
	private bool HDEAPIKJOFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public OMOGDHMODIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface NDLENNICCHK : PBKOKMCFKBA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEOGNNHCCMJ HDEAPIKJOFC(PIPFLAHHDDO AFPDMBJFOGD);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class BBKKMMOCLON : CCIKPIPJGPO, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class PNEGEJGEFNB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private readonly GDOIHMDILDL LJBLGDDIMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private readonly CancellationTokenSource IGGNLLGJDCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public readonly CancellationToken IHPCMNALJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private bool GGOCMBIEMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private bool NBJIGGJMNPH;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2725B60", Offset = "0x2724B60", VA = "0x182725B60")]
		public PNEGEJGEFNB(GDOIHMDILDL LJBLGDDIMIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2725A00", Offset = "0x2724A00", VA = "0x182725A00")]
		public void HKHNCGFKDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x27259D0", Offset = "0x27249D0", VA = "0x1827259D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class BKALLNGNNJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public FHKEOHGPFBE disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BKALLNGNNJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x270DFE0", Offset = "0x270CFE0", VA = "0x18270DFE0")]
		internal object FLLBDDIAGEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class NNNFNCFEMBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public FHKEOHGPFBE disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public BBKKMMOCLON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private BKALLNGNNJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NNNFNCFEMBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x271C8B0", Offset = "0x271B8B0", VA = "0x18271C8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class NJBDGNIFCNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NJBDGNIFCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x271B390", Offset = "0x271A390", VA = "0x18271B390")]
		internal object CFPHIIIGDCB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JPEAFBPNMOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public BBKKMMOCLON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private NJBDGNIFCNA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private IDisposable <logFlagsScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private IDisposable <logTraceScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private IDisposable <logRegistryScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private IDisposable <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private GDOIHMDILDL <newRoomInstance>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private LPIFDEEMPOB <customRoomLoadPayload>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private Exception <ex>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JPEAFBPNMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2713660", Offset = "0x2712660", VA = "0x182713660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class OKPCJPJGMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public GDOIHMDILDL newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OKPCJPJGMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x27210A0", Offset = "0x27200A0", VA = "0x1827210A0")]
		internal object PFCNHENMMHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2721060", Offset = "0x2720060", VA = "0x182721060")]
		internal object JJLBPPFGKAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2721020", Offset = "0x2720020", VA = "0x182721020")]
		internal object HHNJFNBLKJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class JLOAFJIGECB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JLOAFJIGECB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x27135C0", Offset = "0x27125C0", VA = "0x1827135C0")]
		internal void BNACHIILJNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class CCHIIMIFGIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public GDOIHMDILDL newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public LPIFDEEMPOB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public BBKKMMOCLON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private OKPCJPJGMGK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private JLOAFJIGECB <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private CancellationToken <token>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private CancellationTokenRegistration <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private object <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private int <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private OperationCanceledException <oce>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CCHIIMIFGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x270EE90", Offset = "0x270DE90", VA = "0x18270EE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static readonly PHIAKNJLBMI.DIACPJFKGAJ KBMAJKOEMJE;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private static readonly HEHEJCDOEDL NFKNDCNKDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private MODHPLENFAK MMHFCCGACDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private GCNGFCNMOLL EACKCFCOOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private HJNEIHJIJJJ IFMMICNCAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private KOBHDJIAOEJ LCFBHAKNLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private NEAAGLADJAL KIKCJCJNLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private long FKJAGEBIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private PNEGEJGEFNB PNIGGEGEFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private bool BOCKODMKCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private Task KCLGNGGCNHK;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private KCMAHJPHMBH CGILCLDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x20DAE40", Offset = "0x20D9E40", VA = "0x1820DAE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool IPNGIMLJFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x90AF40", Offset = "0x909F40", VA = "0x18090AF40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x20DA560", Offset = "0x20D9560", VA = "0x1820DA560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x20DB280", Offset = "0x20DA280", VA = "0x1820DB280", Slot = "4")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x20DA800", Offset = "0x20D9800", VA = "0x1820DA800", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x20DA980", Offset = "0x20D9980", VA = "0x1820DA980")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NNNFNCFEMBK))]
	private Task EEKCKIKOHCI(FHKEOHGPFBE OLJIOFDNKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x20DA570", Offset = "0x20D9570", VA = "0x1820DA570")]
	private void CHKFAMJLAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x20DB530", Offset = "0x20DA530", VA = "0x1820DB530")]
	private void PLFNFKDCNHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x20DAB40", Offset = "0x20D9B40", VA = "0x1820DAB40")]
	private void FENMEILHEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x20DAAC0", Offset = "0x20D9AC0", VA = "0x1820DAAC0")]
	private bool ELEMJEPEMFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x20DAE90", Offset = "0x20D9E90", VA = "0x1820DAE90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JPEAFBPNMOH))]
	private void GMGDJFIFLLL(int OFBBMOFCDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x20DAFC0", Offset = "0x20D9FC0", VA = "0x1820DAFC0")]
	private void JMBPGBLOOMO(out IDisposable NMNKGLNOCAI, out IDisposable LIICBAMDKND, out IDisposable DEKJOPCPECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x20DA710", Offset = "0x20D9710", VA = "0x1820DA710")]
	private bool CJGKFFOOGOB(GDOIHMDILDL LJBLGDDIMIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x20DAF80", Offset = "0x20D9F80", VA = "0x1820DAF80")]
	private void JAHHGMFFKKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x20DACD0", Offset = "0x20D9CD0", VA = "0x1820DACD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CCHIIMIFGIG))]
	private Task GFGBJBIECNB(GDOIHMDILDL LJBLGDDIMIO, LPIFDEEMPOB EECALEFDDBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x20DBB20", Offset = "0x20DAB20", VA = "0x1820DBB20")]
	public BBKKMMOCLON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal sealed class BPLJILFDIJJ : GNNFCDEOEHF, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class PFKBALHBHJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public PFKBALHBHJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2724A00", Offset = "0x2723A00", VA = "0x182724A00")]
		internal object AMOELLPNAAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class KKIEKPNHBHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KKIEKPNHBHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x27147F0", Offset = "0x27137F0", VA = "0x1827147F0")]
		internal object GGFKDFBNFJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private JAEAMIMPOOP JOJGGPKEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private EDCIEFBMDMA ENFILAAAEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private HDMOMFNHLCD BEHEKIFAFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private PLKALHHIPOD ABDLBIKBIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private NMICDGIKKDM KMGIDBOHAKA;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x20E0320", Offset = "0x20DF320", VA = "0x1820E0320", Slot = "6")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x20DF0C0", Offset = "0x20DE0C0", VA = "0x1820DF0C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x20DF3E0", Offset = "0x20DE3E0", VA = "0x1820DF3E0", Slot = "4")]
	public LCJHGCCKGGO HPCLFKCODFA(OCLNBBADIAK ELLBEBCHLPA)
	{
		return default(LCJHGCCKGGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x20E0680", Offset = "0x20DF680", VA = "0x1820E0680", Slot = "5")]
	public void OKNKBPAIKDL(Guid MLHJIHFFCGB, Task LDHHKGCGIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x20E0890", Offset = "0x20DF890", VA = "0x1820E0890")]
	private void OOBIINBABMB(byte NMBDCPKHMGJ, int GDHPFGJBCGA, object PCDAGHLMCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x20DFAC0", Offset = "0x20DEAC0", VA = "0x1820DFAC0")]
	private void INFOEBEJKOI(LODDIGECODM NKPHHCMFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x20E0960", Offset = "0x20DF960", VA = "0x1820E0960")]
	private void PJJBJMIKGMM(LODDIGECODM NKPHHCMFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x20E00D0", Offset = "0x20DF0D0", VA = "0x1820E00D0")]
	private void JPGDCPNJGFD(LODDIGECODM NKPHHCMFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x20DF820", Offset = "0x20DE820", VA = "0x1820DF820")]
	private PEOGNNHCCMJ IGHNDENHAPG(OCLNBBADIAK KGKJNKONAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x20DEC20", Offset = "0x20DDC20", VA = "0x1820DEC20")]
	private void ALCEELCNHHK(OCLNBBADIAK LLOBEFJCJEE, PEOGNNHCCMJ PKKDOKCIBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x20E0490", Offset = "0x20DF490", VA = "0x1820E0490")]
	private bool MHLFMPNMCPC(OCLNBBADIAK LLOBEFJCJEE, PEOGNNHCCMJ PKKDOKCIBNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x20DF160", Offset = "0x20DE160", VA = "0x1820DF160")]
	private bool HJAEADPFEEP(OCLNBBADIAK NHIJHDJOHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x20DEE20", Offset = "0x20DDE20", VA = "0x1820DEE20")]
	private bool BPPDICOMDJN(byte NMBDCPKHMGJ, ExitGames.Client.Photon.Hashtable NKPHHCMFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public BPLJILFDIJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[UnityEngine.Scripting.Preserve]
internal sealed class MEPGMBNDLCA : HDMOMFNHLCD, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class BMHJMIIPNCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public AsyncTaskMethodBuilder<IOANKPJOPII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public MEPGMBNDLCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private IOANKPJOPII <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private TaskAwaiter<IOANKPJOPII> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BMHJMIIPNCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8D10", Offset = "0x3AF7D10", VA = "0x183AF8D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class LLEDIAMDAML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public OCLNBBADIAK message;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LLEDIAMDAML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3B04EB0", Offset = "0x3B03EB0", VA = "0x183B04EB0")]
		internal object GJGMNLOHCPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class IJDNGEPJIKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public OCLNBBADIAK messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IJDNGEPJIKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3B01CE0", Offset = "0x3B00CE0", VA = "0x183B01CE0")]
		internal object CHONOKGIEMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class ADMEPDGDMOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public OCLNBBADIAK request;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ADMEPDGDMOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7F30", Offset = "0x3AF6F30", VA = "0x183AF7F30")]
		internal object JIBKONNGNAF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class BANJDAEHKLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public OCLNBBADIAK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public MEPGMBNDLCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private ADMEPDGDMOO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private HNNFLHMGLEJ <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private HNNFLHMGLEJ <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<HNNFLHMGLEJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BANJDAEHKLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7F90", Offset = "0x3AF6F90", VA = "0x183AF7F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class OIKLCDDNAPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public OCLNBBADIAK operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OIKLCDDNAPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3B07F30", Offset = "0x3B06F30", VA = "0x183B07F30")]
		internal object KIGNFDEFIKN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class OINPGDIOBGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public OCLNBBADIAK operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public MEPGMBNDLCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private OIKLCDDNAPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private DMMCOJOPIJA <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private OCLNBBADIAK <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private HNNFLHMGLEJ <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private OCLNBBADIAK <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<OCLNBBADIAK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OINPGDIOBGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3B08820", Offset = "0x3B07820", VA = "0x183B08820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class ACCIBGPIMOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder<HNNFLHMGLEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public OCLNBBADIAK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public MEPGMBNDLCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private CNPJAGDKOMO.JCPOJNGNOBC <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private DMMCOJOPIJA <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private OCLNBBADIAK <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private OCLNBBADIAK <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private TaskAwaiter<OCLNBBADIAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ACCIBGPIMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7A60", Offset = "0x3AF6A60", VA = "0x183AF7A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class HJBOIGJLBEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public HNNFLHMGLEJ operation;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HJBOIGJLBEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3B00B50", Offset = "0x3AFFB50", VA = "0x183B00B50")]
		internal object PDMPKPBNMHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class LOGBFBAILHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public HNNFLHMGLEJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public MEPGMBNDLCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private HJBOIGJLBEK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private MNKIABAIHBN<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LOGBFBAILHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3B04F10", Offset = "0x3B03F10", VA = "0x183B04F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class KMKKEHDCHPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public OCLNBBADIAK request;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KMKKEHDCHPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3B03FA0", Offset = "0x3B02FA0", VA = "0x183B03FA0")]
		internal object BOLCOIBNOAA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class HPNGAMHCEOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public OCLNBBADIAK request;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HPNGAMHCEOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3B00E70", Offset = "0x3AFFE70", VA = "0x183B00E70")]
		internal object OLOFHKFFNOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private HJIGCIAFGLC BNEICDKJHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private GNNFCDEOEHF FOGELECIHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private ICNMDKOPAPC MAFAKNAOHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private JAEAMIMPOOP JOJGGPKEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private TaskCompletionSource<IOANKPJOPII> HNKIGDOKNBK;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2717F70", Offset = "0x2716F70", VA = "0x182717F70", Slot = "7")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x27175D0", Offset = "0x27165D0", VA = "0x1827175D0", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMHJMIIPNCG))]
	public Task<IOANKPJOPII> DHPCNBDPBFP(CancellationToken MJHMAANKOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2717740", Offset = "0x2716740", VA = "0x182717740", Slot = "4")]
	public void GHFCOMCCCMH(OCLNBBADIAK HJJLMCEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2718050", Offset = "0x2717050", VA = "0x182718050", Slot = "5")]
	public void NELAFJHAJLB(OCLNBBADIAK JGMAGDHEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2718430", Offset = "0x2717430", VA = "0x182718430")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BANJDAEHKLN))]
	private Task PKOJIBBIOHG(OCLNBBADIAK CFOFEENKFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x27170D0", Offset = "0x27160D0", VA = "0x1827170D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OINPGDIOBGB))]
	private Task ABDPKCBAEGH(OCLNBBADIAK LLOBEFJCJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2718580", Offset = "0x2717580", VA = "0x182718580")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ACCIBGPIMOK))]
	private Task<HNNFLHMGLEJ> PLLPLCCHNFC(OCLNBBADIAK CFOFEENKFCN, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2717D80", Offset = "0x2716D80", VA = "0x182717D80")]
	private DMMCOJOPIJA GOKFOILODMP(OCLNBBADIAK KGKJNKONAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2717E00", Offset = "0x2716E00", VA = "0x182717E00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LOGBFBAILHG))]
	private Task IPLNEEDNDOC(HNNFLHMGLEJ KIDKAIDKLIB, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2717B60", Offset = "0x2716B60", VA = "0x182717B60")]
	private HNNFLHMGLEJ GMGIOFLELAE(OCLNBBADIAK CFOFEENKFCN, DMMCOJOPIJA LKFJOKNCJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x257C8C0", Offset = "0x257B8C0", VA = "0x18257C8C0")]
	private T EPDIFJKFPOK<T>(T CKDFGEALFAK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2717220", Offset = "0x2716220", VA = "0x182717220")]
	private HNNFLHMGLEJ DFCFAOONIHG(OCLNBBADIAK CFOFEENKFCN, DMMCOJOPIJA LKFJOKNCJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MEPGMBNDLCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal interface KOBHDJIAOEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TimeSpan DLFCNAEHGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	TimeSpan MKLJMANAPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	TimeSpan FOGFMPCCMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	TimeSpan ENEBDCHBPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool GJEEBJFFCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool IAIHDCFIBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool GLFLCAPGJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool KKFFANDHPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	TimeSpan IJHDGCIGKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int LNBNLBJMCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool LGHPAENKKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal interface DGKOIJANCJM : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CCGGKNOLNJA> LHIAFJDINIC(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, GDOIHMDILDL DIOKIHLDBFF, CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class FPONAKAOKGI : AEOBIOGPCNC
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class MABJPPPGPME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public FPONAKAOKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public Matchmaking.GJMJAGEKLMG result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public GDOIHMDILDL newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MABJPPPGPME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3824D50", Offset = "0x3823D50", VA = "0x183824D50")]
		internal object MOIOLMCPFLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3824EA0", Offset = "0x3823EA0", VA = "0x183824EA0")]
		internal object NIPONABODAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3824CB0", Offset = "0x3823CB0", VA = "0x183824CB0")]
		internal object HPNIHKHIABE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class DBJBLCFAOFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public FPONAKAOKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private MABJPPPGPME <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private Matchmaking.GJMJAGEKLMG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter<Matchmaking.GJMJAGEKLMG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public DBJBLCFAOFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x381B230", Offset = "0x381A230", VA = "0x18381B230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private const float KJHHAFJGBLF = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private readonly DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private readonly HJNEIHJIJJJ IFMMICNCAOG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private KCMAHJPHMBH CGILCLDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x20E8460", Offset = "0x20E7460", VA = "0x1820E8460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xAEDF80", Offset = "0xAECF80", VA = "0x180AEDF80")]
	public FPONAKAOKGI(DICEJLBHJCH FGIILGHEHMH, HJNEIHJIJJJ IFMMICNCAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x20E82F0", Offset = "0x20E72F0", VA = "0x1820E82F0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DBJBLCFAOFP))]
	public Task<bool> DNIEJNCHPFL(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal interface CCIKPIPJGPO : PKPHLOOLONF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal interface AEOBIOGPCNC
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> DNIEJNCHPFL(CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface PAJEDEDNFBK
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKOEALLLALD(CHFCJEGMBJC OMOHGPDOPOA);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMDAHFCBHCO(CHFCJEGMBJC OMOHGPDOPOA);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMJCJAELJAL(CHFCJEGMBJC OMOHGPDOPOA);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLHPOGMFOBJ(CHFCJEGMBJC OMOHGPDOPOA);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class CHFCJEGMBJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public readonly GDOIHMDILDL PJOFFOMMECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private Dictionary<string, string> NCPNNGOLGOL;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MNKIABAIHBN<string> OCDDHAEFNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x913240", Offset = "0x912240", VA = "0x180913240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
	public CHFCJEGMBJC(GDOIHMDILDL PDLFJMNDFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x20E1780", Offset = "0x20E0780", VA = "0x1820E1780")]
	public CHFCJEGMBJC IEIJMJACANJ(string LOHIKDGDMPP, string CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x20E1860", Offset = "0x20E0860", VA = "0x1820E1860")]
	public bool PEINONGIBMM(out IEnumerable<KeyValuePair<string, string>> PNJIJJNAJHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x20E1760", Offset = "0x20E0760", VA = "0x1820E1760")]
	public CHFCJEGMBJC FCKFBPOHBHI(MNKIABAIHBN<string> PPHNMHNDCPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class MJNLPIDNCAE : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x115D670", Offset = "0x115C670", VA = "0x18115D670")]
	public MJNLPIDNCAE(string HJJLMCEMDKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public interface KCMAHJPHMBH
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GDOIHMDILDL HJOOLFCHIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	EAHJJHFFELH NHAIPHEJKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	MEKHHBDIOBK HGDOBMKNHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool CLKOIFPMEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool KBPPIBJLKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	int CHJOCMJOJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action CHKFAMJLAJM;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<int> GMGDJFIFLLL;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MPJDFMHCAPJ();

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.AOEJIFLEEHC> DFMBMDMIJIG(long NECHDOJFBMC, [Optional] CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.GJMJAGEKLMG> OCDBIIOBCEL();

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task PEGKEOMLIJH();

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(GDOIHMDILDL, LPIFDEEMPOB) LGEJDKLDDGD();

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MGFPBFIAOAF OCDELFKNHDP();

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DKDCOFBKALO(long NECHDOJFBMC);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal interface ICNMDKOPAPC : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OCLNBBADIAK> PGDCJNAIGHP(OCLNBBADIAK CFOFEENKFCN, DMMCOJOPIJA LKFJOKNCJPG, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OCLNBBADIAK> IDNLNFHAPGL(CancellationToken OAGBBBCDIGC, DMMCOJOPIJA LKFJOKNCJPG);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HEPJBIGMLHA DEPDKFPGALN(HNNFLHMGLEJ DNNDECNAGEO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HEPJBIGMLHA NPDGLCMOGJJ(HNNFLHMGLEJ DNNDECNAGEO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class MMEJHDMCOOF : DICEJLBHJCH, HIPOKMDFNOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class NAAKKIDMJKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<PEOGNNHCCMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public MCFPGIBLJJO autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public MMEJHDMCOOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private PEOGNNHCCMJ <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private PEOGNNHCCMJ <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter<PEOGNNHCCMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NAAKKIDMJKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3B06650", Offset = "0x3B05650", VA = "0x183B06650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class AAIILGKNEME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public MMEJHDMCOOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private PEOGNNHCCMJ <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AAIILGKNEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7800", Offset = "0x3AF6800", VA = "0x183AF7800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class KNCNFCPKKNI : IEnumerable<PKPHLOOLONF>, IEnumerable, IEnumerator<PKPHLOOLONF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private PKPHLOOLONF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public MMEJHDMCOOF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private PKPHLOOLONF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xC531B0", Offset = "0xC521B0", VA = "0x180C531B0")]
		[DebuggerHidden]
		public KNCNFCPKKNI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3B04000", Offset = "0x3B03000", VA = "0x183B04000", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3B04480", Offset = "0x3B03480", VA = "0x183B04480", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3B043E0", Offset = "0x3B033E0", VA = "0x183B043E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PKPHLOOLONF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3B043E0", Offset = "0x3B033E0", VA = "0x183B043E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private readonly CancellationTokenSource NJNEGMNGLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private readonly CNALHHIKJDD DBGHBAHCJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private bool GPPEICIHMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private JLKEDIMJKLJ MLEKGOMJDMP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public JAEAMIMPOOP DFGGBACJICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x97E5E0", Offset = "0x97D5E0", VA = "0x18097E5E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x977C50", Offset = "0x976C50", VA = "0x180977C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MODHPLENFAK LKMLCMOCHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x97E580", Offset = "0x97D580", VA = "0x18097E580", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x9751F0", Offset = "0x9741F0", VA = "0x1809751F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public HJNEIHJIJJJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x97E720", Offset = "0x97D720", VA = "0x18097E720", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x971FC0", Offset = "0x970FC0", VA = "0x180971FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EDKKLBPKLAF DIHJJHPNMKL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x97E5B0", Offset = "0x97D5B0", VA = "0x18097E5B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9768A0", Offset = "0x9758A0", VA = "0x1809768A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public FHMMJBGMKEF GEKHKHNKBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x992280", Offset = "0x991280", VA = "0x180992280", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x98DE00", Offset = "0x98CE00", VA = "0x18098DE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NDLENNICCHK NIMGDOECAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x9AD4B0", Offset = "0x9AC4B0", VA = "0x1809AD4B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9F66A0", Offset = "0x9F56A0", VA = "0x1809F66A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public KNGIAEBKBLN JAFCCEFBDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9D0", Offset = "0x9AA9D0", VA = "0x1809AB9D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA23920", Offset = "0xA22920", VA = "0x180A23920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public HJIGCIAFGLC IMFEFMLLGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9B3910", Offset = "0x9B2910", VA = "0x1809B3910", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x98E260", Offset = "0x98D260", VA = "0x18098E260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public NFAKBLJLFPN JPIBCBBLKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x9AD920", Offset = "0x9AC920", VA = "0x1809AD920", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA23960", Offset = "0xA22960", VA = "0x180A23960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public KBCIOEDODBM HGJIKPJOIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xAAC140", Offset = "0xAAB140", VA = "0x180AAC140", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xAAC130", Offset = "0xAAB130", VA = "0x180AAC130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public GCNGFCNMOLL CPPELBDIKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x90F2C0", Offset = "0x90E2C0", VA = "0x18090F2C0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x90F0F0", Offset = "0x90E0F0", VA = "0x18090F0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NEAAGLADJAL BCEPPABNCED
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xAA24A0", Offset = "0xAA14A0", VA = "0x180AA24A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xFF6490", Offset = "0xFF5490", VA = "0x180FF6490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public DCGNGBDMJOK DIDAACLLCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA23950", Offset = "0xA22950", VA = "0x180A23950", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA23970", Offset = "0xA22970", VA = "0x180A23970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public PLKALHHIPOD FCINELFLMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x97F530", Offset = "0x97E530", VA = "0x18097F530", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x10E72E0", Offset = "0x10E62E0", VA = "0x1810E72E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public CCIKPIPJGPO CGJOGIPPJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xBC7CF0", Offset = "0xBC6CF0", VA = "0x180BC7CF0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xBC7EA0", Offset = "0xBC6EA0", VA = "0x180BC7EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public HDMOMFNHLCD CFNCPLKILBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x11EC0D0", Offset = "0x11EB0D0", VA = "0x1811EC0D0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1064FC0", Offset = "0x1063FC0", VA = "0x181064FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public GNNFCDEOEHF EGONKFACNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x98E700", Offset = "0x98D700", VA = "0x18098E700", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x864CF0", Offset = "0x863CF0", VA = "0x180864CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public CCFCEDPNOCD KMJPCLNPOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x98D1F0", Offset = "0x98C1F0", VA = "0x18098D1F0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x98CF00", Offset = "0x98BF00", VA = "0x18098CF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public DGKOIJANCJM MIIMBLJFIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x98D1E0", Offset = "0x98C1E0", VA = "0x18098D1E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x98CEF0", Offset = "0x98BEF0", VA = "0x18098CEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public ICNMDKOPAPC MFMCMGHENDE
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6A0", Offset = "0xA1B6A0", VA = "0x180A1C6A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA1DDC0", Offset = "0xA1CDC0", VA = "0x180A1DDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public GFIAEOLPDAA KDENAGHPBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA1D9A0", Offset = "0xA1C9A0", VA = "0x180A1D9A0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xD0E4A0", Offset = "0xD0D4A0", VA = "0x180D0E4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public EDCIEFBMDMA BGJHGBJHNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA1D9B0", Offset = "0xA1C9B0", VA = "0x180A1D9B0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA1E320", Offset = "0xA1D320", VA = "0x180A1E320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public PAJEDEDNFBK CAJLBNPAPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xACA1B0", Offset = "0xAC91B0", VA = "0x180ACA1B0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xF32A80", Offset = "0xF31A80", VA = "0x180F32A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public NMICDGIKKDM EHDGAAODNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9F31B0", Offset = "0x9F21B0", VA = "0x1809F31B0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xBC6FD0", Offset = "0xBC5FD0", VA = "0x180BC6FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public JLPMGBNKLLC MDGKMAHFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xF33E10", Offset = "0xF32E10", VA = "0x180F33E10", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xBC0C90", Offset = "0xBBFC90", VA = "0x180BC0C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public KOBHDJIAOEJ MBHLDAHAOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x10537C0", Offset = "0x10527C0", VA = "0x1810537C0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x104F8D0", Offset = "0x104E8D0", VA = "0x18104F8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public OPAOFOHKJBL FNDCDBMNKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9F3240", Offset = "0x9F2240", VA = "0x1809F3240", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9EEBE0", Offset = "0x9EDBE0", VA = "0x1809EEBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public GOGKAJFDJAH EJMFAHPBGHE
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2F60", Offset = "0x9F1F60", VA = "0x1809F2F60", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public IEFGNBGNHNN AKFCIIONJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x980ED0", Offset = "0x97FED0", VA = "0x180980ED0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public CGIEFEIKFEN MCFJFBKFKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x101CAC0", Offset = "0x101BAC0", VA = "0x18101CAC0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public LPIFDEEMPOB JFDAOMKHGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x97F2E0", Offset = "0x97E2E0", VA = "0x18097F2E0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9751E0", Offset = "0x9741E0", VA = "0x1809751E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private bool LFDFMMPOEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x27190D0", Offset = "0x27180D0", VA = "0x1827190D0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private bool EHDCOABDCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x27197E0", Offset = "0x27187E0", VA = "0x1827197E0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Task GDHBCMJPOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2719390", Offset = "0x2718390", VA = "0x182719390", Slot = "49")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private CancellationToken DDJNEENBBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2719200", Offset = "0x2718200", VA = "0x182719200", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private CNALHHIKJDD OOBPPHLNKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action BIOLLMMBPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2719070", Offset = "0x2718070", VA = "0x182719070", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2718C80", Offset = "0x2717C80", VA = "0x182718C80", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event KHGHBNJHLDD NHFCJPMEEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x27195E0", Offset = "0x27185E0", VA = "0x1827195E0", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2718C20", Offset = "0x2717C20", VA = "0x182718C20", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event KHGHBNJHLDD PBMIMEEJGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x27191A0", Offset = "0x27181A0", VA = "0x1827191A0", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x27196A0", Offset = "0x27186A0", VA = "0x1827196A0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event KHGHBNJHLDD HONIOMJEODL
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2719640", Offset = "0x2718640", VA = "0x182719640", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x27193E0", Offset = "0x27183E0", VA = "0x1827193E0", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<NOBDFJFKCAB, bool> DHBLGAKBNGB
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2719010", Offset = "0x2718010", VA = "0x182719010", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2719700", Offset = "0x2718700", VA = "0x182719700", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x9751E0", Offset = "0x9741E0", VA = "0x1809751E0", Slot = "36")]
	public void JNAKNNNBHDA(LPIFDEEMPOB HLJAMDMPAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2719860", Offset = "0x2718860", VA = "0x182719860")]
	[UnityEngine.Scripting.Preserve]
	internal MMEJHDMCOOF([JFLEHDEIONF(null)] CNALHHIKJDD DBGHBAHCJKO, [JFLEHDEIONF(null)] JAEAMIMPOOP JOJGGPKEEEH, [JFLEHDEIONF(null)] MODHPLENFAK MMHFCCGACDC, [JFLEHDEIONF(null)] HJNEIHJIJJJ IFMMICNCAOG, [JFLEHDEIONF(null)] EDKKLBPKLAF NEBHKKFGKJG, [JFLEHDEIONF(null)] FHMMJBGMKEF FCOBMCBCEBH, [JFLEHDEIONF(null)] NDLENNICCHK KMPGOOMEOMI, [JFLEHDEIONF(null)] KNGIAEBKBLN NEHHPMGHOON, [JFLEHDEIONF(null)] HJIGCIAFGLC BNEICDKJHGH, [JFLEHDEIONF(null)] NFAKBLJLFPN LJPLHAIDKEB, [JFLEHDEIONF(null)] KBCIOEDODBM CDMKNNGLNND, [JFLEHDEIONF(null)] GCNGFCNMOLL EACKCFCOOFB, [JFLEHDEIONF(null)] NEAAGLADJAL KIKCJCJNLOF, [JFLEHDEIONF(null)] DCGNGBDMJOK MBLGJAFGPEN, [JFLEHDEIONF(null)] PLKALHHIPOD ABDLBIKBIJK, [JFLEHDEIONF(null)] CCIKPIPJGPO NKNHOIADJOC, [JFLEHDEIONF(null)] HDMOMFNHLCD BEHEKIFAFCN, [JFLEHDEIONF(null)] GNNFCDEOEHF FOGELECIHMG, [JFLEHDEIONF(null)] CCFCEDPNOCD IKGLDDEEJDN, [JFLEHDEIONF(null)] DGKOIJANCJM PCHEOGBBACN, [JFLEHDEIONF(null)] GFIAEOLPDAA BBHIMDJDOOK, [JFLEHDEIONF(null)] ICNMDKOPAPC MAFAKNAOHHM, [JFLEHDEIONF(null)] EDCIEFBMDMA ENFILAAAEBG, [JFLEHDEIONF(null)] PAJEDEDNFBK HHPBHKNCDCN, [JFLEHDEIONF(null)] NMICDGIKKDM KMGIDBOHAKA, [JFLEHDEIONF(null)] KOBHDJIAOEJ LCFBHAKNLEG, [JFLEHDEIONF(null)] OPAOFOHKJBL LAOKMGOICOC, [JFLEHDEIONF(null)] GOGKAJFDJAH BKJKPCKLCNC, [JFLEHDEIONF(null)] IEFGNBGNHNN JAEKGMHHFDF, [JFLEHDEIONF(null)] CGIEFEIKFEN LDOPCKOMICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x27194F0", Offset = "0x27184F0", VA = "0x1827194F0")]
	private void LLEBBJIFEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2718D30", Offset = "0x2717D30", VA = "0x182718D30", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2718CE0", Offset = "0x2717CE0", VA = "0x182718CE0", Slot = "50")]
	private void CFCMKMKPDFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2718BA0", Offset = "0x2717BA0", VA = "0x182718BA0", Slot = "51")]
	private IEELIAJJJHO AEGFOHHJMPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2719760", Offset = "0x2718760", VA = "0x182719760", Slot = "52")]
	private HFHJABDNILK OIJKIBNGJBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2719220", Offset = "0x2718220", VA = "0x182719220", Slot = "53")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NAAKKIDMJKI))]
	private Task<PEOGNNHCCMJ> JELCNPNFBGK(MCFPGIBLJJO NLDFIJLPMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x2718EC0", Offset = "0x2717EC0", VA = "0x182718EC0", Slot = "54")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AAIILGKNEME))]
	private Task EDAEEANBHBB(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2719130", Offset = "0x2718130", VA = "0x182719130")]
	[IteratorStateMachine(typeof(KNCNFCPKKNI))]
	private IEnumerable<PKPHLOOLONF> GPEANNCGGEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x2719440", Offset = "0x2718440", VA = "0x182719440")]
	[CompilerGenerated]
	private void LEAFBOCKPDC(PKPHLOOLONF GDOIACLJEDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class COMFAGBFFGA : DGKOIJANCJM, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class NJIEJHGHOGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<CCGGKNOLNJA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public GDOIHMDILDL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public COMFAGBFFGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private EAHJJHFFELH <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private EAHJJHFFELH <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<EAHJJHFFELH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NJIEJHGHOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x271B400", Offset = "0x271A400", VA = "0x18271B400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class BFIPEFMLKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BFIPEFMLKDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x270DEB0", Offset = "0x270CEB0", VA = "0x18270DEB0")]
		internal object NNNKJDHBGDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class IGCAKIFOGLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public AsyncTaskMethodBuilder<EAHJJHFFELH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public GDOIHMDILDL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public COMFAGBFFGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private BFIPEFMLKDK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private EAHJJHFFELH <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<EAHJJHFFELH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IGCAKIFOGLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2712630", Offset = "0x2711630", VA = "0x182712630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class EIPOMKOPJIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public EIPOMKOPJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xCAB4C0", Offset = "0xCAA4C0", VA = "0x180CAB4C0")]
		internal bool NINOPJNONMD(MEKHHBDIOBK sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private HJNEIHJIJJJ IFMMICNCAOG;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private static readonly (PLLPALDIOHF superRoomData, long subRoomDataSaveId) GJMGPHEEAAD;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x20E3160", Offset = "0x20E2160", VA = "0x1820E3160", Slot = "5")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x20E2FA0", Offset = "0x20E1FA0", VA = "0x1820E2FA0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NJIEJHGHOGD))]
	public Task<CCGGKNOLNJA> LHIAFJDINIC(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, GDOIHMDILDL DIOKIHLDBFF, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x20E2910", Offset = "0x20E1910", VA = "0x1820E2910")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IGCAKIFOGLP))]
	private Task<EAHJJHFFELH> FMBCLJJHDKO(GDOIHMDILDL DIOKIHLDBFF, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x20E2E60", Offset = "0x20E1E60", VA = "0x1820E2E60")]
	private CCGGKNOLNJA JMENKJCOJLC(GDOIHMDILDL DIOKIHLDBFF, EAHJJHFFELH PCNPBCBLELJ, long FKNCEBBDENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x20E2AD0", Offset = "0x20E1AD0", VA = "0x1820E2AD0")]
	private (PLLPALDIOHF, long) IHJHGNJLPPF(GDOIHMDILDL DIOKIHLDBFF, EAHJJHFFELH PCNPBCBLELJ, long FKNCEBBDENC)
	{
		return default((PLLPALDIOHF, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public COMFAGBFFGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface EDKKLBPKLAF
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool ILKEDOPGDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	string DCIFBFOMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLBPDCILPGA(Scene JHLFELLADIN);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BEALFEDKLIP(MDCFFKCLDEA MHOPDDCPBJO, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PNKGEMEGFLJ();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[UnityEngine.Scripting.Preserve]
internal sealed class KKBLKGDOKEG : ICNMDKOPAPC, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class JMCLHOOJJCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public OCLNBBADIAK request;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JMCLHOOJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x3B03AC0", Offset = "0x3B02AC0", VA = "0x183B03AC0")]
		internal object CPGDHDKHPFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class GOODAHFHOIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AsyncTaskMethodBuilder<OCLNBBADIAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public OCLNBBADIAK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public DMMCOJOPIJA pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public KKBLKGDOKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private JMCLHOOJJCD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private OCLNBBADIAK <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private OCLNBBADIAK <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter<OCLNBBADIAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GOODAHFHOIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFFD0", Offset = "0x3AFEFD0", VA = "0x183AFFFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class GKHCMMDOKMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder<OCLNBBADIAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public DMMCOJOPIJA pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public KKBLKGDOKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private GEMMKFJNFAA.FDLLAOGMAKD<OCLNBBADIAK> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private AJMLCIGCEML <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter<AJMLCIGCEML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GKHCMMDOKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEF90", Offset = "0x3AFDF90", VA = "0x183AFEF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class OBDBINCDGAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public OCLNBBADIAK request;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OBDBINCDGAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3B07E70", Offset = "0x3B06E70", VA = "0x183B07E70")]
		internal object CBOBHELHKEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class FHLLHPCPDEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public AsyncTaskMethodBuilder<OCLNBBADIAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public OCLNBBADIAK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public DMMCOJOPIJA pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public KKBLKGDOKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private OBDBINCDGAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private HKGOHLMLBJL <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private PJOLMLPLLHA <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private GEMMKFJNFAA.FDLLAOGMAKD<OCLNBBADIAK> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private OCLNBBADIAK <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private HKGOHLMLBJL <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private AJMLCIGCEML <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private TaskAwaiter<AJMLCIGCEML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public FHLLHPCPDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x3AFCE90", Offset = "0x3AFBE90", VA = "0x183AFCE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private JAEAMIMPOOP JOJGGPKEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private JLPMGBNKLLC BGJJDGLMGAC;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private GEMMKFJNFAA JDKGJBKDGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x20F4000", Offset = "0x20F3000", VA = "0x1820F4000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x20F3B30", Offset = "0x20F2B30", VA = "0x1820F3B30", Slot = "8")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x20F40B0", Offset = "0x20F30B0", VA = "0x1820F40B0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GOODAHFHOIO))]
	public Task<OCLNBBADIAK> PGDCJNAIGHP(OCLNBBADIAK CFOFEENKFCN, DMMCOJOPIJA LKFJOKNCJPG, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x20F3990", Offset = "0x20F2990", VA = "0x1820F3990", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GKHCMMDOKMH))]
	public Task<OCLNBBADIAK> IDNLNFHAPGL(CancellationToken OAGBBBCDIGC, DMMCOJOPIJA LKFJOKNCJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x20F3700", Offset = "0x20F2700", VA = "0x1820F3700", Slot = "6")]
	public HEPJBIGMLHA DEPDKFPGALN(HNNFLHMGLEJ DNNDECNAGEO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x20F3BC0", Offset = "0x20F2BC0", VA = "0x1820F3BC0", Slot = "7")]
	public HEPJBIGMLHA NPDGLCMOGJJ(HNNFLHMGLEJ DNNDECNAGEO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x20F3E40", Offset = "0x20F2E40", VA = "0x1820F3E40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FHLLHPCPDEO))]
	private Task<OCLNBBADIAK> OPLMCJKGHFL(OCLNBBADIAK CFOFEENKFCN, DMMCOJOPIJA LKFJOKNCJPG, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x20F3980", Offset = "0x20F2980", VA = "0x1820F3980")]
	private static byte[] DPDJDJECBBC(OCLNBBADIAK HJJLMCEMDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x20F3550", Offset = "0x20F2550", VA = "0x1820F3550")]
	private static string ANFBFFNBOIG(byte[] IELOEMGHLEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public KKBLKGDOKEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public readonly struct DEHFNCCELNE<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class PEIGHJEEOBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AsyncTaskMethodBuilder<EEONHCOMEMH<KDFENHBNPBD<TData>, JINHIJEHMKF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public DEHFNCCELNE<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private EEONHCOMEMH<byte[], JINHIJEHMKF> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private EEONHCOMEMH<byte[], JINHIJEHMKF> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private TaskAwaiter<EEONHCOMEMH<byte[], JINHIJEHMKF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public PEIGHJEEOBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A94050", Offset = "0x2A93050", VA = "0x182A94050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private readonly OAKPMPALGKI<TGetDataArg, TData> KBILNMMJIAF;

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xA2BF10", Offset = "0xA2AF10", VA = "0x180A2BF10")]
	internal DEHFNCCELNE(OAKPMPALGKI<TGetDataArg, TData> OCBMLBBNJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2A02170", Offset = "0x2A01170", VA = "0x182A02170")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DEHFNCCELNE<, >.PEIGHJEEOBJ))]
	public Task<EEONHCOMEMH<KDFENHBNPBD<TData>, JINHIJEHMKF>> PJEMGHNLINN(TGetDataArg IELOEMGHLEA, string KOIONNCBCDP, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class EAJAFHBEEAJ
{
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1076A60", Offset = "0x1075A60", VA = "0x181076A60")]
	public static DEHFNCCELNE<TGetDataArg, TData> DAABCIFNKOF<TGetDataArg, TData>(OAKPMPALGKI<TGetDataArg, TData> OCBMLBBNJOG)
	{
		return default(DEHFNCCELNE<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[UnityEngine.Scripting.Preserve]
internal sealed class BNFFPNCJAML : CCFCEDPNOCD, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class OFLEMDPDDIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public IOANKPJOPII operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public BNFFPNCJAML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public OCLNBBADIAK roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OFLEMDPDDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x271F730", Offset = "0x271E730", VA = "0x18271F730")]
		internal object KDFNEPGAAND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x271F600", Offset = "0x271E600", VA = "0x18271F600")]
		internal object KDBFJJANMCB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class EGDDLOJEDPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<PEOGNNHCCMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public OCLNBBADIAK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public BNFFPNCJAML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private OFLEMDPDDIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private PEOGNNHCCMJ <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private PEOGNNHCCMJ <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<PEOGNNHCCMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public EGDDLOJEDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x2711140", Offset = "0x2710140", VA = "0x182711140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class HAOABAAIIDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IOANKPJOPII operationType;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HAOABAAIIDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x27124C0", Offset = "0x27114C0", VA = "0x1827124C0")]
		internal object MFGGGJMELFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class DFDHAEPMPAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public OCLNBBADIAK request;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public DFDHAEPMPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x27108C0", Offset = "0x270F8C0", VA = "0x1827108C0")]
		internal object PJMDCDGNKCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2710840", Offset = "0x270F840", VA = "0x182710840")]
		internal object GHBIBPALIHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x27107C0", Offset = "0x270F7C0", VA = "0x1827107C0")]
		internal object ALPMKLDNGFA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class LAKFKCKAHEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder<PEOGNNHCCMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public OCLNBBADIAK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public BNFFPNCJAML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private DFDHAEPMPAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private LCJHGCCKGGO <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private PEOGNNHCCMJ <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private (PEOGNNHCCMJ validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private (PEOGNNHCCMJ validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private TaskAwaiter<(PEOGNNHCCMJ validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LAKFKCKAHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2715490", Offset = "0x2714490", VA = "0x182715490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private JAEAMIMPOOP JOJGGPKEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private EDCIEFBMDMA ENFILAAAEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private GNNFCDEOEHF FOGELECIHMG;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x20DE970", Offset = "0x20DD970", VA = "0x1820DE970", Slot = "5")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x20DE800", Offset = "0x20DD800", VA = "0x1820DE800", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EGDDLOJEDPP))]
	private Task<PEOGNNHCCMJ> GPDJOMNKHCF(OCLNBBADIAK KGKJNKONAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x20DEA20", Offset = "0x20DDA20", VA = "0x1820DEA20")]
	private bool NOJJFABLIGI(IOANKPJOPII BEAPEJKINEL, out PEOGNNHCCMJ ALIHEMGMHCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x20DE690", Offset = "0x20DD690", VA = "0x1820DE690")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LAKFKCKAHEI))]
	private Task<PEOGNNHCCMJ> BJAAAHCBPIG(OCLNBBADIAK CFOFEENKFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public BNFFPNCJAML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class NCHOOHKOEBO
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public static PEOGNNHCCMJ DCBKCPJIKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x271A960", Offset = "0x2719960", VA = "0x18271A960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x271A8C0", Offset = "0x27198C0", VA = "0x18271A8C0")]
	public static bool IOBAPDLPKKK(this PEOGNNHCCMJ PKKDOKCIBNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x271A8F0", Offset = "0x27198F0", VA = "0x18271A8F0")]
	public static PEOGNNHCCMJ MCOAOGNGLNO(JPFABOLLDCA PPIDGDFKOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x271A690", Offset = "0x2719690", VA = "0x18271A690")]
	public static PEOGNNHCCMJ DDBOLGNBMIF(params PEOGNNHCCMJ[] HNNAJPMGJDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x271A6A0", Offset = "0x27196A0", VA = "0x18271A6A0")]
	public static PEOGNNHCCMJ HAKLHHHKELG(IEnumerable<PEOGNNHCCMJ> HNNAJPMGJDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x271A3E0", Offset = "0x27193E0", VA = "0x18271A3E0")]
	public static string CGNKNGADIKD(this PEOGNNHCCMJ ALIHEMGMHCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[UnityEngine.Scripting.Preserve]
internal sealed class BAALBMAFELM : EDCIEFBMDMA, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private FHMMJBGMKEF FCOBMCBCEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private JAEAMIMPOOP JOJGGPKEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private HJIGCIAFGLC BNEICDKJHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private GFIAEOLPDAA BBHIMDJDOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private HJNEIHJIJJJ IFMMICNCAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private NEAAGLADJAL KIKCJCJNLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private DCGNGBDMJOK MBLGJAFGPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private KOBHDJIAOEJ LCFBHAKNLEG;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private KCMAHJPHMBH CGILCLDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x20DA000", Offset = "0x20D9000", VA = "0x1820DA000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private static PEOGNNHCCMJ DCBKCPJIKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x20DA3C0", Offset = "0x20D93C0", VA = "0x1820DA3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x20DA250", Offset = "0x20D9250", VA = "0x1820DA250", Slot = "7")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x20DA3D0", Offset = "0x20D93D0", VA = "0x1820DA3D0", Slot = "4")]
	public PEOGNNHCCMJ PFOCDGNMLAM(PIPFLAHHDDO CIAMEHCABFJ, IOANKPJOPII FHNGDKCLEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x20D9D70", Offset = "0x20D8D70", VA = "0x1820D9D70", Slot = "5")]
	public PEOGNNHCCMJ DJBGDIMMPBI(PIPFLAHHDDO KMJAMONBHPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x20DA050", Offset = "0x20D9050", VA = "0x1820DA050", Slot = "6")]
	public PEOGNNHCCMJ LBELIJNCGGJ(PIPFLAHHDDO KMJAMONBHPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x20DA3B0", Offset = "0x20D93B0", VA = "0x1820DA3B0")]
	private static PEOGNNHCCMJ MCOAOGNGLNO(JPFABOLLDCA HDCMCPPKAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public BAALBMAFELM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public delegate Task DAIHOFLBDLA(OFIMLBDMAME CAPINCBBCIM, CancellationToken FFKJLIDBALM);
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal interface DCGNGBDMJOK : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool NFDGBGCCMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JFMMIKJPPGN(DAIHOFLBDLA FMNGADFCCLD);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface NMICDGIKKDM
{
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGOCPLIDJDD(out IEnumerable<int> NMPOFLLFJPC);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FOKAEPNPKFK(DPLHGKBKOHE FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACCLHBIEAIJ(DPLHGKBKOHE FFKJLIDBALM);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface OGPAEANLDLA
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LAGKEKMAGAG(PEOGNNHCCMJ PKKDOKCIBNA);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal interface CCFCEDPNOCD : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PEOGNNHCCMJ> KMJPCLNPOJB(OCLNBBADIAK KGKJNKONAMF);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal interface DICEJLBHJCH : HIPOKMDFNOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	CancellationToken EIOCNFHLEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	CNALHHIKJDD INJAIJFENAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	JAEAMIMPOOP DFGGBACJICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	MODHPLENFAK LKMLCMOCHCB
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	HJNEIHJIJJJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	EDKKLBPKLAF DIHJJHPNMKL
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	FHMMJBGMKEF GEKHKHNKBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	NDLENNICCHK NIMGDOECAFP
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	KNGIAEBKBLN JAFCCEFBDEK
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	HJIGCIAFGLC IMFEFMLLGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	NFAKBLJLFPN JPIBCBBLKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	KBCIOEDODBM HGJIKPJOIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	GCNGFCNMOLL CPPELBDIKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	NEAAGLADJAL BCEPPABNCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	DCGNGBDMJOK DIDAACLLCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	PLKALHHIPOD FCINELFLMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	CCIKPIPJGPO CGJOGIPPJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	HDMOMFNHLCD CFNCPLKILBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	GNNFCDEOEHF EGONKFACNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	CCFCEDPNOCD KMJPCLNPOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	DGKOIJANCJM MIIMBLJFIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	ICNMDKOPAPC MFMCMGHENDE
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	GFIAEOLPDAA KDENAGHPBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	EDCIEFBMDMA BGJHGBJHNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	PAJEDEDNFBK CAJLBNPAPBB
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	NMICDGIKKDM EHDGAAODNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	JLPMGBNKLLC MDGKMAHFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	KOBHDJIAOEJ MBHLDAHAOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	OPAOFOHKJBL FNDCDBMNKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	GOGKAJFDJAH EJMFAHPBGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	IEFGNBGNHNN AKFCIIONJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	CGIEFEIKFEN MCFJFBKFKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void JNAKNNNBHDA(LPIFDEEMPOB HLJAMDMPAJH);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal interface GCNGFCNMOLL : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PPFODPANPOO();

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCCLJDHLHHO();

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKHNCGFKDLF();
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class GHBKEDMCIID
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x20E8A00", Offset = "0x20E7A00", VA = "0x1820E8A00")]
	public static void ONFILLAIDGD(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x20E8C00", Offset = "0x20E7C00", VA = "0x1820E8C00")]
	internal static void ONKCDHHKFLB(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x20E8920", Offset = "0x20E7920", VA = "0x1820E8920")]
	internal static void GICHEKHPOFK(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x20E8D20", Offset = "0x20E7D20", VA = "0x1820E8D20")]
	internal static void PPANNBCIDHN(CNALHHIKJDD DBGHBAHCJKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class MLEPEOMIKDG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2718B60", Offset = "0x2717B60", VA = "0x182718B60")]
	public MLEPEOMIKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0xDD5450", Offset = "0xDD4450", VA = "0x180DD5450")]
	public MLEPEOMIKDG(string HJJLMCEMDKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal interface PKPHLOOLONF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface HJNEIHJIJJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	KCMAHJPHMBH CGILCLDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	int CHJOCMJOJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	bool JALGBLAJELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool DJKGFGEKNFP
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	bool KFAOBBHELAP
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool CJEGPOANDLF
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PIPFLAHHDDO KBJDFGPGPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool DCLINFNMKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool EAHIPLFEFDL
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	float NJJILADDKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event Action<float> HGNJNICEJMG;

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CNALHHIKJDD DAPHEJPCFDL(CNALHHIKJDD EFFGMOEDBAB);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OHCAHGFINOF(CNALHHIKJDD DBGHBAHCJKO);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DFKNDEJDFDO();

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task ONMPNKFCEEK(MNKIABAIHBN<string>.JJAEKMMDGKH OAMIINOCKPC, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JEIBCJLNOPB(float JNFEJCONLCL);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PFADECJHKDC(string MHDPLHDMGFC);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IReadOnlyList<JMCCIKOGHMP> MMKOGOJPMEG();

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDisposable DLGPINAIJDD(object AEOEKGNDHFM, JMCCIKOGHMP BFNKDBHNAAE);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EOMDDKFOOGO ONMMFNHFHPM(IEnumerable<NEMHKEECLGO> NEEAIBMMKKA);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AOKFHBODEFG(int HDPMPABFMFH);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task ONIDEEOCNNB();

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EKAKKBBPHPF();

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool DNECPEKKOJP();

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task GHMDBMKKEPN(CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task KKLIGIBLCMA(CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<GMMGNMCOLCN> HJHAPPGDAIL(DateTime GLJLJJPPFDN, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> FBFONKHDPBC(CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BGMKOFHMHIK(string HIDGLCJGGDE = "", float PNCIGIECCCP = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "23")]
	LLMHCANKMFI KCDGKKJKBAK(DHDFPEDJJBO AHLGOBEDBND, CAMHKKGEKKA JDCEJMEBGBH, OCMKINIOLDE AHGOBAJBCFJ, IEnumerable<PersistenceView> OOGMCHDKBFJ, DGIFJGGKCPG EINJEFOEKPE);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DBBFGJOONBI(OCMKINIOLDE AHGOBAJBCFJ);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void ICCHOEMPDJN(NEMHKEECLGO KOBLBILBKMA, in LLMHCANKMFI NGJHIEDBEAD);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task HPPFOOHCMNE(OCMKINIOLDE ELKCKIIFBGF, bool BGJAPJGNABD, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task COMHOIHGOEC(CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EOANCAEDDHB(long IHGIEILPMCA, long BPCDOJMJPPI, EAHJJHFFELH IMNFFHILDHL, ONCPNDKMCDI DOEHNLGHDNF, JNMBCFANFLA KOBJHMANLPK, NNMKFKJCKPG? BBAPKHEMNJB, DBGEFAOHMNO? IOHNLEDHCKP);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OOPHGJKEIAL(long IHGIEILPMCA, long BPCDOJMJPPI, DBGEFAOHMNO? IOHNLEDHCKP);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BGGJIMOOPKI(PersistenceView LDJFFICGDBN);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool DJHEHLFKBPK(PersistenceView ILDIOIFMEIG);

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool CHJPEJDMPBG(NEMHKEECLGO KOBLBILBKMA, FEALJIILFCB HCOPAHKCNLP, out FLMOHKGBJCK DLEGNLLLDNA);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task ADHOKNONKPI(CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void EDOONPCPLCC();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable IPJKIHJMEMN();

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EFHGFDMFHKK(OCMKINIOLDE ELKCKIIFBGF, FEALJIILFCB HCOPAHKCNLP);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> EBJGOLLMIMF(JAEAMIMPOOP JOJGGPKEEEH, CancellationToken OAGBBBCDIGC, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void ABCDFBNGFKB(CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<CEIPMKNCAPB> MGEFOAAAIOI(HOLMKEDHIPM CFOFEENKFCN);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<EAHJJHFFELH> PCLGIKCJGEH(long IHGIEILPMCA, bool DKCIHIIFJGN, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<ONCPNDKMCDI> AFIEDLBFMHH(long IHGIEILPMCA, long BPCDOJMJPPI, long EOFGLMIFIFP, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<GKJCOLDBOLN> MDICKDKAMNE(string NELEGDAMKMM, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<GKJCOLDBOLN> GMMAHJDAIAE(string NELEGDAMKMM, long IHGIEILPMCA, long BPCDOJMJPPI, string BJIEMONJOEI, JPBPCLMJCAC.PKBKNMHBMJE CAPINCBBCIM, JPBPCLMJCAC.PKBKNMHBMJE NEHMEKKOIFN, int FBPHLCMNECO);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool PIHKJMCOGBG();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool NOPAAAHFLGA();

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool ILNDHOGJCKM(IEnumerable<FLMOHKGBJCK> LFHMJMHLBNO);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CKBMJFFHPPH(List<GameObject> GONKKHMJMDB);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float CGFGMONICML();

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool KOJKFMNKDPB(string GHHMMCBLDBH, out Scene DONBOKOKLIL);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> EJFFLJOEMLI(string GHHMMCBLDBH, LoadSceneMode LHDPOOBNHII, bool DJNKLPFFCKF, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void KJLDDCBEJNA();

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool NCGJNEGOMCH(ByteString PDFBAGGMCIA);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void OJEGOGAEFAH(bool DDHDBPLDGLB);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "58")]
	Task ABDKJNIDKAG();

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task EHIJKGNHBFK();

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void NGFKPAIHAJA();

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void PEFAINBKDMO();

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void FBOHOHAPBLD(GDOIHMDILDL LJBLGDDIMIO);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "66")]
	Task LGPJKOAILEC(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "67")]
	Task FCDJBBKKKJJ(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task LCFBKJPIJNP(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void CCBPEGCFNOP();

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "70")]
	IDisposable KMLJLFKDCCO();

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "71")]
	MHPHGODLEFI HCNKGIGACGN();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task NNJJIMCNDFO(CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public interface MHPHGODLEFI
{
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KGCCOOBEHFA(CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FGCAKFALFOA(CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct LLMHCANKMFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public HashSet<int> MOENMHKJFOL;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum GMMGNMCOLCN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct DHDFPEDJJBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public bool AJJCFDIGBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public string AJELINHJFGD;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class JFDOCMDBLLD
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class LKGDAEKCMBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public MNKIABAIHBN<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LKGDAEKCMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x3823EE0", Offset = "0x3822EE0", VA = "0x183823EE0")]
		internal object LPHCAAAKDKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public const string GKGMALOENLL = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public const string EDNMOLKJPED = "END: ";

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x20EE8E0", Offset = "0x20ED8E0", VA = "0x1820EE8E0")]
	public static MNKIABAIHBN<string> ADPPFDCLAAH([Optional] string MBNDFLFKJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x20EE800", Offset = "0x20ED800", VA = "0x1820EE800")]
	public static MNKIABAIHBN<string> ADPPFDCLAAH(HPPHLHFLMDP CGJPMMKJEHF, [Optional] string MBNDFLFKJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x20EEAF0", Offset = "0x20EDAF0", VA = "0x1820EEAF0")]
	private static void JNNNDKPFCDL(string LOHIKDGDMPP, MNKIABAIHBN<string>.NAPCOPMAIGI PPHNMHNDCPA, HPPHLHFLMDP CGJPMMKJEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x20EEC20", Offset = "0x20EDC20", VA = "0x1820EEC20")]
	private static void LKEFIKIEPAK(string LOHIKDGDMPP, MNKIABAIHBN<string>.NAPCOPMAIGI PPHNMHNDCPA, HPPHLHFLMDP CGJPMMKJEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x20EEB50", Offset = "0x20EDB50", VA = "0x1820EEB50")]
	public static void KGJGKKAAACG(MNKIABAIHBN<string> PPHNMHNDCPA, HPPHLHFLMDP CGJPMMKJEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x20EEA10", Offset = "0x20EDA10", VA = "0x1820EEA10")]
	public static string DFCFPFNDMHN(OCLNBBADIAK KGKJNKONAMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[UnityEngine.Scripting.Preserve]
internal class OLELLBEKKOH : DCGNGBDMJOK, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class OAGLIIOEFAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public OFIMLBDMAME roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public OLELLBEKKOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private Func<CancellationToken, List<Task>> <taskGenerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OAGLIIOEFAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x4EB32D0", Offset = "0x4EB22D0", VA = "0x184EB32D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class PALHFCLDKDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public OLELLBEKKOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public OFIMLBDMAME roomData;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public PALHFCLDKDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4BE0", Offset = "0x4EB3BE0", VA = "0x184EB4BE0")]
		internal List<Task> DJNGGCPEPHL(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class GJOOLCJBFIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public DAIHOFLBDLA taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public OLELLBEKKOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GJOOLCJBFIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF6A0", Offset = "0x4EAE6A0", VA = "0x184EAF6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class GFDEDDONMCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public OLELLBEKKOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GFDEDDONMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF420", Offset = "0x4EAE420", VA = "0x184EAF420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private readonly HashSet<DAIHOFLBDLA> BAMOEOJCBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private MODHPLENFAK MMHFCCGACDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private JMCCIKOGHMP LDOKJCFDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private KKEEEEIJOJM JNKKOPKNPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private IDisposable KGAAGLCPIDJ;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool NFDGBGCCMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x2721140", Offset = "0x2720140", VA = "0x182721140", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal Task GMCDBNHDALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x2721AD0", Offset = "0x2720AD0", VA = "0x182721AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2721F80", Offset = "0x2720F80", VA = "0x182721F80", Slot = "6")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2721150", Offset = "0x2720150", VA = "0x182721150", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2721C30", Offset = "0x2720C30", VA = "0x182721C30", Slot = "5")]
	public bool JFMMIKJPPGN(DAIHOFLBDLA FMNGADFCCLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2721AE0", Offset = "0x2720AE0", VA = "0x182721AE0")]
	private void IBFGJBDLJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x27217F0", Offset = "0x27207F0", VA = "0x1827217F0")]
	private void GFBGICJPLLK(OFIMLBDMAME CAPINCBBCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2721E30", Offset = "0x2720E30", VA = "0x182721E30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OAGLIIOEFAL))]
	private Task LJAJHPFLPOA(OFIMLBDMAME CAPINCBBCIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2722250", Offset = "0x2721250", VA = "0x182722250")]
	private Func<CancellationToken, List<Task>> NICOLOIAMBM(OFIMLBDMAME CAPINCBBCIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x27211B0", Offset = "0x27201B0", VA = "0x1827211B0")]
	private List<Task> EEOKAMHCPBO(OFIMLBDMAME CAPINCBBCIM, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2721C90", Offset = "0x2720C90", VA = "0x182721C90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GJOOLCJBFIE))]
	private Task JNGFBEJKINL(DAIHOFLBDLA GAAPIIBPFHL, OFIMLBDMAME HHCEHFFEAKN, CancellationToken FFKJLIDBALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x27216D0", Offset = "0x27206D0", VA = "0x1827216D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFDEDDONMCG))]
	private Task FPDDBBEJDCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2721A50", Offset = "0x2720A50", VA = "0x182721A50")]
	private void HKHNCGFKDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2722330", Offset = "0x2721330", VA = "0x182722330")]
	public OLELLBEKKOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal interface HJIGCIAFGLC : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool NGGJDDOMAFK
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Task BBPFNNOGPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNHBIJMDADB(Task IJOJNMAHKLB, string LDDNAFEDNGP);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class OBDKMIGEFFI : AEOBIOGPCNC
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class IDFKNMGLACB : IAsyncStateMachine
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
		public OBDKMIGEFFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IDFKNMGLACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x3B01510", Offset = "0x3B00510", VA = "0x183B01510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private readonly DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private readonly HJNEIHJIJJJ IFMMICNCAOG;

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xAEDF80", Offset = "0xAECF80", VA = "0x180AEDF80")]
	public OBDKMIGEFFI(DICEJLBHJCH FGIILGHEHMH, HJNEIHJIJJJ IFMMICNCAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x271CCE0", Offset = "0x271BCE0", VA = "0x18271CCE0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IDFKNMGLACB))]
	public Task<bool> DNIEJNCHPFL(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x271CE50", Offset = "0x271BE50", VA = "0x18271CE50")]
	[CompilerGenerated]
	private object HKABDEAHDBE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class AOFGMECCJBL : MDLFNDBDIID, FHMMJBGMKEF, PBKOKMCFKBA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class IOKNPIHFIKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public PEOGNNHCCMJ result;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IOKNPIHFIKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x2712D20", Offset = "0x2711D20", VA = "0x182712D20")]
		internal object AILLJNJGEFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x20D9D60", Offset = "0x20D8D60", VA = "0x1820D9D60")]
	[UnityEngine.Scripting.Preserve]
	public AOFGMECCJBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x20D9C40", Offset = "0x20D8C40", VA = "0x1820D9C40", Slot = "8")]
	public PEOGNNHCCMJ PHNPLOHJNJC(PIPFLAHHDDO KMJAMONBHPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface OPAOFOHKJBL
{
	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool LNFEMGOHNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	string ACOMBMBEACK
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECAKEDJKKHN();

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PGJBGAMIGNP ELBMCICODBK(long NECHDOJFBMC);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OAKPMPALGKI<PLLPALDIOHF, EOMDDKFOOGO> GKMNHPCACDM(long NECHDOJFBMC);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OAKPMPALGKI<PLLPALDIOHF, OCMKINIOLDE> CCMJJJJOOED(long NECHDOJFBMC);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OAKPMPALGKI<long, FKAJNCHGFNH> CCKHFGBDKHC();

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> OBECBOANJLF(byte[] PLNEIMJEEFL, byte[] NEHMEKKOIFN, CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class BEPGMKKBAHK : PLKALHHIPOD, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class AADOPBNNCFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AADOPBNNCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x270D730", Offset = "0x270C730", VA = "0x18270D730")]
		internal object MGCDMLDCEKJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class OFDBBAMKCGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OFDBBAMKCGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x271F5A0", Offset = "0x271E5A0", VA = "0x18271F5A0")]
		internal object HDFHPAFELNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class JAMKIAKLNND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JAMKIAKLNND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x27132E0", Offset = "0x27122E0", VA = "0x1827132E0")]
		internal object AFGDPFJEFFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class ENLCNOGCHJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ENLCNOGCHJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x27116D0", Offset = "0x27106D0", VA = "0x1827116D0")]
		internal object JCNFAAMGNKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class ONCKHBBKCFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ONCKHBBKCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x2723910", Offset = "0x2722910", VA = "0x182723910")]
		internal object IOJGLKECMBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private readonly Dictionary<Guid, CGBPHMDNPHP> ABDLBIKBIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private readonly TimeSpan HFDGFFGIDBN;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "10")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x20DCB60", Offset = "0x20DBB60", VA = "0x1820DCB60", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x20DC3B0", Offset = "0x20DB3B0", VA = "0x1820DC3B0", Slot = "4")]
	public LCJHGCCKGGO AMLBOIMHPGF(Guid MLHJIHFFCGB)
	{
		return default(LCJHGCCKGGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x20DC930", Offset = "0x20DB930", VA = "0x1820DC930", Slot = "5")]
	public bool DNDEJFPIDIA(Guid MLHJIHFFCGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x20DCC00", Offset = "0x20DBC00", VA = "0x1820DCC00", Slot = "8")]
	public bool HKHNCGFKDLF(Guid MLHJIHFFCGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x20DC5E0", Offset = "0x20DB5E0", VA = "0x1820DC5E0", Slot = "6")]
	public bool DCGDHJNMPEG(Guid MLHJIHFFCGB, Task LDHHKGCGIPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x20DD040", Offset = "0x20DC040", VA = "0x1820DD040", Slot = "7")]
	public bool KIKLIIBBLEG(Guid MLHJIHFFCGB, PEOGNNHCCMJ PKKDOKCIBNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x20DCB70", Offset = "0x20DBB70", VA = "0x1820DCB70", Slot = "9")]
	public Task<(PEOGNNHCCMJ, Task)> FAEAJJPLLCF(Guid MLHJIHFFCGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x20DCE00", Offset = "0x20DBE00", VA = "0x1820DCE00")]
	private void INMPDMNKEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x20DD290", Offset = "0x20DC290", VA = "0x1820DD290")]
	public BEPGMKKBAHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class MBLICDNILCB : MDLFNDBDIID, NDLENNICCHK, PBKOKMCFKBA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class OBFPMFJBAMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public PEOGNNHCCMJ result;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OBFPMFJBAMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x3B07ED0", Offset = "0x3B06ED0", VA = "0x183B07ED0")]
		internal object MJNOHJJPAIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2716CD0", Offset = "0x2715CD0", VA = "0x182716CD0")]
	[UnityEngine.Scripting.Preserve]
	public MBLICDNILCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2716BB0", Offset = "0x2715BB0", VA = "0x182716BB0", Slot = "8")]
	public PEOGNNHCCMJ HDEAPIKJOFC(PIPFLAHHDDO AFPDMBJFOGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal interface NEAAGLADJAL : PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000098")]
	TaskStatus CJNHJBHKBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BJPHOHNIGAP(GDOIHMDILDL DIOKIHLDBFF, LPIFDEEMPOB EECALEFDDBM, CancellationToken JCAANINIIFI);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class OKONFGFBCAL
{
	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2720FD0", Offset = "0x271FFD0", VA = "0x182720FD0")]
	public static bool LJHHKPFNHAC(this NEAAGLADJAL KIKCJCJNLOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal static class ALDKHPNPPCK
{
	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x20D95D0", Offset = "0x20D85D0", VA = "0x1820D95D0")]
	public static string IBJHNNGGMHO(this GDOIHMDILDL PDLFJMNDFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x20D9540", Offset = "0x20D8540", VA = "0x1820D9540")]
	public static bool IBEMLCBCJIJ(this GDOIHMDILDL PDLFJMNDFAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[UnityEngine.Scripting.Preserve]
internal class OEJKCCEEJMF : GCNGFCNMOLL, PKPHLOOLONF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class NDMFOMLMHKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public OEJKCCEEJMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NDMFOMLMHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x4EB21B0", Offset = "0x4EB11B0", VA = "0x184EB21B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class BLPLLDAJCOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public OEJKCCEEJMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private bool <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BLPLLDAJCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD310", Offset = "0x4EAC310", VA = "0x184EAD310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class CGLLBABHBLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CGLLBABHBLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x4EADF50", Offset = "0x4EACF50", VA = "0x184EADF50")]
		internal object IINEONFCMHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class NMBONMDKANG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public OEJKCCEEJMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private CGLLBABHBLP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private AEOBIOGPCNC <provider>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NMBONMDKANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x4EB28D0", Offset = "0x4EB18D0", VA = "0x184EB28D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class NIAMHCMBCKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NIAMHCMBCKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2860", Offset = "0x4EB1860", VA = "0x184EB2860")]
		internal object MJFNKLPFHMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private HJNEIHJIJJJ IFMMICNCAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private AEOBIOGPCNC[] MBAKAKKGILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private CancellationTokenSource IGGNLLGJDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private int GPKBDBOBCOF;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x271F0A0", Offset = "0x271E0A0", VA = "0x18271F0A0", Slot = "7")]
	public void LLEBBJIFEDK(DICEJLBHJCH FGIILGHEHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x271E9C0", Offset = "0x271D9C0", VA = "0x18271E9C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x271EE70", Offset = "0x271DE70", VA = "0x18271EE70", Slot = "6")]
	public void HKHNCGFKDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x271EAC0", Offset = "0x271DAC0", VA = "0x18271EAC0", Slot = "5")]
	public void GCCLJDHLHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x271F3B0", Offset = "0x271E3B0", VA = "0x18271F3B0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NDMFOMLMHKC))]
	public Task PPFODPANPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x271EBA0", Offset = "0x271DBA0", VA = "0x18271EBA0")]
	private void GKOAALOOMPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x271F120", Offset = "0x271E120", VA = "0x18271F120")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BLPLLDAJCOG))]
	private Task MPGGCEEDFMA(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x271E730", Offset = "0x271D730", VA = "0x18271E730")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NMBONMDKANG))]
	private Task<bool> BEODHJJINDE(int CCELBNKPBGB, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x271E9D0", Offset = "0x271D9D0", VA = "0x18271E9D0")]
	private void EBBDLMLIENG(int CCELBNKPBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x271E8C0", Offset = "0x271D8C0", VA = "0x18271E8C0")]
	private void DJGLNLEBECI(int CCELBNKPBGB, bool DHPCHJKOPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x271F270", Offset = "0x271E270", VA = "0x18271F270")]
	private void OLHJMNKIPNN(int CCELBNKPBGB, Exception IKOKPNLPNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x271EF80", Offset = "0x271DF80", VA = "0x18271EF80")]
	private void JDMCFFCIINI(CancellationToken OAGBBBCDIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x271F560", Offset = "0x271E560", VA = "0x18271F560")]
	public OEJKCCEEJMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class AJJNAHEPBJK
{
	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x20D9420", Offset = "0x20D8420", VA = "0x1820D9420")]
	public static void NDOBAALDFMM(this JAEAMIMPOOP JOJGGPKEEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x20D9410", Offset = "0x20D8410", VA = "0x1820D9410")]
	public static void INAJLKLCJMC(this JAEAMIMPOOP JOJGGPKEEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x20D9430", Offset = "0x20D8430", VA = "0x1820D9430")]
	private static void PLHHJMACLJF(this JAEAMIMPOOP JOJGGPKEEEH, bool JDDEMNIGLHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct CFCCKGIDLEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public readonly GECBALHMMKM MAEFMBPOGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public readonly string FIJIFDJCJOM;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x20E0D00", Offset = "0x20DFD00", VA = "0x1820E0D00")]
	public CFCCKGIDLEE(string HLBFHNAAINC, GECBALHMMKM LJGEMIIINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x20E0BE0", Offset = "0x20DFBE0", VA = "0x1820E0BE0")]
	public string HNAIFCDPIPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x20E0C60", Offset = "0x20DFC60", VA = "0x1820E0C60")]
	public string KDCNAGBECAO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public delegate string IPGANKDJLCG<in T>(T IKOKPNLPNJB) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public delegate int PJMGLHMCFOD<in T>(T IKOKPNLPNJB) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class ODAGHOPOFLO : CGIEFEIKFEN
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private delegate string ONPJNNCIACC(Exception IKOKPNLPNJB);

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private delegate int NIOPHDACFJC(Exception IKOKPNLPNJB);

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class HBGBGLBCHJH<T> : OGHHPLCAIKH<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class CMIKOKEPFCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
			public CMIKOKEPFCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
			internal string GEMCNEAMDEF(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class AHPBAAODKEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F2BF0", Offset = "0x6F1FF0")]
			public IPGANKDJLCG<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
			public AHPBAAODKEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x23B8E60", Offset = "0x23B7E60", VA = "0x1823B8E60")]
			internal string MIGNAAPCLCL(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class LBKKNGMAMBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public int subCode;

			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
			public LBKKNGMAMBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
			internal int FBLCCKJAGLK(Exception _)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class BJADNMABIHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F2C50", Offset = "0x6F2050")]
			public PJMGLHMCFOD<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
			public BJADNMABIHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x23B8E60", Offset = "0x23B7E60", VA = "0x1823B8E60")]
			internal int FPBNGNEDNAK(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private readonly ODAGHOPOFLO LDOPCKOMICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private readonly Type CMGECKMNDDB;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x202F750", Offset = "0x202E750", VA = "0x18202F750")]
		internal HBGBGLBCHJH(ODAGHOPOFLO LDOPCKOMICA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x202F620", Offset = "0x202E620", VA = "0x18202F620", Slot = "4")]
		public void NGKHJNLFAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x202F650", Offset = "0x202E650", VA = "0x18202F650", Slot = "5")]
		public OGHHPLCAIKH<T> PANBKDOBNAL(string HDFFHJKOOCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x202F2B0", Offset = "0x202E2B0", VA = "0x18202F2B0", Slot = "6")]
		public OGHHPLCAIKH<T> CNAKFBIFMMD(IPGANKDJLCG<T> FJNDBFHLBPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x202F3B0", Offset = "0x202E3B0", VA = "0x18202F3B0", Slot = "7")]
		public OGHHPLCAIKH<T> FCBIEHNBOJO(int LJGEMIIINDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x202F510", Offset = "0x202E510", VA = "0x18202F510", Slot = "8")]
		public OGHHPLCAIKH<T> ICFBHPHAHJG(int LJGEMIIINDB, int CFFLIBEJKPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x202F3F0", Offset = "0x202E3F0", VA = "0x18202F3F0", Slot = "9")]
		public OGHHPLCAIKH<T> GBGDOCFBFCI(int LJGEMIIINDB, PJMGLHMCFOD<T> MHDBFFDPEGG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class BECNKFFLDEK<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private bool NLABBOCODHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private readonly List<Type> MNBFOLOONBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private readonly Dictionary<Type, TVal> PCAAFKBKPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private readonly Dictionary<Type, int> GKNJOKNLEMI;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public IReadOnlyList<Type> MAMDFMGJHBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x2BDA7F0", Offset = "0x2BD97F0", VA = "0x182BDA7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAAB0", Offset = "0x2BD9AB0", VA = "0x182BDAAB0")]
		public BECNKFFLDEK(Dictionary<Type, int> GKNJOKNLEMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA720", Offset = "0x2BD9720", VA = "0x182BDA720")]
		public void AMLBOIMHPGF(Type LOHIKDGDMPP, TVal HLLJGNGJMBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA7C0", Offset = "0x2BD97C0", VA = "0x182BDA7C0")]
		public bool DMLFOHBGBHN(Type CMGECKMNDDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA650", Offset = "0x2BD9650", VA = "0x182BDA650")]
		public bool AHIJJJJOMOF(TVal CKDFGEALFAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x205F7E0", Offset = "0x205E7E0", VA = "0x18205F7E0")]
		public TVal FLFDNJDANPO(Type DPPJBLOOGOO)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAA10", Offset = "0x2BD9A10", VA = "0x182BDAA10")]
		[CompilerGenerated]
		private int PLEAOAHGIMP(Type ALOFGGPJMJL, Type COCOLHEFGCN)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private sealed class KNEOBPCNBAJ : IEnumerable<GECBALHMMKM>, IEnumerable, IEnumerator<GECBALHMMKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private GECBALHMMKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public ODAGHOPOFLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private AggregateException <aggregateException>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private IEnumerator<Exception> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private Exception <innerException>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private IEnumerator<GECBALHMMKM> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private GECBALHMMKM <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		private GECBALHMMKM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x28779A0", Offset = "0x28769A0", VA = "0x1828779A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(GECBALHMMKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x3B04A70", Offset = "0x3B03A70", VA = "0x183B04A70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xC531B0", Offset = "0xC521B0", VA = "0x180C531B0")]
		[DebuggerHidden]
		public KNEOBPCNBAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x3B04AC0", Offset = "0x3B03AC0", VA = "0x183B04AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x3B04560", Offset = "0x3B03560", VA = "0x183B04560", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x3B04510", Offset = "0x3B03510", VA = "0x183B04510")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x3B044C0", Offset = "0x3B034C0", VA = "0x183B044C0")]
		private void CAIKJCDFNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x3B04A30", Offset = "0x3B03A30", VA = "0x183B04A30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x3B04980", Offset = "0x3B03980", VA = "0x183B04980", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GECBALHMMKM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x3B04980", Offset = "0x3B03980", VA = "0x183B04980", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	internal const int IEKEGLBBAKB = 8700;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private static readonly GECBALHMMKM OEOPIDJNCOB;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	internal const string HFMLKLBFELB = "Unknown error loading room";

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	internal const int FMODCKIEBPO = 8708;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private static readonly Dictionary<Type, int> GIEAEEPKJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly HashSet<Type> MCHFENODLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private readonly BECNKFFLDEK<int> DKGEJMFJHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly BECNKFFLDEK<NIOPHDACFJC> JPICNJPOJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private readonly BECNKFFLDEK<ONPJNNCIACC> OCAFOAHCIBC;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x271D640", Offset = "0x271C640", VA = "0x18271D640")]
	[FBCFLFBFGIL(LAFFCBAHJKM.GameOnly)]
	private static void HBFKEFNCHDO(CNALHHIKJDD HDIGDGEFOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x271E420", Offset = "0x271D420", VA = "0x18271E420")]
	[RecRoom.NoEngine.Common.Preserve]
	public ODAGHOPOFLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x1074000", Offset = "0x1073000", VA = "0x181074000", Slot = "4")]
	public OGHHPLCAIKH<T> OKNOMLMKGKF<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x271D080", Offset = "0x271C080", VA = "0x18271D080", Slot = "5")]
	public CFCCKGIDLEE DHLAFPDMFPB(Exception IKOKPNLPNJB)
	{
		return default(CFCCKGIDLEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x271D280", Offset = "0x271C280", VA = "0x18271D280", Slot = "6")]
	public GECBALHMMKM EAGJPAFDGPO(Exception? IKOKPNLPNJB)
	{
		return default(GECBALHMMKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x271D8F0", Offset = "0x271C8F0", VA = "0x18271D8F0", Slot = "7")]
	[IteratorStateMachine(typeof(KNEOBPCNBAJ))]
	public IEnumerable<GECBALHMMKM> HHOKDKFFJPH(Exception IKOKPNLPNJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x271D140", Offset = "0x271C140", VA = "0x18271D140", Slot = "8")]
	public string DOAJPPELLMC(Exception? IKOKPNLPNJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x271DFE0", Offset = "0x271CFE0", VA = "0x18271DFE0")]
	private string PMDLPJAFKIP(AggregateException FDDDGFJOMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x271DC40", Offset = "0x271CC40", VA = "0x18271DC40")]
	private void NBBJFNDKEKN(Type CMGECKMNDDB, int LJGEMIIINDB, NIOPHDACFJC? AAEAJKKBOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x271D6B0", Offset = "0x271C6B0", VA = "0x18271D6B0")]
	private void HGIOOIAPLBJ(Type CMGECKMNDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x271D980", Offset = "0x271C980", VA = "0x18271D980")]
	private void IFOPGJDIIEE(Type CMGECKMNDDB, ONPJNNCIACC DLMGIPKCHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x271D4A0", Offset = "0x271C4A0", VA = "0x18271D4A0")]
	private static int FOFPKHPAKCG(Type CMGECKMNDDB, Dictionary<Type, int> GKNJOKNLEMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2E19730", Offset = "0x2E18730", VA = "0x182E19730")]
	private static bool PNJHGLPMKIB<TVal>(BECNKFFLDEK<TVal> LGIIOJHKOLK, Type CMGECKMNDDB, out TVal CKDFGEALFAK) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x271CF90", Offset = "0x271BF90", VA = "0x18271CF90")]
	[CompilerGenerated]
	internal static int AEPNFNKLAKH(Type FFACKOJENMJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct GECBALHMMKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public readonly int AIIHAMMLHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public readonly int? POABGFAGHGC;

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x12EB660", Offset = "0x12EA660", VA = "0x1812EB660")]
	public GECBALHMMKM(int HDPMPABFMFH, [Optional] int? CFFLIBEJKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x20E8840", Offset = "0x20E7840", VA = "0x1820E8840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface CGIEFEIKFEN
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OGHHPLCAIKH<T> OKNOMLMKGKF<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CFCCKGIDLEE DHLAFPDMFPB(Exception IKOKPNLPNJB);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GECBALHMMKM EAGJPAFDGPO(Exception IKOKPNLPNJB);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<GECBALHMMKM> HHOKDKFFJPH(Exception IKOKPNLPNJB);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string DOAJPPELLMC(Exception IKOKPNLPNJB);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface OGHHPLCAIKH<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGKHJNLFAEL();

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OGHHPLCAIKH<T> PANBKDOBNAL(string HDFFHJKOOCG);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OGHHPLCAIKH<T> CNAKFBIFMMD(IPGANKDJLCG<T> FJNDBFHLBPH);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OGHHPLCAIKH<T> FCBIEHNBOJO(int LJGEMIIINDB);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OGHHPLCAIKH<T> ICFBHPHAHJG(int LJGEMIIINDB, int CFFLIBEJKPB);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OGHHPLCAIKH<T> GBGDOCFBFCI(int LJGEMIIINDB, PJMGLHMCFOD<T> MHDBFFDPEGG);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class MKFGOAHIPML
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2718720", Offset = "0x2717720", VA = "0x182718720")]
	[FBCFLFBFGIL(LAFFCBAHJKM.GameOnly)]
	private static void HEBPGFNGBNI(CNALHHIKJDD HDIGDGEFOCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public interface MCFPGIBLJJO : IEquatable<MCFPGIBLJJO>
{
	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	AHFPGKFPOBG CCKHDLGAJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	DateTime LGMHIOAKIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DADLLMAKABM();

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JEMIKJDDFKC(long IHGIEILPMCA, long FKNCEBBDENC, out JNMBCFANFLA KOBJHMANLPK);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class NKMOAELCPMN : GOGKAJFDJAH
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class DIAMKDLFNAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public FALKJMEJPBK autosaveType;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public DIAMKDLFNAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class EHLOICBLOLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public DIAMKDLFNAE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public EHLOICBLOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC6F0", Offset = "0x3AFB6F0", VA = "0x183AFC6F0")]
		internal object FKONIDHJIFB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private readonly FPEBKEJOPIF HMJLLKMHMEI;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private const int FJLABIOHJPB = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<MCFPGIBLJJO> HAGMCBNHNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x271B670", Offset = "0x271A670", VA = "0x18271B670", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x271C1A0", Offset = "0x271B1A0", VA = "0x18271C1A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
	[UnityEngine.Scripting.Preserve]
	public NKMOAELCPMN([JFLEHDEIONF(null)] FPEBKEJOPIF HMJLLKMHMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x271B710", Offset = "0x271A710", VA = "0x18271B710", Slot = "6")]
	public bool KEBCCECEGCO(long IHGIEILPMCA, long FKNCEBBDENC, JNMBCFANFLA KOBJHMANLPK, FALKJMEJPBK DDBBBGFMPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x271BBF0", Offset = "0x271ABF0", VA = "0x18271BBF0")]
	private void MKDHAKFEGLL(MCFPGIBLJJO MFDMMJHLBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x271BA60", Offset = "0x271AA60", VA = "0x18271BA60", Slot = "7")]
	public bool MJHMIFBLPGG(long IHGIEILPMCA, long FKNCEBBDENC, out MCFPGIBLJJO NLDFIJLPMIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x271C240", Offset = "0x271B240", VA = "0x18271C240", Slot = "8")]
	public bool PBPMEOAGANJ(long IHGIEILPMCA, long FKNCEBBDENC, FALKJMEJPBK DDBBBGFMPLN, out MCFPGIBLJJO NLDFIJLPMIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x271BDB0", Offset = "0x271ADB0", VA = "0x18271BDB0")]
	private void OJGNLAEPKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x271BC90", Offset = "0x271AC90", VA = "0x18271BC90", Slot = "9")]
	public void NNJCDBJLNML(long IHGIEILPMCA, long FKNCEBBDENC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public enum AHFPGKFPOBG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000374")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal sealed class PNAHBNFGEAL : PEKJCOJDPJP
{
	[Cpp2IlInjected.Token(Token = "0x4000375")]
	private static readonly byte[] LOHIKDGDMPP;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	private const string MFLGIKMAILD = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private const string KMKCHIIPIDN = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private const string IDCOAIJCJEN = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private readonly byte[] KFCGMMGAGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private readonly byte[] JKDPAMIBJON;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public override AHFPGKFPOBG CCKHDLGAJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x9811A0", Offset = "0x9801A0", VA = "0x1809811A0", Slot = "8")]
		get
		{
			return default(AHFPGKFPOBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2725870", Offset = "0x2724870", VA = "0x182725870")]
	public PNAHBNFGEAL([Optional] string HHCIKLGJPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2724D50", Offset = "0x2723D50", VA = "0x182724D50", Slot = "9")]
	internal override void IBMGKFFJHNA(Stream AEOLMPHDGLJ, long IHGIEILPMCA, long FKNCEBBDENC, JNMBCFANFLA KOBJHMANLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x27250F0", Offset = "0x27240F0", VA = "0x1827250F0", Slot = "10")]
	internal override bool OPOLOBKGDOD(Stream CFLIMMPOGMF, long IHGIEILPMCA, long FKNCEBBDENC, AMNPJJLAGLG LNOKNJLMEGO, out JNMBCFANFLA KOBJHMANLPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2724FE0", Offset = "0x2723FE0", VA = "0x182724FE0")]
	private void NBAJBIBDIBA(byte[] KMJIEGIBFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2724C20", Offset = "0x2723C20", VA = "0x182724C20", Slot = "11")]
	protected override FileInfo GMMBENNKNNK(long IHGIEILPMCA, long FKNCEBBDENC, FALKJMEJPBK DDBBBGFMPLN, MCJFHGDAFDA DPGKNMJLDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2724B00", Offset = "0x2723B00", VA = "0x182724B00", Slot = "12")]
	protected override DirectoryInfo DPBLNIPNAJI(FALKJMEJPBK DDBBBGFMPLN, MCJFHGDAFDA DPGKNMJLDPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class KFNEEBOBMNL : PEKJCOJDPJP
{
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private const string MCNICGAKILJ = "V2";

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private const string MFLGIKMAILD = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private const string KMKCHIIPIDN = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public override AHFPGKFPOBG CCKHDLGAJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0B0", Offset = "0xA7A0B0", VA = "0x180A7B0B0", Slot = "8")]
		get
		{
			return default(AHFPGKFPOBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x20F0E90", Offset = "0x20EFE90", VA = "0x1820F0E90")]
	public KFNEEBOBMNL([Optional] string HHCIKLGJPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x20F0780", Offset = "0x20EF780", VA = "0x1820F0780")]
	private void LLJPBPIFKAM(FALKJMEJPBK DDBBBGFMPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x20F04F0", Offset = "0x20EF4F0", VA = "0x1820F04F0", Slot = "9")]
	internal override void IBMGKFFJHNA(Stream AEOLMPHDGLJ, long IHGIEILPMCA, long FKNCEBBDENC, JNMBCFANFLA KOBJHMANLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x20F0810", Offset = "0x20EF810", VA = "0x1820F0810", Slot = "10")]
	internal override bool OPOLOBKGDOD(Stream CFLIMMPOGMF, long IHGIEILPMCA, long FKNCEBBDENC, AMNPJJLAGLG LNOKNJLMEGO, out JNMBCFANFLA KOBJHMANLPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x20F0400", Offset = "0x20EF400", VA = "0x1820F0400", Slot = "11")]
	protected override FileInfo GMMBENNKNNK(long IHGIEILPMCA, long FKNCEBBDENC, FALKJMEJPBK DDBBBGFMPLN, MCJFHGDAFDA DPGKNMJLDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x20F02F0", Offset = "0x20EF2F0", VA = "0x1820F02F0", Slot = "12")]
	protected override DirectoryInfo DPBLNIPNAJI(FALKJMEJPBK DDBBBGFMPLN, MCJFHGDAFDA DPGKNMJLDPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal abstract class PEKJCOJDPJP : FPEBKEJOPIF
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	protected enum MCJFHGDAFDA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class OIHILOAGBNB : IEnumerable<MCFPGIBLJJO>, IEnumerable, IEnumerator<MCFPGIBLJJO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private MCFPGIBLJJO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private FALKJMEJPBK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public FALKJMEJPBK <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public PEKJCOJDPJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private DirectoryInfo <autosaveDirectory>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private FileInfo[] <files>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private FileInfo[] <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private FileInfo <file>5__5;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		private MCFPGIBLJJO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xC531B0", Offset = "0xC521B0", VA = "0x180C531B0")]
		[DebuggerHidden]
		public OIHILOAGBNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x4EB37B0", Offset = "0x4EB27B0", VA = "0x184EB37B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x4EB3A10", Offset = "0x4EB2A10", VA = "0x184EB3A10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x4EB3960", Offset = "0x4EB2960", VA = "0x184EB3960", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MCFPGIBLJJO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x4EB3960", Offset = "0x4EB2960", VA = "0x184EB3960", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class OFDNBMOJEKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public FALKJMEJPBK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OFDNBMOJEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x4EB3720", Offset = "0x4EB2720", VA = "0x184EB3720")]
		internal object BLGFHFBJANK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class ELCFJBKBHOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public PEKJCOJDPJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ELCFJBKBHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x4EAE730", Offset = "0x4EAD730", VA = "0x184EAE730")]
		internal void MFLAAKCLGNK(BMKNOMOCBOC.DDFODEAFFKC ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	protected readonly string PEKEEGLCOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private readonly object BHHPNEODMIE;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public abstract AHFPGKFPOBG CCKHDLGAJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x2724960", Offset = "0x2723960", VA = "0x182724960")]
	protected PEKJCOJDPJP([CanBeNull] string HHCIKLGJPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x27247B0", Offset = "0x27237B0", VA = "0x1827247B0", Slot = "5")]
	public bool IOMGOBFBHJG(long IHGIEILPMCA, long FKNCEBBDENC, FALKJMEJPBK DDBBBGFMPLN, out MCFPGIBLJJO MFDMMJHLBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2724730", Offset = "0x2723730", VA = "0x182724730", Slot = "6")]
	[IteratorStateMachine(typeof(OIHILOAGBNB))]
	public IEnumerable<MCFPGIBLJJO> IFLIKCLCCJB(FALKJMEJPBK DDBBBGFMPLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void IBMGKFFJHNA(Stream AEOLMPHDGLJ, long IHGIEILPMCA, long FKNCEBBDENC, JNMBCFANFLA KOBJHMANLPK);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool OPOLOBKGDOD(Stream CFLIMMPOGMF, long IHGIEILPMCA, long FKNCEBBDENC, AMNPJJLAGLG LNOKNJLMEGO, out JNMBCFANFLA KOBJHMANLPK);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2724180", Offset = "0x2723180", VA = "0x182724180", Slot = "7")]
	public MCFPGIBLJJO HAEFLBCNIIK(long IHGIEILPMCA, long FKNCEBBDENC, JNMBCFANFLA KOBJHMANLPK, FALKJMEJPBK DDBBBGFMPLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo GMMBENNKNNK(long IHGIEILPMCA, long FKNCEBBDENC, FALKJMEJPBK DDBBBGFMPLN, MCJFHGDAFDA DPGKNMJLDPM);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo DPBLNIPNAJI(FALKJMEJPBK DDBBBGFMPLN, MCJFHGDAFDA DPGKNMJLDPM);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x2724110", Offset = "0x2723110", VA = "0x182724110")]
	protected void EJGJEFOIGJK(BMKNOMOCBOC.DDFODEAFFKC JKPMFBJKIFH, string BKCPGKELHMO, FileInfo LONFBICOBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x2724480", Offset = "0x2723480", VA = "0x182724480")]
	internal bool ICAGHICJOAP(FileInfo LFAIJKBANII, long IHGIEILPMCA, long FKNCEBBDENC, out JNMBCFANFLA KOBJHMANLPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	private void JJGGDBKDDHP(Exception JDHMJBPJLEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal interface FPEBKEJOPIF
{
	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	AHFPGKFPOBG CCKHDLGAJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IOMGOBFBHJG(long IHGIEILPMCA, long FKNCEBBDENC, FALKJMEJPBK DDBBBGFMPLN, out MCFPGIBLJJO MFDMMJHLBJH);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<MCFPGIBLJJO> IFLIKCLCCJB(FALKJMEJPBK DDBBBGFMPLN);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCFPGIBLJJO HAEFLBCNIIK(long IHGIEILPMCA, long FKNCEBBDENC, JNMBCFANFLA KOBJHMANLPK, FALKJMEJPBK DDBBBGFMPLN);
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class OGCJCGIIKMK : FPEBKEJOPIF
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class MDIGDOBDNEL : IEnumerable<MCFPGIBLJJO>, IEnumerable, IEnumerator<MCFPGIBLJJO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private MCFPGIBLJJO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private FALKJMEJPBK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public FALKJMEJPBK <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public OGCJCGIIKMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private AHFPGKFPOBG[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private AHFPGKFPOBG <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private FPEBKEJOPIF <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private IEnumerable<MCFPGIBLJJO> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private IEnumerator<MCFPGIBLJJO> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private MCFPGIBLJJO <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		private MCFPGIBLJJO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xC531B0", Offset = "0xC521B0", VA = "0x180C531B0")]
		[DebuggerHidden]
		public MDIGDOBDNEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x4EB1C30", Offset = "0x4EB0C30", VA = "0x184EB1C30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x4EB17F0", Offset = "0x4EB07F0", VA = "0x184EB17F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x4EB17A0", Offset = "0x4EB07A0", VA = "0x184EB17A0")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x4EB1BF0", Offset = "0x4EB0BF0", VA = "0x184EB1BF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x4EB1B40", Offset = "0x4EB0B40", VA = "0x184EB1B40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MCFPGIBLJJO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x4EB1B40", Offset = "0x4EB0B40", VA = "0x184EB1B40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private readonly AHFPGKFPOBG[] AJBFLKDNAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private readonly Dictionary<AHFPGKFPOBG, FPEBKEJOPIF> JADCAJNOOLM;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public AHFPGKFPOBG CCKHDLGAJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x271FCA0", Offset = "0x271ECA0", VA = "0x18271FCA0", Slot = "4")]
		get
		{
			return default(AHFPGKFPOBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x271FCE0", Offset = "0x271ECE0", VA = "0x18271FCE0")]
	[UnityEngine.Scripting.Preserve]
	public OGCJCGIIKMK(params FPEBKEJOPIF[] MDPIDIPKOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x271FB40", Offset = "0x271EB40", VA = "0x18271FB40", Slot = "5")]
	public bool IOMGOBFBHJG(long IHGIEILPMCA, long FKNCEBBDENC, FALKJMEJPBK DDBBBGFMPLN, out MCFPGIBLJJO MFDMMJHLBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x271F7A0", Offset = "0x271E7A0", VA = "0x18271F7A0")]
	private void BNINCIABFDB(int EODFOINBHFB, long IHGIEILPMCA, long FKNCEBBDENC, FALKJMEJPBK DDBBBGFMPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x271FAC0", Offset = "0x271EAC0", VA = "0x18271FAC0", Slot = "6")]
	[IteratorStateMachine(typeof(MDIGDOBDNEL))]
	public IEnumerable<MCFPGIBLJJO> IFLIKCLCCJB(FALKJMEJPBK DDBBBGFMPLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x271F9D0", Offset = "0x271E9D0", VA = "0x18271F9D0", Slot = "7")]
	public MCFPGIBLJJO HAEFLBCNIIK(long IHGIEILPMCA, long FKNCEBBDENC, JNMBCFANFLA KOBJHMANLPK, FALKJMEJPBK DDBBBGFMPLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal static class IOACNLHJKEC
{
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	internal const int PELPNKLGFEP = 32;

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x20EDEA0", Offset = "0x20ECEA0", VA = "0x1820EDEA0")]
	internal static byte[] CNHJIFOFBHE(byte[] KMJIEGIBFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x20EDE20", Offset = "0x20ECE20", VA = "0x1820EDE20")]
	public static void BMCIMBPFEDI(Stream LDKNDLKOFAC, byte[] LAFDDJEPEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x20EDF40", Offset = "0x20ECF40", VA = "0x1820EDF40")]
	public static bool OECDEGAPDEK(Stream LDKNDLKOFAC, long FLJFGAEPHBA, AMNPJJLAGLG AMAPBECLHEM, out byte[] FMILNJAHFJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public delegate void AMNPJJLAGLG(BMKNOMOCBOC.DDFODEAFFKC PIKCBKHBDAM, string HJJLMCEMDKN);
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class JMKLJFBLEJL : MCFPGIBLJJO, IEquatable<MCFPGIBLJJO>, IEquatable<JMKLJFBLEJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	private readonly PEKJCOJDPJP NBPLNCJEIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly FileInfo OHOAODOPFHH;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public AHFPGKFPOBG CCKHDLGAJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x20EFD80", Offset = "0x20EED80", VA = "0x1820EFD80", Slot = "4")]
		get
		{
			return default(AHFPGKFPOBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public DateTime LGMHIOAKIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x20EFCE0", Offset = "0x20EECE0", VA = "0x1820EFCE0", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x20EFE60", Offset = "0x20EEE60", VA = "0x1820EFE60")]
	public JMKLJFBLEJL(PEKJCOJDPJP JOAMDHANKLE, FileInfo LFAIJKBANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x20EFDB0", Offset = "0x20EEDB0", VA = "0x1820EFDB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x20EF8C0", Offset = "0x20EE8C0", VA = "0x1820EF8C0", Slot = "6")]
	public void DADLLMAKABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x20EFCA0", Offset = "0x20EECA0", VA = "0x1820EFCA0", Slot = "7")]
	public bool JEMIKJDDFKC(long IHGIEILPMCA, long FKNCEBBDENC, out JNMBCFANFLA KOBJHMANLPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x20EFA70", Offset = "0x20EEA70", VA = "0x1820EFA70", Slot = "8")]
	public bool Equals(MCFPGIBLJJO BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x20EFB50", Offset = "0x20EEB50", VA = "0x1820EFB50", Slot = "9")]
	public bool Equals(JMKLJFBLEJL BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x20EF970", Offset = "0x20EE970", VA = "0x1820EF970", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x20EFC00", Offset = "0x20EEC00", VA = "0x1820EFC00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x11CF340", Offset = "0x11CE340", VA = "0x1811CF340")]
	public static bool LFCPNLBCIDE(JMKLJFBLEJL EEDCFNGAAFO, JMKLJFBLEJL OFBPOJFNNIJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x11CF320", Offset = "0x11CE320", VA = "0x1811CF320")]
	public static bool JIPCNIGMDBL(JMKLJFBLEJL EEDCFNGAAFO, JMKLJFBLEJL OFBPOJFNNIJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct JFKNJLBDPFB
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class HBMMDJIDLKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private DICEJLBHJCH <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HBMMDJIDLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x381D620", Offset = "0x381C620", VA = "0x18381D620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x20EEC80", Offset = "0x20EDC80", VA = "0x1820EEC80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HBMMDJIDLKF))]
	public static Task PLLHAMBOEGA(HEPJBIGMLHA OAAPCIHIIOO, OFIMLBDMAME HHCEHFFEAKN, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct KOCKNMGNEJH
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class EIJAIKMJDCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public HNNFLHMGLEJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public LBOAMJIDFHD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private DICEJLBHJCH <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private HJNEIHJIJJJ <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private FEALJIILFCB <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private List<(PersistenceView, NEMHKEECLGO)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private NEMHKEECLGO <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public EIJAIKMJDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC770", Offset = "0x3AFB770", VA = "0x183AFC770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x20F9620", Offset = "0x20F8620", VA = "0x1820F9620")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EIJAIKMJDCD))]
	public static Task PLLHAMBOEGA(HNNFLHMGLEJ KIDKAIDKLIB, OFIMLBDMAME HHCEHFFEAKN, LBOAMJIDFHD EKBIPMNLNGI, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal struct EGHAHIAACBN
{
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480")]
	public static EGHAHIAACBN HFOCJEBDOBL()
	{
		return default(EGHAHIAACBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void LFAHGLOFOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void LBILJEHAAGG(OFIMLBDMAME HHCEHFFEAKN, object KOBLBILBKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void BNECBOCMIEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal struct LHPCIKACHNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private OFIMLBDMAME HHCEHFFEAKN;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private HJNEIHJIJJJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x2716170", Offset = "0x2715170", VA = "0x182716170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x27163A0", Offset = "0x27153A0", VA = "0x1827163A0")]
	public static Task PLLHAMBOEGA(DICEJLBHJCH FGIILGHEHMH, OFIMLBDMAME HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x27161C0", Offset = "0x27151C0", VA = "0x1827161C0")]
	private void PLLHAMBOEGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class KABNIFBIBJJ : HNNFLHMGLEJ
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class HOHKBHDJIBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public KABNIFBIBJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private EGIKMCBHEPN <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private DHDFPEDJJBO <roomSaveOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private CAMHKKGEKKA <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private JNMBCFANFLA <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private JNMBCFANFLA <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private TaskAwaiter<JNMBCFANFLA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HOHKBHDJIBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x381E850", Offset = "0x381D850", VA = "0x18381E850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly string AKBKIBJBAHE;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x20F0240", Offset = "0x20EF240", VA = "0x1820F0240")]
	public KABNIFBIBJJ(Guid MLHJIHFFCGB, DICEJLBHJCH FGIILGHEHMH, DMMCOJOPIJA LONIOFFJBLO, string AKBKIBJBAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x20F00A0", Offset = "0x20EF0A0", VA = "0x1820F00A0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HOHKBHDJIBF))]
	protected override Task OMAJKGPPIHI(HEPJBIGMLHA OAAPCIHIIOO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class FBOHCIHKOCF
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class OPPJMMOIFBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public MDNHMBFDALB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public OFIMLBDMAME deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public FBOHCIHKOCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OPPJMMOIFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x3829040", Offset = "0x3828040", VA = "0x183829040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class NDKBNFEPJON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public FBOHCIHKOCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NDKBNFEPJON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class HLBOIOLBGGK
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private sealed class <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public HLBOIOLBGGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x4EB7470", Offset = "0x4EB6470", VA = "0x184EB7470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public NDKBNFEPJON CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HLBOIOLBGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x381E700", Offset = "0x381D700", VA = "0x18381E700")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task HFGAOAJDCIP(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class GCDFGEDGHEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public FBOHCIHKOCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private NDKBNFEPJON <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private HLBOIOLBGGK <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GCDFGEDGHEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x381D0C0", Offset = "0x381C0C0", VA = "0x18381D0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class OCLKLALEMDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public FBOHCIHKOCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private Dictionary<Guid, List<PMICGCMMAGB>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private KeyValuePair<Guid, List<PMICGCMMAGB>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OCLKLALEMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x38286F0", Offset = "0x38276F0", VA = "0x1838286F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class AGPOLPCLBEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public FBOHCIHKOCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private JAEAMIMPOOP <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private Dictionary<Guid, List<PMICGCMMAGB>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private KeyValuePair<Guid, List<PMICGCMMAGB>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AGPOLPCLBEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x38177C0", Offset = "0x38167C0", VA = "0x1838177C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class LODEJOGOEOI
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		private sealed class <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public PMICGCMMAGB handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public LODEJOGOEOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0x4EB4C10", Offset = "0x4EB3C10", VA = "0x184EB4C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public DJNMGENDABJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public List<PMICGCMMAGB> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LODEJOGOEOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x3824260", Offset = "0x3823260", VA = "0x183824260")]
		internal object BKKIMIOLGAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x3824350", Offset = "0x3823350", VA = "0x183824350")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task LGCHPFDHCCH(PMICGCMMAGB handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x38244A0", Offset = "0x38234A0", VA = "0x1838244A0")]
		internal object MFFGDGMCBJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class AOIBIJCJLIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public List<PMICGCMMAGB> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public DJNMGENDABJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public FBOHCIHKOCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private LODEJOGOEOI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private IEnumerable<Task> <handlerTasks>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AOIBIJCJLIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x3817F00", Offset = "0x3816F00", VA = "0x183817F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class MEFGMHNNJEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public FBOHCIHKOCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MEFGMHNNJEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x3825EE0", Offset = "0x3824EE0", VA = "0x183825EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class BPLKHCAHGHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BPLKHCAHGHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x3818EE0", Offset = "0x3817EE0", VA = "0x183818EE0")]
		internal object DFIPIGDNHDA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class HPHCAKCJPDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public FBOHCIHKOCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private BPLKHCAHGHJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private JAEAMIMPOOP <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private List<PMICGCMMAGB> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HPHCAKCJPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x381ED40", Offset = "0x381DD40", VA = "0x18381ED40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class OLLLNJINKCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OLLLNJINKCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x3828FD0", Offset = "0x3827FD0", VA = "0x183828FD0")]
		internal object LCPCMOKPKFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class CLLAIPPHHCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public FBOHCIHKOCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private OLLLNJINKCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private OCLNBBADIAK <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private OCLNBBADIAK <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private OCLNBBADIAK <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private TaskAwaiter<OCLNBBADIAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CLLAIPPHHCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x381A970", Offset = "0x3819970", VA = "0x18381A970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class AGHLPOOGJAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AGHLPOOGJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x3817750", Offset = "0x3816750", VA = "0x183817750")]
		internal object HFKAFDFLGIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly HEPJBIGMLHA OAAPCIHIIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private FKMCDGDKLLL ICIDCOJFOND;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private HNNFLHMGLEJ KNPNLKLENFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x91B270", Offset = "0x91A270", VA = "0x18091B270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
	public FBOHCIHKOCF(HEPJBIGMLHA OAAPCIHIIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x20E72D0", Offset = "0x20E62D0", VA = "0x1820E72D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OPPJMMOIFBI))]
	public Task PLLHAMBOEGA(MDNHMBFDALB BFIEPCPKGPI, OFIMLBDMAME FKLBIBPMBFA, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x20E6630", Offset = "0x20E5630", VA = "0x1820E6630")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GCDFGEDGHEA))]
	private Task EFOMJHIIDLA(OFIMLBDMAME HHCEHFFEAKN, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x20E62D0", Offset = "0x20E52D0", VA = "0x1820E62D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OCLKLALEMDI))]
	private Task CBEMCDFPAIK(OFIMLBDMAME HHCEHFFEAKN, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x20E6C30", Offset = "0x20E5C30", VA = "0x1820E6C30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AGPOLPCLBEK))]
	private Task IPCLHIBAOAB(OFIMLBDMAME HHCEHFFEAKN, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x20E6A60", Offset = "0x20E5A60", VA = "0x1820E6A60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOIBIJCJLIB))]
	private Task HOICIGNGLEP(Guid CNGDBJGBDCN, List<PMICGCMMAGB> OIIKJAAEKLK, DJNMGENDABJ MMNNMHBEMOH, OFIMLBDMAME HHCEHFFEAKN, CancellationToken FFKJLIDBALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x20E6DD0", Offset = "0x20E5DD0", VA = "0x1820E6DD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MEFGMHNNJEL))]
	private Task JFPHEKBKJCD(OFIMLBDMAME HHCEHFFEAKN, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x20E6F70", Offset = "0x20E5F70", VA = "0x1820E6F70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HPHCAKCJPDD))]
	private Task MCCCPHFKDGM(Guid IJENDLMNFBE, OFIMLBDMAME HHCEHFFEAKN, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x20E7130", Offset = "0x20E6130", VA = "0x1820E7130")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CLLAIPPHHCC))]
	private Task PIJNGEEILBA(Guid IJENDLMNFBE, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x20E61A0", Offset = "0x20E51A0", VA = "0x1820E61A0")]
	private void AFDFOACOCFL(Guid IJENDLMNFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x20E67D0", Offset = "0x20E57D0", VA = "0x1820E67D0")]
	private void FHELGKHFHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x20E6470", Offset = "0x20E5470", VA = "0x1820E6470")]
	public Guid CPJGDNDMNKO(MDNHMBFDALB PBGGGGPPPPE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x20E6890", Offset = "0x20E5890", VA = "0x1820E6890")]
	[CompilerGenerated]
	private object GGILBONOION()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal struct BGIJNHGMHNF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private readonly HEPJBIGMLHA OAAPCIHIIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly Guid KJHINMFKANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private bool DHPCHJKOPIB;

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x20DD670", Offset = "0x20DC670", VA = "0x1820DD670")]
	public static BGIJNHGMHNF LNPLFDHJFML(HEPJBIGMLHA OAAPCIHIIOO)
	{
		return default(BGIJNHGMHNF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0xE79E70", Offset = "0xE78E70", VA = "0x180E79E70")]
	public void MBFHLFDEECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x20DD350", Offset = "0x20DC350", VA = "0x1820DD350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x20DD6A0", Offset = "0x20DC6A0", VA = "0x1820DD6A0")]
	private BGIJNHGMHNF(HEPJBIGMLHA OAAPCIHIIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x20DD360", Offset = "0x20DC360", VA = "0x1820DD360")]
	private void KNAHHMNDKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x20DD5C0", Offset = "0x20DC5C0", VA = "0x1820DD5C0")]
	private Func<Guid, bool> LHKBNCEIECD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal struct FIOLADNFICA
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class KMGLDACKLKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public AsyncTaskMethodBuilder<IODHGACPIHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public FIOLADNFICA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private IODHGACPIHP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private TaskAwaiter<IODHGACPIHP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KMGLDACKLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x3822580", Offset = "0x3821580", VA = "0x183822580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class CGCFNMJMPNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AsyncTaskMethodBuilder<IODHGACPIHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public FIOLADNFICA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private IODHGACPIHP <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private IODHGACPIHP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter<IODHGACPIHP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CGCFNMJMPNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x381A2E0", Offset = "0x38192E0", VA = "0x18381A2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class JBAKMKGNBKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JBAKMKGNBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xCAB4C0", Offset = "0xCAA4C0", VA = "0x180CAB4C0")]
		internal bool KBOEEMHCBJD(MEKHHBDIOBK sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class LEJFBBGAGLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public AsyncTaskMethodBuilder<IODHGACPIHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public HJNEIHJIJJJ callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public PLLPALDIOHF superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private JBAKMKGNBKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private EAHJJHFFELH <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private MEKHHBDIOBK <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private PLLPALDIOHF <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private PLLPALDIOHF <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private EAHJJHFFELH <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private GKJCOLDBOLN <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private GKJCOLDBOLN <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private ONCPNDKMCDI <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private ONCPNDKMCDI <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private TaskAwaiter<EAHJJHFFELH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private TaskAwaiter<GKJCOLDBOLN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private TaskAwaiter<ONCPNDKMCDI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LEJFBBGAGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3822B20", Offset = "0x3821B20", VA = "0x183822B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private HJNEIHJIJJJ IFMMICNCAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private KNGIAEBKBLN NEHHPMGHOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	private MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	private long IHGIEILPMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	private long FKNCEBBDENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	private long EOFGLMIFIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private string NELEGDAMKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private PLLPALDIOHF OIKJDLBLCOJ;

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x20E7490", Offset = "0x20E6490", VA = "0x1820E7490")]
	public static Task<IODHGACPIHP> DOEKGINBLNE(DICEJLBHJCH FGIILGHEHMH, CCGGKNOLNJA CFOFEENKFCN, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x20E7B50", Offset = "0x20E6B50", VA = "0x1820E7B50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KMGLDACKLKF))]
	private Task<IODHGACPIHP> PLLHAMBOEGA(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x20E7760", Offset = "0x20E6760", VA = "0x1820E7760")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGCFNMJMPNO))]
	private Task<IODHGACPIHP> OPEOFLDPAJK(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x20E7920", Offset = "0x20E6920", VA = "0x1820E7920")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LEJFBBGAGLE))]
	private static Task<IODHGACPIHP> OPEOFLDPAJK(HJNEIHJIJJJ IFMMICNCAOG, long IHGIEILPMCA, long FKNCEBBDENC, long EOFGLMIFIFP, string NELEGDAMKMM, PLLPALDIOHF OIKJDLBLCOJ, CancellationToken OAGBBBCDIGC, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x20E76D0", Offset = "0x20E66D0", VA = "0x1820E76D0")]
	private void OHMIPHMDICP(EAHJJHFFELH IMNFFHILDHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal struct PDHCJGIAILA
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class OKGKMFOJCMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public DICEJLBHJCH roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OKGKMFOJCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x4EB3A50", Offset = "0x4EB2A50", VA = "0x184EB3A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class AHDMLEMCGMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public PDHCJGIAILA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AHDMLEMCGMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC360", Offset = "0x4EAB360", VA = "0x184EAC360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private static readonly HPPHLHFLMDP EDKPPKNIPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private OFIMLBDMAME HHCEHFFEAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private ByteString LBMEKGGAGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private HEPJBIGMLHA OAAPCIHIIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private bool JAHCCNKIAGO;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private HJNEIHJIJJJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x2723B60", Offset = "0x2722B60", VA = "0x182723B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private bool DCLINFNMKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x2723CA0", Offset = "0x2722CA0", VA = "0x182723CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private bool LIOHIHIOHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x2723BB0", Offset = "0x2722BB0", VA = "0x182723BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2723D20", Offset = "0x2722D20", VA = "0x182723D20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OKGKMFOJCMF))]
	public static Task PLLHAMBOEGA(DICEJLBHJCH FGIILGHEHMH, OFIMLBDMAME HHCEHFFEAKN, HEPJBIGMLHA OAAPCIHIIOO, bool JAHCCNKIAGO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2723F00", Offset = "0x2722F00", VA = "0x182723F00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AHDMLEMCGMM))]
	private Task PLLHAMBOEGA(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal static class CICNMJNMIMD
{
	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x20E19E0", Offset = "0x20E09E0", VA = "0x1820E19E0")]
	public static void GBICDOBIJEI(this MGFPBFIAOAF KBEKNLOLOMC, GDOIHMDILDL DEFMMEKECKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x20E1900", Offset = "0x20E0900", VA = "0x1820E1900")]
	public static void CKEFAEJFOJA(this GDOIHMDILDL PDLFJMNDFAD, [Optional] string HJJLMCEMDKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct CGHFIEDJJGE
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class KCGFMILPAHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public CGHFIEDJJGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KCGFMILPAHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x27143D0", Offset = "0x27133D0", VA = "0x1827143D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private const int DLCPLLEDJJA = 20;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private const float PFCLCKAPKII = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private HJNEIHJIJJJ IFMMICNCAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private OFIMLBDMAME HHCEHFFEAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private float GDABLLJMBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private float GFPILOFHOAG;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x20E10E0", Offset = "0x20E00E0", VA = "0x1820E10E0")]
	public static Task CMJLDFEGAHF(DICEJLBHJCH FGIILGHEHMH, OFIMLBDMAME HHCEHFFEAKN, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x20E1610", Offset = "0x20E0610", VA = "0x1820E1610")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KCGFMILPAHH))]
	public Task PLLHAMBOEGA(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x20E1290", Offset = "0x20E0290", VA = "0x1820E1290")]
	private static void KKFJMDLBNEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x20E13E0", Offset = "0x20E03E0", VA = "0x1820E13E0")]
	private void LFHLACHGBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x20E1560", Offset = "0x20E0560", VA = "0x1820E1560")]
	private static float OEEKGEBBEIK(HJNEIHJIJJJ IFMMICNCAOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x20E1270", Offset = "0x20E0270", VA = "0x1820E1270")]
	private static float GECBGHJCGEJ()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal class HEPJBIGMLHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class PHONNLIHLKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AsyncTaskMethodBuilder<OCLNBBADIAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public OCLNBBADIAK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public HEPJBIGMLHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private OCLNBBADIAK <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private GEMMKFJNFAA.FDLLAOGMAKD<OCLNBBADIAK> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<GEMMKFJNFAA.FDLLAOGMAKD<OCLNBBADIAK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public PHONNLIHLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x38293D0", Offset = "0x38283D0", VA = "0x1838293D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct NJAEIJJHALI<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class KKEKOECKJBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public OCLNBBADIAK roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KKEKOECKJBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x38224C0", Offset = "0x38214C0", VA = "0x1838224C0")]
		internal OCLNBBADIAK FLOPMLKEMAG(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class FJJGLCGLJMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public AsyncTaskMethodBuilder<GEMMKFJNFAA.FDLLAOGMAKD<OCLNBBADIAK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public OCLNBBADIAK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public HEPJBIGMLHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private KKEKOECKJBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private HKGOHLMLBJL <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private GEMMKFJNFAA.FDLLAOGMAKD<OCLNBBADIAK> <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private HKGOHLMLBJL <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private GEMMKFJNFAA.FDLLAOGMAKD<OCLNBBADIAK> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private string <errorMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private ByteString <actualOperationId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private string <errorMessage>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private TaskAwaiter<GEMMKFJNFAA.FDLLAOGMAKD<OCLNBBADIAK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public FJJGLCGLJMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x381C870", Offset = "0x381B870", VA = "0x18381C870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class OIMAPJCLFHG<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public HEPJBIGMLHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private T <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public OIMAPJCLFHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x2FE1750", Offset = "0x2FE0750", VA = "0x182FE1750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class KJPLFPCJFDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public HEPJBIGMLHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KJPLFPCJFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x3822330", Offset = "0x3821330", VA = "0x183822330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class KMIADFEBPOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KMIADFEBPOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x38229B0", Offset = "0x38219B0", VA = "0x1838229B0")]
		internal object IHCBNPFEILF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x3822A10", Offset = "0x3821A10", VA = "0x183822A10")]
		internal bool JJOJBBLKCMF(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class GFIFEEKAOPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GFIFEEKAOPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x381D550", Offset = "0x381C550", VA = "0x18381D550")]
		internal object HKANKJNLMGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class MLFBGNEODIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MLFBGNEODIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x3827210", Offset = "0x3826210", VA = "0x183827210")]
		internal object MNEKEABLJJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private sealed class GIDGHDFPDPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GIDGHDFPDPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x381D5B0", Offset = "0x381C5B0", VA = "0x18381D5B0")]
		internal object DDMCGINNKOG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class NBAMDOHEBFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public HEPJBIGMLHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NBAMDOHEBFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x3827280", Offset = "0x3826280", VA = "0x183827280")]
		internal object MAKJOHEBPOG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class BFEBDCMBPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public HEPJBIGMLHA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BFEBDCMBPEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x3818C40", Offset = "0x3817C40", VA = "0x183818C40")]
		internal object MAKJOHEBPOG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private static readonly Guid ODEKKEHLGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly HNNFLHMGLEJ KNPNLKLENFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private readonly GEMMKFJNFAA FDNIDNDDLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	private readonly MAMFKBMKCDB JOJGGPKEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private readonly PDMLHPDINJL NIPJAHMNEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private bool LLBNGDNEKDI;

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x20EBBF0", Offset = "0x20EABF0", VA = "0x1820EBBF0")]
	public HEPJBIGMLHA(HNNFLHMGLEJ KIDKAIDKLIB, GEMMKFJNFAA FDNIDNDDLKN, MAMFKBMKCDB JOJGGPKEEEH, PDMLHPDINJL NIPJAHMNEIF, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x20EAB80", Offset = "0x20E9B80", VA = "0x1820EAB80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x20EAB80", Offset = "0x20E9B80", VA = "0x1820EAB80")]
	public void BNBDDNOOKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x20EAFC0", Offset = "0x20E9FC0", VA = "0x1820EAFC0")]
	public void EECCHKGKBIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x20EBAB0", Offset = "0x20EAAB0", VA = "0x1820EBAB0")]
	public void PGNLEOHEMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x20EB880", Offset = "0x20EA880", VA = "0x1820EB880")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PHONNLIHLKD))]
	internal Task<OCLNBBADIAK> NHOMALPFKKD(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, OCLNBBADIAK KGKJNKONAMF, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x20F3980", Offset = "0x20F2980", VA = "0x1820F3980")]
	private static byte[] DOOPHCNOEIC<T>(T HJJLMCEMDKN) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x26E4820", Offset = "0x26E3820", VA = "0x1826E4820")]
	private static T HEDEIBMHFDO<T>(MessageParser<T> OMKEHJNDIPC, byte[] HJJLMCEMDKN, T EJPCGJHDNLD) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x20EACF0", Offset = "0x20E9CF0", VA = "0x1820EACF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FJJGLCGLJMB))]
	private Task<GEMMKFJNFAA.FDLLAOGMAKD<OCLNBBADIAK>> DFHCECGCCBA(OCLNBBADIAK KGKJNKONAMF, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x26E49D0", Offset = "0x26E39D0", VA = "0x1826E49D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OIMAPJCLFHG<>))]
	internal Task<T> IBCODIEFGKJ<T>(CancellationToken JCAANINIIFI, Func<CancellationToken, Task<T>> AKBHDLDEAFJ, int GAILCEMEBGK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x20EB220", Offset = "0x20EA220", VA = "0x1820EB220")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KJPLFPCJFDH))]
	internal Task IBCODIEFGKJ(CancellationToken JCAANINIIFI, Func<CancellationToken, Task> AKBHDLDEAFJ, int GAILCEMEBGK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x20EAAF0", Offset = "0x20E9AF0", VA = "0x1820EAAF0")]
	public OCLNBBADIAK BLNKHOINFLE(HKGOHLMLBJL OIFHGNGFIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x20EB810", Offset = "0x20EA810", VA = "0x1820EB810")]
	public OIMBOADDECM NGDELOLNDLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x20EBA40", Offset = "0x20EAA40", VA = "0x1820EBA40")]
	public KIKKPADFBCP OCLJLBGNMHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x20EB090", Offset = "0x20EA090", VA = "0x1820EB090")]
	public EGIKMCBHEPN HOBMECKANIH([Optional] HPPHLHFLMDP? CGJPMMKJEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x20EB3B0", Offset = "0x20EA3B0", VA = "0x1820EB3B0")]
	public void JECDPMHPDCK(Func<Guid, bool> CECBKJKJGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x20EA980", Offset = "0x20E9980", VA = "0x1820EA980")]
	public void BJFAPKBMIDC(Func<Guid, bool> AEGDMDFKFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x20EAE90", Offset = "0x20E9E90", VA = "0x1820EAE90")]
	public void DGIELNMJOMJ(Func<Guid, bool> CECBKJKJGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x20EB660", Offset = "0x20EA660", VA = "0x1820EB660")]
	public Guid LNPLFDHJFML()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x20EB530", Offset = "0x20EA530", VA = "0x1820EB530")]
	public void KNAHHMNDKGD(Guid KJHINMFKANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x20EB3E0", Offset = "0x20EA3E0", VA = "0x1820EB3E0")]
	public void JFPHCJMMOCC(OCLNBBADIAK OHBKMBJHCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x20EA860", Offset = "0x20E9860", VA = "0x1820EA860")]
	public void AHJGPEGCGMK(string MNJELDICJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x20EA740", Offset = "0x20E9740", VA = "0x1820EA740")]
	public void AHJGPEGCGMK(Func<string> ELGDAILMKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x26E4740", Offset = "0x26E3740", VA = "0x1826E4740")]
	private T EPDIFJKFPOK<T>(T CKDFGEALFAK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x20EACA0", Offset = "0x20E9CA0", VA = "0x1820EACA0")]
	public void CIDBKBIIILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x26E4430", Offset = "0x26E3430", VA = "0x1826E4430")]
	[CompilerGenerated]
	internal static string BOFJFELMEFJ<T>(byte[] KMJIEGIBFLJ, int HMFMJIGINKG, ref NJAEIJJHALI<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal struct HEADFKIAHGB
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class CGNLAOFBMFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public DICEJLBHJCH roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public bool omShouldBeEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CGNLAOFBMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x381A5E0", Offset = "0x38195E0", VA = "0x18381A5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class LOECPMGLPPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public HEADFKIAHGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private MGFPBFIAOAF <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LOECPMGLPPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x3824590", Offset = "0x3823590", VA = "0x183824590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private bool MKFPIMCMBOJ;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private HJNEIHJIJJJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x20EA030", Offset = "0x20E9030", VA = "0x1820EA030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	private KCMAHJPHMBH CGILCLDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x20EA080", Offset = "0x20E9080", VA = "0x1820EA080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x20EA3A0", Offset = "0x20E93A0", VA = "0x1820EA3A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGNLAOFBMFO))]
	public static Task PLLHAMBOEGA(DICEJLBHJCH FGIILGHEHMH, bool MKFPIMCMBOJ, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x20EA540", Offset = "0x20E9540", VA = "0x1820EA540")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LOECPMGLPPI))]
	private Task PLLHAMBOEGA(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x20EA100", Offset = "0x20E9100", VA = "0x1820EA100")]
	private void KOPJEJFDOLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
internal struct CMGPAGCJMFA
{
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class GJGCBJGGDIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public DICEJLBHJCH roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GJGCBJGGDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x2711A80", Offset = "0x2710A80", VA = "0x182711A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class BNGANAIODOH
	{
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		private sealed class <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			public BNGANAIODOH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x4EB75F0", Offset = "0x4EB65F0", VA = "0x184EB75F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BNGANAIODOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x270E090", Offset = "0x270D090", VA = "0x18270E090")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task FBHDPKPCCFC(MNKIABAIHBN<string>.JJAEKMMDGKH timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private sealed class GLMJNJJBPBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public CMGPAGCJMFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private BNGANAIODOH <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private OCLNBBADIAK <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private TaskAwaiter<OCLNBBADIAK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GLMJNJJBPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x2711C30", Offset = "0x2710C30", VA = "0x182711C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class IOJILCJBLAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public FEALJIILFCB version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IOJILCJBLAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x2712C40", Offset = "0x2711C40", VA = "0x182712C40")]
		internal object LJKKDPHEDGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x2712B90", Offset = "0x2711B90", VA = "0x182712B90")]
		internal object DIEFLEGINEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private OFIMLBDMAME HHCEHFFEAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private HEPJBIGMLHA OAAPCIHIIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private bool ALLFCCHJDGD;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private static readonly ByteString OEPMJCAHMEP;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private HJNEIHJIJJJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x20E1E20", Offset = "0x20E0E20", VA = "0x1820E1E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private KCMAHJPHMBH CGILCLDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x20E1E70", Offset = "0x20E0E70", VA = "0x1820E1E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x20E2530", Offset = "0x20E1530", VA = "0x1820E2530")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GJGCBJGGDIE))]
	public static Task PLLHAMBOEGA(DICEJLBHJCH FGIILGHEHMH, OFIMLBDMAME HHCEHFFEAKN, HEPJBIGMLHA OAAPCIHIIOO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC, bool ALLFCCHJDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x20E2710", Offset = "0x20E1710", VA = "0x1820E2710")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GLMJNJJBPBD))]
	private Task PLLHAMBOEGA(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x20E1EF0", Offset = "0x20E0EF0", VA = "0x1820E1EF0")]
	private void HJPOJHOMFDO([NotNull] OCMKINIOLDE ELKCKIIFBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x20E24D0", Offset = "0x20E14D0", VA = "0x1820E24D0")]
	private bool JJBICPHJNCB(FEALJIILFCB ELKCHAMAHHH, OCMKINIOLDE ELKCKIIFBGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal abstract class IPGDAGIOAKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly HNNFLHMGLEJ KNPNLKLENFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly HEPJBIGMLHA ADENDNDDCJC;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public HJNEIHJIJJJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x20EE2F0", Offset = "0x20ED2F0", VA = "0x1820EE2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public KCMAHJPHMBH CGILCLDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x20EE340", Offset = "0x20ED340", VA = "0x1820EE340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x20EE3D0", Offset = "0x20ED3D0", VA = "0x1820EE3D0")]
	protected IPGDAGIOAKM(HEPJBIGMLHA OAAPCIHIIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x20EE2D0", Offset = "0x20ED2D0", VA = "0x1820EE2D0")]
	protected void AHJGPEGCGMK(string MNJELDICJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x20EE1A0", Offset = "0x20ED1A0", VA = "0x1820EE1A0")]
	public void AHJGPEGCGMK(Func<string> ELGDAILMKBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal class KIKKPADFBCP : IPGDAGIOAKM, JMKFEAIOBKO
{
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	public delegate Task<MDNHMBFDALB> BBMLLBCIDED(OFIMLBDMAME HHCEHFFEAKN, LBOAMJIDFHD GHDHPOKNPFK, KMGKAPJIBHJ HEHNPOGOANF, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class NMEPGNEMCLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public CCGGKNOLNJA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private BGIJNHGMHNF <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private OCLNBBADIAK <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private OCLNBBADIAK <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter<OCLNBBADIAK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NMEPGNEMCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x3B07560", Offset = "0x3B06560", VA = "0x183B07560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private sealed class PIHDOEAEJII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder<OCLNBBADIAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public CCGGKNOLNJA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private OCLNBBADIAK <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private OCLNBBADIAK <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private TaskAwaiter<OCLNBBADIAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public PIHDOEAEJII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x3B0A260", Offset = "0x3B09260", VA = "0x183B0A260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private sealed class HNHEJJHPOBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public CCGGKNOLNJA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HNHEJJHPOBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B00BD0", Offset = "0x3AFFBD0", VA = "0x183B00BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private sealed class MGMMOCGDANO
	{
		[Cpp2IlInjected.Token(Token = "0x2000137")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			public AsyncTaskMethodBuilder<IODHGACPIHP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			public MGMMOCGDANO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			private IODHGACPIHP <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			private IODHGACPIHP <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			private TaskAwaiter<MDNHMBFDALB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			private TaskAwaiter<IODHGACPIHP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x4EB61E0", Offset = "0x4EB51E0", VA = "0x184EB61E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000138")]
		private sealed class <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			public AsyncTaskMethodBuilder<OFIMLBDMAME> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public MGMMOCGDANO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private OFIMLBDMAME <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private OFIMLBDMAME <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private TaskAwaiter<MDNHMBFDALB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private TaskAwaiter<OFIMLBDMAME> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x4EB6930", Offset = "0x4EB5930", VA = "0x184EB6930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000139")]
		private sealed class <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			public MGMMOCGDANO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			private bool <isReloadingSceneForObjectModel>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			private bool <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			private LBOAMJIDFHD <timedYielder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			private TaskAwaiter<MDNHMBFDALB> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x4EB4D70", Offset = "0x4EB3D70", VA = "0x184EB4D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CCGGKNOLNJA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public KMGKAPJIBHJ preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public KMGKAPJIBHJ downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public IODHGACPIHP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public KMGKAPJIBHJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public OFIMLBDMAME phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public LELBODDNBJP.BCEIMCNOHBP <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MGMMOCGDANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x3B05DC0", Offset = "0x3B04DC0", VA = "0x183B05DC0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<IODHGACPIHP> NFPBOJBFAJA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x3B05B00", Offset = "0x3B04B00", VA = "0x183B05B00")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<OFIMLBDMAME> DGDNMFJECBN(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x3B05F30", Offset = "0x3B04F30", VA = "0x183B05F30")]
		internal void NLCOFMADFDB(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x3B05C70", Offset = "0x3B04C70", VA = "0x183B05C70")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task MJIPACKILOG(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class CCBEFJODKLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public CCGGKNOLNJA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private MGMMOCGDANO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private IODHGACPIHP <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private OFIMLBDMAME <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private TaskAwaiter<IODHGACPIHP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter<OFIMLBDMAME> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CCBEFJODKLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x3818F50", Offset = "0x3817F50", VA = "0x183818F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class FFMGAHIFGBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public FFMGAHIFGBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x381C170", Offset = "0x381B170", VA = "0x18381C170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class AELCANEKGGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public KMGKAPJIBHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private TaskAwaiter<MDNHMBFDALB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AELCANEKGGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x3816F60", Offset = "0x3815F60", VA = "0x183816F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class NLENOAGIDFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public AsyncTaskMethodBuilder<MDNHMBFDALB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public LBOAMJIDFHD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public KMGKAPJIBHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private TaskAwaiter<MDNHMBFDALB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NLENOAGIDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x3B06980", Offset = "0x3B05980", VA = "0x183B06980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class PBBECFAOEJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public AsyncTaskMethodBuilder<MDNHMBFDALB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public LBOAMJIDFHD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public KMGKAPJIBHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private TaskAwaiter<MDNHMBFDALB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public PBBECFAOEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x3B09580", Offset = "0x3B08580", VA = "0x183B09580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class CJPCEMCJDHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public AsyncTaskMethodBuilder<MDNHMBFDALB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public MDNHMBFDALB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public OFIMLBDMAME deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public KMGKAPJIBHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private MDNHMBFDALB <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private MDNHMBFDALB <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private TaskAwaiter<MDNHMBFDALB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CJPCEMCJDHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x381A750", Offset = "0x3819750", VA = "0x18381A750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class MOMKLDJEAHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public KMGKAPJIBHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public BBMLLBCIDED masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public LBOAMJIDFHD timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MOMKLDJEAHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class ONFFACPFPKI
	{
		[Cpp2IlInjected.Token(Token = "0x2000143")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005AB")]
			public AsyncTaskMethodBuilder<MDNHMBFDALB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005AC")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			public ONFFACPFPKI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			private IDisposable <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			private MDNHMBFDALB <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			private MDNHMBFDALB <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			private TaskAwaiter<MDNHMBFDALB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x4EB6F20", Offset = "0x4EB5F20", VA = "0x184EB6F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public MDNHMBFDALB originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public MOMKLDJEAHC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ONFFACPFPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x3B09240", Offset = "0x3B08240", VA = "0x183B09240")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<MDNHMBFDALB> FLDPJGPGLBC(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class JGFJDNCJEEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public AsyncTaskMethodBuilder<MDNHMBFDALB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public LBOAMJIDFHD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public KMGKAPJIBHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public BBMLLBCIDED masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private MOMKLDJEAHC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private ONFFACPFPKI <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private MDNHMBFDALB <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private TaskAwaiter<MDNHMBFDALB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JGFJDNCJEEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x3B03560", Offset = "0x3B02560", VA = "0x183B03560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class MFADFCOMAHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public KMGKAPJIBHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private MDNHMBFDALB <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private IEnumerator<MDNHMBFDALB> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private MDNHMBFDALB <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private TaskAwaiter<MDNHMBFDALB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MFADFCOMAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x3B05700", Offset = "0x3B04700", VA = "0x183B05700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class AFAGEIPBHAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AFAGEIPBHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x3817560", Offset = "0x3816560", VA = "0x183817560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class FEGALMOAMCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public KIKKPADFBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public FEGALMOAMCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x381C020", Offset = "0x381B020", VA = "0x18381C020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private readonly DPLHGKBKOHE BGEKAPPKFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private readonly DPLHGKBKOHE OIKCMOINKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private readonly KNGIAEBKBLN NEHHPMGHOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private readonly FBOHCIHKOCF ICIDCOJFOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private readonly JGAKJNAGHCK KJGMHNFDEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private readonly ILGLECHNODC PLJJJJJDHJC;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float NLDICEFGDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x20F1CC0", Offset = "0x20F0CC0", VA = "0x1820F1CC0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private DICEJLBHJCH DJBMKEADGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x20F29C0", Offset = "0x20F19C0", VA = "0x1820F29C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event INOPMOLMKKF MNEIFIJIAME
	{
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x20F29A0", Offset = "0x20F19A0", VA = "0x1820F29A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x20F2260", Offset = "0x20F1260", VA = "0x1820F2260", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x20F3310", Offset = "0x20F2310", VA = "0x1820F3310")]
	public KIKKPADFBCP(HEPJBIGMLHA OAAPCIHIIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x20F2280", Offset = "0x20F1280", VA = "0x1820F2280")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NMEPGNEMCLK))]
	public Task JHELIMDKBNB(CCGGKNOLNJA CFOFEENKFCN, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x20F2BF0", Offset = "0x20F1BF0", VA = "0x1820F2BF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PIHDOEAEJII))]
	private Task<OCLNBBADIAK> PCNNBLCKNBL(CCGGKNOLNJA CFOFEENKFCN, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x20F1340", Offset = "0x20F0340", VA = "0x1820F1340")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HNHEJJHPOBC))]
	private Task BHGOHEHGEFJ(CCGGKNOLNJA CFOFEENKFCN, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x20F1B20", Offset = "0x20F0B20", VA = "0x1820F1B20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CCBEFJODKLK))]
	private Task FFJLLAGOOCD(CCGGKNOLNJA CFOFEENKFCN, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken ABHHEIOALKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x20F2830", Offset = "0x20F1830", VA = "0x1820F2830")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FFMGAHIFGBF))]
	private Task LGPJKOAILEC(MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x20F17A0", Offset = "0x20F07A0", VA = "0x1820F17A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AELCANEKGGE))]
	private Task DJANIJJAFKD(OFIMLBDMAME HHCEHFFEAKN, KMGKAPJIBHJ HEHNPOGOANF, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x20F1E80", Offset = "0x20F0E80", VA = "0x1820F1E80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NLENOAGIDFO))]
	private Task<MDNHMBFDALB> HEDMBOFMJFK(OFIMLBDMAME HHCEHFFEAKN, LBOAMJIDFHD EKBIPMNLNGI, KMGKAPJIBHJ HEHNPOGOANF, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x20F2620", Offset = "0x20F1620", VA = "0x1820F2620")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBBECFAOEJF))]
	private Task<MDNHMBFDALB> LFLOAOKDMCG(OFIMLBDMAME HHCEHFFEAKN, LBOAMJIDFHD EKBIPMNLNGI, KMGKAPJIBHJ HEHNPOGOANF, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x20F14E0", Offset = "0x20F04E0", VA = "0x1820F14E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CJPCEMCJDHA))]
	private Task<MDNHMBFDALB> CKHJJHAJIFN(MDNHMBFDALB BFIEPCPKGPI, OFIMLBDMAME FKLBIBPMBFA, KMGKAPJIBHJ HEHNPOGOANF, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC, bool GGCGKIHABDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x20F20E0", Offset = "0x20F10E0", VA = "0x1820F20E0")]
	private bool HMGEKHGIMMN(OFIMLBDMAME LCHLENCLGAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x20F2F20", Offset = "0x20F1F20", VA = "0x1820F2F20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGFJDNCJEEG))]
	protected Task<MDNHMBFDALB> PIHEBBMLGBN(OFIMLBDMAME HHCEHFFEAKN, LBOAMJIDFHD EKBIPMNLNGI, KMGKAPJIBHJ HEHNPOGOANF, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC, BBMLLBCIDED HNGEBGMFBNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x20F1960", Offset = "0x20F0960", VA = "0x1820F1960")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFADFCOMAHL))]
	private Task EFJADONIKFG(OFIMLBDMAME HHCEHFFEAKN, KMGKAPJIBHJ HEHNPOGOANF, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x20F2090", Offset = "0x20F1090", VA = "0x1820F2090")]
	private void HEJBEBLFPGJ(MDNHMBFDALB PBGGGGPPPPE, KMGKAPJIBHJ HEHNPOGOANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x20F2420", Offset = "0x20F1420", VA = "0x1820F2420")]
	private void JPPLFCIMPPN(MDNHMBFDALB PFHODLEMNEN, out MDNHMBFDALB NEJJAIFBLDG, out MDNHMBFDALB BLBLAKMPLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x20F2B80", Offset = "0x20F1B80", VA = "0x1820F2B80")]
	private Task<IODHGACPIHP> OPEOFLDPAJK(CCGGKNOLNJA CFOFEENKFCN, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x20F2220", Offset = "0x20F1220", VA = "0x1820F2220")]
	private Task<OFIMLBDMAME> IJNCDKGOKJK(IODHGACPIHP HHCEHFFEAKN, LELBODDNBJP.BCEIMCNOHBP JLDFEGPNHDI, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x20F3150", Offset = "0x20F2150", VA = "0x1820F3150")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AFAGEIPBHAG))]
	private Task PKHJEKIOEOF(OFIMLBDMAME HHCEHFFEAKN, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC, bool ALLFCCHJDGD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x20F2DB0", Offset = "0x20F1DB0", VA = "0x1820F2DB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FEGALMOAMCO))]
	private Task PGBDPKPHFEP(OFIMLBDMAME HHCEHFFEAKN, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x20F2BC0", Offset = "0x20F1BC0", VA = "0x1820F2BC0")]
	private Task PACHIBNFIAH(OFIMLBDMAME HHCEHFFEAKN, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x20F2200", Offset = "0x20F1200", VA = "0x1820F2200")]
	private Task IDIPMELEIFD(OFIMLBDMAME HHCEHFFEAKN, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x20F1CE0", Offset = "0x20F0CE0", VA = "0x1820F1CE0")]
	private Task GANLMNOPEPK(OFIMLBDMAME HHCEHFFEAKN, LBOAMJIDFHD EKBIPMNLNGI, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x20F2460", Offset = "0x20F1460", VA = "0x1820F2460")]
	private Task KNCAMNODDON(OFIMLBDMAME HHCEHFFEAKN, LBOAMJIDFHD EKBIPMNLNGI, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x20E1D80", Offset = "0x20E0D80", VA = "0x1820E1D80")]
	private static Task PIMFMDJAKME(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x20F21E0", Offset = "0x20F11E0", VA = "0x1820F21E0")]
	private Task IDBDPAKPBLA(OFIMLBDMAME HHCEHFFEAKN, LBOAMJIDFHD EKBIPMNLNGI, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x20F29F0", Offset = "0x20F19F0", VA = "0x1820F29F0")]
	private Task OAEAFIIOGDB(OFIMLBDMAME HHCEHFFEAKN, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x20F12C0", Offset = "0x20F02C0", VA = "0x1820F12C0")]
	private void BBPLPHDMBFG(CCGGKNOLNJA CFOFEENKFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x20F16F0", Offset = "0x20F06F0", VA = "0x1820F16F0")]
	public void DADCHJEKJFK(long NECHDOJFBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	private static void AGHJPKOAKOP(EAHJJHFFELH IMNFFHILDHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal abstract class HNNFLHMGLEJ : JMKFEAIOBKO
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public delegate Task IPHOGLHFGHC(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class BCINAHEIBPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public HNNFLHMGLEJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BCINAHEIBPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x38189E0", Offset = "0x38179E0", VA = "0x1838189E0")]
		internal Task KAMHOGBDKNE(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class OCEBGOKHDOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public BCINAHEIBPN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OCEBGOKHDOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x3828630", Offset = "0x3827630", VA = "0x183828630")]
		internal object GPJJGCONNOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x3828570", Offset = "0x3827570", VA = "0x183828570")]
		internal object DDHPOMABOEN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class MDIDDPHJJAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public Func<HNNFLHMGLEJ, MNKIABAIHBN<string>.JJAEKMMDGKH, HEPJBIGMLHA> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public HNNFLHMGLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private BCINAHEIBPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private HEPJBIGMLHA <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private OCLNBBADIAK <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private OCEBGOKHDOF <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private TaskAwaiter<OCLNBBADIAK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MDIDDPHJJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x3824F10", Offset = "0x3823F10", VA = "0x183824F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class LNAHBLFBKGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public HNNFLHMGLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private IPHOGLHFGHC <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LNAHBLFBKGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x3823F60", Offset = "0x3822F60", VA = "0x183823F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public readonly Guid ALPGHNGJHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	public readonly ByteString NMKDHMPJLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	public readonly DMMCOJOPIJA HKHOLGJLPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	protected readonly string CNIGBEKECCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private readonly DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private readonly bool GPCINMPCPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private readonly Queue<IPHOGLHFGHC> GCDGDDALHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private readonly KMGKAPJIBHJ IAFFDMLHGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private readonly NOBDFJFKCAB BEAPEJKINEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private bool MHKNLPPMIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	public MDNHMBFDALB LMDPEOMAFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	public MDNHMBFDALB FNDNGKKICPH;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public DICEJLBHJCH DJBMKEADGAH
	{
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x871190", Offset = "0x870190", VA = "0x180871190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public HJNEIHJIJJJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x20ECD40", Offset = "0x20EBD40", VA = "0x1820ECD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public EDKKLBPKLAF DIHJJHPNMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x20ECD90", Offset = "0x20EBD90", VA = "0x1820ECD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public KCMAHJPHMBH CGILCLDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x20ED270", Offset = "0x20EC270", VA = "0x1820ED270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public float NLDICEFGDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x20ED250", Offset = "0x20EC250", VA = "0x1820ED250", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event INOPMOLMKKF MNEIFIJIAME
	{
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x20ED5A0", Offset = "0x20EC5A0", VA = "0x1820ED5A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x20ED4A0", Offset = "0x20EC4A0", VA = "0x1820ED4A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x20ED780", Offset = "0x20EC780", VA = "0x1820ED780")]
	protected HNNFLHMGLEJ(Guid MLHJIHFFCGB, DICEJLBHJCH FGIILGHEHMH, DMMCOJOPIJA LONIOFFJBLO, string BJNOIEBCOFJ, NOBDFJFKCAB BEAPEJKINEL, bool GPCINMPCPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x20ED2F0", Offset = "0x20EC2F0", VA = "0x1820ED2F0", Slot = "7")]
	protected virtual string IAMDNFFLALJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x20ECDE0", Offset = "0x20EBDE0", VA = "0x1820ECDE0")]
	public void CLJAMGAHFMJ(IPHOGLHFGHC GAAPIIBPFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x20ED5C0", Offset = "0x20EC5C0", VA = "0x1820ED5C0")]
	protected void PEFIEGGMAGC(float EHLDPLPLJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x20ED5E0", Offset = "0x20EC5E0", VA = "0x1820ED5E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MDIDDPHJJAF))]
	public Task PLLHAMBOEGA(CancellationToken OAGBBBCDIGC, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, [Optional] Func<HNNFLHMGLEJ, MNKIABAIHBN<string>.JJAEKMMDGKH, HEPJBIGMLHA> NGGHADFOOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x20ECE40", Offset = "0x20EBE40", VA = "0x1820ECE40")]
	private void EEKELDJNLMI(bool DHPCHJKOPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x20ECFC0", Offset = "0x20EBFC0", VA = "0x1820ECFC0")]
	private void FAGLFDLIFHB(HEPJBIGMLHA OAAPCIHIIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task OMAJKGPPIHI(HEPJBIGMLHA OAAPCIHIIOO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x20ED330", Offset = "0x20EC330", VA = "0x1820ED330")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNAHBLFBKGI))]
	private Task ICANABLHOHN(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x20ECCB0", Offset = "0x20EBCB0", VA = "0x1820ECCB0")]
	public OCLNBBADIAK BLNKHOINFLE(HKGOHLMLBJL OIFHGNGFIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x20ED4C0", Offset = "0x20EC4C0", VA = "0x1820ED4C0")]
	[CompilerGenerated]
	private Task JGKJLFNFHOE(CancellationToken EBIGDBKBHOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal abstract class GBPMOJNFGLC : HNNFLHMGLEJ
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class EGIMKIDEHJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public GBPMOJNFGLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public MHPHGODLEFI playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public EGIMKIDEHJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x381BF60", Offset = "0x381AF60", VA = "0x18381BF60")]
		internal Task CFFCNLMEMHL(MNKIABAIHBN<string>.JJAEKMMDGKH postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x381BFA0", Offset = "0x381AFA0", VA = "0x18381BFA0")]
		internal object JFEAFNMMIGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class JDPEGABEAKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public GBPMOJNFGLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private EGIMKIDEHJL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private AOAGEGKHCPM <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JDPEGABEAKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x3820BF0", Offset = "0x381FBF0", VA = "0x183820BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class DJGJCCFKNBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public MHPHGODLEFI playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public GBPMOJNFGLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public DJGJCCFKNBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x381BA40", Offset = "0x381AA40", VA = "0x18381BA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x20E87F0", Offset = "0x20E77F0", VA = "0x1820E87F0")]
	public GBPMOJNFGLC(Guid MLHJIHFFCGB, DICEJLBHJCH FGIILGHEHMH, DMMCOJOPIJA LONIOFFJBLO, string BJNOIEBCOFJ, NOBDFJFKCAB BEAPEJKINEL, bool GPCINMPCPNE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x20E8650", Offset = "0x20E7650", VA = "0x1820E8650", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JDPEGABEAKO))]
	protected override Task OMAJKGPPIHI(HEPJBIGMLHA OAAPCIHIIOO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task EGINDJDILCF(HEPJBIGMLHA OAAPCIHIIOO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x20E84B0", Offset = "0x20E74B0", VA = "0x1820E84B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJGJCCFKNBI))]
	private Task JCHDFACGNAJ(IDisposable AFJAAICLGFL, MHPHGODLEFI OCJGAOJLJAH, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
public readonly struct JNMBCFANFLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	public readonly OCMKINIOLDE? LEHIKMCFIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	public readonly GODPKLEFLAE DHCBCMBCLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	public readonly string? AJELINHJFGD;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IReadOnlyCollection<string> EMLHLHPPOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x20EFF60", Offset = "0x20EEF60", VA = "0x1820EFF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public IReadOnlyDictionary<long, int> HDOPHAKKCNH
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x20EFF80", Offset = "0x20EEF80", VA = "0x1820EFF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x20EFFA0", Offset = "0x20EEFA0", VA = "0x1820EFFA0")]
	public JNMBCFANFLA(OCMKINIOLDE? CAPINCBBCIM, GODPKLEFLAE GCKGELGOEDG, string? BJIEMONJOEI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct LCIFHGPMPPM
{
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class IMDECCFDIOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private HNNFLHMGLEJ <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private DICEJLBHJCH <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private DPFKDGMPIHI.FCDHHNABMKA <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private TaskAwaiter<OCLNBBADIAK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IMDECCFDIOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x3B01D40", Offset = "0x3B00D40", VA = "0x183B01D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class LFNJHMGIPMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LFNJHMGIPMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x3B04C20", Offset = "0x3B03C20", VA = "0x183B04C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x2715DE0", Offset = "0x2714DE0", VA = "0x182715DE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IMDECCFDIOM))]
	public static Task PLLHAMBOEGA(HEPJBIGMLHA OAAPCIHIIOO, OFIMLBDMAME HHCEHFFEAKN, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x2715D70", Offset = "0x2714D70", VA = "0x182715D70")]
	private static Task<OCLNBBADIAK> NIKCPDHODGL(HEPJBIGMLHA OAAPCIHIIOO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x2715C70", Offset = "0x2714C70", VA = "0x182715C70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LFNJHMGIPMF))]
	private static Task MLPAPGNIEDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal class HBEFAIEENBH : HNNFLHMGLEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class IHHBJALCMHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public HBEFAIEENBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private ObscuredInt <localPlayerAccountId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private OIMBOADDECM <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private JNMBCFANFLA <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private NNMKFKJCKPG <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private CEIPMKNCAPB <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private TaskAwaiter<CEIPMKNCAPB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IHHBJALCMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x381F200", Offset = "0x381E200", VA = "0x18381F200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private readonly int NGKGEEPAIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private readonly MCFPGIBLJJO MFDMMJHLBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	public readonly long PDGJGDFJBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	public readonly long PFKIANLDBJO;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public CEIPMKNCAPB NELONHDANJK
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x9AD920", Offset = "0x9AC920", VA = "0x1809AD920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xA23960", Offset = "0xA22960", VA = "0x180A23960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x20E9930", Offset = "0x20E8930", VA = "0x1820E9930")]
	public HBEFAIEENBH(Guid MLHJIHFFCGB, DICEJLBHJCH FGIILGHEHMH, DMMCOJOPIJA LONIOFFJBLO, int NGKGEEPAIDK, MCFPGIBLJJO MFDMMJHLBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x20E9790", Offset = "0x20E8790", VA = "0x1820E9790", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IHHBJALCMHL))]
	protected override Task OMAJKGPPIHI(HEPJBIGMLHA OAAPCIHIIOO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct JGAKJNAGHCK
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private sealed class CDKNDJBEMEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public AsyncTaskMethodBuilder<MDNHMBFDALB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public MDNHMBFDALB nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public OFIMLBDMAME deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public JGAKJNAGHCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private MDNHMBFDALB <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private TaskAwaiter<MDNHMBFDALB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CDKNDJBEMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x3819CA0", Offset = "0x3818CA0", VA = "0x183819CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class INNINKIOKGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public AsyncTaskMethodBuilder<MDNHMBFDALB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public MDNHMBFDALB state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public JGAKJNAGHCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private OCLNBBADIAK <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private OCLNBBADIAK <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private MDNHMBFDALB <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private OCLNBBADIAK <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private TaskAwaiter<OCLNBBADIAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public INNINKIOKGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x381FF60", Offset = "0x381EF60", VA = "0x18381FF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private readonly HEPJBIGMLHA OAAPCIHIIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private readonly KNGIAEBKBLN NEHHPMGHOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private readonly FBOHCIHKOCF ICIDCOJFOND;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private HNNFLHMGLEJ KNPNLKLENFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x20EF240", Offset = "0x20EE240", VA = "0x1820EF240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x20EF260", Offset = "0x20EE260", VA = "0x1820EF260")]
	public JGAKJNAGHCK(HEPJBIGMLHA OAAPCIHIIOO, KNGIAEBKBLN NEHHPMGHOON, FBOHCIHKOCF ICIDCOJFOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x20EEE40", Offset = "0x20EDE40", VA = "0x1820EEE40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CDKNDJBEMEN))]
	public Task<MDNHMBFDALB> FMIGCKJIHEP(MDNHMBFDALB MGPPOMEFDOF, OFIMLBDMAME FKLBIBPMBFA, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC, bool GGCGKIHABDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x20EF070", Offset = "0x20EE070", VA = "0x1820EF070")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(INNINKIOKGG))]
	private Task<MDNHMBFDALB> NOBOHIBINFN(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, MDNHMBFDALB CILNOBBJOLD, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x20EF040", Offset = "0x20EE040", VA = "0x1820EF040")]
	private bool HCEJMNIMDBO(MDNHMBFDALB ECDDGLPMEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x20EEE20", Offset = "0x20EDE20", VA = "0x1820EEE20")]
	private void AHJGPEGCGMK(string BKCPGKELHMO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct JEJICEHBBAM
{
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class POFOECJMBCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public LBOAMJIDFHD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private HNNFLHMGLEJ <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private MDNHMBFDALB <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private DICEJLBHJCH <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private HJNEIHJIJJJ <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private EGHAHIAACBN <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private IDisposable <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private List<(PersistenceView, NEMHKEECLGO)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private NEMHKEECLGO <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public POFOECJMBCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x3829750", Offset = "0x3828750", VA = "0x183829750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x20EE640", Offset = "0x20ED640", VA = "0x1820EE640")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(POFOECJMBCG))]
	public static Task PLLHAMBOEGA(HEPJBIGMLHA OAAPCIHIIOO, OFIMLBDMAME HHCEHFFEAKN, LBOAMJIDFHD EKBIPMNLNGI, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x20EE430", Offset = "0x20ED430", VA = "0x1820EE430")]
	private static void BLHDKCJOKLO(PersistenceView ILDIOIFMEIG, NEMHKEECLGO KOBLBILBKMA, OFIMLBDMAME HHCEHFFEAKN, MDNHMBFDALB BFIEPCPKGPI, bool BGJAPJGNABD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal class EGIKMCBHEPN : IPGDAGIOAKM
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class CDFDNDMIJKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder<JNMBCFANFLA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public DHDFPEDJJBO roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public CAMHKKGEKKA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public EGIKMCBHEPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private StringBuilder <outputBuilder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CDFDNDMIJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x270FC00", Offset = "0x270EC00", VA = "0x18270FC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class GGJGLDCHHIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public CAMHKKGEKKA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public EGIKMCBHEPN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GGJGLDCHHIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x2711770", Offset = "0x2710770", VA = "0x182711770")]
		internal Task DLPLFKGGIEJ(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x27119B0", Offset = "0x27109B0", VA = "0x1827119B0")]
		internal Task OMIHFPPOCPH(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class APGCIOJFFLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public GGJGLDCHHIB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public APGCIOJFFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x270DE40", Offset = "0x270CE40", VA = "0x18270DE40")]
		internal object JEFBKOJKEOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class KHBBPIFJICE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public GGJGLDCHHIB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KHBBPIFJICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x27147B0", Offset = "0x27137B0", VA = "0x1827147B0")]
		internal Task LMMOJBPHMAD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class EBFLMOEJICH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public CAMHKKGEKKA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public EGIKMCBHEPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private GGJGLDCHHIB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private APGCIOJFFLB <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public EBFLMOEJICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x2710940", Offset = "0x270F940", VA = "0x182710940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private readonly HEHEJCDOEDL HGLKINMLAIG;

	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private static readonly TimeSpan HBIKFKOCEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly HIHMNJNPEEO JCIKBHIGFAM;

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x20E5DF0", Offset = "0x20E4DF0", VA = "0x1820E5DF0")]
	public EGIKMCBHEPN(HEPJBIGMLHA OAAPCIHIIOO, HIHMNJNPEEO JCIKBHIGFAM, HPPHLHFLMDP CGJPMMKJEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x20E5BA0", Offset = "0x20E4BA0", VA = "0x1820E5BA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CDFDNDMIJKG))]
	public Task<JNMBCFANFLA> IKBIGFALLCH(long FKNCEBBDENC, DHDFPEDJJBO AHLGOBEDBND, CAMHKKGEKKA JDCEJMEBGBH, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x20E4AE0", Offset = "0x20E3AE0", VA = "0x1820E4AE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EBFLMOEJICH))]
	private Task BAMLBLPALJD(CAMHKKGEKKA JDCEJMEBGBH, IEnumerable<PersistenceView> OOGMCHDKBFJ, StringBuilder PKEHIBFNIPM, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x20E5540", Offset = "0x20E4540", VA = "0x1820E5540")]
	private JNMBCFANFLA HMHHHAAHLPD(long FKNCEBBDENC, DHDFPEDJJBO AHLGOBEDBND, CAMHKKGEKKA JDCEJMEBGBH, IEnumerable<PersistenceView> OOGMCHDKBFJ, StringBuilder PKEHIBFNIPM)
	{
		return default(JNMBCFANFLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x20E53C0", Offset = "0x20E43C0", VA = "0x1820E53C0")]
	private OCMKINIOLDE EEPPKHLGMJE(long FKNCEBBDENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x20E4CA0", Offset = "0x20E3CA0", VA = "0x1820E4CA0")]
	private void CFIIEPNNKFP(OCMKINIOLDE AHGOBAJBCFJ, StringBuilder PKEHIBFNIPM, IEnumerable<PersistenceView> OOGMCHDKBFJ, in LLMHCANKMFI NGJHIEDBEAD, DGIFJGGKCPG EINJEFOEKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x20E4EB0", Offset = "0x20E3EB0", VA = "0x1820E4EB0")]
	private void EEJJIPDAIAF(OCMKINIOLDE AHGOBAJBCFJ, StringBuilder PKEHIBFNIPM, PersistenceView ILDIOIFMEIG, ref DGIFJGGKCPG EINJEFOEKPE, in LLMHCANKMFI NGJHIEDBEAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal class EIKGFPEMACB : HNNFLHMGLEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class BONLCGJEAAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public EIKGFPEMACB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private DHDFPEDJJBO <roomSaveOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private EGIKMCBHEPN <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private CAMHKKGEKKA <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private JNMBCFANFLA <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private JNMBCFANFLA <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private TaskAwaiter<JNMBCFANFLA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BONLCGJEAAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x270E7C0", Offset = "0x270D7C0", VA = "0x18270E7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly FALKJMEJPBK DDBBBGFMPLN;

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x20E6100", Offset = "0x20E5100", VA = "0x1820E6100")]
	public EIKGFPEMACB(Guid MLHJIHFFCGB, DICEJLBHJCH FGIILGHEHMH, DMMCOJOPIJA LONIOFFJBLO, FALKJMEJPBK DDBBBGFMPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x20E5E80", Offset = "0x20E4E80", VA = "0x1820E5E80", Slot = "7")]
	protected override string IAMDNFFLALJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x20E5F60", Offset = "0x20E4F60", VA = "0x1820E5F60", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BONLCGJEAAN))]
	protected override Task OMAJKGPPIHI(HEPJBIGMLHA OAAPCIHIIOO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct FKMCDGDKLLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	public Dictionary<Guid, List<PMICGCMMAGB>> LBAABCDCMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	public Dictionary<Guid, List<PMICGCMMAGB>> NNCPLHAOLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	public Dictionary<Guid, List<PMICGCMMAGB>> LCKADAGIAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	public List<Guid> NOAJFLLPENL;

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x20E7CE0", Offset = "0x20E6CE0", VA = "0x1820E7CE0")]
	public static FKMCDGDKLLL FLFDNJDANPO(HJNEIHJIJJJ IFMMICNCAOG, MDNHMBFDALB BFIEPCPKGPI, OFIMLBDMAME FKLBIBPMBFA)
	{
		return default(FKMCDGDKLLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public readonly struct DBGEFAOHMNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	public readonly bool FBDFFPKAKNP;

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x1B30280", Offset = "0x1B2F280", VA = "0x181B30280")]
	public DBGEFAOHMNO(bool GAIPOOOELJF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct OMLAGFHEDHL
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class HHHFJBBKMJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public HNNFLHMGLEJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public LBOAMJIDFHD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private MDNHMBFDALB <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private List<(PersistenceView, NEMHKEECLGO)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private (PersistenceView, NEMHKEECLGO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private HADKFFAFLDM <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HHHFJBBKMJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF9E0", Offset = "0x4EAE9E0", VA = "0x184EAF9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x27223B0", Offset = "0x27213B0", VA = "0x1827223B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HHHFJBBKMJP))]
	public static Task PLLHAMBOEGA(HNNFLHMGLEJ KIDKAIDKLIB, OFIMLBDMAME HHCEHFFEAKN, LBOAMJIDFHD EKBIPMNLNGI, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal struct KPNCKGDMPAP
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class GALFPJLEDMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public AsyncTaskMethodBuilder<OFIMLBDMAME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public LELBODDNBJP.BCEIMCNOHBP downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public KPNCKGDMPAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private Task<EEONHCOMEMH<MDCFFKCLDEA, JINHIJEHMKF>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private Task<EEONHCOMEMH<KDFENHBNPBD<OCMKINIOLDE>, JINHIJEHMKF>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private Task<EEONHCOMEMH<KDFENHBNPBD<EOMDDKFOOGO>, JINHIJEHMKF>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private Task<EEONHCOMEMH<KDFENHBNPBD<FKAJNCHGFNH>, JINHIJEHMKF>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private Task<(EEONHCOMEMH<MDCFFKCLDEA, JINHIJEHMKF>, EEONHCOMEMH<KDFENHBNPBD<OCMKINIOLDE>, JINHIJEHMKF>, EEONHCOMEMH<KDFENHBNPBD<EOMDDKFOOGO>, JINHIJEHMKF>, EEONHCOMEMH<KDFENHBNPBD<FKAJNCHGFNH>, JINHIJEHMKF>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private EEONHCOMEMH<MDCFFKCLDEA, JINHIJEHMKF> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private EEONHCOMEMH<KDFENHBNPBD<OCMKINIOLDE>, JINHIJEHMKF> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private EEONHCOMEMH<KDFENHBNPBD<EOMDDKFOOGO>, JINHIJEHMKF> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private EEONHCOMEMH<KDFENHBNPBD<FKAJNCHGFNH>, JINHIJEHMKF> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private KDFENHBNPBD<OCMKINIOLDE> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private (EEONHCOMEMH<MDCFFKCLDEA, JINHIJEHMKF>, EEONHCOMEMH<KDFENHBNPBD<OCMKINIOLDE>, JINHIJEHMKF>, EEONHCOMEMH<KDFENHBNPBD<EOMDDKFOOGO>, JINHIJEHMKF>, EEONHCOMEMH<KDFENHBNPBD<FKAJNCHGFNH>, JINHIJEHMKF>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private (EEONHCOMEMH<MDCFFKCLDEA, JINHIJEHMKF>, EEONHCOMEMH<KDFENHBNPBD<OCMKINIOLDE>, JINHIJEHMKF>, EEONHCOMEMH<KDFENHBNPBD<EOMDDKFOOGO>, JINHIJEHMKF>, EEONHCOMEMH<KDFENHBNPBD<FKAJNCHGFNH>, JINHIJEHMKF>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private TaskAwaiter<(EEONHCOMEMH<MDCFFKCLDEA, JINHIJEHMKF>, EEONHCOMEMH<KDFENHBNPBD<OCMKINIOLDE>, JINHIJEHMKF>, EEONHCOMEMH<KDFENHBNPBD<EOMDDKFOOGO>, JINHIJEHMKF>, EEONHCOMEMH<KDFENHBNPBD<FKAJNCHGFNH>, JINHIJEHMKF>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GALFPJLEDMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE580", Offset = "0x3AFD580", VA = "0x183AFE580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class NPBBMFGECDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public AsyncTaskMethodBuilder<EEONHCOMEMH<MDCFFKCLDEA, JINHIJEHMKF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public LELBODDNBJP.BCEIMCNOHBP downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public KPNCKGDMPAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private EEONHCOMEMH<MDCFFKCLDEA, JINHIJEHMKF> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private TaskAwaiter<EEONHCOMEMH<MDCFFKCLDEA, JINHIJEHMKF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NPBBMFGECDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x3B07980", Offset = "0x3B06980", VA = "0x183B07980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	private DEHFNCCELNE<PLLPALDIOHF, EOMDDKFOOGO> PCGHMPFPEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	private DEHFNCCELNE<PLLPALDIOHF, OCMKINIOLDE> NHKFFLAMMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private DEHFNCCELNE<long, FKAJNCHGFNH> NDPJOOEFEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private PGJBGAMIGNP IGFFIIMOHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private EAHJJHFFELH IMNFFHILDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private MEKHHBDIOBK GJFGJIAPFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private string BJIEMONJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private PLLPALDIOHF PLNEIMJEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private PLLPALDIOHF NEHMEKKOIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private long NECHDOJFBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA;

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x2714D30", Offset = "0x2713D30", VA = "0x182714D30")]
	public static Task<OFIMLBDMAME> DOEKGINBLNE(DICEJLBHJCH FGIILGHEHMH, in IODHGACPIHP HHCEHFFEAKN, LELBODDNBJP.BCEIMCNOHBP JLDFEGPNHDI, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x27152C0", Offset = "0x27142C0", VA = "0x1827152C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GALFPJLEDMB))]
	private Task<OFIMLBDMAME> PLLHAMBOEGA(LELBODDNBJP.BCEIMCNOHBP JLDFEGPNHDI, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x2715090", Offset = "0x2714090", VA = "0x182715090")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NPBBMFGECDO))]
	private Task<EEONHCOMEMH<MDCFFKCLDEA, JINHIJEHMKF>> FAPPGONGGJH(string BJIEMONJOEI, long NECHDOJFBMC, LELBODDNBJP.BCEIMCNOHBP JLDFEGPNHDI, MNKIABAIHBN<string>.JJAEKMMDGKH NLFKPNMIBNJ, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
public class KNGIAEBKBLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private readonly PCCHDNKCHLM HMMPBPFEOMA;

	[Cpp2IlInjected.Token(Token = "0x40006EB")]
	private const string AIDMGDJGEEI = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	private const string EILFAJIAPIB = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40006ED")]
	private const string NACNAKKIKPG = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40006EE")]
	private const string MJOKNHGLIAB = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	private const string PEJKHBFMMGL = "RL_LastLoadedRoomInstanceId";

	[Cpp2IlInjected.Token(Token = "0x40006F0")]
	private const string PGOIICAEBGF = "RL_LastHeartbeatSessionData";

	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private const string HAEMKLFAMJL = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private string BKJNHOJGOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	private long? HNFHFAOOMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private long? GFHECAPCAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private long? LLBMMNGMANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	private string LMMPEIOFLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	private MDNHMBFDALB FLLLIELAHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private long? KAHINAPBEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006F9")]
	private bool CLIOMDMKEHK;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public string ECKAIHNJCMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public long BHHFMPIGOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x20F82B0", Offset = "0x20F72B0", VA = "0x1820F82B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public long IBFNFMLIGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x20F8600", Offset = "0x20F7600", VA = "0x1820F8600")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public long JHOCBEPANAO
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x20F8310", Offset = "0x20F7310", VA = "0x1820F8310")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public string MLPCGEHLNDN
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x20F9010", Offset = "0x20F8010", VA = "0x1820F9010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public MDNHMBFDALB PKLDKPADMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x907770", Offset = "0x906770", VA = "0x180907770")]
		get
		{
			return default(MDNHMBFDALB);
		}
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x20F8660", Offset = "0x20F7660", VA = "0x1820F8660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public long JIHDHMBFFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x20F8B90", Offset = "0x20F7B90", VA = "0x1820F8B90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x20F9050", Offset = "0x20F8050", VA = "0x1820F9050")]
	[UnityEngine.Scripting.Preserve]
	public KNGIAEBKBLN([JFLEHDEIONF(null)] PCCHDNKCHLM HMMPBPFEOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x20F83F0", Offset = "0x20F73F0", VA = "0x1820F83F0")]
	private void FBOCIEFBJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x20F8740", Offset = "0x20F7740", VA = "0x1820F8740")]
	public void HHJHILIDOLE(long IHGIEILPMCA, long FKNCEBBDENC, [Optional] long? NECHDOJFBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x20F8F70", Offset = "0x20F7F70", VA = "0x1820F8F70")]
	public void NFBFDGGPFCL(long NECHDOJFBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x20F8370", Offset = "0x20F7370", VA = "0x1820F8370")]
	public void DJHCBGIJFFM(string OHGPHGCAIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x20F8BF0", Offset = "0x20F7BF0", VA = "0x1820F8BF0")]
	public void LODEGNKCJGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal sealed class PPGAOMKJBNI : HNNFLHMGLEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class ACAKMPILOJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ACAKMPILOJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC060", Offset = "0x4EAB060", VA = "0x184EAC060")]
		internal object CKJNPEBKMCD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class EMJCGMKPFFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public PPGAOMKJBNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private MGFPBFIAOAF <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private KIKKPADFBCP <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public EMJCGMKPFFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x4EAE760", Offset = "0x4EAD760", VA = "0x184EAE760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class NHOPAMLHDEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public PPGAOMKJBNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private byte <omSaveVersion>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private bool <omIsEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private byte <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private TaskAwaiter<byte> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NHOPAMLHDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2590", Offset = "0x4EB1590", VA = "0x184EB2590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private sealed class KHPJEHNKDGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public PPGAOMKJBNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		private CCGGKNOLNJA <loadInfo>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private ONCPNDKMCDI <subRoomSaveData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private ONCPNDKMCDI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private TaskAwaiter<ONCPNDKMCDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KHPJEHNKDGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0EB0", Offset = "0x4EAFEB0", VA = "0x184EB0EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class AMELPIEHBDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public MGFPBFIAOAF presence;

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AMELPIEHBDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC800", Offset = "0x4EAB800", VA = "0x184EAC800")]
		internal object LNPHKLADMDO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006FA")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.Token(Token = "0x40006FB")]
	private static readonly HPPHLHFLMDP EDKPPKNIPOM;

	[Cpp2IlInjected.Token(Token = "0x40006FC")]
	private static readonly HPPHLHFLMDP EDPLNGOFDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	private readonly CCGGKNOLNJA CLOCHCJAIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	private readonly GDOIHMDILDL DEFMMEKECKD;

	[Cpp2IlInjected.Token(Token = "0x40006FF")]
	private const bool KJEJILDPDHJ = false;

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x2726B40", Offset = "0x2725B40", VA = "0x182726B40")]
	public PPGAOMKJBNI(CCGGKNOLNJA CLOCHCJAIEB, GDOIHMDILDL DEFMMEKECKD, Guid MLHJIHFFCGB, DICEJLBHJCH FGIILGHEHMH, DMMCOJOPIJA LONIOFFJBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x2726890", Offset = "0x2725890", VA = "0x182726890", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EMJCGMKPFFJ))]
	protected override Task OMAJKGPPIHI(HEPJBIGMLHA OAAPCIHIIOO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x2726740", Offset = "0x2725740", VA = "0x182726740")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHOPAMLHDEM))]
	protected Task OJEGOGAEFAH(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x2726450", Offset = "0x2725450", VA = "0x182726450")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KHPJEHNKDGP))]
	private Task<byte> ADMABOAACGH(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x27265C0", Offset = "0x27255C0", VA = "0x1827265C0")]
	private MGFPBFIAOAF OCDELFKNHDP()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal struct OOCFEBAJNFD
{
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class BIOKLALNJPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public DICEJLBHJCH roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		private bool <isMaster>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BIOKLALNJPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x4EACEB0", Offset = "0x4EABEB0", VA = "0x184EACEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x27239F0", Offset = "0x27229F0", VA = "0x1827239F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BIOKLALNJPA))]
	public static Task PLLHAMBOEGA(DICEJLBHJCH FGIILGHEHMH, OFIMLBDMAME HHCEHFFEAKN, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
internal struct HANMPKGEFAI
{
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class NONECAKHBJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public HANMPKGEFAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private JAJLFGHDADC <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private string <sceneName>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private Scene <mainScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NONECAKHBJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x3827A20", Offset = "0x3826A20", VA = "0x183827A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class LJLDOJHBIFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LJLDOJHBIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x3823E90", Offset = "0x3822E90", VA = "0x183823E90")]
		internal object HOPPPBCJKNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class LFNPDKGPGED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public HANMPKGEFAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private LJLDOJHBIFH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		private MANEHNJBDFA <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LFNPDKGPGED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x3823940", Offset = "0x3822940", VA = "0x183823940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	private JAJLFGHDADC NJAIIKAGFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	private MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private bool PDEPGLECFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private OFIMLBDMAME HHCEHFFEAKN;

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x20E93C0", Offset = "0x20E83C0", VA = "0x1820E93C0")]
	public static Task<Scene> KDPKOEAOMDN(DICEJLBHJCH FGIILGHEHMH, JAJLFGHDADC FIHLKONONPG, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x20E9320", Offset = "0x20E8320", VA = "0x1820E9320")]
	public static Task<Scene> JNIPCGHOOND(DICEJLBHJCH FGIILGHEHMH, OFIMLBDMAME HHCEHFFEAKN, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x20E94B0", Offset = "0x20E84B0", VA = "0x1820E94B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NONECAKHBJK))]
	private Task<Scene> PLLHAMBOEGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x20E9170", Offset = "0x20E8170", VA = "0x1820E9170")]
	private bool HDCGAEMNPMN(OFIMLBDMAME HHCEHFFEAKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x20E9440", Offset = "0x20E8440", VA = "0x1820E9440")]
	private void KJLDDCBEJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x20E91A0", Offset = "0x20E81A0", VA = "0x1820E91A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LFNPDKGPGED))]
	private Task<Scene> IKINDHGBFGM(string GHHMMCBLDBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
public abstract class PLCLAFAGABK<T> where T : PLCLAFAGABK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	internal readonly DICEJLBHJCH GOCPANEJOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	private int? NLMMDNKAIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073E")]
	protected readonly Guid ALPGHNGJHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073F")]
	protected readonly IOANKPJOPII JHIGDIALLPJ;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	protected T ODHEDLLAHMB
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2063410", Offset = "0x2062410", VA = "0x182063410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x2063580", Offset = "0x2062580", VA = "0x182063580")]
	internal PLCLAFAGABK(DICEJLBHJCH EKIDICEDOKI, IOANKPJOPII FHNGDKCLEKI, [Optional] Guid? MLHJIHFFCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x2063320", Offset = "0x2062320", VA = "0x182063320")]
	private OCLNBBADIAK GMOMFFDOHGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "4")]
	protected virtual void KEMGOJAKLIN(OCLNBBADIAK HJJLMCEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x20634F0", Offset = "0x20624F0", VA = "0x1820634F0")]
	public T PICNENEBOGN(PIPFLAHHDDO AFPDMBJFOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x2063470", Offset = "0x2062470", VA = "0x182063470")]
	public T KPEBNHGFIHB(int GJBCPGJBAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x2063220", Offset = "0x2062220", VA = "0x182063220", Slot = "5")]
	public virtual Task<PEOGNNHCCMJ> CCFLJKBNADN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public class IEELIAJJJHO : PLCLAFAGABK<IEELIAJJJHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	private CCGGKNOLNJA EMBONFDCNJA;

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x20EDD00", Offset = "0x20ECD00", VA = "0x1820EDD00")]
	internal IEELIAJJJHO(DICEJLBHJCH EKIDICEDOKI, IOANKPJOPII FHNGDKCLEKI, [Optional] Guid? MLHJIHFFCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x20EDC10", Offset = "0x20ECC10", VA = "0x1820EDC10")]
	public IEELIAJJJHO EEJLFFEOOIH(CCGGKNOLNJA EMBONFDCNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x20EDC30", Offset = "0x20ECC30", VA = "0x1820EDC30", Slot = "4")]
	protected override void KEMGOJAKLIN(OCLNBBADIAK HJJLMCEMDKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public class HFHJABDNILK : PLCLAFAGABK<HFHJABDNILK>
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	internal enum MOLFKKIFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		RecNet
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private sealed class IMKKCLCLKMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public AsyncTaskMethodBuilder<PEOGNNHCCMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public HFHJABDNILK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private PEOGNNHCCMJ <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private TaskAwaiter<PEOGNNHCCMJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IMKKCLCLKMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x381FBF0", Offset = "0x381EBF0", VA = "0x18381FBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000741")]
	private MOLFKKIFJAG IPPHFGDCGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000742")]
	private string HMOBIOGBPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	private NNMKFKJCKPG EMBONFDCNJA;

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x20EC1F0", Offset = "0x20EB1F0", VA = "0x1820EC1F0")]
	internal HFHJABDNILK(DICEJLBHJCH EKIDICEDOKI, IOANKPJOPII FHNGDKCLEKI, [Optional] Guid? MLHJIHFFCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x20EBFE0", Offset = "0x20EAFE0", VA = "0x1820EBFE0")]
	public HFHJABDNILK JCFIDJMOHLN(string LDBIOFPDBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x20EBE00", Offset = "0x20EAE00", VA = "0x1820EBE00")]
	public HFHJABDNILK AFFNGPOFFEJ(bool NOPCKAINEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x20EC010", Offset = "0x20EB010", VA = "0x1820EC010")]
	public HFHJABDNILK JNOOFJEBOHC(string CDLBCMHHGDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x20EBF80", Offset = "0x20EAF80", VA = "0x1820EBF80")]
	public HFHJABDNILK DBGFBOCNBOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x20EBFB0", Offset = "0x20EAFB0", VA = "0x1820EBFB0")]
	public HFHJABDNILK HIJFPLAIDMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x20EC040", Offset = "0x20EB040", VA = "0x1820EC040", Slot = "4")]
	protected override void KEMGOJAKLIN(OCLNBBADIAK HJJLMCEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x20EBE30", Offset = "0x20EAE30", VA = "0x1820EBE30", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IMKKCLCLKMN))]
	public override Task<PEOGNNHCCMJ> CCFLJKBNADN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x20EC1B0", Offset = "0x20EB1B0", VA = "0x1820EC1B0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<PEOGNNHCCMJ> NDBLCDFNIBD()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct NNMPPOGIEMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class IIFOFCHLHCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public DPFKDGMPIHI.FCDHHNABMKA instantiations;

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IIFOFCHLHCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x3B01C30", Offset = "0x3B00C30", VA = "0x183B01C30")]
		internal object FBHDPKPCCFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class BBKFOEJHFPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BBKFOEJHFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8630", Offset = "0x3AF7630", VA = "0x183AF8630")]
		internal object KAMHOGBDKNE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x271C2F0", Offset = "0x271B2F0", VA = "0x18271C2F0")]
	public static void PLLHAMBOEGA(HNNFLHMGLEJ KIDKAIDKLIB, OFIMLBDMAME HHCEHFFEAKN, DPFKDGMPIHI.FCDHHNABMKA IAGDIKALPMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal struct DPFKDGMPIHI
{
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	public struct FCDHHNABMKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public List<FLMOHKGBJCK> ALGEEAADADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public List<NEMHKEECLGO> FCBHOOPPLLG;

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xA891D0", Offset = "0xA881D0", VA = "0x180A891D0")]
		public FCDHHNABMKA(List<FLMOHKGBJCK> ALGEEAADADL, List<NEMHKEECLGO> FCBHOOPPLLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class ONGKDLNBOGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public IEnumerable<FLMOHKGBJCK> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ONGKDLNBOGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2723970", Offset = "0x2722970", VA = "0x182723970")]
		internal object JIJEEJFHNMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private OFIMLBDMAME HHCEHFFEAKN;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private HJNEIHJIJJJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x20E3D10", Offset = "0x20E2D10", VA = "0x1820E3D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x20E3F40", Offset = "0x20E2F40", VA = "0x1820E3F40")]
	public static FCDHHNABMKA PLLHAMBOEGA(DICEJLBHJCH FGIILGHEHMH, OFIMLBDMAME HHCEHFFEAKN)
	{
		return default(FCDHHNABMKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x20E3FB0", Offset = "0x20E2FB0", VA = "0x1820E3FB0")]
	private FCDHHNABMKA PLLHAMBOEGA()
	{
		return default(FCDHHNABMKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x20E37A0", Offset = "0x20E27A0", VA = "0x1820E37A0")]
	private FCDHHNABMKA BJNMHFBEKPG(OCMKINIOLDE ELKCKIIFBGF, FEALJIILFCB HCOPAHKCNLP)
	{
		return default(FCDHHNABMKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x20E3D60", Offset = "0x20E2D60", VA = "0x1820E3D60")]
	private bool GHFCCCLNCFC(IEnumerable<FLMOHKGBJCK> ALGEEAADADL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct AMLNONLNHHG
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class NGALGBFOGIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public AMLNONLNHHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NGALGBFOGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x271AE10", Offset = "0x2719E10", VA = "0x18271AE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class BJNHAMMEHGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BJNHAMMEHGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x270DF60", Offset = "0x270CF60", VA = "0x18270DF60")]
		internal object HOPPPBCJKNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class JADEOIEIGII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public AMLNONLNHHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private BJNHAMMEHGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private MANEHNJBDFA <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JADEOIEIGII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2712D80", Offset = "0x2711D80", VA = "0x182712D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000756")]
	private bool NHFEENOBPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000757")]
	private MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000758")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000759")]
	private CancellationToken OAGBBBCDIGC;

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x20D9820", Offset = "0x20D8820", VA = "0x1820D9820")]
	public static Task BAMPPKHBGOC(DICEJLBHJCH FGIILGHEHMH, bool NHFEENOBPOG, MNKIABAIHBN<string>.JJAEKMMDGKH PPHNMHNDCPA, CancellationToken CFKODBAEEON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x20D9A00", Offset = "0x20D8A00", VA = "0x1820D9A00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NGALGBFOGIN))]
	private Task PLLHAMBOEGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x20D9890", Offset = "0x20D8890", VA = "0x1820D9890")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JADEOIEIGII))]
	private Task IKINDHGBFGM(bool DJNKLPFFCKF, string GHHMMCBLDBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x98E270", Offset = "0x98D270", VA = "0x18098E270")]
	private bool FLDGICDFFIA(bool NHFEENOBPOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct IODHGACPIHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400076E")]
	public readonly EAHJJHFFELH IMNFFHILDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400076F")]
	public readonly MEKHHBDIOBK GJFGJIAPFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000770")]
	public readonly string BJIEMONJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000771")]
	public readonly PLLPALDIOHF PLNEIMJEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000772")]
	public readonly PLLPALDIOHF NEHMEKKOIFN;

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x20EE120", Offset = "0x20ED120", VA = "0x1820EE120")]
	public IODHGACPIHP(EAHJJHFFELH IMNFFHILDHL, MEKHHBDIOBK GJFGJIAPFHC, string BJIEMONJOEI, PLLPALDIOHF PLNEIMJEEFL, PLLPALDIOHF NEHMEKKOIFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
internal sealed class CILBELBCEKM : GBPMOJNFGLC
{
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class CJFIEMMOHAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public CILBELBCEKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private KPECHFMAHBD <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		private KIKKPADFBCP <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CJFIEMMOHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x27100F0", Offset = "0x270F0F0", VA = "0x1827100F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000773")]
	private readonly CCGGKNOLNJA ACGAODEEPLC;

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x20E1CD0", Offset = "0x20E0CD0", VA = "0x1820E1CD0")]
	public CILBELBCEKM(Guid MLHJIHFFCGB, DICEJLBHJCH FGIILGHEHMH, CCGGKNOLNJA ACGAODEEPLC, DMMCOJOPIJA LONIOFFJBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x20E1B30", Offset = "0x20E0B30", VA = "0x1820E1B30", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CJFIEMMOHAA))]
	protected override Task EGINDJDILCF(HEPJBIGMLHA OAAPCIHIIOO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018E")]
internal struct CKDMIMECGKL
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x20E1D80", Offset = "0x20E0D80", VA = "0x1820E1D80")]
	public static Task PLLHAMBOEGA(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal struct JKGFPOOHPPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class BCLOJDOGNOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public DICEJLBHJCH roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public OFIMLBDMAME data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private bool <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BCLOJDOGNOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x3818A10", Offset = "0x3817A10", VA = "0x183818A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class IOAFPLAEGDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public JKGFPOOHPPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		private bool <shouldObjectModelBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		private bool <isOMFlagChanging>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private bool <reloadSceneForObjectModel>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IOAFPLAEGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x38202B0", Offset = "0x381F2B0", VA = "0x1838202B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400077D")]
	private DICEJLBHJCH FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400077E")]
	private OFIMLBDMAME HHCEHFFEAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400077F")]
	private ByteString LBMEKGGAGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000780")]
	private HEPJBIGMLHA OAAPCIHIIOO;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private HJNEIHJIJJJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x20EF2C0", Offset = "0x20EE2C0", VA = "0x1820EF2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private bool DCLINFNMKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x20EF470", Offset = "0x20EE470", VA = "0x1820EF470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private bool LIOHIHIOHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x20EF310", Offset = "0x20EE310", VA = "0x1820EF310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private bool JEKPDKNPDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x20EF880", Offset = "0x20EE880", VA = "0x1820EF880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x20EF690", Offset = "0x20EE690", VA = "0x1820EF690")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BCLOJDOGNOG))]
	public static Task<bool> PLLHAMBOEGA(DICEJLBHJCH FGIILGHEHMH, OFIMLBDMAME HHCEHFFEAKN, HEPJBIGMLHA OAAPCIHIIOO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x20EF4F0", Offset = "0x20EE4F0", VA = "0x1820EF4F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IOAFPLAEGDK))]
	private Task<bool> PLLHAMBOEGA(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
public static class HAPPJMIEGJO
{
	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x20E9610", Offset = "0x20E8610", VA = "0x1820E9610")]
	public static PLLPALDIOHF COCFCJJDACE(this IAICMLMPHGE AGOKOJHDPLC)
	{
		return default(PLLPALDIOHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x20E96D0", Offset = "0x20E86D0", VA = "0x1820E96D0")]
	public static IAICMLMPHGE IPHHLJGMDBJ(this PLLPALDIOHF CNDELMKPJII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal class OIMBOADDECM : IPGDAGIOAKM
{
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class IJEOOBHJOHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public JPBPCLMJCAC.PKBKNMHBMJE roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IJEOOBHJOHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0840", Offset = "0x4EAF840", VA = "0x184EB0840")]
		internal object CPNAGFELHEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class HHPEAKLHLOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public AsyncTaskMethodBuilder<(JPBPCLMJCAC.PKBKNMHBMJE roomDataUpload, JPBPCLMJCAC.PKBKNMHBMJE subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public JNMBCFANFLA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public OIMBOADDECM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		private IJEOOBHJOHK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		private EOMDDKFOOGO <roomMetadata>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		private JPBPCLMJCAC.PKBKNMHBMJE <subRoomDataUpload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		private JPBPCLMJCAC.PKBKNMHBMJE <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		private JPBPCLMJCAC.PKBKNMHBMJE <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		private TaskAwaiter<JPBPCLMJCAC.PKBKNMHBMJE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HHPEAKLHLOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x4EAFF30", Offset = "0x4EAEF30", VA = "0x184EAFF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class ONDHNOHPOKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public AsyncTaskMethodBuilder<CEIPMKNCAPB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public NNMKFKJCKPG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public JNMBCFANFLA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		public OIMBOADDECM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private JPBPCLMJCAC.PKBKNMHBMJE <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		private JPBPCLMJCAC.PKBKNMHBMJE <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		private int <persistenceVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		private bool <objectModelEnabledInSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x85")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		private byte <omVersion>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		private HOLMKEDHIPM <request>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		private CEIPMKNCAPB <response>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		private (JPBPCLMJCAC.PKBKNMHBMJE roomDataUpload, JPBPCLMJCAC.PKBKNMHBMJE subRoomDataUpload) <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		private (JPBPCLMJCAC.PKBKNMHBMJE roomDataUpload, JPBPCLMJCAC.PKBKNMHBMJE subRoomDataUpload) <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		private CEIPMKNCAPB <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		private TaskAwaiter<(JPBPCLMJCAC.PKBKNMHBMJE roomDataUpload, JPBPCLMJCAC.PKBKNMHBMJE subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		private TaskAwaiter<CEIPMKNCAPB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ONDHNOHPOKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x4EB3C50", Offset = "0x4EB2C50", VA = "0x184EB3C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class ENJFLHHBEOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public AsyncTaskMethodBuilder<GKJCOLDBOLN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public JNMBCFANFLA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public OIMBOADDECM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		private JPBPCLMJCAC.PKBKNMHBMJE <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		private JPBPCLMJCAC.PKBKNMHBMJE <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		private GKJCOLDBOLN <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		private (JPBPCLMJCAC.PKBKNMHBMJE roomDataUpload, JPBPCLMJCAC.PKBKNMHBMJE subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		private (JPBPCLMJCAC.PKBKNMHBMJE roomDataUpload, JPBPCLMJCAC.PKBKNMHBMJE subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private GKJCOLDBOLN <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		private TaskAwaiter<(JPBPCLMJCAC.PKBKNMHBMJE roomDataUpload, JPBPCLMJCAC.PKBKNMHBMJE subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		private TaskAwaiter<GKJCOLDBOLN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ENJFLHHBEOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x4EAED90", Offset = "0x4EADD90", VA = "0x184EAED90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class GBODOOMDHHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D5")]
			public AsyncTaskMethodBuilder<OCLNBBADIAK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007D6")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007D7")]
			public GBODOOMDHHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			private OCLNBBADIAK <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			private RepeatedField<NEMHKEECLGO> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5440", Offset = "0x6F4840")]
			private IEnumerable<NEMHKEECLGO> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			private GKJCOLDBOLN <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			private GKJCOLDBOLN <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007DF")]
			private CEIPMKNCAPB <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007E0")]
			private CEIPMKNCAPB <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007E1")]
			private OCLNBBADIAK <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007E2")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007E3")]
			private TaskAwaiter<GKJCOLDBOLN> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40007E4")]
			private TaskAwaiter<CEIPMKNCAPB> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40007E5")]
			private TaskAwaiter<OCLNBBADIAK> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x4EB7CD0", Offset = "0x4EB6CD0", VA = "0x184EB7CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public OIMBOADDECM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public JNMBCFANFLA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public NNMKFKJCKPG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public DBGEFAOHMNO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5370", Offset = "0x6F4770")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GBODOOMDHHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF2B0", Offset = "0x4EAE2B0", VA = "0x184EAF2B0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<OCLNBBADIAK> DLGCPBDNLEB(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class CIBMJGADOAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public AsyncTaskMethodBuilder<OCLNBBADIAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public NNMKFKJCKPG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		public JNMBCFANFLA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public DBGEFAOHMNO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F54A0", Offset = "0x6F48A0")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public OIMBOADDECM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private GBODOOMDHHO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private OCLNBBADIAK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		private TaskAwaiter<OCLNBBADIAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CIBMJGADOAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x4EADFC0", Offset = "0x4EACFC0", VA = "0x184EADFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000794")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.Token(Token = "0x4000795")]
	private static readonly HPPHLHFLMDP EDKPPKNIPOM;

	[Cpp2IlInjected.Token(Token = "0x4000796")]
	private const float KNNGPFICOCC = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000797")]
	private readonly DGKOIJANCJM PCHEOGBBACN;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private DICEJLBHJCH DJBMKEADGAH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x20F29C0", Offset = "0x20F19C0", VA = "0x1820F29C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x2720F40", Offset = "0x271FF40", VA = "0x182720F40")]
	public OIMBOADDECM(HEPJBIGMLHA OAAPCIHIIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x2720670", Offset = "0x271F670", VA = "0x182720670")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HHPEAKLHLOB))]
	private Task<(JPBPCLMJCAC.PKBKNMHBMJE, JPBPCLMJCAC.PKBKNMHBMJE)> BJPMOOLKLPE(JNMBCFANFLA KOBJHMANLPK, long IHGIEILPMCA, long BPCDOJMJPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271FC80", VA = "0x182720C80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ONDHNOHPOKF))]
	public Task<CEIPMKNCAPB> KOKLEKOJBAI(int FBPHLCMNECO, [CanBeNull] NNMKFKJCKPG BBAPKHEMNJB, JNMBCFANFLA KOBJHMANLPK, long IHGIEILPMCA, long BPCDOJMJPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x2720830", Offset = "0x271F830", VA = "0x182720830")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ENJFLHHBEOI))]
	private Task<GKJCOLDBOLN> FAILKIJLACH(string NELEGDAMKMM, int FBPHLCMNECO, JNMBCFANFLA KOBJHMANLPK, long IHGIEILPMCA, long BPCDOJMJPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x2720A30", Offset = "0x271FA30", VA = "0x182720A30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CIBMJGADOAH))]
	public Task<OCLNBBADIAK> GEJHJMOGEBK(int FBPHLCMNECO, NNMKFKJCKPG? BBAPKHEMNJB, JNMBCFANFLA KOBJHMANLPK, long IHGIEILPMCA, long BPCDOJMJPPI, DBGEFAOHMNO IOHNLEDHCKP, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal class HLNDMGKMPNA : GBPMOJNFGLC
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class AMHJLEHPEIA
	{
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			public AsyncTaskMethodBuilder<OCLNBBADIAK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			public AMHJLEHPEIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000804")]
			private JNMBCFANFLA <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000805")]
			private OCLNBBADIAK <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000806")]
			private JNMBCFANFLA <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			private OCLNBBADIAK <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			private TaskAwaiter<JNMBCFANFLA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000809")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F0700", Offset = "0x6EFB00")]
			private TaskAwaiter<OCLNBBADIAK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x4EB7870", Offset = "0x4EB6870", VA = "0x184EB7870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		public HLNDMGKMPNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		public EGIKMCBHEPN serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		public DHDFPEDJJBO roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		public OIMBOADDECM uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		public DBGEFAOHMNO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AMHJLEHPEIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x3817D90", Offset = "0x3816D90", VA = "0x183817D90")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<OCLNBBADIAK> AGIGLLGNIDG(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private sealed class JIBLKCDLANO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400080B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400080C")]
		public HEPJBIGMLHA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400080D")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400080E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400080F")]
		public HLNDMGKMPNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000810")]
		private AMHJLEHPEIA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		private KPECHFMAHBD <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private ONCPNDKMCDI <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		private KIKKPADFBCP <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private OCLNBBADIAK <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		private bool <omEnabledChanged>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private OCLNBBADIAK <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private Exception <ex>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private bool <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		private TaskAwaiter<OCLNBBADIAK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JIBLKCDLANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x38213D0", Offset = "0x38203D0", VA = "0x1838213D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class MGEABEIHAGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		public CCGGKNOLNJA loadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		public HLNDMGKMPNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private ONCPNDKMCDI <subRoomSaveData>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		private bool <omIsEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		private bool <omEnabledChanged>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		private ONCPNDKMCDI <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		private TaskAwaiter<ONCPNDKMCDI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MGEABEIHAGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x3826EE0", Offset = "0x3825EE0", VA = "0x183826EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40007F4")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.Token(Token = "0x40007F5")]
	private static readonly HPPHLHFLMDP EDKPPKNIPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007F6")]
	private readonly int FBPHLCMNECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007F7")]
	[CanBeNull]
	private readonly NNMKFKJCKPG BBAPKHEMNJB;

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x20ECC00", Offset = "0x20EBC00", VA = "0x1820ECC00")]
	public HLNDMGKMPNA(Guid MLHJIHFFCGB, DICEJLBHJCH FGIILGHEHMH, int FBPHLCMNECO, NNMKFKJCKPG BBAPKHEMNJB, DMMCOJOPIJA LONIOFFJBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x20EC510", Offset = "0x20EB510", VA = "0x1820EC510", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JIBLKCDLANO))]
	protected override Task EGINDJDILCF(HEPJBIGMLHA OAAPCIHIIOO, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x20EC3A0", Offset = "0x20EB3A0", VA = "0x1820EC3A0")]
	private void BGMKOFHMHIK(bool CNJJNCLKHBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x20EC850", Offset = "0x20EB850", VA = "0x1820EC850")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGEABEIHAGO))]
	protected Task<bool> MEKNAGJGLID(CCGGKNOLNJA OEJAFPIALNH, MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x20ECA10", Offset = "0x20EBA10", VA = "0x1820ECA10")]
	private void MJENIHHFMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x20EC6B0", Offset = "0x20EB6B0", VA = "0x1820EC6B0")]
	private void KGGIJHFEGBN(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, KPECHFMAHBD JBAGHENJMLO)
	{
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001A1")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400082E")]
			public JPFABOLLDCA ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400082F")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000830")]
			public JPFABOLLDCA HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000831")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000832")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000833")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private static JPFABOLLDCA[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400082D")]
		private Dictionary<JPFABOLLDCA, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x2727380", Offset = "0x2726380", VA = "0x182727380")]
		public bool GCEKKPPOPOH(JPFABOLLDCA PPIDGDFKOEI, out ResultConfig LCFBHAKNLEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x27273F0", Offset = "0x27263F0", VA = "0x1827273F0")]
		public ResultConfig GMDLDGGFMEE(JPFABOLLDCA HDCMCPPKAMG, [Optional] HashSet<JPFABOLLDCA> MDDFCJNGJOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x2727A70", Offset = "0x2726A70", VA = "0x182727A70", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x2727500", Offset = "0x2726500", VA = "0x182727500", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xA756E0", Offset = "0xA746E0", VA = "0x180A756E0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public class AOAGEGKHCPM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x20D9BC0", Offset = "0x20D8BC0", VA = "0x1820D9BC0")]
	public AOAGEGKHCPM(string HJJLMCEMDKN, Exception MPKLHKDLKCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
public class HCKINJHDDKC
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	private sealed class OFGJGNAGDDC : BBBKDDOMPPF, IEquatable<BBBKDDOMPPF>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A6")]
		[CompilerGenerated]
		private sealed class MDJBDJNBNPM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000840")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000841")]
			public AsyncTaskMethodBuilder<PEOGNNHCCMJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000842")]
			public OFGJGNAGDDC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000843")]
			private HIPOKMDFNOD <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000844")]
			private EAHJJHFFELH <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000845")]
			private CCGGKNOLNJA <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000846")]
			private EAHJJHFFELH <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000847")]
			private PEOGNNHCCMJ <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000848")]
			private TaskAwaiter<EAHJJHFFELH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000849")]
			private TaskAwaiter<PEOGNNHCCMJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public MDJBDJNBNPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x4EB1CC0", Offset = "0x4EB0CC0", VA = "0x184EB1CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400083D")]
		private readonly ONCPNDKMCDI JMLMGODJIOH;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int KFHILOGNNJB
		{
			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x9AEAB0", Offset = "0x9ADAB0", VA = "0x1809AEAB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public ELODNMEIKHI MLJNBOFJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		private DateTime HHCPFICDBCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x22D3310", Offset = "0x22D2310", VA = "0x1822D3310", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public BLAENFHHGKG? EIIBIHEMIOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0xC7EAE0", Offset = "0xC7DAE0", VA = "0x180C7EAE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public GNPOIGIDEFH? LFFNHGOKPMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x3828D20", Offset = "0x3827D20", VA = "0x183828D20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public CEIIPAFKPBB ACNGENCNKLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x90AF50", Offset = "0x909F50", VA = "0x18090AF50", Slot = "10")]
			get
			{
				return default(CEIIPAFKPBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x3828D40", Offset = "0x3827D40", VA = "0x183828D40", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MDJBDJNBNPM))]
		public Task<PEOGNNHCCMJ> GMLKLIGFBPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x3828F70", Offset = "0x3827F70", VA = "0x183828F70")]
		public OFGJGNAGDDC(int AJAAGAEPIFM, ELODNMEIKHI LPNBLMPLGKJ, ONCPNDKMCDI JMLMGODJIOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x3828C80", Offset = "0x3827C80", VA = "0x183828C80", Slot = "11")]
		public bool Equals(BBBKDDOMPPF BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x3828BE0", Offset = "0x3827BE0", VA = "0x183828BE0", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x3828F20", Offset = "0x3827F20", VA = "0x183828F20")]
		private bool NHGODEAALKD(OFGJGNAGDDC BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x3828E90", Offset = "0x3827E90", VA = "0x183828E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	private sealed class NOLKBHOPNBM : BBBKDDOMPPF, IEquatable<BBBKDDOMPPF>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A8")]
		[CompilerGenerated]
		private sealed class AFLLKJMLDGE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400084D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400084E")]
			public AsyncTaskMethodBuilder<PEOGNNHCCMJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400084F")]
			public NOLKBHOPNBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000850")]
			private PEOGNNHCCMJ <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000851")]
			private TaskAwaiter<PEOGNNHCCMJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public AFLLKJMLDGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x4EAC0D0", Offset = "0x4EAB0D0", VA = "0x184EAC0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400084A")]
		private readonly MCFPGIBLJJO IDINGHCODNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400084B")]
		private readonly BLAENFHHGKG HDEECBDKMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400084C")]
		private readonly GNPOIGIDEFH DKPEKJBODGI;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public int KFHILOGNNJB
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x3827920", Offset = "0x3826920", VA = "0x183827920", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public ELODNMEIKHI MLJNBOFJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x3827500", Offset = "0x3826500", VA = "0x183827500", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		private DateTime HHCPFICDBCG
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x38278D0", Offset = "0x38268D0", VA = "0x1838278D0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public BLAENFHHGKG? EIIBIHEMIOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x38279D0", Offset = "0x38269D0", VA = "0x1838279D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public GNPOIGIDEFH? LFFNHGOKPMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x38276A0", Offset = "0x38266A0", VA = "0x1838276A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public CEIIPAFKPBB ACNGENCNKLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86EB10", VA = "0x18086FB10", Slot = "10")]
			get
			{
				return default(CEIIPAFKPBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x37B2D20", Offset = "0x37B1D20", VA = "0x1837B2D20")]
		public NOLKBHOPNBM(MCFPGIBLJJO MFDMMJHLBJH, BLAENFHHGKG OOMBHNAIDBG, GNPOIGIDEFH LLEAFDGNHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x38276F0", Offset = "0x38266F0", VA = "0x1838276F0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(AFLLKJMLDGE))]
		public Task<PEOGNNHCCMJ> GMLKLIGFBPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x3827600", Offset = "0x3826600", VA = "0x183827600", Slot = "11")]
		public bool Equals(BBBKDDOMPPF BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x3827550", Offset = "0x3826550", VA = "0x183827550", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x3827970", Offset = "0x3826970", VA = "0x183827970")]
		private bool NHGODEAALKD(NOLKBHOPNBM BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x3827840", Offset = "0x3826840", VA = "0x183827840", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	private sealed class OAAFPCJGPPP : BBBKDDOMPPF, IEquatable<BBBKDDOMPPF>
	{
		[Cpp2IlInjected.Token(Token = "0x20001AA")]
		[CompilerGenerated]
		private sealed class BNOFJJDAJFK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000855")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000856")]
			public AsyncTaskMethodBuilder<PEOGNNHCCMJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000857")]
			public OAAFPCJGPPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000858")]
			private PEOGNNHCCMJ <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000859")]
			private TaskAwaiter<PEOGNNHCCMJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public BNOFJJDAJFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x4EAD690", Offset = "0x4EAC690", VA = "0x184EAD690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000852")]
		private readonly ELODNMEIKHI AJJDKKOLJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000853")]
		private readonly BLAENFHHGKG HDEECBDKMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000854")]
		private readonly GNPOIGIDEFH DKPEKJBODGI;

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public int KFHILOGNNJB
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x3828380", Offset = "0x3827380", VA = "0x183828380", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		[NotNull]
		public ELODNMEIKHI MLJNBOFJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		private DateTime HHCPFICDBCG
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x867490", Offset = "0x866490", VA = "0x180867490", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public BLAENFHHGKG? EIIBIHEMIOM
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x3828520", Offset = "0x3827520", VA = "0x183828520", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public GNPOIGIDEFH? LFFNHGOKPMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x3828130", Offset = "0x3827130", VA = "0x183828130", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public CEIIPAFKPBB ACNGENCNKLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x867490", Offset = "0x866490", VA = "0x180867490", Slot = "10")]
			get
			{
				return default(CEIIPAFKPBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x37B2D20", Offset = "0x37B1D20", VA = "0x1837B2D20")]
		public OAAFPCJGPPP(ELODNMEIKHI LPNBLMPLGKJ, BLAENFHHGKG OOMBHNAIDBG, GNPOIGIDEFH LLEAFDGNHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x3828180", Offset = "0x3827180", VA = "0x183828180", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(BNOFJJDAJFK))]
		public Task<PEOGNNHCCMJ> GMLKLIGFBPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x3827FF0", Offset = "0x3826FF0", VA = "0x183827FF0", Slot = "11")]
		public bool Equals(BBBKDDOMPPF BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x3827EA0", Offset = "0x3826EA0", VA = "0x183827EA0", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x38282D0", Offset = "0x38272D0", VA = "0x1838282D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x3828400", Offset = "0x3827400", VA = "0x183828400")]
		private bool NHGODEAALKD(OAAFPCJGPPP BKLMLPFOMCO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private sealed class HEDOKKOCFLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000860")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000861")]
		public AsyncTaskMethodBuilder<IList<BBBKDDOMPPF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000862")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000863")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000864")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000865")]
		public HCKINJHDDKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000866")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000867")]
		private IReadOnlyList<ONCPNDKMCDI> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000868")]
		private IReadOnlyList<(int accountId, ELODNMEIKHI account, ONCPNDKMCDI roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000869")]
		private List<BBBKDDOMPPF> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400086A")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400086B")]
		private MCFPGIBLJJO <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400086C")]
		private IReadOnlyList<ONCPNDKMCDI> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400086D")]
		private IReadOnlyList<(int accountId, ELODNMEIKHI account, ONCPNDKMCDI roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400086E")]
		private IEnumerator<(int accountId, ELODNMEIKHI account, ONCPNDKMCDI roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400086F")]
		private (int accountId, ELODNMEIKHI account, ONCPNDKMCDI roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000870")]
		private NOLKBHOPNBM <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000871")]
		private TaskAwaiter<IReadOnlyList<ONCPNDKMCDI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000872")]
		private TaskAwaiter<IReadOnlyList<(int accountId, ELODNMEIKHI account, ONCPNDKMCDI roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HEDOKKOCFLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x381DA60", Offset = "0x381CA60", VA = "0x18381DA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class MEJBEAPEBAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000873")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000874")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, ELODNMEIKHI account, ONCPNDKMCDI roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000875")]
		public IReadOnlyList<ONCPNDKMCDI> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000876")]
		public HCKINJHDDKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000877")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000878")]
		private IReadOnlyList<ELODNMEIKHI> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000879")]
		private Dictionary<ObscuredInt, ELODNMEIKHI> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400087A")]
		private List<(int, ELODNMEIKHI, ONCPNDKMCDI)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400087B")]
		private IReadOnlyList<ELODNMEIKHI> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400087C")]
		private IEnumerator<ONCPNDKMCDI> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400087D")]
		private ONCPNDKMCDI <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400087E")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400087F")]
		private ELODNMEIKHI <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000880")]
		private ELODNMEIKHI <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000881")]
		private TaskAwaiter<IReadOnlyList<ELODNMEIKHI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MEJBEAPEBAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x3826190", Offset = "0x3825190", VA = "0x183826190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000839")]
	private readonly BFLDDOBACFK ONFGPEDLNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400083A")]
	private readonly ECJBCOCFKHO JABOAKHPIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400083B")]
	private readonly GOGKAJFDJAH POOONAGEJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400083C")]
	private readonly KABCLCHAGFB<(long, long), IReadOnlyList<ONCPNDKMCDI>> GLJGFECLPEI;

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x20E9F10", Offset = "0x20E8F10", VA = "0x1820E9F10")]
	[UnityEngine.Scripting.Preserve]
	public HCKINJHDDKC([JFLEHDEIONF(null)] ECJBCOCFKHO MCNBPBNGMMF, [JFLEHDEIONF(null)] GOGKAJFDJAH BDLLPOOJFCP, [JFLEHDEIONF(null)] BFLDDOBACFK HIFCJAPLDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x20E9A60", Offset = "0x20E8A60", VA = "0x1820E9A60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HEDOKKOCFLA))]
	public Task<IList<BBBKDDOMPPF>> FLFEIOIDKGE(long IHGIEILPMCA, long FKNCEBBDENC, bool NIAAONIHODO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x20E9D70", Offset = "0x20E8D70", VA = "0x1820E9D70")]
	private bool NPJBOCGMPDG(DateTime? BGPFDBOCHIL, long IHGIEILPMCA, long FKNCEBBDENC, out MCFPGIBLJJO NLDFIJLPMIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x20E9C00", Offset = "0x20E8C00", VA = "0x1820E9C00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MEJBEAPEBAJ))]
	private Task<IReadOnlyList<(int, ELODNMEIKHI, ONCPNDKMCDI)>> GHJICADGHHA(IReadOnlyList<ONCPNDKMCDI> HDPEBCFKFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal class ICKHMGINEDK : ECJBCOCFKHO
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[CompilerGenerated]
	private sealed class CNPPDEKFPKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000882")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000883")]
		public AsyncTaskMethodBuilder<IReadOnlyList<ONCPNDKMCDI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000884")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000885")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000886")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000887")]
		public ICKHMGINEDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000888")]
		private MPNALOFPFFK<ONCPNDKMCDI> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000889")]
		private MPNALOFPFFK<ONCPNDKMCDI> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400088A")]
		private TaskAwaiter<MPNALOFPFFK<ONCPNDKMCDI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CNPPDEKFPKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x381AFB0", Offset = "0x3819FB0", VA = "0x18381AFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[CompilerGenerated]
	private sealed class MGDMMPFKDII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400088B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400088C")]
		public AsyncTaskMethodBuilder<IReadOnlyList<ELODNMEIKHI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400088D")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400088E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400088F")]
		public ICKHMGINEDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000890")]
		private List<ELODNMEIKHI> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000891")]
		private TaskAwaiter<List<ELODNMEIKHI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MGDMMPFKDII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x3826D00", Offset = "0x3825D00", VA = "0x183826D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000768")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	[UnityEngine.Scripting.Preserve]
	public ICKHMGINEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000769")]
	[Cpp2IlInjected.Address(RVA = "0x20EDA60", Offset = "0x20ECA60", VA = "0x1820EDA60", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CNPPDEKFPKL))]
	public Task<IReadOnlyList<ONCPNDKMCDI>> MEOGIJNEALP(long IHGIEILPMCA, long BPCDOJMJPPI, [Optional] CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x20ED8C0", Offset = "0x20EC8C0", VA = "0x1820ED8C0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGDMMPFKDII))]
	public Task<IReadOnlyList<ELODNMEIKHI>> CILKBCHMDIE(IReadOnlyList<int> CGHMODIEEDD, [Optional] CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public interface ECJBCOCFKHO
{
	[Cpp2IlInjected.Token(Token = "0x6000771")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<ONCPNDKMCDI>> MEOGIJNEALP(long IHGIEILPMCA, long BPCDOJMJPPI, [Optional] CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000772")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<ELODNMEIKHI>> CILKBCHMDIE(IReadOnlyList<int> CGHMODIEEDD, [Optional] CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public interface BBBKDDOMPPF : IEquatable<BBBKDDOMPPF>
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	int KFHILOGNNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	[CanBeNull]
	ELODNMEIKHI MLJNBOFJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	DateTime HFLCKDNMCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	BLAENFHHGKG? EIIBIHEMIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	GNPOIGIDEFH? LFFNHGOKPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	[CanBeNull]
	CEIIPAFKPBB ACNGENCNKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PEOGNNHCCMJ> GMLKLIGFBPJ();
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public enum CEIIPAFKPBB
{
	[Cpp2IlInjected.Token(Token = "0x4000893")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000894")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000895")]
	DiskAutosave
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
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
