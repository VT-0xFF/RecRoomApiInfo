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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x29E8FA0", Offset = "0x29E7DA0", VA = "0x1829E8FA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BBAFABONOHP : CIPPKAIIPLL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29E8EE0", Offset = "0x29E7CE0", VA = "0x1829E8EE0", Slot = "7")]
	public override string KMHKNGKODJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29E8F60", Offset = "0x29E7D60", VA = "0x1829E8F60")]
	private BBAFABONOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29E8F10", Offset = "0x29E7D10", VA = "0x1829E8F10")]
	public static BBAFABONOHP OGAKBGHEIKK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PHBBOHGOCCM<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, BHCHDOMMEOC.DNHFMOFJBEF<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CPDAMFGEICP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] HKGNGHEBDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int INMCMGMELPF;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12DBED0", Offset = "0x12DACD0", VA = "0x1812DBED0")]
		private CPDAMFGEICP(TPartialAction[] ACMMFFKMBAP, int NADGPJLMAMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68E4510", Offset = "0x68E3310", VA = "0x1868E4510")]
		public static PHBBOHGOCCM<TPartialAction, TPartialActionId, TFullAction, TDeps>.CPDAMFGEICP OGAKBGHEIKK(int CCABNJLPHIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68E41D0", Offset = "0x68E2FD0", VA = "0x1868E41D0")]
		public JDAJLJFAAGF<TFullAction> HBALALHJJKF(TPartialAction CBBCHDMMBBD, TDeps FEBHHEFFJMB)
		{
			return default(JDAJLJFAAGF<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, CPDAMFGEICP>? IEAMGMECDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps IHILFMGFJPA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, CPDAMFGEICP> CBONGDAMINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5989990", Offset = "0x5988790", VA = "0x185989990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5989B20", Offset = "0x5988920", VA = "0x185989B20")]
	private PHBBOHGOCCM(Dictionary<TPartialActionId, CPDAMFGEICP>? MEHKJLEOAHI, TDeps FEBHHEFFJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5989A70", Offset = "0x5988870", VA = "0x185989A70")]
	public static PHBBOHGOCCM<TPartialAction, TPartialActionId, TFullAction, TDeps> OGAKBGHEIKK(TDeps FEBHHEFFJMB)
	{
		return default(PHBBOHGOCCM<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5989360", Offset = "0x5988160", VA = "0x185989360")]
	public CKPFCFEHEPP<JDAJLJFAAGF<TFullAction>, FCJOMJLBDOM> HBALALHJJKF(TPartialAction CBBCHDMMBBD)
	{
		return default(CKPFCFEHEPP<JDAJLJFAAGF<TFullAction>, FCJOMJLBDOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5988AF0", Offset = "0x59878F0", VA = "0x185988AF0")]
	public void EIIDOFLDIKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BHCHDOMMEOC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface DNHFMOFJBEF<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BELHNECFEEM([In] TPartialAction CBBCHDMMBBD);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int OJDBHHHGPKI([In] TPartialAction CBBCHDMMBBD);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId MKEOMMBAJOC([In] TPartialAction CBBCHDMMBBD);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction GAJMBCDMOGM(TPartialAction[] JIKIDGOPKPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BBLEDFELLOC<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : JMIMMOAGDKG.BAEKNNKGLEB<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] LMGHLJOENOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int LLKCIAEEOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps IHILFMGFJPA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x624CEF0", Offset = "0x624BCF0", VA = "0x18624CEF0")]
	internal BBLEDFELLOC(TPartialSnapshot[] EGHGFLGGCEB, int EBDIMFKPGMM, TDeps FEBHHEFFJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x624CE90", Offset = "0x624BC90", VA = "0x18624CE90")]
	public static BBLEDFELLOC<TPartialSnapshot, TFullSnapshot, TDeps> OGAKBGHEIKK(TDeps FEBHHEFFJMB)
	{
		return default(BBLEDFELLOC<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JMIMMOAGDKG
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface BAEKNNKGLEB<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HAFFKCPJKNK([In] TPartialSnapshot KAPHLDDOEIG);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot OACPILNJKKH(TPartialSnapshot[] DHMIAHKNLJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9460", Offset = "0x3BF8260", VA = "0x183BF9460")]
	public static JDAJLJFAAGF<TFullSnapshot> HBALALHJJKF<TFullSnapshot, TPartialSnapshot, TDeps>(this BBLEDFELLOC<TPartialSnapshot, TFullSnapshot, TDeps> FEOFEEGOGIO, TPartialSnapshot KAPHLDDOEIG) where TDeps : BAEKNNKGLEB<TPartialSnapshot, TFullSnapshot>
	{
		return default(JDAJLJFAAGF<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9810", Offset = "0x3BF8610", VA = "0x183BF9810")]
	public static bool NEMLMBBIOKK<TPartialSnapshot, TFullSnapshot, TDeps>(this BBLEDFELLOC<TPartialSnapshot, TFullSnapshot, TDeps> FEOFEEGOGIO, TPartialSnapshot KAPHLDDOEIG) where TDeps : BAEKNNKGLEB<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class KOEFAHAGDAI : CIPPKAIIPLL
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x29E8F70", Offset = "0x29E7D70", VA = "0x1829E8F70", Slot = "7")]
	public override string KMHKNGKODJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x29E8F60", Offset = "0x29E7D60", VA = "0x1829E8F60")]
	public KOEFAHAGDAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NECBJNNNOFJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : FLJPFJJIPIO.MOLBIDAGNEO<TAction, TNetSys> where TReceiverDeps : FLJPFJJIPIO.JLALEFLLJJB<TAction, TReceiver> where TRootDeps : FLJPFJJIPIO.HILJKOIILHM<TMRequest, TAction, TRoot> where TDeps : FLJPFJJIPIO.EMHNMLPCNBD<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface GHCNCICANMH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FMEMGPOGECD([In] CKPFCFEHEPP<object, FCJOMJLBDOM> OHLBIIOAJDL);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DCIJANNJCIM();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CKPFCFEHEPP<object, FCJOMJLBDOM> COMDFDMIJGH();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DECIIGDDAOD(Exception KHPHCONHPBN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class DFKHGMKNJMJ : GHCNCICANMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<CKPFCFEHEPP<object, FCJOMJLBDOM>> OOMNOJFCADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<CKPFCFEHEPP<object, LJGAAONCGFM>> DOMNAEOLNMO;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6DDBE70", Offset = "0x6DDAC70", VA = "0x186DDBE70")]
		private DFKHGMKNJMJ(TaskCompletionSource<CKPFCFEHEPP<object, FCJOMJLBDOM>> HLJEBJIJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BBA0", Offset = "0x4E1A9A0", VA = "0x184E1BBA0")]
		public static DFKHGMKNJMJ OGAKBGHEIKK(TaskCompletionSource<CKPFCFEHEPP<object, FCJOMJLBDOM>> HLJEBJIJODM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6DDBAD0", Offset = "0x6DDA8D0", VA = "0x186DDBAD0")]
		public void FMEMGPOGECD([In] CKPFCFEHEPP<object, FCJOMJLBDOM> OHLBIIOAJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6DDB7F0", Offset = "0x6DDA5F0", VA = "0x186DDB7F0", Slot = "5")]
		public void DCIJANNJCIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DDB500", Offset = "0x6DDA300", VA = "0x186DDB500", Slot = "6")]
		public CKPFCFEHEPP<object, FCJOMJLBDOM> COMDFDMIJGH()
		{
			return default(CKPFCFEHEPP<object, FCJOMJLBDOM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6DDBA10", Offset = "0x6DDA810", VA = "0x186DDBA10", Slot = "7")]
		public void DECIIGDDAOD(Exception KHPHCONHPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4D761B0", Offset = "0x4D74FB0", VA = "0x184D761B0", Slot = "4")]
		private void LMHLPCLELIK([In] CKPFCFEHEPP<object, FCJOMJLBDOM> OHLBIIOAJDL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class OPLIMGOJGBA : GHCNCICANMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<CKPFCFEHEPP<object, FCJOMJLBDOM>> OOMNOJFCADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private CKPFCFEHEPP<object, FCJOMJLBDOM> PAMLGOJLBPA;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
		private OPLIMGOJGBA(TaskCompletionSource<CKPFCFEHEPP<object, FCJOMJLBDOM>> HLJEBJIJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BBA0", Offset = "0x4E1A9A0", VA = "0x184E1BBA0")]
		public static OPLIMGOJGBA OGAKBGHEIKK(TaskCompletionSource<CKPFCFEHEPP<object, FCJOMJLBDOM>> HLJEBJIJODM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xEBA7A0", Offset = "0xEB95A0", VA = "0x180EBA7A0")]
		public void FMEMGPOGECD([In] CKPFCFEHEPP<object, FCJOMJLBDOM> OHLBIIOAJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x58B2290", Offset = "0x58B1090", VA = "0x1858B2290", Slot = "5")]
		public void DCIJANNJCIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD16990", Offset = "0xD15790", VA = "0x180D16990", Slot = "6")]
		public CKPFCFEHEPP<object, FCJOMJLBDOM> COMDFDMIJGH()
		{
			return default(CKPFCFEHEPP<object, FCJOMJLBDOM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x58B23B0", Offset = "0x58B11B0", VA = "0x1858B23B0", Slot = "7")]
		public void DECIIGDDAOD(Exception KHPHCONHPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4D761B0", Offset = "0x4D74FB0", VA = "0x184D761B0", Slot = "4")]
		private void LMHLPCLELIK([In] CKPFCFEHEPP<object, FCJOMJLBDOM> OHLBIIOAJDL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class MNBLAHKKFCM : GHCNCICANMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<CKPFCFEHEPP<object, FCJOMJLBDOM>> DOMNAEOLNMO;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5685450", Offset = "0x5684250", VA = "0x185685450")]
		private MNBLAHKKFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5685300", Offset = "0x5684100", VA = "0x185685300")]
		public static MNBLAHKKFCM OGAKBGHEIKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5685090", Offset = "0x5683E90", VA = "0x185685090")]
		public void FMEMGPOGECD([In] CKPFCFEHEPP<object, FCJOMJLBDOM> OHLBIIOAJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public void DCIJANNJCIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5684EE0", Offset = "0x5683CE0", VA = "0x185684EE0", Slot = "6")]
		public CKPFCFEHEPP<object, FCJOMJLBDOM> COMDFDMIJGH()
		{
			return default(CKPFCFEHEPP<object, FCJOMJLBDOM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5684FA0", Offset = "0x5683DA0", VA = "0x185684FA0", Slot = "7")]
		[KNICHPAKIIM("This may be terminal and should probably do more than discarding the exception.")]
		public void DECIIGDDAOD(Exception KHPHCONHPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4D761B0", Offset = "0x4D74FB0", VA = "0x184D761B0", Slot = "4")]
		private void LMHLPCLELIK([In] CKPFCFEHEPP<object, FCJOMJLBDOM> OHLBIIOAJDL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class OPOEMEOFKAJ : GHCNCICANMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private CKPFCFEHEPP<object, FCJOMJLBDOM> PAMLGOJLBPA;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		private OPOEMEOFKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5685300", Offset = "0x5684100", VA = "0x185685300")]
		public static OPOEMEOFKAJ OGAKBGHEIKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x25ED9C0", Offset = "0x25EC7C0", VA = "0x1825ED9C0")]
		public void FMEMGPOGECD([In] CKPFCFEHEPP<object, FCJOMJLBDOM> OHLBIIOAJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public void DCIJANNJCIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xE4BDD0", Offset = "0xE4ABD0", VA = "0x180E4BDD0", Slot = "6")]
		public CKPFCFEHEPP<object, FCJOMJLBDOM> COMDFDMIJGH()
		{
			return default(CKPFCFEHEPP<object, FCJOMJLBDOM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x58B2520", Offset = "0x58B1320", VA = "0x1858B2520", Slot = "7")]
		[KNICHPAKIIM("This may be terminal and should probably do more than discarding the exception.")]
		public void DECIIGDDAOD(Exception KHPHCONHPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4D761B0", Offset = "0x4D74FB0", VA = "0x184D761B0", Slot = "4")]
		private void LMHLPCLELIK([In] CKPFCFEHEPP<object, FCJOMJLBDOM> OHLBIIOAJDL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct AIABJMPLFCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<object, FCJOMJLBDOM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NECBJNNNOFJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public HBBCPCNIOON<MLFFMCDFHFO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<CKPFCFEHEPP<object, FCJOMJLBDOM>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<CKPFCFEHEPP<object, FCJOMJLBDOM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF6B0", Offset = "0x4FDE4B0", VA = "0x184FDF6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4FE06A0", Offset = "0x4FDF4A0", VA = "0x184FE06A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct IIKJELKBNMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<object, FCJOMJLBDOM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public NECBJNNNOFJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public HBBCPCNIOON<MLFFMCDFHFO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<CKPFCFEHEPP<object, FCJOMJLBDOM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4F200F0", Offset = "0x4F1EEF0", VA = "0x184F200F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4F20610", Offset = "0x4F1F410", VA = "0x184F20610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct NMEHDPLOMDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<object, FCJOMJLBDOM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public NECBJNNNOFJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public HBBCPCNIOON<MLFFMCDFHFO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public HBBCPCNIOON<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<CKPFCFEHEPP<object, FCJOMJLBDOM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x570C4B0", Offset = "0x570B2B0", VA = "0x18570C4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x570CF30", Offset = "0x570BD30", VA = "0x18570CF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct OFGLIDKBGIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<object, FCJOMJLBDOM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public NECBJNNNOFJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public HBBCPCNIOON<MLFFMCDFHFO> senderId;

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
		public HBBCPCNIOON<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private GHCNCICANMH <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x58506D0", Offset = "0x584F4D0", VA = "0x1858506D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x58512D0", Offset = "0x58500D0", VA = "0x1858512D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct ACPMIBMEKLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NECBJNNNOFJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public GHCNCICANMH completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GHCNCICANMH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<CKPFCFEHEPP<object?, FCJOMJLBDOM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8520", Offset = "0x4EB7320", VA = "0x184EB8520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4EBC000", Offset = "0x4EBAE00", VA = "0x184EBC000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HKJPGMGEGIP : IAsyncStateMachine
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
		public NECBJNNNOFJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public HBBCPCNIOON<MLFFMCDFHFO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4E2E9B0", Offset = "0x4E2D7B0", VA = "0x184E2E9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4E2ED80", Offset = "0x4E2DB80", VA = "0x184E2ED80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps IHILFMGFJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<HBBCPCNIOON<TMRequest>, TaskCompletionSource<CKPFCFEHEPP<object, FCJOMJLBDOM>>> LIINLFLAMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DPOAEHOMHBA<TMRequest> OFBFFMLJFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool OPCPFKOBFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int GIAHHOMJFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task OAGCKDHAGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int AFFKCPAGIMJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps GDJAOLMFAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x56D2BE0", Offset = "0x56D19E0", VA = "0x1856D2BE0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps ICNDBDPBACA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x56D4C60", Offset = "0x56D3A60", VA = "0x1856D4C60")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps NIKMOPEHKBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x56D2BB0", Offset = "0x56D19B0", VA = "0x1856D2BB0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool APICMNCIFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xE42AD0", Offset = "0xE418D0", VA = "0x180E42AD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xE42610", Offset = "0xE41410", VA = "0x180E42610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HFJKCJNOPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA5A420", Offset = "0xA59220", VA = "0x180A5A420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FCDODJPCLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA76750", Offset = "0xA75550", VA = "0x180A76750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x56D5580", Offset = "0x56D4380", VA = "0x1856D5580")]
	public NECBJNNNOFJ(TDeps FEBHHEFFJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x56D4160", Offset = "0x56D2F60", VA = "0x1856D4160")]
	public Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> NGBHNIDGECG(TRoot EGPDFGOHLFM, TNetSys EEKCNAPAIAN, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, TAction LJIGAFKJJAI, bool CNJBMAGKMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x56D4450", Offset = "0x56D3250", VA = "0x1856D4450")]
	[AsyncStateMachine(typeof(NECBJNNNOFJ<, , , , , , , , >.AIABJMPLFCE))]
	private Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> NGBHNIDGECG(TRoot EGPDFGOHLFM, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, TAction LJIGAFKJJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x56D2040", Offset = "0x56D0E40", VA = "0x1856D2040")]
	[AsyncStateMachine(typeof(NECBJNNNOFJ<, , , , , , , , >.IIKJELKBNMK))]
	private Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> DEICMIADCNK(TRoot EGPDFGOHLFM, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, TAction[] HOMOELFOPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x56D2470", Offset = "0x56D1270", VA = "0x1856D2470")]
	[AsyncStateMachine(typeof(NECBJNNNOFJ<, , , , , , , , >.NMEHDPLOMDK))]
	public Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> FDKCEDNIALC(TRoot EGPDFGOHLFM, TNetSys BCKIHKBGACN, TReceiver JBODBHEGPEF, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, HBBCPCNIOON<TMRequest> PGNFEHAOEME, TAction LJIGAFKJJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x56D1A50", Offset = "0x56D0850", VA = "0x1856D1A50")]
	[AsyncStateMachine(typeof(NECBJNNNOFJ<, , , , , , , , >.OFGLIDKBGIL))]
	private Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> DAODBFPJKEA(TRoot EGPDFGOHLFM, TNetSys BCKIHKBGACN, TReceiver JBODBHEGPEF, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, HBBCPCNIOON<TMRequest> PGNFEHAOEME, TAction LJIGAFKJJAI, Task PAKLLHDIBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x56D28C0", Offset = "0x56D16C0", VA = "0x1856D28C0")]
	[AsyncStateMachine(typeof(NECBJNNNOFJ<, , , , , , , , >.ACPMIBMEKLK))]
	private Task FOCIEJALFMJ(TRoot EGPDFGOHLFM, TNetSys BCKIHKBGACN, TReceiver JBODBHEGPEF, TAction LJIGAFKJJAI, GHCNCICANMH CEAHCJDOOMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x56D3D60", Offset = "0x56D2B60", VA = "0x1856D3D60")]
	private void MNIHOCPCPJL(TReceiver JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x56D31F0", Offset = "0x56D1FF0", VA = "0x1856D31F0")]
	private void JEDPBGKIDCB(TRoot EGPDFGOHLFM, TNetSys BCKIHKBGACN, TReceiver JBODBHEGPEF, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, TAction LJIGAFKJJAI, bool HOHCONCKGAP, bool CKAHCMHKCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x56D3990", Offset = "0x56D2790", VA = "0x1856D3990")]
	[AsyncStateMachine(typeof(NECBJNNNOFJ<, , , , , , , , >.HKJPGMGEGIP))]
	public Task LGGPLFHNLCK(TRoot EGPDFGOHLFM, TNetSys BCKIHKBGACN, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, TAction[] PIKNLACABOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x56D5000", Offset = "0x56D3E00", VA = "0x1856D5000")]
	private (TAction, int) OBBPGLJKIBG(TRoot EGPDFGOHLFM, TNetSys AMLAIOEPFCC, TAction LJIGAFKJJAI)
	{
		return default((TAction, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class FLJPFJJIPIO
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface MOLBIDAGNEO<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LGKAOOLPOJI(TNetSys DNNGMHNAHKG, TAction LJIGAFKJJAI);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction IFANFANENEG(TNetSys DNNGMHNAHKG, TAction LJIGAFKJJAI);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction OPMJJOGIEJF(TNetSys DNNGMHNAHKG, TAction LJIGAFKJJAI);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> PIGELHBEEJK(TNetSys DNNGMHNAHKG, TAction LJIGAFKJJAI);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] GNBEIBBHOBP(TNetSys DNNGMHNAHKG, TAction LJIGAFKJJAI, int AKPNKKMHMII);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HJAGMALILFL(TNetSys DNNGMHNAHKG, TAction LJIGAFKJJAI);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool AFCJEMHEDKB(TNetSys DNNGMHNAHKG, TAction LJIGAFKJJAI);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool BHFIIMGFKMO(TNetSys DNNGMHNAHKG, TAction LJIGAFKJJAI);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool DGOOPGHJHNF(TNetSys DNNGMHNAHKG, TAction LJIGAFKJJAI);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool NBOBGJBCCAB(TNetSys DNNGMHNAHKG, TAction LJIGAFKJJAI);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool KIDFAMDGHMP(TNetSys DNNGMHNAHKG, TAction LJIGAFKJJAI);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface EMHNMLPCNBD<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps GDJAOLMFAMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps NIKMOPEHKBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps ICNDBDPBACA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface JLALEFLLJJB<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		HBBCPCNIOON<MLFFMCDFHFO> ENGABJHLKGB(TReceiver JBODBHEGPEF);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MHNJDPAJMGG(TReceiver JBODBHEGPEF);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> FDKCEDNIALC(TReceiver JBODBHEGPEF, TAction LJIGAFKJJAI);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] PGPANDEBDGH(TReceiver JBODBHEGPEF);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface HILJKOIILHM<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AIGCIGFCOIA(TRoot EGPDFGOHLFM);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int BBLIEGIAMIM(TRoot EGPDFGOHLFM);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int PKCNOCKPNMO(TRoot EGPDFGOHLFM);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int NAECHBEKCBD(TRoot EGPDFGOHLFM);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MFDFGPDOIJB(TRoot EGPDFGOHLFM);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NNKOPCBGOOP(TRoot EGPDFGOHLFM, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, TAction[] HOMOELFOPNM);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool PGAJKDCHOPA(TRoot EGPDFGOHLFM, int AACEGAIHBHL);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task NGBHNIDGECG(TRoot EGPDFGOHLFM, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, HBBCPCNIOON<TMRequest> PGNFEHAOEME, TAction LJIGAFKJJAI, bool MEDEAMFDDON = true);
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
