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
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x60A0D60", Offset = "0x609F760", VA = "0x1860A0D60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6926F0", Offset = "0x6910F0", VA = "0x1806926F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x812880", Offset = "0x811280", VA = "0x180812880")]
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
	[Cpp2IlInjected.Address(RVA = "0x88CB80", Offset = "0x88B580", VA = "0x18088CB80")]
	public BMAGIOMGAFJ(params IDisposable[] NPOACONIGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xECBC90", Offset = "0xECA690", VA = "0x180ECBC90")]
	public static BMAGIOMGAFJ OJKIKDBCCPC(params IDisposable[] NPOACONIGFC)
	{
		return default(BMAGIOMGAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60A0490", Offset = "0x609EE90", VA = "0x1860A0490", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2585120", Offset = "0x2583B20", VA = "0x182585120")]
	public HNHEPJNIBFL(IDisposable BMNJCJDHIKF, in T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x273CC10", Offset = "0x273B610", VA = "0x18273CC10")]
	public static global::HNHEPJNIBFL<U> LMCAGOEOBGO<U>(in global::HNHEPJNIBFL<T> BMNJCJDHIKF, in U MAKFNMHIJIF)
	{
		return default(global::HNHEPJNIBFL<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x431B630", Offset = "0x431A030", VA = "0x18431B630", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HBOIJGMFCGG
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24FFC20", Offset = "0x24FE620", VA = "0x1824FFC20")]
	public static global::HNHEPJNIBFL<T> OJKIKDBCCPC<T>(IDisposable BMNJCJDHIKF, in T MAKFNMHIJIF)
	{
		return default(global::HNHEPJNIBFL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1C54920", Offset = "0x1C53320", VA = "0x181C54920")]
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
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00")]
	public static KNDOHKEKBHA OOFEPMABPOC(Type MCLMFJEAHEC, [Optional] string MENHCPFOPMD, [Optional] string JBHCHLIGIIF, bool FKLEINGPDND = false)
	{
		return default(KNDOHKEKBHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00")]
	public static KNDOHKEKBHA OOFEPMABPOC<T>([Optional] string MENHCPFOPMD, [Optional] string JBHCHLIGIIF, bool FKLEINGPDND = false)
	{
		return default(KNDOHKEKBHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60A0C10", Offset = "0x609F610", VA = "0x1860A0C10")]
	protected IHHGNGPIMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string CNNOKHADNMO();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60A09A0", Offset = "0x609F3A0", VA = "0x1860A09A0", Slot = "6")]
	public virtual string LDFILJMGGMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60A05B0", Offset = "0x609EFB0", VA = "0x1860A05B0")]
	public void ANFGPJLMLOG(StringBuilder CCLNHPOEGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60A0BB0", Offset = "0x609F5B0", VA = "0x1860A0BB0")]
	public void POBCCBCJFMC(StringBuilder CCLNHPOEGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60A0830", Offset = "0x609F230", VA = "0x1860A0830")]
	public void BKJLEOGKMPE(StringBuilder CCLNHPOEGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60A0AC0", Offset = "0x609F4C0", VA = "0x1860A0AC0")]
	public void PJIHDMBNACB(StringBuilder CCLNHPOEGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60A0A20", Offset = "0x609F420", VA = "0x1860A0A20")]
	public static void MNCFGFBMIDF(StringBuilder CCLNHPOEGCA, string GJEBOKDBHAO, string JMBLDDGLJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x67E670", Offset = "0x67D070", VA = "0x18067E670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class INIGDLLJDDH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60A0C80", Offset = "0x609F680", VA = "0x1860A0C80")]
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
	[Cpp2IlInjected.Address(RVA = "0x31D72E0", Offset = "0x31D5CE0", VA = "0x1831D72E0")]
	private FGDKHEOLKOI(in TErr EKEJANBAMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x31D7210", Offset = "0x31D5C10", VA = "0x1831D7210")]
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
	[Cpp2IlInjected.Address(RVA = "0x60A0DF0", Offset = "0x609F7F0", VA = "0x1860A0DF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x21FED80", Offset = "0x21FD780", VA = "0x1821FED80")]
	private IGEKMKBGKBJ(in TOk CCPNFJDNEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x21FECB0", Offset = "0x21FD6B0", VA = "0x1821FECB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2211B90", Offset = "0x2210590", VA = "0x182211B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KLNCGMHOKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2212590", Offset = "0x2210F90", VA = "0x182212590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x22165F0", Offset = "0x2214FF0", VA = "0x1822165F0")]
	internal IKEELLNFFOM(in TErr EKEJANBAMHK, in TOk CCPNFJDNEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x22152C0", Offset = "0x2213CC0", VA = "0x1822152C0")]
	public static global::IKEELLNFFOM<TOk, TErr> PBIHFDLJLAD(in TErr EKEJANBAMHK)
	{
		return default(global::IKEELLNFFOM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x22128B0", Offset = "0x22112B0", VA = "0x1822128B0")]
	public static global::IKEELLNFFOM<TOk, TErr> ENGJOGPJOBB(in TOk CCPNFJDNEDL)
	{
		return default(global::IKEELLNFFOM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x273D410", Offset = "0x273BE10", VA = "0x18273D410")]
	public global::IKEELLNFFOM<TOk, UErr> KDKBDHEJEEM<UErr>()
	{
		return default(global::IKEELLNFFOM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x273DD00", Offset = "0x273C700", VA = "0x18273DD00")]
	public global::IKEELLNFFOM<UOk, TErr> OLKPJFCGKHP<UOk>()
	{
		return default(global::IKEELLNFFOM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x273D120", Offset = "0x273BB20", VA = "0x18273D120")]
	public global::IKEELLNFFOM<UOk, TErr> AAOJLPJNJMG<UOk>()
	{
		return default(global::IKEELLNFFOM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x273D340", Offset = "0x273BD40", VA = "0x18273D340")]
	public global::IKEELLNFFOM<TOk, UErr> BGJANPFKGJL<UErr>()
	{
		return default(global::IKEELLNFFOM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2214F40", Offset = "0x2213940", VA = "0x182214F40")]
	public global::IKEELLNFFOM<ABCENELPPGI, TErr> OFABNNJNMMH()
	{
		return default(global::IKEELLNFFOM<ABCENELPPGI, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2213BD0", Offset = "0x22125D0", VA = "0x182213BD0")]
	public static bool GBIPOJBPNDJ(in global::IKEELLNFFOM<TOk, TErr> FFMFLKJEKLP, in global::IKEELLNFFOM<TOk, TErr> PHDGNGLFBBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2213040", Offset = "0x2211A40", VA = "0x182213040", Slot = "4")]
	public bool Equals(global::IKEELLNFFOM<TOk, TErr> OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2213600", Offset = "0x2212000", VA = "0x182213600", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2214DD0", Offset = "0x22137D0", VA = "0x182214DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x22161B0", Offset = "0x2214BB0", VA = "0x1822161B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JGINGEFKEII
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2606930", Offset = "0x2605330", VA = "0x182606930")]
	public static global::IKEELLNFFOM<TOk, TErr> OPGMGLFPBIP<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, in TOk CCPNFJDNEDL)
	{
		return default(global::IKEELLNFFOM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2607890", Offset = "0x2606290", VA = "0x182607890")]
	public static global::IKEELLNFFOM<ABCENELPPGI, TErr> OPGMGLFPBIP<TErr>(this in global::IKEELLNFFOM<ABCENELPPGI, TErr> DKOFBKPNBJK)
	{
		return default(global::IKEELLNFFOM<ABCENELPPGI, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2606930", Offset = "0x2605330", VA = "0x182606930")]
	public static global::IKEELLNFFOM<TOk, TErr> GCHJJLAMGFL<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, in TErr EKEJANBAMHK)
	{
		return default(global::IKEELLNFFOM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2606B50", Offset = "0x2605550", VA = "0x182606B50")]
	public static TOk JMPIKDDOIAM<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2607C60", Offset = "0x2606660", VA = "0x182607C60")]
	[AsyncStateMachine(typeof(EHLCFKPIFDA))]
	public static Task<TOk> PKBDBKKCFLJ<TOk, TErr>(this Task<global::IKEELLNFFOM<TOk, TErr>> DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2606740", Offset = "0x2605140", VA = "0x182606740")]
	public static TErr FMKBJPDHLBF<TErr, TOk>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2606D60", Offset = "0x2605760", VA = "0x182606D60")]
	public static bool LDLGFHEBOMM<TOk, TErr, UErr, UOk>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out global::IKEELLNFFOM<UOk, UErr> IBPHJGLNIHH) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2606AA0", Offset = "0x26054A0", VA = "0x182606AA0")]
	public static bool JEELPIALIGJ<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out TOk CCPNFJDNEDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x26077B0", Offset = "0x26061B0", VA = "0x1826077B0")]
	public static bool NBAPHLFMFNN<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out TErr EKEJANBAMHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2607830", Offset = "0x2606230", VA = "0x182607830")]
	public static bool NIDEADEICAP<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out TOk CCPNFJDNEDL, out TErr EKEJANBAMHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2606A00", Offset = "0x2605400", VA = "0x182606A00")]
	public static bool IDNFACNMIOH<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out TOk CCPNFJDNEDL, out global::IKEELLNFFOM<TOk, TErr> IBPHJGLNIHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2607210", Offset = "0x2605C10", VA = "0x182607210")]
	public static bool LDLGFHEBOMM<TOk, TErr, UErr, UOk>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out TOk CCPNFJDNEDL, out global::IKEELLNFFOM<UOk, UErr> IBPHJGLNIHH) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x26079A0", Offset = "0x26063A0", VA = "0x1826079A0")]
	public static bool PAFDMKMANKI<TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, out TOk CCPNFJDNEDL, out global::IKEELLNFFOM<ABCENELPPGI, TErr> IBPHJGLNIHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x26074B0", Offset = "0x2605EB0", VA = "0x1826074B0")]
	public static global::IKEELLNFFOM<UOk, UErr> MAKBEADPGCH<UOk, UErr, TOk, TErr>(this in global::IKEELLNFFOM<TOk, TErr> DKOFBKPNBJK, in global::IKEELLNFFOM<UOk, UErr> IBHBGBEBHJM) where TOk : UOk where TErr : UErr
	{
		return default(global::IKEELLNFFOM<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2606490", Offset = "0x2604E90", VA = "0x182606490")]
	public static global::IKEELLNFFOM<TOk[], TErr> BJJELHFPJDP<TOk, TErr>(this IEnumerable<global::IKEELLNFFOM<TOk, TErr>> DKOFBKPNBJK)
	{
		return default(global::IKEELLNFFOM<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1722EA0", Offset = "0x17218A0", VA = "0x181722EA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D6BD80", Offset = "0x2D6A780", VA = "0x182D6BD80")]
	public static global::IKEELLNFFOM<TOk, T> OPGMGLFPBIP<TOk>(in TOk CCPNFJDNEDL)
	{
		return default(global::IKEELLNFFOM<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x28A6BE0", Offset = "0x28A55E0", VA = "0x1828A6BE0")]
	public static global::IKEELLNFFOM<ABCENELPPGI, T> OPGMGLFPBIP()
	{
		return default(global::IKEELLNFFOM<ABCENELPPGI, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2D6BCC0", Offset = "0x2D6A6C0", VA = "0x182D6BCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A76EC0", Offset = "0x2A758C0", VA = "0x182A76EC0")]
		public GGFEDJIDALH(global::ILBDKHKGGBK<T> BMFGKMDOFCF, int LBHJIDIAOEM, bool LMIPPCBLACH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2A76D90", Offset = "0x2A75790", VA = "0x182A76D90")]
		public global::ILBDKHKGGBK<T>.CILCNJMINIA CBILBBMABKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2A76E80", Offset = "0x2A75880", VA = "0x182A76E80", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2A76E80", Offset = "0x2A75880", VA = "0x182A76E80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x289EBE0", Offset = "0x289D5E0", VA = "0x18289EBE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x289ED80", Offset = "0x289D780", VA = "0x18289ED80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x289EFA0", Offset = "0x289D9A0", VA = "0x18289EFA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x289F1E0", Offset = "0x289DBE0", VA = "0x18289F1E0")]
		public CILCNJMINIA(global::ILBDKHKGGBK<T> BMFGKMDOFCF, int LBHJIDIAOEM, bool LMIPPCBLACH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x289EAC0", Offset = "0x289D4C0", VA = "0x18289EAC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x289EC80", Offset = "0x289D680", VA = "0x18289EC80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x638B70", Offset = "0x637F70")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public FNMHJLCOHGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3258370", Offset = "0x3256D70", VA = "0x183258370")]
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
		[Cpp2IlInjected.Address(RVA = "0x24B1D30", Offset = "0x24B0730", VA = "0x1824B1D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T BMLOECHOMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x24B1D00", Offset = "0x24B0700", VA = "0x1824B1D00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T MJCEALLDFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x24B1CD0", Offset = "0x24B06D0", VA = "0x1824B1CD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x24B1BA0", Offset = "0x24B05A0", VA = "0x1824B1BA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ELOKHHJFINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8DDBC0", Offset = "0x8DC5C0", VA = "0x1808DDBC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x24B1CB0", Offset = "0x24B06B0", VA = "0x1824B1CB0")]
	private static int LBOLLNKDDHK(int EBBLFLFCHFB, int JKABHKIANJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24B1DA0", Offset = "0x24B07A0", VA = "0x1824B1DA0")]
	public ILBDKHKGGBK(int JLMAIAGOBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24B1E20", Offset = "0x24B0820", VA = "0x1824B1E20")]
	public ILBDKHKGGBK(int JLMAIAGOBFJ, Func<T> HNFBBNLNLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24B2090", Offset = "0x24B0A90", VA = "0x1824B2090")]
	public ILBDKHKGGBK(T[] NPOACONIGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x24B19D0", Offset = "0x24B03D0", VA = "0x1824B19D0")]
	public void AOEODEEJBLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x24B1C00", Offset = "0x24B0600", VA = "0x1824B1C00")]
	public IEnumerable<T> LBLHKFOJANE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24B1A00", Offset = "0x24B0400", VA = "0x1824B1A00")]
	public global::ILBDKHKGGBK<T>.CILCNJMINIA CBILBBMABKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x24B1D70", Offset = "0x24B0770", VA = "0x1824B1D70", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24B1D70", Offset = "0x24B0770", VA = "0x1824B1D70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JABBLDIHNBJ
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x26052A0", Offset = "0x2603CA0", VA = "0x1826052A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "5")]
	public override string CNNOKHADNMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x34210E0", Offset = "0x341FAE0", VA = "0x1834210E0")]
	internal BHBEKOBPLLH(string DIDMFBHHIEC, in TData JIHCLPECHIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KGHJPHOMKFK
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60A0CF0", Offset = "0x609F6F0", VA = "0x1860A0CF0")]
	public static global::BHBEKOBPLLH<ABCENELPPGI> OJKIKDBCCPC(string DIDMFBHHIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x22A2BE0", Offset = "0x22A15E0", VA = "0x1822A2BE0")]
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
