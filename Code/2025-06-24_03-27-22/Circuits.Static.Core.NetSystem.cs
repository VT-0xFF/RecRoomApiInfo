using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29472C0", Offset = "0x2945EC0", VA = "0x1829472C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HEJNMBKEHBF : AJHEICOHAGC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2947290", Offset = "0x2945E90", VA = "0x182947290", Slot = "7")]
	public override string NEEGIDJCGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2947230", Offset = "0x2945E30", VA = "0x182947230")]
	private HEJNMBKEHBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2947240", Offset = "0x2945E40", VA = "0x182947240")]
	public static HEJNMBKEHBF JHMOIFLKJAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BLHBNEGMOKN<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, CDGFAMKPECH.LCODIDDFPFE<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ADCCJEHGICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] PMMLBHLMMEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int KJLDNHFCBAH;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x124AD70", Offset = "0x1249970", VA = "0x18124AD70")]
		private ADCCJEHGICN(TPartialAction[] NJFGGMNOPGE, int JACNOLEMGLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4CE1F40", Offset = "0x4CE0B40", VA = "0x184CE1F40")]
		public static BLHBNEGMOKN<TPartialAction, TPartialActionId, TFullAction, TDeps>.ADCCJEHGICN JHMOIFLKJAD(int GOKNIIFJJCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4CE1C10", Offset = "0x4CE0810", VA = "0x184CE1C10")]
		public MFCBKIOLAIJ<TFullAction> EMJKNOHDFAA(TPartialAction ANPODIMILKD, TDeps FCHJEFGMLNE)
		{
			return default(MFCBKIOLAIJ<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, ADCCJEHGICN>? JLHIECLMGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps MPDEJFBBCAJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, ADCCJEHGICN> DEACKGPCBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6480700", Offset = "0x647F300", VA = "0x186480700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64807E0", Offset = "0x647F3E0", VA = "0x1864807E0")]
	private BLHBNEGMOKN(Dictionary<TPartialActionId, ADCCJEHGICN>? NKNINKCJKCP, TDeps FCHJEFGMLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x64806B0", Offset = "0x647F2B0", VA = "0x1864806B0")]
	public static BLHBNEGMOKN<TPartialAction, TPartialActionId, TFullAction, TDeps> JHMOIFLKJAD(TDeps FCHJEFGMLNE)
	{
		return default(BLHBNEGMOKN<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6480070", Offset = "0x647EC70", VA = "0x186480070")]
	public MDDPJNIIBBI<MFCBKIOLAIJ<TFullAction>, JHFNBJHGPJG> EMJKNOHDFAA(TPartialAction ANPODIMILKD)
	{
		return default(MDDPJNIIBBI<MFCBKIOLAIJ<TFullAction>, JHFNBJHGPJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x647F850", Offset = "0x647E450", VA = "0x18647F850")]
	public void EDIOFDAMCBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CDGFAMKPECH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface LCODIDDFPFE<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CDOHMCHJIJE([In] TPartialAction ANPODIMILKD);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int CFLLECLMIBD([In] TPartialAction ANPODIMILKD);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId EPCLJEPCFEH([In] TPartialAction ANPODIMILKD);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction CKFFCFKPPKH(TPartialAction[] MMLJKHMCDIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HMICMDGHIKC<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : MDDCMIBMBDB.NLBLJEEHIGG<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] PDEIBCLNGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int HLGHHNGKLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps MPDEJFBBCAJ;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DB62A0", Offset = "0x4DB4EA0", VA = "0x184DB62A0")]
	internal HMICMDGHIKC(TPartialSnapshot[] EPGMEFDLDEB, int CKCMDNFGKKO, TDeps FCHJEFGMLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4DB6240", Offset = "0x4DB4E40", VA = "0x184DB6240")]
	public static HMICMDGHIKC<TPartialSnapshot, TFullSnapshot, TDeps> JHMOIFLKJAD(TDeps FCHJEFGMLNE)
	{
		return default(HMICMDGHIKC<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MDDCMIBMBDB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface NLBLJEEHIGG<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AAPHDNOHANP([In] TPartialSnapshot FMFOPDDCAPI);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot CEBEEDFHJPJ(TPartialSnapshot[] ENCEEBHDOFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE740", Offset = "0x3BAD340", VA = "0x183BAE740")]
	public static MFCBKIOLAIJ<TFullSnapshot> EMJKNOHDFAA<TFullSnapshot, TPartialSnapshot, TDeps>(this HMICMDGHIKC<TPartialSnapshot, TFullSnapshot, TDeps> LAAPKLDJLPE, TPartialSnapshot FMFOPDDCAPI) where TDeps : NLBLJEEHIGG<TPartialSnapshot, TFullSnapshot>
	{
		return default(MFCBKIOLAIJ<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEAF0", Offset = "0x3BAD6F0", VA = "0x183BAEAF0")]
	public static bool MLCEADACLPM<TPartialSnapshot, TFullSnapshot, TDeps>(this HMICMDGHIKC<TPartialSnapshot, TFullSnapshot, TDeps> LAAPKLDJLPE, TPartialSnapshot FMFOPDDCAPI) where TDeps : NLBLJEEHIGG<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class AGHBPLGPFBL : AJHEICOHAGC
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2947200", Offset = "0x2945E00", VA = "0x182947200", Slot = "7")]
	public override string NEEGIDJCGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2947230", Offset = "0x2945E30", VA = "0x182947230")]
	public AGHBPLGPFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class KIIIPFOEKFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : AFHJFGFNFMA.CLIHBJIEPPA<TAction, TNetSys> where TReceiverDeps : AFHJFGFNFMA.PNKKLKBNADN<TAction, TReceiver> where TRootDeps : AFHJFGFNFMA.KLIPFOIGICN<TMRequest, TAction, TRoot> where TDeps : AFHJFGFNFMA.OFOPAMEGJPF<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface LCGFJACPCNH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CMPOCNNAEOL([In] MDDPJNIIBBI<object, JHFNBJHGPJG> DBJBIPJCIKA);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KDEGMCFMKLM();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MDDPJNIIBBI<object, JHFNBJHGPJG> IJNMMFFLFIN();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JEHINOLFBHG(Exception DFLKFAIHDKI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class DNNDGJNKFFE : LCGFJACPCNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<MDDPJNIIBBI<object, JHFNBJHGPJG>> CJGGLFPDNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<MDDPJNIIBBI<object, EFKBKOGFPPJ>> CCGAEPMPLHK;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x42D1A70", Offset = "0x42D0670", VA = "0x1842D1A70")]
		private DNNDGJNKFFE(TaskCompletionSource<MDDPJNIIBBI<object, JHFNBJHGPJG>> GGCMENFMEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x42D1710", Offset = "0x42D0310", VA = "0x1842D1710")]
		public static DNNDGJNKFFE JHMOIFLKJAD(TaskCompletionSource<MDDPJNIIBBI<object, JHFNBJHGPJG>> GGCMENFMEPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x42D12C0", Offset = "0x42CFEC0", VA = "0x1842D12C0")]
		public void CMPOCNNAEOL([In] MDDPJNIIBBI<object, JHFNBJHGPJG> DBJBIPJCIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x42D1990", Offset = "0x42D0590", VA = "0x1842D1990", Slot = "5")]
		public void KDEGMCFMKLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x42D1490", Offset = "0x42D0090", VA = "0x1842D1490", Slot = "6")]
		public MDDPJNIIBBI<object, JHFNBJHGPJG> IJNMMFFLFIN()
		{
			return default(MDDPJNIIBBI<object, JHFNBJHGPJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x42D16B0", Offset = "0x42D02B0", VA = "0x1842D16B0", Slot = "7")]
		public void JEHINOLFBHG(Exception DFLKFAIHDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x42D13C0", Offset = "0x42CFFC0", VA = "0x1842D13C0", Slot = "4")]
		private void FCBLNENBHPA([In] MDDPJNIIBBI<object, JHFNBJHGPJG> DBJBIPJCIKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class NBDDPDGPNOI : LCGFJACPCNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<MDDPJNIIBBI<object, JHFNBJHGPJG>> CJGGLFPDNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private MDDPJNIIBBI<object, JHFNBJHGPJG> KKGPCFBNKFK;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
		private NBDDPDGPNOI(TaskCompletionSource<MDDPJNIIBBI<object, JHFNBJHGPJG>> GGCMENFMEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x42D1710", Offset = "0x42D0310", VA = "0x1842D1710")]
		public static NBDDPDGPNOI JHMOIFLKJAD(TaskCompletionSource<MDDPJNIIBBI<object, JHFNBJHGPJG>> GGCMENFMEPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xE5F890", Offset = "0xE5E490", VA = "0x180E5F890")]
		public void CMPOCNNAEOL([In] MDDPJNIIBBI<object, JHFNBJHGPJG> DBJBIPJCIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5517180", Offset = "0x5515D80", VA = "0x185517180", Slot = "5")]
		public void KDEGMCFMKLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xCADF90", Offset = "0xCACB90", VA = "0x180CADF90", Slot = "6")]
		public MDDPJNIIBBI<object, JHFNBJHGPJG> IJNMMFFLFIN()
		{
			return default(MDDPJNIIBBI<object, JHFNBJHGPJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5517060", Offset = "0x5515C60", VA = "0x185517060", Slot = "7")]
		public void JEHINOLFBHG(Exception DFLKFAIHDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x42D13C0", Offset = "0x42CFFC0", VA = "0x1842D13C0", Slot = "4")]
		private void FCBLNENBHPA([In] MDDPJNIIBBI<object, JHFNBJHGPJG> DBJBIPJCIKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class OAIMEDAMBGB : LCGFJACPCNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<MDDPJNIIBBI<object, JHFNBJHGPJG>> CCGAEPMPLHK;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x564EDE0", Offset = "0x564D9E0", VA = "0x18564EDE0")]
		private OAIMEDAMBGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x52C1940", Offset = "0x52C0540", VA = "0x1852C1940")]
		public static OAIMEDAMBGB JHMOIFLKJAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x564EB00", Offset = "0x564D700", VA = "0x18564EB00")]
		public void CMPOCNNAEOL([In] MDDPJNIIBBI<object, JHFNBJHGPJG> DBJBIPJCIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void KDEGMCFMKLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x564EBD0", Offset = "0x564D7D0", VA = "0x18564EBD0", Slot = "6")]
		public MDDPJNIIBBI<object, JHFNBJHGPJG> IJNMMFFLFIN()
		{
			return default(MDDPJNIIBBI<object, JHFNBJHGPJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x564ECF0", Offset = "0x564D8F0", VA = "0x18564ECF0", Slot = "7")]
		[MHCDBJJGKDE("This may be terminal and should probably do more than discarding the exception.")]
		public void JEHINOLFBHG(Exception DFLKFAIHDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x42D13C0", Offset = "0x42CFFC0", VA = "0x1842D13C0", Slot = "4")]
		private void FCBLNENBHPA([In] MDDPJNIIBBI<object, JHFNBJHGPJG> DBJBIPJCIKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class LKJNAJJKBEJ : LCGFJACPCNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MDDPJNIIBBI<object, JHFNBJHGPJG> KKGPCFBNKFK;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		private LKJNAJJKBEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x52C1940", Offset = "0x52C0540", VA = "0x1852C1940")]
		public static LKJNAJJKBEJ JHMOIFLKJAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x24F4F60", Offset = "0x24F3B60", VA = "0x1824F4F60")]
		public void CMPOCNNAEOL([In] MDDPJNIIBBI<object, JHFNBJHGPJG> DBJBIPJCIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void KDEGMCFMKLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xDDC970", Offset = "0xDDB570", VA = "0x180DDC970", Slot = "6")]
		public MDDPJNIIBBI<object, JHFNBJHGPJG> IJNMMFFLFIN()
		{
			return default(MDDPJNIIBBI<object, JHFNBJHGPJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x52C1850", Offset = "0x52C0450", VA = "0x1852C1850", Slot = "7")]
		[MHCDBJJGKDE("This may be terminal and should probably do more than discarding the exception.")]
		public void JEHINOLFBHG(Exception DFLKFAIHDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x42D13C0", Offset = "0x42CFFC0", VA = "0x1842D13C0", Slot = "4")]
		private void FCBLNENBHPA([In] MDDPJNIIBBI<object, JHFNBJHGPJG> DBJBIPJCIKA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct LFALOEFCJMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<object, JHFNBJHGPJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KIIIPFOEKFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public IKLALLBKLKC<KJCLJNBJCIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<MDDPJNIIBBI<object, JHFNBJHGPJG>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<MDDPJNIIBBI<object, JHFNBJHGPJG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x52B40B0", Offset = "0x52B2CB0", VA = "0x1852B40B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x52B4B20", Offset = "0x52B3720", VA = "0x1852B4B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct OLCNKJIMIJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<object, JHFNBJHGPJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KIIIPFOEKFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public IKLALLBKLKC<KJCLJNBJCIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<MDDPJNIIBBI<object, JHFNBJHGPJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x567CD70", Offset = "0x567B970", VA = "0x18567CD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x567DAE0", Offset = "0x567C6E0", VA = "0x18567DAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct CGLMEGPGCMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<object, JHFNBJHGPJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public KIIIPFOEKFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IKLALLBKLKC<KJCLJNBJCIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IKLALLBKLKC<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<MDDPJNIIBBI<object, JHFNBJHGPJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6946820", Offset = "0x6945420", VA = "0x186946820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6946F20", Offset = "0x6945B20", VA = "0x186946F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct FKFFDGBFMCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<object, JHFNBJHGPJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public KIIIPFOEKFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public IKLALLBKLKC<KJCLJNBJCIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IKLALLBKLKC<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private LCGFJACPCNH <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4C18AB0", Offset = "0x4C176B0", VA = "0x184C18AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4C1A160", Offset = "0x4C18D60", VA = "0x184C1A160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct OPMJNFMKEAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KIIIPFOEKFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public LCGFJACPCNH completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private LCGFJACPCNH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<MDDPJNIIBBI<object?, JHFNBJHGPJG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x569E320", Offset = "0x569CF20", VA = "0x18569E320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x56A2080", Offset = "0x56A0C80", VA = "0x1856A2080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct AGMICDBFBAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public TAction[] snapshotActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public KIIIPFOEKFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IKLALLBKLKC<KJCLJNBJCIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4D64EF0", Offset = "0x4D63AF0", VA = "0x184D64EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4D658F0", Offset = "0x4D644F0", VA = "0x184D658F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps MPDEJFBBCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<IKLALLBKLKC<TMRequest>, TaskCompletionSource<MDDPJNIIBBI<object, JHFNBJHGPJG>>> NAMBMNBFIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private JMKACCGBKOL<TMRequest> OJIHFMIOAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool OIHAFPGIKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int HCCDEBGBMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task FONNGGPAIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int LJIGCLPDEHD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps FDLELNAPDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x51E6FB0", Offset = "0x51E5BB0", VA = "0x1851E6FB0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps ABJHHLMCEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x51E6EE0", Offset = "0x51E5AE0", VA = "0x1851E6EE0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps HBAPIJJGHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x51E5DA0", Offset = "0x51E49A0", VA = "0x1851E5DA0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IIEHBKADHHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xDC7F20", Offset = "0xDC6B20", VA = "0x180DC7F20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xDC7470", Offset = "0xDC6070", VA = "0x180DC7470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KHKJGHPPPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA20E70", Offset = "0xA1FA70", VA = "0x180A20E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CHHAOMBEBDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA3B560", Offset = "0xA3A160", VA = "0x180A3B560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x51E7380", Offset = "0x51E5F80", VA = "0x1851E7380")]
	public KIIIPFOEKFO(TDeps FCHJEFGMLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x51E48F0", Offset = "0x51E34F0", VA = "0x1851E48F0")]
	public Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> BMDDJNJNMEG(TRoot HMGDINOCJAI, TNetSys IBMJGCPAINO, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, TAction IFDCDCHOGGB, bool DLHOJKLEPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x51E43E0", Offset = "0x51E2FE0", VA = "0x1851E43E0")]
	[AsyncStateMachine(typeof(KIIIPFOEKFO<, , , , , , , , >.LFALOEFCJMP))]
	private Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> BMDDJNJNMEG(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, TAction IFDCDCHOGGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x51E3E70", Offset = "0x51E2A70", VA = "0x1851E3E70")]
	[AsyncStateMachine(typeof(KIIIPFOEKFO<, , , , , , , , >.OLCNKJIMIJP))]
	private Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> BEIDLNJPKMO(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, TAction[] PEENJLIBDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x51E6C00", Offset = "0x51E5800", VA = "0x1851E6C00")]
	[AsyncStateMachine(typeof(KIIIPFOEKFO<, , , , , , , , >.CGLMEGPGCMA))]
	public Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> JHICCGNIOLB(TRoot HMGDINOCJAI, TNetSys LAGEJJBCPNF, TReceiver ODPFHLHHEBI, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, IKLALLBKLKC<TMRequest> NFHIONLLLPO, TAction IFDCDCHOGGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x51E5260", Offset = "0x51E3E60", VA = "0x1851E5260")]
	[AsyncStateMachine(typeof(KIIIPFOEKFO<, , , , , , , , >.FKFFDGBFMCB))]
	private Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> EPANINBIJIL(TRoot HMGDINOCJAI, TNetSys LAGEJJBCPNF, TReceiver ODPFHLHHEBI, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, IKLALLBKLKC<TMRequest> NFHIONLLLPO, TAction IFDCDCHOGGB, Task HOHHHINHPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x51E4E60", Offset = "0x51E3A60", VA = "0x1851E4E60")]
	[AsyncStateMachine(typeof(KIIIPFOEKFO<, , , , , , , , >.OPMJNFMKEAE))]
	private Task EAOGNNFDHEF(TRoot HMGDINOCJAI, TNetSys LAGEJJBCPNF, TReceiver ODPFHLHHEBI, TAction IFDCDCHOGGB, LCGFJACPCNH EIKHBOPFLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x51E7080", Offset = "0x51E5C80", VA = "0x1851E7080")]
	private void NKFIKJJOOGD(TReceiver ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x51E6700", Offset = "0x51E5300", VA = "0x1851E6700")]
	private void IGMAFCIBADE(TRoot HMGDINOCJAI, TNetSys LAGEJJBCPNF, TReceiver ODPFHLHHEBI, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, TAction IFDCDCHOGGB, bool JMPHIHLNOFF, bool HHMPEMGBCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x51E3BD0", Offset = "0x51E27D0", VA = "0x1851E3BD0")]
	[AsyncStateMachine(typeof(KIIIPFOEKFO<, , , , , , , , >.AGMICDBFBAL))]
	public Task AIKPLGJPMNO(TRoot HMGDINOCJAI, TNetSys LAGEJJBCPNF, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, TAction[] PGILDNONDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x51E58D0", Offset = "0x51E44D0", VA = "0x1851E58D0")]
	private (TAction, int) FGJKMKPAMAG(TRoot HMGDINOCJAI, TNetSys GABDFBHLDPI, TAction IFDCDCHOGGB)
	{
		return default((TAction, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class AFHJFGFNFMA
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface CLIHBJIEPPA<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OIOJLJDOFEG(TNetSys MKCEANKCCLP, TAction IFDCDCHOGGB);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction GAGFMOENDGE(TNetSys MKCEANKCCLP, TAction IFDCDCHOGGB);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction KBKPKFFMJIP(TNetSys MKCEANKCCLP, TAction IFDCDCHOGGB);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> GJIHGDBMJOI(TNetSys MKCEANKCCLP, TAction IFDCDCHOGGB);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] DKDOFLEPFEF(TNetSys MKCEANKCCLP, TAction IFDCDCHOGGB, int APAACMLOBMA);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ODGNOEDIEDB(TNetSys MKCEANKCCLP, TAction IFDCDCHOGGB);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DKABCLAHIGG(TNetSys MKCEANKCCLP, TAction IFDCDCHOGGB);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool EPEDBGKPEHD(TNetSys MKCEANKCCLP, TAction IFDCDCHOGGB);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool HFJENPOHDNI(TNetSys MKCEANKCCLP, TAction IFDCDCHOGGB);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool BAFMONGMIGK(TNetSys MKCEANKCCLP, TAction IFDCDCHOGGB);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool HLIMGPAPAEG(TNetSys MKCEANKCCLP, TAction IFDCDCHOGGB);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface OFOPAMEGJPF<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps FDLELNAPDAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps HBAPIJJGHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps ABJHHLMCEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface PNKKLKBNADN<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IKLALLBKLKC<KJCLJNBJCIN> MIKKLEDLIAI(TReceiver ODPFHLHHEBI);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JLBJBEHMHJK(TReceiver ODPFHLHHEBI);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> JHICCGNIOLB(TReceiver ODPFHLHHEBI, TAction IFDCDCHOGGB);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] NAPOLEMBJFO(TReceiver ODPFHLHHEBI);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface KLIPFOIGICN<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IFHLMMPFCFG(TRoot HMGDINOCJAI);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int JMELMMPMBEB(TRoot HMGDINOCJAI);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int IIBKAKAIIHD(TRoot HMGDINOCJAI);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int LOCGFANKBPE(TRoot HMGDINOCJAI);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BELDBNFIHBO(TRoot HMGDINOCJAI);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LHFILICJAJL(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, TAction[] PEENJLIBDIA);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool GEGDKICAFLP(TRoot HMGDINOCJAI, int EPFIKJHJFND);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task BMDDJNJNMEG(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, IKLALLBKLKC<TMRequest> NFHIONLLLPO, TAction IFDCDCHOGGB, bool IJNEMJEKNLN = true);
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
