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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2341CB0", Offset = "0x23404B0", VA = "0x182341CB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ILDFOIJMLCP : DBICEFMNJAI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2341C70", Offset = "0x2340470", VA = "0x182341C70", Slot = "7")]
	public override string DHOBPLNCIMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2341CA0", Offset = "0x23404A0", VA = "0x182341CA0")]
	private ILDFOIJMLCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2341C20", Offset = "0x2340420", VA = "0x182341C20")]
	public static ILDFOIJMLCP DFLBOLBHLFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct INMOCHECCOK<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, ECFNKOLLPMP.MHLBFGNDICP<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MMPEJKELNFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] BLNGMEEBHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int AOHFKJAHJJM;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD2DF20", Offset = "0xD2C720", VA = "0x180D2DF20")]
		private MMPEJKELNFI(TPartialAction[] HADKJKJPDBC, int ENMBKODPDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x49EA320", Offset = "0x49E8B20", VA = "0x1849EA320")]
		public static INMOCHECCOK<TPartialAction, TPartialActionId, TFullAction, TDeps>.MMPEJKELNFI DFLBOLBHLFN(int FIODKFGGDNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x49E9FC0", Offset = "0x49E87C0", VA = "0x1849E9FC0")]
		public CNCELCGNJHH<TFullAction> CANEIHOBKBP(TPartialAction GOEKBEEIPHM, TDeps HNBDHJIILED)
		{
			return default(CNCELCGNJHH<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, MMPEJKELNFI>? AMPGDLBIABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps NNDMPDFKOOK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, MMPEJKELNFI> CJHLNHHNGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x43380F0", Offset = "0x43368F0", VA = "0x1843380F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x43381E0", Offset = "0x43369E0", VA = "0x1843381E0")]
	private INMOCHECCOK(Dictionary<TPartialActionId, MMPEJKELNFI>? EDJCHFFFHNN, TDeps HNBDHJIILED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4337F80", Offset = "0x4336780", VA = "0x184337F80")]
	public static INMOCHECCOK<TPartialAction, TPartialActionId, TFullAction, TDeps> DFLBOLBHLFN(TDeps HNBDHJIILED)
	{
		return default(INMOCHECCOK<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x43378E0", Offset = "0x43360E0", VA = "0x1843378E0")]
	public DNFCNMKAMCE<CNCELCGNJHH<TFullAction>, OOJAGAFOLJL> CANEIHOBKBP(TPartialAction GOEKBEEIPHM)
	{
		return default(DNFCNMKAMCE<CNCELCGNJHH<TFullAction>, OOJAGAFOLJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4338030", Offset = "0x4336830", VA = "0x184338030")]
	public void HAADKLMLAKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ECFNKOLLPMP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface MHLBFGNDICP<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LHANHNHIFCO([In] TPartialAction GOEKBEEIPHM);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int ECOCJDLMKOO([In] TPartialAction GOEKBEEIPHM);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId JNMGDPOKCFJ([In] TPartialAction GOEKBEEIPHM);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction LDHENEGCEEA(TPartialAction[] MDPOKABKNMN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BFJHFNFEEAD<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : JDCHCCIAKEJ.CBNAAHDLABH<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] IHKPPOAEFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int EENGAFJKBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps NNDMPDFKOOK;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x53AEA70", Offset = "0x53AD270", VA = "0x1853AEA70")]
	internal BFJHFNFEEAD(TPartialSnapshot[] OJNFHKDFIGD, int DJELNPJJLNN, TDeps HNBDHJIILED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x53AE9A0", Offset = "0x53AD1A0", VA = "0x1853AE9A0")]
	public static BFJHFNFEEAD<TPartialSnapshot, TFullSnapshot, TDeps> DFLBOLBHLFN(TDeps HNBDHJIILED)
	{
		return default(BFJHFNFEEAD<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JDCHCCIAKEJ
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface CBNAAHDLABH<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FDIHAGFGMEE([In] TPartialSnapshot EEGFKLHFIOO);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot LIEMHMNLDJG(TPartialSnapshot[] MJNMHGBFELK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x30B6870", Offset = "0x30B5070", VA = "0x1830B6870")]
	public static CNCELCGNJHH<TFullSnapshot> CANEIHOBKBP<TFullSnapshot, TPartialSnapshot, TDeps>(this BFJHFNFEEAD<TPartialSnapshot, TFullSnapshot, TDeps> EGGDEECAALI, TPartialSnapshot EEGFKLHFIOO) where TDeps : CBNAAHDLABH<TPartialSnapshot, TFullSnapshot>
	{
		return default(CNCELCGNJHH<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x30B6C60", Offset = "0x30B5460", VA = "0x1830B6C60")]
	public static bool FMBFNBLFHJL<TPartialSnapshot, TFullSnapshot, TDeps>(this BFJHFNFEEAD<TPartialSnapshot, TFullSnapshot, TDeps> EGGDEECAALI, TPartialSnapshot EEGFKLHFIOO) where TDeps : CBNAAHDLABH<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class OCNMCOKEEKE : DBICEFMNJAI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2341D30", Offset = "0x2340530", VA = "0x182341D30", Slot = "7")]
	public override string DHOBPLNCIMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2341CA0", Offset = "0x23404A0", VA = "0x182341CA0")]
	public OCNMCOKEEKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class HNEDJHPAJFA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : HMGJAKFBCCP.OAHBIAIIOPM<TAction, TNetSys> where TReceiverDeps : HMGJAKFBCCP.NNAMCGCLGJB<TAction, TReceiver> where TRootDeps : HMGJAKFBCCP.GOKJDAMGMEH<TMRequest, TAction, TRoot> where TDeps : HMGJAKFBCCP.MIHNIGKFCBI<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface MMAJNKKNIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BLOIKGIAACE([In] DNFCNMKAMCE<object, OOJAGAFOLJL> HANDIANDCDI);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OLHPOPFGDBK();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DNFCNMKAMCE<object, OOJAGAFOLJL> KDDIJBBKNPE();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KEHGGLOFPDF(Exception HNGGNNBFAEK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class KFPJKFIHPHG : MMAJNKKNIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<DNFCNMKAMCE<object, OOJAGAFOLJL>> GNEHDDNOKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<DNFCNMKAMCE<object, EPICLACHOCO>> HNJJMJOFCCI;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x46399A0", Offset = "0x46381A0", VA = "0x1846399A0")]
		private KFPJKFIHPHG(TaskCompletionSource<DNFCNMKAMCE<object, OOJAGAFOLJL>> BOBBGFPNGHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x43A3030", Offset = "0x43A1830", VA = "0x1843A3030")]
		public static KFPJKFIHPHG DFLBOLBHLFN(TaskCompletionSource<DNFCNMKAMCE<object, OOJAGAFOLJL>> BOBBGFPNGHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x46394A0", Offset = "0x4637CA0", VA = "0x1846394A0")]
		public void BLOIKGIAACE([In] DNFCNMKAMCE<object, OOJAGAFOLJL> HANDIANDCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x46397E0", Offset = "0x4637FE0", VA = "0x1846397E0", Slot = "5")]
		public void OLHPOPFGDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x46395C0", Offset = "0x4637DC0", VA = "0x1846395C0", Slot = "6")]
		public DNFCNMKAMCE<object, OOJAGAFOLJL> KDDIJBBKNPE()
		{
			return default(DNFCNMKAMCE<object, OOJAGAFOLJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4639720", Offset = "0x4637F20", VA = "0x184639720", Slot = "7")]
		public void KEHGGLOFPDF(Exception HNGGNNBFAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x43A3100", Offset = "0x43A1900", VA = "0x1843A3100", Slot = "4")]
		private void FBLACPHPNNC([In] DNFCNMKAMCE<object, OOJAGAFOLJL> HANDIANDCDI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class AKGMJDJIBEC : MMAJNKKNIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<DNFCNMKAMCE<object, OOJAGAFOLJL>> GNEHDDNOKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private DNFCNMKAMCE<object, OOJAGAFOLJL> AOAONBDIHKD;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
		private AKGMJDJIBEC(TaskCompletionSource<DNFCNMKAMCE<object, OOJAGAFOLJL>> BOBBGFPNGHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x43A3030", Offset = "0x43A1830", VA = "0x1843A3030")]
		public static AKGMJDJIBEC DFLBOLBHLFN(TaskCompletionSource<DNFCNMKAMCE<object, OOJAGAFOLJL>> BOBBGFPNGHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1990", Offset = "0x3CD0190", VA = "0x183CD1990")]
		public void BLOIKGIAACE([In] DNFCNMKAMCE<object, OOJAGAFOLJL> HANDIANDCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x43A3200", Offset = "0x43A1A00", VA = "0x1843A3200", Slot = "5")]
		public void OLHPOPFGDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB570", Offset = "0x9D9D70", VA = "0x1809DB570", Slot = "6")]
		public DNFCNMKAMCE<object, OOJAGAFOLJL> KDDIJBBKNPE()
		{
			return default(DNFCNMKAMCE<object, OOJAGAFOLJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x43A31A0", Offset = "0x43A19A0", VA = "0x1843A31A0", Slot = "7")]
		public void KEHGGLOFPDF(Exception HNGGNNBFAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x43A3100", Offset = "0x43A1900", VA = "0x1843A3100", Slot = "4")]
		private void FBLACPHPNNC([In] DNFCNMKAMCE<object, OOJAGAFOLJL> HANDIANDCDI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class MPCOIAKFGLA : MMAJNKKNIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<DNFCNMKAMCE<object, OOJAGAFOLJL>> HNJJMJOFCCI;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x49F91F0", Offset = "0x49F79F0", VA = "0x1849F91F0")]
		private MPCOIAKFGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x49F8F40", Offset = "0x49F7740", VA = "0x1849F8F40")]
		public static MPCOIAKFGLA DFLBOLBHLFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x49F8D80", Offset = "0x49F7580", VA = "0x1849F8D80")]
		public void BLOIKGIAACE([In] DNFCNMKAMCE<object, OOJAGAFOLJL> HANDIANDCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		public void OLHPOPFGDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x49F9000", Offset = "0x49F7800", VA = "0x1849F9000", Slot = "6")]
		public DNFCNMKAMCE<object, OOJAGAFOLJL> KDDIJBBKNPE()
		{
			return default(DNFCNMKAMCE<object, OOJAGAFOLJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x49F9110", Offset = "0x49F7910", VA = "0x1849F9110", Slot = "7")]
		[DGOKMPKFCKH("This may be terminal and should probably do more than discarding the exception.")]
		public void KEHGGLOFPDF(Exception HNGGNNBFAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x43A3100", Offset = "0x43A1900", VA = "0x1843A3100", Slot = "4")]
		private void FBLACPHPNNC([In] DNFCNMKAMCE<object, OOJAGAFOLJL> HANDIANDCDI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class CPBIHOGKLIC : MMAJNKKNIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DNFCNMKAMCE<object, OOJAGAFOLJL> AOAONBDIHKD;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		private CPBIHOGKLIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x49F8F40", Offset = "0x49F7740", VA = "0x1849F8F40")]
		public static CPBIHOGKLIC DFLBOLBHLFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1CC1FA0", Offset = "0x1CC07A0", VA = "0x181CC1FA0")]
		public void BLOIKGIAACE([In] DNFCNMKAMCE<object, OOJAGAFOLJL> HANDIANDCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		public void OLHPOPFGDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB2DD30", Offset = "0xB2C530", VA = "0x180B2DD30", Slot = "6")]
		public DNFCNMKAMCE<object, OOJAGAFOLJL> KDDIJBBKNPE()
		{
			return default(DNFCNMKAMCE<object, OOJAGAFOLJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5A20EB0", Offset = "0x5A1F6B0", VA = "0x185A20EB0", Slot = "7")]
		[DGOKMPKFCKH("This may be terminal and should probably do more than discarding the exception.")]
		public void KEHGGLOFPDF(Exception HNGGNNBFAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x43A3100", Offset = "0x43A1900", VA = "0x1843A3100", Slot = "4")]
		private void FBLACPHPNNC([In] DNFCNMKAMCE<object, OOJAGAFOLJL> HANDIANDCDI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct CKFFPNPOOJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HNEDJHPAJFA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MFKBDIPIOIA<JHAGCFIKKAF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<DNFCNMKAMCE<object, OOJAGAFOLJL>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5930010", Offset = "0x592E810", VA = "0x185930010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5930560", Offset = "0x592ED60", VA = "0x185930560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct KMGILALCDAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HNEDJHPAJFA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MFKBDIPIOIA<JHAGCFIKKAF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x466D530", Offset = "0x466BD30", VA = "0x18466D530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x466D990", Offset = "0x466C190", VA = "0x18466D990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct PIFFMCANNOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public HNEDJHPAJFA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public MFKBDIPIOIA<JHAGCFIKKAF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public MFKBDIPIOIA<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4C68760", Offset = "0x4C66F60", VA = "0x184C68760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4C68E30", Offset = "0x4C67630", VA = "0x184C68E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct NLBBMDPHADB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public HNEDJHPAJFA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public MFKBDIPIOIA<JHAGCFIKKAF> senderId;

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
		public MFKBDIPIOIA<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private MMAJNKKNIFJ <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4A57270", Offset = "0x4A55A70", VA = "0x184A57270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4A58CC0", Offset = "0x4A574C0", VA = "0x184A58CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BDAFCKGJGHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public HNEDJHPAJFA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public MMAJNKKNIFJ completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private MMAJNKKNIFJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<DNFCNMKAMCE<object?, OOJAGAFOLJL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x539D940", Offset = "0x539C140", VA = "0x18539D940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x539F820", Offset = "0x539E020", VA = "0x18539F820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct DFMDJKPAHKA : IAsyncStateMachine
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
		public HNEDJHPAJFA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public MFKBDIPIOIA<JHAGCFIKKAF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5DA1690", Offset = "0x5D9FE90", VA = "0x185DA1690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5DA1D70", Offset = "0x5DA0570", VA = "0x185DA1D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps NNDMPDFKOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<MFKBDIPIOIA<TMRequest>, TaskCompletionSource<DNFCNMKAMCE<object, OOJAGAFOLJL>>> CFCLPKKEGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private COJKOFCEBDB<TMRequest> IKAIDEGDLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool DKKNGBKFADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int HPGGDNCMBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task IENGFLCPLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int GDHKFHJLMCB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps KDDFEDBCMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4241A60", Offset = "0x4240260", VA = "0x184241A60")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps BAOMMCLHIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x42428A0", Offset = "0x42410A0", VA = "0x1842428A0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps OMPJGAHHOOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4240530", Offset = "0x423ED30", VA = "0x184240530")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LMOKNCJFLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x95C6E0", Offset = "0x95AEE0", VA = "0x18095C6E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x95CF20", Offset = "0x95B720", VA = "0x18095CF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HLOECPOFJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B5250", Offset = "0x8B3A50", VA = "0x1808B5250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NIGNHDLHKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8D4630", Offset = "0x8D2E30", VA = "0x1808D4630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4242A50", Offset = "0x4241250", VA = "0x184242A50")]
	public HNEDJHPAJFA(TDeps HNBDHJIILED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4240AD0", Offset = "0x423F2D0", VA = "0x184240AD0")]
	public Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> GJDNALPHPGG(TRoot KAMAKIBPPKG, TNetSys JIOCDCBKBKA, MFKBDIPIOIA<JHAGCFIKKAF> PHOEBDGADNM, TAction ILIPDNLABEN, bool MLCJJOIGOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4241490", Offset = "0x423FC90", VA = "0x184241490")]
	[AsyncStateMachine(typeof(HNEDJHPAJFA<, , , , , , , , >.CKFFPNPOOJP))]
	private Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> GJDNALPHPGG(TRoot KAMAKIBPPKG, MFKBDIPIOIA<JHAGCFIKKAF> PHOEBDGADNM, TAction ILIPDNLABEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x42418B0", Offset = "0x42400B0", VA = "0x1842418B0")]
	[AsyncStateMachine(typeof(HNEDJHPAJFA<, , , , , , , , >.KMGILALCDAM))]
	private Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> GKLNLKBFBJA(TRoot KAMAKIBPPKG, MFKBDIPIOIA<JHAGCFIKKAF> PHOEBDGADNM, TAction[] GLAHDKCHLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42407F0", Offset = "0x423EFF0", VA = "0x1842407F0")]
	[AsyncStateMachine(typeof(HNEDJHPAJFA<, , , , , , , , >.PIFFMCANNOP))]
	public Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> GBCEGNPBNCJ(TRoot KAMAKIBPPKG, TNetSys BFEHAOEHJGH, TReceiver HBCKNOINJJA, MFKBDIPIOIA<JHAGCFIKKAF> PHOEBDGADNM, MFKBDIPIOIA<TMRequest> NJAMMGLGHPA, TAction ILIPDNLABEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4241ED0", Offset = "0x42406D0", VA = "0x184241ED0")]
	[AsyncStateMachine(typeof(HNEDJHPAJFA<, , , , , , , , >.NLBBMDPHADB))]
	private Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> LJBDOAIHIMC(TRoot KAMAKIBPPKG, TNetSys BFEHAOEHJGH, TReceiver HBCKNOINJJA, MFKBDIPIOIA<JHAGCFIKKAF> PHOEBDGADNM, MFKBDIPIOIA<TMRequest> NJAMMGLGHPA, TAction ILIPDNLABEN, Task FFFDANLKGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4241A90", Offset = "0x4240290", VA = "0x184241A90")]
	[AsyncStateMachine(typeof(HNEDJHPAJFA<, , , , , , , , >.BDAFCKGJGHD))]
	private Task LBNOEADFBCM(TRoot KAMAKIBPPKG, TNetSys BFEHAOEHJGH, TReceiver HBCKNOINJJA, TAction ILIPDNLABEN, MMAJNKKNIFJ DFPOMBKBGOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4242050", Offset = "0x4240850", VA = "0x184242050")]
	private void MENIIKKCKID(TReceiver HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4242180", Offset = "0x4240980", VA = "0x184242180")]
	private void MHIGMNDEBPN(TRoot KAMAKIBPPKG, TNetSys BFEHAOEHJGH, TReceiver HBCKNOINJJA, MFKBDIPIOIA<JHAGCFIKKAF> PHOEBDGADNM, TAction ILIPDNLABEN, bool GDEEOJENKHH, bool NCEMCFHPBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x42406B0", Offset = "0x423EEB0", VA = "0x1842406B0")]
	[AsyncStateMachine(typeof(HNEDJHPAJFA<, , , , , , , , >.DFMDJKPAHKA))]
	public Task FJMFGPKJLGL(TRoot KAMAKIBPPKG, TNetSys BFEHAOEHJGH, MFKBDIPIOIA<JHAGCFIKKAF> PHOEBDGADNM, TAction[] IHAHNNBNJJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class HMGJAKFBCCP
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface OAHBIAIIOPM<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PBCJFEHMDDE(TNetSys GOKCLKGFJEB, TAction ILIPDNLABEN);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction IEBILHOIDAP(TNetSys GOKCLKGFJEB, TAction ILIPDNLABEN);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction DMHHLKGLAHH(TNetSys GOKCLKGFJEB, TAction ILIPDNLABEN);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> IKEEEDBPEOG(TNetSys GOKCLKGFJEB, TAction ILIPDNLABEN);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] GNHIFANCNDB(TNetSys GOKCLKGFJEB, TAction ILIPDNLABEN, int LEABBFJELNK);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PCDGAINPHJM(TNetSys GOKCLKGFJEB, TAction ILIPDNLABEN);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool MDEOHLLIKIA(TNetSys GOKCLKGFJEB, TAction ILIPDNLABEN);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool GCEINLGNIFG(TNetSys GOKCLKGFJEB, TAction ILIPDNLABEN);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool AKNOIHLAOCA(TNetSys GOKCLKGFJEB, TAction ILIPDNLABEN);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool EMDHPDOMPLC(TNetSys GOKCLKGFJEB, TAction ILIPDNLABEN);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool ABLEHPKPAFL(TNetSys GOKCLKGFJEB, TAction ILIPDNLABEN);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface MIHNIGKFCBI<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps KDDFEDBCMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps OMPJGAHHOOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps BAOMMCLHIJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface NNAMCGCLGJB<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MFKBDIPIOIA<JHAGCFIKKAF> OKKKGJJJJKF(TReceiver HBCKNOINJJA);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FOIELAHKNKD(TReceiver HBCKNOINJJA);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> GBCEGNPBNCJ(TReceiver HBCKNOINJJA, TAction ILIPDNLABEN);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] GJBGABBHCDL(TReceiver HBCKNOINJJA);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface GOKJDAMGMEH<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BEHONKAACLP(TRoot KAMAKIBPPKG);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int CJBNABFAEHK(TRoot KAMAKIBPPKG);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int MBHIDJOOHBP(TRoot KAMAKIBPPKG);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int BGICMPCNEOB(TRoot KAMAKIBPPKG);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BKFADCNCKLN(TRoot KAMAKIBPPKG);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HLMAOAMPHDA(TRoot KAMAKIBPPKG, MFKBDIPIOIA<JHAGCFIKKAF> PHOEBDGADNM, TAction[] GLAHDKCHLDI);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task GJDNALPHPGG(TRoot KAMAKIBPPKG, MFKBDIPIOIA<JHAGCFIKKAF> PHOEBDGADNM, MFKBDIPIOIA<TMRequest> NJAMMGLGHPA, TAction ILIPDNLABEN, bool FGFNJFBDHNL = true);
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
