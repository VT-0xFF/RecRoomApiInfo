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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x25AB930", Offset = "0x25A9F30", VA = "0x1825AB930")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BCHKNBKLNOE : MPAEBDCEOBD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25AB870", Offset = "0x25A9E70", VA = "0x1825AB870", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25AB8F0", Offset = "0x25A9EF0", VA = "0x1825AB8F0")]
	private BCHKNBKLNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x25AB8A0", Offset = "0x25A9EA0", VA = "0x1825AB8A0")]
	public static BCHKNBKLNOE FEOBEKOIKMG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CDNENBDPFJG<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, KAIEJPDBAIC.ALBGEODONGO<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DHDPOFJDIJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] BPFJABJLHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int IBLIOHDHAFA;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xFA4FB0", Offset = "0xFA35B0", VA = "0x180FA4FB0")]
		private DHDPOFJDIJN(TPartialAction[] EMEIPFCFCEO, int MKJNDADEFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6310010", Offset = "0x630E610", VA = "0x186310010")]
		public static CDNENBDPFJG<TPartialAction, TPartialActionId, TFullAction, TDeps>.DHDPOFJDIJN FEOBEKOIKMG(int CIPKBFKIILH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6310350", Offset = "0x630E950", VA = "0x186310350")]
		public HEGNJKKKIBE<TFullAction> KLJMBBEBDIE(TPartialAction NAIPMAAFDBH, TDeps GKFDJGEMKAB)
		{
			return default(HEGNJKKKIBE<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, DHDPOFJDIJN>? JCKMPLFMONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps JDFKOKOAHAA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, DHDPOFJDIJN> OHOKEPPCGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5A72E00", Offset = "0x5A71400", VA = "0x185A72E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5A72EF0", Offset = "0x5A714F0", VA = "0x185A72EF0")]
	private CDNENBDPFJG(Dictionary<TPartialActionId, DHDPOFJDIJN>? MOFAFDFLKIO, TDeps GKFDJGEMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5A71DD0", Offset = "0x5A703D0", VA = "0x185A71DD0")]
	public static CDNENBDPFJG<TPartialAction, TPartialActionId, TFullAction, TDeps> FEOBEKOIKMG(TDeps GKFDJGEMKAB)
	{
		return default(CDNENBDPFJG<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5A71F40", Offset = "0x5A70540", VA = "0x185A71F40")]
	public JOFBNNGKBOO<HEGNJKKKIBE<TFullAction>, PPAGHPBHFJD> KLJMBBEBDIE(TPartialAction NAIPMAAFDBH)
	{
		return default(JOFBNNGKBOO<HEGNJKKKIBE<TFullAction>, PPAGHPBHFJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5A71E80", Offset = "0x5A70480", VA = "0x185A71E80")]
	public void FFLKBFJHDLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KAIEJPDBAIC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface ALBGEODONGO<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HIHAJIPHNGC([In] TPartialAction NAIPMAAFDBH);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int DECIHGFHIIC([In] TPartialAction NAIPMAAFDBH);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId MKELKMAHBOA([In] TPartialAction NAIPMAAFDBH);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction LKMMOIMJJEN(TPartialAction[] PLAABCPFEAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DNKMKDFCIDD<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : HKNLEIECMDG.DDMEHABLAMH<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] KNBPNMGKMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int BKIHHAKPLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps JDFKOKOAHAA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x632A180", Offset = "0x6328780", VA = "0x18632A180")]
	internal DNKMKDFCIDD(TPartialSnapshot[] NJFLAOJGOKK, int CEHCGEKDEOK, TDeps GKFDJGEMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x632A120", Offset = "0x6328720", VA = "0x18632A120")]
	public static DNKMKDFCIDD<TPartialSnapshot, TFullSnapshot, TDeps> FEOBEKOIKMG(TDeps GKFDJGEMKAB)
	{
		return default(DNKMKDFCIDD<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HKNLEIECMDG
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface DDMEHABLAMH<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FOBJDOIEMAF([In] TPartialSnapshot BHPCFAFLNGA);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot DEHEADAEJJA(TPartialSnapshot[] EFLGBPFHINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x33EDCB0", Offset = "0x33EC2B0", VA = "0x1833EDCB0")]
	public static HEGNJKKKIBE<TFullSnapshot> KLJMBBEBDIE<TFullSnapshot, TPartialSnapshot, TDeps>(this DNKMKDFCIDD<TPartialSnapshot, TFullSnapshot, TDeps> JDCFMPOHCEA, TPartialSnapshot BHPCFAFLNGA) where TDeps : DDMEHABLAMH<TPartialSnapshot, TFullSnapshot>
	{
		return default(HEGNJKKKIBE<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x33EE270", Offset = "0x33EC870", VA = "0x1833EE270")]
	public static bool MGFFHOKCOCM<TPartialSnapshot, TFullSnapshot, TDeps>(this DNKMKDFCIDD<TPartialSnapshot, TFullSnapshot, TDeps> JDCFMPOHCEA, TPartialSnapshot BHPCFAFLNGA) where TDeps : DDMEHABLAMH<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class NIIEIFLMPJM : MPAEBDCEOBD
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x25AB900", Offset = "0x25A9F00", VA = "0x1825AB900", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x25AB8F0", Offset = "0x25A9EF0", VA = "0x1825AB8F0")]
	public NIIEIFLMPJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class GPOBPEEKBLL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : JJINKDABDAO.NEGMACIPDDF<TAction, TNetSys> where TReceiverDeps : JJINKDABDAO.DDEAJPHIICG<TAction, TReceiver> where TRootDeps : JJINKDABDAO.KEDMIDMAPJC<TMRequest, TAction, TRoot> where TDeps : JJINKDABDAO.OAGGHMKCBEA<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface BNDAPDGBNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PEILLHOJLJI([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JKLPPJMCBLP();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		JOFBNNGKBOO<object, PPAGHPBHFJD> PNMJHGDMEFC();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HLGNGLOINLJ(Exception DADIPHEHDBH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class JHJDCIELPKN : BNDAPDGBNOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<JOFBNNGKBOO<object, PPAGHPBHFJD>> LBIDFOAGEKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<JOFBNNGKBOO<object, EAPODONBJNH>> CEPJEFJLNOF;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x49CCC40", Offset = "0x49CB240", VA = "0x1849CCC40")]
		private JHJDCIELPKN(TaskCompletionSource<JOFBNNGKBOO<object, PPAGHPBHFJD>> KDHLGIELGNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4797DA0", Offset = "0x47963A0", VA = "0x184797DA0")]
		public static JHJDCIELPKN FEOBEKOIKMG(TaskCompletionSource<JOFBNNGKBOO<object, PPAGHPBHFJD>> KDHLGIELGNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x49CC800", Offset = "0x49CAE00", VA = "0x1849CC800")]
		public void PEILLHOJLJI([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x49CC640", Offset = "0x49CAC40", VA = "0x1849CC640", Slot = "5")]
		public void JKLPPJMCBLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x49CCA40", Offset = "0x49CB040", VA = "0x1849CCA40", Slot = "6")]
		public JOFBNNGKBOO<object, PPAGHPBHFJD> PNMJHGDMEFC()
		{
			return default(JOFBNNGKBOO<object, PPAGHPBHFJD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x49CC5E0", Offset = "0x49CABE0", VA = "0x1849CC5E0", Slot = "7")]
		public void HLGNGLOINLJ(Exception DADIPHEHDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4050EF0", Offset = "0x404F4F0", VA = "0x184050EF0", Slot = "4")]
		private void NABCPLLGKAJ([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class ANLJLKIHNML : BNDAPDGBNOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<JOFBNNGKBOO<object, PPAGHPBHFJD>> LBIDFOAGEKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private JOFBNNGKBOO<object, PPAGHPBHFJD> BMDKLCLGEBF;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
		private ANLJLKIHNML(TaskCompletionSource<JOFBNNGKBOO<object, PPAGHPBHFJD>> KDHLGIELGNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4797DA0", Offset = "0x47963A0", VA = "0x184797DA0")]
		public static ANLJLKIHNML FEOBEKOIKMG(TaskCompletionSource<JOFBNNGKBOO<object, PPAGHPBHFJD>> KDHLGIELGNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x49939A0", Offset = "0x4991FA0", VA = "0x1849939A0")]
		public void PEILLHOJLJI([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x49938E0", Offset = "0x4991EE0", VA = "0x1849938E0", Slot = "5")]
		public void JKLPPJMCBLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAA1810", Offset = "0xA9FE10", VA = "0x180AA1810", Slot = "6")]
		public JOFBNNGKBOO<object, PPAGHPBHFJD> PNMJHGDMEFC()
		{
			return default(JOFBNNGKBOO<object, PPAGHPBHFJD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4993880", Offset = "0x4991E80", VA = "0x184993880", Slot = "7")]
		public void HLGNGLOINLJ(Exception DADIPHEHDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4050EF0", Offset = "0x404F4F0", VA = "0x184050EF0", Slot = "4")]
		private void NABCPLLGKAJ([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class HFNLHJOANGA : BNDAPDGBNOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<JOFBNNGKBOO<object, PPAGHPBHFJD>> CEPJEFJLNOF;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4634D50", Offset = "0x4633350", VA = "0x184634D50")]
		private HFNLHJOANGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x46348E0", Offset = "0x4632EE0", VA = "0x1846348E0")]
		public static HFNLHJOANGA FEOBEKOIKMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4634A40", Offset = "0x4633040", VA = "0x184634A40")]
		public void PEILLHOJLJI([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public void JKLPPJMCBLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4634C00", Offset = "0x4633200", VA = "0x184634C00", Slot = "6")]
		public JOFBNNGKBOO<object, PPAGHPBHFJD> PNMJHGDMEFC()
		{
			return default(JOFBNNGKBOO<object, PPAGHPBHFJD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x46349F0", Offset = "0x4632FF0", VA = "0x1846349F0", Slot = "7")]
		[CGDEHPHFPEN("This may be terminal and should probably do more than discarding the exception.")]
		public void HLGNGLOINLJ(Exception DADIPHEHDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4050EF0", Offset = "0x404F4F0", VA = "0x184050EF0", Slot = "4")]
		private void NABCPLLGKAJ([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class KGMDMBMCJMN : BNDAPDGBNOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private JOFBNNGKBOO<object, PPAGHPBHFJD> BMDKLCLGEBF;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		private KGMDMBMCJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x46348E0", Offset = "0x4632EE0", VA = "0x1846348E0")]
		public static KGMDMBMCJMN FEOBEKOIKMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x20BB9F0", Offset = "0x20B9FF0", VA = "0x1820BB9F0")]
		public void PEILLHOJLJI([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public void JKLPPJMCBLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAD38D0", Offset = "0xAD1ED0", VA = "0x180AD38D0", Slot = "6")]
		public JOFBNNGKBOO<object, PPAGHPBHFJD> PNMJHGDMEFC()
		{
			return default(JOFBNNGKBOO<object, PPAGHPBHFJD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4AACBE0", Offset = "0x4AAB1E0", VA = "0x184AACBE0", Slot = "7")]
		[CGDEHPHFPEN("This may be terminal and should probably do more than discarding the exception.")]
		public void HLGNGLOINLJ(Exception DADIPHEHDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4050EF0", Offset = "0x404F4F0", VA = "0x184050EF0", Slot = "4")]
		private void NABCPLLGKAJ([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct JFPFDNMJPJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public GPOBPEEKBLL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AAFGLNNJOHN<LEJAOJOLFIL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<JOFBNNGKBOO<object, PPAGHPBHFJD>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x49C9BD0", Offset = "0x49C81D0", VA = "0x1849C9BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x49CA0B0", Offset = "0x49C86B0", VA = "0x1849CA0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct MKCLEKLHBID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GPOBPEEKBLL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AAFGLNNJOHN<LEJAOJOLFIL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4E09550", Offset = "0x4E07B50", VA = "0x184E09550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4E09E80", Offset = "0x4E08480", VA = "0x184E09E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct OJEKOAKFLNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public GPOBPEEKBLL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public AAFGLNNJOHN<LEJAOJOLFIL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AAFGLNNJOHN<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x500E5C0", Offset = "0x500CBC0", VA = "0x18500E5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x500EC90", Offset = "0x500D290", VA = "0x18500EC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct KKEKAHDBJJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public GPOBPEEKBLL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AAFGLNNJOHN<LEJAOJOLFIL> senderId;

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
		public AAFGLNNJOHN<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private BNDAPDGBNOF <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4ABB860", Offset = "0x4AB9E60", VA = "0x184ABB860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4ABD1D0", Offset = "0x4ABB7D0", VA = "0x184ABD1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct AMCPOOCMIDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GPOBPEEKBLL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public BNDAPDGBNOF completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private BNDAPDGBNOF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<JOFBNNGKBOO<object?, PPAGHPBHFJD>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x48C9650", Offset = "0x48C7C50", VA = "0x1848C9650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x48CD620", Offset = "0x48CBC20", VA = "0x1848CD620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct JCFBHBONIBC : IAsyncStateMachine
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
		public GPOBPEEKBLL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AAFGLNNJOHN<LEJAOJOLFIL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x49C3280", Offset = "0x49C1880", VA = "0x1849C3280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x49C3600", Offset = "0x49C1C00", VA = "0x1849C3600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps JDFKOKOAHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<AAFGLNNJOHN<TMRequest>, TaskCompletionSource<JOFBNNGKBOO<object, PPAGHPBHFJD>>> FCJCBEKLOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private KNFOHJAKEJF<TMRequest> IBOOLAFBFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool NBEHJEBBPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int BNONMHKOECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task PGGNIHBNAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int PCHPNFBJMMK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps BKNPLBCCAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x45C1E90", Offset = "0x45C0490", VA = "0x1845C1E90")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps HLFNEBDLNHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x45C1E10", Offset = "0x45C0410", VA = "0x1845C1E10")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps CCJFAPPGINK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x45C1D90", Offset = "0x45C0390", VA = "0x1845C1D90")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BBGDNKBKFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBAEEB0", Offset = "0xBAD4B0", VA = "0x180BAEEB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBAE520", Offset = "0xBACB20", VA = "0x180BAE520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BLOMHDMIEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x954460", Offset = "0x952A60", VA = "0x180954460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FGJEDCCIGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x96F660", Offset = "0x96DC60", VA = "0x18096F660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x45C2760", Offset = "0x45C0D60", VA = "0x1845C2760")]
	public GPOBPEEKBLL(TDeps GKFDJGEMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x45C0350", Offset = "0x45BE950", VA = "0x1845C0350")]
	public Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> CEGGKGIFGOM(TRoot JGHOOBNHEJB, TNetSys DLOFAJFNCML, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, TAction PJDAFKMDDCG, bool LELKEOHAIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x45C0D20", Offset = "0x45BF320", VA = "0x1845C0D20")]
	[AsyncStateMachine(typeof(GPOBPEEKBLL<, , , , , , , , >.JFPFDNMJPJD))]
	private Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> CEGGKGIFGOM(TRoot JGHOOBNHEJB, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, TAction PJDAFKMDDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x45C16C0", Offset = "0x45BFCC0", VA = "0x1845C16C0")]
	[AsyncStateMachine(typeof(GPOBPEEKBLL<, , , , , , , , >.MKCLEKLHBID))]
	private Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> CNGLEOACDPO(TRoot JGHOOBNHEJB, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, TAction[] NOFICAHDIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x45C2480", Offset = "0x45C0A80", VA = "0x1845C2480")]
	[AsyncStateMachine(typeof(GPOBPEEKBLL<, , , , , , , , >.OJEKOAKFLNP))]
	public Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> NHFLDOKKJDG(TRoot JGHOOBNHEJB, TNetSys KCOPBHJNONI, TReceiver ODAGIILJBBF, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, AAFGLNNJOHN<TMRequest> IENEKJIPKDG, TAction PJDAFKMDDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x45C1EC0", Offset = "0x45C04C0", VA = "0x1845C1EC0")]
	[AsyncStateMachine(typeof(GPOBPEEKBLL<, , , , , , , , >.KKEKAHDBJJH))]
	private Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> IBIIHNIKGJN(TRoot JGHOOBNHEJB, TNetSys KCOPBHJNONI, TReceiver ODAGIILJBBF, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, AAFGLNNJOHN<TMRequest> IENEKJIPKDG, TAction PJDAFKMDDCG, Task BGKJOJOPDGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x45C2330", Offset = "0x45C0930", VA = "0x1845C2330")]
	[AsyncStateMachine(typeof(GPOBPEEKBLL<, , , , , , , , >.AMCPOOCMIDF))]
	private Task LCAJIJJBEGG(TRoot JGHOOBNHEJB, TNetSys KCOPBHJNONI, TReceiver ODAGIILJBBF, TAction PJDAFKMDDCG, BNDAPDGBNOF EGHDHCFFIND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x45C1CC0", Offset = "0x45C02C0", VA = "0x1845C1CC0")]
	private void FHCMEIGJMMB(TReceiver ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x45C1400", Offset = "0x45BFA00", VA = "0x1845C1400")]
	private void CMOMDHGFGBL(TRoot JGHOOBNHEJB, TNetSys KCOPBHJNONI, TReceiver ODAGIILJBBF, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, TAction PJDAFKMDDCG, bool KIIBKLNLLLB, bool DCIHEKCCPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x45C1AD0", Offset = "0x45C00D0", VA = "0x1845C1AD0")]
	[AsyncStateMachine(typeof(GPOBPEEKBLL<, , , , , , , , >.JCFBHBONIBC))]
	public Task EHABOFFPMAH(TRoot JGHOOBNHEJB, TNetSys KCOPBHJNONI, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, TAction[] INIEGOHBBPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class JJINKDABDAO
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface NEGMACIPDDF<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IFJCMLBDBDB(TNetSys ONLGAKFGMFI, TAction PJDAFKMDDCG);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction GGMOOALNMDD(TNetSys ONLGAKFGMFI, TAction PJDAFKMDDCG);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction OEPKLKMDNMF(TNetSys ONLGAKFGMFI, TAction PJDAFKMDDCG);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> JDGLOHBFGDE(TNetSys ONLGAKFGMFI, TAction PJDAFKMDDCG);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] EIOAOEDBCHK(TNetSys ONLGAKFGMFI, TAction PJDAFKMDDCG, int LPGGENAOHPF);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool CCKEILMOEBH(TNetSys ONLGAKFGMFI, TAction PJDAFKMDDCG);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool GACEAADLHNB(TNetSys ONLGAKFGMFI, TAction PJDAFKMDDCG);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IKIJAKPDOAM(TNetSys ONLGAKFGMFI, TAction PJDAFKMDDCG);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool ADCEMGCPJOG(TNetSys ONLGAKFGMFI, TAction PJDAFKMDDCG);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool KGDPKHINAIE(TNetSys ONLGAKFGMFI, TAction PJDAFKMDDCG);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool NJHIKKCCDLE(TNetSys ONLGAKFGMFI, TAction PJDAFKMDDCG);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface OAGGHMKCBEA<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps BKNPLBCCAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps CCJFAPPGINK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps HLFNEBDLNHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface DDEAJPHIICG<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AAFGLNNJOHN<LEJAOJOLFIL> PCAPCCPBPKC(TReceiver ODAGIILJBBF);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PCCIFMBJCNL(TReceiver ODAGIILJBBF);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> NHFLDOKKJDG(TReceiver ODAGIILJBBF, TAction PJDAFKMDDCG);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] GGJBDHLEMGE(TReceiver ODAGIILJBBF);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface KEDMIDMAPJC<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MILNCDEEEFA(TRoot JGHOOBNHEJB);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int HBOMBPEEBNG(TRoot JGHOOBNHEJB);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int LLDNDPDNCFH(TRoot JGHOOBNHEJB);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int BIJBFCAFLNJ(TRoot JGHOOBNHEJB);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NOIPCIJFOIJ(TRoot JGHOOBNHEJB);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool IPPPMKOCCHN(TRoot JGHOOBNHEJB, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, TAction[] NOFICAHDIEO);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task CEGGKGIFGOM(TRoot JGHOOBNHEJB, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, AAFGLNNJOHN<TMRequest> IENEKJIPKDG, TAction PJDAFKMDDCG, bool MEFJEHEHFOA = true);
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
