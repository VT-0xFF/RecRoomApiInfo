using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1D410F0", Offset = "0x1D3F6F0", VA = "0x181D410F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x723370", Offset = "0x721970", VA = "0x180723370")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xE65B40", Offset = "0xE64140", VA = "0x180E65B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MFNILBINDOO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface EJEGJKHCMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string PKNPCOELEGJ(string FFCMOKMMJLP);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KKKEBBLEFHK(string MLGGMMOFMCD);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LDNFKGKMJII(Exception PEAJABIJNDI);
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static EJEGJKHCMMG LOGBPMLPMIM;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct BMAGIOMGAFJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IDisposable[] EAOHEEFHAEF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72F870", Offset = "0x72DE70", VA = "0x18072F870")]
	public BMAGIOMGAFJ(params IDisposable[] NPOACONIGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x796B50", Offset = "0x795150", VA = "0x180796B50")]
	public static BMAGIOMGAFJ OJKIKDBCCPC(params IDisposable[] NPOACONIGFC)
	{
		return default(BMAGIOMGAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1D40820", Offset = "0x1D3EE20", VA = "0x181D40820", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct HNHEPJNIBFL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IDisposable AAEEOADJGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public T OIHHNPGGOMC;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3353880", Offset = "0x3351E80", VA = "0x183353880")]
	public HNHEPJNIBFL(IDisposable BMNJCJDHIKF, in T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x350AC80", Offset = "0x3509280", VA = "0x18350AC80")]
	public static global::HNHEPJNIBFL<U> LMCAGOEOBGO<U>(in global::HNHEPJNIBFL<T> BMNJCJDHIKF, in U MAKFNMHIJIF)
	{
		return default(global::HNHEPJNIBFL<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x498AB10", Offset = "0x4989110", VA = "0x18498AB10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HBOIJGMFCGG
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x32CE440", Offset = "0x32CCA40", VA = "0x1832CE440")]
	public static global::HNHEPJNIBFL<T> OJKIKDBCCPC<T>(IDisposable BMNJCJDHIKF, in T MAKFNMHIJIF)
	{
		return default(global::HNHEPJNIBFL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A456D0", Offset = "0x2A43CD0", VA = "0x182A456D0")]
	public static global::HNHEPJNIBFL<U> LMCAGOEOBGO<U, T>(in global::HNHEPJNIBFL<T> DKINJHLIHFJ, in U MAKFNMHIJIF)
	{
		return default(global::HNHEPJNIBFL<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct KNDOHKEKBHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260")]
	public static KNDOHKEKBHA OOFEPMABPOC(Type MCLMFJEAHEC, [Optional] string MENHCPFOPMD, [Optional] string JBHCHLIGIIF, bool FKLEINGPDND = false)
	{
		return default(KNDOHKEKBHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260")]
	public static KNDOHKEKBHA OOFEPMABPOC<T>([Optional] string MENHCPFOPMD, [Optional] string JBHCHLIGIIF, bool FKLEINGPDND = false)
	{
		return default(KNDOHKEKBHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class IHHGNGPIMCG
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static bool MHCCPDNGOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly string BNAHNFEPNGJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public virtual IHHGNGPIMCG HLGFOFEEJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D40FA0", Offset = "0x1D3F5A0", VA = "0x181D40FA0")]
	protected IHHGNGPIMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string CNNOKHADNMO();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D40D30", Offset = "0x1D3F330", VA = "0x181D40D30", Slot = "6")]
	public virtual string LDFILJMGGMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D40940", Offset = "0x1D3EF40", VA = "0x181D40940")]
	public void ANFGPJLMLOG(StringBuilder CCLNHPOEGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D40F40", Offset = "0x1D3F540", VA = "0x181D40F40")]
	public void POBCCBCJFMC(StringBuilder CCLNHPOEGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1D40BC0", Offset = "0x1D3F1C0", VA = "0x181D40BC0")]
	public void BKJLEOGKMPE(StringBuilder CCLNHPOEGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D40E50", Offset = "0x1D3F450", VA = "0x181D40E50")]
	public void PJIHDMBNACB(StringBuilder CCLNHPOEGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1D40DB0", Offset = "0x1D3F3B0", VA = "0x181D40DB0")]
	public static void MNCFGFBMIDF(StringBuilder CCLNHPOEGCA, string GJEBOKDBHAO, string JMBLDDGLJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x859940", Offset = "0x857F40", VA = "0x180859940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class INIGDLLJDDH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1D41010", Offset = "0x1D3F610", VA = "0x181D41010")]
	public INIGDLLJDDH(string DIDMFBHHIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FGDKHEOLKOI<TErr> : INIGDLLJDDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TErr GCHJJLAMGFL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBFD0", Offset = "0x3DEA5D0", VA = "0x183DEBFD0")]
	private FGDKHEOLKOI(in TErr EKEJANBAMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBF00", Offset = "0x3DEA500", VA = "0x183DEBF00")]
	public static global::FGDKHEOLKOI<TErr> OJKIKDBCCPC(in TErr EKEJANBAMHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MLCMOEMANBL<out TOptions>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	TOptions OIHHNPGGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MCOMKGEBOBH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string LMCBOADCOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PMCPIALAIID : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1D41180", Offset = "0x1D3F780", VA = "0x181D41180")]
	public PMCPIALAIID(string DIDMFBHHIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IGEKMKBGKBJ<TOk> : PMCPIALAIID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly TOk OPGMGLFPBIP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2FEDA90", Offset = "0x2FEC090", VA = "0x182FEDA90")]
	private IGEKMKBGKBJ(in TOk CCPNFJDNEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2FED9C0", Offset = "0x2FEBFC0", VA = "0x182FED9C0")]
	public static global::IGEKMKBGKBJ<TOk> OJKIKDBCCPC(in TOk CCPNFJDNEDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct IKEELLNFFOM<TOk, TErr> : IEquatable<global::IKEELLNFFOM<TOk, TErr>>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly EqualityComparer<TErr> PHJMIBHFMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly TErr GCHJJLAMGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly TOk OPGMGLFPBIP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PFMNNHDPHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2FFF950", Offset = "0x2FFDF50", VA = "0x182FFF950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KLNCGMHOKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3000350", Offset = "0x2FFE950", VA = "0x183000350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30043B0", Offset = "0x30029B0", VA = "0x1830043B0")]
	internal IKEELLNFFOM(in TErr EKEJANBAMHK, in TOk CCPNFJDNEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3003080", Offset = "0x3001680", VA = "0x183003080")]
	public static global::IKEELLNFFOM<TOk, TErr> PBIHFDLJLAD(in TErr EKEJANBAMHK)
	{
		return default(global::IKEELLNFFOM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3000670", Offset = "0x2FFEC70", VA = "0x183000670")]
	public static global::IKEELLNFFOM<TOk, TErr> ENGJOGPJOBB(in TOk CCPNFJDNEDL)
	{
		return default(global::IKEELLNFFOM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x350B480", Offset = "0x3509A80", VA = "0x18350B480")]
	public global::IKEELLNFFOM<TOk, UErr> KDKBDHEJEEM<UErr>()
	{
		return default(global::IKEELLNFFOM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x350BD70", Offset = "0x350A370", VA = "0x18350BD70")]
	public global::IKEELLNFFOM<UOk, TErr> OLKPJFCGKHP<UOk>()
	{
		return default(global::IKEELLNFFOM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x350B190", Offset = "0x3509790", VA = "0x18350B190")]
	public global::IKEELLNFFOM<UOk, TErr> AAOJLPJNJMG<UOk>()
	{
		return default(global::IKEELLNFFOM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x350B3B0", Offset = "0x35099B0", VA = "0x18350B3B0")]
	public global::IKEELLNFFOM<TOk, UErr> BGJANPFKGJL<UErr>()
	{
		return default(global::IKEELLNFFOM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3002D00", Offset = "0x3001300", VA = "0x183002D00")]
	public global::IKEELLNFFOM<ABCENELPPGI, TErr> OFABNNJNMMH()
	{
		return default(global::IKEELLNFFOM<ABCENELPPGI, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3001990", Offset = "0x2FFFF90", VA = "0x183001990")]
	public static bool GBIPOJBPNDJ(in global::IKEELLNFFOM<TOk, TErr> FFMFLKJEKLP, in global::IKEELLNFFOM<TOk, TErr> PHDGNGLFBBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3000E00", Offset = "0x2FFF400", VA = "0x183000E00", Slot = "4")]
	public bool Equals(global::IKEELLNFFOM<TOk, TErr> OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x30013C0", Offset = "0x2FFF9C0", VA = "0x1830013C0", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3002B90", Offset = "0x3001190", VA = "0x183002B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3003F70", Offset = "0x3002570", VA = "0x183003F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JGINGEFKEII
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x33D5170", Offset = "0x33D3770", VA = "0x1833D5170")]
	public static global::IKEELLNFFOM<TOk, TErr> OPGMGLFPBIP<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, in TOk CCPNFJDNEDL)
	{
		return default(global::IKEELLNFFOM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x33D60D0", Offset = "0x33D46D0", VA = "0x1833D60D0")]
	public static global::IKEELLNFFOM<ABCENELPPGI, TErr> OPGMGLFPBIP<TErr>(this in global::IKEELLNFFOM<ABCENELPPGI, TErr> DKOFBKPNBJK)
	{
		return default(global::IKEELLNFFOM<ABCENELPPGI, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x33D5170", Offset = "0x33D3770", VA = "0x1833D5170")]
	public static global::IKEELLNFFOM<TOk, TErr> GCHJJLAMGFL<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, in TErr EKEJANBAMHK)
	{
		return default(global::IKEELLNFFOM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x33D5390", Offset = "0x33D3990", VA = "0x1833D5390")]
	public static TOk JMPIKDDOIAM<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x33D64A0", Offset = "0x33D4AA0", VA = "0x1833D64A0")]
	[AsyncStateMachine(typeof(EHLCFKPIFDA))]
	public static Task<TOk> PKBDBKKCFLJ<TOk, TErr>(this Task<global::IKEELLNFFOM<TOk, TErr>> DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x33D4F80", Offset = "0x33D3580", VA = "0x1833D4F80")]
	public static TErr FMKBJPDHLBF<TErr, TOk>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x33D55A0", Offset = "0x33D3BA0", VA = "0x1833D55A0")]
	public static bool LDLGFHEBOMM<TOk, TErr, UErr, UOk>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out global::IKEELLNFFOM<UOk, UErr> IBPHJGLNIHH) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x33D52E0", Offset = "0x33D38E0", VA = "0x1833D52E0")]
	public static bool JEELPIALIGJ<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out TOk CCPNFJDNEDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x33D5FF0", Offset = "0x33D45F0", VA = "0x1833D5FF0")]
	public static bool NBAPHLFMFNN<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out TErr EKEJANBAMHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x33D6070", Offset = "0x33D4670", VA = "0x1833D6070")]
	public static bool NIDEADEICAP<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out TOk CCPNFJDNEDL, out TErr EKEJANBAMHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x33D5240", Offset = "0x33D3840", VA = "0x1833D5240")]
	public static bool IDNFACNMIOH<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out TOk CCPNFJDNEDL, out global::IKEELLNFFOM<TOk, TErr> IBPHJGLNIHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33D5A50", Offset = "0x33D4050", VA = "0x1833D5A50")]
	public static bool LDLGFHEBOMM<TOk, TErr, UErr, UOk>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out TOk CCPNFJDNEDL, out global::IKEELLNFFOM<UOk, UErr> IBPHJGLNIHH) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x33D61E0", Offset = "0x33D47E0", VA = "0x1833D61E0")]
	public static bool PAFDMKMANKI<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out TOk CCPNFJDNEDL, out global::IKEELLNFFOM<ABCENELPPGI, TErr> IBPHJGLNIHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x33D5CF0", Offset = "0x33D42F0", VA = "0x1833D5CF0")]
	public static global::IKEELLNFFOM<UOk, UErr> MAKBEADPGCH<UOk, UErr, TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, in global::IKEELLNFFOM<UOk, UErr> IBHBGBEBHJM) where TOk : UOk where TErr : UErr
	{
		return default(global::IKEELLNFFOM<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x33D4CD0", Offset = "0x33D32D0", VA = "0x1833D4CD0")]
	public static global::IKEELLNFFOM<TOk[], TErr> BJJELHFPJDP<TOk, TErr>(this IEnumerable<global::IKEELLNFFOM<TOk, TErr>> DKOFBKPNBJK)
	{
		return default(global::IKEELLNFFOM<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2514E40", Offset = "0x2513440", VA = "0x182514E40")]
	[IteratorStateMachine(typeof(EFGNMDLNAIM))]
	public static IEnumerable<TOk> NGAMLKICKFL<TOk, TErr>(this IEnumerable<global::IKEELLNFFOM<TOk, TErr>> DKOFBKPNBJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CLHBALLNFDG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DEB0", Offset = "0x3A3C4B0", VA = "0x183A3DEB0")]
	public static global::IKEELLNFFOM<TOk, T> OPGMGLFPBIP<TOk>(in TOk CCPNFJDNEDL)
	{
		return default(global::IKEELLNFFOM<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3659CC0", Offset = "0x36582C0", VA = "0x183659CC0")]
	public static global::IKEELLNFFOM<ABCENELPPGI, T> OPGMGLFPBIP()
	{
		return default(global::IKEELLNFFOM<ABCENELPPGI, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DDF0", Offset = "0x3A3C3F0", VA = "0x183A3DDF0")]
	public static global::IKEELLNFFOM<T, TErr> GCHJJLAMGFL<TErr>(in TErr EKEJANBAMHK)
	{
		return default(global::IKEELLNFFOM<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public sealed class ILBDKHKGGBK<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private readonly struct GGFEDJIDALH : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly global::ILBDKHKGGBK<T> CEMHFDNCLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly int OBJFFGDNFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly bool IDKMNNKOHNJ;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xB3C4E0", Offset = "0xB3AAE0", VA = "0x180B3C4E0")]
		public GGFEDJIDALH(global::ILBDKHKGGBK<T> BMFGKMDOFCF, int LBHJIDIAOEM, bool LMIPPCBLACH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x37D1E60", Offset = "0x37D0460", VA = "0x1837D1E60")]
		public global::ILBDKHKGGBK<T>.CILCNJMINIA CBILBBMABKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x37D1F50", Offset = "0x37D0550", VA = "0x1837D1F50", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x37D1F50", Offset = "0x37D0550", VA = "0x1837D1F50", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class CILCNJMINIA : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly global::ILBDKHKGGBK<T> CEMHFDNCLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly int GMBEENHMDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int EIOGGANKALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly bool IDKMNNKOHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool EPOLFPCAMDH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T BMLOECHOMBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3651CC0", Offset = "0x36502C0", VA = "0x183651CC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3651E60", Offset = "0x3650460", VA = "0x183651E60", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3652080", Offset = "0x3650680", VA = "0x183652080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x36522C0", Offset = "0x36508C0", VA = "0x1836522C0")]
		public CILCNJMINIA(global::ILBDKHKGGBK<T> BMFGKMDOFCF, int LBHJIDIAOEM, bool LMIPPCBLACH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3651BA0", Offset = "0x36501A0", VA = "0x183651BA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3651D60", Offset = "0x3650360", VA = "0x183651D60", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FNMHJLCOHGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x63F080", Offset = "0x63E480")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public FNMHJLCOHGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3E502B0", Offset = "0x3E4E8B0", VA = "0x183E502B0")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly T[] IEJAICCFOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int EIOGGANKALH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JGLGMMFMOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3280560", Offset = "0x327EB60", VA = "0x183280560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T BMLOECHOMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3280530", Offset = "0x327EB30", VA = "0x183280530")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T MJCEALLDFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3280500", Offset = "0x327EB00", VA = "0x183280500")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x32803D0", Offset = "0x327E9D0", VA = "0x1832803D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ELOKHHJFINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9589A0", Offset = "0x956FA0", VA = "0x1809589A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x32804E0", Offset = "0x327EAE0", VA = "0x1832804E0")]
	private static int LBOLLNKDDHK(int EBBLFLFCHFB, int JKABHKIANJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x32805D0", Offset = "0x327EBD0", VA = "0x1832805D0")]
	public ILBDKHKGGBK(int JLMAIAGOBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3280650", Offset = "0x327EC50", VA = "0x183280650")]
	public ILBDKHKGGBK(int JLMAIAGOBFJ, Func<T> HNFBBNLNLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x32808C0", Offset = "0x327EEC0", VA = "0x1832808C0")]
	public ILBDKHKGGBK(T[] NPOACONIGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3280200", Offset = "0x327E800", VA = "0x183280200")]
	public void AOEODEEJBLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3280430", Offset = "0x327EA30", VA = "0x183280430")]
	public IEnumerable<T> LBLHKFOJANE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3280230", Offset = "0x327E830", VA = "0x183280230")]
	public global::ILBDKHKGGBK<T>.CILCNJMINIA CBILBBMABKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x32805A0", Offset = "0x327EBA0", VA = "0x1832805A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x32805A0", Offset = "0x327EBA0", VA = "0x1832805A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JABBLDIHNBJ
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x33D3AE0", Offset = "0x33D20E0", VA = "0x1833D3AE0")]
	public static global::ILBDKHKGGBK<T> OJKIKDBCCPC<T>(int JLMAIAGOBFJ, Func<T> HNFBBNLNLFO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class BHBEKOBPLLH<TData> : IHHGNGPIMCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly string IKGNNGKHLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly TData NAFFLJHMBID;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "5")]
	public override string CNNOKHADNMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3F9AAD0", Offset = "0x3F990D0", VA = "0x183F9AAD0")]
	internal BHBEKOBPLLH(string DIDMFBHHIEC, in TData JIHCLPECHIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KGHJPHOMKFK
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1D41080", Offset = "0x1D3F680", VA = "0x181D41080")]
	public static global::BHBEKOBPLLH<ABCENELPPGI> OJKIKDBCCPC(string DIDMFBHHIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x30904B0", Offset = "0x308EAB0", VA = "0x1830904B0")]
	public static global::BHBEKOBPLLH<TData> OJKIKDBCCPC<TData>(string DIDMFBHHIEC, in TData JIHCLPECHIB)
	{
		return null;
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
