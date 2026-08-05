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
		[Cpp2IlInjected.Address(RVA = "0x8484E0", Offset = "0x8474E0", VA = "0x1808484E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28B77D0", Offset = "0x28B67D0", VA = "0x1828B77D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB36FF0", Offset = "0xB35FF0", VA = "0x180B36FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x183B060", Offset = "0x183A060", VA = "0x18183B060")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MDFGFKODPDB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<NGDFPBDGPNO> POONHJEPFLJ;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GINJIKAJFOG(long IIKHCGCAMCH, long HCLBMOKINEP, IJCJMPMOCHK JFEDBHBIIIC, GHGMNDCOENL NHJGHMDIBIC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OPNHEBLFLPG(long IIKHCGCAMCH, long HCLBMOKINEP, out NGDFPBDGPNO AAHGAPCMDBK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HHDFJCCHPLG(long IIKHCGCAMCH, long HCLBMOKINEP, GHGMNDCOENL NHJGHMDIBIC, out NGDFPBDGPNO AAHGAPCMDBK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LEFLOIEBHMD(long IIKHCGCAMCH, long HCLBMOKINEP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[UnityEngine.Scripting.Preserve]
internal class DOIAAKGGFIO : IAIGPKNELON, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FIDMPONHOBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public OPAPHGBBLJD roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FIDMPONHOBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C85420", Offset = "0x3C84420", VA = "0x183C85420")]
		internal object NGGCLBGJFPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JJIECCDLKFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x212DC10", Offset = "0x212CC10", VA = "0x18212DC10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x212DB70", Offset = "0x212CB70", VA = "0x18212DB70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event IJFGDNEKBFA CNNJCMDLJAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x212D8C0", Offset = "0x212C8C0", VA = "0x18212D8C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x212DF60", Offset = "0x212CF60", VA = "0x18212DF60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event IJFGDNEKBFA JIGEGLJJMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x212D820", Offset = "0x212C820", VA = "0x18212D820", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x212E0D0", Offset = "0x212D0D0", VA = "0x18212E0D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event IJFGDNEKBFA BDNAFFCLNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x212E210", Offset = "0x212D210", VA = "0x18212E210", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x212D750", Offset = "0x212C750", VA = "0x18212D750", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NOOIKMHHFGH, bool> NLAHFAOIBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x212E030", Offset = "0x212D030", VA = "0x18212E030", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x212E170", Offset = "0x212D170", VA = "0x18212E170", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "19")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x212D960", Offset = "0x212C960", VA = "0x18212D960", Slot = "14")]
	public void FCLJKJCLAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x212E000", Offset = "0x212D000", VA = "0x18212E000", Slot = "15")]
	public void JOKJHHIGHKH(OPAPHGBBLJD IKJNAMJACKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x212D7F0", Offset = "0x212C7F0", VA = "0x18212D7F0", Slot = "16")]
	public void CJDKLBKMCND(OPAPHGBBLJD IKJNAMJACKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x212D720", Offset = "0x212C720", VA = "0x18212D720", Slot = "17")]
	public void AJADLGBEKGK(OPAPHGBBLJD IKJNAMJACKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x212DCB0", Offset = "0x212CCB0", VA = "0x18212DCB0", Slot = "18")]
	public void GEEPEKDGCHF(NOOIKMHHFGH GFEALFGNOCP, bool FKDDMFACIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x212DD60", Offset = "0x212CD60", VA = "0x18212DD60")]
	private void GEHFLMKLAJC(IJFGDNEKBFA KHGAJAOMHOH, OPAPHGBBLJD IKJNAMJACKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public DOIAAKGGFIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface OCKCNNNEKNG : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BHEAAKFGKPI FBMIFBMPDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLNMHEHOIKC();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPCHHCGJIBD();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate IPDKHLDPLEM LFCEHIPOGJL(JMNGDDABPMO KABGDOEGBII, ONJJHJCBMFM LAJCEOKMOIF);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface HDFDLFEDBFN : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LHNNEBBBEAA LIEOCKFHHCK(HAAIMGEOILO BIFINAFNENN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLLNIHPODKM(Guid KPAGBCDJFAA, Task ELGNEFIBDKC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal struct AOLFOCFMMFJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string CEPHMBBEGFI = "v_result";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const string BIDAIPIBKHE = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IDictionary<object, object> MLPMPPLPMHH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FHMCEOPEFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84AD80", Offset = "0x849D80", VA = "0x18084AD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xA9F760", Offset = "0xA9E760", VA = "0x180A9F760")]
	public AOLFOCFMMFJ(IDictionary<object, object> MLPMPPLPMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2122C70", Offset = "0x2121C70", VA = "0x182122C70")]
	public bool LECDBGNDBKI(out HAAIMGEOILO FANKIHBOOPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2122B90", Offset = "0x2121B90", VA = "0x182122B90")]
	public Guid IKFOKALPBAB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2122A80", Offset = "0x2121A80", VA = "0x182122A80")]
	public IPDKHLDPLEM IFBKCLKIBHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2122990", Offset = "0x2121990", VA = "0x182122990")]
	public static ExitGames.Client.Photon.Hashtable GGPPECCFBMF(HAAIMGEOILO FANKIHBOOPE, IPDKHLDPLEM HHNCNGAMNPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface POPKFIFBMON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKKGJHOJFGJ(NBCFGLDFMNE.ONBHAGJIIAM PNFGAFGFDEP);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDHEIGDDENI(NBCFGLDFMNE.ONBHAGJIIAM PNFGAFGFDEP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum OMPJDPAMADP
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
public abstract class NBCFGLDFMNE : POPKFIFBMON, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate IPDKHLDPLEM ONBHAGJIIAM([NotNull] JMNGDDABPMO COCJDPONKKI);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class DBGJGMBMHGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JMNGDDABPMO photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public DBGJGMBMHGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3D61C90", Offset = "0x3D60C90", VA = "0x183D61C90")]
		internal IPDKHLDPLEM LADJOIKLCMC(ONBHAGJIIAM v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool LOOPOECADGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly HashSet<ONBHAGJIIAM> PFEHAEIAFOB;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x28B4C60", Offset = "0x28B3C60", VA = "0x1828B4C60", Slot = "4")]
	public void CKKGJHOJFGJ(ONBHAGJIIAM PNFGAFGFDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x28B4D10", Offset = "0x28B3D10", VA = "0x1828B4D10", Slot = "5")]
	public void PDHEIGDDENI(ONBHAGJIIAM PNFGAFGFDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28B4CC0", Offset = "0x28B3CC0", VA = "0x1828B4CC0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x28B4A40", Offset = "0x28B3A40", VA = "0x1828B4A40")]
	protected IPDKHLDPLEM CBNGJFEINCH(JMNGDDABPMO LILPCOEGCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x28B4D70", Offset = "0x28B3D70", VA = "0x1828B4D70")]
	protected NBCFGLDFMNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class CGBDHHNLKBK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class IFGCCLCLBJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BNENJKMIJMI subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IFGCCLCLBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x28AC080", Offset = "0x28AB080", VA = "0x1828AC080")]
		internal bool IBDKGNEBKBI(BHKIGNODGGN s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2124F90", Offset = "0x2123F90", VA = "0x182124F90")]
	public static FHNAMDEGIOK GGPPECCFBMF(long GEHBPDLNJDE, long EMFFAEIKHBM, string DEDIJINCEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2125270", Offset = "0x2124270", VA = "0x182125270")]
	public static FHNAMDEGIOK GGPPECCFBMF(long GEHBPDLNJDE, long EMFFAEIKHBM, LMFNHKGJLBN KKOHNCFJGIK, long APOIFOLOFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2125340", Offset = "0x2124340", VA = "0x182125340")]
	public static FHNAMDEGIOK GGPPECCFBMF(AOMNJPFLLBL HPMHFAHOFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2125030", Offset = "0x2124030", VA = "0x182125030")]
	public static FHNAMDEGIOK GGPPECCFBMF(HFCNBIIEHLN GOOLFIPMCAA, BNENJKMIJMI OGBOCPCNNPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2125600", Offset = "0x2124600", VA = "0x182125600")]
	public static FHNAMDEGIOK KDHKGAJKAAK(this FHNAMDEGIOK KPMKPNDNMBB, HFCNBIIEHLN ADHIGBHIOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2125470", Offset = "0x2124470", VA = "0x182125470")]
	public static FHNAMDEGIOK IHNIAPIPIGD(this FHNAMDEGIOK KPMKPNDNMBB, BNENJKMIJMI JBAJGDGJGOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum CNPOBNKKGFH
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum NOOIKMHHFGH
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
public struct OPAPHGBBLJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly long GEHBPDLNJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly long EMFFAEIKHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly CNPOBNKKGFH FLAJIGGIBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[CanBeNull]
	public readonly Exception LBBEONNONIP;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28B9380", Offset = "0x28B8380", VA = "0x1828B9380")]
	public OPAPHGBBLJD(long GEHBPDLNJDE, long EMFFAEIKHBM, CNPOBNKKGFH FLAJIGGIBOB, [CanBeNull] Exception LBBEONNONIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28B9330", Offset = "0x28B8330", VA = "0x1828B9330")]
	public static OPAPHGBBLJD JLEKENNMMAD(IACNHFFDGGB DKJDNKEKDGN, CNPOBNKKGFH FLAJIGGIBOB, [Optional] Exception LBBEONNONIP)
	{
		return default(OPAPHGBBLJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public delegate void IJFGDNEKBFA(OPAPHGBBLJD IKJNAMJACKC);
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface IAIGPKNELON : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action JJIECCDLKFN;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event IJFGDNEKBFA CNNJCMDLJAK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event IJFGDNEKBFA JIGEGLJJMKK;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event IJFGDNEKBFA BDNAFFCLNAP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<NOOIKMHHFGH, bool> NLAHFAOIBAA;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FCLJKJCLAHH();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JOKJHHIGHKH(OPAPHGBBLJD IKJNAMJACKC);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CJDKLBKMCND(OPAPHGBBLJD IKJNAMJACKC);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AJADLGBEKGK(OPAPHGBBLJD IKJNAMJACKC);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GEEPEKDGCHF(NOOIKMHHFGH GFEALFGNOCP, bool FKDDMFACIBH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[UnityEngine.Scripting.Preserve]
internal class ECPHILOLJKL : CPFLKKAHAIJ, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class FFIHNIJELDC : IAsyncStateMachine
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
		public ECPHILOLJKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private GLHOFFEBKJL<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private POKOHKIICBM <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FFIHNIJELDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3C83DC0", Offset = "0x3C82DC0", VA = "0x183C83DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private FKNLNKENNLO LBONNBDKDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private GBKCOPOOGJM DNNBPAGCCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private JOCOCPHJKKK DICCIFBHGLC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x212E4B0", Offset = "0x212D4B0", VA = "0x18212E4B0", Slot = "6")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x212E400", Offset = "0x212D400", VA = "0x18212E400", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x212E6C0", Offset = "0x212D6C0", VA = "0x18212E6C0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FFIHNIJELDC))]
	public Task OJEKGBADKEM(string JAGGOBHOHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x212E450", Offset = "0x212D450", VA = "0x18212E450", Slot = "4")]
	public IPDKHLDPLEM FLGMKMJLFGA(JMNGDDABPMO KABGDOEGBII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x212E2F0", Offset = "0x212D2F0", VA = "0x18212E2F0")]
	private POKOHKIICBM AGLMBFFMPNN(string JAGGOBHOHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public ECPHILOLJKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DJAJPIOICAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IPPCHOLAHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KFBOHBEGPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Task OFAKCCCOKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ILGCEILDCHC BHOKDEJKPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action JJIECCDLKFN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event IJFGDNEKBFA CNNJCMDLJAK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event IJFGDNEKBFA JIGEGLJJMKK;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event IJFGDNEKBFA BDNAFFCLNAP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<NOOIKMHHFGH, bool> NLAHFAOIBAA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LFHEBLIDDEK();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ONBNMFLMCNF OMAEJALFOBJ();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PFKCHGGNLIB HEBNAAJMGKH();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<IPDKHLDPLEM> IPJMMFNDMNF(NGDFPBDGPNO LADKCLEPKDB);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task EJOCFNDDHEO(CancellationToken AOAEIGNDKPI);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface KFFAHHHLDMB : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IPDKHLDPLEM> IPJMMFNDMNF(NGDFPBDGPNO AAHGAPCMDBK);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EJOCFNDDHEO(CancellationToken AOAEIGNDKPI);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[RecRoom.NoEngine.Common.Preserve]
internal class HAMPBKIEEBD : GBCLMCDGIFC, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GBLLMLMHDGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IACNHFFDGGB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public ILGCEILDCHC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public HAMPBKIEEBD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GBLLMLMHDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C859B0", Offset = "0x3C849B0", VA = "0x183C859B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NFGKNNIFFJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IACNHFFDGGB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ILGCEILDCHC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public HAMPBKIEEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private GLHOFFEBKJL<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private IKDJAENEOIK <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private LJJLLJAJOOO <analyticsData>5__5;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NFGKNNIFFJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FEB0", Offset = "0x3C8EEB0", VA = "0x183C8FEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FCFCLNCMGFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Matchmaking.LNDDFIFIEDO result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public OEFBBNFLPAL errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FCFCLNCMGFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C833D0", Offset = "0x3C823D0", VA = "0x183C833D0")]
		internal object GDJGCGIGPEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class ANLPHPIAFGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Task<FHNAMDEGIOK> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public ANLPHPIAFGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		internal Task<FHNAMDEGIOK> JNDPENHKONJ(GLHOFFEBKJL<string>.OADOKMKENLA _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HIHMNBCGAGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public IACNHFFDGGB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public ILGCEILDCHC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public IKDJAENEOIK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public HAMPBKIEEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private PGODKIEJDAO <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private CancellationTokenRegistration <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private ANLPHPIAFGF <>8__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private DMCJNHAMGMD <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private Task<Matchmaking.NNODEKHKLIG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private HHICOGLDMCI <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Matchmaking.NNODEKHKLIG <serverConnectionInfo>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private CancellationTokenSource <cameraFadeCts>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CancellationTokenSource <loadingScreenCts>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <loadingScreenScope>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Matchmaking.NNODEKHKLIG <>s__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private CancellationTokenSource <photonJoinedTokenSource>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private CancellationToken <photonJoinedToken>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private FHNAMDEGIOK <initialRoomLoadPayload>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private FHNAMDEGIOK <>s__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<Matchmaking.NNODEKHKLIG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter<FHNAMDEGIOK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HIHMNBCGAGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C872D0", Offset = "0x3C862D0", VA = "0x183C872D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FEPFLKEPKAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public HAMPBKIEEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <disconnectTimerScope>5__2;

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
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FEPFLKEPKAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C83530", Offset = "0x3C82530", VA = "0x183C83530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class GALHDAHIEHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public HAMPBKIEEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private ECDJHHJLGGB <roomContainer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GALHDAHIEHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C85580", Offset = "0x3C84580", VA = "0x183C85580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KJKIONFFELC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder<Matchmaking.NNODEKHKLIG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IACNHFFDGGB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public HAMPBKIEEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Matchmaking.NNODEKHKLIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter<Matchmaking.NNODEKHKLIG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KJKIONFFELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D710", Offset = "0x3C8C710", VA = "0x183C8D710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class HHNNPNAHPJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Matchmaking.NNODEKHKLIG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public IKDJAENEOIK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public HAMPBKIEEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private PNCONIMLMEB <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<PNCONIMLMEB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HHNNPNAHPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C86D50", Offset = "0x3C85D50", VA = "0x183C86D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class MAFIAPIEGHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public IACNHFFDGGB targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MAFIAPIEGHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MJFGMFFNNMC
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
		public MAFIAPIEGHA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MJFGMFFNNMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F480", Offset = "0x3C8E480", VA = "0x183C8F480")]
		internal object DNFOENOPBGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F580", Offset = "0x3C8E580", VA = "0x183C8F580")]
		internal string OMINNDNHHJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KCIKFBHAAIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public IACNHFFDGGB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public HAMPBKIEEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private MAFIAPIEGHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private MJFGMFFNNMC <>8__3;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KCIKFBHAAIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C810", Offset = "0x3C8B810", VA = "0x183C8C810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class OKBBDJKMBCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public FHNAMDEGIOK initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public PGODKIEJDAO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public IACNHFFDGGB targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public IKDJAENEOIK joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public HAMPBKIEEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private IKDJAENEOIK <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private HDGABKIDFJA <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OKBBDJKMBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C915A0", Offset = "0x3C905A0", VA = "0x183C915A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class HJBIOAHHJPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HAMPBKIEEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__7;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HJBIOAHHJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3C89DF0", Offset = "0x3C88DF0", VA = "0x183C89DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PEBPHDLOOLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HAMPBKIEEBD <>4__this;

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
		private TaskAwaiter<IPDKHLDPLEM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PEBPHDLOOLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C91F40", Offset = "0x3C90F40", VA = "0x183C91F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KMFPBLNKKKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public IACNHFFDGGB targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KMFPBLNKKKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3C8DAE0", Offset = "0x3C8CAE0", VA = "0x183C8DAE0")]
		internal object HBOKAGLKIOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class OJOCKNLGCEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OJOCKNLGCEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3C91500", Offset = "0x3C90500", VA = "0x183C91500")]
		internal void MFGEFPJKBHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CJMKDEKPBNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public IACNHFFDGGB targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CJMKDEKPBNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C82A60", Offset = "0x3C81A60", VA = "0x183C82A60")]
		internal object MOMLMGMAJJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class MDCDEHDDKMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public IACNHFFDGGB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MDCDEHDDKMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F180", Offset = "0x3C8E180", VA = "0x183C8F180")]
		internal string KNNFOMFKMBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly FACALIAHOGE MHIEKLAJKHD;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly FACALIAHOGE GJDMCKGLCLP;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly FACALIAHOGE PPNBGJKJEOG;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly string ABOPFNCIKKK;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly string FHLJBKNKGKB;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly string IBBHMBMDCCD;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly Guid LIDJAFPFPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private DKIKCOHPEBM PPDNJLMMOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private NAPEKDAGIPO HGBIDCLGHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private BMIHHOPKAOM JDANGEIJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private KOGEPCGCONJ JJLHNLMGEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private GEGDDOJAOBI IBLAABAEMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private PNFFLEJMNPJ HNEFIHOOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private IAIGPKNELON HNGMLJEMCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private CLEKDBIBPBA NJABNINNONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private NLBKCIFAEMC DLKJNCCNCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private IDisposable MCNJBFBBFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly NLPBKAFHPON IMABMKJKEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly NLPBKAFHPON DMDNEPJGNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private HHICOGLDMCI OCMLLOLHPMO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TaskStatus NOBOGPPIBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x21348C0", Offset = "0x21338C0", VA = "0x1821348C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2136E90", Offset = "0x2135E90", VA = "0x182136E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private CDHOCHHBNDB AAJLKBMPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2137540", Offset = "0x2136540", VA = "0x182137540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2136A60", Offset = "0x2135A60", VA = "0x182136A60", Slot = "6")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2134A90", Offset = "0x2133A90", VA = "0x182134A90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2136EA0", Offset = "0x2135EA0", VA = "0x182136EA0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GBLLMLMHDGL))]
	public Task KHADBGEGLCC(IACNHFFDGGB NCMDIOLBALM, ILGCEILDCHC DBEIEOJPBEI, CancellationToken JANCDKHOLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x21376A0", Offset = "0x21366A0", VA = "0x1821376A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NFGKNNIFFJJ))]
	private Task PFHHLMOFMFK(IACNHFFDGGB NCMDIOLBALM, ILGCEILDCHC DBEIEOJPBEI, CancellationToken JANCDKHOLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x21363C0", Offset = "0x21353C0", VA = "0x1821363C0")]
	private static void IKNKIJBJPCG(CLEKDBIBPBA NJABNINNONH, IACNHFFDGGB NCMDIOLBALM, Exception AEPEBFMCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2135800", Offset = "0x2134800", VA = "0x182135800")]
	private static void HCPBCHCPPKL(LJJLLJAJOOO CCKOPJOJHHL, Exception AEPEBFMCJDO, [Optional] List<int> MGMBJEJNOJB, int EJCNGPKHHKE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2136880", Offset = "0x2135880", VA = "0x182136880")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HIHMNBCGAGK))]
	private Task JFFNHGEJCCN(GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, IACNHFFDGGB NCMDIOLBALM, ILGCEILDCHC DBEIEOJPBEI, IKDJAENEOIK AAOPPHHMNMN, CancellationToken JANCDKHOLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x21370D0", Offset = "0x21360D0", VA = "0x1821370D0")]
	private void LNDKDOLGPCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2135690", Offset = "0x2134690", VA = "0x182135690")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FEPFLKEPKAG))]
	private Task GNDMMEFLBAA(GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2137840", Offset = "0x2136840", VA = "0x182137840")]
	private void PHFECJIPLPN(IACNHFFDGGB NCMDIOLBALM, CancellationToken JANCDKHOLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2134EF0", Offset = "0x2133EF0", VA = "0x182134EF0")]
	private void FJEODADBJJJ(IACNHFFDGGB NCMDIOLBALM, IKDJAENEOIK AAOPPHHMNMN, OperationCanceledException LHBEDECICOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2136190", Offset = "0x2135190", VA = "0x182136190")]
	private void IIDJEIBACHB(IACNHFFDGGB NCMDIOLBALM, IKDJAENEOIK AAOPPHHMNMN, Exception AEPEBFMCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2134C50", Offset = "0x2133C50", VA = "0x182134C50")]
	private void EFPNJJNNFPG(IACNHFFDGGB NCMDIOLBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2137500", Offset = "0x2136500", VA = "0x182137500")]
	private static OPAPHGBBLJD NBEICAODKON(IACNHFFDGGB NCMDIOLBALM)
	{
		return default(OPAPHGBBLJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2134270", Offset = "0x2133270", VA = "0x182134270")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GALHDAHIEHO))]
	private Task AHLPJBLNLKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2134720", Offset = "0x2133720", VA = "0x182134720")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KJKIONFFELC))]
	private Task<Matchmaking.NNODEKHKLIG> BLNINOBLCEL(IACNHFFDGGB NCMDIOLBALM, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2137590", Offset = "0x2136590", VA = "0x182137590")]
	private static PNCONIMLMEB OMGOBIPCMHF(Matchmaking.NNODEKHKLIG FNNHNLHANCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x21348D0", Offset = "0x21338D0", VA = "0x1821348D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HHNNPNAHPJN))]
	private Task DCMELKJDNFD(Matchmaking.NNODEKHKLIG FNNHNLHANCN, IKDJAENEOIK AAOPPHHMNMN, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken OFDJOIJAIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x21354F0", Offset = "0x21344F0", VA = "0x1821354F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KCIKFBHAAIF))]
	private Task GMIGHIGGPGB(IACNHFFDGGB NCMDIOLBALM, CancellationTokenSource EPPJMHBMFEG, Task NGKGKANOAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x21352F0", Offset = "0x21342F0", VA = "0x1821352F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OKBBDJKMBCL))]
	private Task FPGBBINAKGH(FHNAMDEGIOK HEGDHLMBLBL, PGODKIEJDAO MFJEIDAKGAP, IACNHFFDGGB KKAECAHKGJK, IKDJAENEOIK FNFNIJOAGBI, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken CGFPGLDAPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2134390", Offset = "0x2133390", VA = "0x182134390")]
	private IKDJAENEOIK AIDIELPAIPA(IKDJAENEOIK FNFNIJOAGBI, ref CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2137390", Offset = "0x2136390", VA = "0x182137390")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HJBIOAHHJPD))]
	private Task MLJMAEOEMJE(GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2137B50", Offset = "0x2136B50", VA = "0x182137B50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PEBPHDLOOLG))]
	private Task PKDGCCNHCJJ(MLICCGFKPBG HCKNMLENIIG, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2137220", Offset = "0x2136220", VA = "0x182137220")]
	private static void MKCICPBJJEE(IACNHFFDGGB NCMDIOLBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2135120", Offset = "0x2134120", VA = "0x182135120")]
	private void FNBNHCHHFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x21341E0", Offset = "0x21331E0", VA = "0x1821341E0")]
	private void AFPKKLLLNEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2137040", Offset = "0x2136040", VA = "0x182137040")]
	private void LNBHLNIHABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2134E60", Offset = "0x2133E60", VA = "0x182134E60")]
	private void EOPLDCBIBID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2134B50", Offset = "0x2133B50", VA = "0x182134B50")]
	private static void EEJLFCLAONI(IACNHFFDGGB NCMDIOLBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2136030", Offset = "0x2135030", VA = "0x182136030")]
	private static CancellationTokenRegistration HPAABNEIIDO(IACNHFFDGGB NCMDIOLBALM, CancellationToken OFDJOIJAIEB)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2136780", Offset = "0x2135780", VA = "0x182136780")]
	private static void JEGCOGFPPEH(IACNHFFDGGB NCMDIOLBALM, Exception AEPEBFMCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2134550", Offset = "0x2133550", VA = "0x182134550")]
	private void ALNEKEOBHEI(IACNHFFDGGB NCMDIOLBALM, Task NGKGKANOAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2134AE0", Offset = "0x2133AE0", VA = "0x182134AE0")]
	private static void EBBBCGBJAMD(Func<string> DDBKCEMOFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2137EB0", Offset = "0x2136EB0", VA = "0x182137EB0")]
	public HAMPBKIEEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2136120", Offset = "0x2135120", VA = "0x182136120")]
	[CompilerGenerated]
	internal static (int, int?) IEDFDGBCNIK(OEFBBNFLPAL MELFENBBIPJ)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface KGHGBLABDIP
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ADCOJCAAGFK<MJDOGGEGMAI, NEMFMBIHPEH>> AACFJFDPLCJ(string KHCIFCBONLA, long INEHMKECLJM, GDJBEDDBGFK.FMFEBKPGGEH JNFCLJKLECH, CancellationToken AOAEIGNDKPI);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class MEIBLLHEHFF : OFELMDDNBPI<HAAIMGEOILO>
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class BICEMLCLBLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public HAAIMGEOILO message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BICEMLCLBLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3D5FE80", Offset = "0x3D5EE80", VA = "0x183D5FE80")]
		internal object MGOANCIIIPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static readonly MEIBLLHEHFF PCFKPPACGDB;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const string ACCEBCCLNIF = "pl";

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x28B06D0", Offset = "0x28AF6D0", VA = "0x1828B06D0")]
	public ExitGames.Client.Photon.Hashtable BCEEACLIKPE(HAAIMGEOILO FANKIHBOOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x28B0A70", Offset = "0x28AFA70", VA = "0x1828B0A70", Slot = "5")]
	protected override void LKEHBNONMPI(HAAIMGEOILO FANKIHBOOPE, IDictionary<object, object> HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x28B0750", Offset = "0x28AF750", VA = "0x1828B0750", Slot = "6")]
	public override HAAIMGEOILO BPADPDDPOEA(IDictionary<object, object> HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x28B0950", Offset = "0x28AF950", VA = "0x1828B0950")]
	private static void EBBBCGBJAMD(string CLNGOBFBGNM, HAAIMGEOILO FANKIHBOOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x28B0C20", Offset = "0x28AFC20", VA = "0x1828B0C20")]
	public MEIBLLHEHFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x28B03D0", Offset = "0x28AF3D0", VA = "0x1828B03D0")]
	[CompilerGenerated]
	internal static string APHMPBDPKCE(FHNAMDEGIOK KPMKPNDNMBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface IACDDDJJCOH<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ADCOJCAAGFK<byte[], NEMFMBIHPEH>> BKIKPKKJNDC(TGetDataArg HKOOLAFMDPF, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ADCOJCAAGFK<FOGNJLANFCJ<TData>, NEMFMBIHPEH> PIJOBLJOHHL(byte[] HCKNMLENIIG);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface ICMFGEMMOON : POPKFIFBMON, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IPDKHLDPLEM DLONNFGCHFJ(JMNGDDABPMO LILPCOEGCJF);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class DOBAEKOGGEL : CKPABOGBGFO, FOJJDFBLKKK, OHIKLOHOEIH, NKLPMCIGHDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly FOJJDFBLKKK HJDFOJEJIGG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JMNGDDABPMO BJPOJMFLLNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x212D430", Offset = "0x212C430", VA = "0x18212D430", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BGCKJEINFBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x212D5D0", Offset = "0x212C5D0", VA = "0x18212D5D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BJJAGOJACHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x212D3E0", Offset = "0x212C3E0", VA = "0x18212D3E0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool GEMCBBJEIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int MPLIEGBPHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x842FC0", Offset = "0x841FC0", VA = "0x180842FC0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event FLNBLDHGFNP.PJFOOFKEKFE APPDGOHNHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event OKLHLNGBCND OGOECNIOKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x212D530", Offset = "0x212C530", VA = "0x18212D530", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x212D680", Offset = "0x212C680", VA = "0x18212D680", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> CBPKDLBAFJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<JMNGDDABPMO> OHLNFEHCMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action MBOOGLPNLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x212D340", Offset = "0x212C340", VA = "0x18212D340", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x212D2A0", Offset = "0x212C2A0", VA = "0x18212D2A0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x93F0D0", Offset = "0x93E0D0", VA = "0x18093F0D0")]
	public DOBAEKOGGEL(FOJJDFBLKKK HJDFOJEJIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x212D480", Offset = "0x212C480", VA = "0x18212D480", Slot = "8")]
	public bool GMHNGHLHPLB(byte ENMAHFMIGNA, ExitGames.Client.Photon.Hashtable HOIIGILMOEP, PEENOHDEPNM PODKAACEILK, SendOptions CMGNINKGCHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x212D120", Offset = "0x212C120", VA = "0x18212D120", Slot = "29")]
	public JMNGDDABPMO BDDHJKJNDFB(int LFIPGKNDGIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x212D1C0", Offset = "0x212C1C0", VA = "0x18212D1C0", Slot = "16")]
	public JMNGDDABPMO CJFBPOHJFIA(int CAMPNMNOPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "19")]
	public void PKKKNGMMNHP(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "20")]
	public void NNNCCEEIKMG(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "21")]
	public void FMHLENEKING(object DMHDKAFNNAC, bool CPGAGDJBENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x212D620", Offset = "0x212C620", VA = "0x18212D620", Slot = "22")]
	public IDisposable MGMEDIMHBMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "23")]
	private bool PPGFKMNDBHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "24")]
	public void ELAJMBJNOFJ(StringBuilder CHMLAPNLAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x212D100", Offset = "0x212C100", VA = "0x18212D100", Slot = "25")]
	public bool AMHDNBBDEEH(bool ADMJMJPMFBB, out string NAFECGLLOCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public void PCCFLLAGEAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x9232E0", Offset = "0x9222E0", VA = "0x1809232E0", Slot = "28")]
	public void AKGJLPCCIND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal struct IBLPFLMJMIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly TaskCompletionSource<(IPDKHLDPLEM, Task)> MNCLNPNJINA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Task<(IPDKHLDPLEM, Task)> HCFMNLPOHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2138DF0", Offset = "0x2137DF0", VA = "0x182138DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2138E30", Offset = "0x2137E30", VA = "0x182138E30")]
	public IBLPFLMJMIF(TimeSpan OPIACMMDOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2138D00", Offset = "0x2137D00", VA = "0x182138D00")]
	public void KMAHHHJGHFL(Task ELGNEFIBDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2138BE0", Offset = "0x2137BE0", VA = "0x182138BE0")]
	public void ELLLHIKHPIK(IPDKHLDPLEM HHNCNGAMNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2138B90", Offset = "0x2137B90", VA = "0x182138B90")]
	public void BJACDFFAHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2138C70", Offset = "0x2137C70", VA = "0x182138C70")]
	internal void IGLIDEKLHAE(string FANKIHBOOPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class CJNOEJKILFJ : OCKCNNNEKNG, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool LGGKLEHONIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private BHEAAKFGKPI NEGCBCEJLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private BMIHHOPKAOM JDANGEIJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private DMKKLOAJACJ MNBJEIBNFOO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BHEAAKFGKPI FBMIFBMPDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2125B40", Offset = "0x2124B40", VA = "0x182125B40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2125BB0", Offset = "0x2124BB0", VA = "0x182125BB0", Slot = "7")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2125D20", Offset = "0x2124D20", VA = "0x182125D20", Slot = "5")]
	public void LLNMHEHOIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2125B00", Offset = "0x2124B00", VA = "0x182125B00", Slot = "6")]
	public void PPCHHCGJIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2125A80", Offset = "0x2124A80", VA = "0x182125A80")]
	private Task CFCKCMDKNHF(JDELOEPHLML OHNCPAPBFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2125B00", Offset = "0x2124B00", VA = "0x182125B00", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA79440", Offset = "0xA78440", VA = "0x180A79440")]
	public CJNOEJKILFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct ALFIGGOHKCK
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class JAFLOGHCBMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public JDNEJLBOMFE manager;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JAFLOGHCBMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x28AC0B0", Offset = "0x28AB0B0", VA = "0x1828AC0B0")]
		internal Task NLMPEJDNMID(MLICCGFKPBG data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class FBANDIDAEHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public ALFIGGOHKCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private NGDFPBDGPNO <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private KPMOLNDNALM <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private KPMOLNDNALM <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private KPMOLNDNALM <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter<KPMOLNDNALM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter<IPDKHLDPLEM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FBANDIDAEHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28A9E00", Offset = "0x28A8E00", VA = "0x1828A9E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JHDPPHCBBAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ALFIGGOHKCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JHDPPHCBBAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x28AC260", Offset = "0x28AB260", VA = "0x1828AC260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly CancellationToken AOAEIGNDKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly JDNEJLBOMFE NKHIMAEJAFL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private BMIHHOPKAOM JAHOKCHLGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2122740", Offset = "0x2121740", VA = "0x182122740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private KOGEPCGCONJ FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2122420", Offset = "0x2121420", VA = "0x182122420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private CDHOCHHBNDB AAJLKBMPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2122790", Offset = "0x2121790", VA = "0x182122790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private KFFAHHHLDMB BMAHALLAGIL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x21225C0", Offset = "0x21215C0", VA = "0x1821225C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x21228D0", Offset = "0x21218D0", VA = "0x1821228D0")]
	public ALFIGGOHKCK(CancellationToken AOAEIGNDKPI, JDNEJLBOMFE NKHIMAEJAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2122810", Offset = "0x2121810", VA = "0x182122810")]
	public static IGOEHCBIEGM NJBHCNDJINH(JDNEJLBOMFE NKHIMAEJAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2122470", Offset = "0x2121470", VA = "0x182122470")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FBANDIDAEHJ))]
	public Task<bool> ICIKLLEKAKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2122160", Offset = "0x2121160", VA = "0x182122160")]
	private bool AIGCJLKLKKG(out NGDFPBDGPNO AAHGAPCMDBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2122300", Offset = "0x2121300", VA = "0x182122300")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JHDPPHCBBAC))]
	private Task EDNJEIMJEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2122610", Offset = "0x2121610", VA = "0x182122610")]
	private Task<KPMOLNDNALM> MALNEFGPHMJ(NGDFPBDGPNO IAJBKPMCBIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class NNELEJGGMFL : DMKKLOAJACJ
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class OBCPFJFLMFO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly APHOMGELIDO LNFFFIBLNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly string CDBHHMNALJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly T AFGLNBMEDLH;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public T MNHGIJMEOAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8401D0", Offset = "0x83F1D0", VA = "0x1808401D0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8400A0", Offset = "0x83F0A0", VA = "0x1808400A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2C1AE60", Offset = "0x2C19E60", VA = "0x182C1AE60")]
		public OBCPFJFLMFO(APHOMGELIDO LNFFFIBLNOC, string CDBHHMNALJL, T AFGLNBMEDLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2C1AB00", Offset = "0x2C19B00", VA = "0x182C1AB00")]
		private void GIJJLLGACDC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly APHOMGELIDO LNFFFIBLNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly OBCPFJFLMFO<TimeSpan> PGENHNKPDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly OBCPFJFLMFO<TimeSpan> PENKHIGAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly OBCPFJFLMFO<TimeSpan> IDNILKNKAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly OBCPFJFLMFO<TimeSpan> DGCBGKENFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly OBCPFJFLMFO<bool> FLJLJIEIHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly OBCPFJFLMFO<bool> NILCONHKBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly OBCPFJFLMFO<bool> KPIFMBLCPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly OBCPFJFLMFO<int> NKPGKCCEPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly OBCPFJFLMFO<bool> DIIGDLFNDII;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private const string ADNJJNGFJCB = "RoomLoadCameraFadeTimeout";

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan IIAMLKLHOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x28B6F00", Offset = "0x28B5F00", VA = "0x1828B6F00", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan BNNGNEGOAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x28B6F80", Offset = "0x28B5F80", VA = "0x1828B6F80", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public TimeSpan OOBDEBOOCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x28B6B40", Offset = "0x28B5B40", VA = "0x1828B6B40", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public TimeSpan EJMBDCEOBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x28B6E80", Offset = "0x28B5E80", VA = "0x1828B6E80", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DCNBJBPPINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x28B6F40", Offset = "0x28B5F40", VA = "0x1828B6F40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HCECNDDALAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x28B6E40", Offset = "0x28B5E40", VA = "0x1828B6E40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool DNPLFFFBFBE
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x28B6E00", Offset = "0x28B5E00", VA = "0x1828B6E00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int OHOJDPFOACN
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28B6CD0", Offset = "0x28B5CD0", VA = "0x1828B6CD0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool GFJAAOLLAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x28B6EC0", Offset = "0x28B5EC0", VA = "0x1828B6EC0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool HCANNMDKHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x28B6D10", Offset = "0x28B5D10", VA = "0x1828B6D10", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TimeSpan PBBEPMAJCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x28B6B80", Offset = "0x28B5B80", VA = "0x1828B6B80", Slot = "12")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x28B6FC0", Offset = "0x28B5FC0", VA = "0x1828B6FC0")]
	[UnityEngine.Scripting.Preserve]
	public NNELEJGGMFL([KMDNJCFAMOJ(null)] APHOMGELIDO LNFFFIBLNOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal struct CHBDOAMDFLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MJDEAADAGPM : IAsyncStateMachine
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
		public CHBDOAMDFLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MJDEAADAGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x28B33B0", Offset = "0x28B23B0", VA = "0x1828B33B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly CancellationTokenSource KCHPCPEPOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool LOOPOECADGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private Task KMKKLLICGID;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool FHMCEOPEFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2125750", Offset = "0x2124750", VA = "0x182125750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal Task HCFMNLPOHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2125780", Offset = "0x2124780", VA = "0x182125780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2125960", Offset = "0x2124960", VA = "0x182125960")]
	public CHBDOAMDFLG(CancellationToken AOAEIGNDKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2125800", Offset = "0x2124800", VA = "0x182125800")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MJDEAADAGPM))]
	public Task PEJPJELHOCL(Func<CancellationToken, List<Task>> KJLBOPIODAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2125700", Offset = "0x2124700", VA = "0x182125700", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal interface DAKJCBGHOKB : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LHNNEBBBEAA KKDPLFKFCJN(Guid KPAGBCDJFAA);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBPDDHHFGHN(Guid KPAGBCDJFAA);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DGILHDNMFEP(Guid KPAGBCDJFAA, Task ELGNEFIBDKC);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OHCOHGMLNKF(Guid KPAGBCDJFAA, IPDKHLDPLEM IIEEIBLCAGK);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NICHPHNHEPJ(Guid KPAGBCDJFAA);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(IPDKHLDPLEM, Task)> LJBHJPLMAJN(Guid KPAGBCDJFAA);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal interface GBKCOPOOGJM : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IPDKHLDPLEM PNLMGDNOGCC(JMNGDDABPMO KABGDOEGBII, ONJJHJCBMFM LAJCEOKMOIF);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IPDKHLDPLEM NNBMCPOFLLH(JMNGDDABPMO LILPCOEGCJF);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IPDKHLDPLEM DCIOLEHLOAG(JMNGDDABPMO LILPCOEGCJF);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class FHOGADPOALB : ILINNNPDNFI
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class BNIFIOKFIPO : IAsyncStateMachine
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
		public FHOGADPOALB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private IACNHFFDGGB <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private IACNHFFDGGB <newPresenceRoomInstance>5__4;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BNIFIOKFIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3C81070", Offset = "0x3C80070", VA = "0x183C81070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private const float DNGMMBFPCBA = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly KOGEPCGCONJ JJLHNLMGEOM;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private CDHOCHHBNDB AAJLKBMPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x212F3F0", Offset = "0x212E3F0", VA = "0x18212F3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x83AA40", Offset = "0x839A40", VA = "0x18083AA40")]
	public FHOGADPOALB(JDNEJLBOMFE PODNILAEFJM, KOGEPCGCONJ JJLHNLMGEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x212F280", Offset = "0x212E280", VA = "0x18212F280", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BNIFIOKFIPO))]
	public Task<bool> GHJOPFEINPA(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x212F440", Offset = "0x212E440", VA = "0x18212F440")]
	[CompilerGenerated]
	private object PLFJIOKNEOG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal interface BHMBCGKIDBO : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JADNCHEKJPD(HAAIMGEOILO FANKIHBOOPE);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKDPLCPLEDJ(HAAIMGEOILO FANKIHBOOPE);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<ONJJHJCBMFM> JCICCENKLOD(CancellationToken LIFIJBCHKDI);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal interface CPFLKKAHAIJ : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IPDKHLDPLEM FLGMKMJLFGA(JMNGDDABPMO KABGDOEGBII);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OJEKGBADKEM(string JAGGOBHOHJG);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[UnityEngine.Scripting.Preserve]
internal class NOMMPMCLBEA : PNFFLEJMNPJ, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class IFPKGBHFKNM : IAsyncStateMachine
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
		public NOMMPMCLBEA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IFPKGBHFKNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5421990", Offset = "0x5420990", VA = "0x185421990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly NLPBKAFHPON DBCKNGCAPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private string EIKCDKINBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Task PNBJBHNGHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool OPICHLKCIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x28B7540", Offset = "0x28B6540", VA = "0x1828B7540", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Task PMFNHIBOLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x28B76E0", Offset = "0x28B66E0", VA = "0x1828B76E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x93A760", Offset = "0x939760", VA = "0x18093A760", Slot = "7")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x28B7380", Offset = "0x28B6380", VA = "0x1828B7380", Slot = "6")]
	public void CBLCKLNIFHI(Task KMKKLLICGID, string ENNFBOPFJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x28B7570", Offset = "0x28B6570", VA = "0x1828B7570")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IFPKGBHFKNM))]
	private Task GMBEIMJOMFI(Task LIJIOPLHEDD, string ENNFBOPFJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x28B7740", Offset = "0x28B6740", VA = "0x1828B7740")]
	public NOMMPMCLBEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal struct LHNNEBBBEAA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly DAKJCBGHOKB HCONINKJJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly Guid KPAGBCDJFAA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Task<(IPDKHLDPLEM, Task)> HCFMNLPOHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x28AD7A0", Offset = "0x28AC7A0", VA = "0x1828AD7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x20DB790", Offset = "0x20DA790", VA = "0x1820DB790")]
	public LHNNEBBBEAA(DAKJCBGHOKB HCONINKJJIH, Guid KPAGBCDJFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x28AD680", Offset = "0x28AC680", VA = "0x1828AD680")]
	public TaskAwaiter<(IPDKHLDPLEM, Task)> CLBNKIPBPIG()
	{
		return default(TaskAwaiter<(IPDKHLDPLEM, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x28AD6D0", Offset = "0x28AC6D0", VA = "0x1828AD6D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[UnityEngine.Scripting.Preserve]
internal sealed class MIBPFBKAPEA : KFFAHHHLDMB, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class PJFOOGLAEAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public AsyncTaskMethodBuilder<IPDKHLDPLEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public NGDFPBDGPNO autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public MIBPFBKAPEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private GLHOFFEBKJL<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private PGHDDOJGDPE <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private FHNAMDEGIOK <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private IPDKHLDPLEM <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter<IPDKHLDPLEM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PJFOOGLAEAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3D70720", Offset = "0x3D6F720", VA = "0x183D70720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class CDFILKAHICJ : IAsyncStateMachine
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
		public MIBPFBKAPEA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CDFILKAHICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3D60710", Offset = "0x3D5F710", VA = "0x183D60710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class LHMNMCNKNIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public MLICCGFKPBG _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public MIBPFBKAPEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LHMNMCNKNIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3D69C00", Offset = "0x3D68C00", VA = "0x183D69C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class HEONLBNOKFK : IAsyncStateMachine
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
		public MIBPFBKAPEA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HEONLBNOKFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3D652A0", Offset = "0x3D642A0", VA = "0x183D652A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class GMLDFHGCBOD : IAsyncStateMachine
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
		public MIBPFBKAPEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GMLDFHGCBOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3D65030", Offset = "0x3D64030", VA = "0x183D65030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class LMINDBGILBO : IAsyncStateMachine
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
		public MIBPFBKAPEA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LMINDBGILBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A6E0", Offset = "0x3D696E0", VA = "0x183D6A6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class LINDFNCCLMD : IAsyncStateMachine
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
		public MIBPFBKAPEA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LINDFNCCLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3D69FA0", Offset = "0x3D68FA0", VA = "0x183D69FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class EJNENJLDPMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public GHGMNDCOENL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public MIBPFBKAPEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private GLHOFFEBKJL<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private IKDJAENEOIK <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private IGHMMBMHKFC <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EJNENJLDPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3D627D0", Offset = "0x3D617D0", VA = "0x183D627D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private BMIHHOPKAOM JDANGEIJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private KOGEPCGCONJ JJLHNLMGEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private JOCOCPHJKKK DICCIFBHGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private PNFFLEJMNPJ HNEFIHOOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private CCNFKBCFLCE BJNDJHHFHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private CancellationTokenSource JEFMOJBLDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Task LNBNIOGMIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private TaskCompletionSource<int> LNLLMKLAEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private int HOGELOJELLJ;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x28B2500", Offset = "0x28B1500", VA = "0x1828B2500", Slot = "6")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0xE4C160", Offset = "0xE4B160", VA = "0x180E4C160", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x28B2EC0", Offset = "0x28B1EC0", VA = "0x1828B2EC0")]
	private void NCKKGMKMKAA(float IBBHFLIMHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x28B2390", Offset = "0x28B1390", VA = "0x1828B2390", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PJFOOGLAEAE))]
	public Task<IPDKHLDPLEM> IPJMMFNDMNF(NGDFPBDGPNO AAHGAPCMDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x28B20D0", Offset = "0x28B10D0", VA = "0x1828B20D0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CDFILKAHICJ))]
	public Task EJOCFNDDHEO([Optional] CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xE4C160", Offset = "0xE4B160", VA = "0x180E4C160")]
	public void DJBDADPOLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x28B2C60", Offset = "0x28B1C60", VA = "0x1828B2C60")]
	private PGHDDOJGDPE LKDCLDGPNMI(NGDFPBDGPNO AAHGAPCMDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x28B2FA0", Offset = "0x28B1FA0", VA = "0x1828B2FA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LHMNMCNKNIJ))]
	private Task NJNGBPGDLKI(MLICCGFKPBG OHNCPAPBFIL, CancellationToken JANCDKHOLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x28B3110", Offset = "0x28B2110", VA = "0x1828B3110")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HEONLBNOKFK))]
	private Task OECOPGOHHCH(CancellationToken JANCDKHOLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x28B3260", Offset = "0x28B2260", VA = "0x1828B3260")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GMLDFHGCBOD))]
	private Task OKONOAAIFDI([Optional] CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x28B2800", Offset = "0x28B1800", VA = "0x1828B2800")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LMINDBGILBO))]
	private Task KOEJPNMLLFO(CancellationToken JANCDKHOLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x28B26B0", Offset = "0x28B16B0", VA = "0x1828B26B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LINDFNCCLMD))]
	private Task KJHBCCIKEBP(CancellationToken BDNOBJJKKMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x28B2950", Offset = "0x28B1950", VA = "0x1828B2950")]
	private Task LJDGIMMABJM(GHGMNDCOENL NHJGHMDIBIC, CancellationToken JANCDKHOLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x28B1F70", Offset = "0x28B0F70", VA = "0x1828B1F70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJNENJLDPMP))]
	private Task DIIDCCDJANL(GHGMNDCOENL NHJGHMDIBIC, CancellationToken JANCDKHOLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x28B2220", Offset = "0x28B1220", VA = "0x1828B2220")]
	private bool FLGMKMJLFGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public MIBPFBKAPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface FKNLNKENNLO : POPKFIFBMON, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IPDKHLDPLEM FLGMKMJLFGA(JMNGDDABPMO GDEGDBOPGEN);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class MEHOJNAGMMG : CDHPHPDBIBF, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class FLPHCLJLPLB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private readonly IACNHFFDGGB EBNBOKDFFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private readonly CancellationTokenSource KCHPCPEPOBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public readonly CancellationToken COLCFIHLHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private bool FMCBOADOODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private bool PPEKOOOIOOG;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D64620", Offset = "0x3D63620", VA = "0x183D64620")]
		public FLPHCLJLPLB(IACNHFFDGGB EBNBOKDFFDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D644C0", Offset = "0x3D634C0", VA = "0x183D644C0")]
		public void NICHPHNHEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D64490", Offset = "0x3D63490", VA = "0x183D64490", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class KPHGHGFBLAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public JDELOEPHLML disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KPHGHGFBLAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D69660", Offset = "0x3D68660", VA = "0x183D69660")]
		internal object HFJINJNJKPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class PDOGAFAPDLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public JDELOEPHLML disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public MEHOJNAGMMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private KPHGHGFBLAD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PDOGAFAPDLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D70380", Offset = "0x3D6F380", VA = "0x183D70380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class OCEGICDDPJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OCEGICDDPJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E800", Offset = "0x3D6D800", VA = "0x183D6E800")]
		internal object OBOHJHKABMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class ABGHOJNHMOL : IAsyncStateMachine
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
		public MEHOJNAGMMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private OCEGICDDPJP <>8__1;

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
		private IACNHFFDGGB <newRoomInstance>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private ILGCEILDCHC <customRoomLoadPayload>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private Exception <ex>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public ABGHOJNHMOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D5DE20", Offset = "0x3D5CE20", VA = "0x183D5DE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class ICPJPCIDHNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public IACNHFFDGGB newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public ICPJPCIDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D668D0", Offset = "0x3D658D0", VA = "0x183D668D0")]
		internal object DKJHHPHJGIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D66850", Offset = "0x3D65850", VA = "0x183D66850")]
		internal object ACHCCOLPEFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D66890", Offset = "0x3D65890", VA = "0x183D66890")]
		internal object AMFNAGKNPNK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class LOEHGECFFHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LOEHGECFFHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3D6B2A0", Offset = "0x3D6A2A0", VA = "0x183D6B2A0")]
		internal void EBKIMAHJHCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MKOBGNPIGCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public IACNHFFDGGB newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public ILGCEILDCHC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public MEHOJNAGMMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private ICPJPCIDHNI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private LOEHGECFFHN <>8__3;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MKOBGNPIGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D6BEA0", Offset = "0x3D6AEA0", VA = "0x183D6BEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static readonly KLIPIFBEBPJ.GIDANOCOJLK GNGCDMGBOIG;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private static readonly HCKPLALPEPN LLMJHBJHDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private NAPEKDAGIPO HGBIDCLGHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private GEGDDOJAOBI IBLAABAEMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private KOGEPCGCONJ JJLHNLMGEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private DMKKLOAJACJ MNBJEIBNFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private GBCLMCDGIFC HAIFEBPKIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private long CADLALOPLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private FLPHCLJLPLB NFOGEKNIGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private bool BJHGNODCFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private Task DFHBKHPAAOK;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private CDHOCHHBNDB AAJLKBMPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x28AFBA0", Offset = "0x28AEBA0", VA = "0x1828AFBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GPHMEPHDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xB9A5E0", Offset = "0xB995E0", VA = "0x180B9A5E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x28AFBF0", Offset = "0x28AEBF0", VA = "0x1828AFBF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x28AF640", Offset = "0x28AE640", VA = "0x1828AF640", Slot = "4")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x28AF2E0", Offset = "0x28AE2E0", VA = "0x1828AF2E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x28AF8F0", Offset = "0x28AE8F0", VA = "0x1828AF8F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDOGAFAPDLN))]
	private Task JGDJFGONGMB(JDELOEPHLML FKIFALPDHLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x28AF460", Offset = "0x28AE460", VA = "0x1828AF460")]
	private void FICBOAMBMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x28AF050", Offset = "0x28AE050", VA = "0x1828AF050")]
	private void CIMMCFKHEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x28AFC00", Offset = "0x28AEC00", VA = "0x1828AFC00")]
	private void OPHKLGDFMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x28AFB20", Offset = "0x28AEB20", VA = "0x1828AFB20")]
	private bool MIODNCCFBHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x28AF1F0", Offset = "0x28AE1F0", VA = "0x1828AF1F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ABGHOJNHMOL))]
	private void COCPLLCBCGC(int MBEKKEPIMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x28AED90", Offset = "0x28ADD90", VA = "0x1828AED90")]
	private void AOIFJGBLLHK(out IDisposable EINPJLKNMBK, out IDisposable MEPDDDBIALB, out IDisposable CBPJNEEEOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x28AFA30", Offset = "0x28AEA30", VA = "0x1828AFA30")]
	private bool KCMFEDHOCJI(IACNHFFDGGB EBNBOKDFFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x28AF600", Offset = "0x28AE600", VA = "0x1828AF600")]
	private void GFAKKPPNHJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x28AFD90", Offset = "0x28AED90", VA = "0x1828AFD90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MKOBGNPIGCA))]
	private Task PFHHLMOFMFK(IACNHFFDGGB EBNBOKDFFDJ, ILGCEILDCHC DBEIEOJPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x28B0350", Offset = "0x28AF350", VA = "0x1828B0350")]
	public MEHOJNAGMMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal sealed class PGGMHNAHAPH : HDFDLFEDBFN, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class JPDNLIPBBIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JPDNLIPBBIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5423AF0", Offset = "0x5422AF0", VA = "0x185423AF0")]
		internal object NKIFAEFBHGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class NHICKKGHBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NHICKKGHBBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5425F90", Offset = "0x5424F90", VA = "0x185425F90")]
		internal object KPMEOOCCIAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private BMIHHOPKAOM JDANGEIJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private GBKCOPOOGJM DNNBPAGCCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private BHMBCGKIDBO OJCLBJHFODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private DAKJCBGHOKB HCONINKJJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private JKDBJHGFGFE ACAIHNFCCMG;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x28BD150", Offset = "0x28BC150", VA = "0x1828BD150", Slot = "6")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x28BBE80", Offset = "0x28BAE80", VA = "0x1828BBE80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x28BD560", Offset = "0x28BC560", VA = "0x1828BD560", Slot = "4")]
	public LHNNEBBBEAA LIEOCKFHHCK(HAAIMGEOILO BIFINAFNENN)
	{
		return default(LHNNEBBBEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x28BCA40", Offset = "0x28BBA40", VA = "0x1828BCA40", Slot = "5")]
	public void GLLNIHPODKM(Guid KPAGBCDJFAA, Task ELGNEFIBDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x28BBF20", Offset = "0x28BAF20", VA = "0x1828BBF20")]
	private void EDMBHGEGNNB(byte ENMAHFMIGNA, int OCBMBLDMNDI, object PIGPMIKHGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x28BC1E0", Offset = "0x28BB1E0", VA = "0x1828BC1E0")]
	private void FGKGEMLIFEN(AOLFOCFMMFJ MLPMPPLPMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x28BCC50", Offset = "0x28BBC50", VA = "0x1828BCC50")]
	private void HKAEHLBANFF(AOLFOCFMMFJ MLPMPPLPMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x28BC7F0", Offset = "0x28BB7F0", VA = "0x1828BC7F0")]
	private void FHJOHNMKBMB(AOLFOCFMMFJ MLPMPPLPMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x28BDBA0", Offset = "0x28BCBA0", VA = "0x1828BDBA0")]
	private IPDKHLDPLEM MLOAODFNOHH(HAAIMGEOILO LHDBABCMEDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x28BD9A0", Offset = "0x28BC9A0", VA = "0x1828BD9A0")]
	private void LNGNLOMMADI(HAAIMGEOILO MDIFEFNDDDI, IPDKHLDPLEM HHNCNGAMNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x28BBFF0", Offset = "0x28BAFF0", VA = "0x1828BBFF0")]
	private bool FEGAOAGOJBH(HAAIMGEOILO MDIFEFNDDDI, IPDKHLDPLEM HHNCNGAMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x28BCED0", Offset = "0x28BBED0", VA = "0x1828BCED0")]
	private bool HKFOBKHHMJC(HAAIMGEOILO PMDGHMLHCMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x28BD2C0", Offset = "0x28BC2C0", VA = "0x1828BD2C0")]
	private bool KEJDEJFDANA(byte ENMAHFMIGNA, ExitGames.Client.Photon.Hashtable MLPMPPLPMHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public PGGMHNAHAPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[UnityEngine.Scripting.Preserve]
internal sealed class GCGEELAGKPH : BHMBCGKIDBO, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GCPEMDCCGPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public AsyncTaskMethodBuilder<ONJJHJCBMFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public GCGEELAGKPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private ONJJHJCBMFM <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private TaskAwaiter<ONJJHJCBMFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GCPEMDCCGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C85F60", Offset = "0x3C84F60", VA = "0x183C85F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class EEKHNEJMBCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public HAAIMGEOILO message;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EEKHNEJMBCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3C83250", Offset = "0x3C82250", VA = "0x183C83250")]
		internal object ENBFNMGNLCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class FHHGAMFAJDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public HAAIMGEOILO messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FHHGAMFAJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C853C0", Offset = "0x3C843C0", VA = "0x183C853C0")]
		internal object LIJFMJAPCKD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class GBMDEHCOKCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public HAAIMGEOILO request;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GBMDEHCOKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C85F00", Offset = "0x3C84F00", VA = "0x183C85F00")]
		internal object CKMHBINKIHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class AGECCDJMKEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public HAAIMGEOILO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public GCGEELAGKPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private GBMDEHCOKCI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private NFDNOKDBJMA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private NFDNOKDBJMA <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<NFDNOKDBJMA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AGECCDJMKEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3C80370", Offset = "0x3C7F370", VA = "0x183C80370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class LGNEDKMPHNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public HAAIMGEOILO operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LGNEDKMPHNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E950", Offset = "0x3C8D950", VA = "0x183C8E950")]
		internal object IABDBJNCJLN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class JCLFBBCDLOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public HAAIMGEOILO operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public GCGEELAGKPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private LGNEDKMPHNB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private IKDJAENEOIK <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private HAAIMGEOILO <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private NFDNOKDBJMA <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private HAAIMGEOILO <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<HAAIMGEOILO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JCLFBBCDLOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B990", Offset = "0x3C8A990", VA = "0x183C8B990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class LJCLDANGHIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder<NFDNOKDBJMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public HAAIMGEOILO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public GCGEELAGKPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private FALKLFBFFEL.KBBCPIPBDKI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private IKDJAENEOIK <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private HAAIMGEOILO <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private HAAIMGEOILO <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private TaskAwaiter<HAAIMGEOILO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LJCLDANGHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E9B0", Offset = "0x3C8D9B0", VA = "0x183C8E9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class JDBINPGNGKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public NFDNOKDBJMA operation;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JDBINPGNGKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C3B0", Offset = "0x3C8B3B0", VA = "0x183C8C3B0")]
		internal object AKIJNHFPICB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class AFAHMKMLGOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public NFDNOKDBJMA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public GCGEELAGKPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private JDBINPGNGKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private GLHOFFEBKJL<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AFAHMKMLGOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C7FD90", Offset = "0x3C7ED90", VA = "0x183C7FD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class JADOOEAMCLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public HAAIMGEOILO request;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JADOOEAMCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B930", Offset = "0x3C8A930", VA = "0x183C8B930")]
		internal object NJOLGOBCHMH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class FLCKHAANAAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public HAAIMGEOILO request;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FLCKHAANAAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3C85520", Offset = "0x3C84520", VA = "0x183C85520")]
		internal object NFOEDJPABLK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private PNFFLEJMNPJ HNEFIHOOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private HDFDLFEDBFN GGPBPGMIJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private JOCOCPHJKKK DICCIFBHGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private BMIHHOPKAOM JDANGEIJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private TaskCompletionSource<ONJJHJCBMFM> FOKHCIMOCCI;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2132AA0", Offset = "0x2131AA0", VA = "0x182132AA0", Slot = "7")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2132930", Offset = "0x2131930", VA = "0x182132930", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GCPEMDCCGPD))]
	public Task<ONJJHJCBMFM> JCICCENKLOD(CancellationToken LIFIJBCHKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2132510", Offset = "0x2131510", VA = "0x182132510", Slot = "4")]
	public void JADNCHEKJPD(HAAIMGEOILO FANKIHBOOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x21334B0", Offset = "0x21324B0", VA = "0x1821334B0", Slot = "5")]
	public void OKDPLCPLEDJ(HAAIMGEOILO JNNAGALDLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2133210", Offset = "0x2132210", VA = "0x182133210")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AGECCDJMKEM))]
	private Task OBPDPIODEDF(HAAIMGEOILO NJAMEFJLMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2133360", Offset = "0x2132360", VA = "0x182133360")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JCLFBBCDLOL))]
	private Task OIBADEDBGLG(HAAIMGEOILO MDIFEFNDDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2133890", Offset = "0x2132890", VA = "0x182133890")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LJCLDANGHIG))]
	private Task<NFDNOKDBJMA> OKOBLALFLHP(HAAIMGEOILO NJAMEFJLMOC, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2132B80", Offset = "0x2131B80", VA = "0x182132B80")]
	private IKDJAENEOIK LLJBPGODBPC(HAAIMGEOILO LHDBABCMEDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x21323A0", Offset = "0x21313A0", VA = "0x1821323A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AFAHMKMLGOK))]
	private Task GNPEKGHMHKK(NFDNOKDBJMA IBOEOPFBKMK, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2132C00", Offset = "0x2131C00", VA = "0x182132C00")]
	private NFDNOKDBJMA NKNOLKDBAGH(HAAIMGEOILO NJAMEFJLMOC, IKDJAENEOIK KHMKLDBMCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x13EDD30", Offset = "0x13ECD30", VA = "0x1813EDD30")]
	private T BPKFIONCOEJ<T>(T CKMKMNKGMMC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2132E20", Offset = "0x2131E20", VA = "0x182132E20")]
	private NFDNOKDBJMA OAENBHJFJID(HAAIMGEOILO NJAMEFJLMOC, IKDJAENEOIK KHMKLDBMCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public GCGEELAGKPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal interface DMKKLOAJACJ
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TimeSpan IIAMLKLHOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	TimeSpan BNNGNEGOAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	TimeSpan OOBDEBOOCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	TimeSpan EJMBDCEOBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool DCNBJBPPINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool HCECNDDALAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool DNPLFFFBFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool HCANNMDKHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	TimeSpan PBBEPMAJCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int OHOJDPFOACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool GFJAAOLLAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal interface AMCKMBNLFMO : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FHNAMDEGIOK> LDICHBDCKLI(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, IACNHFFDGGB NCMDIOLBALM, CancellationToken AOAEIGNDKPI);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class KBDKMIBGJEP : ILINNNPDNFI
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class AHPJBBBLKEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public KBDKMIBGJEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public Matchmaking.FLAFGOMJGIO result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public IACNHFFDGGB newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AHPJBBBLKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EBF0", Offset = "0x3D5DBF0", VA = "0x183D5EBF0")]
		internal object NJIDJNKCGME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EDE0", Offset = "0x3D5DDE0", VA = "0x183D5EDE0")]
		internal object OMJPDMGNPDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3D5ED40", Offset = "0x3D5DD40", VA = "0x183D5ED40")]
		internal object NMNLLFBFFLL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class BEFBBGIHBOE : IAsyncStateMachine
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
		public KBDKMIBGJEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private AHPJBBBLKEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private Matchmaking.FLAFGOMJGIO <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter<Matchmaking.FLAFGOMJGIO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BEFBBGIHBOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F090", Offset = "0x3D5E090", VA = "0x183D5F090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private const float DNGMMBFPCBA = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private readonly JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private readonly KOGEPCGCONJ JJLHNLMGEOM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private CDHOCHHBNDB AAJLKBMPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x213FD80", Offset = "0x213ED80", VA = "0x18213FD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x83AA40", Offset = "0x839A40", VA = "0x18083AA40")]
	public KBDKMIBGJEP(JDNEJLBOMFE PODNILAEFJM, KOGEPCGCONJ JJLHNLMGEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x213FC10", Offset = "0x213EC10", VA = "0x18213FC10", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BEFBBGIHBOE))]
	public Task<bool> GHJOPFEINPA(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal interface CDHPHPDBIBF : NAJLJPDBPKB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal interface ILINNNPDNFI
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> GHJOPFEINPA(CancellationToken AOAEIGNDKPI);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface HKHOADPMHMG
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAJJONCIDBF(LJJLLJAJOOO ECOMMAJJKHI);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNFLNECIJGF(LJJLLJAJOOO ECOMMAJJKHI);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAOCDLHBICG(LJJLLJAJOOO ECOMMAJJKHI);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHBAMHBDFBB(LJJLLJAJOOO ECOMMAJJKHI);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LJJLLJAJOOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public readonly IACNHFFDGGB IPKJEFGEDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private Dictionary<string, string> PLAGJKALGJF;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public GLHOFFEBKJL<string> IBMGLEFJAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x93A6D0", Offset = "0x9396D0", VA = "0x18093A6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x934550", Offset = "0x933550", VA = "0x180934550")]
	public LJJLLJAJOOO(IACNHFFDGGB LKKJHIDALEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x28AD910", Offset = "0x28AC910", VA = "0x1828AD910")]
	public LJJLLJAJOOO FECKBBDJOMI(string CDBHHMNALJL, string CKMKMNKGMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x28AD870", Offset = "0x28AC870", VA = "0x1828AD870")]
	public bool ABFGDKPJFMJ(out IEnumerable<KeyValuePair<string, string>> EEDMCIBFPDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x225D570", Offset = "0x225C570", VA = "0x18225D570")]
	public LJJLLJAJOOO FOBMPNEMFHM(GLHOFFEBKJL<string> IMDANOAGPHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class MLJCOFKMEJP : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0xBF11F0", Offset = "0xBF01F0", VA = "0x180BF11F0")]
	public MLJCOFKMEJP(string FANKIHBOOPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public interface CDHOCHHBNDB
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IACNHFFDGGB EOBCLNIKALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	HFCNBIIEHLN GGIAGGIEAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BHKIGNODGGN OJHHCHGDLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool GKKCAOAFCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool FHNBEPPBGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	int JPJHIKNCGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action FICBOAMBMKI;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<int> COCPLLCBCGC;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NCMPICGJCEI();

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.NNODEKHKLIG> BLNINOBLCEL(long INEHMKECLJM, [Optional] CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.FLAFGOMJGIO> KBNEDJEFOKH();

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task DBOLJICONBP();

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(IACNHFFDGGB, ILGCEILDCHC) MDAJGDHANAC();

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AMEDHPDPDLP EBPBLLNLIHO();

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DAMBLCAKFFC(long INEHMKECLJM);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal interface JOCOCPHJKKK : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HAAIMGEOILO> KIIDHHHGHHA(HAAIMGEOILO NJAMEFJLMOC, IKDJAENEOIK KHMKLDBMCFM, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<HAAIMGEOILO> GKCDNDFNMHE(CancellationToken AOAEIGNDKPI, IKDJAENEOIK KHMKLDBMCFM);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DEGFCGHLJFD IEEJGGECJNB(NFDNOKDBJMA OOGKNODDOIC, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DEGFCGHLJFD EIKNOJNDJCC(NFDNOKDBJMA OOGKNODDOIC, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class FLLLEOEKJPA : JDNEJLBOMFE, DJAJPIOICAP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class FGCPEOJEABG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<IPDKHLDPLEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public NGDFPBDGPNO autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public FLLLEOEKJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private IPDKHLDPLEM <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private IPDKHLDPLEM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter<IPDKHLDPLEM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FGCPEOJEABG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3C84240", Offset = "0x3C83240", VA = "0x183C84240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class LELLGIILDCM : IAsyncStateMachine
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
		public FLLLEOEKJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private IPDKHLDPLEM <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LELLGIILDCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E6F0", Offset = "0x3C8D6F0", VA = "0x183C8E6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class HKCCMKGMIFD : IEnumerable<NAJLJPDBPKB>, IEnumerable, IEnumerator<NAJLJPDBPKB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private NAJLJPDBPKB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public FLLLEOEKJPA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private NAJLJPDBPKB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xB730E0", Offset = "0xB720E0", VA = "0x180B730E0")]
		[DebuggerHidden]
		public HKCCMKGMIFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B0C0", Offset = "0x3C8A0C0", VA = "0x183C8B0C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B540", Offset = "0x3C8A540", VA = "0x183C8B540", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B4A0", Offset = "0x3C8A4A0", VA = "0x183C8B4A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NAJLJPDBPKB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B4A0", Offset = "0x3C8A4A0", VA = "0x183C8B4A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private readonly CancellationTokenSource PKJJCIPEHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private readonly ECDJHHJLGGB LADPAJPBFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private bool LOOPOECADGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private OKGHEHBINHO CGLJPAFCKKJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public BMIHHOPKAOM JAHOKCHLGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x94B760", Offset = "0x94A760", VA = "0x18094B760", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x94AD10", Offset = "0x949D10", VA = "0x18094AD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NAPEKDAGIPO LBLPDFBHHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x947AC0", Offset = "0x946AC0", VA = "0x180947AC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x9476E0", Offset = "0x9466E0", VA = "0x1809476E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public KOGEPCGCONJ FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x92FA50", Offset = "0x92EA50", VA = "0x18092FA50", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x92FC50", Offset = "0x92EC50", VA = "0x18092FC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public AMHFGBDMPHO AHDHPIHKONG
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x962CB0", Offset = "0x961CB0", VA = "0x180962CB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9629F0", Offset = "0x9619F0", VA = "0x1809629F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICMFGEMMOON OCEKAGFPNOK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x848B60", Offset = "0x847B60", VA = "0x180848B60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x848B90", Offset = "0x847B90", VA = "0x180848B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public FKNLNKENNLO LDBBDAIDDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x94AC50", Offset = "0x949C50", VA = "0x18094AC50", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x94ABD0", Offset = "0x949BD0", VA = "0x18094ABD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public DKIKCOHPEBM KDPHNHHCOPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x94AD40", Offset = "0x949D40", VA = "0x18094AD40", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x94ACA0", Offset = "0x949CA0", VA = "0x18094ACA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public PNFFLEJMNPJ LKCIIAIJILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x94ABE0", Offset = "0x949BE0", VA = "0x18094ABE0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x842370", VA = "0x180843370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public KFFAHHHLDMB BMAHALLAGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA19A10", Offset = "0xA18A10", VA = "0x180A19A10", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA8F180", Offset = "0xA8E180", VA = "0x180A8F180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IAIGPKNELON FJEGPMCMPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA823E0", Offset = "0xA813E0", VA = "0x180A823E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xADB170", Offset = "0xADA170", VA = "0x180ADB170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public GEGDDOJAOBI KBHCNLPMJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x842FB0", Offset = "0x841FB0", VA = "0x180842FB0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x842EA0", Offset = "0x841EA0", VA = "0x180842EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public GBCLMCDGIFC HHGNIIPPJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xBEC0C0", Offset = "0xBEB0C0", VA = "0x180BEC0C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xBEC280", Offset = "0xBEB280", VA = "0x180BEC280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public CCNFKBCFLCE KPIJDHAGMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x840E00", Offset = "0x83FE00", VA = "0x180840E00", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xE70390", Offset = "0xE6F390", VA = "0x180E70390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public DAKJCBGHOKB CLDDKIBECPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x977040", Offset = "0x976040", VA = "0x180977040", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xC17E70", Offset = "0xC16E70", VA = "0x180C17E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public CDHPHPDBIBF GABDHEDNAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA19A00", Offset = "0xA18A00", VA = "0x180A19A00", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA7E2B0", Offset = "0xA7D2B0", VA = "0x180A7E2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public BHMBCGKIDBO HLFFJKMDAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xE8C420", Offset = "0xE8B420", VA = "0x180E8C420", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xF28D70", Offset = "0xF27D70", VA = "0x180F28D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public HDFDLFEDBFN AGPCEHHPFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x9950C0", Offset = "0x9940C0", VA = "0x1809950C0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x97EC90", Offset = "0x97DC90", VA = "0x18097EC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public MNBFPGDJMJD LNKKEMDJAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA2A240", Offset = "0xA29240", VA = "0x180A2A240", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xAAA960", Offset = "0xAA9960", VA = "0x180AAA960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public AMCKMBNLFMO HIKDGBGDKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9A78B0", Offset = "0x9A68B0", VA = "0x1809A78B0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA05CA0", Offset = "0xA04CA0", VA = "0x180A05CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public JOCOCPHJKKK NCMJIAOMLCA
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9A78A0", Offset = "0x9A68A0", VA = "0x1809A78A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA18E90", Offset = "0xA17E90", VA = "0x180A18E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public CPFLKKAHAIJ DOIHEPAAAGL
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xE56B30", Offset = "0xE55B30", VA = "0x180E56B30", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xE55F50", Offset = "0xE54F50", VA = "0x180E55F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public GBKCOPOOGJM LMOKBPAMFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA05B30", Offset = "0xA04B30", VA = "0x180A05B30", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xAE8E40", Offset = "0xAE7E40", VA = "0x180AE8E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public HKHOADPMHMG PPMGDFLKHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAA8F60", Offset = "0xAA7F60", VA = "0x180AA8F60", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xE56A50", Offset = "0xE55A50", VA = "0x180E56A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public JKDBJHGFGFE MPMINNBJGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA06970", Offset = "0xA05970", VA = "0x180A06970", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xA06980", Offset = "0xA05980", VA = "0x180A06980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public OCKCNNNEKNG KDOKFDNCCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xAC4800", Offset = "0xAC3800", VA = "0x180AC4800", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA77080", Offset = "0xA76080", VA = "0x180A77080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public DMKKLOAJACJ FDHGDOPDDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x94AC60", Offset = "0x949C60", VA = "0x18094AC60", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x94ABC0", Offset = "0x949BC0", VA = "0x18094ABC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public ICOLHCPNMGH MGDDKMGKNKP
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA164C0", Offset = "0xA154C0", VA = "0x180A164C0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xE81740", Offset = "0xE80740", VA = "0x180E81740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public MDFGFKODPDB KEBMKMOJJFL
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA14050", Offset = "0xA13050", VA = "0x180A14050", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public NLBKCIFAEMC MFBKGFKMNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9AA970", Offset = "0x9A9970", VA = "0x1809AA970", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public CLEKDBIBPBA EFOLGGKKEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xAE9640", Offset = "0xAE8640", VA = "0x180AE9640", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ILGCEILDCHC BHOKDEJKPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x976DF0", Offset = "0x975DF0", VA = "0x180976DF0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x96E910", Offset = "0x96D910", VA = "0x18096E910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private bool PACBHLALCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2130AE0", Offset = "0x212FAE0", VA = "0x182130AE0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private bool PBLBKDNFAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x21301E0", Offset = "0x212F1E0", VA = "0x1821301E0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Task GHCHPBIPNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x21309C0", Offset = "0x212F9C0", VA = "0x1821309C0", Slot = "49")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private CancellationToken LENEODGHKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2130C60", Offset = "0x212FC60", VA = "0x182130C60", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private ECDJHHJLGGB JHFPEKJLIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action DGAEDKLHJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2130070", Offset = "0x212F070", VA = "0x182130070", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2130640", Offset = "0x212F640", VA = "0x182130640", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event IJFGDNEKBFA JLHBHJBKOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2130180", Offset = "0x212F180", VA = "0x182130180", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2130B40", Offset = "0x212FB40", VA = "0x182130B40", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event IJFGDNEKBFA CBBMECAPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2130A80", Offset = "0x212FA80", VA = "0x182130A80", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x21305E0", Offset = "0x212F5E0", VA = "0x1821305E0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event IJFGDNEKBFA LPBIBLDPPKF
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2130120", Offset = "0x212F120", VA = "0x182130120", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2130010", Offset = "0x212F010", VA = "0x182130010", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<NOOIKMHHFGH, bool> DONMBKLLMNA
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2130C00", Offset = "0x212FC00", VA = "0x182130C00", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2130BA0", Offset = "0x212FBA0", VA = "0x182130BA0", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x96E910", Offset = "0x96D910", VA = "0x18096E910", Slot = "36")]
	public void BLJCHAIMKKI(ILGCEILDCHC PAFMPLIFAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2130C80", Offset = "0x212FC80", VA = "0x182130C80")]
	[UnityEngine.Scripting.Preserve]
	internal FLLLEOEKJPA([KMDNJCFAMOJ(null)] ECDJHHJLGGB LADPAJPBFMP, [KMDNJCFAMOJ(null)] BMIHHOPKAOM JDANGEIJBKM, [KMDNJCFAMOJ(null)] NAPEKDAGIPO HGBIDCLGHFL, [KMDNJCFAMOJ(null)] KOGEPCGCONJ JJLHNLMGEOM, [KMDNJCFAMOJ(null)] AMHFGBDMPHO GKACFBLKAML, [KMDNJCFAMOJ(null)] ICMFGEMMOON MFGKLAIAKLH, [KMDNJCFAMOJ(null)] FKNLNKENNLO LBONNBDKDDA, [KMDNJCFAMOJ(null)] DKIKCOHPEBM PPDNJLMMOEM, [KMDNJCFAMOJ(null)] PNFFLEJMNPJ HNEFIHOOCBB, [KMDNJCFAMOJ(null)] KFFAHHHLDMB MFIKOBBKOEJ, [KMDNJCFAMOJ(null)] IAIGPKNELON HNGMLJEMCHC, [KMDNJCFAMOJ(null)] GEGDDOJAOBI IBLAABAEMJA, [KMDNJCFAMOJ(null)] GBCLMCDGIFC HAIFEBPKIMB, [KMDNJCFAMOJ(null)] CCNFKBCFLCE BJNDJHHFHOD, [KMDNJCFAMOJ(null)] DAKJCBGHOKB HCONINKJJIH, [KMDNJCFAMOJ(null)] CDHPHPDBIBF OOHFIIAMCMG, [KMDNJCFAMOJ(null)] BHMBCGKIDBO OJCLBJHFODD, [KMDNJCFAMOJ(null)] HDFDLFEDBFN GGPBPGMIJGF, [KMDNJCFAMOJ(null)] MNBFPGDJMJD JEHCEFGFDHI, [KMDNJCFAMOJ(null)] AMCKMBNLFMO PMJOENFPEHF, [KMDNJCFAMOJ(null)] CPFLKKAHAIJ DAEPOIALHPF, [KMDNJCFAMOJ(null)] JOCOCPHJKKK DICCIFBHGLC, [KMDNJCFAMOJ(null)] GBKCOPOOGJM DNNBPAGCCOP, [KMDNJCFAMOJ(null)] HKHOADPMHMG GBDNADBNNEH, [KMDNJCFAMOJ(null)] JKDBJHGFGFE ACAIHNFCCMG, [KMDNJCFAMOJ(null)] DMKKLOAJACJ MNBJEIBNFOO, [KMDNJCFAMOJ(null)] ICOLHCPNMGH NGENFPJLNIN, [KMDNJCFAMOJ(null)] MDFGFKODPDB CHMDCFBAKIE, [KMDNJCFAMOJ(null)] NLBKCIFAEMC DLKJNCCNCEK, [KMDNJCFAMOJ(null)] CLEKDBIBPBA NJABNINNONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2130850", Offset = "0x212F850", VA = "0x182130850")]
	private void JFGMJMMFADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2130260", Offset = "0x212F260", VA = "0x182130260", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x21300D0", Offset = "0x212F0D0", VA = "0x1821300D0", Slot = "50")]
	private void APJOHFHMFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2130560", Offset = "0x212F560", VA = "0x182130560", Slot = "51")]
	private ONBNMFLMCNF FFECOFLCFFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2130940", Offset = "0x212F940", VA = "0x182130940", Slot = "52")]
	private PFKCHGGNLIB JNOBEEFIEAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x21303F0", Offset = "0x212F3F0", VA = "0x1821303F0", Slot = "53")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FGCPEOJEABG))]
	private Task<IPDKHLDPLEM> EHKJENHEAFK(NGDFPBDGPNO AAHGAPCMDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x21306A0", Offset = "0x212F6A0", VA = "0x1821306A0", Slot = "54")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LELLGIILDCM))]
	private Task GMIHIIAPOPB(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2130A10", Offset = "0x212FA10", VA = "0x182130A10")]
	[IteratorStateMachine(typeof(HKCCMKGMIFD))]
	private IEnumerable<NAJLJPDBPKB> KNJPAJFNLJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x21307F0", Offset = "0x212F7F0", VA = "0x1821307F0")]
	[CompilerGenerated]
	private void HFJPGBFGFLH(NAJLJPDBPKB LMOLNJNIDGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class MEBMACMOCOC : AMCKMBNLFMO, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class LJBNMBMDFPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<FHNAMDEGIOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public IACNHFFDGGB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public MEBMACMOCOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private HFCNBIIEHLN <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private HFCNBIIEHLN <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<HFCNBIIEHLN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LJBNMBMDFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A410", Offset = "0x3D69410", VA = "0x183D6A410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class OGANFLEAONP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OGANFLEAONP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E870", Offset = "0x3D6D870", VA = "0x183D6E870")]
		internal object JNHFAOPPOFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class PKKOFHGJDHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public AsyncTaskMethodBuilder<HFCNBIIEHLN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public IACNHFFDGGB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public MEBMACMOCOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private OGANFLEAONP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private HFCNBIIEHLN <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<HFCNBIIEHLN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PKKOFHGJDHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3D70F20", Offset = "0x3D6FF20", VA = "0x183D70F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class OGOPKJCBFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OGOPKJCBFFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xB672E0", Offset = "0xB662E0", VA = "0x180B672E0")]
		internal bool NGJOABMACBB(BHKIGNODGGN sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private KOGEPCGCONJ JJLHNLMGEOM;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private static readonly (LMFNHKGJLBN superRoomData, long subRoomDataSaveId) DEAJFBHFFEM;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x28AE790", Offset = "0x28AD790", VA = "0x1828AE790", Slot = "5")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x28AE940", Offset = "0x28AD940", VA = "0x1828AE940", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LJBNMBMDFPK))]
	public Task<FHNAMDEGIOK> LDICHBDCKLI(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, IACNHFFDGGB NCMDIOLBALM, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x28AEB00", Offset = "0x28ADB00", VA = "0x1828AEB00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PKKOFHGJDHI))]
	private Task<HFCNBIIEHLN> LJLFNAPEICC(IACNHFFDGGB NCMDIOLBALM, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x28AE800", Offset = "0x28AD800", VA = "0x1828AE800")]
	private FHNAMDEGIOK LCJCJABOKHI(IACNHFFDGGB NCMDIOLBALM, HFCNBIIEHLN KLFEHFNEONK, long HCLBMOKINEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x28AE400", Offset = "0x28AD400", VA = "0x1828AE400")]
	private (LMFNHKGJLBN, long) EPHBAKAPLBC(IACNHFFDGGB NCMDIOLBALM, HFCNBIIEHLN KLFEHFNEONK, long HCLBMOKINEP)
	{
		return default((LMFNHKGJLBN, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public MEBMACMOCOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface AMHFGBDMPHO
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool PLHBKDJHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	string NFLFNLOBPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBEEGMPDJGM(Scene OBLEOIAELKE);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BFKMAJNJAMD(MJDOGGEGMAI HAAFMHMNADM, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task KFJFJMFPHKB();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[UnityEngine.Scripting.Preserve]
internal sealed class IEDOILOMFNI : JOCOCPHJKKK, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class AGMFFMAEJAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public HAAIMGEOILO request;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AGMFFMAEJAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EB90", Offset = "0x3D5DB90", VA = "0x183D5EB90")]
		internal object NBKHFABMNHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class NDKHIIEANAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AsyncTaskMethodBuilder<HAAIMGEOILO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public HAAIMGEOILO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public IKDJAENEOIK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public IEDOILOMFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private AGMFFMAEJAC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private HAAIMGEOILO <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private HAAIMGEOILO <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter<HAAIMGEOILO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NDKHIIEANAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D6D200", Offset = "0x3D6C200", VA = "0x183D6D200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class JENKFHBKPNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder<HAAIMGEOILO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public IKDJAENEOIK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public IEDOILOMFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private BHEAAKFGKPI.HLENJMOIMEN<HAAIMGEOILO> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private ANOMGNDJDAN <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter<ANOMGNDJDAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JENKFHBKPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x3D67B50", Offset = "0x3D66B50", VA = "0x183D67B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class GLCKLFKHBIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public HAAIMGEOILO request;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GLCKLFKHBIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D64FD0", Offset = "0x3D63FD0", VA = "0x183D64FD0")]
		internal object OHMKPGODMKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class OJMOOOEOBAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public AsyncTaskMethodBuilder<HAAIMGEOILO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public HAAIMGEOILO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public IKDJAENEOIK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public IEDOILOMFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private GLCKLFKHBIL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private NDLGDKLMKOL <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private KOEDKEJNPCO <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private BHEAAKFGKPI.HLENJMOIMEN<HAAIMGEOILO> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private HAAIMGEOILO <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private NDLGDKLMKOL <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private ANOMGNDJDAN <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private TaskAwaiter<ANOMGNDJDAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OJMOOOEOBAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E920", Offset = "0x3D6D920", VA = "0x183D6E920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private BMIHHOPKAOM JDANGEIJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private OCKCNNNEKNG AGNFPPIGKFI;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private BHEAAKFGKPI FBMIFBMPDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2139730", Offset = "0x2138730", VA = "0x182139730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2139DC0", Offset = "0x2138DC0", VA = "0x182139DC0", Slot = "8")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2139E50", Offset = "0x2138E50", VA = "0x182139E50", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NDKHIIEANAP))]
	public Task<HAAIMGEOILO> KIIDHHHGHHA(HAAIMGEOILO NJAMEFJLMOC, IKDJAENEOIK KHMKLDBMCFM, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x21397E0", Offset = "0x21387E0", VA = "0x1821397E0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JENKFHBKPNL))]
	public Task<HAAIMGEOILO> GKCDNDFNMHE(CancellationToken AOAEIGNDKPI, IKDJAENEOIK KHMKLDBMCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2139B40", Offset = "0x2138B40", VA = "0x182139B40", Slot = "6")]
	public DEGFCGHLJFD IEEJGGECJNB(NFDNOKDBJMA OOGKNODDOIC, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x21394B0", Offset = "0x21384B0", VA = "0x1821394B0", Slot = "7")]
	public DEGFCGHLJFD EIKNOJNDJCC(NFDNOKDBJMA OOGKNODDOIC, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2139980", Offset = "0x2138980", VA = "0x182139980")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OJMOOOEOBAI))]
	private Task<HAAIMGEOILO> GPLKOKPHEHL(HAAIMGEOILO NJAMEFJLMOC, IKDJAENEOIK KHMKLDBMCFM, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x213A010", Offset = "0x2139010", VA = "0x18213A010")]
	private static byte[] NCKHIBJLOJC(HAAIMGEOILO FANKIHBOOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x213A020", Offset = "0x2139020", VA = "0x18213A020")]
	private static string NMHEKCBELPI(byte[] HKOOLAFMDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public IEDOILOMFNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public readonly struct PBENKKBPEBM<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class HINAGBBELDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AsyncTaskMethodBuilder<ADCOJCAAGFK<FOGNJLANFCJ<TData>, NEMFMBIHPEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public PBENKKBPEBM<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private ADCOJCAAGFK<byte[], NEMFMBIHPEH> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private ADCOJCAAGFK<byte[], NEMFMBIHPEH> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private TaskAwaiter<ADCOJCAAGFK<byte[], NEMFMBIHPEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public HINAGBBELDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x3081B10", Offset = "0x3080B10", VA = "0x183081B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private readonly IACDDDJJCOH<TGetDataArg, TData> KPGBJJBPKMJ;

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xA9F760", Offset = "0xA9E760", VA = "0x180A9F760")]
	internal PBENKKBPEBM(IACDDDJJCOH<TGetDataArg, TData> LGKMJKEAAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x32D0760", Offset = "0x32CF760", VA = "0x1832D0760")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBENKKBPEBM<, >.HINAGBBELDP))]
	public Task<ADCOJCAAGFK<FOGNJLANFCJ<TData>, NEMFMBIHPEH>> NLKOHFKCOKD(TGetDataArg HKOOLAFMDPF, string OLOJPBPMMPD, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class KHKBGJLOMMK
{
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x20B4F40", Offset = "0x20B3F40", VA = "0x1820B4F40")]
	public static PBENKKBPEBM<TGetDataArg, TData> CECGBIGMPDN<TGetDataArg, TData>(IACDDDJJCOH<TGetDataArg, TData> LGKMJKEAAMO)
	{
		return default(PBENKKBPEBM<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[UnityEngine.Scripting.Preserve]
internal sealed class KKNAIOOKFEL : MNBFPGDJMJD, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class CKJDILCBDCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public ONJJHJCBMFM operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public KKNAIOOKFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public HAAIMGEOILO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CKJDILCBDCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D610B0", Offset = "0x3D600B0", VA = "0x183D610B0")]
		internal object KAHINCFOPON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x3D60F80", Offset = "0x3D5FF80", VA = "0x183D60F80")]
		internal object AIPEHJNCINL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class IOHFBNCOHBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<IPDKHLDPLEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public HAAIMGEOILO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public KKNAIOOKFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private CKJDILCBDCH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private IPDKHLDPLEM <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private IPDKHLDPLEM <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<IPDKHLDPLEM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IOHFBNCOHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x3D67590", Offset = "0x3D66590", VA = "0x183D67590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class CJBKELEABML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public ONJJHJCBMFM operationType;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CJBKELEABML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x3D60F10", Offset = "0x3D5FF10", VA = "0x183D60F10")]
		internal object GOKPPABBKGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class BBHLMMMDHFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public HAAIMGEOILO request;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BBHLMMMDHFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F010", Offset = "0x3D5E010", VA = "0x183D5F010")]
		internal object ODCNMIAFDOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EF90", Offset = "0x3D5DF90", VA = "0x183D5EF90")]
		internal object GLCGJECNAMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EF10", Offset = "0x3D5DF10", VA = "0x183D5EF10")]
		internal object CBKPOOEJBOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class NJFOMPJLFEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder<IPDKHLDPLEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public HAAIMGEOILO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public KKNAIOOKFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private BBHLMMMDHFH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private LHNNEBBBEAA <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private IPDKHLDPLEM <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private (IPDKHLDPLEM validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private (IPDKHLDPLEM validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private TaskAwaiter<(IPDKHLDPLEM validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NJFOMPJLFEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x3D6D690", Offset = "0x3D6C690", VA = "0x183D6D690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private BMIHHOPKAOM JDANGEIJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private GBKCOPOOGJM DNNBPAGCCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private HDFDLFEDBFN GGPBPGMIJGF;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2140510", Offset = "0x213F510", VA = "0x182140510", Slot = "5")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2140820", Offset = "0x213F820", VA = "0x182140820", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IOHFBNCOHBD))]
	private Task<IPDKHLDPLEM> OBOLDEBFGLA(HAAIMGEOILO LHDBABCMEDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x21405C0", Offset = "0x213F5C0", VA = "0x1821405C0")]
	private bool MPKAGBMFINO(ONJJHJCBMFM GFEALFGNOCP, out IPDKHLDPLEM MLAOHBBKEKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x21403A0", Offset = "0x213F3A0", VA = "0x1821403A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NJFOMPJLFEF))]
	private Task<IPDKHLDPLEM> EDJCBPDMEGG(HAAIMGEOILO NJAMEFJLMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public KKNAIOOKFEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class IOELMOPGLIC
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public static IPDKHLDPLEM DHKGAJBLJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x213BD60", Offset = "0x213AD60", VA = "0x18213BD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x213D990", Offset = "0x213C990", VA = "0x18213D990")]
	public static bool CHNJHMGOEJH(this IPDKHLDPLEM HHNCNGAMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x213B950", Offset = "0x213A950", VA = "0x18213B950")]
	public static IPDKHLDPLEM MNNIAENOIJO(CDPHGAFOIMM FLOPKLHBFLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x213D760", Offset = "0x213C760", VA = "0x18213D760")]
	public static IPDKHLDPLEM AOAKANCEBAH(params IPDKHLDPLEM[] IEFEIOBNNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x213D770", Offset = "0x213C770", VA = "0x18213D770")]
	public static IPDKHLDPLEM CGOIKMELONA(IEnumerable<IPDKHLDPLEM> IEFEIOBNNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x213D9C0", Offset = "0x213C9C0", VA = "0x18213D9C0")]
	public static string HBFGCPMLHKG(this IPDKHLDPLEM MLAOHBBKEKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[UnityEngine.Scripting.Preserve]
internal sealed class IMCKBKHKAME : GBKCOPOOGJM, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private ICMFGEMMOON MFGKLAIAKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private BMIHHOPKAOM JDANGEIJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private PNFFLEJMNPJ HNEFIHOOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private CPFLKKAHAIJ DAEPOIALHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private KOGEPCGCONJ JJLHNLMGEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private GBCLMCDGIFC HAIFEBPKIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private CCNFKBCFLCE BJNDJHHFHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private DMKKLOAJACJ MNBJEIBNFOO;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private CDHOCHHBNDB AAJLKBMPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x213B9C0", Offset = "0x213A9C0", VA = "0x18213B9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private static IPDKHLDPLEM DHKGAJBLJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x213BD60", Offset = "0x213AD60", VA = "0x18213BD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x213B7F0", Offset = "0x213A7F0", VA = "0x18213B7F0", Slot = "7")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x213BDC0", Offset = "0x213ADC0", VA = "0x18213BDC0", Slot = "4")]
	public IPDKHLDPLEM PNLMGDNOGCC(JMNGDDABPMO KABGDOEGBII, ONJJHJCBMFM LAJCEOKMOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x213BA10", Offset = "0x213AA10", VA = "0x18213BA10", Slot = "5")]
	public IPDKHLDPLEM NNBMCPOFLLH(JMNGDDABPMO LILPCOEGCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x213B540", Offset = "0x213A540", VA = "0x18213B540", Slot = "6")]
	public IPDKHLDPLEM DCIOLEHLOAG(JMNGDDABPMO LILPCOEGCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x213B950", Offset = "0x213A950", VA = "0x18213B950")]
	private static IPDKHLDPLEM MNNIAENOIJO(CDPHGAFOIMM LLGBBMDFDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public IMCKBKHKAME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public delegate Task IGOEHCBIEGM(MLICCGFKPBG EICHFPBIJBD, CancellationToken DMHDKAFNNAC);
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal interface CCNFKBCFLCE : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool LHBJEEEAMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ANADLIPLHPM(IGOEHCBIEGM NBOFCLPBPGJ);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface JKDBJHGFGFE
{
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OCLLNFOCAPC(out IEnumerable<int> GNNEGJJHGPO);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIDJGALKMBN(NLPBKAFHPON DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHCPNLBJOOJ(NLPBKAFHPON DMHDKAFNNAC);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface IEJEDJIHFPA
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FHHNLEIICAE(IPDKHLDPLEM HHNCNGAMNPE);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal interface MNBFPGDJMJD : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IPDKHLDPLEM> LNKKEMDJAFJ(HAAIMGEOILO LHDBABCMEDP);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal interface JDNEJLBOMFE : DJAJPIOICAP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	CancellationToken DHNELDKDDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	ECDJHHJLGGB DELEMCNPOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	BMIHHOPKAOM JAHOKCHLGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	NAPEKDAGIPO LBLPDFBHHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	KOGEPCGCONJ FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	AMHFGBDMPHO AHDHPIHKONG
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	ICMFGEMMOON OCEKAGFPNOK
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	FKNLNKENNLO LDBBDAIDDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	DKIKCOHPEBM KDPHNHHCOPO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	PNFFLEJMNPJ LKCIIAIJILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	KFFAHHHLDMB BMAHALLAGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	IAIGPKNELON FJEGPMCMPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	GEGDDOJAOBI KBHCNLPMJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	GBCLMCDGIFC HHGNIIPPJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	CCNFKBCFLCE KPIJDHAGMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	DAKJCBGHOKB CLDDKIBECPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	CDHPHPDBIBF GABDHEDNAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	BHMBCGKIDBO HLFFJKMDAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	HDFDLFEDBFN AGPCEHHPFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	MNBFPGDJMJD LNKKEMDJAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	AMCKMBNLFMO HIKDGBGDKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	JOCOCPHJKKK NCMJIAOMLCA
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	CPFLKKAHAIJ DOIHEPAAAGL
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	GBKCOPOOGJM LMOKBPAMFJE
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	HKHOADPMHMG PPMGDFLKHCI
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	JKDBJHGFGFE MPMINNBJGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	OCKCNNNEKNG KDOKFDNCCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	DMKKLOAJACJ FDHGDOPDDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	ICOLHCPNMGH MGDDKMGKNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	MDFGFKODPDB KEBMKMOJJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	NLBKCIFAEMC MFBKGFKMNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	CLEKDBIBPBA EFOLGGKKEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void BLJCHAIMKKI(ILGCEILDCHC PAFMPLIFAHP);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal interface GEGDDOJAOBI : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NNCIDFODEFD();

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFHEBLIDDEK();

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NICHPHNHEPJ();
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class BDIIGOHIIFD
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2123EA0", Offset = "0x2122EA0", VA = "0x182123EA0")]
	public static void CCJKFJJKEDP(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2124180", Offset = "0x2123180", VA = "0x182124180")]
	internal static void JHADICKNDED(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x21240A0", Offset = "0x21230A0", VA = "0x1821240A0")]
	internal static void CJOFKIBECBK(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2123A50", Offset = "0x2122A50", VA = "0x182123A50")]
	internal static void ADOPJGNGJNF(ECDJHHJLGGB LADPAJPBFMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class EBFPDMMJLDG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x212E2B0", Offset = "0x212D2B0", VA = "0x18212E2B0")]
	public EBFPDMMJLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x10F18E0", Offset = "0x10F08E0", VA = "0x1810F18E0")]
	public EBFPDMMJLDG(string FANKIHBOOPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal interface NAJLJPDBPKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface KOGEPCGCONJ
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	CDHOCHHBNDB AAJLKBMPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	int JPJHIKNCGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	bool NHFFHEFFNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool IBIPLHFHEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	bool AABMHJJIBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool EOFAFLIBMON
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	JMNGDDABPMO BJPOJMFLLNM
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool LKIINHAPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool JHNHNKDJLEL
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	float BGIIJHGOHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event Action<float> PGLGANBNDPE;

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ECDJHHJLGGB PBLLHMEPNEO(ECDJHHJLGGB GBECFLMEHHF);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CBHEABBHGLI(ECDJHHJLGGB LADPAJPBFMP);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LMOJAINNLJE();

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task HBMCDNJNGLE(GLHOFFEBKJL<string>.OADOKMKENLA BGGNBIHJPGG, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EMKGDMAFCGC(float BLFDDDCGHGF);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LOFPEOJHJIA(string LJDDKLAKIKO);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IReadOnlyList<PBCKDOBPMHO> GNNLMADKKIF();

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDisposable OHFNBOPCKNO(object HBLIBBFCHOD, PBCKDOBPMHO KHGAJAOMHOH);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FAOEADGKIBK JOGDIEJAMME(IEnumerable<EHDNHMEBPAJ> CIFIMCOBJMN);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MAOFHCGLIMM(int MJHCKHIMNCG);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task GMMBJJPBENO();

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IACDIJIEHLK();

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool EBGDHBFHIAJ();

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task FGLDJOBEOBO(CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task HKBPLCIAAEF(CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<KPMOLNDNALM> FCCNAPCJGMJ(DateTime GFIEPMDEGAE, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> NCJGCNGIKJF(CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MNJDPMIHDOO(string KHBMIBDCBLG = "", float ICAMICGGEIA = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "23")]
	JDHBPCKDEIH DLBPBHOJNMM(OANGKBOCJHG CFHBGCMLNED, FCHEHKECEPG MHANIEBHIHC, HJBOCBIPMIO AAMCPGJKAGK, IEnumerable<PersistenceView> CDGHLNDNDOH, OOMJECFJHBK NIICCNOEDKK);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IGGAIKCIEDA(HJBOCBIPMIO AAMCPGJKAGK);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HPIJOHIBKFL(EHDNHMEBPAJ FOIHDPEDGJM, in JDHBPCKDEIH GIMGMHOIHOB);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task AAIIMFKHIII(HJBOCBIPMIO IIOBMIAKFHM, bool NEMDFCKOCMK, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task NHLAOBPGPME(CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ENPCMCIGONA(long IIKHCGCAMCH, long EMFFAEIKHBM, HFCNBIIEHLN DJAJOEFBOKM, BNENJKMIJMI BHAEMPHLEDO, IJCJMPMOCHK JFEDBHBIIIC, GHFIGJILBPN? OADHBHHMKBL, NPBBNMNNFIK? NNOKELLFGPG);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PEHHJALOMHC(long IIKHCGCAMCH, long EMFFAEIKHBM, NPBBNMNNFIK? NNOKELLFGPG);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KBIHOOOIADB(PersistenceView NJMJBEGNAOA);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool BKACHNJNKFO(PersistenceView KNJCBGNMLFC);

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool NBAIFOONGNA(EHDNHMEBPAJ FOIHDPEDGJM, DLDBICONFJM KFNGFNKFIAG, out GLEFCHMIPDK JAFMNDKCIFL);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task JAKDCHLFPLJ(CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void GKFAOBBHIDJ();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable PNOELJHEAFG();

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FICEODGLDPF(HJBOCBIPMIO IIOBMIAKFHM, DLDBICONFJM KFNGFNKFIAG);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> JONCCKKHINK(BMIHHOPKAOM JDANGEIJBKM, CancellationToken AOAEIGNDKPI, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void DBHOJHLOJFG(CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<AOMNJPFLLBL> LOCMFFHBNHF(PLKDEJCBHIG NJAMEFJLMOC);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<HFCNBIIEHLN> FDABGDECOCM(long IIKHCGCAMCH, bool KJAMJELBEDJ, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<BNENJKMIJMI> NIINJEHLJHA(long IIKHCGCAMCH, long EMFFAEIKHBM, long APOIFOLOFGK, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<AOCKGLNEMOK> IHONCNDDOLH(string DEDIJINCEFD, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<AOCKGLNEMOK> JJDCENDDEJC(string DEDIJINCEFD, long IIKHCGCAMCH, long EMFFAEIKHBM, string KHCIFCBONLA, JGCOJJFPODN.NEEKMBOANOL EICHFPBIJBD, JGCOJJFPODN.NEEKMBOANOL IPILOODINKM, int AENEABEPOLE);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool ACGOAAIABKA();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool DADKIBBIBDO();

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool FOLLGMJMDFM(IEnumerable<GLEFCHMIPDK> DGEAOHBCHJI);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void OMKBJILPBBO(List<GameObject> EGAHDDIJAAM);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float IEMHEOPLPAN();

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool PKMJMOCHADC(string PBKPNMBFKAM, out Scene JEBCPCLCOEA);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> AKPFAMMELFL(string PBKPNMBFKAM, LoadSceneMode OFIFCNNIODL, bool IKJLNNNBEMG, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void OCODKDNOGPD();

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool CAKBKBGAKND(ByteString AOBDCPLDMJI);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void KNDNGIGOPCM(bool PINBJOHBLIC);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "58")]
	Task DOLCNMHFAKD();

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task GKPMJAFKLAM();

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void NEBICCFELML();

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void MLONEBMEPDK();

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void JBDIJOKNEGC(IACNHFFDGGB EBNBOKDFFDJ);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "66")]
	Task ODIJECIEJKM(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "67")]
	Task LBKDJHOMMFF(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task MHCIGKHFADP(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void AFIBNAFAEHO();

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "70")]
	IDisposable OGHHJNFJODB();

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "71")]
	GCJMIIKJJEA PIKNCBGOIPJ();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task FGFMHOCHEFI(CancellationToken AOAEIGNDKPI);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public interface GCJMIIKJJEA
{
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BNHEICMBCFJ(CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KBHCGCNEKHJ(CancellationToken AOAEIGNDKPI);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct JDHBPCKDEIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public HashSet<int> DHDKBBNNAML;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum KPMOLNDNALM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct OANGKBOCJHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public bool IHFIIPNHMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public string NGPKHKMKPIP;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class MGPICPFLMAC
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class HAILHAIDCHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public GLHOFFEBKJL<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HAILHAIDCHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x3D65220", Offset = "0x3D64220", VA = "0x183D65220")]
		internal object DKELLDCCDOE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public const string BDJMOCHBPAP = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public const string BMMABABCECB = "END: ";

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x28B1D00", Offset = "0x28B0D00", VA = "0x1828B1D00")]
	public static GLHOFFEBKJL<string> OGMNNFKDBIP([Optional] string OHLDNCMHLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x28B1E30", Offset = "0x28B0E30", VA = "0x1828B1E30")]
	public static GLHOFFEBKJL<string> OGMNNFKDBIP(FACALIAHOGE IHHCPPEACEL, [Optional] string OHLDNCMHLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x28B1AF0", Offset = "0x28B0AF0", VA = "0x1828B1AF0")]
	private static void FNPHCFEIILI(string CDBHHMNALJL, GLHOFFEBKJL<string>.EAJKHLBIIEG IMDANOAGPHH, FACALIAHOGE IHHCPPEACEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x28B1F10", Offset = "0x28B0F10", VA = "0x1828B1F10")]
	private static void PIKBFHPCBCM(string CDBHHMNALJL, GLHOFFEBKJL<string>.EAJKHLBIIEG IMDANOAGPHH, FACALIAHOGE IHHCPPEACEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x28B1B50", Offset = "0x28B0B50", VA = "0x1828B1B50")]
	public static void HCICLIBCHAJ(GLHOFFEBKJL<string> IMDANOAGPHH, FACALIAHOGE IHHCPPEACEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x28B1C20", Offset = "0x28B0C20", VA = "0x1828B1C20")]
	public static string HPALKMOFDNJ(HAAIMGEOILO LHDBABCMEDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[UnityEngine.Scripting.Preserve]
internal class JEIABOJPLMI : CCNFKBCFLCE, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class PMKPAPFEALI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public MLICCGFKPBG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public JEIABOJPLMI <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PMKPAPFEALI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x3D71480", Offset = "0x3D70480", VA = "0x183D71480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class JEAKPLFPBGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public JEIABOJPLMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public MLICCGFKPBG roomData;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JEAKPLFPBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3D67B20", Offset = "0x3D66B20", VA = "0x183D67B20")]
		internal List<Task> BPHAIPPNGMB(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class MAEAHDPFNMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public IGOEHCBIEGM taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public JEIABOJPLMI <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MAEAHDPFNMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x3D6B340", Offset = "0x3D6A340", VA = "0x183D6B340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class LNJMJGPDINK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public JEIABOJPLMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LNJMJGPDINK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x3D6B020", Offset = "0x3D6A020", VA = "0x183D6B020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private readonly HashSet<IGOEHCBIEGM> AMFJKGKPMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private NAPEKDAGIPO HGBIDCLGHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private PBCKDOBPMHO LHHJCACOFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private CHBDOAMDFLG NPBNCJKILKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private IDisposable MCNJBFBBFNM;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool LHBJEEEAMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x213F080", Offset = "0x213E080", VA = "0x18213F080", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal Task HCFMNLPOHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x213F070", Offset = "0x213E070", VA = "0x18213F070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x213ED20", Offset = "0x213DD20", VA = "0x18213ED20", Slot = "6")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x213E2B0", Offset = "0x213D2B0", VA = "0x18213E2B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x213E0E0", Offset = "0x213D0E0", VA = "0x18213E0E0", Slot = "5")]
	public bool ANADLIPLHPM(IGOEHCBIEGM NBOFCLPBPGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x213E140", Offset = "0x213D140", VA = "0x18213E140")]
	private void DMOELEOOHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x213E970", Offset = "0x213D970", VA = "0x18213E970")]
	private void HEAAACMDMPB(MLICCGFKPBG EICHFPBIJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x213EBD0", Offset = "0x213DBD0", VA = "0x18213EBD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PMKPAPFEALI))]
	private Task ICGOMFMMGED(MLICCGFKPBG EICHFPBIJBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x213E000", Offset = "0x213D000", VA = "0x18213E000")]
	private Func<CancellationToken, List<Task>> AJJMJCBOGDC(MLICCGFKPBG EICHFPBIJBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x213E330", Offset = "0x213D330", VA = "0x18213E330")]
	private List<Task> EIEPHKJLIBN(MLICCGFKPBG EICHFPBIJBD, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x213F0B0", Offset = "0x213E0B0", VA = "0x18213F0B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MAEAHDPFNMJ))]
	private Task PHKCNFKGKJG(IGOEHCBIEGM KAAMIGCABEB, MLICCGFKPBG HCKNMLENIIG, CancellationToken DMHDKAFNNAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x213E850", Offset = "0x213D850", VA = "0x18213E850")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNJMJGPDINK))]
	private Task GPDLFNJKOGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x213EFC0", Offset = "0x213DFC0", VA = "0x18213EFC0")]
	private void NICHPHNHEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x213F250", Offset = "0x213E250", VA = "0x18213F250")]
	public JEIABOJPLMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal interface PNFFLEJMNPJ : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool OPICHLKCIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Task PMFNHIBOLFB
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBLCKLNIFHI(Task KMKKLLICGID, string ENNFBOPFJKK);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class CMPNKLFDKHJ : ILINNNPDNFI
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class AOOCHJEMABG : IAsyncStateMachine
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
		public CMPNKLFDKHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AOOCHJEMABG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C80D20", Offset = "0x3C7FD20", VA = "0x183C80D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private readonly JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private readonly KOGEPCGCONJ JJLHNLMGEOM;

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x83AA40", Offset = "0x839A40", VA = "0x18083AA40")]
	public CMPNKLFDKHJ(JDNEJLBOMFE PODNILAEFJM, KOGEPCGCONJ JJLHNLMGEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x21291F0", Offset = "0x21281F0", VA = "0x1821291F0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOOCHJEMABG))]
	public Task<bool> GHJOPFEINPA(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2129360", Offset = "0x2128360", VA = "0x182129360")]
	[CompilerGenerated]
	private object IHDNGKCBLFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class EGCJGOKBLAF : NBCFGLDFMNE, ICMFGEMMOON, POPKFIFBMON, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class OKJDBENOOEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public IPDKHLDPLEM result;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OKJDBENOOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C91BE0", Offset = "0x3C90BE0", VA = "0x183C91BE0")]
		internal object ODMGNJHLBHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2123020", Offset = "0x2122020", VA = "0x182123020")]
	[UnityEngine.Scripting.Preserve]
	public EGCJGOKBLAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x212E860", Offset = "0x212D860", VA = "0x18212E860", Slot = "8")]
	public IPDKHLDPLEM DLONNFGCHFJ(JMNGDDABPMO LILPCOEGCJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface ICOLHCPNMGH
{
	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool JALCBNBPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	string KPBKDOOALAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLAJHAPIEPM();

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KGHGBLABDIP MLPNNFJKPEO(long INEHMKECLJM);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IACDDDJJCOH<LMFNHKGJLBN, FAOEADGKIBK> INLPDGJBDLC(long INEHMKECLJM);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IACDDDJJCOH<LMFNHKGJLBN, HJBOCBIPMIO> NPIJJKGNFLK(long INEHMKECLJM);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IACDDDJJCOH<long, LNEEMMLDGFL> POIPIADMIMF();

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> IFDAGDAIMNP(byte[] KKOHNCFJGIK, byte[] IPILOODINKM, CancellationToken AOAEIGNDKPI);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class MFHLEGAOKKF : DAKJCBGHOKB, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class LLMGDEPKLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LLMGDEPKLIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A680", Offset = "0x3D69680", VA = "0x183D6A680")]
		internal object HJCPFBKPKGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class DDNODLEHCOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public DDNODLEHCOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D61CC0", Offset = "0x3D60CC0", VA = "0x183D61CC0")]
		internal object FGBDLPNKPOG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class IAOBKGJKCBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IAOBKGJKCBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D667F0", Offset = "0x3D657F0", VA = "0x183D667F0")]
		internal object KCNOODPILIJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class BEJCDKODNKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BEJCDKODNKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F900", Offset = "0x3D5E900", VA = "0x183D5F900")]
		internal object ABHLDJPHEAF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class NDBOGBBOELK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NDBOGBBOELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D6D1A0", Offset = "0x3D6C1A0", VA = "0x183D6D1A0")]
		internal object PNFKNGOEGEJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private readonly Dictionary<Guid, IBLPFLMJMIF> HCONINKJJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private readonly TimeSpan NBGEALEDIJE;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "10")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x28B0FC0", Offset = "0x28AFFC0", VA = "0x1828B0FC0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x28B11E0", Offset = "0x28B01E0", VA = "0x1828B11E0", Slot = "4")]
	public LHNNEBBBEAA KKDPLFKFCJN(Guid KPAGBCDJFAA)
	{
		return default(LHNNEBBBEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x28B0FD0", Offset = "0x28AFFD0", VA = "0x1828B0FD0", Slot = "5")]
	public bool HBPDDHHFGHN(Guid KPAGBCDJFAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x28B1680", Offset = "0x28B0680", VA = "0x1828B1680", Slot = "8")]
	public bool NICHPHNHEPJ(Guid KPAGBCDJFAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x28B0C60", Offset = "0x28AFC60", VA = "0x1828B0C60", Slot = "6")]
	public bool DGILHDNMFEP(Guid KPAGBCDJFAA, Task ELGNEFIBDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x28B1850", Offset = "0x28B0850", VA = "0x1828B1850", Slot = "7")]
	public bool OHCOHGMLNKF(Guid KPAGBCDJFAA, IPDKHLDPLEM HHNCNGAMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x28B1610", Offset = "0x28B0610", VA = "0x1828B1610", Slot = "9")]
	public Task<(IPDKHLDPLEM, Task)> LJBHJPLMAJN(Guid KPAGBCDJFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x28B1400", Offset = "0x28B0400", VA = "0x1828B1400")]
	private void KOJKIPKFMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x28B1A30", Offset = "0x28B0A30", VA = "0x1828B1A30")]
	public MFHLEGAOKKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class BBBAPINIJID : NBCFGLDFMNE, FKNLNKENNLO, POPKFIFBMON, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class JMAOBBJABMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public IPDKHLDPLEM result;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JMAOBBJABMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x28AC4E0", Offset = "0x28AB4E0", VA = "0x1828AC4E0")]
		internal object NGJHCELKHGM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2123020", Offset = "0x2122020", VA = "0x182123020")]
	[UnityEngine.Scripting.Preserve]
	public BBBAPINIJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2122F00", Offset = "0x2121F00", VA = "0x182122F00", Slot = "8")]
	public IPDKHLDPLEM FLGMKMJLFGA(JMNGDDABPMO GDEGDBOPGEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal interface GBCLMCDGIFC : NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000098")]
	TaskStatus NOBOGPPIBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KHADBGEGLCC(IACNHFFDGGB NCMDIOLBALM, ILGCEILDCHC DBEIEOJPBEI, CancellationToken JANCDKHOLLO);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class EEPGOPMJCNB
{
	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x212E810", Offset = "0x212D810", VA = "0x18212E810")]
	public static bool IPPCHOLAHCF(this GBCLMCDGIFC HAIFEBPKIMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal static class LOPJFNLGFNP
{
	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x28AD9F0", Offset = "0x28AC9F0", VA = "0x1828AD9F0")]
	public static string BFEIKACDHFK(this IACNHFFDGGB LKKJHIDALEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x28ADC40", Offset = "0x28ACC40", VA = "0x1828ADC40")]
	public static bool OCCLDOFPCFE(this IACNHFFDGGB LKKJHIDALEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[UnityEngine.Scripting.Preserve]
internal class IFOLHHCCEED : GEGDDOJAOBI, NAJLJPDBPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class IIAOJHEAKMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public IFOLHHCCEED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IIAOJHEAKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x3D67040", Offset = "0x3D66040", VA = "0x183D67040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class FMEKHDGJKMO : IAsyncStateMachine
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
		public IFOLHHCCEED <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FMEKHDGJKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x3D646D0", Offset = "0x3D636D0", VA = "0x183D646D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class JHDDJPCOPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JHDDJPCOPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x3D68120", Offset = "0x3D67120", VA = "0x183D68120")]
		internal object FJEFPPFMKDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class MBHEHCNJDBB : IAsyncStateMachine
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
		public IFOLHHCCEED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private JHDDJPCOPBD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private ILINNNPDNFI <provider>5__3;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MBHEHCNJDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x3D6B680", Offset = "0x3D6A680", VA = "0x183D6B680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class HKMMIGJFDJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HKMMIGJFDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D66780", Offset = "0x3D65780", VA = "0x183D66780")]
		internal object EEGECLHIOBF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private static readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private KOGEPCGCONJ JJLHNLMGEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private ILINNNPDNFI[] NEHFNICGLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private CancellationTokenSource KCHPCPEPOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private int EJCNGPKHHKE;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x213A4B0", Offset = "0x21394B0", VA = "0x18213A4B0", Slot = "7")]
	public void JFGMJMMFADK(JDNEJLBOMFE PODNILAEFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x213A220", Offset = "0x2139220", VA = "0x18213A220", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x213A870", Offset = "0x2139870", VA = "0x18213A870", Slot = "6")]
	public void NICHPHNHEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x213A670", Offset = "0x2139670", VA = "0x18213A670", Slot = "5")]
	public void LFHEBLIDDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x213A980", Offset = "0x2139980", VA = "0x18213A980", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IIAOJHEAKMH))]
	public Task NNCIDFODEFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x213AAA0", Offset = "0x2139AA0", VA = "0x18213AAA0")]
	private void OGBKEJLPJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x213ADA0", Offset = "0x2139DA0", VA = "0x18213ADA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FMEKHDGJKMO))]
	private Task ONDEOMFCMHO(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x213A230", Offset = "0x2139230", VA = "0x18213A230")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MBHEHCNJDBB))]
	private Task<bool> ENCFPPPPPDP(int EJNMEMKEIOD, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x213A3C0", Offset = "0x21393C0", VA = "0x18213A3C0")]
	private void JEOKNGDCBFC(int EJNMEMKEIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x213A120", Offset = "0x2139120", VA = "0x18213A120")]
	private void BOECILJLFEK(int EJNMEMKEIOD, bool FKDDMFACIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x213A530", Offset = "0x2139530", VA = "0x18213A530")]
	private void JGAONOPPNEF(int EJNMEMKEIOD, Exception AEPEBFMCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x213A750", Offset = "0x2139750", VA = "0x18213A750")]
	private void MECECFGBKON(CancellationToken AOAEIGNDKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x213AF80", Offset = "0x2139F80", VA = "0x18213AF80")]
	public IFOLHHCCEED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class GLBBMOECHCL
{
	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x21340B0", Offset = "0x21330B0", VA = "0x1821340B0")]
	public static void FALGEMAFBGD(this BMIHHOPKAOM JDANGEIJBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x21341D0", Offset = "0x21331D0", VA = "0x1821341D0")]
	public static void LKFIJPHOLHO(this BMIHHOPKAOM JDANGEIJBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x21340C0", Offset = "0x21330C0", VA = "0x1821340C0")]
	private static void LBCNLMNACAK(this BMIHHOPKAOM JDANGEIJBKM, bool GHFGEGHAEEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct HLAGKIGAIMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public readonly OEFBBNFLPAL KLHIPBANHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public readonly string DBDHOLEBFFP;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2138B70", Offset = "0x2137B70", VA = "0x182138B70")]
	public HLAGKIGAIMG(string ELKDGFCIGJN, OEFBBNFLPAL MELFENBBIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2138A50", Offset = "0x2137A50", VA = "0x182138A50")]
	public string CGKBEKACCDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2138AD0", Offset = "0x2137AD0", VA = "0x182138AD0")]
	public string CJKPAOGFLJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public delegate string NBKHNPJCGJC<in T>(T AEPEBFMCJDO) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public delegate int GEKGPKMDIAA<in T>(T AEPEBFMCJDO) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class INACGFNOHKG : CLEKDBIBPBA
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private delegate string IOLGGAJAJCC(Exception AEPEBFMCJDO);

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private delegate int KNBEINIIPIG(Exception AEPEBFMCJDO);

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class DHGMJEFCEJH<T> : EACPPLOOLKC<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class NMFILMDPIDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
			public NMFILMDPIDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
			internal string LJOIFHGPHCO(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class ILOHEIBKFLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D2230", Offset = "0x6D1630")]
			public NBKHNPJCGJC<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
			public ILOHEIBKFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x245CB90", Offset = "0x245BB90", VA = "0x18245CB90")]
			internal string CLNJKJEHHLN(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class FPCHBMIEECJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public int subCode;

			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
			public FPCHBMIEECJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
			internal int OFIMAJLFFHD(Exception _)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class BGNPCAJIECK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D2290", Offset = "0x6D1690")]
			public GEKGPKMDIAA<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
			public BGNPCAJIECK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x245CB90", Offset = "0x245BB90", VA = "0x18245CB90")]
			internal int NLGEDAIPFKN(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private readonly INACGFNOHKG NJABNINNONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private readonly Type CLGDBJKDMAH;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x37C4D70", Offset = "0x37C3D70", VA = "0x1837C4D70")]
		internal DHGMJEFCEJH(INACGFNOHKG NJABNINNONH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x37C4A10", Offset = "0x37C3A10", VA = "0x1837C4A10", Slot = "4")]
		public void CMGKAPNMFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x37C48D0", Offset = "0x37C38D0", VA = "0x1837C48D0", Slot = "5")]
		public EACPPLOOLKC<T> AEDHKDPKGCE(string MIPGDOLAABL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x37C4B50", Offset = "0x37C3B50", VA = "0x1837C4B50", Slot = "6")]
		public EACPPLOOLKC<T> GDPELELHGGO(NBKHNPJCGJC<T> EMDJMFAFBED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x37C49D0", Offset = "0x37C39D0", VA = "0x1837C49D0", Slot = "7")]
		public EACPPLOOLKC<T> CECDKMCGAAN(int MELFENBBIPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x37C4A40", Offset = "0x37C3A40", VA = "0x1837C4A40", Slot = "8")]
		public EACPPLOOLKC<T> FKGGKFOOLEO(int MELFENBBIPJ, int LMPEKMKHOHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x37C4C50", Offset = "0x37C3C50", VA = "0x1837C4C50", Slot = "9")]
		public EACPPLOOLKC<T> OEPAFPDFHJI(int MELFENBBIPJ, GEKGPKMDIAA<T> HMAMFHAAGOJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class GOMIOIPGMFH<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private bool EFPMDIEHHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private readonly List<Type> OJOKNNKNJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private readonly Dictionary<Type, TVal> KNLPMGADPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private readonly Dictionary<Type, int> NPIKLCAFJMA;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public IReadOnlyList<Type> FPGEKOOHJGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x25D2C50", Offset = "0x25D1C50", VA = "0x1825D2C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x25D3080", Offset = "0x25D2080", VA = "0x1825D3080")]
		public GOMIOIPGMFH(Dictionary<Type, int> NPIKLCAFJMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x25D2F40", Offset = "0x25D1F40", VA = "0x1825D2F40")]
		public void KKDPLFKFCJN(Type CDBHHMNALJL, TVal PCKJKBNEEPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x25D2BF0", Offset = "0x25D1BF0", VA = "0x1825D2BF0")]
		public bool CNEJNLOPMGC(Type CLGDBJKDMAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x25D2F10", Offset = "0x25D1F10", VA = "0x1825D2F10")]
		public bool KIBMAJNELKD(TVal CKMKMNKGMMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x25D2C20", Offset = "0x25D1C20", VA = "0x1825D2C20")]
		public TVal EAOPAIAIDNN(Type FLAJIGGIBOB)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x25D2E70", Offset = "0x25D1E70", VA = "0x1825D2E70")]
		[CompilerGenerated]
		private int EICJFNLPFAA(Type NBIPOEHKPAL, Type FEDAPCBNNEP)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private sealed class EKIABPCCLNE : IEnumerable<OEFBBNFLPAL>, IEnumerable, IEnumerator<OEFBBNFLPAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private OEFBBNFLPAL <>2__current;

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
		public INACGFNOHKG <>4__this;

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
		private IEnumerator<OEFBBNFLPAL> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private OEFBBNFLPAL <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		private OEFBBNFLPAL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x2C42E10", Offset = "0x2C41E10", VA = "0x182C42E10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OEFBBNFLPAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x3D632A0", Offset = "0x3D622A0", VA = "0x183D632A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xB730E0", Offset = "0xB720E0", VA = "0x180B730E0")]
		[DebuggerHidden]
		public EKIABPCCLNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x3D632F0", Offset = "0x3D622F0", VA = "0x183D632F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x3D62D40", Offset = "0x3D61D40", VA = "0x183D62D40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x3D62CF0", Offset = "0x3D61CF0", VA = "0x183D62CF0")]
		private void JIJNIFIPMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x3D63160", Offset = "0x3D62160", VA = "0x183D63160")]
		private void PJBNDPOBDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x3D63260", Offset = "0x3D62260", VA = "0x183D63260", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x3D631B0", Offset = "0x3D621B0", VA = "0x183D631B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OEFBBNFLPAL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x3D631B0", Offset = "0x3D621B0", VA = "0x183D631B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	internal const int EMCHOKJOHEM = 8700;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private static readonly OEFBBNFLPAL NFFGJAFIJHL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	internal const string DEMGEPPOCKN = "Unknown error loading room";

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	internal const int IOHBKKKMIHL = 8708;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private static readonly Dictionary<Type, int> PKKMNIIBOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly HashSet<Type> MCCBCLKFMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private readonly GOMIOIPGMFH<int> LFCOANGDMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly GOMIOIPGMFH<KNBEINIIPIG> NJCNKACGOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private readonly GOMIOIPGMFH<IOLGGAJAJCC> HLPOAKMFNJL;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x213C680", Offset = "0x213B680", VA = "0x18213C680")]
	[OHDKPIIHCBL(BGEACDHIFOF.GameOnly)]
	private static void ELLMEMEMKGP(ECDJHHJLGGB GGKDJNHCHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x213D3D0", Offset = "0x213C3D0", VA = "0x18213D3D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public INACGFNOHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x13ED190", Offset = "0x13EC190", VA = "0x1813ED190", Slot = "4")]
	public EACPPLOOLKC<T> BEFDACDPEBO<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x213CDF0", Offset = "0x213BDF0", VA = "0x18213CDF0", Slot = "5")]
	public HLAGKIGAIMG JEOOCFBFOJJ(Exception AEPEBFMCJDO)
	{
		return default(HLAGKIGAIMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x213C6F0", Offset = "0x213B6F0", VA = "0x18213C6F0", Slot = "6")]
	public OEFBBNFLPAL FPKFLDNMOGE(Exception? AEPEBFMCJDO)
	{
		return default(OEFBBNFLPAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x213CEA0", Offset = "0x213BEA0", VA = "0x18213CEA0", Slot = "7")]
	[IteratorStateMachine(typeof(EKIABPCCLNE))]
	public IEnumerable<OEFBBNFLPAL> LLJAECLLKOO(Exception AEPEBFMCJDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x213C910", Offset = "0x213B910", VA = "0x18213C910", Slot = "8")]
	public string IFGBKIPDMOO(Exception? AEPEBFMCJDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x213C300", Offset = "0x213B300", VA = "0x18213C300")]
	private string BJPOLNKNLBH(AggregateException OHLHOLNLCDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x213CA50", Offset = "0x213BA50", VA = "0x18213CA50")]
	private void IIFFGFAOJEN(Type CLGDBJKDMAH, int MELFENBBIPJ, KNBEINIIPIG? FFFICEAFJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x213D0D0", Offset = "0x213C0D0", VA = "0x18213D0D0")]
	private void NMDJOIAMNHO(Type CLGDBJKDMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x213C040", Offset = "0x213B040", VA = "0x18213C040")]
	private void BEGBFAPBDFC(Type CLGDBJKDMAH, IOLGGAJAJCC OOBHFNFKCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x213CF30", Offset = "0x213BF30", VA = "0x18213CF30")]
	private static int NBACOFBFBIO(Type CLGDBJKDMAH, Dictionary<Type, int> NPIKLCAFJMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x28E4470", Offset = "0x28E3470", VA = "0x1828E4470")]
	private static bool KJACGALMFOO<TVal>(GOMIOIPGMFH<TVal> JIBLOMPBADG, Type CLGDBJKDMAH, out TVal CKMKMNKGMMC) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x213BF50", Offset = "0x213AF50", VA = "0x18213BF50")]
	[CompilerGenerated]
	internal static int AMHHBHMHBBC(Type JNECNKCMJFE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct OEFBBNFLPAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public readonly int DLEOMCALLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public readonly int? CKLLEOOHJIM;

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x20DBE10", Offset = "0x20DAE10", VA = "0x1820DBE10")]
	public OEFBBNFLPAL(int MJHCKHIMNCG, [Optional] int? LMPEKMKHOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x28B7C60", Offset = "0x28B6C60", VA = "0x1828B7C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface CLEKDBIBPBA
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EACPPLOOLKC<T> BEFDACDPEBO<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HLAGKIGAIMG JEOOCFBFOJJ(Exception AEPEBFMCJDO);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OEFBBNFLPAL FPKFLDNMOGE(Exception AEPEBFMCJDO);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<OEFBBNFLPAL> LLJAECLLKOO(Exception AEPEBFMCJDO);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string IFGBKIPDMOO(Exception AEPEBFMCJDO);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface EACPPLOOLKC<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMGKAPNMFCI();

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EACPPLOOLKC<T> AEDHKDPKGCE(string MIPGDOLAABL);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EACPPLOOLKC<T> GDPELELHGGO(NBKHNPJCGJC<T> EMDJMFAFBED);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EACPPLOOLKC<T> CECDKMCGAAN(int MELFENBBIPJ);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EACPPLOOLKC<T> FKGGKFOOLEO(int MELFENBBIPJ, int LMPEKMKHOHI);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EACPPLOOLKC<T> OEPAFPDFHJI(int MELFENBBIPJ, GEKGPKMDIAA<T> HMAMFHAAGOJ);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class OBEACBPJPGP
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x28B7860", Offset = "0x28B6860", VA = "0x1828B7860")]
	[OHDKPIIHCBL(BGEACDHIFOF.GameOnly)]
	private static void FHIGGLJNFIH(ECDJHHJLGGB GGKDJNHCHBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public interface NGDFPBDGPNO : IEquatable<NGDFPBDGPNO>
{
	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	KACPKECEGPN EIDFJEPEFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	DateTime EODABADFEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNBLGMIMBEE();

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IKDFDCNEPON(long IIKHCGCAMCH, long HCLBMOKINEP, out IJCJMPMOCHK JFEDBHBIIIC);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class ONFONOKJHPJ : MDFGFKODPDB
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class GHJBECCEHFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public GHGMNDCOENL autosaveType;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GHJBECCEHFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class CNHPAKHIJKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public GHJBECCEHFF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CNHPAKHIJKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x541FBA0", Offset = "0x541EBA0", VA = "0x18541FBA0")]
		internal object PIBBEPFJPED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private readonly EHDMEJHIMLF BCFJKABEKBJ;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private const int KEOEPBDLNID = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<NGDFPBDGPNO> POONHJEPFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x28B8660", Offset = "0x28B7660", VA = "0x1828B8660", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x28B8F40", Offset = "0x28B7F40", VA = "0x1828B8F40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x934550", Offset = "0x933550", VA = "0x180934550")]
	[UnityEngine.Scripting.Preserve]
	public ONFONOKJHPJ([KMDNJCFAMOJ(null)] EHDMEJHIMLF BCFJKABEKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x28B8AF0", Offset = "0x28B7AF0", VA = "0x1828B8AF0", Slot = "6")]
	public bool GINJIKAJFOG(long IIKHCGCAMCH, long HCLBMOKINEP, IJCJMPMOCHK JFEDBHBIIIC, GHGMNDCOENL NHJGHMDIBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x28B8FE0", Offset = "0x28B7FE0", VA = "0x1828B8FE0")]
	private void IGCBMKECEHJ(NGDFPBDGPNO LADKCLEPKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x28B91A0", Offset = "0x28B81A0", VA = "0x1828B91A0", Slot = "7")]
	public bool OPNHEBLFLPG(long IIKHCGCAMCH, long HCLBMOKINEP, out NGDFPBDGPNO AAHGAPCMDBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x28B8E90", Offset = "0x28B7E90", VA = "0x1828B8E90", Slot = "8")]
	public bool HHDFJCCHPLG(long IIKHCGCAMCH, long HCLBMOKINEP, GHGMNDCOENL NHJGHMDIBIC, out NGDFPBDGPNO AAHGAPCMDBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x28B8700", Offset = "0x28B7700", VA = "0x1828B8700")]
	private void DCPNBELCIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x28B9080", Offset = "0x28B8080", VA = "0x1828B9080", Slot = "9")]
	public void LEFLOIEBHMD(long IIKHCGCAMCH, long HCLBMOKINEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public enum KACPKECEGPN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000374")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal sealed class PGAJFGLBEHO : FFKNEMBLLJI
{
	[Cpp2IlInjected.Token(Token = "0x4000375")]
	private static readonly byte[] CDBHHMNALJL;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	private const string EFPIOHJNLFJ = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private const string IGHMDFGFGII = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private const string LLOGJAHADIJ = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private readonly byte[] OHHCKHPOPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private readonly byte[] OALJAIAECOL;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public override KACPKECEGPN EIDFJEPEFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x147BFB0", Offset = "0x147AFB0", VA = "0x18147BFB0", Slot = "8")]
		get
		{
			return default(KACPKECEGPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x28BBD90", Offset = "0x28BAD90", VA = "0x1828BBD90")]
	public PGAJFGLBEHO([Optional] string LJCJGBDLIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x28BBA80", Offset = "0x28BAA80", VA = "0x1828BBA80", Slot = "9")]
	internal override void PLENIPKMMGB(Stream KFIIKHBPGIL, long IIKHCGCAMCH, long HCLBMOKINEP, IJCJMPMOCHK JFEDBHBIIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x28BB150", Offset = "0x28BA150", VA = "0x1828BB150", Slot = "10")]
	internal override bool JKICDLCFANA(Stream KPOLOGAPIPG, long IIKHCGCAMCH, long HCLBMOKINEP, DBCIEAILGAF BJHPFMBPAHG, out IJCJMPMOCHK JFEDBHBIIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x28BB850", Offset = "0x28BA850", VA = "0x1828BB850")]
	private void NFOCOMEOKAJ(byte[] OFGEHNEOBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x28BB020", Offset = "0x28BA020", VA = "0x1828BB020", Slot = "11")]
	protected override FileInfo BAIKDLOAFKP(long IIKHCGCAMCH, long HCLBMOKINEP, GHGMNDCOENL NHJGHMDIBIC, AJKDNIDLDGP DJNHOFEAPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x28BB960", Offset = "0x28BA960", VA = "0x1828BB960", Slot = "12")]
	protected override DirectoryInfo NLPDBLAFMNH(GHGMNDCOENL NHJGHMDIBIC, AJKDNIDLDGP DJNHOFEAPOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class PKAFMGCMFCJ : FFKNEMBLLJI
{
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private const string HMCGGBENCFI = "V2";

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private const string EFPIOHJNLFJ = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private const string IGHMDFGFGII = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public override KACPKECEGPN EIDFJEPEFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x9AAA10", Offset = "0x9A9A10", VA = "0x1809AAA10", Slot = "8")]
		get
		{
			return default(KACPKECEGPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x28BEA10", Offset = "0x28BDA10", VA = "0x1828BEA10")]
	public PKAFMGCMFCJ([Optional] string LJCJGBDLIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x28BE640", Offset = "0x28BD640", VA = "0x1828BE640")]
	private void LDFENLJLIOD(GHGMNDCOENL NHJGHMDIBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x28BE7E0", Offset = "0x28BD7E0", VA = "0x1828BE7E0", Slot = "9")]
	internal override void PLENIPKMMGB(Stream KFIIKHBPGIL, long IIKHCGCAMCH, long HCLBMOKINEP, IJCJMPMOCHK JFEDBHBIIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x28BE1B0", Offset = "0x28BD1B0", VA = "0x1828BE1B0", Slot = "10")]
	internal override bool JKICDLCFANA(Stream KPOLOGAPIPG, long IIKHCGCAMCH, long HCLBMOKINEP, DBCIEAILGAF BJHPFMBPAHG, out IJCJMPMOCHK JFEDBHBIIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x28BE0C0", Offset = "0x28BD0C0", VA = "0x1828BE0C0", Slot = "11")]
	protected override FileInfo BAIKDLOAFKP(long IIKHCGCAMCH, long HCLBMOKINEP, GHGMNDCOENL NHJGHMDIBIC, AJKDNIDLDGP DJNHOFEAPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x28BE6D0", Offset = "0x28BD6D0", VA = "0x1828BE6D0", Slot = "12")]
	protected override DirectoryInfo NLPDBLAFMNH(GHGMNDCOENL NHJGHMDIBIC, AJKDNIDLDGP DJNHOFEAPOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal abstract class FFKNEMBLLJI : EHDMEJHIMLF
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	protected enum AJKDNIDLDGP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class MLHIBFFDDKD : IEnumerable<NGDFPBDGPNO>, IEnumerable, IEnumerator<NGDFPBDGPNO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private NGDFPBDGPNO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private GHGMNDCOENL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public GHGMNDCOENL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public FFKNEMBLLJI <>4__this;

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
		private NGDFPBDGPNO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xB730E0", Offset = "0xB720E0", VA = "0x180B730E0")]
		[DebuggerHidden]
		public MLHIBFFDDKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FB50", Offset = "0x3C8EB50", VA = "0x183C8FB50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FDB0", Offset = "0x3C8EDB0", VA = "0x183C8FDB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FD00", Offset = "0x3C8ED00", VA = "0x183C8FD00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NGDFPBDGPNO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FD00", Offset = "0x3C8ED00", VA = "0x183C8FD00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class EIAHJEEJPJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public GHGMNDCOENL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EIAHJEEJPJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x3C83340", Offset = "0x3C82340", VA = "0x183C83340")]
		internal object GHANBHAMEIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class FGGBJFLKPPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public FFKNEMBLLJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FGGBJFLKPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x3C84570", Offset = "0x3C83570", VA = "0x183C84570")]
		internal void LKGIDMMNNAH(CFBDKNOALMO.GEFDCDDBMII ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	protected readonly string IHLBPABPKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private readonly object GGJJGFIGIDO;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public abstract KACPKECEGPN EIDFJEPEFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x212F1E0", Offset = "0x212E1E0", VA = "0x18212F1E0")]
	protected FFKNEMBLLJI([CanBeNull] string LJCJGBDLIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x212E980", Offset = "0x212D980", VA = "0x18212E980", Slot = "5")]
	public bool DCNDEFKGDAA(long IIKHCGCAMCH, long HCLBMOKINEP, GHGMNDCOENL NHJGHMDIBIC, out NGDFPBDGPNO LADKCLEPKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x212EB30", Offset = "0x212DB30", VA = "0x18212EB30", Slot = "6")]
	[IteratorStateMachine(typeof(MLHIBFFDDKD))]
	public IEnumerable<NGDFPBDGPNO> GNNLEKLPLLO(GHGMNDCOENL NHJGHMDIBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void PLENIPKMMGB(Stream KFIIKHBPGIL, long IIKHCGCAMCH, long HCLBMOKINEP, IJCJMPMOCHK JFEDBHBIIIC);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool JKICDLCFANA(Stream KPOLOGAPIPG, long IIKHCGCAMCH, long HCLBMOKINEP, DBCIEAILGAF BJHPFMBPAHG, out IJCJMPMOCHK JFEDBHBIIIC);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x212EBB0", Offset = "0x212DBB0", VA = "0x18212EBB0", Slot = "7")]
	public NGDFPBDGPNO MMHHPNKHBLL(long IIKHCGCAMCH, long HCLBMOKINEP, IJCJMPMOCHK JFEDBHBIIIC, GHGMNDCOENL NHJGHMDIBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo BAIKDLOAFKP(long IIKHCGCAMCH, long HCLBMOKINEP, GHGMNDCOENL NHJGHMDIBIC, AJKDNIDLDGP DJNHOFEAPOK);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo NLPDBLAFMNH(GHGMNDCOENL NHJGHMDIBIC, AJKDNIDLDGP DJNHOFEAPOK);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x212EEB0", Offset = "0x212DEB0", VA = "0x18212EEB0")]
	protected void NKCMKCOJOCC(CFBDKNOALMO.GEFDCDDBMII AHPFIPEOAGB, string DDBKCEMOFJA, FileInfo NLCPLNFJNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x212EF20", Offset = "0x212DF20", VA = "0x18212EF20")]
	internal bool OKDCNOOEPBP(FileInfo NNAPPEBIKIG, long IIKHCGCAMCH, long HCLBMOKINEP, out IJCJMPMOCHK JFEDBHBIIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	private void AILKPCKHINO(Exception AMMLDGPCMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal interface EHDMEJHIMLF
{
	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	KACPKECEGPN EIDFJEPEFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DCNDEFKGDAA(long IIKHCGCAMCH, long HCLBMOKINEP, GHGMNDCOENL NHJGHMDIBIC, out NGDFPBDGPNO LADKCLEPKDB);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<NGDFPBDGPNO> GNNLEKLPLLO(GHGMNDCOENL NHJGHMDIBIC);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NGDFPBDGPNO MMHHPNKHBLL(long IIKHCGCAMCH, long HCLBMOKINEP, IJCJMPMOCHK JFEDBHBIIIC, GHGMNDCOENL NHJGHMDIBIC);
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class AGOEMHMLMPH : EHDMEJHIMLF
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class LELGELLEMKE : IEnumerable<NGDFPBDGPNO>, IEnumerable, IEnumerator<NGDFPBDGPNO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private NGDFPBDGPNO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private GHGMNDCOENL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public GHGMNDCOENL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public AGOEMHMLMPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private KACPKECEGPN[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private KACPKECEGPN <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private EHDMEJHIMLF <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private IEnumerable<NGDFPBDGPNO> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private IEnumerator<NGDFPBDGPNO> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private NGDFPBDGPNO <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		private NGDFPBDGPNO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xB730E0", Offset = "0xB720E0", VA = "0x180B730E0")]
		[DebuggerHidden]
		public LELGELLEMKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x28AD150", Offset = "0x28AC150", VA = "0x1828AD150", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x28ACD80", Offset = "0x28ABD80", VA = "0x1828ACD80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x28ACD30", Offset = "0x28ABD30", VA = "0x1828ACD30")]
		private void JIJNIFIPMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x28AD110", Offset = "0x28AC110", VA = "0x1828AD110", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x28AD060", Offset = "0x28AC060", VA = "0x1828AD060", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NGDFPBDGPNO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x28AD060", Offset = "0x28AC060", VA = "0x1828AD060", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private readonly KACPKECEGPN[] PFIOOHIDCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private readonly Dictionary<KACPKECEGPN, EHDMEJHIMLF> FFMLHGJAMLF;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public KACPKECEGPN EIDFJEPEFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2121850", Offset = "0x2120850", VA = "0x182121850", Slot = "4")]
		get
		{
			return default(KACPKECEGPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2121DF0", Offset = "0x2120DF0", VA = "0x182121DF0")]
	[UnityEngine.Scripting.Preserve]
	public AGOEMHMLMPH(params EHDMEJHIMLF[] KCBOLOKAGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2121890", Offset = "0x2120890", VA = "0x182121890", Slot = "5")]
	public bool DCNDEFKGDAA(long IIKHCGCAMCH, long HCLBMOKINEP, GHGMNDCOENL NHJGHMDIBIC, out NGDFPBDGPNO LADKCLEPKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2121A70", Offset = "0x2120A70", VA = "0x182121A70")]
	private void LINMHNMJBLP(int PAIOOGEGADD, long IIKHCGCAMCH, long HCLBMOKINEP, GHGMNDCOENL NHJGHMDIBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x21219F0", Offset = "0x21209F0", VA = "0x1821219F0", Slot = "6")]
	[IteratorStateMachine(typeof(LELGELLEMKE))]
	public IEnumerable<NGDFPBDGPNO> GNNLEKLPLLO(GHGMNDCOENL NHJGHMDIBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2121CA0", Offset = "0x2120CA0", VA = "0x182121CA0", Slot = "7")]
	public NGDFPBDGPNO MMHHPNKHBLL(long IIKHCGCAMCH, long HCLBMOKINEP, IJCJMPMOCHK JFEDBHBIIIC, GHGMNDCOENL NHJGHMDIBIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal static class GBJIMNJLKEI
{
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	internal const int BKNGGBBGEPG = 32;

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x2132280", Offset = "0x2131280", VA = "0x182132280")]
	internal static byte[] NDEHNINMIPD(byte[] OFGEHNEOBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x2132320", Offset = "0x2131320", VA = "0x182132320")]
	public static void PIEJOPENBJB(Stream IJMHEHCCCCM, byte[] DJMCKOHCAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x21320A0", Offset = "0x21310A0", VA = "0x1821320A0")]
	public static bool BNHGMHJEHLO(Stream IJMHEHCCCCM, long BNKNGFEMHJJ, DBCIEAILGAF LJMFNPNIENB, out byte[] OFFBGGNAGBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public delegate void DBCIEAILGAF(CFBDKNOALMO.GEFDCDDBMII ENGCNJPBLCN, string FANKIHBOOPE);
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class MONOCKICIGC : NGDFPBDGPNO, IEquatable<NGDFPBDGPNO>, IEquatable<MONOCKICIGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	private readonly FFKNEMBLLJI CKFNBLJKCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly FileInfo AHJMPMAINCD;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public KACPKECEGPN EIDFJEPEFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x28B3BD0", Offset = "0x28B2BD0", VA = "0x1828B3BD0", Slot = "4")]
		get
		{
			return default(KACPKECEGPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public DateTime EODABADFEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x28B4020", Offset = "0x28B3020", VA = "0x1828B4020", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x28B4170", Offset = "0x28B3170", VA = "0x1828B4170")]
	public MONOCKICIGC(FFKNEMBLLJI CGDNKPICCAF, FileInfo NNAPPEBIKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x28B40C0", Offset = "0x28B30C0", VA = "0x1828B40C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x28B3F30", Offset = "0x28B2F30", VA = "0x1828B3F30", Slot = "6")]
	public void HNBLGMIMBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x28B3FE0", Offset = "0x28B2FE0", VA = "0x1828B3FE0", Slot = "7")]
	public bool IKDFDCNEPON(long IIKHCGCAMCH, long HCLBMOKINEP, out IJCJMPMOCHK JFEDBHBIIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x28B3CB0", Offset = "0x28B2CB0", VA = "0x1828B3CB0", Slot = "8")]
	public bool Equals(NGDFPBDGPNO JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x28B3C00", Offset = "0x28B2C00", VA = "0x1828B3C00", Slot = "9")]
	public bool Equals(MONOCKICIGC JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x28B3D90", Offset = "0x28B2D90", VA = "0x1828B3D90", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x28B3E90", Offset = "0x28B2E90", VA = "0x1828B3E90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0xA99410", Offset = "0xA98410", VA = "0x180A99410")]
	public static bool JFBEPFHBCDN(MONOCKICIGC KOMAFEKIKMM, MONOCKICIGC MKGHCBPGAGB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0xA99420", Offset = "0xA98420", VA = "0x180A99420")]
	public static bool NLNNLODOBLO(MONOCKICIGC KOMAFEKIKMM, MONOCKICIGC MKGHCBPGAGB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct OLOLIGLAPKP
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class PPBCHDLAAII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private JDNEJLBOMFE <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PPBCHDLAAII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x5427070", Offset = "0x5426070", VA = "0x185427070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x28B8110", Offset = "0x28B7110", VA = "0x1828B8110")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PPBCHDLAAII))]
	public static Task ICIKLLEKAKC(DEGFCGHLJFD OPAIPEGNAFH, MLICCGFKPBG HCKNMLENIIG, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct OMKHEGBPBLL
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class JKLMDBLMFOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public NFDNOKDBJMA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public AGJJBIKALMI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private JDNEJLBOMFE <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private KOGEPCGCONJ <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private DLDBICONFJM <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private List<(PersistenceView, EHDNHMEBPAJ)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EHDNHMEBPAJ <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JKLMDBLMFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x5422730", Offset = "0x5421730", VA = "0x185422730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x28B82B0", Offset = "0x28B72B0", VA = "0x1828B82B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JKLMDBLMFOK))]
	public static Task ICIKLLEKAKC(NFDNOKDBJMA IBOEOPFBKMK, MLICCGFKPBG HCKNMLENIIG, AGJJBIKALMI NAHMLNGINOI, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal struct BEIJGNKMAEG
{
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160")]
	public static BEIJGNKMAEG GGPPECCFBMF()
	{
		return default(BEIJGNKMAEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void DMOMOOJGHOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void JJMNDGNPJMH(MLICCGFKPBG HCKNMLENIIG, object FOIHDPEDGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void GBFHBHBKDFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal struct AFIHFPBLGGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private MLICCGFKPBG HCKNMLENIIG;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private KOGEPCGCONJ FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x2121580", Offset = "0x2120580", VA = "0x182121580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x21217B0", Offset = "0x21207B0", VA = "0x1821217B0")]
	public static Task ICIKLLEKAKC(JDNEJLBOMFE PODNILAEFJM, MLICCGFKPBG HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x21215D0", Offset = "0x21205D0", VA = "0x1821215D0")]
	private void ICIKLLEKAKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class POKOHKIICBM : NFDNOKDBJMA
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class PCMJGJEDHOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public POKOHKIICBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private CMEINEGPICM <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private OANGKBOCJHG <roomSaveOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private FCHEHKECEPG <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private IJCJMPMOCHK <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private IJCJMPMOCHK <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private TaskAwaiter<IJCJMPMOCHK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PCMJGJEDHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x5426B80", Offset = "0x5425B80", VA = "0x185426B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly string EHPHFKEFKFO;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x28BEBF0", Offset = "0x28BDBF0", VA = "0x1828BEBF0")]
	public POKOHKIICBM(Guid KPAGBCDJFAA, JDNEJLBOMFE PODNILAEFJM, IKDJAENEOIK LGOKDDEFMAD, string EHPHFKEFKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x28BEA50", Offset = "0x28BDA50", VA = "0x1828BEA50", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PCMJGJEDHOG))]
	protected override Task OMMOLOGAHOL(DEGFCGHLJFD OPAIPEGNAFH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class PGACOPBGFPJ
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class MNNMLIFPDAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public FJPEGOCFHLO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public MLICCGFKPBG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public PGACOPBGFPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MNNMLIFPDAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x54256E0", Offset = "0x54246E0", VA = "0x1854256E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class HNKLHGNMOBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public PGACOPBGFPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HNKLHGNMOBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class BDNHMCNPMAC
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
			public BDNHMCNPMAC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x5429D10", Offset = "0x5428D10", VA = "0x185429D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public GLHOFFEBKJL<string>.OADOKMKENLA handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public HNKLHGNMOBJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BDNHMCNPMAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x541F6B0", Offset = "0x541E6B0", VA = "0x18541F6B0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task OHKCKJJNNHG(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class LGOEBLODJPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public PGACOPBGFPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private HNKLHGNMOBJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private BDNHMCNPMAC <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LGOEBLODJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x5423CD0", Offset = "0x5422CD0", VA = "0x185423CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class AMOLEODNLIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public PGACOPBGFPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private Dictionary<Guid, List<NOKGGCBOAHJ>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private KeyValuePair<Guid, List<NOKGGCBOAHJ>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AMOLEODNLIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x541F1C0", Offset = "0x541E1C0", VA = "0x18541F1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class MGLCGADLFFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public PGACOPBGFPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private BMIHHOPKAOM <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private Dictionary<Guid, List<NOKGGCBOAHJ>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private KeyValuePair<Guid, List<NOKGGCBOAHJ>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MGLCGADLFFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x5424F90", Offset = "0x5423F90", VA = "0x185424F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class CFHJOMCONOE
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
			public NOKGGCBOAHJ handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public CFHJOMCONOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0x54274B0", Offset = "0x54264B0", VA = "0x1854274B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public EDJKELCENHH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public List<NOKGGCBOAHJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CFHJOMCONOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x541FAB0", Offset = "0x541EAB0", VA = "0x18541FAB0")]
		internal object OGFCMBNHDCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x541F960", Offset = "0x541E960", VA = "0x18541F960")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task FGBHAPCBBBD(NOKGGCBOAHJ handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x541F870", Offset = "0x541E870", VA = "0x18541F870")]
		internal object BDCNDNCLPDH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class GLHINKAOCGO : IAsyncStateMachine
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
		public List<NOKGGCBOAHJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public EDJKELCENHH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public PGACOPBGFPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private CFHJOMCONOE <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GLHINKAOCGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x5421090", Offset = "0x5420090", VA = "0x185421090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class JLFBPALBLNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public PGACOPBGFPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JLFBPALBLNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x5422E50", Offset = "0x5421E50", VA = "0x185422E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class ODNODJIGMKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public ODNODJIGMKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x5426300", Offset = "0x5425300", VA = "0x185426300")]
		internal object MGMFOHPFNBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class GICANEOFJPG : IAsyncStateMachine
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
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public PGACOPBGFPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private ODNODJIGMKG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private BMIHHOPKAOM <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private List<NOKGGCBOAHJ> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GICANEOFJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5420BD0", Offset = "0x541FBD0", VA = "0x185420BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class INFFMJFECGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public INFFMJFECGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x5422080", Offset = "0x5421080", VA = "0x185422080")]
		internal object GFPOIAAODLI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class JDECJIJICAP : IAsyncStateMachine
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
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public PGACOPBGFPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private INFFMJFECGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private HAAIMGEOILO <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private HAAIMGEOILO <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private HAAIMGEOILO <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private TaskAwaiter<HAAIMGEOILO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JDECJIJICAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x54220F0", Offset = "0x54210F0", VA = "0x1854220F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class CFDDPFODGPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CFDDPFODGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x541F800", Offset = "0x541E800", VA = "0x18541F800")]
		internal object ECLFIHHMKLK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly DEGFCGHLJFD OPAIPEGNAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private MLADIDOPHBM AAPGJAMBIDJ;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private NFDNOKDBJMA IBNCPONPDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xC7D8B0", Offset = "0xC7C8B0", VA = "0x180C7D8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x934550", Offset = "0x933550", VA = "0x180934550")]
	public PGACOPBGFPJ(DEGFCGHLJFD OPAIPEGNAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x28BA530", Offset = "0x28B9530", VA = "0x1828BA530")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MNNMLIFPDAN))]
	public Task ICIKLLEKAKC(FJPEGOCFHLO KIEDLHGHJCB, MLICCGFKPBG AFOPLHCLLNE, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x28BA6F0", Offset = "0x28B96F0", VA = "0x1828BA6F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LGOEBLODJPI))]
	private Task KIMIMPLBMNJ(MLICCGFKPBG HCKNMLENIIG, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x28BAE80", Offset = "0x28B9E80", VA = "0x1828BAE80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMOLEODNLIK))]
	private Task PIMIIMFLPLG(MLICCGFKPBG HCKNMLENIIG, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x28BACE0", Offset = "0x28B9CE0", VA = "0x1828BACE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGLCGADLFFF))]
	private Task OACDEKOIPBB(MLICCGFKPBG HCKNMLENIIG, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x28BA950", Offset = "0x28B9950", VA = "0x1828BA950")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GLHINKAOCGO))]
	private Task MMNLCEEPBIF(Guid CPANAOFEFBL, List<NOKGGCBOAHJ> IHABILPHDFG, EDJKELCENHH APJHCNCGIGD, MLICCGFKPBG HCKNMLENIIG, CancellationToken DMHDKAFNNAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x28BA1C0", Offset = "0x28B91C0", VA = "0x1828BA1C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JLFBPALBLNI))]
	private Task GLBIEBNHKBI(MLICCGFKPBG HCKNMLENIIG, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x28BA000", Offset = "0x28B9000", VA = "0x1828BA000")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GICANEOFJPG))]
	private Task FDCHBHPDOPC(Guid MFCECHKHIKC, MLICCGFKPBG HCKNMLENIIG, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x28B9D30", Offset = "0x28B8D30", VA = "0x1828B9D30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JDECJIJICAP))]
	private Task DJOMKEIBDCN(Guid MFCECHKHIKC, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x28B9ED0", Offset = "0x28B8ED0", VA = "0x1828B9ED0")]
	private void FAHCNDBFEHC(Guid MFCECHKHIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x28BA890", Offset = "0x28B9890", VA = "0x1828BA890")]
	private void MFKIEEGJNFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x28BAB20", Offset = "0x28B9B20", VA = "0x1828BAB20")]
	public Guid NCEDJCOLANB(FJPEGOCFHLO OAFGAAEKNMJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x28BA360", Offset = "0x28B9360", VA = "0x1828BA360")]
	[CompilerGenerated]
	private object IAGEKOBINBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal struct IDLDCCPJLGA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private readonly DEGFCGHLJFD OPAIPEGNAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly Guid EMDFAHODBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private bool FKDDMFACIBH;

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2138FB0", Offset = "0x2137FB0", VA = "0x182138FB0")]
	public static IDLDCCPJLGA HDOPEFLAOAP(DEGFCGHLJFD OPAIPEGNAFH)
	{
		return default(IDLDCCPJLGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0xDC6A80", Offset = "0xDC5A80", VA = "0x180DC6A80")]
	public void GHGHHLKGCID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2138FA0", Offset = "0x2137FA0", VA = "0x182138FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x21392F0", Offset = "0x21382F0", VA = "0x1821392F0")]
	private IDLDCCPJLGA(DEGFCGHLJFD OPAIPEGNAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2138FE0", Offset = "0x2137FE0", VA = "0x182138FE0")]
	private void HMNKPDNMBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2139240", Offset = "0x2138240", VA = "0x182139240")]
	private Func<Guid, bool> HNJJADBEBKG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal struct FMAHCPIBLAJ
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class KCNHJAMDGNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public AsyncTaskMethodBuilder<FOBHBCFFLBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public FMAHCPIBLAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private FOBHBCFFLBJ <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private TaskAwaiter<FOBHBCFFLBJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KCNHJAMDGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D2E0", Offset = "0x3C8C2E0", VA = "0x183C8D2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class OOPBNIKOELJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AsyncTaskMethodBuilder<FOBHBCFFLBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public FMAHCPIBLAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private FOBHBCFFLBJ <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private FOBHBCFFLBJ <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter<FOBHBCFFLBJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OOPBNIKOELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x3C91C40", Offset = "0x3C90C40", VA = "0x183C91C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class DEIHNCOBFJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public DEIHNCOBFJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xB672E0", Offset = "0xB662E0", VA = "0x180B672E0")]
		internal bool KNJJGGBEBGK(BHKIGNODGGN sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class FGJDOKNMJHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public AsyncTaskMethodBuilder<FOBHBCFFLBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public KOGEPCGCONJ callbacks;

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
		public LMFNHKGJLBN superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private DEIHNCOBFJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private HFCNBIIEHLN <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private BHKIGNODGGN <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private LMFNHKGJLBN <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private LMFNHKGJLBN <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private HFCNBIIEHLN <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private AOCKGLNEMOK <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private AOCKGLNEMOK <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private BNENJKMIJMI <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private BNENJKMIJMI <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private TaskAwaiter<HFCNBIIEHLN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private TaskAwaiter<AOCKGLNEMOK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private TaskAwaiter<BNENJKMIJMI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FGJDOKNMJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3C845A0", Offset = "0x3C835A0", VA = "0x183C845A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private KOGEPCGCONJ JJLHNLMGEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private DKIKCOHPEBM PPDNJLMMOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	private GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	private long IIKHCGCAMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	private long HCLBMOKINEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	private long APOIFOLOFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private string DEDIJINCEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private LMFNHKGJLBN NMAGJEPJGBK;

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x21312B0", Offset = "0x21302B0", VA = "0x1821312B0")]
	public static Task<FOBHBCFFLBJ> IFEEGJLBEBF(JDNEJLBOMFE PODNILAEFJM, FHNAMDEGIOK NJAMEFJLMOC, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2131120", Offset = "0x2130120", VA = "0x182131120")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KCNHJAMDGNF))]
	private Task<FOBHBCFFLBJ> ICIKLLEKAKC(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2131720", Offset = "0x2130720", VA = "0x182131720")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OOPBNIKOELJ))]
	private Task<FOBHBCFFLBJ> PJGODMNLBIA(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x21314F0", Offset = "0x21304F0", VA = "0x1821314F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FGJDOKNMJHP))]
	private static Task<FOBHBCFFLBJ> PJGODMNLBIA(KOGEPCGCONJ JJLHNLMGEOM, long IIKHCGCAMCH, long HCLBMOKINEP, long APOIFOLOFGK, string DEDIJINCEFD, LMFNHKGJLBN NMAGJEPJGBK, CancellationToken AOAEIGNDKPI, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2131090", Offset = "0x2130090", VA = "0x182131090")]
	private void FEKBGCOCDGL(HFCNBIIEHLN DJAJOEFBOKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal struct COAFBFPKHLP
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class MGOJBGFIIGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public JDNEJLBOMFE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MGOJBGFIIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F280", Offset = "0x3C8E280", VA = "0x183C8F280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class EDHCHPNOIHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public COAFBFPKHLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EDHCHPNOIHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x3C82F20", Offset = "0x3C81F20", VA = "0x183C82F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private static readonly FACALIAHOGE NCPPCAECOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private MLICCGFKPBG HCKNMLENIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private ByteString DINDLJLGDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private DEGFCGHLJFD OPAIPEGNAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private bool PPMPBGFGPJI;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private KOGEPCGCONJ FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x21294D0", Offset = "0x21284D0", VA = "0x1821294D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private bool LKIINHAPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x2129890", Offset = "0x2128890", VA = "0x182129890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private bool FEAPMPPPFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x2129440", Offset = "0x2128440", VA = "0x182129440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x21296B0", Offset = "0x21286B0", VA = "0x1821296B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGOJBGFIIGL))]
	public static Task ICIKLLEKAKC(JDNEJLBOMFE PODNILAEFJM, MLICCGFKPBG HCKNMLENIIG, DEGFCGHLJFD OPAIPEGNAFH, bool PPMPBGFGPJI, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2129520", Offset = "0x2128520", VA = "0x182129520")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDHCHPNOIHP))]
	private Task ICIKLLEKAKC(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal static class BAHEBMIFFLB
{
	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x2122D30", Offset = "0x2121D30", VA = "0x182122D30")]
	public static void FOEDLLINIJF(this AMEDHPDPDLP PGLEPPEKPLH, IACNHFFDGGB DFHJKCNLBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x2122E80", Offset = "0x2121E80", VA = "0x182122E80")]
	public static void MKCICPBJJEE(this IACNHFFDGGB LKKJHIDALEL, [Optional] string FANKIHBOOPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct GDJIMPDFHHO
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class JEGLBJGIJEO : IAsyncStateMachine
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
		public GDJIMPDFHHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JEGLBJGIJEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C430", Offset = "0x3C8B430", VA = "0x183C8C430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private const int JGLAFGEANCN = 20;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private const float LMIJEFNMKPA = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private KOGEPCGCONJ JJLHNLMGEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private MLICCGFKPBG HCKNMLENIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private float IKDLNENFMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private float ANAAKEOEOHF;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2133A30", Offset = "0x2132A30", VA = "0x182133A30")]
	public static Task FHDNLOKIAKA(JDNEJLBOMFE PODNILAEFJM, MLICCGFKPBG HCKNMLENIIG, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2133BE0", Offset = "0x2132BE0", VA = "0x182133BE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JEGLBJGIJEO))]
	public Task ICIKLLEKAKC(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2133F60", Offset = "0x2132F60", VA = "0x182133F60")]
	private static void OKLKPADMFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2133DE0", Offset = "0x2132DE0", VA = "0x182133DE0")]
	private void NMCFHDPEKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2133D30", Offset = "0x2132D30", VA = "0x182133D30")]
	private static float LJJAAFGNCGI(KOGEPCGCONJ JJLHNLMGEOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2133BC0", Offset = "0x2132BC0", VA = "0x182133BC0")]
	private static float HKIAEBNMDMI()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal class DEGFCGHLJFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class PNACGCKMHAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AsyncTaskMethodBuilder<HAAIMGEOILO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public HAAIMGEOILO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public DEGFCGHLJFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private HAAIMGEOILO <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private BHEAAKFGKPI.HLENJMOIMEN<HAAIMGEOILO> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<BHEAAKFGKPI.HLENJMOIMEN<HAAIMGEOILO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PNACGCKMHAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x3C92B10", Offset = "0x3C91B10", VA = "0x183C92B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct MJBKCCIMPBL<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class NECOBOIFPFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public HAAIMGEOILO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NECOBOIFPFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FDF0", Offset = "0x3C8EDF0", VA = "0x183C8FDF0")]
		internal HAAIMGEOILO PNEOPGEMHCK(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class GDAIMDPGHCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public AsyncTaskMethodBuilder<BHEAAKFGKPI.HLENJMOIMEN<HAAIMGEOILO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public HAAIMGEOILO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public DEGFCGHLJFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private NECOBOIFPFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private NDLGDKLMKOL <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private BHEAAKFGKPI.HLENJMOIMEN<HAAIMGEOILO> <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private NDLGDKLMKOL <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private BHEAAKFGKPI.HLENJMOIMEN<HAAIMGEOILO> <>s__6;

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
		private TaskAwaiter<BHEAAKFGKPI.HLENJMOIMEN<HAAIMGEOILO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GDAIMDPGHCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x3C86190", Offset = "0x3C85190", VA = "0x183C86190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class IGKNNIBDFHI<T> : IAsyncStateMachine
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
		public DEGFCGHLJFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private T <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public IGKNNIBDFHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x185C660", Offset = "0x185B660", VA = "0x18185C660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class IGJDCBDFKDH : IAsyncStateMachine
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
		public DEGFCGHLJFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IGJDCBDFKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B7A0", Offset = "0x3C8A7A0", VA = "0x183C8B7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class HOEMPJJIAMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HOEMPJJIAMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B6D0", Offset = "0x3C8A6D0", VA = "0x183C8B6D0")]
		internal object MIBEJOPODKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B5C0", Offset = "0x3C8A5C0", VA = "0x183C8B5C0")]
		internal bool JKBEAAHLJGH(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class GEIGAAKIFCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GEIGAAKIFCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x3C869E0", Offset = "0x3C859E0", VA = "0x183C869E0")]
		internal object DNKFHEBFFEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class IAHPMLHNJPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IAHPMLHNJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B730", Offset = "0x3C8A730", VA = "0x183C8B730")]
		internal object ADJIGNAJKED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private sealed class BOGCADNLOBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BOGCADNLOBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x3C817E0", Offset = "0x3C807E0", VA = "0x183C817E0")]
		internal object AAIAIDCDHCE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class LKJDONCIIFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public DEGFCGHLJFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LKJDONCIIFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x3C8EE80", Offset = "0x3C8DE80", VA = "0x183C8EE80")]
		internal object MGOANCIIIPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class GIKBGDCMKJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public DEGFCGHLJFD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GIKBGDCMKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x3C86AB0", Offset = "0x3C85AB0", VA = "0x183C86AB0")]
		internal object MGOANCIIIPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private static readonly Guid BJGDOMCDPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly NFDNOKDBJMA IBNCPONPDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private readonly BHEAAKFGKPI LMPMBOFADKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	private readonly OHIKLOHOEIH JDANGEIJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private readonly NKLPMCIGHDG LANGEDGGAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private bool MDBMDEAMOGB;

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x212B630", Offset = "0x212A630", VA = "0x18212B630")]
	public DEGFCGHLJFD(NFDNOKDBJMA IBOEOPFBKMK, BHEAAKFGKPI LMPMBOFADKL, OHIKLOHOEIH JDANGEIJBKM, NKLPMCIGHDG LANGEDGGAEK, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x212A6B0", Offset = "0x21296B0", VA = "0x18212A6B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x212A6B0", Offset = "0x21296B0", VA = "0x18212A6B0")]
	public void EHDBDHIGJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x212A180", Offset = "0x2129180", VA = "0x18212A180")]
	public void BADBIILIAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x212B1D0", Offset = "0x212A1D0", VA = "0x18212B1D0")]
	public void NLGNPMBPNCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x212AFE0", Offset = "0x2129FE0", VA = "0x18212AFE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PNACGCKMHAC))]
	internal Task<HAAIMGEOILO> LIGNCENGKFA(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, HAAIMGEOILO LHDBABCMEDP, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x213A010", Offset = "0x2139010", VA = "0x18213A010")]
	private static byte[] BEGAFJKPELG<T>(T FANKIHBOOPE) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x221DE00", Offset = "0x221CE00", VA = "0x18221DE00")]
	private static T EKKKNFDDBMI<T>(MessageParser<T> BGNMAOFIHED, byte[] FANKIHBOOPE, T OEIHLFLEFMO) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x212A2E0", Offset = "0x21292E0", VA = "0x18212A2E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GDAIMDPGHCI))]
	private Task<BHEAAKFGKPI.HLENJMOIMEN<HAAIMGEOILO>> BMFLAEBEEHN(HAAIMGEOILO LHDBABCMEDP, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x221E2C0", Offset = "0x221D2C0", VA = "0x18221E2C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IGKNNIBDFHI<>))]
	internal Task<T> PKIDCICMOFA<T>(CancellationToken JANCDKHOLLO, Func<CancellationToken, Task<T>> HMAACKIELGB, int PABNJDMIMNL = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x212B430", Offset = "0x212A430", VA = "0x18212B430")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IGJDCBDFKDH))]
	internal Task PKIDCICMOFA(CancellationToken JANCDKHOLLO, Func<CancellationToken, Task> HMAACKIELGB, int PABNJDMIMNL = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x212A250", Offset = "0x2129250", VA = "0x18212A250")]
	public HAAIMGEOILO BFNGFEFCBFO(NDLGDKLMKOL OPEJAKGMNML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x212A640", Offset = "0x2129640", VA = "0x18212A640")]
	public NLNGELNHAEK DLENIKMEAJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x212A5D0", Offset = "0x21295D0", VA = "0x18212A5D0")]
	public CKLDLAEHLEJ DKJAGMPLANK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x212B2A0", Offset = "0x212A2A0", VA = "0x18212B2A0")]
	public CMEINEGPICM PGIDMBPPMHD([Optional] FACALIAHOGE? IHHCPPEACEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x212B1A0", Offset = "0x212A1A0", VA = "0x18212B1A0")]
	public void MAINEMLIFBH(Func<Guid, bool> IEEKCBEDONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x212AA10", Offset = "0x2129A10", VA = "0x18212AA10")]
	public void ELGDDCLHKBC(Func<Guid, bool> HAFFFJIBHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x212AEB0", Offset = "0x2129EB0", VA = "0x18212AEB0")]
	public void KIOLCCMDJEM(Func<Guid, bool> IEEKCBEDONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x212ABD0", Offset = "0x2129BD0", VA = "0x18212ABD0")]
	public Guid HDOPEFLAOAP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x212AD80", Offset = "0x2129D80", VA = "0x18212AD80")]
	public void HMNKPDNMBCA(Guid EMDFAHODBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x212A480", Offset = "0x2129480", VA = "0x18212A480")]
	public void COHGAFLDDIH(HAAIMGEOILO JDPBEDFPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x212A7D0", Offset = "0x21297D0", VA = "0x18212A7D0")]
	public void EBBBCGBJAMD(string LFPAPJLBFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x212A8F0", Offset = "0x21298F0", VA = "0x18212A8F0")]
	public void EBBBCGBJAMD(Func<string> GMNPOAFDOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x221DD20", Offset = "0x221CD20", VA = "0x18221DD20")]
	private T BPKFIONCOEJ<T>(T CKMKMNKGMMC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x212AB80", Offset = "0x2129B80", VA = "0x18212AB80")]
	public void FBKKPLLPEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x221DFB0", Offset = "0x221CFB0", VA = "0x18221DFB0")]
	[CompilerGenerated]
	internal static string HGNBKCKMLFF<T>(byte[] OFGEHNEOBIB, int GBMCFPCCNIJ, ref MJBKCCIMPBL<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal struct CCFMFHBONOH
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class JCPIKGAMBEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public JDNEJLBOMFE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public bool omShouldBeEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JCPIKGAMBEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x28AC0F0", Offset = "0x28AB0F0", VA = "0x1828AC0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class CGCKIJLMMDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CCFMFHBONOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private AMEDHPDPDLP <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CGCKIJLMMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x28A8040", Offset = "0x28A7040", VA = "0x1828A8040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private static readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private bool JJPJELKKHCG;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private KOGEPCGCONJ FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2124710", Offset = "0x2123710", VA = "0x182124710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	private CDHOCHHBNDB AAJLKBMPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2124A80", Offset = "0x2123A80", VA = "0x182124A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x21248E0", Offset = "0x21238E0", VA = "0x1821248E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JCPIKGAMBEK))]
	public static Task ICIKLLEKAKC(JDNEJLBOMFE PODNILAEFJM, bool JJPJELKKHCG, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2124760", Offset = "0x2123760", VA = "0x182124760")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGCKIJLMMDI))]
	private Task ICIKLLEKAKC(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2124B00", Offset = "0x2123B00", VA = "0x182124B00")]
	private void PALINIKBIJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
internal struct FJBGCMAEOPH
{
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class KPPIONADJBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public JDNEJLBOMFE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KPPIONADJBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x3C8DCB0", Offset = "0x3C8CCB0", VA = "0x183C8DCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class CLCGDONDBMP
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
			public GLHOFFEBKJL<string>.OADOKMKENLA timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			public CLCGDONDBMP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			private GLHOFFEBKJL<string>.OADOKMKENLA <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x5429E90", Offset = "0x5428E90", VA = "0x185429E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CLCGDONDBMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3C82AE0", Offset = "0x3C81AE0", VA = "0x183C82AE0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task LDCKACKJOBF(GLHOFFEBKJL<string>.OADOKMKENLA timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private sealed class LDFLBNKGLJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public FJBGCMAEOPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private CLCGDONDBMP <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private HAAIMGEOILO <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private TaskAwaiter<HAAIMGEOILO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LDFLBNKGLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x3C8DE60", Offset = "0x3C8CE60", VA = "0x183C8DE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class DEKKPENDJNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public DLDBICONFJM version;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public DEKKPENDJNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x3C82C50", Offset = "0x3C81C50", VA = "0x183C82C50")]
		internal object ADPEJNLDKMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x3C82D30", Offset = "0x3C81D30", VA = "0x183C82D30")]
		internal object EDHNGMMOCNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private MLICCGFKPBG HCKNMLENIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private DEGFCGHLJFD OPAIPEGNAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private bool DANDMANHIDK;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private static readonly ByteString NFGCEMNHBLD;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private KOGEPCGCONJ FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x212F580", Offset = "0x212E580", VA = "0x18212F580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private CDHOCHHBNDB AAJLKBMPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x212F930", Offset = "0x212E930", VA = "0x18212F930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x212F750", Offset = "0x212E750", VA = "0x18212F750")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KPPIONADJBF))]
	public static Task ICIKLLEKAKC(JDNEJLBOMFE PODNILAEFJM, MLICCGFKPBG HCKNMLENIIG, DEGFCGHLJFD OPAIPEGNAFH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI, bool DANDMANHIDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x212F5D0", Offset = "0x212E5D0", VA = "0x18212F5D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LDFLBNKGLJC))]
	private Task ICIKLLEKAKC(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x212F9B0", Offset = "0x212E9B0", VA = "0x18212F9B0")]
	private void NPLOCCCKDNP([NotNull] HJBOCBIPMIO IIOBMIAKFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x212F520", Offset = "0x212E520", VA = "0x18212F520")]
	private bool FDHPDDDOHBO(DLDBICONFJM DFLAEIEBLPA, HJBOCBIPMIO IIOBMIAKFHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal abstract class BPGFNOBMGBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly NFDNOKDBJMA IBNCPONPDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly DEGFCGHLJFD HBBJJKHEPLC;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public KOGEPCGCONJ FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x21243F0", Offset = "0x21233F0", VA = "0x1821243F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public CDHOCHHBNDB AAJLKBMPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x2124410", Offset = "0x2123410", VA = "0x182124410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x2124470", Offset = "0x2123470", VA = "0x182124470")]
	protected BPGFNOBMGBA(DEGFCGHLJFD OPAIPEGNAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x21243D0", Offset = "0x21233D0", VA = "0x1821243D0")]
	protected void EBBBCGBJAMD(string LFPAPJLBFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x21242A0", Offset = "0x21232A0", VA = "0x1821242A0")]
	public void EBBBCGBJAMD(Func<string> GMNPOAFDOFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal class CKLDLAEHLEJ : BPGFNOBMGBA, PFINJLOOIOO
{
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	public delegate Task<FJPEGOCFHLO> FGONIACDGCP(MLICCGFKPBG HCKNMLENIIG, AGJJBIKALMI ODKKAIBEPND, DMCJNHAMGMD MFJEIDAKGAP, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class MAECAKBFMLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public FHNAMDEGIOK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private IDLDCCPJLGA <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private HAAIMGEOILO <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private HAAIMGEOILO <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter<HAAIMGEOILO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MAECAKBFMLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x28ADFE0", Offset = "0x28ACFE0", VA = "0x1828ADFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private sealed class BDKLHCBLBGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder<HAAIMGEOILO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public FHNAMDEGIOK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private HAAIMGEOILO <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private HAAIMGEOILO <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private TaskAwaiter<HAAIMGEOILO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BDKLHCBLBGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x28A6FE0", Offset = "0x28A5FE0", VA = "0x1828A6FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private sealed class BDKHEMBHIMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public FHNAMDEGIOK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BDKHEMBHIMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x28A6D40", Offset = "0x28A5D40", VA = "0x1828A6D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private sealed class IDAPHCFIBIO
	{
		[Cpp2IlInjected.Token(Token = "0x2000137")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			public AsyncTaskMethodBuilder<FOBHBCFFLBJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			public IDAPHCFIBIO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			private FOBHBCFFLBJ <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			private FOBHBCFFLBJ <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			private TaskAwaiter<FJPEGOCFHLO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			private TaskAwaiter<FOBHBCFFLBJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x5428A80", Offset = "0x5427A80", VA = "0x185428A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
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
			public AsyncTaskMethodBuilder<MLICCGFKPBG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public IDAPHCFIBIO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private MLICCGFKPBG <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private MLICCGFKPBG <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private TaskAwaiter<FJPEGOCFHLO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private TaskAwaiter<MLICCGFKPBG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x54291D0", Offset = "0x54281D0", VA = "0x1854291D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
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
			public IDAPHCFIBIO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			private bool <isReloadingSceneForObjectModel>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			private bool <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			private AGJJBIKALMI <timedYielder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			private TaskAwaiter<FJPEGOCFHLO> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x5427610", Offset = "0x5426610", VA = "0x185427610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public FHNAMDEGIOK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public DMCJNHAMGMD preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public DMCJNHAMGMD downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public FOBHBCFFLBJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public DMCJNHAMGMD postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public MLICCGFKPBG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public GDJBEDDBGFK.FMFEBKPGGEH <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IDAPHCFIBIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x28ABF10", Offset = "0x28AAF10", VA = "0x1828ABF10")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<FOBHBCFFLBJ> PFPDECAEFDG(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x28ABC10", Offset = "0x28AAC10", VA = "0x1828ABC10")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<MLICCGFKPBG> AIIFFHOMPBC(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x28ABED0", Offset = "0x28AAED0", VA = "0x1828ABED0")]
		internal void OPHNAADMBHH(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x28ABD80", Offset = "0x28AAD80", VA = "0x1828ABD80")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task MIAMPDNJNEB(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class DMOFMDPGIDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public FHNAMDEGIOK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private IDAPHCFIBIO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private FOBHBCFFLBJ <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private MLICCGFKPBG <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private TaskAwaiter<FOBHBCFFLBJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter<MLICCGFKPBG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public DMOFMDPGIDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x28A8B60", Offset = "0x28A7B60", VA = "0x1828A8B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class NBDPLEKIAGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NBDPLEKIAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x28B4DF0", Offset = "0x28B3DF0", VA = "0x1828B4DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class LCOIPPCHICN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public DMCJNHAMGMD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private TaskAwaiter<FJPEGOCFHLO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LCOIPPCHICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x28AC730", Offset = "0x28AB730", VA = "0x1828AC730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class NHLBOEGMIEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public AsyncTaskMethodBuilder<FJPEGOCFHLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public AGJJBIKALMI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public DMCJNHAMGMD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private TaskAwaiter<FJPEGOCFHLO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NHLBOEGMIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C90920", Offset = "0x3C8F920", VA = "0x183C90920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class CDCEFOAEIBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public AsyncTaskMethodBuilder<FJPEGOCFHLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public AGJJBIKALMI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public DMCJNHAMGMD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private TaskAwaiter<FJPEGOCFHLO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CDCEFOAEIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x28A7360", Offset = "0x28A6360", VA = "0x1828A7360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class HHHKMNLECNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public AsyncTaskMethodBuilder<FJPEGOCFHLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public FJPEGOCFHLO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public MLICCGFKPBG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public DMCJNHAMGMD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private FJPEGOCFHLO <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private FJPEGOCFHLO <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private TaskAwaiter<FJPEGOCFHLO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HHHKMNLECNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x28AAED0", Offset = "0x28A9ED0", VA = "0x1828AAED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class NHLOGJEHMAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public DMCJNHAMGMD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public FGONIACDGCP masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AGJJBIKALMI timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NHLOGJEHMAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class NAALILMCHEK
	{
		[Cpp2IlInjected.Token(Token = "0x2000143")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005AB")]
			public AsyncTaskMethodBuilder<FJPEGOCFHLO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005AC")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			public NAALILMCHEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			private IDisposable <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			private FJPEGOCFHLO <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			private FJPEGOCFHLO <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			private TaskAwaiter<FJPEGOCFHLO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x54297C0", Offset = "0x54287C0", VA = "0x1854297C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public FJPEGOCFHLO originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public NHLOGJEHMAC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NAALILMCHEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x28B4580", Offset = "0x28B3580", VA = "0x1828B4580")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<FJPEGOCFHLO> GGNMFOLHJGB(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class AEIIKLEBCED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public AsyncTaskMethodBuilder<FJPEGOCFHLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AGJJBIKALMI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public DMCJNHAMGMD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public FGONIACDGCP masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private NHLOGJEHMAC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private NAALILMCHEK <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private FJPEGOCFHLO <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private TaskAwaiter<FJPEGOCFHLO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AEIIKLEBCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x28A65B0", Offset = "0x28A55B0", VA = "0x1828A65B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class AAEPHMKAOGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public DMCJNHAMGMD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private FJPEGOCFHLO <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private IEnumerator<FJPEGOCFHLO> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private FJPEGOCFHLO <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private TaskAwaiter<FJPEGOCFHLO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AAEPHMKAOGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x28A6140", Offset = "0x28A5140", VA = "0x1828A6140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class KGCLLMAIDEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KGCLLMAIDEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x28AC540", Offset = "0x28AB540", VA = "0x1828AC540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class HOHGPNHLPKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public CKLDLAEHLEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HOHGPNHLPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x28ABAC0", Offset = "0x28AAAC0", VA = "0x1828ABAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private readonly NLPBKAFHPON ACBKPEOPNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private readonly NLPBKAFHPON IDKHAEHEKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private readonly DKIKCOHPEBM PPDNJLMMOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private readonly PGACOPBGFPJ AAPGJAMBIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private readonly BBLEJFHBLEP GCJKFLLLIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private readonly PGODKIEJDAO EDHEPOGABPK;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float NKLEJKBFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x2125F40", Offset = "0x2124F40", VA = "0x182125F40", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private JDNEJLBOMFE FKLDBIJEFGA
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x2127580", Offset = "0x2126580", VA = "0x182127580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event BKCKGJBCPDC BNKIGGCJDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x2125EE0", Offset = "0x2124EE0", VA = "0x182125EE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x2127560", Offset = "0x2126560", VA = "0x182127560", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x2127DC0", Offset = "0x2126DC0", VA = "0x182127DC0")]
	public CKLDLAEHLEJ(DEGFCGHLJFD OPAIPEGNAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x21269E0", Offset = "0x21259E0", VA = "0x1821269E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MAECAKBFMLO))]
	public Task DMPCJPACMOG(FHNAMDEGIOK NJAMEFJLMOC, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x2126B80", Offset = "0x2125B80", VA = "0x182126B80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BDKLHCBLBGM))]
	private Task<HAAIMGEOILO> EGDOLINDCGD(FHNAMDEGIOK NJAMEFJLMOC, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x21262C0", Offset = "0x21252C0", VA = "0x1821262C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BDKHEMBHIMD))]
	private Task CBDJIAJPKKE(FHNAMDEGIOK NJAMEFJLMOC, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x2126120", Offset = "0x2125120", VA = "0x182126120")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DMOFMDPGIDE))]
	private Task BMKOLGPKIIB(FHNAMDEGIOK NJAMEFJLMOC, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken CGILLIIIJHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x21278E0", Offset = "0x21268E0", VA = "0x1821278E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NBDPLEKIAGJ))]
	private Task ODIJECIEJKM(GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2125F60", Offset = "0x2124F60", VA = "0x182125F60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LCOIPPCHICN))]
	private Task BBKHGALLEIL(MLICCGFKPBG HCKNMLENIIG, DMCJNHAMGMD MFJEIDAKGAP, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2126670", Offset = "0x2125670", VA = "0x182126670")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHLBOEGMIEH))]
	private Task<FJPEGOCFHLO> DFCBPKFOCEI(MLICCGFKPBG HCKNMLENIIG, AGJJBIKALMI NAHMLNGINOI, DMCJNHAMGMD MFJEIDAKGAP, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2126D80", Offset = "0x2125D80", VA = "0x182126D80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CDCEFOAEIBJ))]
	private Task<FJPEGOCFHLO> GAFEMIFNKIA(MLICCGFKPBG HCKNMLENIIG, AGJJBIKALMI NAHMLNGINOI, DMCJNHAMGMD MFJEIDAKGAP, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2126460", Offset = "0x2125460", VA = "0x182126460")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HHHKMNLECNI))]
	private Task<FJPEGOCFHLO> CJFCOPMFKOI(FJPEGOCFHLO KIEDLHGHJCB, MLICCGFKPBG AFOPLHCLLNE, DMCJNHAMGMD MFJEIDAKGAP, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI, bool MDMHKLIJAJK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x21268A0", Offset = "0x21258A0", VA = "0x1821268A0")]
	private bool DKILMOJGDNM(MLICCGFKPBG CGAGOCFMPLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2127150", Offset = "0x2126150", VA = "0x182127150")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AEIIKLEBCED))]
	protected Task<FJPEGOCFHLO> HAPHHJNBLDB(MLICCGFKPBG HCKNMLENIIG, AGJJBIKALMI NAHMLNGINOI, DMCJNHAMGMD MFJEIDAKGAP, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI, FGONIACDGCP LFIIAPAGGDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2127A50", Offset = "0x2126A50", VA = "0x182127A50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AAEPHMKAOGF))]
	private Task OIFKEKONMEP(MLICCGFKPBG HCKNMLENIIG, DMCJNHAMGMD MFJEIDAKGAP, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2127380", Offset = "0x2126380", VA = "0x182127380")]
	private void HBNAOLNEEKG(FJPEGOCFHLO OAFGAAEKNMJ, DMCJNHAMGMD MFJEIDAKGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2127520", Offset = "0x2126520", VA = "0x182127520")]
	private void KNDPFNBMKKK(FJPEGOCFHLO LMPLJPPMPAP, out FJPEGOCFHLO KIEKFAJFMBF, out FJPEGOCFHLO AFNNENFJKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2127D80", Offset = "0x2126D80", VA = "0x182127D80")]
	private Task<FOBHBCFFLBJ> PJGODMNLBIA(FHNAMDEGIOK NJAMEFJLMOC, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2125F00", Offset = "0x2124F00", VA = "0x182125F00")]
	private Task<MLICCGFKPBG> AOICOKICBFJ(FOBHBCFFLBJ HCKNMLENIIG, GDJBEDDBGFK.FMFEBKPGGEH JNFCLJKLECH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x2126F90", Offset = "0x2125F90", VA = "0x182126F90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KGCLLMAIDEC))]
	private Task GEMKPFOPKKK(MLICCGFKPBG HCKNMLENIIG, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI, bool DANDMANHIDK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x2127C10", Offset = "0x2126C10", VA = "0x182127C10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HOHGPNHLPKN))]
	private Task OMDIKEDEEAD(MLICCGFKPBG HCKNMLENIIG, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x2127750", Offset = "0x2126750", VA = "0x182127750")]
	private Task MPDDPHIIICF(MLICCGFKPBG HCKNMLENIIG, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x2126D60", Offset = "0x2125D60", VA = "0x182126D60")]
	private Task FDJICGILHNA(MLICCGFKPBG HCKNMLENIIG, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x2126880", Offset = "0x2125880", VA = "0x182126880")]
	private Task DIAKBDNKJFL(MLICCGFKPBG HCKNMLENIIG, AGJJBIKALMI NAHMLNGINOI, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x2127500", Offset = "0x2126500", VA = "0x182127500")]
	private Task KGOEGIKDGJA(MLICCGFKPBG HCKNMLENIIG, AGJJBIKALMI NAHMLNGINOI, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x2124670", Offset = "0x2123670", VA = "0x182124670")]
	private static Task BPCENFOBPNK(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x21275B0", Offset = "0x21265B0", VA = "0x1821275B0")]
	private Task LOGIHFNIMHD(MLICCGFKPBG HCKNMLENIIG, AGJJBIKALMI NAHMLNGINOI, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x2126D40", Offset = "0x2125D40", VA = "0x182126D40")]
	private Task ENMGPBGILJP(MLICCGFKPBG HCKNMLENIIG, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x2127480", Offset = "0x2126480", VA = "0x182127480")]
	private void JBBEPBLGNBN(FHNAMDEGIOK NJAMEFJLMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x21273D0", Offset = "0x21263D0", VA = "0x1821273D0")]
	public void ILDFFOAHFGN(long INEHMKECLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	private static void EJPENMLFCLA(HFCNBIIEHLN DJAJOEFBOKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal abstract class NFDNOKDBJMA : PFINJLOOIOO
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public delegate Task BOEPOBDLAGA(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class BJFCDFDGKNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public GLHOFFEBKJL<string>.OADOKMKENLA operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public NFDNOKDBJMA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BJFCDFDGKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x3D60250", Offset = "0x3D5F250", VA = "0x183D60250")]
		internal Task PAIFEHGAJLA(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class MLAALHCJCOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public BJFCDFDGKNI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MLAALHCJCOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x5425560", Offset = "0x5424560", VA = "0x185425560")]
		internal object BJPFCEKHPGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x5425620", Offset = "0x5424620", VA = "0x185425620")]
		internal object FBJDFDPDKEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class HFMHPOLJAAJ : IAsyncStateMachine
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
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public Func<NFDNOKDBJMA, GLHOFFEBKJL<string>.OADOKMKENLA, DEGFCGHLJFD> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public NFDNOKDBJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private BJFCDFDGKNI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private DEGFCGHLJFD <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private HAAIMGEOILO <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private MLAALHCJCOP <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private TaskAwaiter<HAAIMGEOILO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HFMHPOLJAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x3D65810", Offset = "0x3D64810", VA = "0x183D65810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class NLLCKCFFIMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public NFDNOKDBJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private BOEPOBDLAGA <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NLLCKCFFIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x5426000", Offset = "0x5425000", VA = "0x185426000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public readonly Guid FBALPGIFIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	public readonly ByteString PMIBNJDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	public readonly IKDJAENEOIK BEBLKKBALGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	protected readonly string NLHMPAJENCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private readonly JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private readonly bool MOPIDKGAOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private readonly Queue<BOEPOBDLAGA> FIGDAAPLKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private readonly DMCJNHAMGMD EGIDEIKPIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private readonly NOOIKMHHFGH GFEALFGNOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private bool EGCDBJKKBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	public FJPEGOCFHLO HNHJCLPEEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	public FJPEGOCFHLO HFAKCFDKKPO;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public JDNEJLBOMFE FKLDBIJEFGA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x944E10", Offset = "0x943E10", VA = "0x180944E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public KOGEPCGCONJ FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x28B5930", Offset = "0x28B4930", VA = "0x1828B5930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public AMHFGBDMPHO AHDHPIHKONG
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x28B5B00", Offset = "0x28B4B00", VA = "0x1828B5B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public CDHOCHHBNDB AAJLKBMPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x28B5DD0", Offset = "0x28B4DD0", VA = "0x1828B5DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public float NKLEJKBFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x28B5680", Offset = "0x28B4680", VA = "0x1828B5680", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event BKCKGJBCPDC BNKIGGCJDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x28B54F0", Offset = "0x28B44F0", VA = "0x1828B54F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x28B5DB0", Offset = "0x28B4DB0", VA = "0x1828B5DB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x28B5E50", Offset = "0x28B4E50", VA = "0x1828B5E50")]
	protected NFDNOKDBJMA(Guid KPAGBCDJFAA, JDNEJLBOMFE PODNILAEFJM, IKDJAENEOIK LGOKDDEFMAD, string LMIEDLKHILL, NOOIKMHHFGH GFEALFGNOCP, bool MOPIDKGAOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x28B5D70", Offset = "0x28B4D70", VA = "0x1828B5D70", Slot = "7")]
	protected virtual string KJLJJJEABOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x28B5D10", Offset = "0x28B4D10", VA = "0x1828B5D10")]
	public void JCHGPGFJMFB(BOEPOBDLAGA KAAMIGCABEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x28B5B50", Offset = "0x28B4B50", VA = "0x1828B5B50")]
	protected void HMPCPIBLMOM(float NGPEGHBKONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x28B5B70", Offset = "0x28B4B70", VA = "0x1828B5B70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HFMHPOLJAAJ))]
	public Task ICIKLLEKAKC(CancellationToken AOAEIGNDKPI, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, [Optional] Func<NFDNOKDBJMA, GLHOFFEBKJL<string>.OADOKMKENLA, DEGFCGHLJFD> FOMGJPCNEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x28B5980", Offset = "0x28B4980", VA = "0x1828B5980")]
	private void GNELPPIDFNF(bool FKDDMFACIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x28B5730", Offset = "0x28B4730", VA = "0x1828B5730")]
	private void DGLPELJJPCO(DEGFCGHLJFD OPAIPEGNAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task OMMOLOGAHOL(DEGFCGHLJFD OPAIPEGNAFH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x28B5510", Offset = "0x28B4510", VA = "0x1828B5510")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NLLCKCFFIMM))]
	private Task AJLEGNFBPHD(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x28B56A0", Offset = "0x28B46A0", VA = "0x1828B56A0")]
	public HAAIMGEOILO BFNGFEFCBFO(NDLGDKLMKOL OPEJAKGMNML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x28B5850", Offset = "0x28B4850", VA = "0x1828B5850")]
	[CompilerGenerated]
	private Task FPOBCAKBHOH(CancellationToken DIIOIJOPPCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal abstract class JDEANEJJHEC : NFDNOKDBJMA
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class BAPFNAHIOKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public JDEANEJJHEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public GCJMIIKJJEA playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BAPFNAHIOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EE50", Offset = "0x3D5DE50", VA = "0x183D5EE50")]
		internal Task GFGGNMJDIFJ(GLHOFFEBKJL<string>.OADOKMKENLA postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EE90", Offset = "0x3D5DE90", VA = "0x183D5EE90")]
		internal object HGPFGANNEFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class EDGHLCLGFHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public JDEANEJJHEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private BAPFNAHIOKK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private ANOOGLOIHBD <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EDGHLCLGFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x3D61D20", Offset = "0x3D60D20", VA = "0x183D61D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class MLDPKMOEFGF : IAsyncStateMachine
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
		public GCJMIIKJJEA playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public GLHOFFEBKJL<string>.OADOKMKENLA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public JDEANEJJHEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MLDPKMOEFGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x3D6CC10", Offset = "0x3D6BC10", VA = "0x183D6CC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x213DFB0", Offset = "0x213CFB0", VA = "0x18213DFB0")]
	public JDEANEJJHEC(Guid KPAGBCDJFAA, JDNEJLBOMFE PODNILAEFJM, IKDJAENEOIK LGOKDDEFMAD, string LMIEDLKHILL, NOOIKMHHFGH GFEALFGNOCP, bool MOPIDKGAOHO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x213DE10", Offset = "0x213CE10", VA = "0x18213DE10", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDGHLCLGFHF))]
	protected override Task OMMOLOGAHOL(DEGFCGHLJFD OPAIPEGNAFH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task MJCIDGMOBDD(DEGFCGHLJFD OPAIPEGNAFH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x213DC70", Offset = "0x213CC70", VA = "0x18213DC70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MLDPKMOEFGF))]
	private Task EKLLDPNPBKE(IDisposable HAMICBHECMM, GCJMIIKJJEA FMPNKECNFPF, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
public readonly struct IJCJMPMOCHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	public readonly HJBOCBIPMIO? BHCNFJGHLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	public readonly ALBGBBIHDHI IJMEOECOLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	public readonly string? NGPKHKMKPIP;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IReadOnlyCollection<string> ILEMBEJGCOA
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x213B370", Offset = "0x213A370", VA = "0x18213B370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public IReadOnlyDictionary<long, int> DALPIBLAPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x213B390", Offset = "0x213A390", VA = "0x18213B390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x213B3B0", Offset = "0x213A3B0", VA = "0x18213B3B0")]
	public IJCJMPMOCHK(HJBOCBIPMIO? EICHFPBIJBD, ALBGBBIHDHI LJKGLAICBJJ, string? KHCIFCBONLA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct MOPMGOMDNCA
{
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class KCKDDIKIGIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private NFDNOKDBJMA <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private JDNEJLBOMFE <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private DFBHMCCJCBD.KJONFBCKMEH <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private TaskAwaiter<HAAIMGEOILO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KCKDDIKIGIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x3D68C90", Offset = "0x3D67C90", VA = "0x183D68C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class MEPFFJAKNLH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MEPFFJAKNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x3D6BC10", Offset = "0x3D6AC10", VA = "0x183D6BC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x28B4370", Offset = "0x28B3370", VA = "0x1828B4370")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KCKDDIKIGIK))]
	public static Task ICIKLLEKAKC(DEGFCGHLJFD OPAIPEGNAFH, MLICCGFKPBG HCKNMLENIIG, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x28B4510", Offset = "0x28B3510", VA = "0x1828B4510")]
	private static Task<HAAIMGEOILO> ONLIFJEKEBE(DEGFCGHLJFD OPAIPEGNAFH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x28B4270", Offset = "0x28B3270", VA = "0x1828B4270")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MEPFFJAKNLH))]
	private static Task FEFIBGPEEFK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal class PGHDDOJGDPE : NFDNOKDBJMA
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class JMBHBOEJMBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public PGHDDOJGDPE <>4__this;

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
		private NLNGELNHAEK <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private IJCJMPMOCHK <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private GHFIGJILBPN <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private AOMNJPFLLBL <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private TaskAwaiter<AOMNJPFLLBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JMBHBOEJMBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x5423100", Offset = "0x5422100", VA = "0x185423100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private readonly int GAFCNALPDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private readonly NGDFPBDGPNO LADKCLEPKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	public readonly long NAFMDDMADFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	public readonly long NBHODKPJNCL;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public AOMNJPFLLBL GHKEEHBLBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xA19A10", Offset = "0xA18A10", VA = "0x180A19A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xA8F180", Offset = "0xA8E180", VA = "0x180A8F180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x28BDF90", Offset = "0x28BCF90", VA = "0x1828BDF90")]
	public PGHDDOJGDPE(Guid KPAGBCDJFAA, JDNEJLBOMFE PODNILAEFJM, IKDJAENEOIK LGOKDDEFMAD, int GAFCNALPDED, NGDFPBDGPNO LADKCLEPKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x28BDDF0", Offset = "0x28BCDF0", VA = "0x1828BDDF0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JMBHBOEJMBD))]
	protected override Task OMMOLOGAHOL(DEGFCGHLJFD OPAIPEGNAFH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct BBLEJFHBLEP
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private sealed class HMMONJLAPEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public AsyncTaskMethodBuilder<FJPEGOCFHLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public FJPEGOCFHLO nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public MLICCGFKPBG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public BBLEJFHBLEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private FJPEGOCFHLO <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private TaskAwaiter<FJPEGOCFHLO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HMMONJLAPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x28AB0F0", Offset = "0x28AA0F0", VA = "0x1828AB0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class COABBOMMMNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public AsyncTaskMethodBuilder<FJPEGOCFHLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public FJPEGOCFHLO state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public BBLEJFHBLEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private HAAIMGEOILO <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private HAAIMGEOILO <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private FJPEGOCFHLO <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private HAAIMGEOILO <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private TaskAwaiter<HAAIMGEOILO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public COABBOMMMNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x28A8810", Offset = "0x28A7810", VA = "0x1828A8810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private readonly DEGFCGHLJFD OPAIPEGNAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private readonly DKIKCOHPEBM PPDNJLMMOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private readonly PGACOPBGFPJ AAPGJAMBIDJ;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private NFDNOKDBJMA IBNCPONPDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x2123060", Offset = "0x2122060", VA = "0x182123060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x2123470", Offset = "0x2122470", VA = "0x182123470")]
	public BBLEJFHBLEP(DEGFCGHLJFD OPAIPEGNAFH, DKIKCOHPEBM PPDNJLMMOEM, PGACOPBGFPJ AAPGJAMBIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x2123270", Offset = "0x2122270", VA = "0x182123270")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HMMONJLAPEG))]
	public Task<FJPEGOCFHLO> PDIHEDFLFNG(FJPEGOCFHLO KIPPCFNFDDP, MLICCGFKPBG AFOPLHCLLNE, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI, bool MDMHKLIJAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x21230A0", Offset = "0x21220A0", VA = "0x1821230A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(COABBOMMMNO))]
	private Task<FJPEGOCFHLO> HMAIDKNBJLH(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, FJPEGOCFHLO EGNHEHPGBMN, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x2123030", Offset = "0x2122030", VA = "0x182123030")]
	private bool BBGCDLNOPCC(FJPEGOCFHLO MDEEHDJBPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x2123080", Offset = "0x2122080", VA = "0x182123080")]
	private void EBBBCGBJAMD(string DDBKCEMOFJA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct OKPDPJNJCMK
{
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class OHMDPLMEGNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public AGJJBIKALMI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private NFDNOKDBJMA <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private FJPEGOCFHLO <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private JDNEJLBOMFE <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private KOGEPCGCONJ <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private BEIJGNKMAEG <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private IDisposable <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private List<(PersistenceView, EHDNHMEBPAJ)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private EHDNHMEBPAJ <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OHMDPLMEGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x5426370", Offset = "0x5425370", VA = "0x185426370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x28B7F50", Offset = "0x28B6F50", VA = "0x1828B7F50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OHMDPLMEGNF))]
	public static Task ICIKLLEKAKC(DEGFCGHLJFD OPAIPEGNAFH, MLICCGFKPBG HCKNMLENIIG, AGJJBIKALMI NAHMLNGINOI, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x28B7D40", Offset = "0x28B6D40", VA = "0x1828B7D40")]
	private static void DLAIFKJJNGA(PersistenceView KNJCBGNMLFC, EHDNHMEBPAJ FOIHDPEDGJM, MLICCGFKPBG HCKNMLENIIG, FJPEGOCFHLO KIEDLHGHJCB, bool NEMDFCKOCMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal class CMEINEGPICM : BPGFNOBMGBA
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class PGJAMBEJNBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder<IJCJMPMOCHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public OANGKBOCJHG roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public FCHEHKECEPG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public CMEINEGPICM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PGJAMBEJNBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x3C92620", Offset = "0x3C91620", VA = "0x183C92620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class AJIFNNJCDOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public FCHEHKECEPG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public CMEINEGPICM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AJIFNNJCDOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x3C80A10", Offset = "0x3C7FA10", VA = "0x183C80A10")]
		internal Task CCJJPCAEJAD(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x3C80C50", Offset = "0x3C7FC50", VA = "0x183C80C50")]
		internal Task NPACHBHINPE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class GFLLIOMDNPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public AJIFNNJCDOA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GFLLIOMDNPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x3C86A40", Offset = "0x3C85A40", VA = "0x183C86A40")]
		internal object MIMPDMLIFIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class HLCIEEMKEBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AJIFNNJCDOA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HLCIEEMKEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B580", Offset = "0x3C8A580", VA = "0x183C8B580")]
		internal Task LCMBMOBDCIO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class CGNGHBEBMJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public FCHEHKECEPG serializeType;

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
		public CMEINEGPICM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private AJIFNNJCDOA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private GFLLIOMDNPK <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CGNGHBEBMJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x3C82260", Offset = "0x3C81260", VA = "0x183C82260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private readonly HCKPLALPEPN GKBNGGKDBGF;

	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private static readonly TimeSpan IDKOEMAIOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly BDLKJKHIBAO PPGPGOIEKBF;

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x2129160", Offset = "0x2128160", VA = "0x182129160")]
	public CMEINEGPICM(DEGFCGHLJFD OPAIPEGNAFH, BDLKJKHIBAO PPGPGOIEKBF, FACALIAHOGE IHHCPPEACEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x2128000", Offset = "0x2127000", VA = "0x182128000")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PGJAMBEJNBJ))]
	public Task<IJCJMPMOCHK> BCEEACLIKPE(long HCLBMOKINEP, OANGKBOCJHG CFHBGCMLNED, FCHEHKECEPG MHANIEBHIHC, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x21286C0", Offset = "0x21276C0", VA = "0x1821286C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGNGHBEBMJA))]
	private Task FEHDMFLINIC(FCHEHKECEPG MHANIEBHIHC, IEnumerable<PersistenceView> CDGHLNDNDOH, StringBuilder NGEHEGFHFJB, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x2128880", Offset = "0x2127880", VA = "0x182128880")]
	private IJCJMPMOCHK GGPBADLGINB(long HCLBMOKINEP, OANGKBOCJHG CFHBGCMLNED, FCHEHKECEPG MHANIEBHIHC, IEnumerable<PersistenceView> CDGHLNDNDOH, StringBuilder NGEHEGFHFJB)
	{
		return default(IJCJMPMOCHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x2128F30", Offset = "0x2127F30", VA = "0x182128F30")]
	private HJBOCBIPMIO OIDBEIPAAEE(long HCLBMOKINEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x2128D20", Offset = "0x2127D20", VA = "0x182128D20")]
	private void JHMFBBOGINL(HJBOCBIPMIO AAMCPGJKAGK, StringBuilder NGEHEGFHFJB, IEnumerable<PersistenceView> CDGHLNDNDOH, in JDHBPCKDEIH GIMGMHOIHOB, OOMJECFJHBK NIICCNOEDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x21281E0", Offset = "0x21271E0", VA = "0x1821281E0")]
	private void DEOPNOOHCIN(HJBOCBIPMIO AAMCPGJKAGK, StringBuilder NGEHEGFHFJB, PersistenceView KNJCBGNMLFC, ref OOMJECFJHBK NIICCNOEDKK, in JDHBPCKDEIH GIMGMHOIHOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal class IGHMMBMHKFC : NFDNOKDBJMA
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class OBFACMOMOOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public IGHMMBMHKFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private OANGKBOCJHG <roomSaveOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private CMEINEGPICM <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private FCHEHKECEPG <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private IJCJMPMOCHK <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private IJCJMPMOCHK <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private TaskAwaiter<IJCJMPMOCHK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OBFACMOMOOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E130", Offset = "0x3D6D130", VA = "0x183D6E130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly GHGMNDCOENL NHJGHMDIBIC;

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x213B240", Offset = "0x213A240", VA = "0x18213B240")]
	public IGHMMBMHKFC(Guid KPAGBCDJFAA, JDNEJLBOMFE PODNILAEFJM, IKDJAENEOIK LGOKDDEFMAD, GHGMNDCOENL NHJGHMDIBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x213AFC0", Offset = "0x2139FC0", VA = "0x18213AFC0", Slot = "7")]
	protected override string KJLJJJEABOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x213B0A0", Offset = "0x213A0A0", VA = "0x18213B0A0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OBFACMOMOOM))]
	protected override Task OMMOLOGAHOL(DEGFCGHLJFD OPAIPEGNAFH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct MLADIDOPHBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	public Dictionary<Guid, List<NOKGGCBOAHJ>> BINOELLJNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	public Dictionary<Guid, List<NOKGGCBOAHJ>> EHPGHOGLNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	public Dictionary<Guid, List<NOKGGCBOAHJ>> FIIMAAKGLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	public List<Guid> KMIGNCKGMEP;

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x28B35C0", Offset = "0x28B25C0", VA = "0x1828B35C0")]
	public static MLADIDOPHBM EAOPAIAIDNN(KOGEPCGCONJ JJLHNLMGEOM, FJPEGOCFHLO KIEDLHGHJCB, MLICCGFKPBG AFOPLHCLLNE)
	{
		return default(MLADIDOPHBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public readonly struct NPBBNMNNFIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	public readonly bool IOADKHNFBGG;

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x16B8DA0", Offset = "0x16B7DA0", VA = "0x1816B8DA0")]
	public NPBBNMNNFIK(bool DHNJJAKKFEH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct BPKALAIJKOJ
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class EJDNCBLHMLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public NFDNOKDBJMA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public AGJJBIKALMI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private FJPEGOCFHLO <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private List<(PersistenceView, EHDNHMEBPAJ)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private (PersistenceView, EHDNHMEBPAJ) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private IHCOAICHMDG <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EJDNCBLHMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x28A98B0", Offset = "0x28A88B0", VA = "0x1828A98B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x21244D0", Offset = "0x21234D0", VA = "0x1821244D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJDNCBLHMLD))]
	public static Task ICIKLLEKAKC(NFDNOKDBJMA IBOEOPFBKMK, MLICCGFKPBG HCKNMLENIIG, AGJJBIKALMI NAHMLNGINOI, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal struct DAEJHJNDMNG
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class CFCOJMGGNHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public AsyncTaskMethodBuilder<MLICCGFKPBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public GDJBEDDBGFK.FMFEBKPGGEH downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public DAEJHJNDMNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private Task<ADCOJCAAGFK<MJDOGGEGMAI, NEMFMBIHPEH>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private Task<ADCOJCAAGFK<FOGNJLANFCJ<HJBOCBIPMIO>, NEMFMBIHPEH>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private Task<ADCOJCAAGFK<FOGNJLANFCJ<FAOEADGKIBK>, NEMFMBIHPEH>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private Task<ADCOJCAAGFK<FOGNJLANFCJ<LNEEMMLDGFL>, NEMFMBIHPEH>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private Task<(ADCOJCAAGFK<MJDOGGEGMAI, NEMFMBIHPEH>, ADCOJCAAGFK<FOGNJLANFCJ<HJBOCBIPMIO>, NEMFMBIHPEH>, ADCOJCAAGFK<FOGNJLANFCJ<FAOEADGKIBK>, NEMFMBIHPEH>, ADCOJCAAGFK<FOGNJLANFCJ<LNEEMMLDGFL>, NEMFMBIHPEH>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private ADCOJCAAGFK<MJDOGGEGMAI, NEMFMBIHPEH> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private ADCOJCAAGFK<FOGNJLANFCJ<HJBOCBIPMIO>, NEMFMBIHPEH> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private ADCOJCAAGFK<FOGNJLANFCJ<FAOEADGKIBK>, NEMFMBIHPEH> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private ADCOJCAAGFK<FOGNJLANFCJ<LNEEMMLDGFL>, NEMFMBIHPEH> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private FOGNJLANFCJ<HJBOCBIPMIO> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private (ADCOJCAAGFK<MJDOGGEGMAI, NEMFMBIHPEH>, ADCOJCAAGFK<FOGNJLANFCJ<HJBOCBIPMIO>, NEMFMBIHPEH>, ADCOJCAAGFK<FOGNJLANFCJ<FAOEADGKIBK>, NEMFMBIHPEH>, ADCOJCAAGFK<FOGNJLANFCJ<LNEEMMLDGFL>, NEMFMBIHPEH>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private (ADCOJCAAGFK<MJDOGGEGMAI, NEMFMBIHPEH>, ADCOJCAAGFK<FOGNJLANFCJ<HJBOCBIPMIO>, NEMFMBIHPEH>, ADCOJCAAGFK<FOGNJLANFCJ<FAOEADGKIBK>, NEMFMBIHPEH>, ADCOJCAAGFK<FOGNJLANFCJ<LNEEMMLDGFL>, NEMFMBIHPEH>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private TaskAwaiter<(ADCOJCAAGFK<MJDOGGEGMAI, NEMFMBIHPEH>, ADCOJCAAGFK<FOGNJLANFCJ<HJBOCBIPMIO>, NEMFMBIHPEH>, ADCOJCAAGFK<FOGNJLANFCJ<FAOEADGKIBK>, NEMFMBIHPEH>, ADCOJCAAGFK<FOGNJLANFCJ<LNEEMMLDGFL>, NEMFMBIHPEH>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CFCOJMGGNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x3C81850", Offset = "0x3C80850", VA = "0x183C81850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class MJGMOEGKMCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public AsyncTaskMethodBuilder<ADCOJCAAGFK<MJDOGGEGMAI, NEMFMBIHPEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public GDJBEDDBGFK.FMFEBKPGGEH downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public GLHOFFEBKJL<string>.OADOKMKENLA downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public DAEJHJNDMNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private ADCOJCAAGFK<MJDOGGEGMAI, NEMFMBIHPEH> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private TaskAwaiter<ADCOJCAAGFK<MJDOGGEGMAI, NEMFMBIHPEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MJGMOEGKMCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F690", Offset = "0x3C8E690", VA = "0x183C8F690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	private PBENKKBPEBM<LMFNHKGJLBN, FAOEADGKIBK> HBJOKDMLKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	private PBENKKBPEBM<LMFNHKGJLBN, HJBOCBIPMIO> KOHJFJDMEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private PBENKKBPEBM<long, LNEEMMLDGFL> FNDGOINDCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private KGHGBLABDIP FGHCLKBFBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private HFCNBIIEHLN DJAJOEFBOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private BHKIGNODGGN GEDMENHCEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private string KHCIFCBONLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private LMFNHKGJLBN KKOHNCFJGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private LMFNHKGJLBN IPILOODINKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private long INEHMKECLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH;

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x2129D90", Offset = "0x2128D90", VA = "0x182129D90")]
	public static Task<MLICCGFKPBG> IFEEGJLBEBF(JDNEJLBOMFE PODNILAEFJM, in FOBHBCFFLBJ HCKNMLENIIG, GDJBEDDBGFK.FMFEBKPGGEH JNFCLJKLECH, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x2129BC0", Offset = "0x2128BC0", VA = "0x182129BC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CFCOJMGGNHD))]
	private Task<MLICCGFKPBG> ICIKLLEKAKC(GDJBEDDBGFK.FMFEBKPGGEH JNFCLJKLECH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x2129990", Offset = "0x2128990", VA = "0x182129990")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MJGMOEGKMCH))]
	private Task<ADCOJCAAGFK<MJDOGGEGMAI, NEMFMBIHPEH>> CGCPGLPOHAP(string KHCIFCBONLA, long INEHMKECLJM, GDJBEDDBGFK.FMFEBKPGGEH JNFCLJKLECH, GLHOFFEBKJL<string>.OADOKMKENLA DJKCFFPBOLD, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
public class DKIKCOHPEBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private readonly CDNJAGBMOFC CLBDIFEPPCH;

	[Cpp2IlInjected.Token(Token = "0x40006EB")]
	private const string IEBMHFNGPDE = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	private const string EAEFCNHHJMI = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40006ED")]
	private const string KHDDLFEHCMD = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40006EE")]
	private const string EDMABGEHMJM = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	private const string GIGEIHINBKJ = "RL_LastLoadedRoomInstanceId";

	[Cpp2IlInjected.Token(Token = "0x40006F0")]
	private const string MLNFKOJDAGM = "RL_LastHeartbeatSessionData";

	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private const string JAKDGINKOBA = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private string NEOCJIHJOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	private long? MPIKADKGJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private long? DNBDFCDFBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private long? JDCKHEAEFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	private string AALBJNCJPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	private FJPEGOCFHLO LPEHLLCKHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private long? IFNAAIANJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006F9")]
	private bool DFINILMEIPJ;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public string INHMGGPCCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public long PFEMNBDCENA
	{
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x212C780", Offset = "0x212B780", VA = "0x18212C780")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public long PKJCEJJJAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x212C6E0", Offset = "0x212B6E0", VA = "0x18212C6E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public long CCBKJECDFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x212D030", Offset = "0x212C030", VA = "0x18212D030")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public string DCJCPMNPMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x212C740", Offset = "0x212B740", VA = "0x18212C740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public FJPEGOCFHLO OAMMGDFDPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xAC0EA0", Offset = "0xABFEA0", VA = "0x180AC0EA0")]
		get
		{
			return default(FJPEGOCFHLO);
		}
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x212C2F0", Offset = "0x212B2F0", VA = "0x18212C2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public long GNLAJJPCALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x212C3D0", Offset = "0x212B3D0", VA = "0x18212C3D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x212D090", Offset = "0x212C090", VA = "0x18212D090")]
	[UnityEngine.Scripting.Preserve]
	public DKIKCOHPEBM([KMDNJCFAMOJ(null)] CDNJAGBMOFC CLBDIFEPPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x212C4D0", Offset = "0x212B4D0", VA = "0x18212C4D0")]
	private void GKKKBBHMGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x212C7E0", Offset = "0x212B7E0", VA = "0x18212C7E0")]
	public void OBGHJDFCPGJ(long IIKHCGCAMCH, long HCLBMOKINEP, [Optional] long? INEHMKECLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x212C430", Offset = "0x212B430", VA = "0x18212C430")]
	public void FLHFIBHNEFA(long INEHMKECLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x212CFB0", Offset = "0x212BFB0", VA = "0x18212CFB0")]
	public void PCLABKELBHM(string HIBJDJEBCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x212CC30", Offset = "0x212BC30", VA = "0x18212CC30")]
	public void OKKFNFFOPAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal sealed class HDGABKIDFJA : NFDNOKDBJMA
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class MPLBHAENLHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MPLBHAENLHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x3D6D130", Offset = "0x3D6C130", VA = "0x183D6D130")]
		internal object AMPEBIDKAFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class JMAICJILDKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public HDGABKIDFJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private AMEDHPDPDLP <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private CKLDLAEHLEJ <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JMAICJILDKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x3D68190", Offset = "0x3D67190", VA = "0x183D68190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class EGOOIHODJLL : IAsyncStateMachine
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
		public HDGABKIDFJA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EGOOIHODJLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x3D62500", Offset = "0x3D61500", VA = "0x183D62500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private sealed class FDFAPFIOKNP : IAsyncStateMachine
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
		public HDGABKIDFJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		private FHNAMDEGIOK <loadInfo>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private BNENJKMIJMI <subRoomSaveData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private BNENJKMIJMI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private TaskAwaiter<BNENJKMIJMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FDFAPFIOKNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x3D63420", Offset = "0x3D62420", VA = "0x183D63420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class DLMMJFLECAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public AMEDHPDPDLP presence;

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public DLMMJFLECAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x3C82DE0", Offset = "0x3C81DE0", VA = "0x183C82DE0")]
		internal object LJACLBGKEDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006FA")]
	private static readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.Token(Token = "0x40006FB")]
	private static readonly FACALIAHOGE NCPPCAECOBG;

	[Cpp2IlInjected.Token(Token = "0x40006FC")]
	private static readonly FACALIAHOGE NKCILBPFPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	private readonly FHNAMDEGIOK HEGDHLMBLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	private readonly IACNHFFDGGB DFHJKCNLBCD;

	[Cpp2IlInjected.Token(Token = "0x40006FF")]
	private const bool PNPKIFEJKIB = false;

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x2138850", Offset = "0x2137850", VA = "0x182138850")]
	public HDGABKIDFJA(FHNAMDEGIOK HEGDHLMBLBL, IACNHFFDGGB DFHJKCNLBCD, Guid KPAGBCDJFAA, JDNEJLBOMFE PODNILAEFJM, IKDJAENEOIK LGOKDDEFMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x21385A0", Offset = "0x21375A0", VA = "0x1821385A0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JMAICJILDKK))]
	protected override Task OMMOLOGAHOL(DEGFCGHLJFD OPAIPEGNAFH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x21382E0", Offset = "0x21372E0", VA = "0x1821382E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EGOOIHODJLL))]
	protected Task KNDNGIGOPCM(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x2138430", Offset = "0x2137430", VA = "0x182138430")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FDFAPFIOKNP))]
	private Task<byte> ODEFEGNABED(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x2137F90", Offset = "0x2136F90", VA = "0x182137F90")]
	private AMEDHPDPDLP EBPBLLNLIHO()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal struct CCOPBMIIAHA
{
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class OPFLILLCFFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public JDNEJLBOMFE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public MLICCGFKPBG data;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OPFLILLCFFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x28B93A0", Offset = "0x28B83A0", VA = "0x1828B93A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x2124E20", Offset = "0x2123E20", VA = "0x182124E20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OPFLILLCFFF))]
	public static Task ICIKLLEKAKC(JDNEJLBOMFE PODNILAEFJM, MLICCGFKPBG HCKNMLENIIG, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
internal struct LAJPIFJJNEK
{
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class KJPMCDHDHNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public LAJPIFJJNEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private EJPMCCMHJJD <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__2;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KJPMCDHDHNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D691E0", Offset = "0x3D681E0", VA = "0x183D691E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class EMIGDMCPCKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EMIGDMCPCKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D633D0", Offset = "0x3D623D0", VA = "0x183D633D0")]
		internal object HKKHAKLJKMA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class KAHEAKGFPFD : IAsyncStateMachine
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
		public LAJPIFJJNEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private EMIGDMCPCKB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		private ECHDHFAHHDM <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KAHEAKGFPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x3D687C0", Offset = "0x3D677C0", VA = "0x183D687C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	private EJPMCCMHJJD DGHFLAFNKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	private GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private bool AGEGKGGGJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private MLICCGFKPBG HCKNMLENIIG;

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x2140BB0", Offset = "0x213FBB0", VA = "0x182140BB0")]
	public static Task<Scene> EIJLEKFHOMN(JDNEJLBOMFE PODNILAEFJM, EJPMCCMHJJD JMKGNGFIOPG, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x2140990", Offset = "0x213F990", VA = "0x182140990")]
	public static Task<Scene> CPJHLGCPFLH(JDNEJLBOMFE PODNILAEFJM, MLICCGFKPBG HCKNMLENIIG, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x2140C60", Offset = "0x213FC60", VA = "0x182140C60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KJPMCDHDHNB))]
	private Task<Scene> ICIKLLEKAKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x2140C30", Offset = "0x213FC30", VA = "0x182140C30")]
	private bool GBCOMDOJDLI(MLICCGFKPBG HCKNMLENIIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x2140DC0", Offset = "0x213FDC0", VA = "0x182140DC0")]
	private void OCODKDNOGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x2140A30", Offset = "0x213FA30", VA = "0x182140A30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KAHEAKGFPFD))]
	private Task<Scene> DOKABLBKLJJ(string PBKPNMBFKAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
public abstract class IIKJILOCJEO<T> where T : IIKJILOCJEO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	internal readonly JDNEJLBOMFE KHGAEHABKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	private int? IFLDIMAKIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073E")]
	protected readonly Guid FBALPGIFIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073F")]
	protected readonly ONJJHJCBMFM CNLKLEPPLGJ;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	protected T KINJLNOLIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x244CBE0", Offset = "0x244BBE0", VA = "0x18244CBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x244CCD0", Offset = "0x244BCD0", VA = "0x18244CCD0")]
	internal IIKJILOCJEO(JDNEJLBOMFE CDLDGFAPMEH, ONJJHJCBMFM LAJCEOKMOIF, [Optional] Guid? KPAGBCDJFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x244CAF0", Offset = "0x244BAF0", VA = "0x18244CAF0")]
	private HAAIMGEOILO JCKGBABIBHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "4")]
	protected virtual void IHJLGBMLMAH(HAAIMGEOILO FANKIHBOOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x244CC40", Offset = "0x244BC40", VA = "0x18244CC40")]
	public T PPIFAJPHABH(JMNGDDABPMO GDEGDBOPGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x244CA70", Offset = "0x244BA70", VA = "0x18244CA70")]
	public T IJCHFFINDIL(int CLHCBCNMINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x244C970", Offset = "0x244B970", VA = "0x18244C970", Slot = "5")]
	public virtual Task<IPDKHLDPLEM> HEKLGOEBMEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public class ONBNMFLMCNF : IIKJILOCJEO<ONBNMFLMCNF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	private FHNAMDEGIOK KPMKPNDNMBB;

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x28B8540", Offset = "0x28B7540", VA = "0x1828B8540")]
	internal ONBNMFLMCNF(JDNEJLBOMFE CDLDGFAPMEH, ONJJHJCBMFM LAJCEOKMOIF, [Optional] Guid? KPAGBCDJFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x28B8450", Offset = "0x28B7450", VA = "0x1828B8450")]
	public ONBNMFLMCNF HANPNPCMFGK(FHNAMDEGIOK KPMKPNDNMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x28B8470", Offset = "0x28B7470", VA = "0x1828B8470", Slot = "4")]
	protected override void IHJLGBMLMAH(HAAIMGEOILO FANKIHBOOPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public class PFKCHGGNLIB : IIKJILOCJEO<PFKCHGGNLIB>
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	internal enum MPOIFMGGKLF
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
	private sealed class MBKOEKLOLPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public AsyncTaskMethodBuilder<IPDKHLDPLEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public PFKCHGGNLIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private IPDKHLDPLEM <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private TaskAwaiter<IPDKHLDPLEM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MBKOEKLOLPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x5424C20", Offset = "0x5423C20", VA = "0x185424C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000741")]
	private MPOIFMGGKLF IEBJGBEJNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000742")]
	private string BKIJLBGIBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	private GHFIGJILBPN KPMKPNDNMBB;

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x28B9B80", Offset = "0x28B8B80", VA = "0x1828B9B80")]
	internal PFKCHGGNLIB(JDNEJLBOMFE CDLDGFAPMEH, ONJJHJCBMFM LAJCEOKMOIF, [Optional] Guid? KPAGBCDJFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x28B9820", Offset = "0x28B8820", VA = "0x1828B9820")]
	public PFKCHGGNLIB GFJANDKDHLI(string MELMAIMGFMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x28B97C0", Offset = "0x28B87C0", VA = "0x1828B97C0")]
	public PFKCHGGNLIB DOGAFOIBADN(bool PFLBFAFIDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x28B9B10", Offset = "0x28B8B10", VA = "0x1828B9B10")]
	public PFKCHGGNLIB JMCNJNNLMEG(string JAGGOBHOHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x28B9790", Offset = "0x28B8790", VA = "0x1828B9790")]
	public PFKCHGGNLIB AEDJGMEJEAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x28B97F0", Offset = "0x28B87F0", VA = "0x1828B97F0")]
	public PFKCHGGNLIB EFBCIJDOFIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x28B99A0", Offset = "0x28B89A0", VA = "0x1828B99A0", Slot = "4")]
	protected override void IHJLGBMLMAH(HAAIMGEOILO FANKIHBOOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x28B9850", Offset = "0x28B8850", VA = "0x1828B9850", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MBKOEKLOLPK))]
	public override Task<IPDKHLDPLEM> HEKLGOEBMEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x28B9B40", Offset = "0x28B8B40", VA = "0x1828B9B40")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<IPDKHLDPLEM> KLAPEILGBGI()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct FMPJPJHECEH
{
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class FDFIIGKBIJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public DFBHMCCJCBD.KJONFBCKMEH instantiations;

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FDFIIGKBIJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C83480", Offset = "0x3C82480", VA = "0x183C83480")]
		internal object LDCKACKJOBF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class EGGCOCBKBNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EGGCOCBKBNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x3C832B0", Offset = "0x3C822B0", VA = "0x183C832B0")]
		internal object PAIFEHGAJLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x21318E0", Offset = "0x21308E0", VA = "0x1821318E0")]
	public static void ICIKLLEKAKC(NFDNOKDBJMA IBOEOPFBKMK, MLICCGFKPBG HCKNMLENIIG, DFBHMCCJCBD.KJONFBCKMEH JPEJCOLPFBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal struct DFBHMCCJCBD
{
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	public struct KJONFBCKMEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public List<GLEFCHMIPDK> MPDHPBNGPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public List<EHDNHMEBPAJ> LHJHCDANGFI;

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xB2E3C0", Offset = "0xB2D3C0", VA = "0x180B2E3C0")]
		public KJONFBCKMEH(List<GLEFCHMIPDK> MPDHPBNGPJG, List<EHDNHMEBPAJ> LHJHCDANGFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class MBDJAHNNNJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public IEnumerable<GLEFCHMIPDK> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MBDJAHNNNJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F100", Offset = "0x3C8E100", VA = "0x183C8F100")]
		internal object AJHJJJMLOGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private MLICCGFKPBG HCKNMLENIIG;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private KOGEPCGCONJ FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x212BA20", Offset = "0x212AA20", VA = "0x18212BA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x212C280", Offset = "0x212B280", VA = "0x18212C280")]
	public static KJONFBCKMEH ICIKLLEKAKC(JDNEJLBOMFE PODNILAEFJM, MLICCGFKPBG HCKNMLENIIG)
	{
		return default(KJONFBCKMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x212BFE0", Offset = "0x212AFE0", VA = "0x18212BFE0")]
	private KJONFBCKMEH ICIKLLEKAKC()
	{
		return default(KJONFBCKMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x212BA70", Offset = "0x212AA70", VA = "0x18212BA70")]
	private KJONFBCKMEH HCKJDKKDECE(HJBOCBIPMIO IIOBMIAKFHM, DLDBICONFJM KFNGFNKFIAG)
	{
		return default(KJONFBCKMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x212B840", Offset = "0x212A840", VA = "0x18212B840")]
	private bool DJNPNDLPBPI(IEnumerable<GLEFCHMIPDK> MPDHPBNGPJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct LPPEOCANCCP
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class GJBPEOEGJGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public LPPEOCANCCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GJBPEOEGJGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x3D64A50", Offset = "0x3D63A50", VA = "0x183D64A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class GOHBLOCBLPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GOHBLOCBLPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x3D651A0", Offset = "0x3D641A0", VA = "0x183D651A0")]
		internal object HKKHAKLJKMA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class LDCNNPJCMDH : IAsyncStateMachine
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
		public LPPEOCANCCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private GOHBLOCBLPJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private ECHDHFAHHDM <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LDCNNPJCMDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x3D69710", Offset = "0x3D68710", VA = "0x183D69710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000756")]
	private bool IMDLCAAAPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000757")]
	private GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000758")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000759")]
	private CancellationToken AOAEIGNDKPI;

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x28ADCD0", Offset = "0x28ACCD0", VA = "0x1828ADCD0")]
	public static Task AFDLNGLNPML(JDNEJLBOMFE PODNILAEFJM, bool IMDLCAAAPLM, GLHOFFEBKJL<string>.OADOKMKENLA IMDANOAGPHH, CancellationToken OFDJOIJAIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x28ADEB0", Offset = "0x28ACEB0", VA = "0x1828ADEB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GJBPEOEGJGF))]
	private Task ICIKLLEKAKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x28ADD40", Offset = "0x28ACD40", VA = "0x1828ADD40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LDCNNPJCMDH))]
	private Task DOKABLBKLJJ(bool IKJLNNNBEMG, string PBKPNMBFKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x84F1E0", Offset = "0x84E1E0", VA = "0x18084F1E0")]
	private bool PEOIAHGCAOE(bool IMDLCAAAPLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct FOBHBCFFLBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400076E")]
	public readonly HFCNBIIEHLN DJAJOEFBOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400076F")]
	public readonly BHKIGNODGGN GEDMENHCEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000770")]
	public readonly string KHCIFCBONLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000771")]
	public readonly LMFNHKGJLBN KKOHNCFJGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000772")]
	public readonly LMFNHKGJLBN IPILOODINKM;

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x2131EA0", Offset = "0x2130EA0", VA = "0x182131EA0")]
	public FOBHBCFFLBJ(HFCNBIIEHLN DJAJOEFBOKM, BHKIGNODGGN GEDMENHCEAJ, string KHCIFCBONLA, LMFNHKGJLBN KKOHNCFJGIK, LMFNHKGJLBN IPILOODINKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
internal sealed class NJKPLCJFCHE : JDEANEJJHEC
{
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class ACBPEHGJPKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public NJKPLCJFCHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private OPAPHGBBLJD <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		private CKLDLAEHLEJ <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public ACBPEHGJPKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x541EB30", Offset = "0x541DB30", VA = "0x18541EB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000773")]
	private readonly FHNAMDEGIOK FMILGLMEIHI;

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x28B6130", Offset = "0x28B5130", VA = "0x1828B6130")]
	public NJKPLCJFCHE(Guid KPAGBCDJFAA, JDNEJLBOMFE PODNILAEFJM, FHNAMDEGIOK FMILGLMEIHI, IKDJAENEOIK LGOKDDEFMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x28B5F90", Offset = "0x28B4F90", VA = "0x1828B5F90", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ACBPEHGJPKH))]
	protected override Task MJCIDGMOBDD(DEGFCGHLJFD OPAIPEGNAFH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018E")]
internal struct CACBJAAJEAG
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x2124670", Offset = "0x2123670", VA = "0x182124670")]
	public static Task ICIKLLEKAKC(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal struct BCHELIEIPHL
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class AIAJLFAGEKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public JDNEJLBOMFE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public MLICCGFKPBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AIAJLFAGEKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x28A6B10", Offset = "0x28A5B10", VA = "0x1828A6B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class FPANCNGHKCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public BCHELIEIPHL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FPANCNGHKCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x28AA970", Offset = "0x28A9970", VA = "0x1828AA970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400077D")]
	private JDNEJLBOMFE PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400077E")]
	private MLICCGFKPBG HCKNMLENIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400077F")]
	private ByteString DINDLJLGDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000780")]
	private DEGFCGHLJFD OPAIPEGNAFH;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private KOGEPCGCONJ FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x21235F0", Offset = "0x21225F0", VA = "0x1821235F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private bool LKIINHAPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x21239D0", Offset = "0x21229D0", VA = "0x1821239D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private bool FEAPMPPPFGP
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2123510", Offset = "0x2122510", VA = "0x182123510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private bool KHMOGOPJKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x21234D0", Offset = "0x21224D0", VA = "0x1821234D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x21237E0", Offset = "0x21227E0", VA = "0x1821237E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AIAJLFAGEKO))]
	public static Task<bool> ICIKLLEKAKC(JDNEJLBOMFE PODNILAEFJM, MLICCGFKPBG HCKNMLENIIG, DEGFCGHLJFD OPAIPEGNAFH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x2123640", Offset = "0x2122640", VA = "0x182123640")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPANCNGHKCC))]
	private Task<bool> ICIKLLEKAKC(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
public static class FPPHDMJOABO
{
	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x2131F20", Offset = "0x2130F20", VA = "0x182131F20")]
	public static LMFNHKGJLBN DPJPEIGABKJ(this CCEIOIEAMHA BCIBKJCBEBB)
	{
		return default(LMFNHKGJLBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x2131FE0", Offset = "0x2130FE0", VA = "0x182131FE0")]
	public static CCEIOIEAMHA JJECCBDOFFH(this LMFNHKGJLBN AHEECIJMHJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal class NLNGELNHAEK : BPGFNOBMGBA
{
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class ELNMBMPFHIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public JGCOJJFPODN.NEEKMBOANOL roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public ELNMBMPFHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x541FC20", Offset = "0x541EC20", VA = "0x18541FC20")]
		internal object PFHOBLGBACC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class LNBPKGKHMKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public AsyncTaskMethodBuilder<(JGCOJJFPODN.NEEKMBOANOL roomDataUpload, JGCOJJFPODN.NEEKMBOANOL subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public IJCJMPMOCHK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public NLNGELNHAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		private ELNMBMPFHIL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		private FAOEADGKIBK <roomMetadata>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		private JGCOJJFPODN.NEEKMBOANOL <subRoomDataUpload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		private JGCOJJFPODN.NEEKMBOANOL <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		private JGCOJJFPODN.NEEKMBOANOL <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		private TaskAwaiter<JGCOJJFPODN.NEEKMBOANOL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LNBPKGKHMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x5424360", Offset = "0x5423360", VA = "0x185424360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class FABBGNKBELA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public AsyncTaskMethodBuilder<AOMNJPFLLBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public GHFIGJILBPN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public IJCJMPMOCHK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		public NLNGELNHAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private JGCOJJFPODN.NEEKMBOANOL <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		private JGCOJJFPODN.NEEKMBOANOL <subRoomDataUpload>5__2;

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
		private PLKDEJCBHIG <request>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		private AOMNJPFLLBL <response>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		private (JGCOJJFPODN.NEEKMBOANOL roomDataUpload, JGCOJJFPODN.NEEKMBOANOL subRoomDataUpload) <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		private (JGCOJJFPODN.NEEKMBOANOL roomDataUpload, JGCOJJFPODN.NEEKMBOANOL subRoomDataUpload) <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		private AOMNJPFLLBL <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		private TaskAwaiter<(JGCOJJFPODN.NEEKMBOANOL roomDataUpload, JGCOJJFPODN.NEEKMBOANOL subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		private TaskAwaiter<AOMNJPFLLBL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FABBGNKBELA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x541FC70", Offset = "0x541EC70", VA = "0x18541FC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class NEJPPPDNKJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public AsyncTaskMethodBuilder<AOCKGLNEMOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public IJCJMPMOCHK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public NLNGELNHAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		private JGCOJJFPODN.NEEKMBOANOL <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		private JGCOJJFPODN.NEEKMBOANOL <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		private AOCKGLNEMOK <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		private (JGCOJJFPODN.NEEKMBOANOL roomDataUpload, JGCOJJFPODN.NEEKMBOANOL subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		private (JGCOJJFPODN.NEEKMBOANOL roomDataUpload, JGCOJJFPODN.NEEKMBOANOL subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private AOCKGLNEMOK <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		private TaskAwaiter<(JGCOJJFPODN.NEEKMBOANOL roomDataUpload, JGCOJJFPODN.NEEKMBOANOL subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		private TaskAwaiter<AOCKGLNEMOK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NEJPPPDNKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x5425A70", Offset = "0x5424A70", VA = "0x185425A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class KHFIMFPAGBM
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D5")]
			public AsyncTaskMethodBuilder<HAAIMGEOILO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007D6")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007D7")]
			public KHFIMFPAGBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			private HAAIMGEOILO <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			private RepeatedField<EHDNHMEBPAJ> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4A80", Offset = "0x6D3E80")]
			private IEnumerable<EHDNHMEBPAJ> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			private AOCKGLNEMOK <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			private AOCKGLNEMOK <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007DF")]
			private AOMNJPFLLBL <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007E0")]
			private AOMNJPFLLBL <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007E1")]
			private HAAIMGEOILO <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007E2")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007E3")]
			private TaskAwaiter<AOCKGLNEMOK> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40007E4")]
			private TaskAwaiter<AOMNJPFLLBL> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40007E5")]
			private TaskAwaiter<HAAIMGEOILO> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x542A570", Offset = "0x5429570", VA = "0x18542A570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public NLNGELNHAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public IJCJMPMOCHK roomSerializedData;

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
		public GHFIGJILBPN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public NPBBNMNNFIK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D49B0", Offset = "0x6D3DB0")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KHFIMFPAGBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x5423B60", Offset = "0x5422B60", VA = "0x185423B60")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<HAAIMGEOILO> GBBNALDKLMA(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class HOGLPHHLIOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public AsyncTaskMethodBuilder<HAAIMGEOILO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public GHFIGJILBPN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		public IJCJMPMOCHK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public NPBBNMNNFIK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4AE0", Offset = "0x6D3EE0")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public NLNGELNHAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private KHFIMFPAGBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private HAAIMGEOILO <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		private TaskAwaiter<HAAIMGEOILO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HOGLPHHLIOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x54215C0", Offset = "0x54205C0", VA = "0x1854215C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000794")]
	private static readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.Token(Token = "0x4000795")]
	private static readonly FACALIAHOGE NCPPCAECOBG;

	[Cpp2IlInjected.Token(Token = "0x4000796")]
	private const float LNFFIDBLLDH = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000797")]
	private readonly AMCKMBNLFMO PMJOENFPEHF;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private JDNEJLBOMFE FKLDBIJEFGA
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2127580", Offset = "0x2126580", VA = "0x182127580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x28B6AB0", Offset = "0x28B5AB0", VA = "0x1828B6AB0")]
	public NLNGELNHAEK(DEGFCGHLJFD OPAIPEGNAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x28B6820", Offset = "0x28B5820", VA = "0x1828B6820")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNBPKGKHMKC))]
	private Task<(JGCOJJFPODN.NEEKMBOANOL, JGCOJJFPODN.NEEKMBOANOL)> NONPAMGBHFJ(IJCJMPMOCHK JFEDBHBIIIC, long IIKHCGCAMCH, long EMFFAEIKHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x28B61E0", Offset = "0x28B51E0", VA = "0x1828B61E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FABBGNKBELA))]
	public Task<AOMNJPFLLBL> DOBNFGMNAFE(int AENEABEPOLE, [CanBeNull] GHFIGJILBPN OADHBHHMKBL, IJCJMPMOCHK JFEDBHBIIIC, long IIKHCGCAMCH, long EMFFAEIKHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x28B6620", Offset = "0x28B5620", VA = "0x1828B6620")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NEJPPPDNKJM))]
	private Task<AOCKGLNEMOK> NAPBMHALGCC(string DEDIJINCEFD, int AENEABEPOLE, IJCJMPMOCHK JFEDBHBIIIC, long IIKHCGCAMCH, long EMFFAEIKHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x28B63D0", Offset = "0x28B53D0", VA = "0x1828B63D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HOGLPHHLIOL))]
	public Task<HAAIMGEOILO> FEIAKGBDCCP(int AENEABEPOLE, GHFIGJILBPN? OADHBHHMKBL, IJCJMPMOCHK JFEDBHBIIIC, long IIKHCGCAMCH, long EMFFAEIKHBM, NPBBNMNNFIK NNOKELLFGPG, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal class JHIFANIMGMO : JDEANEJJHEC
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class IOBHIBOKECB
	{
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			public AsyncTaskMethodBuilder<HAAIMGEOILO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			public IOBHIBOKECB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000804")]
			private IJCJMPMOCHK <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000805")]
			private HAAIMGEOILO <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000806")]
			private IJCJMPMOCHK <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			private HAAIMGEOILO <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			private TaskAwaiter<IJCJMPMOCHK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000809")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFD40", Offset = "0x6CF140")]
			private TaskAwaiter<HAAIMGEOILO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x542A110", Offset = "0x5429110", VA = "0x18542A110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		public JHIFANIMGMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		public CMEINEGPICM serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		public OANGKBOCJHG roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		public NLNGELNHAEK uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		public NPBBNMNNFIK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IOBHIBOKECB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x3D67420", Offset = "0x3D66420", VA = "0x183D67420")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<HAAIMGEOILO> FLNCCPOHPLM(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private sealed class OLCLLCHLFFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400080B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400080C")]
		public DEGFCGHLJFD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400080D")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400080E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400080F")]
		public JHIFANIMGMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000810")]
		private IOBHIBOKECB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		private OPAPHGBBLJD <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private BNENJKMIJMI <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		private CKLDLAEHLEJ <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private HAAIMGEOILO <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		private bool <omEnabledChanged>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private HAAIMGEOILO <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private Exception <ex>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private bool <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		private TaskAwaiter<HAAIMGEOILO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OLCLLCHLFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F490", Offset = "0x3D6E490", VA = "0x183D6F490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class OAFFCGCMPMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		public FHNAMDEGIOK loadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		public JHIFANIMGMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private BNENJKMIJMI <subRoomSaveData>5__1;

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
		private BNENJKMIJMI <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		private TaskAwaiter<BNENJKMIJMI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OAFFCGCMPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DE00", Offset = "0x3D6CE00", VA = "0x183D6DE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40007F4")]
	private static readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.Token(Token = "0x40007F5")]
	private static readonly FACALIAHOGE NCPPCAECOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007F6")]
	private readonly int AENEABEPOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007F7")]
	[CanBeNull]
	private readonly GHFIGJILBPN OADHBHHMKBL;

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x213FB60", Offset = "0x213EB60", VA = "0x18213FB60")]
	public JHIFANIMGMO(Guid KPAGBCDJFAA, JDNEJLBOMFE PODNILAEFJM, int AENEABEPOLE, GHFIGJILBPN OADHBHHMKBL, IKDJAENEOIK LGOKDDEFMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x213F760", Offset = "0x213E760", VA = "0x18213F760", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OLCLLCHLFFL))]
	protected override Task MJCIDGMOBDD(DEGFCGHLJFD OPAIPEGNAFH, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x213F900", Offset = "0x213E900", VA = "0x18213F900")]
	private void MNJDPMIHDOO(bool NMIBIJFPDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x213F2D0", Offset = "0x213E2D0", VA = "0x18213F2D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OAFFCGCMPMM))]
	protected Task<bool> BIGMKOOEOAN(FHNAMDEGIOK JKJGMNFBEKM, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x213F490", Offset = "0x213E490", VA = "0x18213F490")]
	private void KNFHKJPBDPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x213F5C0", Offset = "0x213E5C0", VA = "0x18213F5C0")]
	private void LILKFEJNHKH(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH, OPAPHGBBLJD IKJNAMJACKC)
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
			public CDPHGAFOIMM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400082F")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000830")]
			public CDPHGAFOIMM HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private static CDPHGAFOIMM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400082D")]
		private Dictionary<CDPHGAFOIMM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x28BF040", Offset = "0x28BE040", VA = "0x1828BF040")]
		public bool LFGPJKJPMID(CDPHGAFOIMM FLOPKLHBFLA, out ResultConfig MNBJEIBNFOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x28BEF30", Offset = "0x28BDF30", VA = "0x1828BEF30")]
		public ResultConfig FBOGKPOIHOO(CDPHGAFOIMM LLGBBMDFDOO, [Optional] HashSet<CDPHGAFOIMM> PEIAKFJKKDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x28BF620", Offset = "0x28BE620", VA = "0x1828BF620", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x28BF0B0", Offset = "0x28BE0B0", VA = "0x1828BF0B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x9A4ED0", Offset = "0x9A3ED0", VA = "0x1809A4ED0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public class ANOOGLOIHBD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x2122910", Offset = "0x2121910", VA = "0x182122910")]
	public ANOOGLOIHBD(string FANKIHBOOPE, Exception LBCOELDFNJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
public class KCDLBGNNOFD
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	private sealed class PPEKGGMKJFO : GNLALEFILNM, IEquatable<GNLALEFILNM>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A6")]
		[CompilerGenerated]
		private sealed class GHAANCFOIFP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000840")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000841")]
			public AsyncTaskMethodBuilder<IPDKHLDPLEM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000842")]
			public PPEKGGMKJFO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000843")]
			private DJAJPIOICAP <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000844")]
			private HFCNBIIEHLN <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000845")]
			private FHNAMDEGIOK <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000846")]
			private HFCNBIIEHLN <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000847")]
			private IPDKHLDPLEM <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000848")]
			private TaskAwaiter<HFCNBIIEHLN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000849")]
			private TaskAwaiter<IPDKHLDPLEM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public GHAANCFOIFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x54206E0", Offset = "0x541F6E0", VA = "0x1854206E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400083D")]
		private readonly BNENJKMIJMI JMKBONJLEMG;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int MAHOPMGOCFM
		{
			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x999690", Offset = "0x998690", VA = "0x180999690", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public EGHNJFCJNHG PJFBHIBACJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		private DateTime HKEHCNMHGIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x187E3E0", Offset = "0x187D3E0", VA = "0x18187E3E0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public FBCCPDGNONB? DHMCEBEMFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x1304DA0", Offset = "0x1303DA0", VA = "0x181304DA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public LFBEAACDAHN? EICFKJOAOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x3D71920", Offset = "0x3D70920", VA = "0x183D71920", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public JFKCKIEADED AMJFIBLOOMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x842FC0", Offset = "0x841FC0", VA = "0x180842FC0", Slot = "10")]
			get
			{
				return default(JFKCKIEADED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x3D71940", Offset = "0x3D70940", VA = "0x183D71940", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(GHAANCFOIFP))]
		public Task<IPDKHLDPLEM> EPHDOAPOCMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x3D71C60", Offset = "0x3D70C60", VA = "0x183D71C60")]
		public PPEKGGMKJFO(int JCKMOAGGPKG, EGHNJFCJNHG MGLEBFCGAKD, BNENJKMIJMI JMKBONJLEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x3D71A90", Offset = "0x3D70A90", VA = "0x183D71A90", Slot = "11")]
		public bool Equals(GNLALEFILNM JONIFABKCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x3D71B30", Offset = "0x3D70B30", VA = "0x183D71B30", Slot = "0")]
		public override bool Equals(object DCGPCJKHCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x3D718D0", Offset = "0x3D708D0", VA = "0x183D718D0")]
		private bool AKFGNGMHEHI(PPEKGGMKJFO JONIFABKCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x3D71BD0", Offset = "0x3D70BD0", VA = "0x183D71BD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	private sealed class BHGOIPGFHHG : GNLALEFILNM, IEquatable<GNLALEFILNM>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A8")]
		[CompilerGenerated]
		private sealed class FIANBFBNLLP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400084D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400084E")]
			public AsyncTaskMethodBuilder<IPDKHLDPLEM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400084F")]
			public BHGOIPGFHHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000850")]
			private IPDKHLDPLEM <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000851")]
			private TaskAwaiter<IPDKHLDPLEM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public FIANBFBNLLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x5420450", Offset = "0x541F450", VA = "0x185420450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400084A")]
		private readonly NGDFPBDGPNO NFAIEDAAIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400084B")]
		private readonly FBCCPDGNONB JPOOPABBBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400084C")]
		private readonly LFBEAACDAHN PMPCPMALKIN;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public int MAHOPMGOCFM
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x3D5FE30", Offset = "0x3D5EE30", VA = "0x183D5FE30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public EGHNJFCJNHG PJFBHIBACJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x3D5FD00", Offset = "0x3D5ED00", VA = "0x183D5FD00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		private DateTime HKEHCNMHGIA
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x3D5FA10", Offset = "0x3D5EA10", VA = "0x183D5FA10", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public FBCCPDGNONB? DHMCEBEMFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x3D5FDE0", Offset = "0x3D5EDE0", VA = "0x183D5FDE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public LFBEAACDAHN? EICFKJOAOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x3D5F9C0", Offset = "0x3D5E9C0", VA = "0x183D5F9C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public JFKCKIEADED AMJFIBLOOMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x843410", Offset = "0x842410", VA = "0x180843410", Slot = "10")]
			get
			{
				return default(JFKCKIEADED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x3864E30", Offset = "0x3863E30", VA = "0x183864E30")]
		public BHGOIPGFHHG(NGDFPBDGPNO LADKCLEPKDB, FBCCPDGNONB DCKFLDBFLBD, LFBEAACDAHN CMJLDCJHMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x3D5FA60", Offset = "0x3D5EA60", VA = "0x183D5FA60", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(FIANBFBNLLP))]
		public Task<IPDKHLDPLEM> EPHDOAPOCMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x3D5FBB0", Offset = "0x3D5EBB0", VA = "0x183D5FBB0", Slot = "11")]
		public bool Equals(GNLALEFILNM JONIFABKCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x3D5FC50", Offset = "0x3D5EC50", VA = "0x183D5FC50", Slot = "0")]
		public override bool Equals(object DCGPCJKHCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F960", Offset = "0x3D5E960", VA = "0x183D5F960")]
		private bool AKFGNGMHEHI(BHGOIPGFHHG JONIFABKCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x3D5FD50", Offset = "0x3D5ED50", VA = "0x183D5FD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	private sealed class IFACBAPNMHE : GNLALEFILNM, IEquatable<GNLALEFILNM>
	{
		[Cpp2IlInjected.Token(Token = "0x20001AA")]
		[CompilerGenerated]
		private sealed class LKLIEOIJMMP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000855")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000856")]
			public AsyncTaskMethodBuilder<IPDKHLDPLEM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000857")]
			public IFACBAPNMHE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000858")]
			private IPDKHLDPLEM <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000859")]
			private TaskAwaiter<IPDKHLDPLEM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public LKLIEOIJMMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x5424160", Offset = "0x5423160", VA = "0x185424160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000852")]
		private readonly EGHNJFCJNHG MOHDBLDMPJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000853")]
		private readonly FBCCPDGNONB JPOOPABBBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000854")]
		private readonly LFBEAACDAHN PMPCPMALKIN;

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public int MAHOPMGOCFM
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x3D66FC0", Offset = "0x3D65FC0", VA = "0x183D66FC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		[NotNull]
		public EGHNJFCJNHG PJFBHIBACJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		private DateTime HKEHCNMHGIA
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x84F960", Offset = "0x84E960", VA = "0x18084F960", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public FBCCPDGNONB? DHMCEBEMFPK
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x3D66F70", Offset = "0x3D65F70", VA = "0x183D66F70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public LFBEAACDAHN? EICFKJOAOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x3D66A90", Offset = "0x3D65A90", VA = "0x183D66A90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public JFKCKIEADED AMJFIBLOOMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x84F960", Offset = "0x84E960", VA = "0x18084F960", Slot = "10")]
			get
			{
				return default(JFKCKIEADED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x3864E30", Offset = "0x3863E30", VA = "0x183864E30")]
		public IFACBAPNMHE(EGHNJFCJNHG MGLEBFCGAKD, FBCCPDGNONB DCKFLDBFLBD, LFBEAACDAHN CMJLDCJHMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x3D66AE0", Offset = "0x3D65AE0", VA = "0x183D66AE0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(LKLIEOIJMMP))]
		public Task<IPDKHLDPLEM> EPHDOAPOCMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x3D66C30", Offset = "0x3D65C30", VA = "0x183D66C30", Slot = "11")]
		public bool Equals(GNLALEFILNM JONIFABKCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x3D66D70", Offset = "0x3D65D70", VA = "0x183D66D70", Slot = "0")]
		public override bool Equals(object DCGPCJKHCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x3D66EC0", Offset = "0x3D65EC0", VA = "0x183D66EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x3D66970", Offset = "0x3D65970", VA = "0x183D66970")]
		private bool AKFGNGMHEHI(IFACBAPNMHE JONIFABKCAI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private sealed class FLBPBBEGEOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000860")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000861")]
		public AsyncTaskMethodBuilder<IList<GNLALEFILNM>> <>t__builder;

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
		public KCDLBGNNOFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000866")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000867")]
		private IReadOnlyList<BNENJKMIJMI> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000868")]
		private IReadOnlyList<(int accountId, EGHNJFCJNHG account, BNENJKMIJMI roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000869")]
		private List<GNLALEFILNM> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400086A")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400086B")]
		private NGDFPBDGPNO <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400086C")]
		private IReadOnlyList<BNENJKMIJMI> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400086D")]
		private IReadOnlyList<(int accountId, EGHNJFCJNHG account, BNENJKMIJMI roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400086E")]
		private IEnumerator<(int accountId, EGHNJFCJNHG account, BNENJKMIJMI roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400086F")]
		private (int accountId, EGHNJFCJNHG account, BNENJKMIJMI roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000870")]
		private BHGOIPGFHHG <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000871")]
		private TaskAwaiter<IReadOnlyList<BNENJKMIJMI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000872")]
		private TaskAwaiter<IReadOnlyList<(int accountId, EGHNJFCJNHG account, BNENJKMIJMI roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FLBPBBEGEOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x3D637F0", Offset = "0x3D627F0", VA = "0x183D637F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class CNJFILPPGGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000873")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000874")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, EGHNJFCJNHG account, BNENJKMIJMI roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000875")]
		public IReadOnlyList<BNENJKMIJMI> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000876")]
		public KCDLBGNNOFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000877")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000878")]
		private IReadOnlyList<EGHNJFCJNHG> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000879")]
		private Dictionary<ObscuredInt, EGHNJFCJNHG> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400087A")]
		private List<(int, EGHNJFCJNHG, BNENJKMIJMI)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400087B")]
		private IReadOnlyList<EGHNJFCJNHG> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400087C")]
		private IEnumerator<BNENJKMIJMI> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400087D")]
		private BNENJKMIJMI <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400087E")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400087F")]
		private EGHNJFCJNHG <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000880")]
		private EGHNJFCJNHG <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000881")]
		private TaskAwaiter<IReadOnlyList<EGHNJFCJNHG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CNJFILPPGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x3D61120", Offset = "0x3D60120", VA = "0x183D61120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000839")]
	private readonly OHFDBHOOODG CFKHNBIMGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400083A")]
	private readonly DMCFLNOKOCM BPKNOKFIMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400083B")]
	private readonly MDFGFKODPDB FMPGHGKJADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400083C")]
	private readonly PAMNIPJFFHP<(long, long), IReadOnlyList<BNENJKMIJMI>> OBNONBPBIJA;

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x2140280", Offset = "0x213F280", VA = "0x182140280")]
	[UnityEngine.Scripting.Preserve]
	public KCDLBGNNOFD([KMDNJCFAMOJ(null)] DMCFLNOKOCM CIHABJPDENH, [KMDNJCFAMOJ(null)] MDFGFKODPDB JIHGGPOGAEJ, [KMDNJCFAMOJ(null)] OHFDBHOOODG IPHNNNMDNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x21400E0", Offset = "0x213F0E0", VA = "0x1821400E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FLBPBBEGEOC))]
	public Task<IList<GNLALEFILNM>> OFELIOJDPBK(long IIKHCGCAMCH, long HCLBMOKINEP, bool IAPBFOLJKIM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x213FF40", Offset = "0x213EF40", VA = "0x18213FF40")]
	private bool GMONLAKIOBO(DateTime? BIDIKCLNLJD, long IIKHCGCAMCH, long HCLBMOKINEP, out NGDFPBDGPNO AAHGAPCMDBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x213FDD0", Offset = "0x213EDD0", VA = "0x18213FDD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CNJFILPPGGO))]
	private Task<IReadOnlyList<(int, EGHNJFCJNHG, BNENJKMIJMI)>> AALDAACJBCA(IReadOnlyList<BNENJKMIJMI> OKAIAHDMHHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal class NALJPCKCJAH : DMCFLNOKOCM
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[CompilerGenerated]
	private sealed class LNGMJDEJHBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000882")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000883")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BNENJKMIJMI>> <>t__builder;

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
		public NALJPCKCJAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000888")]
		private GJLKPNHFOGL<BNENJKMIJMI> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000889")]
		private GJLKPNHFOGL<BNENJKMIJMI> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400088A")]
		private TaskAwaiter<GJLKPNHFOGL<BNENJKMIJMI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LNGMJDEJHBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x3D6ADA0", Offset = "0x3D69DA0", VA = "0x183D6ADA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[CompilerGenerated]
	private sealed class CIFBKALJAOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400088B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400088C")]
		public AsyncTaskMethodBuilder<IReadOnlyList<EGHNJFCJNHG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400088D")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400088E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400088F")]
		public NALJPCKCJAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000890")]
		private List<EGHNJFCJNHG> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000891")]
		private TaskAwaiter<List<EGHNJFCJNHG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CIFBKALJAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x3D60D30", Offset = "0x3D5FD30", VA = "0x183D60D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000768")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	[UnityEngine.Scripting.Preserve]
	public NALJPCKCJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000769")]
	[Cpp2IlInjected.Address(RVA = "0x28B4890", Offset = "0x28B3890", VA = "0x1828B4890", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNGMJDEJHBB))]
	public Task<IReadOnlyList<BNENJKMIJMI>> CKKJGAHJIGB(long IIKHCGCAMCH, long EMFFAEIKHBM, [Optional] CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x28B46F0", Offset = "0x28B36F0", VA = "0x1828B46F0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CIFBKALJAOO))]
	public Task<IReadOnlyList<EGHNJFCJNHG>> ACFLIAGBFGJ(IReadOnlyList<int> LFFHJLDLLHD, [Optional] CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public interface DMCFLNOKOCM
{
	[Cpp2IlInjected.Token(Token = "0x6000771")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<BNENJKMIJMI>> CKKJGAHJIGB(long IIKHCGCAMCH, long EMFFAEIKHBM, [Optional] CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000772")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<EGHNJFCJNHG>> ACFLIAGBFGJ(IReadOnlyList<int> LFFHJLDLLHD, [Optional] CancellationToken AOAEIGNDKPI);
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public interface GNLALEFILNM : IEquatable<GNLALEFILNM>
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	int MAHOPMGOCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	[CanBeNull]
	EGHNJFCJNHG PJFBHIBACJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	DateTime NPHIDAANCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	FBCCPDGNONB? DHMCEBEMFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	LFBEAACDAHN? EICFKJOAOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	[CanBeNull]
	JFKCKIEADED AMJFIBLOOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IPDKHLDPLEM> EPHDOAPOCMM();
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public enum JFKCKIEADED
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
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
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
