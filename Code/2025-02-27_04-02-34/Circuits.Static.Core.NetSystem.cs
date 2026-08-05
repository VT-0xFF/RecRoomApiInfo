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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2578BB0", Offset = "0x2577FB0", VA = "0x182578BB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
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
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BCHKNBKLNOE : MPAEBDCEOBD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2578AF0", Offset = "0x2577EF0", VA = "0x182578AF0", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2578B70", Offset = "0x2577F70", VA = "0x182578B70")]
	private BCHKNBKLNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2578B20", Offset = "0x2577F20", VA = "0x182578B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xF7C350", Offset = "0xF7B750", VA = "0x180F7C350")]
		private DHDPOFJDIJN(TPartialAction[] EMEIPFCFCEO, int MKJNDADEFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62A7E40", Offset = "0x62A7240", VA = "0x1862A7E40")]
		public static CDNENBDPFJG<TPartialAction, TPartialActionId, TFullAction, TDeps>.DHDPOFJDIJN FEOBEKOIKMG(int CIPKBFKIILH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62A8180", Offset = "0x62A7580", VA = "0x1862A8180")]
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
		[Cpp2IlInjected.Address(RVA = "0x5A3A180", Offset = "0x5A39580", VA = "0x185A3A180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A270", Offset = "0x5A39670", VA = "0x185A3A270")]
	private CDNENBDPFJG(Dictionary<TPartialActionId, DHDPOFJDIJN>? MOFAFDFLKIO, TDeps GKFDJGEMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5A39150", Offset = "0x5A38550", VA = "0x185A39150")]
	public static CDNENBDPFJG<TPartialAction, TPartialActionId, TFullAction, TDeps> FEOBEKOIKMG(TDeps GKFDJGEMKAB)
	{
		return default(CDNENBDPFJG<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5A392C0", Offset = "0x5A386C0", VA = "0x185A392C0")]
	public JOFBNNGKBOO<HEGNJKKKIBE<TFullAction>, PPAGHPBHFJD> KLJMBBEBDIE(TPartialAction NAIPMAAFDBH)
	{
		return default(JOFBNNGKBOO<HEGNJKKKIBE<TFullAction>, PPAGHPBHFJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5A39200", Offset = "0x5A38600", VA = "0x185A39200")]
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
	[Cpp2IlInjected.Address(RVA = "0x62C2010", Offset = "0x62C1410", VA = "0x1862C2010")]
	internal DNKMKDFCIDD(TPartialSnapshot[] NJFLAOJGOKK, int CEHCGEKDEOK, TDeps GKFDJGEMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62C1FB0", Offset = "0x62C13B0", VA = "0x1862C1FB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x33A9280", Offset = "0x33A8680", VA = "0x1833A9280")]
	public static HEGNJKKKIBE<TFullSnapshot> KLJMBBEBDIE<TFullSnapshot, TPartialSnapshot, TDeps>(this DNKMKDFCIDD<TPartialSnapshot, TFullSnapshot, TDeps> JDCFMPOHCEA, TPartialSnapshot BHPCFAFLNGA) where TDeps : DDMEHABLAMH<TPartialSnapshot, TFullSnapshot>
	{
		return default(HEGNJKKKIBE<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x33A9670", Offset = "0x33A8A70", VA = "0x1833A9670")]
	public static bool MGFFHOKCOCM<TPartialSnapshot, TFullSnapshot, TDeps>(this DNKMKDFCIDD<TPartialSnapshot, TFullSnapshot, TDeps> JDCFMPOHCEA, TPartialSnapshot BHPCFAFLNGA) where TDeps : DDMEHABLAMH<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class NIIEIFLMPJM : MPAEBDCEOBD
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2578B80", Offset = "0x2577F80", VA = "0x182578B80", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2578B70", Offset = "0x2577F70", VA = "0x182578B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x4971240", Offset = "0x4970640", VA = "0x184971240")]
		private JHJDCIELPKN(TaskCompletionSource<JOFBNNGKBOO<object, PPAGHPBHFJD>> KDHLGIELGNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x473E940", Offset = "0x473DD40", VA = "0x18473E940")]
		public static JHJDCIELPKN FEOBEKOIKMG(TaskCompletionSource<JOFBNNGKBOO<object, PPAGHPBHFJD>> KDHLGIELGNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4970E00", Offset = "0x4970200", VA = "0x184970E00")]
		public void PEILLHOJLJI([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4970C40", Offset = "0x4970040", VA = "0x184970C40", Slot = "5")]
		public void JKLPPJMCBLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4971040", Offset = "0x4970440", VA = "0x184971040", Slot = "6")]
		public JOFBNNGKBOO<object, PPAGHPBHFJD> PNMJHGDMEFC()
		{
			return default(JOFBNNGKBOO<object, PPAGHPBHFJD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4970BE0", Offset = "0x496FFE0", VA = "0x184970BE0", Slot = "7")]
		public void HLGNGLOINLJ(Exception DADIPHEHDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3FFE270", Offset = "0x3FFD670", VA = "0x183FFE270", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
		private ANLJLKIHNML(TaskCompletionSource<JOFBNNGKBOO<object, PPAGHPBHFJD>> KDHLGIELGNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x473E940", Offset = "0x473DD40", VA = "0x18473E940")]
		public static ANLJLKIHNML FEOBEKOIKMG(TaskCompletionSource<JOFBNNGKBOO<object, PPAGHPBHFJD>> KDHLGIELGNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4950830", Offset = "0x494FC30", VA = "0x184950830")]
		public void PEILLHOJLJI([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4950770", Offset = "0x494FB70", VA = "0x184950770", Slot = "5")]
		public void JKLPPJMCBLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA998F0", Offset = "0xA98CF0", VA = "0x180A998F0", Slot = "6")]
		public JOFBNNGKBOO<object, PPAGHPBHFJD> PNMJHGDMEFC()
		{
			return default(JOFBNNGKBOO<object, PPAGHPBHFJD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4950710", Offset = "0x494FB10", VA = "0x184950710", Slot = "7")]
		public void HLGNGLOINLJ(Exception DADIPHEHDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3FFE270", Offset = "0x3FFD670", VA = "0x183FFE270", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x45DADD0", Offset = "0x45DA1D0", VA = "0x1845DADD0")]
		private HFNLHJOANGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x45DA960", Offset = "0x45D9D60", VA = "0x1845DA960")]
		public static HFNLHJOANGA FEOBEKOIKMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x45DAAC0", Offset = "0x45D9EC0", VA = "0x1845DAAC0")]
		public void PEILLHOJLJI([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public void JKLPPJMCBLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x45DAC80", Offset = "0x45DA080", VA = "0x1845DAC80", Slot = "6")]
		public JOFBNNGKBOO<object, PPAGHPBHFJD> PNMJHGDMEFC()
		{
			return default(JOFBNNGKBOO<object, PPAGHPBHFJD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x45DAA70", Offset = "0x45D9E70", VA = "0x1845DAA70", Slot = "7")]
		[CGDEHPHFPEN("This may be terminal and should probably do more than discarding the exception.")]
		public void HLGNGLOINLJ(Exception DADIPHEHDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3FFE270", Offset = "0x3FFD670", VA = "0x183FFE270", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		private KGMDMBMCJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x45DA960", Offset = "0x45D9D60", VA = "0x1845DA960")]
		public static KGMDMBMCJMN FEOBEKOIKMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x208CAC0", Offset = "0x208BEC0", VA = "0x18208CAC0")]
		public void PEILLHOJLJI([In] JOFBNNGKBOO<object, PPAGHPBHFJD> BIEIOPPGBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public void JKLPPJMCBLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xACB980", Offset = "0xACAD80", VA = "0x180ACB980", Slot = "6")]
		public JOFBNNGKBOO<object, PPAGHPBHFJD> PNMJHGDMEFC()
		{
			return default(JOFBNNGKBOO<object, PPAGHPBHFJD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4A50A10", Offset = "0x4A4FE10", VA = "0x184A50A10", Slot = "7")]
		[CGDEHPHFPEN("This may be terminal and should probably do more than discarding the exception.")]
		public void HLGNGLOINLJ(Exception DADIPHEHDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3FFE270", Offset = "0x3FFD670", VA = "0x183FFE270", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x496E1D0", Offset = "0x496D5D0", VA = "0x18496E1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x496E6B0", Offset = "0x496DAB0", VA = "0x18496E6B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DAB9A0", Offset = "0x4DAADA0", VA = "0x184DAB9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4DAC2D0", Offset = "0x4DAB6D0", VA = "0x184DAC2D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4FAFAE0", Offset = "0x4FAEEE0", VA = "0x184FAFAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4FB01B0", Offset = "0x4FAF5B0", VA = "0x184FB01B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4A5F690", Offset = "0x4A5EA90", VA = "0x184A5F690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4A61070", Offset = "0x4A60470", VA = "0x184A61070", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x48881B0", Offset = "0x48875B0", VA = "0x1848881B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x488C180", Offset = "0x488B580", VA = "0x18488C180", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x49678C0", Offset = "0x4966CC0", VA = "0x1849678C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4967C40", Offset = "0x4967040", VA = "0x184967C40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4568220", Offset = "0x4567620", VA = "0x184568220")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps HLFNEBDLNHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x45681A0", Offset = "0x45675A0", VA = "0x1845681A0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps CCJFAPPGINK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4568120", Offset = "0x4567520", VA = "0x184568120")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BBGDNKBKFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBA81F0", Offset = "0xBA75F0", VA = "0x180BA81F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBA7860", Offset = "0xBA6C60", VA = "0x180BA7860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BLOMHDMIEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x94D460", Offset = "0x94C860", VA = "0x18094D460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FGJEDCCIGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x968620", Offset = "0x967A20", VA = "0x180968620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4568AF0", Offset = "0x4567EF0", VA = "0x184568AF0")]
	public GPOBPEEKBLL(TDeps GKFDJGEMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x45666E0", Offset = "0x4565AE0", VA = "0x1845666E0")]
	public Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> CEGGKGIFGOM(TRoot JGHOOBNHEJB, TNetSys DLOFAJFNCML, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, TAction PJDAFKMDDCG, bool LELKEOHAIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x45670B0", Offset = "0x45664B0", VA = "0x1845670B0")]
	[AsyncStateMachine(typeof(GPOBPEEKBLL<, , , , , , , , >.JFPFDNMJPJD))]
	private Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> CEGGKGIFGOM(TRoot JGHOOBNHEJB, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, TAction PJDAFKMDDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4567A50", Offset = "0x4566E50", VA = "0x184567A50")]
	[AsyncStateMachine(typeof(GPOBPEEKBLL<, , , , , , , , >.MKCLEKLHBID))]
	private Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> CNGLEOACDPO(TRoot JGHOOBNHEJB, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, TAction[] NOFICAHDIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4568810", Offset = "0x4567C10", VA = "0x184568810")]
	[AsyncStateMachine(typeof(GPOBPEEKBLL<, , , , , , , , >.OJEKOAKFLNP))]
	public Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> NHFLDOKKJDG(TRoot JGHOOBNHEJB, TNetSys KCOPBHJNONI, TReceiver ODAGIILJBBF, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, AAFGLNNJOHN<TMRequest> IENEKJIPKDG, TAction PJDAFKMDDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4568250", Offset = "0x4567650", VA = "0x184568250")]
	[AsyncStateMachine(typeof(GPOBPEEKBLL<, , , , , , , , >.KKEKAHDBJJH))]
	private Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> IBIIHNIKGJN(TRoot JGHOOBNHEJB, TNetSys KCOPBHJNONI, TReceiver ODAGIILJBBF, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, AAFGLNNJOHN<TMRequest> IENEKJIPKDG, TAction PJDAFKMDDCG, Task BGKJOJOPDGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x45686C0", Offset = "0x4567AC0", VA = "0x1845686C0")]
	[AsyncStateMachine(typeof(GPOBPEEKBLL<, , , , , , , , >.AMCPOOCMIDF))]
	private Task LCAJIJJBEGG(TRoot JGHOOBNHEJB, TNetSys KCOPBHJNONI, TReceiver ODAGIILJBBF, TAction PJDAFKMDDCG, BNDAPDGBNOF EGHDHCFFIND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4568050", Offset = "0x4567450", VA = "0x184568050")]
	private void FHCMEIGJMMB(TReceiver ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4567790", Offset = "0x4566B90", VA = "0x184567790")]
	private void CMOMDHGFGBL(TRoot JGHOOBNHEJB, TNetSys KCOPBHJNONI, TReceiver ODAGIILJBBF, AAFGLNNJOHN<LEJAOJOLFIL> GNEBHLDFAOJ, TAction PJDAFKMDDCG, bool KIIBKLNLLLB, bool DCIHEKCCPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4567E60", Offset = "0x4567260", VA = "0x184567E60")]
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
