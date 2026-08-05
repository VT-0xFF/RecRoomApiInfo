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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x36FBC20", Offset = "0x36FAE20", VA = "0x1836FBC20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KPAJKDAICAP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<COOLNBMBOGP> OBIAGPECIKF;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KAJCFGBPPDK(long LNBFDCAEKJF, long GLLEENOIFOJ, FAPAGDCIGJE ACEDMDLCIME, BJINNGNHAFI AGHJKILGDNH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CFMMIDPILBD(long LNBFDCAEKJF, long GLLEENOIFOJ, out COOLNBMBOGP CGJKBLJLHJH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BGLENIICFMC(long LNBFDCAEKJF, long GLLEENOIFOJ, BJINNGNHAFI AGHJKILGDNH, out COOLNBMBOGP CGJKBLJLHJH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMFLJJLDBLA(long LNBFDCAEKJF, long GLLEENOIFOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[UnityEngine.Scripting.Preserve]
internal class IOMODDFAEEJ : JGOBHOBCPFC, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CHIGCGGCLAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public NAKGFMDIFDB roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CHIGCGGCLAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x428D200", Offset = "0x428C400", VA = "0x18428D200")]
		internal object FOEFPIFMAEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KDJNDJNHFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B7F0", Offset = "0x2D2A9F0", VA = "0x182D2B7F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BB10", Offset = "0x2D2AD10", VA = "0x182D2BB10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event FBNDGCEMMGM HOLICIJFIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BBE0", Offset = "0x2D2ADE0", VA = "0x182D2BBE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B500", Offset = "0x2D2A700", VA = "0x182D2B500", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event FBNDGCEMMGM GDMNJEIBGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B750", Offset = "0x2D2A950", VA = "0x182D2B750", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B890", Offset = "0x2D2AA90", VA = "0x182D2B890", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FBNDGCEMMGM IEDOIEKCBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B930", Offset = "0x2D2AB30", VA = "0x182D2B930", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B6B0", Offset = "0x2D2A8B0", VA = "0x182D2B6B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<GJBJJHDBNNK, bool> EBHBHIPIJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B9D0", Offset = "0x2D2ABD0", VA = "0x182D2B9D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BA70", Offset = "0x2D2AC70", VA = "0x182D2BA70", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "19")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B280", Offset = "0x2D2A480", VA = "0x182D2B280", Slot = "14")]
	public void AIDIFMDMBIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2D2BBB0", Offset = "0x2D2ADB0", VA = "0x182D2BBB0", Slot = "15")]
	public void NONDOGJELND(NAKGFMDIFDB GHJIPDLACNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B650", Offset = "0x2D2A850", VA = "0x182D2B650", Slot = "16")]
	public void DFLIKFLHOAI(NAKGFMDIFDB GHJIPDLACNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B680", Offset = "0x2D2A880", VA = "0x182D2B680", Slot = "17")]
	public void GBHALKDGIEH(NAKGFMDIFDB GHJIPDLACNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B5A0", Offset = "0x2D2A7A0", VA = "0x182D2B5A0", Slot = "18")]
	public void DCGOLFBHJHE(GJBJJHDBNNK EEIOBIJNMEC, bool LKCMOCEILKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2D2BC80", Offset = "0x2D2AE80", VA = "0x182D2BC80")]
	private void OGNFCKBDNLK(FBNDGCEMMGM FOJNDMIMLDK, NAKGFMDIFDB GHJIPDLACNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public IOMODDFAEEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface DNEAHMCJOPM : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LIAOPDCMOJN JNDDJJFOCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJCHEKLJHNL();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBAAOPDBNPA();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate NAKMMEJMOAP JBFOEJAMJPP(NBDCAKCJOHF ABACAIJJLIF, APGCGMGDIIP DILEKOOCNPA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface BBMDBLLFADF : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOJCCABHALO EMDLLDPNABD(BLGLLGBBDII FBANNGACLMB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHAOAMJDGIH(Guid HPINIPGLIPD, Task IHNIBFOOPAD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal struct NCFGALNHNEO
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string GCHDHLJCPOE = "v_result";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const string PCGOOHBEFHM = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IDictionary<object, object> NHCCLIMEPFL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LIKFKNKKDJD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xCE73A0", Offset = "0xCE65A0", VA = "0x180CE73A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xD48AD0", Offset = "0xD47CD0", VA = "0x180D48AD0")]
	public NCFGALNHNEO(IDictionary<object, object> NHCCLIMEPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x36FB520", Offset = "0x36FA720", VA = "0x1836FB520")]
	public bool LCPKCBBFGLP(out BLGLLGBBDII CEOMJLPEFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x36FB6D0", Offset = "0x36FA8D0", VA = "0x1836FB6D0")]
	public Guid PJJPHBDJHND()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x36FB410", Offset = "0x36FA610", VA = "0x1836FB410")]
	public NAKMMEJMOAP CJDKNNICOMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x36FB5E0", Offset = "0x36FA7E0", VA = "0x1836FB5E0")]
	public static ExitGames.Client.Photon.Hashtable LNIGJBIDADO(BLGLLGBBDII CEOMJLPEFPB, NAKMMEJMOAP FGPPDHPBHPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DFBDMPCEMAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABCKPIGJNOM(EJAEMFPIIFN.DFCOHNDKEME KCDNGPAAJFF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJDKGLPCIMG(EJAEMFPIIFN.DFCOHNDKEME KCDNGPAAJFF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum HIFPAFEDKAL
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
public abstract class EJAEMFPIIFN : DFBDMPCEMAM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate NAKMMEJMOAP DFCOHNDKEME([NotNull] NBDCAKCJOHF FKIAFEKBNAG);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class GGMBGJOJGEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NBDCAKCJOHF photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GGMBGJOJGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4290CD0", Offset = "0x428FED0", VA = "0x184290CD0")]
		internal NAKMMEJMOAP AKFGPMPLPOI(DFCOHNDKEME v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool MIGKAMNMNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly HashSet<DFCOHNDKEME> KJAKOIHPGOE;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D430", Offset = "0x2D1C630", VA = "0x182D1D430", Slot = "4")]
	public void ABCKPIGJNOM(DFCOHNDKEME KCDNGPAAJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D490", Offset = "0x2D1C690", VA = "0x182D1D490", Slot = "5")]
	public void AJDKGLPCIMG(DFCOHNDKEME KCDNGPAAJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D4F0", Offset = "0x2D1C6F0", VA = "0x182D1D4F0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D540", Offset = "0x2D1C740", VA = "0x182D1D540")]
	protected NAKMMEJMOAP LIAIIAMIEFP(NBDCAKCJOHF KCAAIIKABAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BC20", Offset = "0x2D0AE20", VA = "0x182D0BC20")]
	protected EJAEMFPIIFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DMMHHEOLAHC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class GMDCIHEMDDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KCDJMIOEEPA subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GMDCIHEMDDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x42BE0F0", Offset = "0x42BD2F0", VA = "0x1842BE0F0")]
		internal bool PKBMJNNFJFC(GONBIMCIPLJ s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D18200", Offset = "0x2D17400", VA = "0x182D18200")]
	public static IHKLGONHBKF LNIGJBIDADO(long NIMDKKEKAKL, long HGPBCNPIJHG, string DPPPGPGBEBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D182A0", Offset = "0x2D174A0", VA = "0x182D182A0")]
	public static IHKLGONHBKF LNIGJBIDADO(long NIMDKKEKAKL, long HGPBCNPIJHG, DLJGDNEKCBH JNLAJBEPGHH, long FLFKBNIMKBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D180C0", Offset = "0x2D172C0", VA = "0x182D180C0")]
	public static IHKLGONHBKF LNIGJBIDADO(FELEHJCEPLI HJCHEIJFCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2D17E80", Offset = "0x2D17080", VA = "0x182D17E80")]
	public static IHKLGONHBKF LNIGJBIDADO(ODLKOJAEFAL BFOGMBHGEAN, KCDJMIOEEPA OFAIAHHNFCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D18370", Offset = "0x2D17570", VA = "0x182D18370")]
	public static IHKLGONHBKF PEKLGJMHFJL(this IHKLGONHBKF DGLHFPEOHIM, ODLKOJAEFAL IDLJFPOCLGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2D17CF0", Offset = "0x2D16EF0", VA = "0x182D17CF0")]
	public static IHKLGONHBKF BOJKCGHPEGF(this IHKLGONHBKF DGLHFPEOHIM, KCDJMIOEEPA IGMFMCPBECG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum MKJPILOBGEE
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum GJBJJHDBNNK
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
public struct NAKGFMDIFDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly long NIMDKKEKAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly long HGPBCNPIJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly MKJPILOBGEE JAACLLLIGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[CanBeNull]
	public readonly Exception HOKKOBEEEGI;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x36FAB30", Offset = "0x36F9D30", VA = "0x1836FAB30")]
	public NAKGFMDIFDB(long NIMDKKEKAKL, long HGPBCNPIJHG, MKJPILOBGEE JAACLLLIGMF, [CanBeNull] Exception HOKKOBEEEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x36FAAE0", Offset = "0x36F9CE0", VA = "0x1836FAAE0")]
	public static NAKGFMDIFDB LPMNOAABMGJ(MDCIINLFDMH GNMPDOBAMND, MKJPILOBGEE JAACLLLIGMF, [Optional] Exception HOKKOBEEEGI)
	{
		return default(NAKGFMDIFDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public delegate void FBNDGCEMMGM(NAKGFMDIFDB GHJIPDLACNG);
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface JGOBHOBCPFC : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action KDJNDJNHFHJ;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FBNDGCEMMGM HOLICIJFIJC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FBNDGCEMMGM GDMNJEIBGBM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FBNDGCEMMGM IEDOIEKCBHB;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GJBJJHDBNNK, bool> EBHBHIPIJCH;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AIDIFMDMBIM();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NONDOGJELND(NAKGFMDIFDB GHJIPDLACNG);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DFLIKFLHOAI(NAKGFMDIFDB GHJIPDLACNG);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GBHALKDGIEH(NAKGFMDIFDB GHJIPDLACNG);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DCGOLFBHJHE(GJBJJHDBNNK EEIOBIJNMEC, bool LKCMOCEILKH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[UnityEngine.Scripting.Preserve]
internal class CPHOOBBOGGF : MINMGNDMHLI, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EBEDKOLNNMN : IAsyncStateMachine
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
		public CPHOOBBOGGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private FDMIABHIEGI<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private LNNBCGJEJKM <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EBEDKOLNNMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x42BA870", Offset = "0x42B9A70", VA = "0x1842BA870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KLELFNKDBNP OCHOGPMKPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private JKLCIGBBEGC MFNJCMHILGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private IHCAMGNCBDI IKGLEHGFGJO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2D14280", Offset = "0x2D13480", VA = "0x182D14280", Slot = "6")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2D13F70", Offset = "0x2D13170", VA = "0x182D13F70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2D13FC0", Offset = "0x2D131C0", VA = "0x182D13FC0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EBEDKOLNNMN))]
	public Task GECIBNGMFFF(string KMBFNDAPCGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2D14110", Offset = "0x2D13310", VA = "0x182D14110", Slot = "4")]
	public NAKMMEJMOAP HPDOMJLIBEH(NBDCAKCJOHF ABACAIJJLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2D14170", Offset = "0x2D13370", VA = "0x182D14170")]
	private LNNBCGJEJKM IIAOLKJLFPH(string KMBFNDAPCGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CPHOOBBOGGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface MOGJDODAHJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EMJFJBFFOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OLGDGMHABFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Task PCMBJBDDICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	KIPGPNOONJB NEEHJJMBIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action KDJNDJNHFHJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event FBNDGCEMMGM HOLICIJFIJC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event FBNDGCEMMGM GDMNJEIBGBM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event FBNDGCEMMGM IEDOIEKCBHB;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<GJBJJHDBNNK, bool> EBHBHIPIJCH;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LIIEFGHGIHK();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DGGNNJGLDCH KCJHDKBKHEI();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DHEDDELEOOF GLOECPFIGHD();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<NAKMMEJMOAP> JJDLPJCPIFG(COOLNBMBOGP HJNBJLCLGDH);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task CAHIFJGDIHB(CancellationToken PLEKJLHDOLP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface JKIJBDKIACB : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NAKMMEJMOAP> JJDLPJCPIFG(COOLNBMBOGP CGJKBLJLHJH);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CAHIFJGDIHB(CancellationToken PLEKJLHDOLP);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[RecRoom.NoEngine.Common.Preserve]
internal class CDKGPEMHFKO : HDMCFFBEMAE, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LGDCIDKHHEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public MDCIINLFDMH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public KIPGPNOONJB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CDKGPEMHFKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Task <task>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LGDCIDKHHEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x36F3C40", Offset = "0x36F2E40", VA = "0x1836F3C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MMFDNKPLIOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public MDCIINLFDMH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KIPGPNOONJB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CDKGPEMHFKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private FDMIABHIEGI<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private NLAKPJCOMPN <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private KFPGNDCOJCM <analyticsData>5__5;

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
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MMFDNKPLIOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x36F9B80", Offset = "0x36F8D80", VA = "0x1836F9B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PHEIGOKOBKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Matchmaking.OLBNGFBIDAN result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NOAKBMOBOAL errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PHEIGOKOBKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x42C74A0", Offset = "0x42C66A0", VA = "0x1842C74A0")]
		internal object MPONJIJLAKF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JPIKOHDLNKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Task<IHKLGONHBKF> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JPIKOHDLNKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		internal Task<IHKLGONHBKF> FDEIDFBENEL(FDMIABHIEGI<string>.JOOBNAKNCND _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class APEOEOKADCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public MDCIINLFDMH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public KIPGPNOONJB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NLAKPJCOMPN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CDKGPEMHFKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private OLPMEMOFGMN <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private CancellationTokenRegistration <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private JPIKOHDLNKN <>8__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private NJJJDBEKHBD <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private Task<Matchmaking.NBDPJBOGNGD> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private LFOBIOBIBAB <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private Matchmaking.NBDPJBOGNGD <serverConnectionInfo>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CancellationTokenSource <cameraFadeCts>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private CancellationTokenSource <loadingScreenCts>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <loadingScreenScope>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private Matchmaking.NBDPJBOGNGD <>s__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private CancellationTokenSource <photonJoinedTokenSource>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CancellationToken <photonJoinedToken>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private IHKLGONHBKF <initialRoomLoadPayload>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IHKLGONHBKF <>s__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<Matchmaking.NBDPJBOGNGD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<IHKLGONHBKF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public APEOEOKADCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x36E5B00", Offset = "0x36E4D00", VA = "0x1836E5B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FLFHMPAFPDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CDKGPEMHFKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <disconnectTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private object <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Exception <ex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FLFHMPAFPDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x36EA9E0", Offset = "0x36E9BE0", VA = "0x1836EA9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class LKDIJDCHMPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CDKGPEMHFKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private JLCNCEFHLIA <roomContainer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LKDIJDCHMPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x36F5250", Offset = "0x36F4450", VA = "0x1836F5250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BPJPFJHHLAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<Matchmaking.NBDPJBOGNGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public MDCIINLFDMH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CDKGPEMHFKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Matchmaking.NBDPJBOGNGD <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<Matchmaking.NBDPJBOGNGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BPJPFJHHLAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x36E8DA0", Offset = "0x36E7FA0", VA = "0x1836E8DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class NAMGMBKFGHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public MDCIINLFDMH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Matchmaking.NBDPJBOGNGD serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public NLAKPJCOMPN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CDKGPEMHFKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private OOGNCOGFMCL <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<OOGNCOGFMCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NAMGMBKFGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x42C3B50", Offset = "0x42C2D50", VA = "0x1842C3B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class GIDEMMLBINB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public MDCIINLFDMH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GIDEMMLBINB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KFOEPDFOFLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public GIDEMMLBINB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KFOEPDFOFLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x36EEBD0", Offset = "0x36EDDD0", VA = "0x1836EEBD0")]
		internal object NMEJLIKMIPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x36EEAC0", Offset = "0x36EDCC0", VA = "0x1836EEAC0")]
		internal string LIELMFPILJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KLGCAIBCEKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public MDCIINLFDMH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CDKGPEMHFKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private GIDEMMLBINB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private KFOEPDFOFLI <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KLGCAIBCEKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x36EF5E0", Offset = "0x36EE7E0", VA = "0x1836EF5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class PDBFGDGMBGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public IHKLGONHBKF initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public OLPMEMOFGMN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public MDCIINLFDMH targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public NLAKPJCOMPN joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public CDKGPEMHFKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private NLAKPJCOMPN <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private PMMBBGOOHDG <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PDBFGDGMBGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x42C6E60", Offset = "0x42C6060", VA = "0x1842C6E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class KNCLIMNFILI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public CDKGPEMHFKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private CancellationTokenSource <timeoutTcs>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private CancellationToken <timeoutToken>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KNCLIMNFILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x36F0460", Offset = "0x36EF660", VA = "0x1836F0460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BBLNNJPCIIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public CDKGPEMHFKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <version>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool <canUpdateRoom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private bool <shouldSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6E")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter<NAKMMEJMOAP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BBLNNJPCIIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x36E8600", Offset = "0x36E7800", VA = "0x1836E8600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class LEGKMHCDPKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public MDCIINLFDMH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LEGKMHCDPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x36F1F40", Offset = "0x36F1140", VA = "0x1836F1F40")]
		internal object BFBGCGGCGJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PABMOAPIFBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PABMOAPIFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x42C5E60", Offset = "0x42C5060", VA = "0x1842C5E60")]
		internal void LFGEHGKLFIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class EMDIJLHNBHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public MDCIINLFDMH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EMDIJLHNBHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x36EA220", Offset = "0x36E9420", VA = "0x1836EA220")]
		internal object CLLBIDEOLDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class EHLEHHGIMAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public MDCIINLFDMH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EHLEHHGIMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x36EA120", Offset = "0x36E9320", VA = "0x1836EA120")]
		internal string OALEEMEGPHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly string HAAFGJBKHKJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly string GGOAEMFBEGH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly string GBHAOFPADCF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly Guid PEHGKHHHAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private PHLPMAPMHHI CFKKPPPPOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private AENCAKHMCBK EICMDGFKLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private IPBPMMLOKDP BIHEKONDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private FGKLHHEMEMB JCECDDPGEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private IPDOADDBPPL DCPLGDEFGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private CNOMDHHEFIE PFPAIKIAJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private JGOBHOBCPFC GICHEILONDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private AOCCOOPEIPL MPPAGFGEBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private MPIGEJNPJHM JDJNHODIMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private IDisposable CPFFJOKLIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly NNFJPPGGOPL HHPBIPLOBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly NNFJPPGGOPL EHPMIIIMCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private LFOBIOBIBAB HPCNEMJJKKN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TaskStatus ONKFOHPIPML
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x983E00", Offset = "0x983000", VA = "0x180983E00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x983E20", Offset = "0x983020", VA = "0x180983E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private KOIGEBDLLEK PJNHDMFJAGK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2D10370", Offset = "0x2D0F570", VA = "0x182D10370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2D11BF0", Offset = "0x2D10DF0", VA = "0x182D11BF0", Slot = "6")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2D0ECD0", Offset = "0x2D0DED0", VA = "0x182D0ECD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2D11E10", Offset = "0x2D11010", VA = "0x182D11E10", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LGDCIDKHHEF))]
	public Task OMEEECMIGBD(MDCIINLFDMH OGJNPFMLCHO, KIPGPNOONJB GFEFGABCJFI, CancellationToken NNJAJHKDGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2D11830", Offset = "0x2D10A30", VA = "0x182D11830")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MMFDNKPLIOJ))]
	private Task OFJDDMLGABF(MDCIINLFDMH OGJNPFMLCHO, KIPGPNOONJB GFEFGABCJFI, CancellationToken NNJAJHKDGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2D0FD50", Offset = "0x2D0EF50", VA = "0x182D0FD50")]
	private static void HFCKHKOKFAF(AOCCOOPEIPL MPPAGFGEBCK, MDCIINLFDMH OGJNPFMLCHO, Exception ODBCLHKGDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EF60", Offset = "0x2D0E160", VA = "0x182D0EF60")]
	private static void GAGIMEPFENO(KFPGNDCOJCM HDDJNNOJBAD, Exception ODBCLHKGDHB, [Optional] List<int> FKKODMAJDJO, int GFDOFJMIICG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2D121C0", Offset = "0x2D113C0", VA = "0x182D121C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(APEOEOKADCF))]
	private Task PNNPDJBHDPD(FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, MDCIINLFDMH OGJNPFMLCHO, KIPGPNOONJB GFEFGABCJFI, NLAKPJCOMPN DKEAHNCOFEH, CancellationToken NNJAJHKDGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2D0ED20", Offset = "0x2D0DF20", VA = "0x182D0ED20")]
	private void EDKEIGMEONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2D10F50", Offset = "0x2D10150", VA = "0x182D10F50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FLFHMPAFPDN))]
	private Task KCKCBFOLCDA(FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2D10890", Offset = "0x2D0FA90", VA = "0x182D10890")]
	private void IOCBPMKFKKL(MDCIINLFDMH OGJNPFMLCHO, CancellationToken NNJAJHKDGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2D11250", Offset = "0x2D10450", VA = "0x182D11250")]
	private void KMHMCHGCNIP(MDCIINLFDMH OGJNPFMLCHO, NLAKPJCOMPN DKEAHNCOFEH, OperationCanceledException LHDGMMFMGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2D105C0", Offset = "0x2D0F7C0", VA = "0x182D105C0")]
	private void HPDAICAEADK(MDCIINLFDMH OGJNPFMLCHO, NLAKPJCOMPN DKEAHNCOFEH, Exception ODBCLHKGDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E7D0", Offset = "0x2D0D9D0", VA = "0x182D0E7D0")]
	private void BJBJJFBPFOO(MDCIINLFDMH OGJNPFMLCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E790", Offset = "0x2D0D990", VA = "0x182D0E790")]
	private static NAKGFMDIFDB BDDIJAKNLDI(MDCIINLFDMH OGJNPFMLCHO)
	{
		return default(NAKGFMDIFDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2D10E30", Offset = "0x2D10030", VA = "0x182D10E30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LKDIJDCHMPM))]
	private Task JPNLMMLKEPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2D11520", Offset = "0x2D10720", VA = "0x182D11520")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BPJPFJHHLAD))]
	private Task<Matchmaking.NBDPJBOGNGD> MAOPMEINLLF(MDCIINLFDMH OGJNPFMLCHO, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2D10CE0", Offset = "0x2D0FEE0", VA = "0x182D10CE0")]
	private static OOGNCOGFMCL JJDGPAIPDOE(MDCIINLFDMH OGJNPFMLCHO, Matchmaking.NBDPJBOGNGD JAAFDFPDNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2D10190", Offset = "0x2D0F390", VA = "0x182D10190")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NAMGMBKFGHP))]
	private Task HFJGOLAJPNH(MDCIINLFDMH OGJNPFMLCHO, Matchmaking.NBDPJBOGNGD JAAFDFPDNCL, NLAKPJCOMPN DKEAHNCOFEH, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken NNKDDPOLGBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2D11FB0", Offset = "0x2D111B0", VA = "0x182D11FB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KLGCAIBCEKK))]
	private Task PHNBMPNJLLO(MDCIINLFDMH OGJNPFMLCHO, CancellationTokenSource AINNMLEALGE, Task LKNALIDJIEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2D103C0", Offset = "0x2D0F5C0", VA = "0x182D103C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDBFGDGMBGK))]
	private Task HOGJBMOOPBF(IHKLGONHBKF PAPKKOBCIDK, OLPMEMOFGMN IEMCCPFJDNF, MDCIINLFDMH ONBHFMILHPB, NLAKPJCOMPN MPOFLDKLENO, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken EGPMFMILHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F790", Offset = "0x2D0E990", VA = "0x182D0F790")]
	private NLAKPJCOMPN GAJKGIPPJMG(NLAKPJCOMPN MPOFLDKLENO, ref CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2D116C0", Offset = "0x2D108C0", VA = "0x182D116C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KNCLIMNFILI))]
	private Task NBMIJIGABOF(FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EA70", Offset = "0x2D0DC70", VA = "0x182D0EA70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BBLNNJPCIIM))]
	private Task CNDBMBDLIFC(FEKMMALKIBN JCEJEOAKGOJ, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E620", Offset = "0x2D0D820", VA = "0x182D0E620")]
	private static void ANAAFNLJJLI(MDCIINLFDMH OGJNPFMLCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D119D0", Offset = "0x2D10BD0", VA = "0x182D119D0")]
	private void OGFNNBMPJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D0FCC0", Offset = "0x2D0EEC0", VA = "0x182D0FCC0")]
	private void HBKIHFDIBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2D10C50", Offset = "0x2D0FE50", VA = "0x182D10C50")]
	private void JFLGJJGELEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2D0FC30", Offset = "0x2D0EE30", VA = "0x182D0FC30")]
	private void GHJFKHEEJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2D110C0", Offset = "0x2D102C0", VA = "0x182D110C0")]
	private static void KFLPPHHENBH(MDCIINLFDMH OGJNPFMLCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EE70", Offset = "0x2D0E070", VA = "0x182D0EE70")]
	private static CancellationTokenRegistration FHGCHLLCPML(MDCIINLFDMH OGJNPFMLCHO, CancellationToken NNKDDPOLGBC)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E480", Offset = "0x2D0D680", VA = "0x182D0E480")]
	private static void AJDIFNJFOOO(MDCIINLFDMH OGJNPFMLCHO, Exception ODBCLHKGDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F9F0", Offset = "0x2D0EBF0", VA = "0x182D0F9F0")]
	private void GCLKOPKGCKD(MDCIINLFDMH OGJNPFMLCHO, Task LKNALIDJIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EBE0", Offset = "0x2D0DDE0", VA = "0x182D0EBE0")]
	private static void DJGNNKLAGEN(Func<string> GGOJIBEJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2D12490", Offset = "0x2D11690", VA = "0x182D12490")]
	public CDKGPEMHFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D12150", Offset = "0x2D11350", VA = "0x182D12150")]
	[CompilerGenerated]
	internal static (int, int?) PIKMFFGADMD(NOAKBMOBOAL AOOCDELIJDO)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface NDMECFMJHCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CLFKONEBOLH<AAMJDAPOEFN, PIHDIMJPEHH>> PFKAAIANMPF(string KBBAHAIKDJO, long EGCEBLMJCKK, IDFOFNFJIKL.DBKAFHNIHIC NKLNPBABDBB, CancellationToken PLEKJLHDOLP);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class BCHMLPMIOHC : GCFFAAFIFCD<BLGLLGBBDII>
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class KFBJCJJBDKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public BLGLLGBBDII message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KFBJCJJBDKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x36EE6F0", Offset = "0x36ED8F0", VA = "0x1836EE6F0")]
		internal object HAIAEACGODG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static readonly BCHMLPMIOHC EBEPLDELFOG;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const string LFOPGKECCOG = "pl";

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CA80", Offset = "0x2D0BC80", VA = "0x182D0CA80")]
	public ExitGames.Client.Photon.Hashtable IOEANABOGCL(BLGLLGBBDII CEOMJLPEFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C4C0", Offset = "0x2D0B6C0", VA = "0x182D0C4C0", Slot = "5")]
	protected override void ANMGLLOMEPD(BLGLLGBBDII CEOMJLPEFPB, IDictionary<object, object> JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C2C0", Offset = "0x2D0B4C0", VA = "0x182D0C2C0", Slot = "6")]
	public override BLGLLGBBDII AKLCAJOKCCK(IDictionary<object, object> JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C5F0", Offset = "0x2D0B7F0", VA = "0x182D0C5F0")]
	private static void DJGNNKLAGEN(string CKFMFAFJJON, BLGLLGBBDII CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CB80", Offset = "0x2D0BD80", VA = "0x182D0CB80")]
	public BCHMLPMIOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C780", Offset = "0x2D0B980", VA = "0x182D0C780")]
	[CompilerGenerated]
	internal static string GIEFEPODPPI(IHKLGONHBKF DGLHFPEOHIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface BILFFCGDFHA<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CLFKONEBOLH<byte[], PIHDIMJPEHH>> MHGKBJPLECH(TGetDataArg ANPLPNKHBJM, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CLFKONEBOLH<KBFBKOAJJMK<TData>, PIHDIMJPEHH> FILDEJAOGPG(byte[] JCEJEOAKGOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface KIIBJKPFFHE : DFBDMPCEMAM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAKMMEJMOAP GJIGEPNPDDE(NBDCAKCJOHF KCAAIIKABAL);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class FHOAKJCIELM : HPAPDDMIFHF, KCKPGLBOMMK, DGFEKNNEOCH, JOMLHIGAINO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly KCKPGLBOMMK FFFPAJGOLMI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NBDCAKCJOHF POMNKEBNHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D253B0", Offset = "0x2D245B0", VA = "0x182D253B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NOEJKIFPBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D25020", Offset = "0x2D24220", VA = "0x182D25020", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DEHLFKPJMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D25360", Offset = "0x2D24560", VA = "0x182D25360", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool JFPICALLGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int PEOKBPKMCND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x825660", Offset = "0x824860", VA = "0x180825660", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event CHLADHGPDLB.AEFCMKHNLIM EONFAIPJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event LDEABADBJDM KADOEFMAOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D24F20", Offset = "0x2D24120", VA = "0x182D24F20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2D24DE0", Offset = "0x2D23FE0", VA = "0x182D24DE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> FCGPCEOKNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<NBDCAKCJOHF> CCBHOFPBKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action FMKIMEJMGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2D252A0", Offset = "0x2D244A0", VA = "0x182D252A0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2D24E80", Offset = "0x2D24080", VA = "0x182D24E80", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xFB12C0", Offset = "0xFB04C0", VA = "0x180FB12C0")]
	public FHOAKJCIELM(KCKPGLBOMMK FFFPAJGOLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D251F0", Offset = "0x2D243F0", VA = "0x182D251F0", Slot = "8")]
	public bool JBENOBPANKL(byte KCLBFAFAFOD, ExitGames.Client.Photon.Hashtable OKAHKOBFKDI, GFCBDFMOPMB KOIDCMDGPBG, SendOptions OMHNBEKIFGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D25070", Offset = "0x2D24270", VA = "0x182D25070", Slot = "29")]
	public NBDCAKCJOHF IKHHNKIJMIE(int CBAIKFCAIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D25110", Offset = "0x2D24310", VA = "0x182D25110", Slot = "16")]
	public NBDCAKCJOHF IKOFBKKMJCE(int HNAKENADKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "19")]
	public void HJLDHCJNLFM(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "20")]
	public void GPIHCDDEFFC(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "21")]
	public void EFDBJBGLKAE(object IBIKCCMDMHA, bool HILEBBGEELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D24FC0", Offset = "0x2D241C0", VA = "0x182D24FC0", Slot = "22")]
	public IDisposable HJDPONLFFON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "23")]
	private bool AIEEGHKEAHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "24")]
	public void IDFJPPKIGHH(StringBuilder NAGILKMPPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2D25340", Offset = "0x2D24540", VA = "0x182D25340", Slot = "25")]
	public bool LGEPCFAKGNE(bool MKFDADNGNLG, out string KLEKJFJOCHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public void GNDLPJMOKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1909B80", Offset = "0x1908D80", VA = "0x181909B80", Slot = "28")]
	public void BEPAGIGMKDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal struct COEHOHKBDPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly TaskCompletionSource<(NAKMMEJMOAP, Task)> MHGDJNMIPFG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Task<(NAKMMEJMOAP, Task)> JNAAGNCIBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2D13700", Offset = "0x2D12900", VA = "0x182D13700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2D13910", Offset = "0x2D12B10", VA = "0x182D13910")]
	public COEHOHKBDPA(TimeSpan HJLEAHGMGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2D137D0", Offset = "0x2D129D0", VA = "0x182D137D0")]
	public void PAPHMEONIEN(Task IHNIBFOOPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2D13670", Offset = "0x2D12870", VA = "0x182D13670")]
	public void IIGODFAFKCM(NAKMMEJMOAP FGPPDHPBHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2D138C0", Offset = "0x2D12AC0", VA = "0x182D138C0")]
	public void PLEBEOEEHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2D13740", Offset = "0x2D12940", VA = "0x182D13740")]
	internal void MCMEPNNMLME(string CEOMJLPEFPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class JOEFOEKGIAE : DNEAHMCJOPM, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private bool PEMBBFNMGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private LIAOPDCMOJN KMILKPFDEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private IPBPMMLOKDP BIHEKONDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NJLAOLIOPMC PEPOGGMJFLC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LIAOPDCMOJN JNDDJJFOCIA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x36EC8A0", Offset = "0x36EBAA0", VA = "0x1836EC8A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x36EC910", Offset = "0x36EBB10", VA = "0x1836EC910", Slot = "7")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x36ECA20", Offset = "0x36EBC20", VA = "0x1836ECA20", Slot = "5")]
	public void PJCHEKLJHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x36EC7E0", Offset = "0x36EB9E0", VA = "0x1836EC7E0", Slot = "6")]
	public void JBAAOPDBNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x36EC820", Offset = "0x36EBA20", VA = "0x1836EC820")]
	private Task HKMLFMCNCKG(FBHGBLBDFGI AGKOCALGANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x36EC7E0", Offset = "0x36EB9E0", VA = "0x1836EC7E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1522AC0", Offset = "0x1521CC0", VA = "0x181522AC0")]
	public JOEFOEKGIAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct CCBOGCEOODI
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class KAFPKLJNAHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public KCLMMCNCBHA manager;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KAFPKLJNAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x36EE6B0", Offset = "0x36ED8B0", VA = "0x1836EE6B0")]
		internal Task LDDKBOCKCPJ(FEKMMALKIBN data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class DDLIMGDJDEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public CCBOGCEOODI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private COOLNBMBOGP <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private PELNDJMPAIB <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private PELNDJMPAIB <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private PELNDJMPAIB <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter<PELNDJMPAIB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter<NAKMMEJMOAP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DDLIMGDJDEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x36E9980", Offset = "0x36E8B80", VA = "0x1836E9980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class OEDCDIHMFFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CCBOGCEOODI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OEDCDIHMFFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x36FBE70", Offset = "0x36FB070", VA = "0x1836FBE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly CancellationToken PLEKJLHDOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly KCLMMCNCBHA EKDODOMDNPH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private IPBPMMLOKDP JOBLGKBPLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DD70", Offset = "0x2D0CF70", VA = "0x182D0DD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private FGKLHHEMEMB HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DD20", Offset = "0x2D0CF20", VA = "0x182D0DD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private KOIGEBDLLEK PJNHDMFJAGK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DDC0", Offset = "0x2D0CFC0", VA = "0x182D0DDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private JKIJBDKIACB MPJDGLGBNIL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0E430", Offset = "0x2D0D630", VA = "0x182D0E430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1580A20", Offset = "0x157FC20", VA = "0x181580A20")]
	public CCBOGCEOODI(CancellationToken PLEKJLHDOLP, KCLMMCNCBHA EKDODOMDNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E110", Offset = "0x2D0D310", VA = "0x182D0E110")]
	public static KJDACGGJIOE OFLAOHPIFAM(KCLMMCNCBHA EKDODOMDNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E1C0", Offset = "0x2D0D3C0", VA = "0x182D0E1C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDLIMGDJDEK))]
	public Task<bool> ONDGBMOLAPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DF70", Offset = "0x2D0D170", VA = "0x182D0DF70")]
	private bool JKHHIFIFOCI(out COOLNBMBOGP CGJKBLJLHJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E310", Offset = "0x2D0D510", VA = "0x182D0E310")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OEDCDIHMFFC))]
	private Task PBJLCJOBONB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DE40", Offset = "0x2D0D040", VA = "0x182D0DE40")]
	private Task<PELNDJMPAIB> IAKLPACIKEH(COOLNBMBOGP KJIAJKNJBML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class JLKCIEEGLKI : NJLAOLIOPMC
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class BOEDMHHAPPC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly GLMBDHOFKPK IFKOJKGHEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly string PPNIGBBPGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly T DDGOMDBNGFF;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public T IHPKAGOHFMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x844720", Offset = "0x843920", VA = "0x180844720")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8DC340", Offset = "0x8DB540", VA = "0x1808DC340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DC40", Offset = "0x2F8CE40", VA = "0x182F8DC40")]
		public BOEDMHHAPPC(GLMBDHOFKPK IFKOJKGHEEL, string PPNIGBBPGOI, T DDGOMDBNGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2F8D8F0", Offset = "0x2F8CAF0", VA = "0x182F8D8F0")]
		private void LBFBOKOMKKD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly GLMBDHOFKPK IFKOJKGHEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly BOEDMHHAPPC<TimeSpan> LEPPDGCKLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly BOEDMHHAPPC<TimeSpan> LBDBGKKEMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly BOEDMHHAPPC<TimeSpan> JDLGKOKNBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly BOEDMHHAPPC<TimeSpan> EDNEEJHFLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly BOEDMHHAPPC<bool> FKDGCBDALPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly BOEDMHHAPPC<bool> FBLKNAJKFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly BOEDMHHAPPC<bool> IGJCIGLKDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly BOEDMHHAPPC<int> GAPDDHGIKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly BOEDMHHAPPC<bool> OLIBMOPBNJL;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const string GJMNNPCIEGG = "RoomLoadCameraFadeTimeout";

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan DOGABANHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x36EB9C0", Offset = "0x36EABC0", VA = "0x1836EB9C0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan EOHIKIHBNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x36EB6C0", Offset = "0x36EA8C0", VA = "0x1836EB6C0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public TimeSpan GPOBIOCBMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x36EB700", Offset = "0x36EA900", VA = "0x1836EB700", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public TimeSpan LNAEANAJCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x36EB640", Offset = "0x36EA840", VA = "0x1836EB640", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool FNICOJFNEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x36EBA40", Offset = "0x36EAC40", VA = "0x1836EBA40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool GMBIJAFBNGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x36EB980", Offset = "0x36EAB80", VA = "0x1836EB980", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NCGOJEDNIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x36EBA00", Offset = "0x36EAC00", VA = "0x1836EBA00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int HIIMMKDHGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x36EB600", Offset = "0x36EA800", VA = "0x1836EB600", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool HCLMMECJALE
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x36EB680", Offset = "0x36EA880", VA = "0x1836EB680", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool PMBCFBIOGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x36EB890", Offset = "0x36EAA90", VA = "0x1836EB890", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TimeSpan ADIDLJOOJGN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x36EB740", Offset = "0x36EA940", VA = "0x1836EB740", Slot = "12")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x36EBA80", Offset = "0x36EAC80", VA = "0x1836EBA80")]
	[UnityEngine.Scripting.Preserve]
	public JLKCIEEGLKI([IDNKOMINBGM(null)] GLMBDHOFKPK IFKOJKGHEEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal struct GEMPBMIOHGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class JLBNKELONLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public GEMPBMIOHGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JLBNKELONLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x42962F0", Offset = "0x42954F0", VA = "0x1842962F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly CancellationTokenSource AKHLKBFAFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private bool MIGKAMNMNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private Task ONPFLGLLMLP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool LIKFKNKKDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2D25750", Offset = "0x2D24950", VA = "0x182D25750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal Task JNAAGNCIBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2D25780", Offset = "0x2D24980", VA = "0x182D25780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2D25800", Offset = "0x2D24A00", VA = "0x182D25800")]
	public GEMPBMIOHGA(CancellationToken PLEKJLHDOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2D255F0", Offset = "0x2D247F0", VA = "0x182D255F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JLBNKELONLO))]
	public Task FGDKAKNLFJH(Func<CancellationToken, List<Task>> LHLHPPKLFID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2D255A0", Offset = "0x2D247A0", VA = "0x182D255A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal interface GFPBNPJJDJN : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOJCCABHALO PPMBLONPHPF(Guid HPINIPGLIPD);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PLKCAALIKKA(Guid HPINIPGLIPD);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JMAGGDOJMAP(Guid HPINIPGLIPD, Task IHNIBFOOPAD);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CKDCPLFNADD(Guid HPINIPGLIPD, NAKMMEJMOAP KDCKBIBAECJ);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LFPEABENKGO(Guid HPINIPGLIPD);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(NAKMMEJMOAP, Task)> DIDJHADGBNC(Guid HPINIPGLIPD);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal interface JKLCIGBBEGC : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAKMMEJMOAP GJMPMGNLBPP(NBDCAKCJOHF ABACAIJJLIF, APGCGMGDIIP DILEKOOCNPA);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NAKMMEJMOAP BECHIAGPJAF(NBDCAKCJOHF KCAAIIKABAL);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NAKMMEJMOAP HBLEPKFCLKD(NBDCAKCJOHF KCAAIIKABAL);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class BFIMADHHBAL : MEMOKKFMPAN
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class FKFKLALBADE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public BFIMADHHBAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private MDCIINLFDMH <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private MDCIINLFDMH <newPresenceRoomInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private float <timeoutTime>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FKFKLALBADE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x36EA2A0", Offset = "0x36E94A0", VA = "0x1836EA2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private const float NKPNMNIFJFP = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly FGKLHHEMEMB JCECDDPGEKA;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private KOIGEBDLLEK PJNHDMFJAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2D0CCA0", Offset = "0x2D0BEA0", VA = "0x182D0CCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8D7200", Offset = "0x8D6400", VA = "0x1808D7200")]
	public BFIMADHHBAL(KCLMMCNCBHA COENACEECKL, FGKLHHEMEMB JCECDDPGEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CCF0", Offset = "0x2D0BEF0", VA = "0x182D0CCF0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FKFKLALBADE))]
	public Task<bool> LLCGDCDDPAA(CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CBC0", Offset = "0x2D0BDC0", VA = "0x182D0CBC0")]
	[CompilerGenerated]
	private object EMJDHJBBBMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal interface NCCDKGMFIIF : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIDKODIIMCB(BLGLLGBBDII CEOMJLPEFPB);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHFDKGGPFBI(BLGLLGBBDII CEOMJLPEFPB);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<APGCGMGDIIP> PDMPMJBPNNI(CancellationToken MGFGEANJBBG);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal interface MINMGNDMHLI : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAKMMEJMOAP HPDOMJLIBEH(NBDCAKCJOHF ABACAIJJLIF);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GECIBNGMFFF(string KMBFNDAPCGA);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[UnityEngine.Scripting.Preserve]
internal class JPBANOOFAKK : CNOMDHHEFIE, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JHKCCJNBEOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public JPBANOOFAKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JHKCCJNBEOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4295400", Offset = "0x4294600", VA = "0x184295400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly NNFJPPGGOPL EAACEGEMKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private string FOAODJFHJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Task PIGPNLPDMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool GEJCDPPHIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x36ED110", Offset = "0x36EC310", VA = "0x1836ED110", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Task GMBJDDFIAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x36ECEF0", Offset = "0x36EC0F0", VA = "0x1836ECEF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x841E50", Offset = "0x841050", VA = "0x180841E50", Slot = "7")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x36ECF50", Offset = "0x36EC150", VA = "0x1836ECF50", Slot = "6")]
	public void KFMDEGIFGKN(Task ONPFLGLLMLP, string FLOAPHEDMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x36ECD80", Offset = "0x36EBF80", VA = "0x1836ECD80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JHKCCJNBEOD))]
	private Task BOANJIAHAEP(Task CBFHJGCJEKL, string FLOAPHEDMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x36ED140", Offset = "0x36EC340", VA = "0x1836ED140")]
	public JPBANOOFAKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal struct HOJCCABHALO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly GFPBNPJJDJN LKLMKNNGJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly Guid HPINIPGLIPD;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Task<(NAKMMEJMOAP, Task)> JNAAGNCIBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2D29DB0", Offset = "0x2D28FB0", VA = "0x182D29DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x25CF8A0", Offset = "0x25CEAA0", VA = "0x1825CF8A0")]
	public HOJCCABHALO(GFPBNPJJDJN LKLMKNNGJEB, Guid HPINIPGLIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2D29D60", Offset = "0x2D28F60", VA = "0x182D29D60")]
	public TaskAwaiter<(NAKMMEJMOAP, Task)> LBFELGIGDIH()
	{
		return default(TaskAwaiter<(NAKMMEJMOAP, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2D29C90", Offset = "0x2D28E90", VA = "0x182D29C90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[UnityEngine.Scripting.Preserve]
internal sealed class EBBDCLEOGLH : JKIJBDKIACB, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class HHONFPMAMGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder<NAKMMEJMOAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public COOLNBMBOGP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public EBBDCLEOGLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private FDMIABHIEGI<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private DHINMMNHIHF <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private IHKLGONHBKF <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private NAKMMEJMOAP <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TaskAwaiter<NAKMMEJMOAP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HHONFPMAMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x42BE700", Offset = "0x42BD900", VA = "0x1842BE700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class PAIKKLHAGGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public EBBDCLEOGLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private CancellationTokenSource <combinedTokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PAIKKLHAGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x42C5F00", Offset = "0x42C5100", VA = "0x1842C5F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class MFBGENLMIJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public FEKMMALKIBN _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public EBBDCLEOGLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MFBGENLMIJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x42C25B0", Offset = "0x42C17B0", VA = "0x1842C25B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class LNGLCPGOAKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public EBBDCLEOGLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private object <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LNGLCPGOAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x42C1460", Offset = "0x42C0660", VA = "0x1842C1460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class BBALPBJFGCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public EBBDCLEOGLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BBALPBJFGCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x42B5B30", Offset = "0x42B4D30", VA = "0x1842B5B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class EEOHCJIPAMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public EBBDCLEOGLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private CancellationToken <nextAutosaveToken>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EEOHCJIPAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x42BBA80", Offset = "0x42BAC80", VA = "0x1842BBA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class KBBLJLBPPOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public EBBDCLEOGLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private Task <delayTask>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private Task<int> <intervalChangedTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private Task <resultTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KBBLJLBPPOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x42C0540", Offset = "0x42BF740", VA = "0x1842C0540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class PBGDEEGGPKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public BJINNGNHAFI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public EBBDCLEOGLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private FDMIABHIEGI<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private NLAKPJCOMPN <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private EGMAPPFLLFP <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PBGDEEGGPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x42C6600", Offset = "0x42C5800", VA = "0x1842C6600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private IPBPMMLOKDP BIHEKONDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private FGKLHHEMEMB JCECDDPGEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private IHCAMGNCBDI IKGLEHGFGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private CNOMDHHEFIE PFPAIKIAJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private KDJCIPGDMJL NOPNKEBPJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private CancellationTokenSource KNHOLBMODGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private Task AOKIGJBAKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private TaskCompletionSource<int> OEDFJLOOLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int HALNHPHBBIE;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C900", Offset = "0x2D1BB00", VA = "0x182D1C900", Slot = "6")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1852BB0", Offset = "0x1851DB0", VA = "0x181852BB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2D1BB40", Offset = "0x2D1AD40", VA = "0x182D1BB40")]
	private void DEHLKHLOFAO(float FOKLIKGFBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C390", Offset = "0x2D1B590", VA = "0x182D1C390", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HHONFPMAMGK))]
	public Task<NAKMMEJMOAP> JJDLPJCPIFG(COOLNBMBOGP CGJKBLJLHJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B9F0", Offset = "0x2D1ABF0", VA = "0x182D1B9F0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PAIKKLHAGGA))]
	public Task CAHIFJGDIHB([Optional] CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x1852BB0", Offset = "0x1851DB0", VA = "0x181852BB0")]
	public void MCLMAFKBLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2D1BC20", Offset = "0x2D1AE20", VA = "0x182D1BC20")]
	private DHINMMNHIHF ELIMMKCNNAP(COOLNBMBOGP CGJKBLJLHJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B730", Offset = "0x2D1A930", VA = "0x182D1B730")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFBGENLMIJE))]
	private Task AKLADKFEHNF(FEKMMALKIBN AGKOCALGANA, CancellationToken NNJAJHKDGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C500", Offset = "0x2D1B700", VA = "0x182D1C500")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNGLCPGOAKL))]
	private Task KCBOBLAIOCI(CancellationToken NNJAJHKDGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C130", Offset = "0x2D1B330", VA = "0x182D1C130")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BBALPBJFGCM))]
	private Task HNCCDHLKDJK([Optional] CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B8A0", Offset = "0x2D1AAA0", VA = "0x182D1B8A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EEOHCJIPAMH))]
	private Task BIBGJBBIDAJ(CancellationToken NNJAJHKDGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2D1BE80", Offset = "0x2D1B080", VA = "0x182D1BE80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KBBLJLBPPOE))]
	private Task GAOMODOHHAE(CancellationToken KPPLPOHHCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C650", Offset = "0x2D1B850", VA = "0x182D1C650")]
	private Task LLJGBNJJAEF(BJINNGNHAFI AGHJKILGDNH, CancellationToken NNJAJHKDGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1BFD0", Offset = "0x2D1B1D0", VA = "0x182D1BFD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBGDEEGGPKI))]
	private Task HGFMBGFIAKK(BJINNGNHAFI AGHJKILGDNH, CancellationToken NNJAJHKDGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C280", Offset = "0x2D1B480", VA = "0x182D1C280")]
	private bool HPDOMJLIBEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public EBBDCLEOGLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface KLELFNKDBNP : DFBDMPCEMAM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAKMMEJMOAP HPDOMJLIBEH(NBDCAKCJOHF NHDBOCCEDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class JPCLBDLCBEN : CIHNBPNHBJC, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class IDJIKBPDMLH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly MDCIINLFDMH EDMNGDGPOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly CancellationTokenSource AKHLKBFAFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public readonly CancellationToken GENOJEADKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private bool PFLBHCPJLJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private bool PFALPCMNDEH;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4294690", Offset = "0x4293890", VA = "0x184294690")]
		public IDJIKBPDMLH(MDCIINLFDMH EDMNGDGPOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4294540", Offset = "0x4293740", VA = "0x184294540")]
		public void LFPEABENKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4294510", Offset = "0x4293710", VA = "0x184294510", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class MEIEMFKIBBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public FBHGBLBDFGI disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MEIEMFKIBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x429A720", Offset = "0x4299920", VA = "0x18429A720")]
		internal object LBIFMIKDAKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GFIPOHLFKIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public FBHGBLBDFGI disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public JPCLBDLCBEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private MEIEMFKIBBG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GFIPOHLFKIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4290890", Offset = "0x428FA90", VA = "0x184290890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class LEMOKMPGLDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LEMOKMPGLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4299510", Offset = "0x4298710", VA = "0x184299510")]
		internal object BHGCNJNEGFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class NPBIFNEBJPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public JPCLBDLCBEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private LEMOKMPGLDC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private IDisposable <logFlagsScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private IDisposable <logTraceScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private IDisposable <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private MDCIINLFDMH <newRoomInstance>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private KIPGPNOONJB <customRoomLoadPayload>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NPBIFNEBJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x429D750", Offset = "0x429C950", VA = "0x18429D750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class LPPBLKKAEKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public MDCIINLFDMH newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LPPBLKKAEKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x429A370", Offset = "0x4299570", VA = "0x18429A370")]
		internal object POMBGNBMECG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x429A330", Offset = "0x4299530", VA = "0x18429A330")]
		internal object ECDGKCEBPDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x429A2F0", Offset = "0x42994F0", VA = "0x18429A2F0")]
		internal object ADDGDPFGMEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class FFMHEPGAPBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FFMHEPGAPBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x428FE60", Offset = "0x428F060", VA = "0x18428FE60")]
		internal void HBOCIGKPDLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class HNIFOPGFHEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public MDCIINLFDMH newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public KIPGPNOONJB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public JPCLBDLCBEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private LPPBLKKAEKF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private FFMHEPGAPBI <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private CancellationToken <token>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private CancellationTokenRegistration <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private object <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private int <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private OperationCanceledException <oce>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HNIFOPGFHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4293580", Offset = "0x4292780", VA = "0x184293580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private AENCAKHMCBK EICMDGFKLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private IPDOADDBPPL DCPLGDEFGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private FGKLHHEMEMB JCECDDPGEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private NJLAOLIOPMC PEPOGGMJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private HDMCFFBEMAE HFAJEOBGPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private long DHOHEGMIHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private IDJIKBPDMLH KOAKBFCDNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private bool AAPFCFIMOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private Task PEKINEPPNMH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private KOIGEBDLLEK PJNHDMFJAGK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x36EDAB0", Offset = "0x36ECCB0", VA = "0x1836EDAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool HMHGLAIFOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x98D6F0", Offset = "0x98C8F0", VA = "0x18098D6F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x36EE620", Offset = "0x36ED820", VA = "0x1836EE620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x36EE3D0", Offset = "0x36ED5D0", VA = "0x1836EE3D0", Slot = "4")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x36ED400", Offset = "0x36EC600", VA = "0x1836ED400", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x36ED580", Offset = "0x36EC780", VA = "0x1836ED580")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFIPOHLFKIG))]
	private Task EDAHHOJLNEK(FBHGBLBDFGI GFNMJAADDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x36ED1D0", Offset = "0x36EC3D0", VA = "0x1836ED1D0")]
	private void DOOJPPLPADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x36EDCA0", Offset = "0x36ECEA0", VA = "0x1836EDCA0")]
	private void KANDFPMFNJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x36EDF50", Offset = "0x36ED150", VA = "0x1836EDF50")]
	private void LDLLDCHHKNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x36EDED0", Offset = "0x36ED0D0", VA = "0x1836EDED0")]
	private bool LBPNHNJIDGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x36EE170", Offset = "0x36ED370", VA = "0x1836EE170")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NPBIFNEBJPE))]
	private void MKGBKNINBJG(int ONBDCPMPPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x36ED700", Offset = "0x36EC900", VA = "0x1836ED700")]
	private void GDJPPDNAEJP(out IDisposable OHKFHDMKHNA, out IDisposable BOHMBOIBCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x36EDB00", Offset = "0x36ECD00", VA = "0x1836EDB00")]
	private bool IBIKDFKJAID(MDCIINLFDMH EDMNGDGPOBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x36ED6C0", Offset = "0x36EC8C0", VA = "0x1836ED6C0")]
	private void FNIFAJJOECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x36EE260", Offset = "0x36ED460", VA = "0x1836EE260")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HNIFOPGFHEE))]
	private Task OFJDDMLGABF(MDCIINLFDMH EDMNGDGPOBH, KIPGPNOONJB GFEFGABCJFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x36EE630", Offset = "0x36ED830", VA = "0x1836EE630")]
	public JPCLBDLCBEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal sealed class FDFEFDILEFK : BBMDBLLFADF, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class IFIHPIHJPHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public IFIHPIHJPHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x42949E0", Offset = "0x4293BE0", VA = "0x1842949E0")]
		internal object BACGGIFOPGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class FADDJBCCIPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FADDJBCCIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x428F8D0", Offset = "0x428EAD0", VA = "0x18428F8D0")]
		internal object GGBHGPACJEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private IPBPMMLOKDP BIHEKONDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private JKLCIGBBEGC MFNJCMHILGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private NCCDKGMFIIF NGNGGAHJGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private GFPBNPJJDJN LKLMKNNGJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private GNJHADANBGP HOHANAPHNGF;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2D23C20", Offset = "0x2D22E20", VA = "0x182D23C20", Slot = "6")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2D22560", Offset = "0x2D21760", VA = "0x182D22560", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2D22600", Offset = "0x2D21800", VA = "0x182D22600", Slot = "4")]
	public HOJCCABHALO EMDLLDPNABD(BLGLLGBBDII FBANNGACLMB)
	{
		return default(HOJCCABHALO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2D21A70", Offset = "0x2D20C70", VA = "0x182D21A70", Slot = "5")]
	public void CHAOAMJDGIH(Guid HPINIPGLIPD, Task IHNIBFOOPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2D23860", Offset = "0x2D22A60", VA = "0x182D23860")]
	private void LFJFMGPIKFO(byte KCLBFAFAFOD, int DPPFMLJLOBF, object GIKHOFPMBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2D22D80", Offset = "0x2D21F80", VA = "0x182D22D80")]
	private void JDLHJBODNLI(NCFGALNHNEO NHCCLIMEPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2D23D90", Offset = "0x2D22F90", VA = "0x182D23D90")]
	private void PJOFEJGALMG(NCFGALNHNEO NHCCLIMEPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2D22290", Offset = "0x2D21490", VA = "0x182D22290")]
	private void DBFODCCDNGM(NCFGALNHNEO NHCCLIMEPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2D21CF0", Offset = "0x2D20EF0", VA = "0x182D21CF0")]
	private NAKMMEJMOAP CINFCOFNDMP(BLGLLGBBDII CCFNHFGLHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D22B10", Offset = "0x2D21D10", VA = "0x182D22B10")]
	private void FMEAPDKINAB(BLGLLGBBDII DDAINBJGPFN, NAKMMEJMOAP FGPPDHPBHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2D22020", Offset = "0x2D21220", VA = "0x182D22020")]
	private bool CMNAGDLFBEB(BLGLLGBBDII DDAINBJGPFN, NAKMMEJMOAP FGPPDHPBHPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D23930", Offset = "0x2D22B30", VA = "0x182D23930")]
	private bool MBABDIMKMAP(BLGLLGBBDII JHLOJEBNHCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D23540", Offset = "0x2D22740", VA = "0x182D23540")]
	private bool KDMJGCMMBHC(byte KCLBFAFAFOD, ExitGames.Client.Photon.Hashtable NHCCLIMEPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public FDFEFDILEFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[UnityEngine.Scripting.Preserve]
internal sealed class ENEOGHANIBN : NCCDKGMFIIF, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JFDIDOPDLEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<APGCGMGDIIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public ENEOGHANIBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private APGCGMGDIIP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter<APGCGMGDIIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JFDIDOPDLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x42951D0", Offset = "0x42943D0", VA = "0x1842951D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class GICJDCMAHAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public BLGLLGBBDII message;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GICJDCMAHAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4290D00", Offset = "0x428FF00", VA = "0x184290D00")]
		internal object CNFDHDDBPAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class PPLGOPPLAME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public BLGLLGBBDII messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PPLGOPPLAME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x429EF20", Offset = "0x429E120", VA = "0x18429EF20")]
		internal object ELDPJPOJAMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class KCFACEFHGIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public BLGLLGBBDII request;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KCFACEFHGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4297170", Offset = "0x4296370", VA = "0x184297170")]
		internal object JAAMKEKBPEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class JIFNEJNMJMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public BLGLLGBBDII request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public ENEOGHANIBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private KCFACEFHGIB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private ILAIPNDOCNE <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private ILAIPNDOCNE <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter<ILAIPNDOCNE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JIFNEJNMJMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x4295B90", Offset = "0x4294D90", VA = "0x184295B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class MDLLCDAJHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public BLGLLGBBDII operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MDLLCDAJHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x429A6C0", Offset = "0x42998C0", VA = "0x18429A6C0")]
		internal object NPDFEKPENEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class HCAENKPPGMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public BLGLLGBBDII operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public ENEOGHANIBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private MDLLCDAJHNF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private NLAKPJCOMPN <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private BLGLLGBBDII <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private ILAIPNDOCNE <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private BLGLLGBBDII <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private TaskAwaiter<BLGLLGBBDII> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HCAENKPPGMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x42926E0", Offset = "0x42918E0", VA = "0x1842926E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class GODCEMCFHML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AsyncTaskMethodBuilder<ILAIPNDOCNE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public BLGLLGBBDII request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public ENEOGHANIBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private NLAKPJCOMPN <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private BLGLLGBBDII <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private BLGLLGBBDII <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private TaskAwaiter<BLGLLGBBDII> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GODCEMCFHML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4291DE0", Offset = "0x4290FE0", VA = "0x184291DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class EGAHECCPONB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public ILAIPNDOCNE operation;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EGAHECCPONB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x428E330", Offset = "0x428D530", VA = "0x18428E330")]
		internal object LPILBKJAOME()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class EJNELKEEFKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public ILAIPNDOCNE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public ENEOGHANIBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private EGAHECCPONB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private FDMIABHIEGI<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EJNELKEEFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x428EA00", Offset = "0x428DC00", VA = "0x18428EA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class PMHABKEMNJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public BLGLLGBBDII request;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PMHABKEMNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x429EE80", Offset = "0x429E080", VA = "0x18429EE80")]
		internal object IACINJMLPDJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class CDEGHBPGDPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public BLGLLGBBDII request;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CDEGHBPGDPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x428CAC0", Offset = "0x428BCC0", VA = "0x18428CAC0")]
		internal object MLJCBCKOOAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private CNOMDHHEFIE PFPAIKIAJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private BBMDBLLFADF PALIMGMPOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private IHCAMGNCBDI IKGLEHGFGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private IPBPMMLOKDP BIHEKONDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private TaskCompletionSource<APGCGMGDIIP> PDBFBKPACNI;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E680", Offset = "0x2D1D880", VA = "0x182D1E680", Slot = "7")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E760", Offset = "0x2D1D960", VA = "0x182D1E760", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JFDIDOPDLEI))]
	public Task<APGCGMGDIIP> PDMPMJBPNNI(CancellationToken MGFGEANJBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D7B0", Offset = "0x2D1C9B0", VA = "0x182D1D7B0", Slot = "4")]
	public void CIDKODIIMCB(BLGLLGBBDII CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DC20", Offset = "0x2D1CE20", VA = "0x182D1DC20", Slot = "5")]
	public void FHFDKGGPFBI(BLGLLGBBDII NHGNKLBALPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E1F0", Offset = "0x2D1D3F0", VA = "0x182D1E1F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JIFNEJNMJMB))]
	private Task GFOECOHPBBP(BLGLLGBBDII JFILJIAPEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E530", Offset = "0x2D1D730", VA = "0x182D1E530")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HCAENKPPGMH))]
	private Task MBEIBOEBAOG(BLGLLGBBDII DDAINBJGPFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E050", Offset = "0x2D1D250", VA = "0x182D1E050")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GODCEMCFHML))]
	private Task<ILAIPNDOCNE> FMKKBJHMNNP(BLGLLGBBDII JFILJIAPEEP, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E4B0", Offset = "0x2D1D6B0", VA = "0x182D1E4B0")]
	private NLAKPJCOMPN JPLGHLIMKLA(BLGLLGBBDII CCFNHFGLHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E340", Offset = "0x2D1D540", VA = "0x182D1E340")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJNELKEEFKA))]
	private Task HAGGNADGKFC(ILAIPNDOCNE IAFPJLJBHFI, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D1EDA0", Offset = "0x2D1DFA0", VA = "0x182D1EDA0")]
	private ILAIPNDOCNE PLLDFGDAOOO(BLGLLGBBDII JFILJIAPEEP, NLAKPJCOMPN HJCCDBGIIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x33C3790", Offset = "0x33C2990", VA = "0x1833C3790")]
	private T CBAKNPBIAPP<T>(T ACKOJNNBEBO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E8D0", Offset = "0x2D1DAD0", VA = "0x182D1E8D0")]
	private ILAIPNDOCNE PJGJBMGGPKE(BLGLLGBBDII JFILJIAPEEP, NLAKPJCOMPN HJCCDBGIIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public ENEOGHANIBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal interface NJLAOLIOPMC
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TimeSpan DOGABANHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	TimeSpan EOHIKIHBNDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	TimeSpan GPOBIOCBMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	TimeSpan LNAEANAJCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool FNICOJFNEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool GMBIJAFBNGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool NCGOJEDNIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool PMBCFBIOGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	TimeSpan ADIDLJOOJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int HIIMMKDHGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool HCLMMECJALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal interface IPDFLCGLIDF : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IHKLGONHBKF> PIHPKNEFFDE(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, MDCIINLFDMH OGJNPFMLCHO, CancellationToken PLEKJLHDOLP);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class MELBKNINBEH : MEMOKKFMPAN
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class BKKACMLBPBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public MELBKNINBEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Matchmaking.PNJEDKFHBKE result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public MDCIINLFDMH newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BKKACMLBPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5C329F0", Offset = "0x5C31BF0", VA = "0x185C329F0")]
		internal object NFKKLHGPPBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5C328E0", Offset = "0x5C31AE0", VA = "0x185C328E0")]
		internal object HDMIIPOELIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5C32950", Offset = "0x5C31B50", VA = "0x185C32950")]
		internal object IJCLBNAENHH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class FOALHFFEMEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public MELBKNINBEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private BKKACMLBPBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private Matchmaking.PNJEDKFHBKE <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private TaskAwaiter<Matchmaking.PNJEDKFHBKE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FOALHFFEMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x5C34810", Offset = "0x5C33A10", VA = "0x185C34810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private const float NKPNMNIFJFP = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly FGKLHHEMEMB JCECDDPGEKA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private KOIGEBDLLEK PJNHDMFJAGK
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x36F98F0", Offset = "0x36F8AF0", VA = "0x1836F98F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8D7200", Offset = "0x8D6400", VA = "0x1808D7200")]
	public MELBKNINBEH(KCLMMCNCBHA COENACEECKL, FGKLHHEMEMB JCECDDPGEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x36F9940", Offset = "0x36F8B40", VA = "0x1836F9940", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FOALHFFEMEN))]
	public Task<bool> LLCGDCDDPAA(CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal interface CIHNBPNHBJC : JOHHDFEACJK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal interface MEMOKKFMPAN
{
	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> LLCGDCDDPAA(CancellationToken PLEKJLHDOLP);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface MAFKBFGMOCC
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBEJFOPHJKK(KFPGNDCOJCM HGAMMMFCKDF);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIEGJDMPJFB(KFPGNDCOJCM HGAMMMFCKDF);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDDOJABGAMK(KFPGNDCOJCM HGAMMMFCKDF);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INFEACJEKJL(KFPGNDCOJCM HGAMMMFCKDF);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class KFPGNDCOJCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public readonly MDCIINLFDMH LIIAGOAAJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Dictionary<string, string> LICKNOCKBHB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FDMIABHIEGI<string> HHPEMCMKDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C10", Offset = "0x8D6E10", VA = "0x1808D7C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A20", Offset = "0x8D6C20", VA = "0x1808D7A20")]
	public KFPGNDCOJCM(MDCIINLFDMH IBCKECGKAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x36EECD0", Offset = "0x36EDED0", VA = "0x1836EECD0")]
	public KFPGNDCOJCM APFPCHGOJLM(string PPNIGBBPGOI, string ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x36EEDB0", Offset = "0x36EDFB0", VA = "0x1836EEDB0")]
	public bool OLAFOLJBBLF(out IEnumerable<KeyValuePair<string, string>> BPLEMBJFIBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2FF7020", Offset = "0x2FF6220", VA = "0x182FF7020")]
	public KFPGNDCOJCM CEDJIADHLMP(FDMIABHIEGI<string> FIIEBNCLKIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class BBHNNLDGNMD : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x15BB320", Offset = "0x15BA520", VA = "0x1815BB320")]
	public BBHNNLDGNMD(string CEOMJLPEFPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public interface KOIGEBDLLEK
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MDCIINLFDMH EKHCKLMNKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ODLKOJAEFAL GIEKKMDEHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GONBIMCIPLJ KFGOCJMJONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool OFEOAOOAIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool KMPOIMNBDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	int NCJJBHBNKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action DOOJPPLPADD;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<int> MKGBKNINBJG;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BNPLDKFMHIC();

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.NBDPJBOGNGD> MAOPMEINLLF(long EGCEBLMJCKK, [Optional] CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.PNJEDKFHBKE> MJPJFOJFGEI();

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task NLCKDHPAPIM();

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(MDCIINLFDMH, KIPGPNOONJB) HGGJKMNGPKB();

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	POMIGJLEENF IJFDNNGNCLO();

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HKFAMDJGCGE(long EGCEBLMJCKK);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal interface IHCAMGNCBDI : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BLGLLGBBDII> ENMFHHDMMON(BLGLLGBBDII JFILJIAPEEP, NLAKPJCOMPN HJCCDBGIIJP, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<BLGLLGBBDII> NFBOKLMCAIL(CancellationToken PLEKJLHDOLP, NLAKPJCOMPN HJCCDBGIIJP);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPBMEMKDFAC GAELHNHGPJD(ILAIPNDOCNE GJLEIPPLCMJ, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DPBMEMKDFAC LMMAPDAJGIL(ILAIPNDOCNE GJLEIPPLCMJ, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class HEECOEDBPPI : KCLMMCNCBHA, MOGJDODAHJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class HIJOJONGNLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<NAKMMEJMOAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public COOLNBMBOGP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public HEECOEDBPPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private NAKMMEJMOAP <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private NAKMMEJMOAP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter<NAKMMEJMOAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HIJOJONGNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x4293250", Offset = "0x4292450", VA = "0x184293250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class MGENLNDHCHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public HEECOEDBPPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private NAKMMEJMOAP <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MGENLNDHCHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x429A7D0", Offset = "0x42999D0", VA = "0x18429A7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class CAIEGABPLKB : IEnumerable<JOHHDFEACJK>, IEnumerable, IEnumerator<JOHHDFEACJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private JOHHDFEACJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public HEECOEDBPPI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private JOHHDFEACJK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xECAD80", Offset = "0xEC9F80", VA = "0x180ECAD80")]
		[DebuggerHidden]
		public CAIEGABPLKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x428C600", Offset = "0x428B800", VA = "0x18428C600", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x428CA80", Offset = "0x428BC80", VA = "0x18428CA80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x428C9E0", Offset = "0x428BBE0", VA = "0x18428C9E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JOHHDFEACJK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x428C9E0", Offset = "0x428BBE0", VA = "0x18428C9E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private readonly CancellationTokenSource CMJBCGDGCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private readonly JLCNCEFHLIA HPKKDLHOJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private bool MIGKAMNMNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private PEFONGOIMGH OGALPMPKDPH;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public IPBPMMLOKDP JOBLGKBPLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8EE410", Offset = "0x8ED610", VA = "0x1808EE410", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x983E40", Offset = "0x983040", VA = "0x180983E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public AENCAKHMCBK GPJOFLHBLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BE0", Offset = "0x8D5DE0", VA = "0x1808D6BE0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x93C0C0", Offset = "0x93B2C0", VA = "0x18093C0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public FGKLHHEMEMB HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8EE420", Offset = "0x8ED620", VA = "0x1808EE420", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x93C0D0", Offset = "0x93B2D0", VA = "0x18093C0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GNHMLIMFFFL MCEDHNPFAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8EE430", Offset = "0x8ED630", VA = "0x1808EE430", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x93C0B0", Offset = "0x93B2B0", VA = "0x18093C0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public KIIBJKPFFHE JJOPCNBOICG
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3B0", Offset = "0x8ED5B0", VA = "0x1808EE3B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x900430", Offset = "0x8FF630", VA = "0x180900430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public KLELFNKDBNP PMJLLFNEFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3C0", Offset = "0x8ED5C0", VA = "0x1808EE3C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x90DFB0", Offset = "0x90D1B0", VA = "0x18090DFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public PHLPMAPMHHI LMOGHNNHHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x912480", Offset = "0x911680", VA = "0x180912480", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x90DF90", Offset = "0x90D190", VA = "0x18090DF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CNOMDHHEFIE EICGFCPLGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE60", Offset = "0x8DE060", VA = "0x1808DEE60", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x939B80", Offset = "0x938D80", VA = "0x180939B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public JKIJBDKIACB MPJDGLGBNIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF00", Offset = "0x8DE100", VA = "0x1808DEF00", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xABAFC0", Offset = "0xABA1C0", VA = "0x180ABAFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public JGOBHOBCPFC LMIDELFGGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x912450", Offset = "0x911650", VA = "0x180912450", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xABB1B0", Offset = "0xABA3B0", VA = "0x180ABB1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public IPDOADDBPPL EBDLKLOMCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3D0", Offset = "0x8ED5D0", VA = "0x1808EE3D0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x90DFA0", Offset = "0x90D1A0", VA = "0x18090DFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public HDMCFFBEMAE MKKJJNDHGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3E0", Offset = "0x8ED5E0", VA = "0x1808EE3E0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x932C20", Offset = "0x931E20", VA = "0x180932C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public KDJCIPGDMJL HJDNHKBLFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8EE400", Offset = "0x8ED600", VA = "0x1808EE400", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xB10A30", Offset = "0xB0FC30", VA = "0x180B10A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public GFPBNPJJDJN EJMJGMDJDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3F0", Offset = "0x8ED5F0", VA = "0x1808EE3F0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x90DFC0", Offset = "0x90D1C0", VA = "0x18090DFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public CIHNBPNHBJC IJMGJCBGELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xB0E240", Offset = "0xB0D440", VA = "0x180B0E240", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xB0E930", Offset = "0xB0DB30", VA = "0x180B0E930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NCCDKGMFIIF DOBFKBMKBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA7B690", Offset = "0xA7A890", VA = "0x180A7B690", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xB0E250", Offset = "0xB0D450", VA = "0x180B0E250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public BBMDBLLFADF JEAJKFDDHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x935BB0", Offset = "0x934DB0", VA = "0x180935BB0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public IDALKIAHADN HLLENGEOJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x82F320", Offset = "0x82E520", VA = "0x18082F320", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xB57F60", Offset = "0xB57160", VA = "0x180B57F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public IPDFLCGLIDF LHDBIPAKIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x990410", Offset = "0x98F610", VA = "0x180990410", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xABAFD0", Offset = "0xABA1D0", VA = "0x180ABAFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public IHCAMGNCBDI DNGHNIFJKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xABAB00", Offset = "0xAB9D00", VA = "0x180ABAB00", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xABAFE0", Offset = "0xABA1E0", VA = "0x180ABAFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public MINMGNDMHLI CCBJMFCGAAO
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xABAB10", Offset = "0xAB9D10", VA = "0x180ABAB10", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xABAFF0", Offset = "0xABA1F0", VA = "0x180ABAFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JKLCIGBBEGC FOLHHEPLLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xB0EBC0", Offset = "0xB0DDC0", VA = "0x180B0EBC0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xB0EEC0", Offset = "0xB0E0C0", VA = "0x180B0EEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public MAFKBFGMOCC MDAENENCGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xB58BC0", Offset = "0xB57DC0", VA = "0x180B58BC0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x1775730", Offset = "0x1774930", VA = "0x181775730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public GNJHADANBGP GLNHHPDHHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xB0EEA0", Offset = "0xB0E0A0", VA = "0x180B0EEA0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xB0F010", Offset = "0xB0E210", VA = "0x180B0F010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public DNEAHMCJOPM FBIBJALJIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xB0EEB0", Offset = "0xB0E0B0", VA = "0x180B0EEB0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xB0F020", Offset = "0xB0E220", VA = "0x180B0F020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public NJLAOLIOPMC IMIBPEAOPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xE6D680", Offset = "0xE6C880", VA = "0x180E6D680", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xE6CD20", Offset = "0xE6BF20", VA = "0x180E6CD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public JIMOFDHDMFE CODCAGIKHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xABAB60", Offset = "0xAB9D60", VA = "0x180ABAB60", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xFB3A10", Offset = "0xFB2C10", VA = "0x180FB3A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public KPAJKDAICAP MBJJEALLBBL
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xABAB40", Offset = "0xAB9D40", VA = "0x180ABAB40", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public MPIGEJNPJHM DOLFEHDMPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x19CDDE0", Offset = "0x19CCFE0", VA = "0x1819CDDE0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public AOCCOOPEIPL BBOOCDDCJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xABACA0", Offset = "0xAB9EA0", VA = "0x180ABACA0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public KIPGPNOONJB NEEHJJMBIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xABAC30", Offset = "0xAB9E30", VA = "0x180ABAC30", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1D04380", Offset = "0x1D03580", VA = "0x181D04380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private bool EBAKKMEFBJB
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2D28A30", Offset = "0x2D27C30", VA = "0x182D28A30", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private bool GHMOHGNCFCM
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2D27EC0", Offset = "0x2D270C0", VA = "0x182D27EC0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Task JJONNMMAJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2D27E70", Offset = "0x2D27070", VA = "0x182D27E70", Slot = "49")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private CancellationToken ANAPGNKGDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2D28000", Offset = "0x2D27200", VA = "0x182D28000", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private JLCNCEFHLIA MOOGBDMDHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action GHINCEJHMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2D283E0", Offset = "0x2D275E0", VA = "0x182D283E0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2D28AA0", Offset = "0x2D27CA0", VA = "0x182D28AA0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event FBNDGCEMMGM DFCCGBGJBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2D28650", Offset = "0x2D27850", VA = "0x182D28650", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2D28BF0", Offset = "0x2D27DF0", VA = "0x182D28BF0", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event FBNDGCEMMGM FCIPLKFLLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2D28440", Offset = "0x2D27640", VA = "0x182D28440", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2D281B0", Offset = "0x2D273B0", VA = "0x182D281B0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event FBNDGCEMMGM LHDAEEIAOBG
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2D286B0", Offset = "0x2D278B0", VA = "0x182D286B0", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2D28710", Offset = "0x2D27910", VA = "0x182D28710", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<GJBJJHDBNNK, bool> ILAKKHDOKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2D28A40", Offset = "0x2D27C40", VA = "0x182D28A40", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2D27FA0", Offset = "0x2D271A0", VA = "0x182D27FA0", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1D04380", Offset = "0x1D03580", VA = "0x181D04380", Slot = "36")]
	public void NCNNMLGDKJA(KIPGPNOONJB BFJMPNHBNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2D28CA0", Offset = "0x2D27EA0", VA = "0x182D28CA0")]
	[UnityEngine.Scripting.Preserve]
	internal HEECOEDBPPI([IDNKOMINBGM(null)] JLCNCEFHLIA HPKKDLHOJJI, [IDNKOMINBGM(null)] IPBPMMLOKDP BIHEKONDPKH, [IDNKOMINBGM(null)] AENCAKHMCBK EICMDGFKLMM, [IDNKOMINBGM(null)] FGKLHHEMEMB JCECDDPGEKA, [IDNKOMINBGM(null)] GNHMLIMFFFL DEPEKOBAGGK, [IDNKOMINBGM(null)] KIIBJKPFFHE GDDMBMEBKPJ, [IDNKOMINBGM(null)] KLELFNKDBNP OCHOGPMKPDB, [IDNKOMINBGM(null)] PHLPMAPMHHI CFKKPPPPOKL, [IDNKOMINBGM(null)] CNOMDHHEFIE PFPAIKIAJAO, [IDNKOMINBGM(null)] JKIJBDKIACB IINOJLBGGDJ, [IDNKOMINBGM(null)] JGOBHOBCPFC GICHEILONDH, [IDNKOMINBGM(null)] IPDOADDBPPL DCPLGDEFGGM, [IDNKOMINBGM(null)] HDMCFFBEMAE HFAJEOBGPNH, [IDNKOMINBGM(null)] KDJCIPGDMJL NOPNKEBPJIN, [IDNKOMINBGM(null)] GFPBNPJJDJN LKLMKNNGJEB, [IDNKOMINBGM(null)] CIHNBPNHBJC HONFBNJGJPA, [IDNKOMINBGM(null)] NCCDKGMFIIF NGNGGAHJGED, [IDNKOMINBGM(null)] BBMDBLLFADF PALIMGMPOCJ, [IDNKOMINBGM(null)] IDALKIAHADN BEJKKLHAJKD, [IDNKOMINBGM(null)] IPDFLCGLIDF BPNKNGPNKBA, [IDNKOMINBGM(null)] MINMGNDMHLI MPPOMBDOCPC, [IDNKOMINBGM(null)] IHCAMGNCBDI IKGLEHGFGJO, [IDNKOMINBGM(null)] JKLCIGBBEGC MFNJCMHILGM, [IDNKOMINBGM(null)] MAFKBFGMOCC PFDMDEBCPEP, [IDNKOMINBGM(null)] GNJHADANBGP HOHANAPHNGF, [IDNKOMINBGM(null)] NJLAOLIOPMC PEPOGGMJFLC, [IDNKOMINBGM(null)] JIMOFDHDMFE ELKAHKMLMLL, [IDNKOMINBGM(null)] KPAJKDAICAP IBBPLGCPKFC, [IDNKOMINBGM(null)] MPIGEJNPJHM JDJNHODIMIO, [IDNKOMINBGM(null)] AOCCOOPEIPL MPPAGFGEBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2D28B00", Offset = "0x2D27D00", VA = "0x182D28B00")]
	private void OHLMLHJNBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2D28020", Offset = "0x2D27220", VA = "0x182D28020", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x2D28C50", Offset = "0x2D27E50", VA = "0x182D28C50", Slot = "50")]
	private void PNKBIFKLGMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2D284A0", Offset = "0x2D276A0", VA = "0x182D284A0", Slot = "51")]
	private DGGNNJGLDCH IECBAEDDGFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2D28210", Offset = "0x2D27410", VA = "0x182D28210", Slot = "52")]
	private DHEDDELEOOF GDBDLKKAMBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2D288C0", Offset = "0x2D27AC0", VA = "0x182D288C0", Slot = "53")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HIJOJONGNLE))]
	private Task<NAKMMEJMOAP> LAHHHLAANOL(COOLNBMBOGP CGJKBLJLHJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2D28770", Offset = "0x2D27970", VA = "0x182D28770", Slot = "54")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGENLNDHCHO))]
	private Task KPFHNKIGNEF(CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x2D285E0", Offset = "0x2D277E0", VA = "0x182D285E0")]
	[IteratorStateMachine(typeof(CAIEGABPLKB))]
	private IEnumerable<JOHHDFEACJK> IFMPOAJCMKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2D27F40", Offset = "0x2D27140", VA = "0x182D27F40")]
	[CompilerGenerated]
	private void CJJNPABNKNK(JOHHDFEACJK FEFGGGJBLPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class JMHNFCHBPKE : IPDFLCGLIDF, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class LGDFKMOAMCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AsyncTaskMethodBuilder<IHKLGONHBKF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public MDCIINLFDMH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public JMHNFCHBPKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private ODLKOJAEFAL <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private ODLKOJAEFAL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<ODLKOJAEFAL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LGDFKMOAMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x4299580", Offset = "0x4298780", VA = "0x184299580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class MJCFPICGJPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MJCFPICGJPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x429AE60", Offset = "0x429A060", VA = "0x18429AE60")]
		internal object AKNOJFNEADH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class MNKMLPIKEAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public AsyncTaskMethodBuilder<ODLKOJAEFAL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public MDCIINLFDMH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public JMHNFCHBPKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private MJCFPICGJPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private ODLKOJAEFAL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<ODLKOJAEFAL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MNKMLPIKEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x429AF10", Offset = "0x429A110", VA = "0x18429AF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class OHKFLMCBMBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OHKFLMCBMBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x10CF3A0", Offset = "0x10CE5A0", VA = "0x1810CF3A0")]
		internal bool NKCKJPPINLO(GONBIMCIPLJ sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private FGKLHHEMEMB JCECDDPGEKA;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private static readonly (DLJGDNEKCBH superRoomData, long subRoomDataSaveId) JABOHFKFAHN;

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x36EC150", Offset = "0x36EB350", VA = "0x1836EC150", Slot = "5")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x36EC550", Offset = "0x36EB750", VA = "0x1836EC550", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LGDFKMOAMCL))]
	public Task<IHKLGONHBKF> PIHPKNEFFDE(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, MDCIINLFDMH OGJNPFMLCHO, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x36EBE40", Offset = "0x36EB040", VA = "0x1836EBE40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MNKMLPIKEAK))]
	private Task<ODLKOJAEFAL> LECJOHDJHCL(MDCIINLFDMH OGJNPFMLCHO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x36EC000", Offset = "0x36EB200", VA = "0x1836EC000")]
	private IHKLGONHBKF MNFCFIJEFOO(MDCIINLFDMH OGJNPFMLCHO, ODLKOJAEFAL MGAFFPBPBBG, long GLLEENOIFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x36EC1C0", Offset = "0x36EB3C0", VA = "0x1836EC1C0")]
	private (DLJGDNEKCBH, long) OOPPLMFMOOP(MDCIINLFDMH OGJNPFMLCHO, ODLKOJAEFAL MGAFFPBPBBG, long GLLEENOIFOJ)
	{
		return default((DLJGDNEKCBH, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public JMHNFCHBPKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface GNHMLIMFFFL
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool GGAOCAGANFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	string AMCFNKPBLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGDAPPAJCGG(Scene IJCMADLMCPP);

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BAKGNJGNDGE(AAMJDAPOEFN BDENOCCMJBK, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HKHNJLIFBIG();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[UnityEngine.Scripting.Preserve]
internal sealed class CEOKKOKDNDA : IHCAMGNCBDI, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class NHLCLDCILDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public BLGLLGBBDII request;

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NHLCLDCILDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x42C4270", Offset = "0x42C3470", VA = "0x1842C4270")]
		internal object EOFPEDAMAAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class BOHFPLCFOBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AsyncTaskMethodBuilder<BLGLLGBBDII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public BLGLLGBBDII request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public NLAKPJCOMPN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public CEOKKOKDNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private NHLCLDCILDO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private BLGLLGBBDII <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private BLGLLGBBDII <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private TaskAwaiter<BLGLLGBBDII> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BOHFPLCFOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x42B6BC0", Offset = "0x42B5DC0", VA = "0x1842B6BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class AKCJCGKFIOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public AsyncTaskMethodBuilder<BLGLLGBBDII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public NLAKPJCOMPN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public CEOKKOKDNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private LIAOPDCMOJN.AGGGIDDBOGP<BLGLLGBBDII> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private AHKCMHOBILL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private TaskAwaiter<AHKCMHOBILL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public AKCJCGKFIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x42B4E30", Offset = "0x42B4030", VA = "0x1842B4E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class JBCDKMLIGOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public BLGLLGBBDII request;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JBCDKMLIGOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x42C0420", Offset = "0x42BF620", VA = "0x1842C0420")]
		internal object MELNJMDECBC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class CEAEEIDMBBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public AsyncTaskMethodBuilder<BLGLLGBBDII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public BLGLLGBBDII request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public NLAKPJCOMPN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CEOKKOKDNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private JBCDKMLIGOD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private PIPBFFKIFBF <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private MLIGIHCHAAG <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private LIAOPDCMOJN.AGGGIDDBOGP<BLGLLGBBDII> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private BLGLLGBBDII <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private PIPBFFKIFBF <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private AHKCMHOBILL <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter<AHKCMHOBILL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CEAEEIDMBBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x42B73A0", Offset = "0x42B65A0", VA = "0x1842B73A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private IPBPMMLOKDP BIHEKONDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private DNEAHMCJOPM NJMJFMJMKDH;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private LIAOPDCMOJN JNDDJJFOCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D12AB0", Offset = "0x2D11CB0", VA = "0x182D12AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2D12F80", Offset = "0x2D12180", VA = "0x182D12F80", Slot = "8")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2D12670", Offset = "0x2D11870", VA = "0x182D12670", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BOHFPLCFOBG))]
	public Task<BLGLLGBBDII> ENMFHHDMMON(BLGLLGBBDII JFILJIAPEEP, NLAKPJCOMPN HJCCDBGIIJP, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2D12DE0", Offset = "0x2D11FE0", VA = "0x182D12DE0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AKCJCGKFIOK))]
	public Task<BLGLLGBBDII> NFBOKLMCAIL(CancellationToken PLEKJLHDOLP, NLAKPJCOMPN HJCCDBGIIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2D12830", Offset = "0x2D11A30", VA = "0x182D12830", Slot = "6")]
	public DPBMEMKDFAC GAELHNHGPJD(ILAIPNDOCNE GJLEIPPLCMJ, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2D12B60", Offset = "0x2D11D60", VA = "0x182D12B60", Slot = "7")]
	public DPBMEMKDFAC LMMAPDAJGIL(ILAIPNDOCNE GJLEIPPLCMJ, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2D13010", Offset = "0x2D12210", VA = "0x182D13010")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CEAEEIDMBBL))]
	private Task<BLGLLGBBDII> OKCKIIAFKDO(BLGLLGBBDII JFILJIAPEEP, NLAKPJCOMPN HJCCDBGIIJP, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C290", Offset = "0x2C0B490", VA = "0x182C0C290")]
	private static byte[] KMKIJLNPLLC(BLGLLGBBDII CEOMJLPEFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2D12570", Offset = "0x2D11770", VA = "0x182D12570")]
	private static string CGBFLKDOFNI(byte[] ANPLPNKHBJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CEOKKOKDNDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public readonly struct DOFFIKKHBFE<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class MILMGFNPMLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public AsyncTaskMethodBuilder<CLFKONEBOLH<KBFBKOAJJMK<TData>, PIHDIMJPEHH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public DOFFIKKHBFE<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private CLFKONEBOLH<byte[], PIHDIMJPEHH> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private CLFKONEBOLH<byte[], PIHDIMJPEHH> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private TaskAwaiter<CLFKONEBOLH<byte[], PIHDIMJPEHH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public MILMGFNPMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x30C1C20", Offset = "0x30C0E20", VA = "0x1830C1C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private readonly BILFFCGDFHA<TGetDataArg, TData> APHBGODKBHN;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xD48AD0", Offset = "0xD47CD0", VA = "0x180D48AD0")]
	internal DOFFIKKHBFE(BILFFCGDFHA<TGetDataArg, TData> FLJLOPPINOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2EDAF60", Offset = "0x2EDA160", VA = "0x182EDAF60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DOFFIKKHBFE<, >.MILMGFNPMLA))]
	public Task<CLFKONEBOLH<KBFBKOAJJMK<TData>, PIHDIMJPEHH>> OEPHOMDCHIG(TGetDataArg ANPLPNKHBJM, string ABFHDCNLLAC, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class NLGHBHHICGJ
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2FEDCD0", Offset = "0x2FECED0", VA = "0x182FEDCD0")]
	public static DOFFIKKHBFE<TGetDataArg, TData> NMBJFIHLDEO<TGetDataArg, TData>(BILFFCGDFHA<TGetDataArg, TData> FLJLOPPINOK)
	{
		return default(DOFFIKKHBFE<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[UnityEngine.Scripting.Preserve]
internal sealed class AKGAPAJEFNA : IDALKIAHADN, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class KLIHBBLJFHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public APGCGMGDIIP operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AKGAPAJEFNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public BLGLLGBBDII roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KLIHBBLJFHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x36F0240", Offset = "0x36EF440", VA = "0x1836F0240")]
		internal object CAHJKCMIHBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x36F02B0", Offset = "0x36EF4B0", VA = "0x1836F02B0")]
		internal object MBLDEFKIJCK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class OOOHCMANEBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder<NAKMMEJMOAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public BLGLLGBBDII roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public AKGAPAJEFNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private KLIHBBLJFHH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private NAKMMEJMOAP <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private NAKMMEJMOAP <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private TaskAwaiter<NAKMMEJMOAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OOOHCMANEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x36FC510", Offset = "0x36FB710", VA = "0x1836FC510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class LMPJGDDHJIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public APGCGMGDIIP operationType;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LMPJGDDHJIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x36F5700", Offset = "0x36F4900", VA = "0x1836F5700")]
		internal object NNPFJOINGNE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class GNOGLKAIJLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public BLGLLGBBDII request;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GNOGLKAIJLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x36EB4D0", Offset = "0x36EA6D0", VA = "0x1836EB4D0")]
		internal object HCOGIALPOBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x36EB550", Offset = "0x36EA750", VA = "0x1836EB550")]
		internal object IDCDEPNFFDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x36EB450", Offset = "0x36EA650", VA = "0x1836EB450")]
		internal object DACMILKKGGM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class CFPNKHCFBJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder<NAKMMEJMOAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public BLGLLGBBDII request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public AKGAPAJEFNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private GNOGLKAIJLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private HOJCCABHALO <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private NAKMMEJMOAP <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private (NAKMMEJMOAP validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private (NAKMMEJMOAP validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter<(NAKMMEJMOAP validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CFPNKHCFBJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x36E9170", Offset = "0x36E8370", VA = "0x1836E9170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private IPBPMMLOKDP BIHEKONDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private JKLCIGBBEGC MFNJCMHILGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private BBMDBLLFADF PALIMGMPOCJ;

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C0A0", Offset = "0x2D0B2A0", VA = "0x182D0C0A0", Slot = "5")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C150", Offset = "0x2D0B350", VA = "0x182D0C150", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OOOHCMANEBH))]
	private Task<NAKMMEJMOAP> OKFKMOFJMFK(BLGLLGBBDII CCFNHFGLHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BCA0", Offset = "0x2D0AEA0", VA = "0x182D0BCA0")]
	private bool EGEOMIMHNMF(APGCGMGDIIP EEIOBIJNMEC, out NAKMMEJMOAP GAFKIBJKPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BF30", Offset = "0x2D0B130", VA = "0x182D0BF30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CFPNKHCFBJO))]
	private Task<NAKMMEJMOAP> MKANOOAKEKA(BLGLLGBBDII JFILJIAPEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public AKGAPAJEFNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class HPIJGDAHIFI
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public static NAKMMEJMOAP OIDOEPMEFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2D29EF0", Offset = "0x2D290F0", VA = "0x182D29EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2D29F60", Offset = "0x2D29160", VA = "0x182D29F60")]
	public static bool MMMCCHMOIOO(this NAKMMEJMOAP FGPPDHPBHPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2D29E80", Offset = "0x2D29080", VA = "0x182D29E80")]
	public static NAKMMEJMOAP ADMJACNIILE(PLDGKALNBGG MJPJFJGLNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2D29F50", Offset = "0x2D29150", VA = "0x182D29F50")]
	public static NAKMMEJMOAP GOFHDDIDGLC(params NAKMMEJMOAP[] JKMCCNHNGFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D29F90", Offset = "0x2D29190", VA = "0x182D29F90")]
	public static NAKMMEJMOAP OEJMNFANAGG(IEnumerable<NAKMMEJMOAP> JKMCCNHNGFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A1B0", Offset = "0x2D293B0", VA = "0x182D2A1B0")]
	public static string OIEPIBDBHHK(this NAKMMEJMOAP GAFKIBJKPNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[UnityEngine.Scripting.Preserve]
internal sealed class JKKLCODDEJF : JKLCIGBBEGC, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private KIIBJKPFFHE GDDMBMEBKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private IPBPMMLOKDP BIHEKONDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private CNOMDHHEFIE PFPAIKIAJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private MINMGNDMHLI MPPOMBDOCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private FGKLHHEMEMB JCECDDPGEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private HDMCFFBEMAE HFAJEOBGPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private KDJCIPGDMJL NOPNKEBPJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private NJLAOLIOPMC PEPOGGMJFLC;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private KOIGEBDLLEK PJNHDMFJAGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D380", Offset = "0x2D2C580", VA = "0x182D2D380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private static NAKMMEJMOAP OIDOEPMEFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x2D29EF0", Offset = "0x2D290F0", VA = "0x182D29EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D2D3D0", Offset = "0x2D2C5D0", VA = "0x182D2D3D0", Slot = "7")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CFA0", Offset = "0x2D2C1A0", VA = "0x182D2CFA0", Slot = "4")]
	public NAKMMEJMOAP GJMPMGNLBPP(NBDCAKCJOHF ABACAIJJLIF, APGCGMGDIIP DILEKOOCNPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CCB0", Offset = "0x2D2BEB0", VA = "0x182D2CCB0", Slot = "5")]
	public NAKMMEJMOAP BECHIAGPJAF(NBDCAKCJOHF KCAAIIKABAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D2D130", Offset = "0x2D2C330", VA = "0x182D2D130", Slot = "6")]
	public NAKMMEJMOAP HBLEPKFCLKD(NBDCAKCJOHF KCAAIIKABAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2D29E80", Offset = "0x2D29080", VA = "0x182D29E80")]
	private static NAKMMEJMOAP ADMJACNIILE(PLDGKALNBGG CPFOGLIOEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public JKKLCODDEJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public delegate Task KJDACGGJIOE(FEKMMALKIBN ALBGHDBNPBA, CancellationToken IBIKCCMDMHA);
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal interface KDJCIPGDMJL : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool PLNLPJNAADK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IDNJLPLMKAH(KJDACGGJIOE FOAKBMILDFL);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface GNJHADANBGP
{
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JILHAEHHICL(out IEnumerable<int> JCMOMGFFJEB);

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKLGPNILKPK(NNFJPPGGOPL IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIKOAHMEACJ(NNFJPPGGOPL IBIKCCMDMHA);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface DBPHNLENJJE
{
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LDFCPCCJGDM(NAKMMEJMOAP FGPPDHPBHPL);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal interface IDALKIAHADN : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NAKMMEJMOAP> HLLENGEOJKP(BLGLLGBBDII CCFNHFGLHCD);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal interface KCLMMCNCBHA : MOGJDODAHJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	CancellationToken MJIJBDPOFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	JLCNCEFHLIA DCCLFJBDDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	IPBPMMLOKDP JOBLGKBPLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	AENCAKHMCBK GPJOFLHBLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	FGKLHHEMEMB HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	GNHMLIMFFFL MCEDHNPFAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	KIIBJKPFFHE JJOPCNBOICG
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	KLELFNKDBNP PMJLLFNEFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	PHLPMAPMHHI LMOGHNNHHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	CNOMDHHEFIE EICGFCPLGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	JKIJBDKIACB MPJDGLGBNIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	JGOBHOBCPFC LMIDELFGGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	IPDOADDBPPL EBDLKLOMCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	HDMCFFBEMAE MKKJJNDHGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	KDJCIPGDMJL HJDNHKBLFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	GFPBNPJJDJN EJMJGMDJDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	CIHNBPNHBJC IJMGJCBGELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	NCCDKGMFIIF DOBFKBMKBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	BBMDBLLFADF JEAJKFDDHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	IDALKIAHADN HLLENGEOJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	IPDFLCGLIDF LHDBIPAKIPM
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	IHCAMGNCBDI DNGHNIFJKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	MINMGNDMHLI CCBJMFCGAAO
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	JKLCIGBBEGC FOLHHEPLLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	MAFKBFGMOCC MDAENENCGIB
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	GNJHADANBGP GLNHHPDHHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	DNEAHMCJOPM FBIBJALJIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	NJLAOLIOPMC IMIBPEAOPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	JIMOFDHDMFE CODCAGIKHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	KPAJKDAICAP MBJJEALLBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	MPIGEJNPJHM DOLFEHDMPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	AOCCOOPEIPL BBOOCDDCJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void NCNNMLGDKJA(KIPGPNOONJB BFJMPNHBNHD);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal interface IPDOADDBPPL : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NFHICOAFCNK();

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIIEFGHGIHK();

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFPEABENKGO();
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class HBALLCLMBIK
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2D26E20", Offset = "0x2D26020", VA = "0x182D26E20")]
	public static void HFJFHLHDMEM(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2D27100", Offset = "0x2D26300", VA = "0x182D27100")]
	internal static void PCHHHCEENAK(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2D27020", Offset = "0x2D26220", VA = "0x182D27020")]
	internal static void JJCIIJPPKHG(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2D269D0", Offset = "0x2D25BD0", VA = "0x182D269D0")]
	internal static void BDMJOPHNCKK(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class OAEADDDKMKK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x36FBCB0", Offset = "0x36FAEB0", VA = "0x1836FBCB0")]
	public OAEADDDKMKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xE71680", Offset = "0xE70880", VA = "0x180E71680")]
	public OAEADDDKMKK(string CEOMJLPEFPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal interface JOHHDFEACJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface FGKLHHEMEMB
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	KOIGEBDLLEK PJNHDMFJAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	int NCJJBHBNKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	bool PBDIAKBJPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool ALJMHJAGCDO
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	bool KLIOFEALBGG
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool IDDDPNOOJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	NBDCAKCJOHF POMNKEBNHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool NALCCFFMOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	float OIDHLHGNEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event Action<float> DJBELOJPHAC;

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JLCNCEFHLIA EEAIAODKKOM(JLCNCEFHLIA LCOCKHBLJDI);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MGLFKIHMDIE(JLCNCEFHLIA HPKKDLHOJJI);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GFAHNNCGBMI();

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task LGCBLFAGEJL(FDMIABHIEGI<string>.JOOBNAKNCND GKLGBCMHEGP, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LOFDGPDNJNI(float OANMHFDLEKL);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KBMBCDJKMPP(string ABEFDBJEOBE);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IReadOnlyList<BDCIMDEJCKC> DIKOEAAEAEM();

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDisposable OLCGOJPBIID(object APPLJOFCBIB, BDCIMDEJCKC FOJNDMIMLDK);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PJHLEBGLDJJ DFJHONADHCA(IEnumerable<LLLPGKDBIPO> FIALEMGCPMI);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HLKJAEENING(int PJFLCBPHEFP);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task FMLFMDENGPB();

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JAOAKAMKMIH();

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool NCIPHNAHLCO();

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task APGNBGOPING(CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task DAAJLEEGHLI(CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<PELNDJMPAIB> PGGEKEKOAEK(DateTime BDJKODBDKBP, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> ABKBBGLKHJL(CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GEAJDBFGKGN();

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "23")]
	AMCNICLCIHB DPLDDGECBBD(CNHIGFDMMEB IEHGKJOAHNI, PIKKGCCILDN AGIBBHKKBME, IEnumerable<PersistenceView> AENEAMCMGKB, IOHKDEOFJPL NMEEMMJAGGE);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MGHPGJDEMHM(PIKKGCCILDN AGIBBHKKBME);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void DFKBFHPGJGE(LLLPGKDBIPO LOAEFHPBAMF, in AMCNICLCIHB EJGLCDFFPME);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task COAFKOKLPID(PIKKGCCILDN PNICJAKMKDO, bool CFDBMHIBLHO, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task ABLGHONKOCN(CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FKIOFDBAOKB(long LNBFDCAEKJF, long HGPBCNPIJHG, ODLKOJAEFAL NLENBJFJHPJ, KCDJMIOEEPA ENDKLAPPJNP, FAPAGDCIGJE ACEDMDLCIME, HGOCCJHPOPO? HHMDLJJBABE, HHMNCCHMPGB? PMAEPBFCDMH);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void AMPAOCHFHIK(long LNBFDCAEKJF, long HGPBCNPIJHG, HHMNCCHMPGB? PMAEPBFCDMH);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void PLCCGOFPNAK(PersistenceView POOAJHHIDGN);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool OLLAHCFPPGK(PersistenceView EGALACPJCAA);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool JIECIBGPJAJ(LLLPGKDBIPO LOAEFHPBAMF, OALBBBOJDGP BONMCPNGJKJ, out PLEENCLLJNN GJLHONGLCDF);

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task CHLJNAODIJN(CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void LOODCHMCODI();

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable JKDJHCJCMFF();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void AELCMHACHEI(PIKKGCCILDN PNICJAKMKDO, OALBBBOJDGP BONMCPNGJKJ);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> KHHGDHIPAKI(IPBPMMLOKDP BIHEKONDPKH, CancellationToken PLEKJLHDOLP, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void DEDDNEFHAEF(CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<FELEHJCEPLI> LNGHGMJJPKA(NGHCPPHCGII JFILJIAPEEP);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<ODLKOJAEFAL> GLOMBJHIJEN(long LNBFDCAEKJF, bool HFLLEGLICAB, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<KCDJMIOEEPA> LINJCEBELDE(long LNBFDCAEKJF, long HGPBCNPIJHG, long FLFKBNIMKBB, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<LDOOKNNGNOF> HNABNPBAHKC(string DPPPGPGBEBC, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<LDOOKNNGNOF> GHIEFHNDLMD(string DPPPGPGBEBC, long LNBFDCAEKJF, long HGPBCNPIJHG, string KBBAHAIKDJO, KNEBJLHEJJD.MMAHHCEEOGD ALBGHDBNPBA, KNEBJLHEJJD.MMAHHCEEOGD ECMLCDIPEEO, int IBNBKGICHHN);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool ELFGNPKHHHC();

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool PEJPCKCLNGC();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool NKELJPNEGIN(IEnumerable<PLEENCLLJNN> ELPIMJDGFIE);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void IOEHLNNEPPA(List<GameObject> BAMMDELJOOM);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float LJDFFOOKEDI();

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool BEFLJLJMKNE(string BHNAPHDEPMN, out Scene EPBAFGFEGFJ);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> JIJKHEABPEC(string BHNAPHDEPMN, LoadSceneMode BODPDDJOFLM, bool AEFHNDBCMIG, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void CHDHJGFDLKE();

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool JIPBBCEMEHN(ByteString CFOODOIEFBB);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void AFDOFIOFDMA();

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void PEONONDKBEJ();

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void ADMLAJOIIBL(MDCIINLFDMH EDMNGDGPOBH);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "62")]
	Task HMCNCGAFJPN(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task LHHIIGAPBDL(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task BKAMNELAMKI(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void MICFNIMKOGN();

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "66")]
	IDisposable DHHIDKPKODL();

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "67")]
	JJKPEJNDAHF PDBJJEDNKDA();

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task JGFMGMFHPCN(CancellationToken PLEKJLHDOLP);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public interface JJKPEJNDAHF
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JBEKKELJHEH(CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FPILGCEHCEH(CancellationToken PLEKJLHDOLP);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct AMCNICLCIHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public HashSet<int> PLMDNABDAHL;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum PELNDJMPAIB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class BGNPONLDNAK
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class IDEGKAEIJHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public MBPNBFDACPD finalTimerLogFlags;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public IDEGKAEIJHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x36EB5D0", Offset = "0x36EA7D0", VA = "0x1836EB5D0")]
		internal void PKNPLPMNFMD(JJCILEKGKNO t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class FPAHFINEMEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public FDMIABHIEGI<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FPAHFINEMEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x36EB3D0", Offset = "0x36EA5D0", VA = "0x1836EB3D0")]
		internal object CHNPAFPFEIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public const string APMAIEAPGKE = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public const string PJEKLIENAPH = "END: ";

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CF70", Offset = "0x2D0C170", VA = "0x182D0CF70")]
	public static FDMIABHIEGI<string> BPHMPGEDHEP([Optional] string DIFHJJLNJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CE60", Offset = "0x2D0C060", VA = "0x182D0CE60")]
	public static FDMIABHIEGI<string> BPHMPGEDHEP(MBPNBFDACPD JDOMMIHLGEI, [Optional] string DIFHJJLNJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D2D0", Offset = "0x2D0C4D0", VA = "0x182D0D2D0")]
	private static void NJMDPCGLGEG(string PPNIGBBPGOI, FDMIABHIEGI<string>.AGKEECKOJAL FIIEBNCLKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D1C0", Offset = "0x2D0C3C0", VA = "0x182D0D1C0")]
	private static void MDICJJFPEGB(string PPNIGBBPGOI, FDMIABHIEGI<string>.AGKEECKOJAL FIIEBNCLKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D3E0", Offset = "0x2D0C5E0", VA = "0x182D0D3E0")]
	public static void ODOMNDPOMGO(FDMIABHIEGI<string> FIIEBNCLKIG, MBPNBFDACPD ALHJKEONHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D0E0", Offset = "0x2D0C2E0", VA = "0x182D0D0E0")]
	public static string CFNKPMBNKDC(BLGLLGBBDII CCFNHFGLHCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[UnityEngine.Scripting.Preserve]
internal class LOCAKPAKAPL : KDJCIPGDMJL, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class FLGAIIBGGIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public FEKMMALKIBN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public LOCAKPAKAPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private Func<CancellationToken, List<Task>> <taskGenerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FLGAIIBGGIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5C342C0", Offset = "0x5C334C0", VA = "0x185C342C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class ICJOGCEIOCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public LOCAKPAKAPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public FEKMMALKIBN roomData;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public ICJOGCEIOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x5C36320", Offset = "0x5C35520", VA = "0x185C36320")]
		internal List<Task> KIJKEGHOOEK(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class FOBLBPCJFFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public KJDACGGJIOE taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public LOCAKPAKAPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FOBLBPCJFFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x5C351D0", Offset = "0x5C343D0", VA = "0x185C351D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class ENKBIMKLHKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public LOCAKPAKAPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public ENKBIMKLHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5C34040", Offset = "0x5C33240", VA = "0x185C34040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private readonly HashSet<KJDACGGJIOE> ELKJKACKGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private AENCAKHMCBK EICMDGFKLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private BDCIMDEJCKC IPPABCAAMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private GEMPBMIOHGA NNLHIBJOGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private IDisposable CPFFJOKLIKB;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool PLNLPJNAADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x36F77C0", Offset = "0x36F69C0", VA = "0x1836F77C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	internal Task JNAAGNCIBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x36F7F40", Offset = "0x36F7140", VA = "0x1836F7F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x36F8380", Offset = "0x36F7580", VA = "0x1836F8380", Slot = "6")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x36F7760", Offset = "0x36F6960", VA = "0x1836F7760", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x36F7EE0", Offset = "0x36F70E0", VA = "0x1836F7EE0", Slot = "5")]
	public bool IDNJLPLMKAH(KJDACGGJIOE FOAKBMILDFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x36F8050", Offset = "0x36F7250", VA = "0x1836F8050")]
	private void NCAJENKGNPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x36F7340", Offset = "0x36F6540", VA = "0x1836F7340")]
	private void CDHBBDPPCHP(FEKMMALKIBN ALBGHDBNPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x36F77D0", Offset = "0x36F69D0", VA = "0x1836F77D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FLGAIIBGGIK))]
	private Task FLDNODELIDG(FEKMMALKIBN ALBGHDBNPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x36F82A0", Offset = "0x36F74A0", VA = "0x1836F82A0")]
	private Func<CancellationToken, List<Task>> NGHGLIJMFIE(FEKMMALKIBN ALBGHDBNPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x36F7920", Offset = "0x36F6B20", VA = "0x1836F7920")]
	private List<Task> IAAILHBPAKD(FEKMMALKIBN ALBGHDBNPBA, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x36F71A0", Offset = "0x36F63A0", VA = "0x1836F71A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FOBLBPCJFFF))]
	private Task BBKALPMFNDL(KJDACGGJIOE EENKNAANHHA, FEKMMALKIBN JCEJEOAKGOJ, CancellationToken IBIKCCMDMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x36F7640", Offset = "0x36F6840", VA = "0x1836F7640")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ENKBIMKLHKA))]
	private Task DBJKBAOPAHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x36F7F50", Offset = "0x36F7150", VA = "0x1836F7F50")]
	private void LFPEABENKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x36F8650", Offset = "0x36F7850", VA = "0x1836F8650")]
	public LOCAKPAKAPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal interface CNOMDHHEFIE : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool GEJCDPPHIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Task GMBJDDFIAPC
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFMDEGIFGKN(Task ONPFLGLLMLP, string FLOAPHEDMCI);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class MPNBEBHJLPI : MEMOKKFMPAN
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class OIHIIPPKEBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public MPNBEBHJLPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OIHIIPPKEBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5C39040", Offset = "0x5C38240", VA = "0x185C39040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly FGKLHHEMEMB JCECDDPGEKA;

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x8D7200", Offset = "0x8D6400", VA = "0x1808D7200")]
	public MPNBEBHJLPI(KCLMMCNCBHA COENACEECKL, FGKLHHEMEMB JCECDDPGEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x36FA830", Offset = "0x36F9A30", VA = "0x1836FA830", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OIHIIPPKEBA))]
	public Task<bool> LLCGDCDDPAA(CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x36FA9A0", Offset = "0x36F9BA0", VA = "0x1836FA9A0")]
	[CompilerGenerated]
	private object OENFJIFMLOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class AJICKMPHHOG : EJAEMFPIIFN, KIIBJKPFFHE, DFBDMPCEMAM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class MDNBOEPCGBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public NAKMMEJMOAP result;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MDNBOEPCGBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x36F9890", Offset = "0x36F8A90", VA = "0x1836F9890")]
		internal object FMLMGEONAHE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BC20", Offset = "0x2D0AE20", VA = "0x182D0BC20")]
	[UnityEngine.Scripting.Preserve]
	public AJICKMPHHOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BA90", Offset = "0x2D0AC90", VA = "0x182D0BA90", Slot = "8")]
	public NAKMMEJMOAP GJIGEPNPDDE(NBDCAKCJOHF KCAAIIKABAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface JIMOFDHDMFE
{
	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool KKNBFOCMAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	string NILCOHMNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPKFOGNKFPE();

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NDMECFMJHCJ FLACCMBKIHC(long EGCEBLMJCKK);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BILFFCGDFHA<DLJGDNEKCBH, PJHLEBGLDJJ> FNJPIFLCIKL(long EGCEBLMJCKK);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BILFFCGDFHA<DLJGDNEKCBH, PIKKGCCILDN> LFKNILIKPBC(long EGCEBLMJCKK);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BILFFCGDFHA<long, ODJGGCOOJEA> KCLKFKKHPFE();

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> DMLLOJAOAIM(byte[] JNLAJBEPGHH, byte[] ECMLCDIPEEO, CancellationToken PLEKJLHDOLP);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class EALNPJHBDKN : GFPBNPJJDJN, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class JKIFIDGKMJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JKIFIDGKMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x42C0480", Offset = "0x42BF680", VA = "0x1842C0480")]
		internal object CNMKEPLOMAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class OLNKGACMFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OLNKGACMFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x42C5E00", Offset = "0x42C5000", VA = "0x1842C5E00")]
		internal object OAFFPPKAKMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class JNAIMIMPHIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JNAIMIMPHIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x42C04E0", Offset = "0x42BF6E0", VA = "0x1842C04E0")]
		internal object AFJIMADOEKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class IEDPGKODCEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public IEDPGKODCEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x42C03C0", Offset = "0x42BF5C0", VA = "0x1842C03C0")]
		internal object ELMGAGMGPPN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class BGPEIOEJDIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BGPEIOEJDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x42B69F0", Offset = "0x42B5BF0", VA = "0x1842B69F0")]
		internal object HOCOBMAGCDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private readonly Dictionary<Guid, COEHOHKBDPA> LKLMKNNGJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private readonly TimeSpan IALJOCPIFCJ;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "10")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A7A0", Offset = "0x2D199A0", VA = "0x182D1A7A0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B3D0", Offset = "0x2D1A5D0", VA = "0x182D1B3D0", Slot = "4")]
	public HOJCCABHALO PPMBLONPHPF(Guid HPINIPGLIPD)
	{
		return default(HOJCCABHALO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AE30", Offset = "0x2D1A030", VA = "0x182D1AE30", Slot = "5")]
	public bool PLKCAALIKKA(Guid HPINIPGLIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2D1ABA0", Offset = "0x2D19DA0", VA = "0x182D1ABA0", Slot = "8")]
	public bool LFPEABENKGO(Guid HPINIPGLIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A7B0", Offset = "0x2D199B0", VA = "0x182D1A7B0", Slot = "6")]
	public bool JMAGGDOJMAP(Guid HPINIPGLIPD, Task IHNIBFOOPAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A430", Offset = "0x2D19630", VA = "0x182D1A430", Slot = "7")]
	public bool CKDCPLFNADD(Guid HPINIPGLIPD, NAKMMEJMOAP FGPPDHPBHPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A710", Offset = "0x2D19910", VA = "0x182D1A710", Slot = "9")]
	public Task<(NAKMMEJMOAP, Task)> DIDJHADGBNC(Guid HPINIPGLIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B100", Offset = "0x2D1A300", VA = "0x182D1B100")]
	private void PMOELLFNCGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B670", Offset = "0x2D1A870", VA = "0x182D1B670")]
	public EALNPJHBDKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class ONPGGPJHPPB : EJAEMFPIIFN, KLELFNKDBNP, DFBDMPCEMAM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class GMHMGPPLNHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public NAKMMEJMOAP result;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GMHMGPPLNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C362C0", Offset = "0x5C354C0", VA = "0x185C362C0")]
		internal object GMMHNFBLOLH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x36FC500", Offset = "0x36FB700", VA = "0x1836FC500")]
	[UnityEngine.Scripting.Preserve]
	public ONPGGPJHPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x36FC370", Offset = "0x36FB570", VA = "0x1836FC370", Slot = "8")]
	public NAKMMEJMOAP HPDOMJLIBEH(NBDCAKCJOHF NHDBOCCEDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal interface HDMCFFBEMAE : JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	TaskStatus ONKFOHPIPML
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OMEEECMIGBD(MDCIINLFDMH OGJNPFMLCHO, KIPGPNOONJB GFEFGABCJFI, CancellationToken NNJAJHKDGKL);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class MMEOCCPOHKJ
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x36F9B30", Offset = "0x36F8D30", VA = "0x1836F9B30")]
	public static bool EMJFJBFFOOK(this HDMCFFBEMAE HFAJEOBGPNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal static class FFJEEECIJKI
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2D24B00", Offset = "0x2D23D00", VA = "0x182D24B00")]
	public static string GMKPACCOLCH(this MDCIINLFDMH IBCKECGKAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D24D50", Offset = "0x2D23F50", VA = "0x182D24D50")]
	public static bool IGECHNDGCOD(this MDCIINLFDMH IBCKECGKAII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[UnityEngine.Scripting.Preserve]
internal class GFGNLIEOFFG : IPDOADDBPPL, JOHHDFEACJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class IGLPKFBHPOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public GFGNLIEOFFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public IGLPKFBHPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x4294A50", Offset = "0x4293C50", VA = "0x184294A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class MGNJHEIKDEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public GFGNLIEOFFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private bool <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MGNJHEIKDEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x429AA30", Offset = "0x4299C30", VA = "0x18429AA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class DADNINMLCML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DADNINMLCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x428D300", Offset = "0x428C500", VA = "0x18428D300")]
		internal object LELAFNFDDDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class EGFENKGJHIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public GFGNLIEOFFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private DADNINMLCML <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private MEMOKKFMPAN <provider>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EGFENKGJHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x428E3B0", Offset = "0x428D5B0", VA = "0x18428E3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class NDPAELJJIFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NDPAELJJIFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x429B490", Offset = "0x429A690", VA = "0x18429B490")]
		internal object PJIIKNPGFAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private FGKLHHEMEMB JCECDDPGEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private MEMOKKFMPAN[] PFNEJJHEJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private CancellationTokenSource AKHLKBFAFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private int GFDOFJMIICG;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2D26630", Offset = "0x2D25830", VA = "0x182D26630", Slot = "7")]
	public void OHLMLHJNBAL(KCLMMCNCBHA COENACEECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2D25C80", Offset = "0x2D24E80", VA = "0x182D25C80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2D26210", Offset = "0x2D25410", VA = "0x182D26210", Slot = "6")]
	public void LFPEABENKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2D263A0", Offset = "0x2D255A0", VA = "0x182D263A0", Slot = "5")]
	public void LIIEFGHGIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2D26510", Offset = "0x2D25710", VA = "0x182D26510", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IGLPKFBHPOI))]
	public Task NFHICOAFCNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2D25920", Offset = "0x2D24B20", VA = "0x182D25920")]
	private void AIBBGHJAIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2D25F00", Offset = "0x2D25100", VA = "0x182D25F00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGNJHEIKDEB))]
	private Task IKLGIOMNIEN(CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x2D266B0", Offset = "0x2D258B0", VA = "0x182D266B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EGFENKGJHIH))]
	private Task<bool> OMJKKJPBKFB(int MMFFFGBLCAP, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x2D25C90", Offset = "0x2D24E90", VA = "0x182D25C90")]
	private void EDMPJLFMOIG(int MMFFFGBLCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x2D26840", Offset = "0x2D25A40", VA = "0x182D26840")]
	private void PCDPNJMNCPO(int MMFFFGBLCAP, bool LKCMOCEILKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2D26050", Offset = "0x2D25250", VA = "0x182D26050")]
	private void IPPHGPPCIGK(int MMFFFGBLCAP, Exception ODBCLHKGDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2D25DF0", Offset = "0x2D24FF0", VA = "0x182D25DF0")]
	private void GNPBLMHGNMP(CancellationToken PLEKJLHDOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D26990", Offset = "0x2D25B90", VA = "0x182D26990")]
	public GFGNLIEOFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class MPJIKCAALNK
{
	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x36FA700", Offset = "0x36F9900", VA = "0x1836FA700")]
	public static void CLELBJFHDII(this IPBPMMLOKDP BIHEKONDPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x36FA710", Offset = "0x36F9910", VA = "0x1836FA710")]
	public static void JACCCPGIKCG(this IPBPMMLOKDP BIHEKONDPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x36FA720", Offset = "0x36F9920", VA = "0x1836FA720")]
	private static void OGFIFDLHJHK(this IPBPMMLOKDP BIHEKONDPKH, bool JNDJLMCDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct AJEDLBAHGON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public readonly NOAKBMOBOAL CMJEAPKGJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public readonly string MOLALINFKIN;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BA70", Offset = "0x2D0AC70", VA = "0x182D0BA70")]
	public AJEDLBAHGON(string KJKLIEDLLGN, NOAKBMOBOAL AOOCDELIJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B950", Offset = "0x2D0AB50", VA = "0x182D0B950")]
	public string GJFCGPOKDIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B9D0", Offset = "0x2D0ABD0", VA = "0x182D0B9D0")]
	public string JNNGGJDDOFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public delegate string AJHFKGIAOCH<in T>(T ODBCLHKGDHB) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public delegate int PKLLCFGBIEH<in T>(T ODBCLHKGDHB) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class LNANNDMLJLA : AOCCOOPEIPL
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private delegate string JJJCJFDCADI(Exception ODBCLHKGDHB);

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private delegate int JFLLPJKHLGC(Exception ODBCLHKGDHB);

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class IIPFHBLJFHK<T> : BIDFOACDKKD<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class IJJBOKMNIPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
			public IJJBOKMNIPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
			internal string PEFEGFLINPJ(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class EGFAJJBEPMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7BFBE0", Offset = "0x7BEFE0")]
			public AJHFKGIAOCH<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
			public EGFAJJBEPMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x35CDD30", Offset = "0x35CCF30", VA = "0x1835CDD30")]
			internal string MMJCNOBCKFD(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class IJNNDBABDLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public int subCode;

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
			public IJNNDBABDLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
			internal int FMEHAJBOABM(Exception _)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class PAOACBLLNNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7BFC40", Offset = "0x7BF040")]
			public PKLLCFGBIEH<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
			public PAOACBLLNNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x35CDD30", Offset = "0x35CCF30", VA = "0x1835CDD30")]
			internal int GIFOLDNCCKH(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private readonly LNANNDMLJLA MPPAGFGEBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private readonly Type DPFABNPMDPP;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x2754C40", Offset = "0x2753E40", VA = "0x182754C40")]
		internal IIPFHBLJFHK(LNANNDMLJLA MPPAGFGEBCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x27549C0", Offset = "0x2753BC0", VA = "0x1827549C0", Slot = "4")]
		public void GEEIMLGNFAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x27547A0", Offset = "0x27539A0", VA = "0x1827547A0", Slot = "5")]
		public BIDFOACDKKD<T> BMCHKHPOHPH(string PEEOOIILKMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x2754B40", Offset = "0x2753D40", VA = "0x182754B40", Slot = "6")]
		public BIDFOACDKKD<T> NAAPJFJEEHN(AJHFKGIAOCH<T> MLGPNEEGBIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x27549F0", Offset = "0x2753BF0", VA = "0x1827549F0", Slot = "7")]
		public BIDFOACDKKD<T> GKMMJLKCPAA(int AOOCDELIJDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2754A30", Offset = "0x2753C30", VA = "0x182754A30", Slot = "8")]
		public BIDFOACDKKD<T> IHEAKMJHHNF(int AOOCDELIJDO, int NJMLDJALCMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x27548A0", Offset = "0x2753AA0", VA = "0x1827548A0", Slot = "9")]
		public BIDFOACDKKD<T> FGBJHKLBBCP(int AOOCDELIJDO, PKLLCFGBIEH<T> ALFEFAFNHPE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class NKGIKBDODCB<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private bool KPMNONPBBEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private readonly List<Type> FEFAKPKIOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private readonly Dictionary<Type, TVal> GLAKBFAJMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private readonly Dictionary<Type, int> DCMJGPOIECB;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public IReadOnlyList<Type> CMHDDLEAFCB
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x2F6D450", Offset = "0x2F6C650", VA = "0x182F6D450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D740", Offset = "0x2F6C940", VA = "0x182F6D740")]
		public NKGIKBDODCB(Dictionary<Type, int> DCMJGPOIECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D6A0", Offset = "0x2F6C8A0", VA = "0x182F6D6A0")]
		public void PPMBLONPHPF(Type PPNIGBBPGOI, TVal HKPIHPOEJGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D2E0", Offset = "0x2F6C4E0", VA = "0x182F6D2E0")]
		public bool KIBDODDKDKH(Type DPFABNPMDPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D2B0", Offset = "0x2F6C4B0", VA = "0x182F6D2B0")]
		public bool BNLINIFLGKC(TVal ACKOJNNBEBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D5D0", Offset = "0x2F6C7D0", VA = "0x182F6D5D0")]
		public TVal MEINKDCJHDP(Type JAACLLLIGMF)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2F6D310", Offset = "0x2F6C510", VA = "0x182F6D310")]
		[CompilerGenerated]
		private int KLJCPHJMPJA(Type NGIIFIKAJBG, Type AGMOGHOJNPB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private sealed class GMDKKLMDJOO : IEnumerable<NOAKBMOBOAL>, IEnumerable, IEnumerator<NOAKBMOBOAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private NOAKBMOBOAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public LNANNDMLJLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private AggregateException <aggregateException>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private IEnumerator<Exception> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private Exception <innerException>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private IEnumerator<NOAKBMOBOAL> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private NOAKBMOBOAL <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private NOAKBMOBOAL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x12E1A20", Offset = "0x12E0C20", VA = "0x1812E1A20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NOAKBMOBOAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x4291810", Offset = "0x4290A10", VA = "0x184291810", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xECAD80", Offset = "0xEC9F80", VA = "0x180ECAD80")]
		[DebuggerHidden]
		public GMDKKLMDJOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x4291860", Offset = "0x4290A60", VA = "0x184291860", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x42912B0", Offset = "0x42904B0", VA = "0x1842912B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x4291260", Offset = "0x4290460", VA = "0x184291260")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x42916D0", Offset = "0x42908D0", VA = "0x1842916D0")]
		private void PKFPAMEJFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x42917D0", Offset = "0x42909D0", VA = "0x1842917D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x4291720", Offset = "0x4290920", VA = "0x184291720", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NOAKBMOBOAL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x4291720", Offset = "0x4290920", VA = "0x184291720", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	internal const int MMFGKIBINKE = 8700;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private static readonly NOAKBMOBOAL JOMLKKGFDDH;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	internal const string DHONKCGCEGA = "Unknown error loading room";

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	internal const int FPDIOIFAKLE = 8708;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private static readonly Dictionary<Type, int> DMEENNOINAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private readonly HashSet<Type> MKJKCBOADPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private readonly NKGIKBDODCB<int> BKCIOGJINLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private readonly NKGIKBDODCB<JFLLPJKHLGC> MNCBPNLDALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private readonly NKGIKBDODCB<JJJCJFDCADI> EMLJFKHPPCG;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x36F5830", Offset = "0x36F4A30", VA = "0x1836F5830")]
	[MPKPGFJAEKF(OJBJGAAILBP.GameOnly)]
	private static void CGPKALMGMIN(JLCNCEFHLIA LBDNCAMEGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x36F6C40", Offset = "0x36F5E40", VA = "0x1836F6C40")]
	[RecRoom.NoEngine.Common.Preserve]
	public LNANNDMLJLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x268FC40", Offset = "0x268EE40", VA = "0x18268FC40", Slot = "4")]
	public BIDFOACDKKD<T> MIJJPICFKJJ<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x36F5770", Offset = "0x36F4970", VA = "0x1836F5770", Slot = "5")]
	public AJEDLBAHGON BBLPNILKDGB(Exception ODBCLHKGDHB)
	{
		return default(AJEDLBAHGON);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x36F5FF0", Offset = "0x36F51F0", VA = "0x1836F5FF0", Slot = "6")]
	public NOAKBMOBOAL FDOFEDAPGIJ(Exception? ODBCLHKGDHB)
	{
		return default(NOAKBMOBOAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x36F5C80", Offset = "0x36F4E80", VA = "0x1836F5C80", Slot = "7")]
	[IteratorStateMachine(typeof(GMDKKLMDJOO))]
	public IEnumerable<NOAKBMOBOAL> DIFHMBGEDBJ(Exception ODBCLHKGDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x36F5EB0", Offset = "0x36F50B0", VA = "0x1836F5EB0", Slot = "8")]
	public string EJOHMLCCBCM(Exception? ODBCLHKGDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x36F5920", Offset = "0x36F4B20", VA = "0x1836F5920")]
	private string DHCAODAGJJH(AggregateException NGMGLFPFHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x36F67F0", Offset = "0x36F59F0", VA = "0x1836F67F0")]
	private void NPDGGPCFFCK(Type DPFABNPMDPP, int AOOCDELIJDO, JFLLPJKHLGC? AIBNOMCILKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x36F6200", Offset = "0x36F5400", VA = "0x1836F6200")]
	private void HFGNPMIMKAB(Type DPFABNPMDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x36F6440", Offset = "0x36F5640", VA = "0x1836F6440")]
	private void KKABIFFBPHF(Type DPFABNPMDPP, JJJCJFDCADI PILAPAPONCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x36F5D10", Offset = "0x36F4F10", VA = "0x1836F5D10")]
	private static int EECEKHGFAPI(Type DPFABNPMDPP, Dictionary<Type, int> DCMJGPOIECB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x334ADC0", Offset = "0x3349FC0", VA = "0x18334ADC0")]
	private static bool ICLFGLOLJCK<TVal>(NKGIKBDODCB<TVal> DNDGJFJKDEB, Type DPFABNPMDPP, out TVal ACKOJNNBEBO) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x36F6700", Offset = "0x36F5900", VA = "0x1836F6700")]
	[CompilerGenerated]
	internal static int MLEGFCPCNKF(Type IBJCNKBJPLH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct NOAKBMOBOAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public readonly int IPDIAIKJAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public readonly int? EOJLMNGHGKL;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x25CFF20", Offset = "0x25CF120", VA = "0x1825CFF20")]
	public NOAKBMOBOAL(int PJFLCBPHEFP, [Optional] int? NJMLDJALCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x36FBB40", Offset = "0x36FAD40", VA = "0x1836FBB40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface AOCCOOPEIPL
{
	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BIDFOACDKKD<T> MIJJPICFKJJ<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AJEDLBAHGON BBLPNILKDGB(Exception ODBCLHKGDHB);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NOAKBMOBOAL FDOFEDAPGIJ(Exception ODBCLHKGDHB);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<NOAKBMOBOAL> DIFHMBGEDBJ(Exception ODBCLHKGDHB);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string EJOHMLCCBCM(Exception ODBCLHKGDHB);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface BIDFOACDKKD<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEEIMLGNFAN();

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BIDFOACDKKD<T> BMCHKHPOHPH(string PEEOOIILKMJ);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BIDFOACDKKD<T> NAAPJFJEEHN(AJHFKGIAOCH<T> MLGPNEEGBIL);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BIDFOACDKKD<T> GKMMJLKCPAA(int AOOCDELIJDO);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BIDFOACDKKD<T> IHEAKMJHHNF(int AOOCDELIJDO, int NJMLDJALCMJ);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BIDFOACDKKD<T> FGBJHKLBBCP(int AOOCDELIJDO, PKLLCFGBIEH<T> ALFEFAFNHPE);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class DCIKGKECJPG
{
	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2D14490", Offset = "0x2D13690", VA = "0x182D14490")]
	[MPKPGFJAEKF(OJBJGAAILBP.GameOnly)]
	private static void BDIDELBNDKE(JLCNCEFHLIA LBDNCAMEGNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public interface COOLNBMBOGP : IEquatable<COOLNBMBOGP>
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	ODENNJIICMF FHIHBHJPOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	DateTime HNDJABNFHNI
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLOCCGKMGML();

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LAOJBEACHJH(long LNBFDCAEKJF, long GLLEENOIFOJ, out FAPAGDCIGJE ACEDMDLCIME);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class PJHFPDPMEEL : KPAJKDAICAP
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class MOOINMEGNKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public BJINNGNHAFI autosaveType;

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MOOINMEGNKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class BIODHPNBEDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public MOOINMEGNKM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BIODHPNBEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5C32860", Offset = "0x5C31A60", VA = "0x185C32860")]
		internal object GNAAMMBAEJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private readonly MHIFEODOBEA KFOGBGOKEFM;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private const int FNLPMGADKMJ = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<COOLNBMBOGP> OBIAGPECIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x36FEDF0", Offset = "0x36FDFF0", VA = "0x1836FEDF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x36FEE90", Offset = "0x36FE090", VA = "0x1836FEE90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A20", Offset = "0x8D6C20", VA = "0x1808D7A20")]
	[UnityEngine.Scripting.Preserve]
	public PJHFPDPMEEL([IDNKOMINBGM(null)] MHIFEODOBEA KFOGBGOKEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x36FF210", Offset = "0x36FE410", VA = "0x1836FF210", Slot = "6")]
	public bool KAJCFGBPPDK(long LNBFDCAEKJF, long GLLEENOIFOJ, FAPAGDCIGJE ACEDMDLCIME, BJINNGNHAFI AGHJKILGDNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x36FF170", Offset = "0x36FE370", VA = "0x1836FF170")]
	private void DIBGJJHKPHM(COOLNBMBOGP HJNBJLCLGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x36FEFE0", Offset = "0x36FE1E0", VA = "0x1836FEFE0", Slot = "7")]
	public bool CFMMIDPILBD(long LNBFDCAEKJF, long GLLEENOIFOJ, out COOLNBMBOGP CGJKBLJLHJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x36FEF30", Offset = "0x36FE130", VA = "0x1836FEF30", Slot = "8")]
	public bool BGLENIICFMC(long LNBFDCAEKJF, long GLLEENOIFOJ, BJINNGNHAFI AGHJKILGDNH, out COOLNBMBOGP CGJKBLJLHJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x36FF6D0", Offset = "0x36FE8D0", VA = "0x1836FF6D0")]
	private void OCFGBGFGLOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x36FF5B0", Offset = "0x36FE7B0", VA = "0x1836FF5B0", Slot = "9")]
	public void NMFLJJLDBLA(long LNBFDCAEKJF, long GLLEENOIFOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public enum ODENNJIICMF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal sealed class LJLGIMKCPOF : FDAICMCLDFN
{
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private static readonly byte[] PPNIGBBPGOI;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private const string JKFFCPJFIHB = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private const string KCEJNBPLHFA = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private const string MLEJCNHPBEO = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private readonly byte[] LCNDDMHEDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private readonly byte[] BKFKCIKLDJN;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public override ODENNJIICMF FHIHBHJPOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xA7CEC0", Offset = "0xA7C0C0", VA = "0x180A7CEC0", Slot = "8")]
		get
		{
			return default(ODENNJIICMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x36F5160", Offset = "0x36F4360", VA = "0x1836F5160")]
	public LJLGIMKCPOF([Optional] string DNHLHNJBCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x36F4250", Offset = "0x36F3450", VA = "0x1836F4250", Slot = "9")]
	internal override void CJBEJLJNNKB(Stream GKHDDFBOJDE, long LNBFDCAEKJF, long GLLEENOIFOJ, FAPAGDCIGJE ACEDMDLCIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x36F4530", Offset = "0x36F3730", VA = "0x1836F4530", Slot = "10")]
	internal override bool FGCKIGECLCC(Stream FPCJPIAEFLN, long LNBFDCAEKJF, long GLLEENOIFOJ, AGMDCFDMIGG EPHDNEHAFJB, out FAPAGDCIGJE ACEDMDLCIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x36F4D80", Offset = "0x36F3F80", VA = "0x1836F4D80")]
	private void IKHGHBHJIFH(byte[] KJNADKBIDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x36F4FB0", Offset = "0x36F41B0", VA = "0x1836F4FB0", Slot = "11")]
	protected override FileInfo LJGJIIDMLJL(long LNBFDCAEKJF, long GLLEENOIFOJ, BJINNGNHAFI AGHJKILGDNH, AODKEDCEIFL LOFKIAMMOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x36F4E90", Offset = "0x36F4090", VA = "0x1836F4E90", Slot = "12")]
	protected override DirectoryInfo KPJCCFPINOE(BJINNGNHAFI AGHJKILGDNH, AODKEDCEIFL LOFKIAMMOFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class FDMJNKAMDOB : FDAICMCLDFN
{
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private const string GEOLBKAOFIG = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private const string JKFFCPJFIHB = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private const string KCEJNBPLHFA = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public override ODENNJIICMF FHIHBHJPOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x1744E00", Offset = "0x1744000", VA = "0x181744E00", Slot = "8")]
		get
		{
			return default(ODENNJIICMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2D24A40", Offset = "0x2D23C40", VA = "0x182D24A40")]
	public FDMJNKAMDOB([Optional] string DNHLHNJBCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2D242B0", Offset = "0x2D234B0", VA = "0x182D242B0")]
	private void DJJBMHLODFH(BJINNGNHAFI AGHJKILGDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2D24080", Offset = "0x2D23280", VA = "0x182D24080", Slot = "9")]
	internal override void CJBEJLJNNKB(Stream GKHDDFBOJDE, long LNBFDCAEKJF, long GLLEENOIFOJ, FAPAGDCIGJE ACEDMDLCIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2D24340", Offset = "0x2D23540", VA = "0x182D24340", Slot = "10")]
	internal override bool FGCKIGECLCC(Stream FPCJPIAEFLN, long LNBFDCAEKJF, long GLLEENOIFOJ, AGMDCFDMIGG EPHDNEHAFJB, out FAPAGDCIGJE ACEDMDLCIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2D24950", Offset = "0x2D23B50", VA = "0x182D24950", Slot = "11")]
	protected override FileInfo LJGJIIDMLJL(long LNBFDCAEKJF, long GLLEENOIFOJ, BJINNGNHAFI AGHJKILGDNH, AODKEDCEIFL LOFKIAMMOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2D24840", Offset = "0x2D23A40", VA = "0x182D24840", Slot = "12")]
	protected override DirectoryInfo KPJCCFPINOE(BJINNGNHAFI AGHJKILGDNH, AODKEDCEIFL LOFKIAMMOFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal abstract class FDAICMCLDFN : MHIFEODOBEA
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	protected enum AODKEDCEIFL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class IEFKOPCOAIH : IEnumerable<COOLNBMBOGP>, IEnumerable, IEnumerator<COOLNBMBOGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private COOLNBMBOGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private BJINNGNHAFI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public BJINNGNHAFI <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public FDAICMCLDFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private DirectoryInfo <autosaveDirectory>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private FileInfo[] <files>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private FileInfo[] <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private FileInfo <file>5__5;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private COOLNBMBOGP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xECAD80", Offset = "0xEC9F80", VA = "0x180ECAD80")]
		[DebuggerHidden]
		public IEFKOPCOAIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x4294740", Offset = "0x4293940", VA = "0x184294740", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x42949A0", Offset = "0x4293BA0", VA = "0x1842949A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x42948F0", Offset = "0x4293AF0", VA = "0x1842948F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<COOLNBMBOGP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x42948F0", Offset = "0x4293AF0", VA = "0x1842948F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class NGHDJCELPAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public BJINNGNHAFI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NGHDJCELPAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x429B500", Offset = "0x429A700", VA = "0x18429B500")]
		internal object EIMBGONBMPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class ANFOLCNDNCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public FDAICMCLDFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public ANFOLCNDNCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x428BD30", Offset = "0x428AF30", VA = "0x18428BD30")]
		internal void DODMIINDMOD(AAKMENFOFEI.ACBODHFEDLF ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000374")]
	protected readonly string HBEOMODJGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000375")]
	private readonly object CJCEMEDEEMB;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public abstract ODENNJIICMF FHIHBHJPOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2D219D0", Offset = "0x2D20BD0", VA = "0x182D219D0")]
	protected FDAICMCLDFN([CanBeNull] string DNHLHNJBCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2D217A0", Offset = "0x2D209A0", VA = "0x182D217A0", Slot = "5")]
	public bool IMBCKAKIHNE(long LNBFDCAEKJF, long GLLEENOIFOJ, BJINNGNHAFI AGHJKILGDNH, out COOLNBMBOGP HJNBJLCLGDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2D21950", Offset = "0x2D20B50", VA = "0x182D21950", Slot = "6")]
	[IteratorStateMachine(typeof(IEFKOPCOAIH))]
	public IEnumerable<COOLNBMBOGP> NOGDDGPEOCI(BJINNGNHAFI AGHJKILGDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void CJBEJLJNNKB(Stream GKHDDFBOJDE, long LNBFDCAEKJF, long GLLEENOIFOJ, FAPAGDCIGJE ACEDMDLCIME);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool FGCKIGECLCC(Stream FPCJPIAEFLN, long LNBFDCAEKJF, long GLLEENOIFOJ, AGMDCFDMIGG EPHDNEHAFJB, out FAPAGDCIGJE ACEDMDLCIME);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2D214A0", Offset = "0x2D206A0", VA = "0x182D214A0", Slot = "7")]
	public COOLNBMBOGP EMNCPONKEJA(long LNBFDCAEKJF, long GLLEENOIFOJ, FAPAGDCIGJE ACEDMDLCIME, BJINNGNHAFI AGHJKILGDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo LJGJIIDMLJL(long LNBFDCAEKJF, long GLLEENOIFOJ, BJINNGNHAFI AGHJKILGDNH, AODKEDCEIFL LOFKIAMMOFN);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo KPJCCFPINOE(BJINNGNHAFI AGHJKILGDNH, AODKEDCEIFL LOFKIAMMOFN);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x2D21170", Offset = "0x2D20370", VA = "0x182D21170")]
	protected void EFEEGDDPDMH(AAKMENFOFEI.ACBODHFEDLF LAEBBKOFMEK, string GGOJIBEJMBM, FileInfo OHBBEDEEPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2D211E0", Offset = "0x2D203E0", VA = "0x182D211E0")]
	internal bool EKCIKNBGOMI(FileInfo LAEKKNIBICC, long LNBFDCAEKJF, long GLLEENOIFOJ, out FAPAGDCIGJE ACEDMDLCIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	private void NIDKOLFAIBP(Exception JFHIOGAFNIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal interface MHIFEODOBEA
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	ODENNJIICMF FHIHBHJPOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IMBCKAKIHNE(long LNBFDCAEKJF, long GLLEENOIFOJ, BJINNGNHAFI AGHJKILGDNH, out COOLNBMBOGP HJNBJLCLGDH);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<COOLNBMBOGP> NOGDDGPEOCI(BJINNGNHAFI AGHJKILGDNH);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	COOLNBMBOGP EMNCPONKEJA(long LNBFDCAEKJF, long GLLEENOIFOJ, FAPAGDCIGJE ACEDMDLCIME, BJINNGNHAFI AGHJKILGDNH);
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class JFEHKGGPKCF : MHIFEODOBEA
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class FAGLLPOAOMI : IEnumerable<COOLNBMBOGP>, IEnumerable, IEnumerator<COOLNBMBOGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private COOLNBMBOGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private BJINNGNHAFI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public BJINNGNHAFI <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public JFEHKGGPKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private ODENNJIICMF[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private ODENNJIICMF <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private MHIFEODOBEA <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private IEnumerable<COOLNBMBOGP> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private IEnumerator<COOLNBMBOGP> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private COOLNBMBOGP <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private COOLNBMBOGP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xECAD80", Offset = "0xEC9F80", VA = "0x180ECAD80")]
		[DebuggerHidden]
		public FAGLLPOAOMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x428FDD0", Offset = "0x428EFD0", VA = "0x18428FDD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x428F990", Offset = "0x428EB90", VA = "0x18428F990", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x428F940", Offset = "0x428EB40", VA = "0x18428F940")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x428FD90", Offset = "0x428EF90", VA = "0x18428FD90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x428FCE0", Offset = "0x428EEE0", VA = "0x18428FCE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<COOLNBMBOGP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x428FCE0", Offset = "0x428EEE0", VA = "0x18428FCE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly ODENNJIICMF[] MBOHOCBBJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private readonly Dictionary<ODENNJIICMF, MHIFEODOBEA> PGNGPIJBGPO;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public ODENNJIICMF FHIHBHJPOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C630", Offset = "0x2D2B830", VA = "0x182D2C630", Slot = "4")]
		get
		{
			return default(ODENNJIICMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C940", Offset = "0x2D2BB40", VA = "0x182D2C940")]
	[UnityEngine.Scripting.Preserve]
	public JFEHKGGPKCF(params MHIFEODOBEA[] LKBGKMJCOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C4D0", Offset = "0x2D2B6D0", VA = "0x182D2C4D0", Slot = "5")]
	public bool IMBCKAKIHNE(long LNBFDCAEKJF, long GLLEENOIFOJ, BJINNGNHAFI AGHJKILGDNH, out COOLNBMBOGP HJNBJLCLGDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C670", Offset = "0x2D2B870", VA = "0x182D2C670")]
	private void JILOACLICFL(int ABJBLDJJGAG, long LNBFDCAEKJF, long GLLEENOIFOJ, BJINNGNHAFI AGHJKILGDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C8C0", Offset = "0x2D2BAC0", VA = "0x182D2C8C0", Slot = "6")]
	[IteratorStateMachine(typeof(FAGLLPOAOMI))]
	public IEnumerable<COOLNBMBOGP> NOGDDGPEOCI(BJINNGNHAFI AGHJKILGDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C380", Offset = "0x2D2B580", VA = "0x182D2C380", Slot = "7")]
	public COOLNBMBOGP EMNCPONKEJA(long LNBFDCAEKJF, long GLLEENOIFOJ, FAPAGDCIGJE ACEDMDLCIME, BJINNGNHAFI AGHJKILGDNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal static class KHKAHKACIDD
{
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	internal const int MGLNPCIENBL = 32;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x36EF030", Offset = "0x36EE230", VA = "0x1836EF030")]
	internal static byte[] KHEDJNELGEI(byte[] KJNADKBIDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x36EF0D0", Offset = "0x36EE2D0", VA = "0x1836EF0D0")]
	public static void OELCBCMPNEN(Stream MNDMLEMMFJE, byte[] FJMFOKKNFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x36EEE50", Offset = "0x36EE050", VA = "0x1836EEE50")]
	public static bool BMDMFLIOBLJ(Stream MNDMLEMMFJE, long IJAPDELFLJG, AGMDCFDMIGG JMDHEDMONPH, out byte[] PKJODJAPJIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public delegate void AGMDCFDMIGG(AAKMENFOFEI.ACBODHFEDLF EPDBFPEHHFJ, string CEOMJLPEFPB);
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class KPLBBMKHAIG : COOLNBMBOGP, IEquatable<COOLNBMBOGP>, IEquatable<KPLBBMKHAIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	private readonly FDAICMCLDFN BILKOAEAGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public readonly FileInfo LNEMIPMIAOG;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public ODENNJIICMF FHIHBHJPOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xED8B30", Offset = "0xED7D30", VA = "0x180ED8B30", Slot = "4")]
		get
		{
			return default(ODENNJIICMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public DateTime HNDJABNFHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x36F1760", Offset = "0x36F0960", VA = "0x1836F1760", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x36F1CD0", Offset = "0x36F0ED0", VA = "0x1836F1CD0")]
	public KPLBBMKHAIG(FDAICMCLDFN MHINDCMIHLI, FileInfo LAEKKNIBICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x36F1C20", Offset = "0x36F0E20", VA = "0x1836F1C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x36F1A90", Offset = "0x36F0C90", VA = "0x1836F1A90", Slot = "6")]
	public void FLOCCGKMGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x36F1BE0", Offset = "0x36F0DE0", VA = "0x1836F1BE0", Slot = "7")]
	public bool LAOJBEACHJH(long LNBFDCAEKJF, long GLLEENOIFOJ, out FAPAGDCIGJE ACEDMDLCIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x36F19B0", Offset = "0x36F0BB0", VA = "0x1836F19B0", Slot = "8")]
	public bool Equals(COOLNBMBOGP HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x36F1900", Offset = "0x36F0B00", VA = "0x1836F1900", Slot = "9")]
	public bool Equals(KPLBBMKHAIG HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x36F1800", Offset = "0x36F0A00", VA = "0x1836F1800", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x36F1B40", Offset = "0x36F0D40", VA = "0x1836F1B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x25B5300", Offset = "0x25B4500", VA = "0x1825B5300")]
	public static bool JGKKLLGINAK(KPLBBMKHAIG NGKKOMJDENH, KPLBBMKHAIG KEJINCBACKA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x25B53E0", Offset = "0x25B45E0", VA = "0x1825B53E0")]
	public static bool NGNNEMMJMMJ(KPLBBMKHAIG NGKKOMJDENH, KPLBBMKHAIG KEJINCBACKA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct GEFCHKPPBAD
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class GKIBPFHLIDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private KCLMMCNCBHA <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GKIBPFHLIDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x4290D60", Offset = "0x428FF60", VA = "0x184290D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D25400", Offset = "0x2D24600", VA = "0x182D25400")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GKIBPFHLIDE))]
	public static Task ONDGBMOLAPF(DPBMEMKDFAC CPNHGIEOMKO, FEKMMALKIBN JCEJEOAKGOJ, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct JOIJHNIJPNH
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class NHJOOOBKKOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public ILAIPNDOCNE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public BCCKLEDHADN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private KCLMMCNCBHA <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private FGKLHHEMEMB <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private OALBBBOJDGP <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private List<(PersistenceView, LLLPGKDBIPO)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private LLLPGKDBIPO <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NHJOOOBKKOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x429C830", Offset = "0x429BA30", VA = "0x18429C830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x36ECBE0", Offset = "0x36EBDE0", VA = "0x1836ECBE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHJOOOBKKOK))]
	public static Task ONDGBMOLAPF(ILAIPNDOCNE IAFPJLJBHFI, FEKMMALKIBN JCEJEOAKGOJ, BCCKLEDHADN BJOENEBOOPC, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal struct GCIHMELJNEJ
{
	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710")]
	public static GCIHMELJNEJ LNIGJBIDADO()
	{
		return default(GCIHMELJNEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void DEPLJAPIKAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void PMCOBBFCIPA(FEKMMALKIBN JCEJEOAKGOJ, object LOAEFHPBAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void OPPLIMCMOGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal struct FCAEFGMAOMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	private FEKMMALKIBN JCEJEOAKGOJ;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private FGKLHHEMEMB HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D20E10", Offset = "0x2D20010", VA = "0x182D20E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x2D210D0", Offset = "0x2D202D0", VA = "0x182D210D0")]
	public static Task ONDGBMOLAPF(KCLMMCNCBHA COENACEECKL, FEKMMALKIBN JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D20E60", Offset = "0x2D20060", VA = "0x182D20E60")]
	private void ONDGBMOLAPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class LNNBCGJEJKM : ILAIPNDOCNE
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class EMNDIHDFIPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public LNNBCGJEJKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private LGCHJFHJHIL <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private CNHIGFDMMEB <serializeType>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private FAPAGDCIGJE <data>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private FAPAGDCIGJE <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private TaskAwaiter<FAPAGDCIGJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EMNDIHDFIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x5C33BF0", Offset = "0x5C32DF0", VA = "0x185C33BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private readonly string JOHBEDGKEMC;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x36F70F0", Offset = "0x36F62F0", VA = "0x1836F70F0")]
	public LNNBCGJEJKM(Guid HPINIPGLIPD, KCLMMCNCBHA COENACEECKL, NLAKPJCOMPN EFMABIDKOGO, string JOHBEDGKEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x36F6F50", Offset = "0x36F6150", VA = "0x1836F6F50", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EMNDIHDFIPD))]
	protected override Task PDNAOFOALBA(DPBMEMKDFAC CPNHGIEOMKO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class FAFHCAIJIMH
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class JNGKBFGPDHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public JMPAFDOMFIK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public FEKMMALKIBN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public FAFHCAIJIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JNGKBFGPDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x4296AE0", Offset = "0x4295CE0", VA = "0x184296AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class EKNIFOLOJIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public FAFHCAIJIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EKNIFOLOJIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class ELJCLNJGBJP
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private sealed class <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public ELJCLNJGBJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x5C3C100", Offset = "0x5C3B300", VA = "0x185C3C100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public FDMIABHIEGI<string>.JOOBNAKNCND handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public EKNIFOLOJIK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public ELJCLNJGBJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x428F080", Offset = "0x428E280", VA = "0x18428F080")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task NEOLIMLHENL(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class GMFBLGGKBHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public FAFHCAIJIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EKNIFOLOJIK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private ELJCLNJGBJP <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GMFBLGGKBHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x4291940", Offset = "0x4290B40", VA = "0x184291940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class NHJJCLHOIIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public FAFHCAIJIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private Dictionary<Guid, List<JKOJPLCGJGM>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private KeyValuePair<Guid, List<JKOJPLCGJGM>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NHJJCLHOIIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x429C340", Offset = "0x429B540", VA = "0x18429C340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class JMNELOLILID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public FAFHCAIJIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private IPBPMMLOKDP <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private Dictionary<Guid, List<JKOJPLCGJGM>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private KeyValuePair<Guid, List<JKOJPLCGJGM>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JMNELOLILID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x4296500", Offset = "0x4295700", VA = "0x184296500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class OKHCFBGFAIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		private sealed class <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public JKOJPLCGJGM handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public OKHCFBGFAIH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DC")]
			[Cpp2IlInjected.Address(RVA = "0x5C39870", Offset = "0x5C38A70", VA = "0x185C39870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public JMGDOOFECAA runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public List<JKOJPLCGJGM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OKHCFBGFAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x429E4C0", Offset = "0x429D6C0", VA = "0x18429E4C0")]
		internal object BGPNKIEKPFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x429E6A0", Offset = "0x429D8A0", VA = "0x18429E6A0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task ILNHPNALMGI(JKOJPLCGJGM handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x429E5B0", Offset = "0x429D7B0", VA = "0x18429E5B0")]
		internal object DBNNGLONEBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class BOAAKONNDGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public List<JKOJPLCGJGM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public JMGDOOFECAA runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public FAFHCAIJIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private OKHCFBGFAIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private IEnumerable<Task> <handlerTasks>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BOAAKONNDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x428BFF0", Offset = "0x428B1F0", VA = "0x18428BFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class MCCLPAHAIBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public FAFHCAIJIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MCCLPAHAIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x429A410", Offset = "0x4299610", VA = "0x18429A410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class PHIFOJGEMDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PHIFOJGEMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x429EE10", Offset = "0x429E010", VA = "0x18429EE10")]
		internal object AJDPOIHJMKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class FNAJGIIGNKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public FAFHCAIJIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private PHIFOJGEMDI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private IPBPMMLOKDP <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private List<JKOJPLCGJGM> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FNAJGIIGNKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x4290330", Offset = "0x428F530", VA = "0x184290330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class AEIHMGHAKFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public AEIHMGHAKFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x428B760", Offset = "0x428A960", VA = "0x18428B760")]
		internal object FKFAPNHJFEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class NHNIPKKLBAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public FAFHCAIJIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private AEIHMGHAKFG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private BLGLLGBBDII <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private BLGLLGBBDII <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private BLGLLGBBDII <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<BLGLLGBBDII> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NHNIPKKLBAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x429D030", Offset = "0x429C230", VA = "0x18429D030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class ECNJOJFFFCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public ECNJOJFFFCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x428D680", Offset = "0x428C880", VA = "0x18428D680")]
		internal object KALIHMACGNJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private readonly DPBMEMKDFAC CPNHGIEOMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private MBFHBMOLDFG AFLKFGGONHO;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private ILAIPNDOCNE FBHIPHECEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xB33020", Offset = "0xB32220", VA = "0x180B33020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A20", Offset = "0x8D6C20", VA = "0x1808D7A20")]
	public FAFHCAIJIMH(DPBMEMKDFAC CPNHGIEOMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x2D20720", Offset = "0x2D1F920", VA = "0x182D20720")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JNGKBFGPDHC))]
	public Task ONDGBMOLAPF(JMPAFDOMFIK CMGBFAPDNEF, FEKMMALKIBN IDDOFILHGPI, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F510", Offset = "0x2D1E710", VA = "0x182D1F510")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GMFBLGGKBHG))]
	private Task DABICLODEFN(FEKMMALKIBN JCEJEOAKGOJ, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F6B0", Offset = "0x2D1E8B0", VA = "0x182D1F6B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHJJCLHOIIO))]
	private Task DKPLLHBKHLB(FEKMMALKIBN JCEJEOAKGOJ, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x2D1FF50", Offset = "0x2D1F150", VA = "0x182D1FF50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JMNELOLILID))]
	private Task KELHIEKKAED(FEKMMALKIBN JCEJEOAKGOJ, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x2D1FD80", Offset = "0x2D1EF80", VA = "0x182D1FD80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BOAAKONNDGK))]
	private Task HLODJKKPEDI(Guid NCDFHONANJO, List<JKOJPLCGJGM> GJFKDHPEMED, JMGDOOFECAA PDKJENJDALN, FEKMMALKIBN JCEJEOAKGOJ, CancellationToken IBIKCCMDMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D20580", Offset = "0x2D1F780", VA = "0x182D20580")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MCCLPAHAIBC))]
	private Task OKJNPPCCMCI(FEKMMALKIBN JCEJEOAKGOJ, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2D1FA20", Offset = "0x2D1EC20", VA = "0x182D1FA20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FNAJGIIGNKF))]
	private Task FLPPFKLNGCB(Guid HLICKIEJFIK, FEKMMALKIBN JCEJEOAKGOJ, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D20220", Offset = "0x2D1F420", VA = "0x182D20220")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHNIPKKLBAG))]
	private Task NGJJLFFAJEM(Guid HLICKIEJFIK, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D1FBE0", Offset = "0x2D1EDE0", VA = "0x182D1FBE0")]
	private void HBICOGHNLME(Guid HLICKIEJFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x2D200F0", Offset = "0x2D1F2F0", VA = "0x182D200F0")]
	private void MMGJGLFPNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x2D203C0", Offset = "0x2D1F5C0", VA = "0x182D203C0")]
	public Guid NNDGMPHLEKK(JMPAFDOMFIK LKHDJIAPGHE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F850", Offset = "0x2D1EA50", VA = "0x182D1F850")]
	[CompilerGenerated]
	private object DNPBHPOLNGJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal struct BPGEBDKMLIE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private readonly DPBMEMKDFAC CPNHGIEOMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private readonly Guid ODJALLBHBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private bool LKCMOCEILKH;

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DC70", Offset = "0x2D0CE70", VA = "0x182D0DC70")]
	public static BPGEBDKMLIE LIBKAHAKOGA(DPBMEMKDFAC CPNHGIEOMKO)
	{
		return default(BPGEBDKMLIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x20EA7C0", Offset = "0x20E99C0", VA = "0x1820EA7C0")]
	public void EPBFCIAMBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D920", Offset = "0x2D0CB20", VA = "0x182D0D920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DCD0", Offset = "0x2D0CED0", VA = "0x182D0DCD0")]
	private BPGEBDKMLIE(DPBMEMKDFAC CPNHGIEOMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D930", Offset = "0x2D0CB30", VA = "0x182D0D930")]
	private void KFNNOLGGNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D870", Offset = "0x2D0CA70", VA = "0x182D0D870")]
	private Func<Guid, bool> ADNMIGLDAPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal struct LEKLLMMIJEC
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class FKNJFHONNDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public AsyncTaskMethodBuilder<LKOCAIKGKMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public LEKLLMMIJEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private LKOCAIKGKMD <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter<LKOCAIKGKMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FKNJFHONNDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x428FF00", Offset = "0x428F100", VA = "0x18428FF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class JOHFJGGCNAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public AsyncTaskMethodBuilder<LKOCAIKGKMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public LEKLLMMIJEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private LKOCAIKGKMD <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private LKOCAIKGKMD <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter<LKOCAIKGKMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JOHFJGGCNAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x4296E70", Offset = "0x4296070", VA = "0x184296E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class GOEPHKGHIHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GOEPHKGHIHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x10CF3A0", Offset = "0x10CE5A0", VA = "0x1810CF3A0")]
		internal bool KADDJBHEIEM(GONBIMCIPLJ sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class NHAAMNBCPAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public AsyncTaskMethodBuilder<LKOCAIKGKMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public FGKLHHEMEMB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public DLJGDNEKCBH superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private GOEPHKGHIHI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private ODLKOJAEFAL <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private GONBIMCIPLJ <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private DLJGDNEKCBH <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private DLJGDNEKCBH <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private ODLKOJAEFAL <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private LDOOKNNGNOF <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private LDOOKNNGNOF <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private KCDJMIOEEPA <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private KCDJMIOEEPA <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private TaskAwaiter<ODLKOJAEFAL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private TaskAwaiter<LDOOKNNGNOF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private TaskAwaiter<KCDJMIOEEPA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NHAAMNBCPAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x429B590", Offset = "0x429A790", VA = "0x18429B590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private FGKLHHEMEMB JCECDDPGEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private PHLPMAPMHHI CFKKPPPPOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private long LNBFDCAEKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private long GLLEENOIFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private long FLFKBNIMKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private string DPPPGPGBEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private DLJGDNEKCBH HNEFGELDJJL;

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x36F21A0", Offset = "0x36F13A0", VA = "0x1836F21A0")]
	public static Task<LKOCAIKGKMD> IJICNGGIEKC(KCLMMCNCBHA COENACEECKL, IHKLGONHBKF JFILJIAPEEP, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x36F2830", Offset = "0x36F1A30", VA = "0x1836F2830")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FKNJFHONNDM))]
	private Task<LKOCAIKGKMD> ONDGBMOLAPF(CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x36F2440", Offset = "0x36F1640", VA = "0x1836F2440")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JOHFJGGCNAF))]
	private Task<LKOCAIKGKMD> NDKOAPEMLNC(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x36F2600", Offset = "0x36F1800", VA = "0x1836F2600")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHAAMNBCPAF))]
	private static Task<LKOCAIKGKMD> NDKOAPEMLNC(FGKLHHEMEMB JCECDDPGEKA, long LNBFDCAEKJF, long GLLEENOIFOJ, long FLFKBNIMKBB, string DPPPGPGBEBC, DLJGDNEKCBH HNEFGELDJJL, CancellationToken PLEKJLHDOLP, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x36F2110", Offset = "0x36F1310", VA = "0x1836F2110")]
	private void BCELFJAPNIB(ODLKOJAEFAL NLENBJFJHPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal struct ENFLKJJEBIC
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class BHKFNFKJCIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public KCLMMCNCBHA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BHKFNFKJCIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x428BDF0", Offset = "0x428AFF0", VA = "0x18428BDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class GPCCDAECGCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public ENFLKJJEBIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GPCCDAECGCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x42922B0", Offset = "0x42914B0", VA = "0x1842922B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private FEKMMALKIBN JCEJEOAKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private ByteString GIOKKDKJOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private DPBMEMKDFAC CPNHGIEOMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	private bool KENOHEBAIJH;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private FGKLHHEMEMB HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F0D0", Offset = "0x2D1E2D0", VA = "0x182D1F0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private bool NALCCFFMOHE
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F120", Offset = "0x2D1E320", VA = "0x182D1F120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private bool APCBMCONCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F040", Offset = "0x2D1E240", VA = "0x182D1F040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F330", Offset = "0x2D1E530", VA = "0x182D1F330")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BHKFNFKJCIP))]
	public static Task ONDGBMOLAPF(KCLMMCNCBHA COENACEECKL, FEKMMALKIBN JCEJEOAKGOJ, DPBMEMKDFAC CPNHGIEOMKO, bool KENOHEBAIJH, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F1A0", Offset = "0x2D1E3A0", VA = "0x182D1F1A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GPCCDAECGCM))]
	private Task ONDGBMOLAPF(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal static class PPOKPGNHHEI
{
	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x3700510", Offset = "0x36FF710", VA = "0x183700510")]
	public static void BCGPJPDDMFH(this POMIGJLEENF DPJIIADICCM, MDCIINLFDMH JMJJBHAFLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x3700490", Offset = "0x36FF690", VA = "0x183700490")]
	public static void ANAAFNLJJLI(this MDCIINLFDMH IBCKECGKAII, [Optional] string CEOMJLPEFPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct PEPAENHAIPO
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class OIJBPKFADJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public PEPAENHAIPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OIJBPKFADJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x5C39420", Offset = "0x5C38620", VA = "0x185C39420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private const int LPFEHMONIAO = 20;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private const float JHPKCFEIMGC = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private FGKLHHEMEMB JCECDDPGEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private FEKMMALKIBN JCEJEOAKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private float OEGACKADFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private float NHBFEHAGFCD;

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x36FD300", Offset = "0x36FC500", VA = "0x1836FD300")]
	public static Task PDDJIKMKNEJ(KCLMMCNCBHA COENACEECKL, FEKMMALKIBN JCEJEOAKGOJ, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x36FD1B0", Offset = "0x36FC3B0", VA = "0x1836FD1B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OIJBPKFADJP))]
	public Task ONDGBMOLAPF(CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x36FCE00", Offset = "0x36FC000", VA = "0x1836FCE00")]
	private static void HHKBEPNBLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x36FCFB0", Offset = "0x36FC1B0", VA = "0x1836FCFB0")]
	private void IIHENFMBGDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x36FCD50", Offset = "0x36FBF50", VA = "0x1836FCD50")]
	private static float FDGCKDFDMOF(FGKLHHEMEMB JCECDDPGEKA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x36FD190", Offset = "0x36FC390", VA = "0x1836FD190")]
	private static float IKGNHPPBPOK()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal class DPBMEMKDFAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class PBKIFDFCOJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AsyncTaskMethodBuilder<BLGLLGBBDII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public BLGLLGBBDII roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public DPBMEMKDFAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private BLGLLGBBDII <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private LIAOPDCMOJN.AGGGIDDBOGP<BLGLLGBBDII> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter<LIAOPDCMOJN.AGGGIDDBOGP<BLGLLGBBDII>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PBKIFDFCOJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x42C6AF0", Offset = "0x42C5CF0", VA = "0x1842C6AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct FIJKDLOFFEL<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class CLMGACEKPHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public BLGLLGBBDII roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CLMGACEKPHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x42B8000", Offset = "0x42B7200", VA = "0x1842B8000")]
		internal BLGLLGBBDII IPDKIHIBKML(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class NPJPAGIBLFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AsyncTaskMethodBuilder<LIAOPDCMOJN.AGGGIDDBOGP<BLGLLGBBDII>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public BLGLLGBBDII roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public DPBMEMKDFAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private CLMGACEKPHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private PIPBFFKIFBF <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private LIAOPDCMOJN.AGGGIDDBOGP<BLGLLGBBDII> <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private PIPBFFKIFBF <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private LIAOPDCMOJN.AGGGIDDBOGP<BLGLLGBBDII> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private string <errorMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private ByteString <actualOperationId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private string <errorMessage>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter<LIAOPDCMOJN.AGGGIDDBOGP<BLGLLGBBDII>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NPJPAGIBLFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x42C4340", Offset = "0x42C3540", VA = "0x1842C4340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class AMFCPBDBIOJ<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public DPBMEMKDFAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private T <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public AMFCPBDBIOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x392F520", Offset = "0x392E720", VA = "0x18392F520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class LDGMHLPEEGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public DPBMEMKDFAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LDGMHLPEEGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x42C0A10", Offset = "0x42BFC10", VA = "0x1842C0A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class LKKIOFLBPJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LKKIOFLBPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x42C0E00", Offset = "0x42C0000", VA = "0x1842C0E00")]
		internal object ODNFGEIJAIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x42C0CF0", Offset = "0x42BFEF0", VA = "0x1842C0CF0")]
		internal bool CIDKEKADMKO(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class KPDPJFMHPOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KPDPJFMHPOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x42C09B0", Offset = "0x42BFBB0", VA = "0x1842C09B0")]
		internal object BCDAGBADHOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class NOCBLCNLLMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NOCBLCNLLMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x42C42D0", Offset = "0x42C34D0", VA = "0x1842C42D0")]
		internal object OLICMCCHPPE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private sealed class HJKLBOFEAPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HJKLBOFEAPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x42BFA90", Offset = "0x42BEC90", VA = "0x1842BFA90")]
		internal object HDGPAJHIDNC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class MOKPMEHMNLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public DPBMEMKDFAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MOKPMEHMNLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x42C38D0", Offset = "0x42C2AD0", VA = "0x1842C38D0")]
		internal object HAIAEACGODG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class MMPIDOCBGHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public DPBMEMKDFAC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MMPIDOCBGHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x42C3630", Offset = "0x42C2830", VA = "0x1842C3630")]
		internal object HAIAEACGODG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private static readonly Guid KFLPBHMLFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public readonly ILAIPNDOCNE FBHIPHECEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private readonly LIAOPDCMOJN LPGGOAOJDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private readonly DGFEKNNEOCH BIHEKONDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private readonly JOMLHIGAINO OJLIAFIHFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	private bool FALBPHEHLDN;

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A220", Offset = "0x2D19420", VA = "0x182D1A220")]
	public DPBMEMKDFAC(ILAIPNDOCNE IAFPJLJBHFI, LIAOPDCMOJN LPGGOAOJDAJ, DGFEKNNEOCH BIHEKONDPKH, JOMLHIGAINO OJLIAFIHFCA, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2D18F90", Offset = "0x2D18190", VA = "0x182D18F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2D18F90", Offset = "0x2D18190", VA = "0x182D18F90")]
	public void ENEBJGALICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2D19560", Offset = "0x2D18760", VA = "0x182D19560")]
	public void HCCFJELDPFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A050", Offset = "0x2D19250", VA = "0x182D1A050")]
	public void POKCJBMGGKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2D197A0", Offset = "0x2D189A0", VA = "0x182D197A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBKIFDFCOJL))]
	internal Task<BLGLLGBBDII> IBBJNNPCJJC(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, BLGLLGBBDII CCFNHFGLHCD, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C290", Offset = "0x2C0B490", VA = "0x182C0C290")]
	private static byte[] BCDECIGMNPP<T>(T CEOMJLPEFPB) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C380", Offset = "0x2C0B580", VA = "0x182C0C380")]
	private static T HMBDGFNHBNP<T>(MessageParser<T> MLEOGDCBDEG, byte[] CEOMJLPEFPB, T NKFNPAPLNGH) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x2D19140", Offset = "0x2D18340", VA = "0x182D19140")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NPJPAGIBLFD))]
	private Task<LIAOPDCMOJN.AGGGIDDBOGP<BLGLLGBBDII>> EAOCIBJBDBB(BLGLLGBBDII CCFNHFGLHCD, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C730", Offset = "0x2C0B930", VA = "0x182C0C730")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMFCPBDBIOJ<>))]
	internal Task<T> IHLKCHDHGJF<T>(CancellationToken NNJAJHKDGKL, Func<CancellationToken, Task<T>> EGNEBIKKLCO, int AOCBBDIPGGH = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2D19960", Offset = "0x2D18B60", VA = "0x182D19960")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LDGMHLPEEGA))]
	internal Task IHLKCHDHGJF(CancellationToken NNJAJHKDGKL, Func<CancellationToken, Task> EGNEBIKKLCO, int AOCBBDIPGGH = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x2D19710", Offset = "0x2D18910", VA = "0x182D19710")]
	public BLGLLGBBDII HLBDEOFGFIJ(PIPBFFKIFBF NCKPHKOBCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2D18F20", Offset = "0x2D18120", VA = "0x182D18F20")]
	public NAMKBNPIOMO DLFFIMIJLPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2D18B90", Offset = "0x2D17D90", VA = "0x182D18B90")]
	public DLKJANMPNAB BDPCIMALBHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2D19310", Offset = "0x2D18510", VA = "0x182D19310")]
	public LGCHJFHJHIL GMBOJOKDOAG([Optional] MBPNBFDACPD? ALHJKEONHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2D192E0", Offset = "0x2D184E0", VA = "0x182D192E0")]
	public void GGFLKILEIEK(Func<Guid, bool> KKHDHHGCHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2D189B0", Offset = "0x2D17BB0", VA = "0x182D189B0")]
	public void AKGCAGJDFFH(Func<Guid, bool> NAHINHEOLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2D19EB0", Offset = "0x2D190B0", VA = "0x182D19EB0")]
	public void MKLEGGKDBMM(Func<Guid, bool> KKHDHHGCHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2D19C90", Offset = "0x2D18E90", VA = "0x182D19C90")]
	public Guid LIBKAHAKOGA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x2D19AF0", Offset = "0x2D18CF0", VA = "0x182D19AF0")]
	public void KFNNOLGGNPJ(Guid ODJALLBHBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2D19410", Offset = "0x2D18610", VA = "0x182D19410")]
	public void GNJEGCHECJI(BLGLLGBBDII AGEBOEODANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2D18C00", Offset = "0x2D17E00", VA = "0x182D18C00")]
	public void DJGNNKLAGEN(string DAIEOOCLKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2D18D90", Offset = "0x2D17F90", VA = "0x182D18D90")]
	public void DJGNNKLAGEN(Func<string> OPIJOGKNAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C2A0", Offset = "0x2C0B4A0", VA = "0x182C0C2A0")]
	private T CBAKNPBIAPP<T>(T ACKOJNNBEBO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x2D196C0", Offset = "0x2D188C0", VA = "0x182D196C0")]
	public void HHPAPLNPPGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C930", Offset = "0x2C0BB30", VA = "0x182C0C930")]
	[CompilerGenerated]
	internal static string OCNCNMIGJML<T>(byte[] KJNADKBIDLI, int BCDOOFLOGMD, ref FIJKDLOFFEL<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal struct HCAAIAKMIPD
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class EEABJDAFJJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public KCLMMCNCBHA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EEABJDAFJJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x428D6F0", Offset = "0x428C8F0", VA = "0x18428D6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class CGNLBOCBBDO
	{
		[Cpp2IlInjected.Token(Token = "0x200012A")]
		private sealed class <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			public FDMIABHIEGI<string>.JOOBNAKNCND timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public CGNLBOCBBDO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			private FDMIABHIEGI<string>.JOOBNAKNCND <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(RVA = "0x5C3C280", Offset = "0x5C3B480", VA = "0x185C3C280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CGNLBOCBBDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x428CB20", Offset = "0x428BD20", VA = "0x18428CB20")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task NNLHHCGDJBE(FDMIABHIEGI<string>.JOOBNAKNCND timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class EEDEBPHJOMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public HCAAIAKMIPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private CGNLBOCBBDO <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private BLGLLGBBDII <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter<BLGLLGBBDII> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EEDEBPHJOMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x428D8A0", Offset = "0x428CAA0", VA = "0x18428D8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class IPJKCAFILNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public OALBBBOJDGP version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public IPJKCAFILNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x4295040", Offset = "0x4294240", VA = "0x184295040")]
		internal object KDALJMLAGGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x4295120", Offset = "0x4294320", VA = "0x184295120")]
		internal object KPLBCMCLADC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private FEKMMALKIBN JCEJEOAKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private DPBMEMKDFAC CPNHGIEOMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private bool JMLNDFHODLD;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private static readonly ByteString GJHFPJPOPJF;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private FGKLHHEMEMB HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2D27220", Offset = "0x2D26420", VA = "0x182D27220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private KOIGEBDLLEK PJNHDMFJAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2D27270", Offset = "0x2D26470", VA = "0x182D27270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x2D27C10", Offset = "0x2D26E10", VA = "0x182D27C10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EEABJDAFJJL))]
	public static Task ONDGBMOLAPF(KCLMMCNCBHA COENACEECKL, FEKMMALKIBN JCEJEOAKGOJ, DPBMEMKDFAC CPNHGIEOMKO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP, bool JMLNDFHODLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x2D27A90", Offset = "0x2D26C90", VA = "0x182D27A90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EEDEBPHJOMI))]
	private Task ONDGBMOLAPF(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x2D27350", Offset = "0x2D26550", VA = "0x182D27350")]
	private void NFFCENDFNKL([NotNull] PIKKGCCILDN PNICJAKMKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x2D272F0", Offset = "0x2D264F0", VA = "0x182D272F0")]
	private bool KEEAOOMGHPC(OALBBBOJDGP EJEDLELNMDA, PIKKGCCILDN PNICJAKMKDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal abstract class PNGJBJMNIMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ILAIPNDOCNE FBHIPHECEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly DPBMEMKDFAC DHCEBEFNCBA;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public FGKLHHEMEMB HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x3700250", Offset = "0x36FF450", VA = "0x183700250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public KOIGEBDLLEK PJNHDMFJAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x37002B0", Offset = "0x36FF4B0", VA = "0x1837002B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x3700310", Offset = "0x36FF510", VA = "0x183700310")]
	protected PNGJBJMNIMG(DPBMEMKDFAC CPNHGIEOMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x3700290", Offset = "0x36FF490", VA = "0x183700290")]
	protected void DJGNNKLAGEN(string DAIEOOCLKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x3700270", Offset = "0x36FF470", VA = "0x183700270")]
	public void DJGNNKLAGEN(Func<string> OPIJOGKNAMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class DLKJANMPNAB : PNGJBJMNIMG, EBMFPPDAIBE
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	public delegate Task<JMPAFDOMFIK> DPIFCGKCFPK(FEKMMALKIBN JCEJEOAKGOJ, BCCKLEDHADN BIMPHFPCCNC, NJJJDBEKHBD IEMCCPFJDNF, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class DEFMBMBPGGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public IHKLGONHBKF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private BPGEBDKMLIE <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private BLGLLGBBDII <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private BLGLLGBBDII <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private TaskAwaiter<BLGLLGBBDII> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DEFMBMBPGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x42B80C0", Offset = "0x42B72C0", VA = "0x1842B80C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class AJLMIPFJGOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public AsyncTaskMethodBuilder<BLGLLGBBDII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public IHKLGONHBKF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private BLGLLGBBDII <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private BLGLLGBBDII <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter<BLGLLGBBDII> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public AJLMIPFJGOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x42B4AC0", Offset = "0x42B3CC0", VA = "0x1842B4AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class CBLFEDAOAHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public IHKLGONHBKF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CBLFEDAOAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x42B7100", Offset = "0x42B6300", VA = "0x1842B7100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class OIKDKBJGCFN
	{
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000524")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public AsyncTaskMethodBuilder<LKOCAIKGKMD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			public OIKDKBJGCFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			private LKOCAIKGKMD <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			private LKOCAIKGKMD <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			private TaskAwaiter<JMPAFDOMFIK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			private TaskAwaiter<LKOCAIKGKMD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x5C3ADF0", Offset = "0x5C39FF0", VA = "0x185C3ADF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000135")]
		private sealed class <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public AsyncTaskMethodBuilder<FEKMMALKIBN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public OIKDKBJGCFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private FEKMMALKIBN <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private FEKMMALKIBN <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private TaskAwaiter<JMPAFDOMFIK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter<FEKMMALKIBN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x5C3B540", Offset = "0x5C3A740", VA = "0x185C3B540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000136")]
		private sealed class <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			public OIKDKBJGCFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			private bool <isReloadingSceneForObjectModel>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private bool <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private BCCKLEDHADN <timedYielder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			private TaskAwaiter<JMPAFDOMFIK> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x5C399D0", Offset = "0x5C38BD0", VA = "0x185C399D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public IHKLGONHBKF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public NJJJDBEKHBD preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public NJJJDBEKHBD downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public LKOCAIKGKMD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public NJJJDBEKHBD postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public FEKMMALKIBN phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public IDFOFNFJIKL.DBKAFHNIHIC <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OIKDKBJGCFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x42C4E40", Offset = "0x42C4040", VA = "0x1842C4E40")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<LKOCAIKGKMD> HAIKLNODOPN(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x42C4FB0", Offset = "0x42C41B0", VA = "0x1842C4FB0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<FEKMMALKIBN> LIENOHPDEJP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x42C5120", Offset = "0x42C4320", VA = "0x1842C5120")]
		internal void MLAIJABMEMJ(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x42C4CF0", Offset = "0x42C3EF0", VA = "0x1842C4CF0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task GJDHGBJNICO(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class DFIMHHCNNOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public IHKLGONHBKF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private OIKDKBJGCFN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private LKOCAIKGKMD <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private FEKMMALKIBN <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private TaskAwaiter<LKOCAIKGKMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<FEKMMALKIBN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DFIMHHCNNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x42B84E0", Offset = "0x42B76E0", VA = "0x1842B84E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class PMPBDCLCAJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PMPBDCLCAJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x42C8010", Offset = "0x42C7210", VA = "0x1842C8010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class GJJHDCHFFPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public NJJJDBEKHBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private TaskAwaiter<JMPAFDOMFIK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GJJHDCHFFPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x42BDAF0", Offset = "0x42BCCF0", VA = "0x1842BDAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class HIOPINJDGLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public AsyncTaskMethodBuilder<JMPAFDOMFIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public BCCKLEDHADN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public NJJJDBEKHBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private TaskAwaiter<JMPAFDOMFIK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HIOPINJDGLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x42BEEC0", Offset = "0x42BE0C0", VA = "0x1842BEEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class MLHPDCADBDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public AsyncTaskMethodBuilder<JMPAFDOMFIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public BCCKLEDHADN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public NJJJDBEKHBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private TaskAwaiter<JMPAFDOMFIK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MLHPDCADBDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x42C2950", Offset = "0x42C1B50", VA = "0x1842C2950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class BAIBCJBOKMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public AsyncTaskMethodBuilder<JMPAFDOMFIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public JMPAFDOMFIK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public FEKMMALKIBN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public NJJJDBEKHBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private JMPAFDOMFIK <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private JMPAFDOMFIK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private TaskAwaiter<JMPAFDOMFIK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BAIBCJBOKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x42B5910", Offset = "0x42B4B10", VA = "0x1842B5910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class JEGMFFMJODH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public NJJJDBEKHBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public DPIFCGKCFPK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public BCCKLEDHADN timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JEGMFFMJODH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class LPBFEGNKBCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			public AsyncTaskMethodBuilder<JMPAFDOMFIK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public LPBFEGNKBCB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			private JMPAFDOMFIK <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private JMPAFDOMFIK <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private TaskAwaiter<JMPAFDOMFIK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x5C3BB30", Offset = "0x5C3AD30", VA = "0x185C3BB30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public JMPAFDOMFIK originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public JEGMFFMJODH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LPBFEGNKBCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x42C1E30", Offset = "0x42C1030", VA = "0x1842C1E30")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<JMPAFDOMFIK> CJAAELPCCGI(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class MAPOPJMPLJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AsyncTaskMethodBuilder<JMPAFDOMFIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public BCCKLEDHADN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public NJJJDBEKHBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public DPIFCGKCFPK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private JEGMFFMJODH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private LPBFEGNKBCB <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private JMPAFDOMFIK <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter<JMPAFDOMFIK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MAPOPJMPLJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x42C1FA0", Offset = "0x42C11A0", VA = "0x1842C1FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class LOAJMHFFIEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public NJJJDBEKHBD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private JMPAFDOMFIK <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private IEnumerator<JMPAFDOMFIK> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private JMPAFDOMFIK <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter<JMPAFDOMFIK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LOAJMHFFIEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x42C1A30", Offset = "0x42C0C30", VA = "0x1842C1A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class IBBPKMPMEDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public IBBPKMPMEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x42BFB00", Offset = "0x42BED00", VA = "0x1842BFB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class LJNIPLNPOBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public DLKJANMPNAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LJNIPLNPOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x42C0BA0", Offset = "0x42BFDA0", VA = "0x1842C0BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class FIEFLABFDJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public ODLKOJAEFAL roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FIEFLABFDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x42BCF80", Offset = "0x42BC180", VA = "0x1842BCF80")]
		internal object CFBILIKLOGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private readonly NNFJPPGGOPL BMOBAHFMLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly NNFJPPGGOPL BFJCLKMIMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly PHLPMAPMHHI CFKKPPPPOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly FAFHCAIJIMH AFLKFGGONHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly PFNKBBLBMGP JAOCBJOMGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly OLPMEMOFGMN FCHFGDDAOIN;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float FOFMFJFACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x2D15D40", Offset = "0x2D14F40", VA = "0x182D15D40", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private KCLMMCNCBHA DCNGDMOHPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2D16D50", Offset = "0x2D15F50", VA = "0x182D16D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event LCCNGFINBNI HLBPLMGPMFA
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2D16F10", Offset = "0x2D16110", VA = "0x182D16F10", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2D15A90", Offset = "0x2D14C90", VA = "0x182D15A90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x2D17AF0", Offset = "0x2D16CF0", VA = "0x182D17AF0")]
	public DLKJANMPNAB(DPBMEMKDFAC CPNHGIEOMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x2D16B70", Offset = "0x2D15D70", VA = "0x182D16B70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DEFMBMBPGGH))]
	public Task JLEOKOBJEJP(IHKLGONHBKF JFILJIAPEEP, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x2D16820", Offset = "0x2D15A20", VA = "0x182D16820")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AJLMIPFJGOK))]
	private Task<BLGLLGBBDII> JEEKINBBAHJ(IHKLGONHBKF JFILJIAPEEP, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x2D15D60", Offset = "0x2D14F60", VA = "0x182D15D60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CBLFEDAOAHB))]
	private Task EBMBLOLOBPB(IHKLGONHBKF JFILJIAPEEP, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x2D16320", Offset = "0x2D15520", VA = "0x182D16320")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DFIMHHCNNOF))]
	private Task HCOEPJGNBME(IHKLGONHBKF JFILJIAPEEP, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken JFBGNCGJLGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x2D164F0", Offset = "0x2D156F0", VA = "0x182D164F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PMPBDCLCAJE))]
	private Task HMCNCGAFJPN(FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2D175B0", Offset = "0x2D167B0", VA = "0x182D175B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GJJHDCHFFPC))]
	private Task NLIHAJGOJHB(FEKMMALKIBN JCEJEOAKGOJ, NJJJDBEKHBD IEMCCPFJDNF, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2D15F00", Offset = "0x2D15100", VA = "0x182D15F00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HIOPINJDGLH))]
	private Task<JMPAFDOMFIK> FEPMEOLPNBH(FEKMMALKIBN JCEJEOAKGOJ, BCCKLEDHADN BJOENEBOOPC, NJJJDBEKHBD IEMCCPFJDNF, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x2D16110", Offset = "0x2D15310", VA = "0x182D16110")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MLHPDCADBDF))]
	private Task<JMPAFDOMFIK> FGMPAEJDHLN(FEKMMALKIBN JCEJEOAKGOJ, BCCKLEDHADN BJOENEBOOPC, NJJJDBEKHBD IEMCCPFJDNF, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x2D170F0", Offset = "0x2D162F0", VA = "0x182D170F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BAIBCJBOKMH))]
	private Task<JMPAFDOMFIK> LBFLBEKELNC(JMPAFDOMFIK CMGBFAPDNEF, FEKMMALKIBN IDDOFILHGPI, NJJJDBEKHBD IEMCCPFJDNF, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP, bool IKBIHPODCEL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x2D174B0", Offset = "0x2D166B0", VA = "0x182D174B0")]
	private bool NEDHCJICJNA(FEKMMALKIBN DLMOOBMHFPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2D15AF0", Offset = "0x2D14CF0", VA = "0x182D15AF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MAPOPJMPLJE))]
	protected Task<JMPAFDOMFIK> CJMIIDLMHGB(FEKMMALKIBN JCEJEOAKGOJ, BCCKLEDHADN BJOENEBOOPC, NJJJDBEKHBD IEMCCPFJDNF, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP, DPIFCGKCFPK LKIMGJNIKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2D16660", Offset = "0x2D15860", VA = "0x182D16660")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LOAJMHFFIEN))]
	private Task IFNGOKEECDJ(FEKMMALKIBN JCEJEOAKGOJ, NJJJDBEKHBD IEMCCPFJDNF, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2D15A40", Offset = "0x2D14C40", VA = "0x182D15A40")]
	private void AIBAEKDLDML(JMPAFDOMFIK LKHDJIAPGHE, NJJJDBEKHBD IEMCCPFJDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2D15AB0", Offset = "0x2D14CB0", VA = "0x182D15AB0")]
	private void BIFGPNFNNJN(JMPAFDOMFIK MPHHDMCFBJG, out JMPAFDOMFIK GJIFLMCDCHP, out JMPAFDOMFIK BNIOICMCJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2D17470", Offset = "0x2D16670", VA = "0x182D17470")]
	private Task<LKOCAIKGKMD> NDKOAPEMLNC(IHKLGONHBKF JFILJIAPEEP, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2D16D10", Offset = "0x2D15F10", VA = "0x182D16D10")]
	private Task<FEKMMALKIBN> KJLLCEEJLMD(LKOCAIKGKMD JCEJEOAKGOJ, IDFOFNFJIKL.DBKAFHNIHIC NKLNPBABDBB, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x2D16F30", Offset = "0x2D16130", VA = "0x182D16F30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IBBPKMPMEDK))]
	private Task LANHNCCPHBL(FEKMMALKIBN JCEJEOAKGOJ, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP, bool JMLNDFHODLD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x2D16D80", Offset = "0x2D15F80", VA = "0x182D16D80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LJNIPLNPOBG))]
	private Task KMOMHFKNJIC(FEKMMALKIBN JCEJEOAKGOJ, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x2D164C0", Offset = "0x2D156C0", VA = "0x182D164C0")]
	private Task HLKFCFIBNFJ(FEKMMALKIBN JCEJEOAKGOJ, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x2D17950", Offset = "0x2D16B50", VA = "0x182D17950")]
	private Task OKJGFCPCIEN(FEKMMALKIBN JCEJEOAKGOJ, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x2D17770", Offset = "0x2D16970", VA = "0x182D17770")]
	private Task ODBDDGHILEP(FEKMMALKIBN JCEJEOAKGOJ, BCCKLEDHADN BJOENEBOOPC, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x2D17790", Offset = "0x2D16990", VA = "0x182D17790")]
	private Task OFGFFOJJJOF(FEKMMALKIBN JCEJEOAKGOJ, BCCKLEDHADN BJOENEBOOPC, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2D17AE0", Offset = "0x2D16CE0", VA = "0x182D17AE0")]
	private static Task PINKLFFAFAF(CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2D16EF0", Offset = "0x2D160F0", VA = "0x182D16EF0")]
	private Task KOINFDJDOGL(FEKMMALKIBN JCEJEOAKGOJ, BCCKLEDHADN BJOENEBOOPC, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2D169E0", Offset = "0x2D15BE0", VA = "0x182D169E0")]
	private Task JGOKIOAHJNA(FEKMMALKIBN JCEJEOAKGOJ, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2D159C0", Offset = "0x2D14BC0", VA = "0x182D159C0")]
	private void ABMPDLNIJPO(IHKLGONHBKF JFILJIAPEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x2D15D20", Offset = "0x2D14F20", VA = "0x182D15D20")]
	public void DIIJJHCHBAM(long EGCEBLMJCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2D17300", Offset = "0x2D16500", VA = "0x182D17300")]
	private static void MLAKBOEPCMH(ODLKOJAEFAL NLENBJFJHPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class ILAIPNDOCNE : EBMFPPDAIBE
{
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public delegate Task ANKICPCDMOJ(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class LICDFFBGKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public FDMIABHIEGI<string>.JOOBNAKNCND operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public ILAIPNDOCNE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LICDFFBGKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x42997F0", Offset = "0x42989F0", VA = "0x1842997F0")]
		internal Task PLJNIBOBLGP(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class INFADGFOMDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public LICDFFBGKBG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public INFADGFOMDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x4294F80", Offset = "0x4294180", VA = "0x184294F80")]
		internal object OFJBGMIEBNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x4294EC0", Offset = "0x42940C0", VA = "0x184294EC0")]
		internal object GFNCACKEPJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class KGEAIOKKNDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public Func<ILAIPNDOCNE, FDMIABHIEGI<string>.JOOBNAKNCND, DPBMEMKDFAC> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public ILAIPNDOCNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private LICDFFBGKBG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private DPBMEMKDFAC <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private BLGLLGBBDII <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private INFADGFOMDA <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter<BLGLLGBBDII> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KGEAIOKKNDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x42971D0", Offset = "0x42963D0", VA = "0x1842971D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class KNDEDONCGPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public ILAIPNDOCNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private ANKICPCDMOJ <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KNDEDONCGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x4298170", Offset = "0x4297370", VA = "0x184298170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	public readonly Guid INMOFOFIJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	public readonly ByteString PLFFOJFCEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	public readonly NLAKPJCOMPN ACEODAOLBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	protected readonly string FCBCFDKFPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private readonly KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private readonly bool LMHJFCPCPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private readonly Queue<ANKICPCDMOJ> PNMEIDOKKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private readonly NJJJDBEKHBD BBNFAANLPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private readonly GJBJJHDBNNK EEIOBIJNMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private bool HEDPNKBMOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	public JMPAFDOMFIK HIBGGLLENKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	public JMPAFDOMFIK EKNOCJGMKHM;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public KCLMMCNCBHA DCNGDMOHPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x8293D0", Offset = "0x8285D0", VA = "0x1808293D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public FGKLHHEMEMB HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A6D0", Offset = "0x2D298D0", VA = "0x182D2A6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public GNHMLIMFFFL MCEDHNPFAAC
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2D2ADD0", Offset = "0x2D29FD0", VA = "0x182D2ADD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public KOIGEBDLLEK PJNHDMFJAGK
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AA10", Offset = "0x2D29C10", VA = "0x182D2AA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public float FOFMFJFACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A890", Offset = "0x2D29A90", VA = "0x182D2A890", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event LCCNGFINBNI HLBPLMGPMFA
	{
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2D2ADB0", Offset = "0x2D29FB0", VA = "0x182D2ADB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A6B0", Offset = "0x2D298B0", VA = "0x182D2A6B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B140", Offset = "0x2D2A340", VA = "0x182D2B140")]
	protected ILAIPNDOCNE(Guid HPINIPGLIPD, KCLMMCNCBHA COENACEECKL, NLAKPJCOMPN EFMABIDKOGO, string OOCIDNNGEKL, GJBJJHDBNNK EEIOBIJNMEC, bool LMHJFCPCPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x2D2AB20", Offset = "0x2D29D20", VA = "0x182D2AB20", Slot = "7")]
	protected virtual string HOODFCCBJIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A9B0", Offset = "0x2D29BB0", VA = "0x182D2A9B0")]
	public void GOJDBKBOLOG(ANKICPCDMOJ EENKNAANHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A990", Offset = "0x2D29B90", VA = "0x182D2A990")]
	protected void GKNBDDIMNJD(float EDOIJPFKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x2D2AE20", Offset = "0x2D2A020", VA = "0x182D2AE20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KGEAIOKKNDI))]
	public Task ONDGBMOLAPF(CancellationToken PLEKJLHDOLP, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, [Optional] Func<ILAIPNDOCNE, FDMIABHIEGI<string>.JOOBNAKNCND, DPBMEMKDFAC> KOJCGKIEHGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x2D2AFC0", Offset = "0x2D2A1C0", VA = "0x182D2AFC0")]
	private void PBFMNBDCGNB(bool LKCMOCEILKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2D2AB60", Offset = "0x2D29D60", VA = "0x182D2AB60")]
	private void HPLKNOKHOOC(DPBMEMKDFAC CPNHGIEOMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task PDNAOFOALBA(DPBMEMKDFAC CPNHGIEOMKO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A720", Offset = "0x2D29920", VA = "0x182D2A720")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KNDEDONCGPP))]
	private Task DIGAGDHAOGL(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x2D2AA90", Offset = "0x2D29C90", VA = "0x182D2AA90")]
	public BLGLLGBBDII HLBDEOFGFIJ(PIPBFFKIFBF NCKPHKOBCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A8B0", Offset = "0x2D29AB0", VA = "0x182D2A8B0")]
	[CompilerGenerated]
	private Task EEFBLDHPBBO(CancellationToken NIKDBMNECCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal abstract class NHFEEIDLGIP : ILAIPNDOCNE
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class NKKMBIALHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public NHFEEIDLGIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public JJKPEJNDAHF playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NKKMBIALHHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x5C385E0", Offset = "0x5C377E0", VA = "0x185C385E0")]
		internal Task KDJFKLGGKCH(FDMIABHIEGI<string>.JOOBNAKNCND postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x5C38560", Offset = "0x5C37760", VA = "0x185C38560")]
		internal object DEMAPHIIPHM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class GAPKHKGAFFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public NHFEEIDLGIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private NKKMBIALHHC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private MFJNBCGLIDH <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GAPKHKGAFFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x5C355B0", Offset = "0x5C347B0", VA = "0x185C355B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class GGBGAHHOGCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public JJKPEJNDAHF playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public FDMIABHIEGI<string>.JOOBNAKNCND timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public NHFEEIDLGIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GGBGAHHOGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x5C35D90", Offset = "0x5C34F90", VA = "0x185C35D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x36FBAF0", Offset = "0x36FACF0", VA = "0x1836FBAF0")]
	public NHFEEIDLGIP(Guid HPINIPGLIPD, KCLMMCNCBHA COENACEECKL, NLAKPJCOMPN EFMABIDKOGO, string OOCIDNNGEKL, GJBJJHDBNNK EEIOBIJNMEC, bool LMHJFCPCPEA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x36FB950", Offset = "0x36FAB50", VA = "0x1836FB950", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GAPKHKGAFFB))]
	protected override Task PDNAOFOALBA(DPBMEMKDFAC CPNHGIEOMKO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task OGDNCHJDDNH(DPBMEMKDFAC CPNHGIEOMKO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x36FB7B0", Offset = "0x36FA9B0", VA = "0x1836FB7B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GGBGAHHOGCA))]
	private Task PAFBBJCHPOG(IDisposable MGGIHAOGEIN, JJKPEJNDAHF BDIBKCPDOCP, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public readonly struct FAPAGDCIGJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	public readonly PIKKGCCILDN? HBEALCPNAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	public readonly MFPPABHAKIJ KAOEJOIHJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005FB")]
	public readonly string? KJBFFEEFAFM;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public IReadOnlyCollection<string> NOEJMBDMKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2D20900", Offset = "0x2D1FB00", VA = "0x182D20900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public IReadOnlyDictionary<long, int> PKFBCOFOMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2D208E0", Offset = "0x2D1FAE0", VA = "0x182D208E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x2D20920", Offset = "0x2D1FB20", VA = "0x182D20920")]
	public FAPAGDCIGJE(PIKKGCCILDN? ALBGHDBNPBA, MFPPABHAKIJ MBHELAHJDNF, string? KBBAHAIKDJO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct HKABMMDCFLN
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class OMGLIKFIKHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private ILAIPNDOCNE <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private KCLMMCNCBHA <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private MBFOHDGMHHM.EFAAFNPIFCF <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private TaskAwaiter<BLGLLGBBDII> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OMGLIKFIKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x429E7F0", Offset = "0x429D9F0", VA = "0x18429E7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class LBDBLLPHMLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private HHAKNEDDCKI.PFMJGIGAMGD <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LBDBLLPHMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x4298470", Offset = "0x4297670", VA = "0x184298470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x2D29390", Offset = "0x2D28590", VA = "0x182D29390")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMGLIKFIKHJ))]
	public static Task ONDGBMOLAPF(DPBMEMKDFAC CPNHGIEOMKO, FEKMMALKIBN JCEJEOAKGOJ, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x2D290B0", Offset = "0x2D282B0", VA = "0x182D290B0")]
	private static Task<BLGLLGBBDII> FJGHFAIGOLJ(DPBMEMKDFAC CPNHGIEOMKO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x2D29290", Offset = "0x2D28490", VA = "0x182D29290")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBDBLLPHMLD))]
	private static Task FPBHBCOFAOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal class DHINMMNHIHF : ILAIPNDOCNE
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class BFNNHPCAKLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public DHINMMNHIHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private ObscuredInt <localPlayerAccountId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private NAMKBNPIOMO <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private FAPAGDCIGJE <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private HGOCCJHPOPO <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private FELEHJCEPLI <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private TaskAwaiter<FELEHJCEPLI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BFNNHPCAKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x42B6010", Offset = "0x42B5210", VA = "0x1842B6010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private readonly int JGJCFGPMGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private readonly COOLNBMBOGP HJNBJLCLGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	public readonly long MMLPPAMNLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	public readonly long DHBIGNIEOAJ;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public FELEHJCEPLI PMPHOILDANG
	{
		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE60", Offset = "0x8DE060", VA = "0x1808DEE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x939B80", Offset = "0x938D80", VA = "0x180939B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x2D15150", Offset = "0x2D14350", VA = "0x182D15150")]
	public DHINMMNHIHF(Guid HPINIPGLIPD, KCLMMCNCBHA COENACEECKL, NLAKPJCOMPN EFMABIDKOGO, int JGJCFGPMGGJ, COOLNBMBOGP HJNBJLCLGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x2D14FB0", Offset = "0x2D141B0", VA = "0x182D14FB0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BFNNHPCAKLI))]
	protected override Task PDNAOFOALBA(DPBMEMKDFAC CPNHGIEOMKO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct PFNKBBLBMGP
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class EDFFGEFDMCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder<JMPAFDOMFIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public JMPAFDOMFIK nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public FEKMMALKIBN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public PFNKBBLBMGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private JMPAFDOMFIK <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private TaskAwaiter<JMPAFDOMFIK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EDFFGEFDMCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x5C335B0", Offset = "0x5C327B0", VA = "0x185C335B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class AEFLJHODCDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public AsyncTaskMethodBuilder<JMPAFDOMFIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public JMPAFDOMFIK state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public PFNKBBLBMGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private BLGLLGBBDII <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private BLGLLGBBDII <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private JMPAFDOMFIK <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private BLGLLGBBDII <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private TaskAwaiter<BLGLLGBBDII> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public AEFLJHODCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x5C32310", Offset = "0x5C31510", VA = "0x185C32310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000623")]
	private readonly DPBMEMKDFAC CPNHGIEOMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000624")]
	private readonly PHLPMAPMHHI CFKKPPPPOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	private readonly FAFHCAIJIMH AFLKFGGONHO;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private ILAIPNDOCNE FBHIPHECEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xD47480", Offset = "0xD46680", VA = "0x180D47480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x36FD8B0", Offset = "0x36FCAB0", VA = "0x1836FD8B0")]
	public PFNKBBLBMGP(DPBMEMKDFAC CPNHGIEOMKO, PHLPMAPMHHI CFKKPPPPOKL, FAFHCAIJIMH AFLKFGGONHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x36FD6B0", Offset = "0x36FC8B0", VA = "0x1836FD6B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDFFGEFDMCM))]
	public Task<JMPAFDOMFIK> PJIEKMNIJKL(JMPAFDOMFIK JEPHJMMEJHD, FEKMMALKIBN IDDOFILHGPI, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP, bool IKBIHPODCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x36FD4E0", Offset = "0x36FC6E0", VA = "0x1836FD4E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AEFLJHODCDH))]
	private Task<JMPAFDOMFIK> IJGPKIDKBFG(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, JMPAFDOMFIK OJBGFLKOHML, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x36FD4B0", Offset = "0x36FC6B0", VA = "0x1836FD4B0")]
	private bool FBHDMAIPDAG(JMPAFDOMFIK HFHJPAFNMCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x36FD490", Offset = "0x36FC690", VA = "0x1836FD490")]
	private void DJGNNKLAGEN(string GGOJIBEJMBM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct DJMNAPMIPNN
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class FKAPALDBFNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public BCCKLEDHADN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private ILAIPNDOCNE <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private JMPAFDOMFIK <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private KCLMMCNCBHA <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private FGKLHHEMEMB <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private GCIHMELJNEJ <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private List<(PersistenceView, LLLPGKDBIPO)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private LLLPGKDBIPO <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FKAPALDBFNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x42BD210", Offset = "0x42BC410", VA = "0x1842BD210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x2D154F0", Offset = "0x2D146F0", VA = "0x182D154F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FKAPALDBFNE))]
	public static Task ONDGBMOLAPF(DPBMEMKDFAC CPNHGIEOMKO, FEKMMALKIBN JCEJEOAKGOJ, BCCKLEDHADN BJOENEBOOPC, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x2D15280", Offset = "0x2D14480", VA = "0x182D15280")]
	private static void CHPNHOBPCGK(PersistenceView EGALACPJCAA, LLLPGKDBIPO LOAEFHPBAMF, FEKMMALKIBN JCEJEOAKGOJ, JMPAFDOMFIK CMGBFAPDNEF, bool CFDBMHIBLHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal class LGCHJFHJHIL : PNGJBJMNIMG
{
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private sealed class AHFOKFKCOBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public AsyncTaskMethodBuilder<FAPAGDCIGJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public CNHIGFDMMEB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public LGCHJFHJHIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private StringBuilder <outputBuilder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public AHFOKFKCOBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x428B7D0", Offset = "0x428A9D0", VA = "0x18428B7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class DKMFIIGHGPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public CNHIGFDMMEB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public LGCHJFHJHIL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DKMFIIGHGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x428D370", Offset = "0x428C570", VA = "0x18428D370")]
		internal Task HCIHGKDHBPJ(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x428D5B0", Offset = "0x428C7B0", VA = "0x18428D5B0")]
		internal Task KLCDMEBBEDM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class HHDFGINMKLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public DKMFIIGHGPA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HHDFGINMKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x42931E0", Offset = "0x42923E0", VA = "0x1842931E0")]
		internal object PHKLLIDHJDA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class POBOKFOAFOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public DKMFIIGHGPA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public POBOKFOAFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x429EEE0", Offset = "0x429E0E0", VA = "0x18429EEE0")]
		internal Task DLPGNHEGMKC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class LDJDBNPKODG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public CNHIGFDMMEB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public LGCHJFHJHIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private DKMFIIGHGPA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private HHDFGINMKLA <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LDJDBNPKODG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x4298BE0", Offset = "0x4297DE0", VA = "0x184298BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private readonly MBPNBFDACPD ALHJKEONHDO;

	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private static readonly TimeSpan FDJCAJDACPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private readonly JOMHMDNIMJO MOGPCKJAALG;

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x36F3B30", Offset = "0x36F2D30", VA = "0x1836F3B30")]
	public LGCHJFHJHIL(DPBMEMKDFAC CPNHGIEOMKO, JOMHMDNIMJO MOGPCKJAALG, [Optional] MBPNBFDACPD? ALHJKEONHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x36F32D0", Offset = "0x36F24D0", VA = "0x1836F32D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AHFOKFKCOBE))]
	public Task<FAPAGDCIGJE> IOEANABOGCL(long GLLEENOIFOJ, string KBBAHAIKDJO, CNHIGFDMMEB IEHGKJOAHNI, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x36F2BD0", Offset = "0x36F1DD0", VA = "0x1836F2BD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LDJDBNPKODG))]
	private Task ELAMAIFELFB(CNHIGFDMMEB IEHGKJOAHNI, IEnumerable<PersistenceView> AENEAMCMGKB, StringBuilder PNFMBOMENNM, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x36F3660", Offset = "0x36F2860", VA = "0x1836F3660")]
	private FAPAGDCIGJE NBMAEBGEDMF(long GLLEENOIFOJ, string KBBAHAIKDJO, CNHIGFDMMEB IEHGKJOAHNI, IEnumerable<PersistenceView> AENEAMCMGKB, StringBuilder PNFMBOMENNM)
	{
		return default(FAPAGDCIGJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x36F34A0", Offset = "0x36F26A0", VA = "0x1836F34A0")]
	private PIKKGCCILDN KEHAFPBDBJK(long GLLEENOIFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x36F29C0", Offset = "0x36F1BC0", VA = "0x1836F29C0")]
	private void AOJHCLJKNIK(PIKKGCCILDN AGIBBHKKBME, StringBuilder PNFMBOMENNM, IEnumerable<PersistenceView> AENEAMCMGKB, in AMCNICLCIHB EJGLCDFFPME, IOHKDEOFJPL NMEEMMJAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x36F2D90", Offset = "0x36F1F90", VA = "0x1836F2D90")]
	private void IDJMMFMOABK(PIKKGCCILDN AGIBBHKKBME, StringBuilder PNFMBOMENNM, PersistenceView EGALACPJCAA, ref IOHKDEOFJPL NMEEMMJAGGE, in AMCNICLCIHB EJGLCDFFPME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal class EGMAPPFLLFP : ILAIPNDOCNE
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class PKNJIOLIEGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public EGMAPPFLLFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private string <unityAssetId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private LGCHJFHJHIL <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private CNHIGFDMMEB <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private FAPAGDCIGJE <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private FAPAGDCIGJE <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private TaskAwaiter<FAPAGDCIGJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PKNJIOLIEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x42C7940", Offset = "0x42C6B40", VA = "0x1842C7940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private readonly BJINNGNHAFI AGHJKILGDNH;

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D390", Offset = "0x2D1C590", VA = "0x182D1D390")]
	public EGMAPPFLLFP(Guid HPINIPGLIPD, KCLMMCNCBHA COENACEECKL, NLAKPJCOMPN EFMABIDKOGO, BJINNGNHAFI AGHJKILGDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D110", Offset = "0x2D1C310", VA = "0x182D1D110", Slot = "7")]
	protected override string HOODFCCBJIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D1F0", Offset = "0x2D1C3F0", VA = "0x182D1D1F0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PKNJIOLIEGB))]
	protected override Task PDNAOFOALBA(DPBMEMKDFAC CPNHGIEOMKO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct MBFHBMOLDFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	public Dictionary<Guid, List<JKOJPLCGJGM>> FLKHBPEHJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	public Dictionary<Guid, List<JKOJPLCGJGM>> AALKGHIMBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	public Dictionary<Guid, List<JKOJPLCGJGM>> LGJLNCDJDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	public List<Guid> GMOKOFEGFKD;

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x36F86D0", Offset = "0x36F78D0", VA = "0x1836F86D0")]
	public static MBFHBMOLDFG MEINKDCJHDP(FGKLHHEMEMB JCECDDPGEKA, JMPAFDOMFIK CMGBFAPDNEF, FEKMMALKIBN IDDOFILHGPI)
	{
		return default(MBFHBMOLDFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
public readonly struct HHMNCCHMPGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	public readonly bool FNGGAIKEBFF;

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x14ACA40", Offset = "0x14ABC40", VA = "0x1814ACA40")]
	public HHMNCCHMPGB(bool BNFDKGMKGIB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct PCJCEDAOCAI
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class DCEEHJBGNIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public ILAIPNDOCNE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public BCCKLEDHADN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private JMPAFDOMFIK <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private List<(PersistenceView, LLLPGKDBIPO)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private (PersistenceView, LLLPGKDBIPO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private GMINIDBBNAJ <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DCEEHJBGNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x5C32F10", Offset = "0x5C32110", VA = "0x185C32F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x36FCBB0", Offset = "0x36FBDB0", VA = "0x1836FCBB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DCEEHJBGNIH))]
	public static Task ONDGBMOLAPF(ILAIPNDOCNE IAFPJLJBHFI, FEKMMALKIBN JCEJEOAKGOJ, BCCKLEDHADN BJOENEBOOPC, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct HLPOCEEKJGK
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class LIEKDDBELFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public AsyncTaskMethodBuilder<FEKMMALKIBN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public IDFOFNFJIKL.DBKAFHNIHIC downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public HLPOCEEKJGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private Task<CLFKONEBOLH<AAMJDAPOEFN, PIHDIMJPEHH>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private Task<CLFKONEBOLH<KBFBKOAJJMK<PIKKGCCILDN>, PIHDIMJPEHH>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private Task<CLFKONEBOLH<KBFBKOAJJMK<PJHLEBGLDJJ>, PIHDIMJPEHH>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private Task<CLFKONEBOLH<KBFBKOAJJMK<ODJGGCOOJEA>, PIHDIMJPEHH>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private Task<(CLFKONEBOLH<AAMJDAPOEFN, PIHDIMJPEHH>, CLFKONEBOLH<KBFBKOAJJMK<PIKKGCCILDN>, PIHDIMJPEHH>, CLFKONEBOLH<KBFBKOAJJMK<PJHLEBGLDJJ>, PIHDIMJPEHH>, CLFKONEBOLH<KBFBKOAJJMK<ODJGGCOOJEA>, PIHDIMJPEHH>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private CLFKONEBOLH<AAMJDAPOEFN, PIHDIMJPEHH> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private CLFKONEBOLH<KBFBKOAJJMK<PIKKGCCILDN>, PIHDIMJPEHH> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private CLFKONEBOLH<KBFBKOAJJMK<PJHLEBGLDJJ>, PIHDIMJPEHH> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private CLFKONEBOLH<KBFBKOAJJMK<ODJGGCOOJEA>, PIHDIMJPEHH> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private KBFBKOAJJMK<PIKKGCCILDN> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private (CLFKONEBOLH<AAMJDAPOEFN, PIHDIMJPEHH>, CLFKONEBOLH<KBFBKOAJJMK<PIKKGCCILDN>, PIHDIMJPEHH>, CLFKONEBOLH<KBFBKOAJJMK<PJHLEBGLDJJ>, PIHDIMJPEHH>, CLFKONEBOLH<KBFBKOAJJMK<ODJGGCOOJEA>, PIHDIMJPEHH>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private (CLFKONEBOLH<AAMJDAPOEFN, PIHDIMJPEHH>, CLFKONEBOLH<KBFBKOAJJMK<PIKKGCCILDN>, PIHDIMJPEHH>, CLFKONEBOLH<KBFBKOAJJMK<PJHLEBGLDJJ>, PIHDIMJPEHH>, CLFKONEBOLH<KBFBKOAJJMK<ODJGGCOOJEA>, PIHDIMJPEHH>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private TaskAwaiter<(CLFKONEBOLH<AAMJDAPOEFN, PIHDIMJPEHH>, CLFKONEBOLH<KBFBKOAJJMK<PIKKGCCILDN>, PIHDIMJPEHH>, CLFKONEBOLH<KBFBKOAJJMK<PJHLEBGLDJJ>, PIHDIMJPEHH>, CLFKONEBOLH<KBFBKOAJJMK<ODJGGCOOJEA>, PIHDIMJPEHH>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LIEKDDBELFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x4299820", Offset = "0x4298A20", VA = "0x184299820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class CGPKKPDDPPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public AsyncTaskMethodBuilder<CLFKONEBOLH<AAMJDAPOEFN, PIHDIMJPEHH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public IDFOFNFJIKL.DBKAFHNIHIC downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public FDMIABHIEGI<string>.JOOBNAKNCND downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public HLPOCEEKJGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private CLFKONEBOLH<AAMJDAPOEFN, PIHDIMJPEHH> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private TaskAwaiter<CLFKONEBOLH<AAMJDAPOEFN, PIHDIMJPEHH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CGPKKPDDPPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x428CC90", Offset = "0x428BE90", VA = "0x18428CC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private DOFFIKKHBFE<DLJGDNEKCBH, PJHLEBGLDJJ> MBFDILNCMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private DOFFIKKHBFE<DLJGDNEKCBH, PIKKGCCILDN> GBAABNMIFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private DOFFIKKHBFE<long, ODJGGCOOJEA> KALNJLGEMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private NDMECFMJHCJ DBDHDCCHHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private ODLKOJAEFAL NLENBJFJHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	private GONBIMCIPLJ LLLDMEELKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private string KBBAHAIKDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private DLJGDNEKCBH JNLAJBEPGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private DLJGDNEKCBH ECMLCDIPEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private long EGCEBLMJCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG;

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2D29760", Offset = "0x2D28960", VA = "0x182D29760")]
	public static Task<FEKMMALKIBN> IJICNGGIEKC(KCLMMCNCBHA COENACEECKL, in LKOCAIKGKMD JCEJEOAKGOJ, IDFOFNFJIKL.DBKAFHNIHIC NKLNPBABDBB, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x2D29AC0", Offset = "0x2D28CC0", VA = "0x182D29AC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LIEKDDBELFA))]
	private Task<FEKMMALKIBN> ONDGBMOLAPF(IDFOFNFJIKL.DBKAFHNIHIC NKLNPBABDBB, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x2D29530", Offset = "0x2D28730", VA = "0x182D29530")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGPKKPDDPPD))]
	private Task<CLFKONEBOLH<AAMJDAPOEFN, PIHDIMJPEHH>> EHOEHFELLAD(string KBBAHAIKDJO, long EGCEBLMJCKK, IDFOFNFJIKL.DBKAFHNIHIC NKLNPBABDBB, FDMIABHIEGI<string>.JOOBNAKNCND BDCHNBDPHPM, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class PHLPMAPMHHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private readonly NMEPAPEIDNF BOJOLFKPABE;

	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private const string CMHJCIBIJBL = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private const string CBABOCOCDEJ = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private const string MPEACKBHFDF = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private const string AKDEKGLODGF = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private const string FOPDNFNEBMP = "RL_LastLoadedRoomInstanceId";

	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private const string BLFPDLBHJGE = "RL_LastHeartbeatSessionData";

	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private const string OKLNMMPOKDJ = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private string IAMLLEIPBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private long? LBNCILBAOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private long? ICEIDDEAOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private long? BCILJMJGJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private string NIBPGCKCPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private JMPAFDOMFIK LAIJNDCPPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private long? GCKMDKFMMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private bool PECGEFMFPAE;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string KKEEKENGOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public long KNHALGOPOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x36FDE40", Offset = "0x36FD040", VA = "0x1836FDE40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public long PBHIKANDDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x36FE0B0", Offset = "0x36FD2B0", VA = "0x1836FE0B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public long OAFFGBANKIC
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x36FE250", Offset = "0x36FD450", VA = "0x1836FE250")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string OFACCNLBFEG
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x36FDD60", Offset = "0x36FCF60", VA = "0x1836FDD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public JMPAFDOMFIK EDNCDAICNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x9F97E0", Offset = "0x9F89E0", VA = "0x1809F97E0")]
		get
		{
			return default(JMPAFDOMFIK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x36FE110", Offset = "0x36FD310", VA = "0x1836FE110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public long GNBHOMECJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x36FE1F0", Offset = "0x36FD3F0", VA = "0x1836FE1F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x36FE6B0", Offset = "0x36FD8B0", VA = "0x1836FE6B0")]
	[UnityEngine.Scripting.Preserve]
	public PHLPMAPMHHI([IDNKOMINBGM(null)] NMEPAPEIDNF BOJOLFKPABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x36FDEA0", Offset = "0x36FD0A0", VA = "0x1836FDEA0")]
	private void DFJMMIFCIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x36FD910", Offset = "0x36FCB10", VA = "0x1836FD910")]
	public void AFABJLCIDBA(long LNBFDCAEKJF, long GLLEENOIFOJ, [Optional] long? EGCEBLMJCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x36FDDA0", Offset = "0x36FCFA0", VA = "0x1836FDDA0")]
	public void BBODOGAJLCC(long EGCEBLMJCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x36FE630", Offset = "0x36FD830", VA = "0x1836FE630")]
	public void ONEDBOCJNMG(string PKIJBNEHBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x36FE2B0", Offset = "0x36FD4B0", VA = "0x1836FE2B0")]
	public void NGOAIGKHCNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal sealed class PMMBBGOOHDG : ILAIPNDOCNE
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class PEJIHGOJLFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PEJIHGOJLFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x5C39800", Offset = "0x5C38A00", VA = "0x185C39800")]
		internal object JLAGHHAIHJM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class OICAHBPGDHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public PMMBBGOOHDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private POMIGJLEENF <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private DLKJANMPNAB <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OICAHBPGDHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x5C38B10", Offset = "0x5C37D10", VA = "0x185C38B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class LGACMNOCNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public POMIGJLEENF presence;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LGACMNOCNMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x5C372B0", Offset = "0x5C364B0", VA = "0x185C372B0")]
		internal object MDNBELMIOIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private readonly IHKLGONHBKF PAPKKOBCIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private readonly MDCIINLFDMH JMJJBHAFLJH;

	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private const bool LHPCJCKODKG = false;

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x36FFFE0", Offset = "0x36FF1E0", VA = "0x1836FFFE0")]
	public PMMBBGOOHDG(IHKLGONHBKF PAPKKOBCIDK, MDCIINLFDMH JMJJBHAFLJH, Guid HPINIPGLIPD, KCLMMCNCBHA COENACEECKL, NLAKPJCOMPN EFMABIDKOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x36FFE40", Offset = "0x36FF040", VA = "0x1836FFE40", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OICAHBPGDHM))]
	protected override Task PDNAOFOALBA(DPBMEMKDFAC CPNHGIEOMKO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x36FFAC0", Offset = "0x36FECC0", VA = "0x1836FFAC0")]
	private POMIGJLEENF IJFDNNGNCLO()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal struct LDPCEBHHKKB
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class LBDPHPMHAIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public KCLMMCNCBHA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private bool <isMaster>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LBDPHPMHAIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x4298770", Offset = "0x4297970", VA = "0x184298770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x36F1DD0", Offset = "0x36F0FD0", VA = "0x1836F1DD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBDPHPMHAIO))]
	public static Task ONDGBMOLAPF(KCLMMCNCBHA COENACEECKL, FEKMMALKIBN JCEJEOAKGOJ, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct CFLOCFFACOG
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class AOINGDNPDJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public CFLOCFFACOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		private BDGGIBPLHIH <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private string <sceneName>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private Scene <mainScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public AOINGDNPDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x42B5490", Offset = "0x42B4690", VA = "0x1842B5490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class CLBPGGAEPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CLBPGGAEPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x42B7FB0", Offset = "0x42B71B0", VA = "0x1842B7FB0")]
		internal object CMIDIEPPMAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class LLOFCNBNLDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public CFLOCFFACOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private CLBPGGAEPKN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private PCHNJKGKBFN <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LLOFCNBNLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x42C0EE0", Offset = "0x42C00E0", VA = "0x1842C0EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private BDGGIBPLHIH APLHLKFBJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private bool KIPOCCAELAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private FEKMMALKIBN JCEJEOAKGOJ;

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x2D13490", Offset = "0x2D12690", VA = "0x182D13490")]
	public static Task<Scene> OFIPGEEDCKJ(KCLMMCNCBHA COENACEECKL, BDGGIBPLHIH PHELDHIFHGF, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x2D133F0", Offset = "0x2D125F0", VA = "0x182D133F0")]
	public static Task<Scene> KFELKKOEDGK(KCLMMCNCBHA COENACEECKL, FEKMMALKIBN JCEJEOAKGOJ, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x2D13510", Offset = "0x2D12710", VA = "0x182D13510")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOINGDNPDJI))]
	private Task<Scene> ONDGBMOLAPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x2D13240", Offset = "0x2D12440", VA = "0x182D13240")]
	private bool JHKIECHPMJJ(FEKMMALKIBN JCEJEOAKGOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x2D131D0", Offset = "0x2D123D0", VA = "0x182D131D0")]
	private void CHDHJGFDLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x2D13270", Offset = "0x2D12470", VA = "0x182D13270")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LLOFCNBNLDD))]
	private Task<Scene> KBCEDLLDMLO(string BHNAPHDEPMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public abstract class MCHPMKDDPFC<T> where T : MCHPMKDDPFC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	internal readonly KCLMMCNCBHA ENAKLFPKLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	private int? NPJMBPEMLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400070B")]
	protected readonly Guid INMOFOFIJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400070C")]
	protected readonly APGCGMGDIIP AFADMDLPOOO;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	protected T MCFHBEALOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x3044D40", Offset = "0x3043F40", VA = "0x183044D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x3044FF0", Offset = "0x30441F0", VA = "0x183044FF0")]
	internal MCHPMKDDPFC(KCLMMCNCBHA ELIHKMIAOHL, APGCGMGDIIP DILEKOOCNPA, [Optional] Guid? HPINIPGLIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x3044F00", Offset = "0x3044100", VA = "0x183044F00")]
	private BLGLLGBBDII PGNFAMBNFMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "4")]
	protected virtual void NECGFKKIEDJ(BLGLLGBBDII CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x3044DA0", Offset = "0x3043FA0", VA = "0x183044DA0")]
	public T BIBGDPJOBLM(NBDCAKCJOHF NHDBOCCEDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x3044E80", Offset = "0x3044080", VA = "0x183044E80")]
	public T ENAJHGMOEKM(int HFNPIDKPBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x3044C40", Offset = "0x3043E40", VA = "0x183044C40", Slot = "5")]
	public virtual Task<NAKMMEJMOAP> AHDDMHAECBB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public class DGGNNJGLDCH : MCHPMKDDPFC<DGGNNJGLDCH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400070D")]
	private IHKLGONHBKF DGLHFPEOHIM;

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x2D14920", Offset = "0x2D13B20", VA = "0x182D14920")]
	internal DGGNNJGLDCH(KCLMMCNCBHA ELIHKMIAOHL, APGCGMGDIIP DILEKOOCNPA, [Optional] Guid? HPINIPGLIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x2D14830", Offset = "0x2D13A30", VA = "0x182D14830")]
	public DGGNNJGLDCH NADOBNCBHPN(IHKLGONHBKF DGLHFPEOHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x2D14850", Offset = "0x2D13A50", VA = "0x182D14850", Slot = "4")]
	protected override void NECGFKKIEDJ(BLGLLGBBDII CEOMJLPEFPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public class DHEDDELEOOF : MCHPMKDDPFC<DHEDDELEOOF>
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal enum FMNJGCNGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		RecNet
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class BEGEOLKGAJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public AsyncTaskMethodBuilder<NAKMMEJMOAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public DHEDDELEOOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		private NAKMMEJMOAP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private TaskAwaiter<NAKMMEJMOAP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BEGEOLKGAJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x42B5CA0", Offset = "0x42B4EA0", VA = "0x1842B5CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	private FMNJGCNGIEG FJOICKHEEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private string PIEAGKJKJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	private HGOCCJHPOPO DGLHFPEOHIM;

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x2D14E00", Offset = "0x2D14000", VA = "0x182D14E00")]
	internal DHEDDELEOOF(KCLMMCNCBHA ELIHKMIAOHL, APGCGMGDIIP DILEKOOCNPA, [Optional] Guid? HPINIPGLIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x2D14B90", Offset = "0x2D13D90", VA = "0x182D14B90")]
	public DHEDDELEOOF DBHNLFELFEJ(string JDAIAPJCJIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D14C30", Offset = "0x2D13E30", VA = "0x182D14C30")]
	public DHEDDELEOOF IGDPBINKPGC(bool KEJDKLBEGNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x2D14C00", Offset = "0x2D13E00", VA = "0x182D14C00")]
	public DHEDDELEOOF GOMHGHABLAG(string KMBFNDAPCGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x2D14C60", Offset = "0x2D13E60", VA = "0x182D14C60")]
	public DHEDDELEOOF IGKGPJDJGEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D14C90", Offset = "0x2D13E90", VA = "0x182D14C90", Slot = "4")]
	protected override void NECGFKKIEDJ(BLGLLGBBDII CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x2D14A40", Offset = "0x2D13C40", VA = "0x182D14A40", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BEGEOLKGAJL))]
	public override Task<NAKMMEJMOAP> AHDDMHAECBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x2D14BC0", Offset = "0x2D13DC0", VA = "0x182D14BC0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<NAKMMEJMOAP> GAAPPIDMJMK()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct PILFMBOFKOF
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class DHDAMJEAKCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public MBFOHDGMHHM.EFAAFNPIFCF instantiations;

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DHDAMJEAKCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x5C33500", Offset = "0x5C32700", VA = "0x185C33500")]
		internal object NNLHHCGDJBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class KMOFJALJDHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KMOFJALJDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x5C36F90", Offset = "0x5C36190", VA = "0x185C36F90")]
		internal object PLJNIBOBLGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x36FE720", Offset = "0x36FD920", VA = "0x1836FE720")]
	public static void ONDGBMOLAPF(ILAIPNDOCNE IAFPJLJBHFI, FEKMMALKIBN JCEJEOAKGOJ, MBFOHDGMHHM.EFAAFNPIFCF LFPBNJGPONM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct MBFOHDGMHHM
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public struct EFAAFNPIFCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public List<PLEENCLLJNN> DOIHIPEIDOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public List<LLLPGKDBIPO> MHKOOMPIHDB;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7B0", Offset = "0xA5E9B0", VA = "0x180A5F7B0")]
		public EFAAFNPIFCF(List<PLEENCLLJNN> DOIHIPEIDOA, List<LLLPGKDBIPO> MHKOOMPIHDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class NHIALMCJADF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public IEnumerable<PLEENCLLJNN> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NHIALMCJADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x5C384E0", Offset = "0x5C376E0", VA = "0x185C384E0")]
		internal object INPPIPFABHM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	private FEKMMALKIBN JCEJEOAKGOJ;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private FGKLHHEMEMB HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x36F8CE0", Offset = "0x36F7EE0", VA = "0x1836F8CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x36F95D0", Offset = "0x36F87D0", VA = "0x1836F95D0")]
	public static EFAAFNPIFCF ONDGBMOLAPF(KCLMMCNCBHA COENACEECKL, FEKMMALKIBN JCEJEOAKGOJ)
	{
		return default(EFAAFNPIFCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x36F92A0", Offset = "0x36F84A0", VA = "0x1836F92A0")]
	private EFAAFNPIFCF ONDGBMOLAPF()
	{
		return default(EFAAFNPIFCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x36F8D30", Offset = "0x36F7F30", VA = "0x1836F8D30")]
	private EFAAFNPIFCF GENGIODJHBF(PIKKGCCILDN PNICJAKMKDO, OALBBBOJDGP BONMCPNGJKJ)
	{
		return default(EFAAFNPIFCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x36F9640", Offset = "0x36F8840", VA = "0x1836F9640")]
	private bool PDDFCIEOFKE(IEnumerable<PLEENCLLJNN> DOIHIPEIDOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct DLFCDJKICFO
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class FHIOJHPOADK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public DLFCDJKICFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FHIOJHPOADK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x42BCA10", Offset = "0x42BBC10", VA = "0x1842BCA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class LKLKILFBLEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LKLKILFBLEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x42C0E60", Offset = "0x42C0060", VA = "0x1842C0E60")]
		internal object CMIDIEPPMAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class EKADCDKAOPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public DLFCDJKICFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private LKLKILFBLEF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		private PCHNJKGKBFN <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EKADCDKAOPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x42BC230", Offset = "0x42BB430", VA = "0x1842BC230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	private bool BCFEOGPJPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	private FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private CancellationToken PLEKJLHDOLP;

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x2D15820", Offset = "0x2D14A20", VA = "0x182D15820")]
	public static Task LNMMIAAAPCG(KCLMMCNCBHA COENACEECKL, bool BCFEOGPJPBJ, FDMIABHIEGI<string>.JOOBNAKNCND FIIEBNCLKIG, CancellationToken NNKDDPOLGBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x2D15890", Offset = "0x2D14A90", VA = "0x182D15890")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FHIOJHPOADK))]
	private Task ONDGBMOLAPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x2D156B0", Offset = "0x2D148B0", VA = "0x182D156B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EKADCDKAOPM))]
	private Task KBCEDLLDMLO(bool AEFHNDBCMIG, string BHNAPHDEPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x826280", Offset = "0x825480", VA = "0x180826280")]
	private bool ELDEIJIHNCN(bool BCFEOGPJPBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct LKOCAIKGKMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	public readonly ODLKOJAEFAL NLENBJFJHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	public readonly GONBIMCIPLJ LLLDMEELKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	public readonly string KBBAHAIKDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400073E")]
	public readonly DLJGDNEKCBH JNLAJBEPGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400073F")]
	public readonly DLJGDNEKCBH ECMLCDIPEEO;

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x36F5680", Offset = "0x36F4880", VA = "0x1836F5680")]
	public LKOCAIKGKMD(ODLKOJAEFAL NLENBJFJHPJ, GONBIMCIPLJ LLLDMEELKCM, string KBBAHAIKDJO, DLJGDNEKCBH JNLAJBEPGHH, DLJGDNEKCBH ECMLCDIPEEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal sealed class IJAMBDKGNPH : NHFEEIDLGIP
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class FABPGINBLEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public IJAMBDKGNPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		private NAKGFMDIFDB <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private DLKJANMPNAB <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FABPGINBLEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x428F1D0", Offset = "0x428E3D0", VA = "0x18428F1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	private readonly IHKLGONHBKF EFEFPAELCIN;

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A600", Offset = "0x2D29800", VA = "0x182D2A600")]
	public IJAMBDKGNPH(Guid HPINIPGLIPD, KCLMMCNCBHA COENACEECKL, IHKLGONHBKF EFEFPAELCIN, NLAKPJCOMPN EFMABIDKOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A460", Offset = "0x2D29660", VA = "0x182D2A460", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FABPGINBLEB))]
	protected override Task OGDNCHJDDNH(DPBMEMKDFAC CPNHGIEOMKO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct PPDHNELPFJK
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x3700370", Offset = "0x36FF570", VA = "0x183700370")]
	public static Task ONDGBMOLAPF(CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct DOFGGDAPCOO
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class ENDHCEPLOBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public KCLMMCNCBHA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		public FEKMMALKIBN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private bool <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public ENDHCEPLOBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x42BC7E0", Offset = "0x42BB9E0", VA = "0x1842BC7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class HBCJDEENNJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public DOFGGDAPCOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		private HHAKNEDDCKI.JDFCPJKNDIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private bool <shouldObjectModelBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		private bool <isOMFlagChanging>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private bool <reloadSceneForObjectModel>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HBCJDEENNJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x42BE120", Offset = "0x42BD320", VA = "0x1842BE120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	private KCLMMCNCBHA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	private FEKMMALKIBN JCEJEOAKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	private ByteString GIOKKDKJOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400074D")]
	private DPBMEMKDFAC CPNHGIEOMKO;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private FGKLHHEMEMB HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2D18550", Offset = "0x2D17750", VA = "0x182D18550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private bool NALCCFFMOHE
	{
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2D185A0", Offset = "0x2D177A0", VA = "0x182D185A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private bool APCBMCONCEE
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2D184C0", Offset = "0x2D176C0", VA = "0x182D184C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private bool NLAHAILLPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2D18480", Offset = "0x2D17680", VA = "0x182D18480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x2D187C0", Offset = "0x2D179C0", VA = "0x182D187C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ENDHCEPLOBJ))]
	public static Task<bool> ONDGBMOLAPF(KCLMMCNCBHA COENACEECKL, FEKMMALKIBN JCEJEOAKGOJ, DPBMEMKDFAC CPNHGIEOMKO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x2D18620", Offset = "0x2D17820", VA = "0x182D18620")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HBCJDEENNJO))]
	private Task<bool> ONDGBMOLAPF(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class OBIAHKOBJBA
{
	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x36FBCF0", Offset = "0x36FAEF0", VA = "0x1836FBCF0")]
	public static DLJGDNEKCBH AIEBELABCNA(this CNNJJIBPPAC LGJPMIDIPNK)
	{
		return default(DLJGDNEKCBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x36FBDB0", Offset = "0x36FAFB0", VA = "0x1836FBDB0")]
	public static CNNJJIBPPAC FBOCEDNAKHJ(this DLJGDNEKCBH JJBPCJEHCDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal class NAMKBNPIOMO : PNGJBJMNIMG
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class JHPKJLDKIEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public KNEBJLHEJJD.MMAHHCEEOGD roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public KNEBJLHEJJD.MMAHHCEEOGD subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JHPKJLDKIEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C36A90", Offset = "0x5C35C90", VA = "0x185C36A90")]
		internal object CIOIACGKGDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x5C36D60", Offset = "0x5C35F60", VA = "0x185C36D60")]
		internal object NBPDFCGMICG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x5C36DB0", Offset = "0x5C35FB0", VA = "0x185C36DB0")]
		internal object PMBBDKFNOAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x5C36B20", Offset = "0x5C35D20", VA = "0x185C36B20")]
		internal object ILBIIGOCDEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class NBDIFBBKKKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public AsyncTaskMethodBuilder<(KNEBJLHEJJD.MMAHHCEEOGD roomDataUpload, KNEBJLHEJJD.MMAHHCEEOGD subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public FAPAGDCIGJE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public NAMKBNPIOMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private JHPKJLDKIEI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		private PJHLEBGLDJJ <roomMetadata>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private KNEBJLHEJJD.MMAHHCEEOGD <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private KNEBJLHEJJD.MMAHHCEEOGD <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private TaskAwaiter<KNEBJLHEJJD.MMAHHCEEOGD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NBDIFBBKKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x5C37910", Offset = "0x5C36B10", VA = "0x185C37910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class JGMJEGOFPIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public AsyncTaskMethodBuilder<FELEHJCEPLI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		public HGOCCJHPOPO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public FAPAGDCIGJE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public NAMKBNPIOMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		private KNEBJLHEJJD.MMAHHCEEOGD <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		private KNEBJLHEJJD.MMAHHCEEOGD <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private int <persistenceVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		private byte <omVersion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		private NGHCPPHCGII <request>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		private FELEHJCEPLI <response>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		private (KNEBJLHEJJD.MMAHHCEEOGD roomDataUpload, KNEBJLHEJJD.MMAHHCEEOGD subRoomDataUpload) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		private (KNEBJLHEJJD.MMAHHCEEOGD roomDataUpload, KNEBJLHEJJD.MMAHHCEEOGD subRoomDataUpload) <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private FELEHJCEPLI <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private TaskAwaiter<(KNEBJLHEJJD.MMAHHCEEOGD roomDataUpload, KNEBJLHEJJD.MMAHHCEEOGD subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private TaskAwaiter<FELEHJCEPLI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JGMJEGOFPIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x5C36350", Offset = "0x5C35550", VA = "0x185C36350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class MNHGLNOEPMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public AsyncTaskMethodBuilder<LDOOKNNGNOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public FAPAGDCIGJE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public NAMKBNPIOMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		private KNEBJLHEJJD.MMAHHCEEOGD <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		private KNEBJLHEJJD.MMAHHCEEOGD <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private LDOOKNNGNOF <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		private (KNEBJLHEJJD.MMAHHCEEOGD roomDataUpload, KNEBJLHEJJD.MMAHHCEEOGD subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		private (KNEBJLHEJJD.MMAHHCEEOGD roomDataUpload, KNEBJLHEJJD.MMAHHCEEOGD subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		private LDOOKNNGNOF <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		private TaskAwaiter<(KNEBJLHEJJD.MMAHHCEEOGD roomDataUpload, KNEBJLHEJJD.MMAHHCEEOGD subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		private TaskAwaiter<LDOOKNNGNOF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MNHGLNOEPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x5C373F0", Offset = "0x5C365F0", VA = "0x185C373F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class JJIJOBPAICM
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			public AsyncTaskMethodBuilder<BLGLLGBBDII> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			public JJIJOBPAICM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007A4")]
			private BLGLLGBBDII <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007A5")]
			private RepeatedField<LLLPGKDBIPO> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007A6")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7BD570", Offset = "0x7BC970")]
			private IEnumerable<LLLPGKDBIPO> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007A7")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x40007A8")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007A9")]
			private LDOOKNNGNOF <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007AA")]
			private LDOOKNNGNOF <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007AB")]
			private FELEHJCEPLI <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			private FELEHJCEPLI <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			private BLGLLGBBDII <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			private TaskAwaiter<LDOOKNNGNOF> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			private TaskAwaiter<FELEHJCEPLI> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			private TaskAwaiter<BLGLLGBBDII> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x5C3C970", Offset = "0x5C3BB70", VA = "0x185C3C970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public NAMKBNPIOMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public FAPAGDCIGJE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public HGOCCJHPOPO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public HHMNCCHMPGB roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7BD4A0", Offset = "0x7BC8A0")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JJIJOBPAICM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x5C36E20", Offset = "0x5C36020", VA = "0x185C36E20")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<BLGLLGBBDII> AEGFAPALBPC(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class CFAMIDMPPKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		public AsyncTaskMethodBuilder<BLGLLGBBDII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		public HGOCCJHPOPO roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		public FAPAGDCIGJE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public HHMNCCHMPGB roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7BD5D0", Offset = "0x7BC9D0")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public NAMKBNPIOMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		private JJIJOBPAICM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		private BLGLLGBBDII <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		private TaskAwaiter<BLGLLGBBDII> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CFAMIDMPPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x5C32B40", Offset = "0x5C31D40", VA = "0x185C32B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private const float KDMKPNJICDF = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private readonly IPDFLCGLIDF BPNKNGPNKBA;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private KCLMMCNCBHA DCNGDMOHPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D16D50", Offset = "0x2D15F50", VA = "0x182D16D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x36FB350", Offset = "0x36FA550", VA = "0x1836FB350")]
	public NAMKBNPIOMO(DPBMEMKDFAC CPNHGIEOMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x36FB190", Offset = "0x36FA390", VA = "0x1836FB190")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NBDIFBBKKKF))]
	private Task<(KNEBJLHEJJD.MMAHHCEEOGD, KNEBJLHEJJD.MMAHHCEEOGD)> DEPPGBMJIAA(FAPAGDCIGJE ACEDMDLCIME, long LNBFDCAEKJF, long HGPBCNPIJHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x36FAB50", Offset = "0x36F9D50", VA = "0x1836FAB50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGMJEGOFPIG))]
	public Task<FELEHJCEPLI> DAEIOIHNIBE(int IBNBKGICHHN, [CanBeNull] HGOCCJHPOPO HHMDLJJBABE, FAPAGDCIGJE ACEDMDLCIME, long LNBFDCAEKJF, long HGPBCNPIJHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x36FAD40", Offset = "0x36F9F40", VA = "0x1836FAD40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MNHGLNOEPMN))]
	private Task<LDOOKNNGNOF> DAFBFJFDAGH(string DPPPGPGBEBC, int IBNBKGICHHN, FAPAGDCIGJE ACEDMDLCIME, long LNBFDCAEKJF, long HGPBCNPIJHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x36FAF40", Offset = "0x36FA140", VA = "0x1836FAF40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CFAMIDMPPKI))]
	public Task<BLGLLGBBDII> DBCEKFCFNAG(int IBNBKGICHHN, HGOCCJHPOPO? HHMDLJJBABE, FAPAGDCIGJE ACEDMDLCIME, long LNBFDCAEKJF, long HGPBCNPIJHG, HHMNCCHMPGB PMAEPBFCDMH, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
internal class CPEKCEFMGFH : NHFEEIDLGIP
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class BOCMAOGJLEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007CA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007CB")]
			public AsyncTaskMethodBuilder<BLGLLGBBDII> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007CC")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007CD")]
			public BOCMAOGJLEM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007CE")]
			private FAPAGDCIGJE <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007CF")]
			private BLGLLGBBDII <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007D0")]
			private FAPAGDCIGJE <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007D1")]
			private BLGLLGBBDII <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007D2")]
			private TaskAwaiter<FAPAGDCIGJE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7BD710", Offset = "0x7BCB10")]
			private TaskAwaiter<BLGLLGBBDII> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x5C3C500", Offset = "0x5C3B700", VA = "0x185C3C500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public CPEKCEFMGFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public LGCHJFHJHIL serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		public NAMKBNPIOMO uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public HHMNCCHMPGB roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BOCMAOGJLEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x42B6A50", Offset = "0x42B5C50", VA = "0x1842B6A50")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<BLGLLGBBDII> OKLELOIBDJC(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class EENEFNHNIBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		public DPBMEMKDFAC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		public CPEKCEFMGFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		private BOCMAOGJLEM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		private NAKGFMDIFDB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		private KCDJMIOEEPA <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		private DLKJANMPNAB <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		private BLGLLGBBDII <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		private BLGLLGBBDII <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		private TaskAwaiter<BLGLLGBBDII> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EENEFNHNIBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x42BACB0", Offset = "0x42B9EB0", VA = "0x1842BACB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007C0")]
	private readonly int IBNBKGICHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007C1")]
	[CanBeNull]
	private readonly HGOCCJHPOPO HHMDLJJBABE;

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D13EC0", Offset = "0x2D130C0", VA = "0x182D13EC0")]
	public CPEKCEFMGFH(Guid HPINIPGLIPD, KCLMMCNCBHA COENACEECKL, int IBNBKGICHHN, HGOCCJHPOPO HHMDLJJBABE, NLAKPJCOMPN EFMABIDKOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D13D20", Offset = "0x2D12F20", VA = "0x182D13D20", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EENEFNHNIBB))]
	protected override Task OGDNCHJDDNH(DPBMEMKDFAC CPNHGIEOMKO, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D13A80", Offset = "0x2D12C80", VA = "0x182D13A80")]
	private void ICOLEDPBJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D13B80", Offset = "0x2D12D80", VA = "0x182D13B80")]
	private void KBCBIPIHMKL(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK, NAKGFMDIFDB GHJIPDLACNG)
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
			[Cpp2IlInjected.Token(Token = "0x40007E8")]
			public PLDGKALNBGG ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007E9")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007EA")]
			public PLDGKALNBGG HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007EB")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007EC")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007ED")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private static PLDGKALNBGG[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		private Dictionary<PLDGKALNBGG, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x3700900", Offset = "0x36FFB00", VA = "0x183700900")]
		public bool LILEOCEEAFJ(PLDGKALNBGG MJPJFJGLNGK, out ResultConfig PEPOGGMJFLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x37010E0", Offset = "0x37002E0", VA = "0x1837010E0")]
		public ResultConfig PNCAHDBGFLI(PLDGKALNBGG CPFOGLIOEOJ, [Optional] HashSet<PLDGKALNBGG> MFFIHNEDKLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x3700EE0", Offset = "0x37000E0", VA = "0x183700EE0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x3700970", Offset = "0x36FFB70", VA = "0x183700970", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xC7A8A0", Offset = "0xC79AA0", VA = "0x180C7A8A0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public class MFJNBCGLIDH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x36F9AB0", Offset = "0x36F8CB0", VA = "0x1836F9AB0")]
	public MFJNBCGLIDH(string CEOMJLPEFPB, Exception EKEFPFGKHCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public class ECKJJFLEEBE
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	private sealed class PIEKLDBCNBN : BADBIJFLLKE, IEquatable<BADBIJFLLKE>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A1")]
		[CompilerGenerated]
		private sealed class NPLOICMLILK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007FB")]
			public AsyncTaskMethodBuilder<NAKMMEJMOAP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007FC")]
			public PIEKLDBCNBN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007FD")]
			private MOGJDODAHJA <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007FE")]
			private ODLKOJAEFAL <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007FF")]
			private IHKLGONHBKF <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			private ODLKOJAEFAL <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			private NAKMMEJMOAP <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			private TaskAwaiter<ODLKOJAEFAL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			private TaskAwaiter<NAKMMEJMOAP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public NPLOICMLILK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x5C38620", Offset = "0x5C37820", VA = "0x185C38620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private readonly KCDJMIOEEPA CCBLHKLPKND;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public int NLIFNBICGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x8D86B0", Offset = "0x8D78B0", VA = "0x1808D86B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public ICIDMOFEFHA LHKNKDFGODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		private DateTime KHIOCKFMOBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x2D72470", Offset = "0x2D71670", VA = "0x182D72470", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public POGAGPMPBJC? JJBMAEMNPAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x19F47F0", Offset = "0x19F39F0", VA = "0x1819F47F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public IOAOKAJOOCP? GPIMCILOGOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x42C7870", Offset = "0x42C6A70", VA = "0x1842C7870", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public ODCJCBINIIK GBEBLJCEKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x825660", Offset = "0x824860", VA = "0x180825660", Slot = "10")]
			get
			{
				return default(ODCJCBINIIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x42C7550", Offset = "0x42C6750", VA = "0x1842C7550", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(NPLOICMLILK))]
		public Task<NAKMMEJMOAP> DBIHDPKDHDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x42C78E0", Offset = "0x42C6AE0", VA = "0x1842C78E0")]
		public PIEKLDBCNBN(int GLJDFMDBEMC, ICIDMOFEFHA AANKCDLGBJC, KCDJMIOEEPA CCBLHKLPKND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x42C76A0", Offset = "0x42C68A0", VA = "0x1842C76A0", Slot = "11")]
		public bool Equals(BADBIJFLLKE HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x42C7740", Offset = "0x42C6940", VA = "0x1842C7740", Slot = "0")]
		public override bool Equals(object BHEOHCEHIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x42C7890", Offset = "0x42C6A90", VA = "0x1842C7890")]
		private bool LLFEHLHOCGD(PIEKLDBCNBN HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x42C77E0", Offset = "0x42C69E0", VA = "0x1842C77E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	private sealed class DGCICNBAEJP : BADBIJFLLKE, IEquatable<BADBIJFLLKE>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A3")]
		[CompilerGenerated]
		private sealed class KNCEJGPKCAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			public AsyncTaskMethodBuilder<NAKMMEJMOAP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000809")]
			public DGCICNBAEJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400080A")]
			private NAKMMEJMOAP <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400080B")]
			private TaskAwaiter<NAKMMEJMOAP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public KNCEJGPKCAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x5C37020", Offset = "0x5C36220", VA = "0x185C37020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private readonly COOLNBMBOGP PFPDMKNCOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private readonly POGAGPMPBJC EJFMGODKEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		private readonly IOAOKAJOOCP KNFMLIAMPLM;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public int NLIFNBICGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x42B9600", Offset = "0x42B8800", VA = "0x1842B9600", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public ICIDMOFEFHA LHKNKDFGODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x42B9650", Offset = "0x42B8850", VA = "0x1842B9650", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private DateTime KHIOCKFMOBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x42B9230", Offset = "0x42B8430", VA = "0x1842B9230", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public POGAGPMPBJC? JJBMAEMNPAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x42B9700", Offset = "0x42B8900", VA = "0x1842B9700", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public IOAOKAJOOCP? GPIMCILOGOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x42B95B0", Offset = "0x42B87B0", VA = "0x1842B95B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public ODCJCBINIIK GBEBLJCEKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x8F2F00", Offset = "0x8F2100", VA = "0x1808F2F00", Slot = "10")]
			get
			{
				return default(ODCJCBINIIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA54B20", Offset = "0xA53D20", VA = "0x180A54B20")]
		public DGCICNBAEJP(COOLNBMBOGP HJNBJLCLGDH, POGAGPMPBJC GOGCPOOCEKO, IOAOKAJOOCP EEMKFLFDFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x42B9280", Offset = "0x42B8480", VA = "0x1842B9280", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(KNCEJGPKCAE))]
		public Task<NAKMMEJMOAP> DBIHDPKDHDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x42B93D0", Offset = "0x42B85D0", VA = "0x1842B93D0", Slot = "11")]
		public bool Equals(BADBIJFLLKE HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x42B9470", Offset = "0x42B8670", VA = "0x1842B9470", Slot = "0")]
		public override bool Equals(object BHEOHCEHIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x42B96A0", Offset = "0x42B88A0", VA = "0x1842B96A0")]
		private bool LLFEHLHOCGD(DGCICNBAEJP HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x42B9520", Offset = "0x42B8720", VA = "0x1842B9520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	private sealed class ICGIPMDHAML : BADBIJFLLKE, IEquatable<BADBIJFLLKE>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A5")]
		[CompilerGenerated]
		private sealed class AGMEHLENGEO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400080F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000810")]
			public AsyncTaskMethodBuilder<NAKMMEJMOAP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000811")]
			public ICGIPMDHAML <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000812")]
			private NAKMMEJMOAP <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000813")]
			private TaskAwaiter<NAKMMEJMOAP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public AGMEHLENGEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x5C32660", Offset = "0x5C31860", VA = "0x185C32660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400080C")]
		private readonly ICIDMOFEFHA GFLKPLPOOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400080D")]
		private readonly POGAGPMPBJC EJFMGODKEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400080E")]
		private readonly IOAOKAJOOCP KNFMLIAMPLM;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public int NLIFNBICGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x42C01D0", Offset = "0x42BF3D0", VA = "0x1842C01D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		[NotNull]
		public ICIDMOFEFHA LHKNKDFGODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		private DateTime KHIOCKFMOBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public POGAGPMPBJC? JJBMAEMNPAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x42C0370", Offset = "0x42BF570", VA = "0x1842C0370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public IOAOKAJOOCP? GPIMCILOGOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x42C0180", Offset = "0x42BF380", VA = "0x1842C0180", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public ODCJCBINIIK GBEBLJCEKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480", Slot = "10")]
			get
			{
				return default(ODCJCBINIIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xA54B20", Offset = "0xA53D20", VA = "0x180A54B20")]
		public ICGIPMDHAML(ICIDMOFEFHA AANKCDLGBJC, POGAGPMPBJC GOGCPOOCEKO, IOAOKAJOOCP EEMKFLFDFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x42BFCF0", Offset = "0x42BEEF0", VA = "0x1842BFCF0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(AGMEHLENGEO))]
		public Task<NAKMMEJMOAP> DBIHDPKDHDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x42BFE40", Offset = "0x42BF040", VA = "0x1842BFE40", Slot = "11")]
		public bool Equals(BADBIJFLLKE HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x42BFF80", Offset = "0x42BF180", VA = "0x1842BFF80", Slot = "0")]
		public override bool Equals(object BHEOHCEHIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x42C00D0", Offset = "0x42BF2D0", VA = "0x1842C00D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x42C0250", Offset = "0x42BF450", VA = "0x1842C0250")]
		private bool LLFEHLHOCGD(ICGIPMDHAML HPOECFLNEOJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class OKLPBFJJMFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		public AsyncTaskMethodBuilder<IList<BADBIJFLLKE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		public ECKJJFLEEBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		private IReadOnlyList<KCDJMIOEEPA> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		private IReadOnlyList<(int accountId, ICIDMOFEFHA account, KCDJMIOEEPA roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		private List<BADBIJFLLKE> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		private COOLNBMBOGP <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		private IReadOnlyList<KCDJMIOEEPA> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		private IReadOnlyList<(int accountId, ICIDMOFEFHA account, KCDJMIOEEPA roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		private IEnumerator<(int accountId, ICIDMOFEFHA account, KCDJMIOEEPA roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		private (int accountId, ICIDMOFEFHA account, KCDJMIOEEPA roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private DGCICNBAEJP <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private TaskAwaiter<IReadOnlyList<KCDJMIOEEPA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		private TaskAwaiter<IReadOnlyList<(int accountId, ICIDMOFEFHA account, KCDJMIOEEPA roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OKLPBFJJMFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x42C5160", Offset = "0x42C4360", VA = "0x1842C5160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class DLKKEMKJEHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400082D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400082E")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, ICIDMOFEFHA account, KCDJMIOEEPA roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400082F")]
		public IReadOnlyList<KCDJMIOEEPA> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000830")]
		public ECKJJFLEEBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000831")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000832")]
		private IReadOnlyList<ICIDMOFEFHA> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000833")]
		private Dictionary<ObscuredInt, ICIDMOFEFHA> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000834")]
		private List<(int, ICIDMOFEFHA, KCDJMIOEEPA)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000835")]
		private IReadOnlyList<ICIDMOFEFHA> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000836")]
		private IEnumerator<KCDJMIOEEPA> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000837")]
		private KCDJMIOEEPA <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000839")]
		private ICIDMOFEFHA <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400083A")]
		private ICIDMOFEFHA <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400083B")]
		private TaskAwaiter<IReadOnlyList<ICIDMOFEFHA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DLKKEMKJEHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x42B9750", Offset = "0x42B8950", VA = "0x1842B9750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F3")]
	private readonly LBBHJGNFLHM CKAIFNDMHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F4")]
	private readonly OPBFCOCOCPJ GJGNMHBILBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007F5")]
	private readonly KPAJKDAICAP DJHHCJPACHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40007F6")]
	private readonly ABIPCOALHKN<(long, long), IReadOnlyList<KCDJMIOEEPA>> BLKEJMNHJFL;

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CFF0", Offset = "0x2D1C1F0", VA = "0x182D1CFF0")]
	[UnityEngine.Scripting.Preserve]
	public ECKJJFLEEBE([IDNKOMINBGM(null)] OPBFCOCOCPJ IOLKMGOEMKI, [IDNKOMINBGM(null)] KPAJKDAICAP LCCOJKAOBDI, [IDNKOMINBGM(null)] LBBHJGNFLHM GGNFNGIMIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CB40", Offset = "0x2D1BD40", VA = "0x182D1CB40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OKLPBFJJMFN))]
	public Task<IList<BADBIJFLLKE>> GDLMBMGKLAB(long LNBFDCAEKJF, long GLLEENOIFOJ, bool HMPFDNENOKG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CE50", Offset = "0x2D1C050", VA = "0x182D1CE50")]
	private bool MHOMODCMJEN(DateTime? ALFFBPBOEMF, long LNBFDCAEKJF, long GLLEENOIFOJ, out COOLNBMBOGP CGJKBLJLHJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CCE0", Offset = "0x2D1BEE0", VA = "0x182D1CCE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DLKKEMKJEHK))]
	private Task<IReadOnlyList<(int, ICIDMOFEFHA, KCDJMIOEEPA)>> JDKJAMGNMPK(IReadOnlyList<KCDJMIOEEPA> EONLNGNIGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal class BMLPDOOECBP : OPBFCOCOCPJ
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private sealed class OLMLOCDICAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400083C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400083D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<KCDJMIOEEPA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400083E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000840")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000841")]
		public BMLPDOOECBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000842")]
		private PONDDPFHIJK<KCDJMIOEEPA> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000843")]
		private PONDDPFHIJK<KCDJMIOEEPA> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000844")]
		private TaskAwaiter<PONDDPFHIJK<KCDJMIOEEPA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OLMLOCDICAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x36FC0F0", Offset = "0x36FB2F0", VA = "0x1836FC0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private sealed class DEAEHBBLHFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000845")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000846")]
		public AsyncTaskMethodBuilder<IReadOnlyList<ICIDMOFEFHA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000847")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000848")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000849")]
		public BMLPDOOECBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400084A")]
		private List<ICIDMOFEFHA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400084B")]
		private TaskAwaiter<List<ICIDMOFEFHA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DEAEHBBLHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x36E9F40", Offset = "0x36E9140", VA = "0x1836E9F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	[UnityEngine.Scripting.Preserve]
	public BMLPDOOECBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D6C0", Offset = "0x2D0C8C0", VA = "0x182D0D6C0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OLMLOCDICAE))]
	public Task<IReadOnlyList<KCDJMIOEEPA>> KJIDCMDGPDE(long LNBFDCAEKJF, long HGPBCNPIJHG, [Optional] CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D520", Offset = "0x2D0C720", VA = "0x182D0D520", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DEAEHBBLHFE))]
	public Task<IReadOnlyList<ICIDMOFEFHA>> EKBPOBLFMJD(IReadOnlyList<int> KDNFKMNKCKB, [Optional] CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public interface OPBFCOCOCPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<KCDJMIOEEPA>> KJIDCMDGPDE(long LNBFDCAEKJF, long HGPBCNPIJHG, [Optional] CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<ICIDMOFEFHA>> EKBPOBLFMJD(IReadOnlyList<int> KDNFKMNKCKB, [Optional] CancellationToken PLEKJLHDOLP);
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public interface BADBIJFLLKE : IEquatable<BADBIJFLLKE>
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	int NLIFNBICGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	[CanBeNull]
	ICIDMOFEFHA LHKNKDFGODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	DateTime IMEMBFDMHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	POGAGPMPBJC? JJBMAEMNPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	IOAOKAJOOCP? GPIMCILOGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	[CanBeNull]
	ODCJCBINIIK GBEBLJCEKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NAKMMEJMOAP> DBIHDPKDHDF();
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public enum ODCJCBINIIK
{
	[Cpp2IlInjected.Token(Token = "0x400084D")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400084E")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400084F")]
	DiskAutosave
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
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
