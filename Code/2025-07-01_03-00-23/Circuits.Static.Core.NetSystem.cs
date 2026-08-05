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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x29A6740", Offset = "0x29A4D40", VA = "0x1829A6740")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JIKKFAGOBHI : CKEJBHKCKAO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29A6700", Offset = "0x29A4D00", VA = "0x1829A6700", Slot = "7")]
	public override string GNDOFJNNOIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29A6730", Offset = "0x29A4D30", VA = "0x1829A6730")]
	private JIKKFAGOBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29A66B0", Offset = "0x29A4CB0", VA = "0x1829A66B0")]
	public static JIKKFAGOBHI BFOPDLPDKBM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EEDDCANHEIK<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, GPINNAPIMHK.ONBMHKDGCLI<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JGFKPCKDGKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] KNGMCAPCGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int JLGKOIGOGLA;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12879E0", Offset = "0x1285FE0", VA = "0x1812879E0")]
		private JGFKPCKDGKK(TPartialAction[] NFFMFHLBNGI, int CDNAFIPKGFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x519BD90", Offset = "0x519A390", VA = "0x18519BD90")]
		public static EEDDCANHEIK<TPartialAction, TPartialActionId, TFullAction, TDeps>.JGFKPCKDGKK BFOPDLPDKBM(int EKPKMOPHHCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x519BEA0", Offset = "0x519A4A0", VA = "0x18519BEA0")]
		public ALKPLFJMODP<TFullAction> JDHJEIACFOB(TPartialAction FLHGFGMLAAB, TDeps GMIGKAKBDIM)
		{
			return default(ALKPLFJMODP<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, JGFKPCKDGKK>? KMMEHILPNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps ODPIHOLNHGM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, JGFKPCKDGKK> PBAIAJMHDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x475E150", Offset = "0x475C750", VA = "0x18475E150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x475F180", Offset = "0x475D780", VA = "0x18475F180")]
	private EEDDCANHEIK(Dictionary<TPartialActionId, JGFKPCKDGKK>? AOBNJAAGFPJ, TDeps GMIGKAKBDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x475E230", Offset = "0x475C830", VA = "0x18475E230")]
	public static EEDDCANHEIK<TPartialAction, TPartialActionId, TFullAction, TDeps> BFOPDLPDKBM(TDeps GMIGKAKBDIM)
	{
		return default(EEDDCANHEIK<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x475E2E0", Offset = "0x475C8E0", VA = "0x18475E2E0")]
	public FANMKCKHALG<ALKPLFJMODP<TFullAction>, GNLHMHNEEGO> JDHJEIACFOB(TPartialAction FLHGFGMLAAB)
	{
		return default(FANMKCKHALG<ALKPLFJMODP<TFullAction>, GNLHMHNEEGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x475F0D0", Offset = "0x475D6D0", VA = "0x18475F0D0")]
	public void MFMMFDHNIGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GPINNAPIMHK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface ONBMHKDGCLI<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OEDCPLBJGDN([In] TPartialAction FLHGFGMLAAB);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int LCBFFMLGCNG([In] TPartialAction FLHGFGMLAAB);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId NPDOOCNMMFK([In] TPartialAction FLHGFGMLAAB);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction KJCFAIHPNFD(TPartialAction[] FDNBJHODOIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct JFHGPPGHJGI<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : AHHICPNHAPC.HLHHMMENKCO<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] KNNEPLGGOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int FLAAEFPHJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps ODPIHOLNHGM;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x519ABB0", Offset = "0x51991B0", VA = "0x18519ABB0")]
	internal JFHGPPGHJGI(TPartialSnapshot[] COHNKLNCELF, int ECLOJPIMOBO, TDeps GMIGKAKBDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x519AB50", Offset = "0x5199150", VA = "0x18519AB50")]
	public static JFHGPPGHJGI<TPartialSnapshot, TFullSnapshot, TDeps> BFOPDLPDKBM(TDeps GMIGKAKBDIM)
	{
		return default(JFHGPPGHJGI<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AHHICPNHAPC
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface HLHHMMENKCO<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KAIFBDHCJDB([In] TPartialSnapshot OBEOLGLJMGD);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot MOPDCNEKFIB(TPartialSnapshot[] ADDELFMGKOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x30B4240", Offset = "0x30B2840", VA = "0x1830B4240")]
	public static ALKPLFJMODP<TFullSnapshot> JDHJEIACFOB<TFullSnapshot, TPartialSnapshot, TDeps>(this JFHGPPGHJGI<TPartialSnapshot, TFullSnapshot, TDeps> PIKMBNLEPPK, TPartialSnapshot OBEOLGLJMGD) where TDeps : HLHHMMENKCO<TPartialSnapshot, TFullSnapshot>
	{
		return default(ALKPLFJMODP<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x30B40F0", Offset = "0x30B26F0", VA = "0x1830B40F0")]
	public static bool FFGDKDBOAFJ<TPartialSnapshot, TFullSnapshot, TDeps>(this JFHGPPGHJGI<TPartialSnapshot, TFullSnapshot, TDeps> PIKMBNLEPPK, TPartialSnapshot OBEOLGLJMGD) where TDeps : HLHHMMENKCO<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class PCJGONDPAHE : CKEJBHKCKAO
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x29A67C0", Offset = "0x29A4DC0", VA = "0x1829A67C0", Slot = "7")]
	public override string GNDOFJNNOIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x29A6730", Offset = "0x29A4D30", VA = "0x1829A6730")]
	public PCJGONDPAHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class COPKANDOGDI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : PCGFNEGKEFB.JAJODCHBJBN<TAction, TNetSys> where TReceiverDeps : PCGFNEGKEFB.KMMAFKCJLGL<TAction, TReceiver> where TRootDeps : PCGFNEGKEFB.ACGBOGBHMEL<TMRequest, TAction, TRoot> where TDeps : PCGFNEGKEFB.HOAKNGLMODD<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface LAEDEKAMFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LEPHLCNLLNK([In] FANMKCKHALG<object, GNLHMHNEEGO> HPCDHGHHCOO);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IGIPFIELCJA();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FANMKCKHALG<object, GNLHMHNEEGO> DCAAAGJCJFK();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DMGKFBGMLEM(Exception CGONOPBDIAB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class CIHHJJFCMNE : LAEDEKAMFDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<FANMKCKHALG<object, GNLHMHNEEGO>> CHHENIKIMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<FANMKCKHALG<object, KNIOCFDMLBC>> CEJHDEOBKGK;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67A8A40", Offset = "0x67A7040", VA = "0x1867A8A40")]
		private CIHHJJFCMNE(TaskCompletionSource<FANMKCKHALG<object, GNLHMHNEEGO>> JGEAKLOFCKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x52D9CA0", Offset = "0x52D82A0", VA = "0x1852D9CA0")]
		public static CIHHJJFCMNE BFOPDLPDKBM(TaskCompletionSource<FANMKCKHALG<object, GNLHMHNEEGO>> JGEAKLOFCKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67A8940", Offset = "0x67A6F40", VA = "0x1867A8940")]
		public void LEPHLCNLLNK([In] FANMKCKHALG<object, GNLHMHNEEGO> HPCDHGHHCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67A8580", Offset = "0x67A6B80", VA = "0x1867A8580", Slot = "5")]
		public void IGIPFIELCJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x67A82D0", Offset = "0x67A68D0", VA = "0x1867A82D0", Slot = "6")]
		public FANMKCKHALG<object, GNLHMHNEEGO> DCAAAGJCJFK()
		{
			return default(FANMKCKHALG<object, GNLHMHNEEGO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67A8380", Offset = "0x67A6980", VA = "0x1867A8380", Slot = "7")]
		public void DMGKFBGMLEM(Exception CGONOPBDIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF380", Offset = "0x4DED980", VA = "0x184DEF380", Slot = "4")]
		private void BIEEIENGIMO([In] FANMKCKHALG<object, GNLHMHNEEGO> HPCDHGHHCOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class BCPEKPFALLF : LAEDEKAMFDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<FANMKCKHALG<object, GNLHMHNEEGO>> CHHENIKIMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private FANMKCKHALG<object, GNLHMHNEEGO> FGJBFKEFKJO;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
		private BCPEKPFALLF(TaskCompletionSource<FANMKCKHALG<object, GNLHMHNEEGO>> JGEAKLOFCKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x52D9CA0", Offset = "0x52D82A0", VA = "0x1852D9CA0")]
		public static BCPEKPFALLF BFOPDLPDKBM(TaskCompletionSource<FANMKCKHALG<object, GNLHMHNEEGO>> JGEAKLOFCKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xE792C0", Offset = "0xE778C0", VA = "0x180E792C0")]
		public void LEPHLCNLLNK([In] FANMKCKHALG<object, GNLHMHNEEGO> HPCDHGHHCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x61408E0", Offset = "0x613EEE0", VA = "0x1861408E0", Slot = "5")]
		public void IGIPFIELCJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70", Slot = "6")]
		public FANMKCKHALG<object, GNLHMHNEEGO> DCAAAGJCJFK()
		{
			return default(FANMKCKHALG<object, GNLHMHNEEGO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6140760", Offset = "0x613ED60", VA = "0x186140760", Slot = "7")]
		public void DMGKFBGMLEM(Exception CGONOPBDIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF380", Offset = "0x4DED980", VA = "0x184DEF380", Slot = "4")]
		private void BIEEIENGIMO([In] FANMKCKHALG<object, GNLHMHNEEGO> HPCDHGHHCOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class HENGBJGDKMA : LAEDEKAMFDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<FANMKCKHALG<object, GNLHMHNEEGO>> CEJHDEOBKGK;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF940", Offset = "0x4DEDF40", VA = "0x184DEF940")]
		private HENGBJGDKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF2C0", Offset = "0x4DED8C0", VA = "0x184DEF2C0")]
		public static HENGBJGDKMA BFOPDLPDKBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF5B0", Offset = "0x4DEDBB0", VA = "0x184DEF5B0")]
		public void LEPHLCNLLNK([In] FANMKCKHALG<object, GNLHMHNEEGO> HPCDHGHHCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		public void IGIPFIELCJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF460", Offset = "0x4DEDA60", VA = "0x184DEF460", Slot = "6")]
		public FANMKCKHALG<object, GNLHMHNEEGO> DCAAAGJCJFK()
		{
			return default(FANMKCKHALG<object, GNLHMHNEEGO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF4C0", Offset = "0x4DEDAC0", VA = "0x184DEF4C0", Slot = "7")]
		[CMBJJNOBAFP("This may be terminal and should probably do more than discarding the exception.")]
		public void DMGKFBGMLEM(Exception CGONOPBDIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF380", Offset = "0x4DED980", VA = "0x184DEF380", Slot = "4")]
		private void BIEEIENGIMO([In] FANMKCKHALG<object, GNLHMHNEEGO> HPCDHGHHCOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class MNBDDHPFDJE : LAEDEKAMFDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private FANMKCKHALG<object, GNLHMHNEEGO> FGJBFKEFKJO;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		private MNBDDHPFDJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF2C0", Offset = "0x4DED8C0", VA = "0x184DEF2C0")]
		public static MNBDDHPFDJE BFOPDLPDKBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x25379B0", Offset = "0x2535FB0", VA = "0x1825379B0")]
		public void LEPHLCNLLNK([In] FANMKCKHALG<object, GNLHMHNEEGO> HPCDHGHHCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		public void IGIPFIELCJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680", Slot = "6")]
		public FANMKCKHALG<object, GNLHMHNEEGO> DCAAAGJCJFK()
		{
			return default(FANMKCKHALG<object, GNLHMHNEEGO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5615050", Offset = "0x5613650", VA = "0x185615050", Slot = "7")]
		[CMBJJNOBAFP("This may be terminal and should probably do more than discarding the exception.")]
		public void DMGKFBGMLEM(Exception CGONOPBDIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF380", Offset = "0x4DED980", VA = "0x184DEF380", Slot = "4")]
		private void BIEEIENGIMO([In] FANMKCKHALG<object, GNLHMHNEEGO> HPCDHGHHCOO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct FANILJIKHJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<object, GNLHMHNEEGO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public COPKANDOGDI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public LLDGDOINCKI<JLBFOIDJJFC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<FANMKCKHALG<object, GNLHMHNEEGO>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<FANMKCKHALG<object, GNLHMHNEEGO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4BE6550", Offset = "0x4BE4B50", VA = "0x184BE6550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4BE6B00", Offset = "0x4BE5100", VA = "0x184BE6B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct LFLJBBNPPGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<object, GNLHMHNEEGO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public COPKANDOGDI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public LLDGDOINCKI<JLBFOIDJJFC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<FANMKCKHALG<object, GNLHMHNEEGO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5383B80", Offset = "0x5382180", VA = "0x185383B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x53848B0", Offset = "0x5382EB0", VA = "0x1853848B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MBKOANOOICK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<object, GNLHMHNEEGO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public COPKANDOGDI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public LLDGDOINCKI<JLBFOIDJJFC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public LLDGDOINCKI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<FANMKCKHALG<object, GNLHMHNEEGO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x55FDF10", Offset = "0x55FC510", VA = "0x1855FDF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x55FE2E0", Offset = "0x55FC8E0", VA = "0x1855FE2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct CBBHHHHLHLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<object, GNLHMHNEEGO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public COPKANDOGDI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public LLDGDOINCKI<JLBFOIDJJFC> senderId;

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
		public LLDGDOINCKI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private LAEDEKAMFDH <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x65E2E50", Offset = "0x65E1450", VA = "0x1865E2E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x65E45E0", Offset = "0x65E2BE0", VA = "0x1865E45E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct KIEPFJKPEOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public COPKANDOGDI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public LAEDEKAMFDH completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private LAEDEKAMFDH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<FANMKCKHALG<object?, GNLHMHNEEGO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x52D1DD0", Offset = "0x52D03D0", VA = "0x1852D1DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x52D3BD0", Offset = "0x52D21D0", VA = "0x1852D3BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct BLACPJNCNDJ : IAsyncStateMachine
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
		public COPKANDOGDI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public LLDGDOINCKI<JLBFOIDJJFC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x620D5A0", Offset = "0x620BBA0", VA = "0x18620D5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x620D9D0", Offset = "0x620BFD0", VA = "0x18620D9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps ODPIHOLNHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<LLDGDOINCKI<TMRequest>, TaskCompletionSource<FANMKCKHALG<object, GNLHMHNEEGO>>> BAGCJIFMAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private PHBLGJGAIAI<TMRequest> AGJDLLLKDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool BMBFFHHGJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int GJHAIPPKBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task HCLJOEMILNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int OAAPCDCJPII;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps MMOACJCCOML
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68860C0", Offset = "0x68846C0", VA = "0x1868860C0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps DHIPNACGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6885B60", Offset = "0x6884160", VA = "0x186885B60")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps AGNFBPNLAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6885A90", Offset = "0x6884090", VA = "0x186885A90")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BAPFPGDPPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xDF4B30", Offset = "0xDF3130", VA = "0x180DF4B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xDF55F0", Offset = "0xDF3BF0", VA = "0x180DF55F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PANDFPIKLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int KOJLIGICKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA635A0", Offset = "0xA61BA0", VA = "0x180A635A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6887A10", Offset = "0x6886010", VA = "0x186887A10")]
	public COPKANDOGDI(TDeps GMIGKAKBDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6884B40", Offset = "0x6883140", VA = "0x186884B40")]
	public Task<FANMKCKHALG<object, GNLHMHNEEGO>> ANGIGKOKHEN(TRoot CMAFOEIBEKN, TNetSys COCNFLOJIJC, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, TAction CJDOILFHDJI, bool PAIBICJIBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6884330", Offset = "0x6882930", VA = "0x186884330")]
	[AsyncStateMachine(typeof(COPKANDOGDI<, , , , , , , , >.FANILJIKHJG))]
	private Task<FANMKCKHALG<object, GNLHMHNEEGO>> ANGIGKOKHEN(TRoot CMAFOEIBEKN, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, TAction CJDOILFHDJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6885CA0", Offset = "0x68842A0", VA = "0x186885CA0")]
	[AsyncStateMachine(typeof(COPKANDOGDI<, , , , , , , , >.LFLJBBNPPGM))]
	private Task<FANMKCKHALG<object, GNLHMHNEEGO>> HLCGDMDMFBP(TRoot CMAFOEIBEKN, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, TAction[] NFILGHOODJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68875B0", Offset = "0x6885BB0", VA = "0x1868875B0")]
	[AsyncStateMachine(typeof(COPKANDOGDI<, , , , , , , , >.MBKOANOOICK))]
	public Task<FANMKCKHALG<object, GNLHMHNEEGO>> PLDMMMLFINN(TRoot CMAFOEIBEKN, TNetSys KMILKALDJJF, TReceiver GOFEAPECJPJ, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, LLDGDOINCKI<TMRequest> FILKDPOEDAI, TAction CJDOILFHDJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6884FB0", Offset = "0x68835B0", VA = "0x186884FB0")]
	[AsyncStateMachine(typeof(COPKANDOGDI<, , , , , , , , >.CBBHHHHLHLI))]
	private Task<FANMKCKHALG<object, GNLHMHNEEGO>> CDDPDFBEEKA(TRoot CMAFOEIBEKN, TNetSys KMILKALDJJF, TReceiver GOFEAPECJPJ, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, LLDGDOINCKI<TMRequest> FILKDPOEDAI, TAction CJDOILFHDJI, Task JIHHAICOCCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x68852C0", Offset = "0x68838C0", VA = "0x1868852C0")]
	[AsyncStateMachine(typeof(COPKANDOGDI<, , , , , , , , >.KIEPFJKPEOA))]
	private Task DEHCLPKJKLJ(TRoot CMAFOEIBEKN, TNetSys KMILKALDJJF, TReceiver GOFEAPECJPJ, TAction CJDOILFHDJI, LAEDEKAMFDH KHOLMNMONBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6885B90", Offset = "0x6884190", VA = "0x186885B90")]
	private void FPGEGDINNPL(TReceiver GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68871E0", Offset = "0x68857E0", VA = "0x1868871E0")]
	private void OLKDHMLFOPF(TRoot CMAFOEIBEKN, TNetSys KMILKALDJJF, TReceiver GOFEAPECJPJ, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, TAction CJDOILFHDJI, bool HGBFPNBMLAN, bool AHKMGHEBLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6885810", Offset = "0x6883E10", VA = "0x186885810")]
	[AsyncStateMachine(typeof(COPKANDOGDI<, , , , , , , , >.BLACPJNCNDJ))]
	public Task FABMOGGBGOL(TRoot CMAFOEIBEKN, TNetSys KMILKALDJJF, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, TAction[] EGIOGLKFKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6886460", Offset = "0x6884A60", VA = "0x186886460")]
	private (TAction, int) MBHFPMAMLJI(TRoot CMAFOEIBEKN, TNetSys JJIIBIBOMKK, TAction CJDOILFHDJI)
	{
		return default((TAction, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class PCGFNEGKEFB
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface JAJODCHBJBN<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PPOBMMALINH(TNetSys MMBEHPFPKIL, TAction CJDOILFHDJI);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction EPAKJLGBCEM(TNetSys MMBEHPFPKIL, TAction CJDOILFHDJI);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction KPFAKJANJGB(TNetSys MMBEHPFPKIL, TAction CJDOILFHDJI);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> ACAMLOPPCIP(TNetSys MMBEHPFPKIL, TAction CJDOILFHDJI);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] JDHBAMCDILK(TNetSys MMBEHPFPKIL, TAction CJDOILFHDJI, int AIBCGPECKOL);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HEPJCIAJDKO(TNetSys MMBEHPFPKIL, TAction CJDOILFHDJI);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool PBCMHEMFKKI(TNetSys MMBEHPFPKIL, TAction CJDOILFHDJI);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool HKDFNCKEILD(TNetSys MMBEHPFPKIL, TAction CJDOILFHDJI);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool KBHMJLMHAFH(TNetSys MMBEHPFPKIL, TAction CJDOILFHDJI);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HIGKKMGHAAE(TNetSys MMBEHPFPKIL, TAction CJDOILFHDJI);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool LPPCKOJNOAE(TNetSys MMBEHPFPKIL, TAction CJDOILFHDJI);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface HOAKNGLMODD<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps MMOACJCCOML
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps AGNFBPNLAMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps DHIPNACGKHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface KMMAFKCJLGL<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LLDGDOINCKI<JLBFOIDJJFC> DPBIGJOIFNM(TReceiver GOFEAPECJPJ);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JLANKGHFPMP(TReceiver GOFEAPECJPJ);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<FANMKCKHALG<object, GNLHMHNEEGO>> PLDMMMLFINN(TReceiver GOFEAPECJPJ, TAction CJDOILFHDJI);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] NFPINAEAFEI(TReceiver GOFEAPECJPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface ACGBOGBHMEL<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JDBJEJOBBOE(TRoot CMAFOEIBEKN);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int PEFBOHLPKGN(TRoot CMAFOEIBEKN);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int FNAGFHDKGNA(TRoot CMAFOEIBEKN);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int CKICCCPBKPH(TRoot CMAFOEIBEKN);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PGDOJCLFIJL(TRoot CMAFOEIBEKN);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PBCOHGNAHIC(TRoot CMAFOEIBEKN, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, TAction[] NFILGHOODJC);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JOMHAIEEOKI(TRoot CMAFOEIBEKN, int MMPEMHFFMIF);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task ANGIGKOKHEN(TRoot CMAFOEIBEKN, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, LLDGDOINCKI<TMRequest> FILKDPOEDAI, TAction CJDOILFHDJI, bool DJOBCBGDMLA = true);
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
