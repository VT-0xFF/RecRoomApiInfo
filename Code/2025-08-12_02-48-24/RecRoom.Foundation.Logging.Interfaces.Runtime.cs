using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class DHOMNFBLIOG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
	public DHOMNFBLIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class CPELMMHKDGN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8476870", Offset = "0x8474E70", VA = "0x188476870")]
	public CPELMMHKDGN(int MLMBLBFOLPC, int MAALDANNCBI, int BBHLFEHECGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class BCINLFCBMLK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
	public BCINLFCBMLK(bool GJELDCFHGMM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class EJAKBCPOPHJ : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8476DA0", Offset = "0x84753A0", VA = "0x188476DA0")]
	public EJAKBCPOPHJ(string DJFMCHMDHGK, string OINDFPIKPLL = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class NLLIDJLIDIE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24C3360", Offset = "0x24C1960", VA = "0x1824C3360")]
	public NLLIDJLIDIE(int FKMNCAKIOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum MNJIBCLEONI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	NonNetworked = 1,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Incoming = 2,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Outgoing = 4,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Suppressed = 8,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	FastForward = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	CacheRemove = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Default = 0x3F,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	All = 0x3F
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DKHJPBKAEFJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DHHEIGGAIIJ<T> : DKHJPBKAEFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEEGCONLPEB([In] HKGLAFGIPMJ JFDIFLBCLEH, T FKMNCAKIOFK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NHOENFDKKHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DACLOFBDGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int OJLGMFDDGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JOPFJMCBNNG(Type EHLAHNIAPLD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNBMJNFOGPL(NativeParallelHashMap<int, LKOMLBJPOKB> KNPJHKKMLOF, NativeArray<byte> DAJAOHIJHHL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BDLPAEPPGOE
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class LKKJOAACEIF
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class EFAPEKADENO<T> : HCOCNPCBMOB<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A126E0", Offset = "0x4A10CE0", VA = "0x184A126E0")]
	protected EFAPEKADENO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class HCOCNPCBMOB<T> : DHHEIGGAIIJ<T>, DKHJPBKAEFJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x50A3430", Offset = "0x50A1A30", VA = "0x1850A3430")]
	public void LEEGCONLPEB([In] HKGLAFGIPMJ JFDIFLBCLEH, T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected HCOCNPCBMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x50A3410", Offset = "0x50A1A10", VA = "0x1850A3410", Slot = "4")]
	private void HLLAIJFPNNA([In] HKGLAFGIPMJ JFDIFLBCLEH, T FKMNCAKIOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class GGDIHFLELHE<T> : DHHEIGGAIIJ<NativeArray<T>>, DKHJPBKAEFJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1360", Offset = "0x4FDF960", VA = "0x184FE1360")]
	public void LEEGCONLPEB([In] HKGLAFGIPMJ JFDIFLBCLEH, NativeArray<T> FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3F1E3A0", Offset = "0x3F1C9A0", VA = "0x183F1E3A0")]
	public static ReadOnlySpan<T> NLBMKHIOOMI<T>(NativeArray<T> OHHBFAGELLA) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected GGDIHFLELHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1330", Offset = "0x4FDF930", VA = "0x184FE1330", Slot = "4")]
	private void ALEJGJIFLLD([In] HKGLAFGIPMJ JFDIFLBCLEH, NativeArray<T> FKMNCAKIOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BDDGFGLCNFK : DHHEIGGAIIJ<BDDGFGLCNFK.IILHFFEAPJE>, DKHJPBKAEFJ
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct IILHFFEAPJE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	public void LEEGCONLPEB([In] HKGLAFGIPMJ JFDIFLBCLEH, IILHFFEAPJE FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BDDGFGLCNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	private void GJMDIGBPIGG([In] HKGLAFGIPMJ JFDIFLBCLEH, IILHFFEAPJE FKMNCAKIOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EHCPHFAFPDJ : DHHEIGGAIIJ<string>, DKHJPBKAEFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly EHCPHFAFPDJ DOBPPELCKJD;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84769D0", Offset = "0x8474FD0", VA = "0x1884769D0")]
	public void LEEGCONLPEB([In] HKGLAFGIPMJ JFDIFLBCLEH, string FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public EHCPHFAFPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84769C0", Offset = "0x8474FC0", VA = "0x1884769C0", Slot = "4")]
	private void KEOMFIIPBPA([In] HKGLAFGIPMJ JFDIFLBCLEH, string FKMNCAKIOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class MODNDPPCNGP<T> : CKIONENBABO<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A126E0", Offset = "0x4A10CE0", VA = "0x184A126E0")]
	protected MODNDPPCNGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class CKIONENBABO<T> : DHHEIGGAIIJ<T>, DKHJPBKAEFJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC27E0", Offset = "0x6EC0DE0", VA = "0x186EC27E0")]
	public void LEEGCONLPEB([In] HKGLAFGIPMJ JFDIFLBCLEH, T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected CKIONENBABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x50A3410", Offset = "0x50A1A10", VA = "0x1850A3410", Slot = "4")]
	private void HLLAIJFPNNA([In] HKGLAFGIPMJ JFDIFLBCLEH, T FKMNCAKIOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HKGLAFGIPMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct EFIJJNGGBMI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HKGLAFGIPMJ JFDIFLBCLEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int GAEBCMMDLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int MEBPJALCCIP;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6310AC0", Offset = "0x630F0C0", VA = "0x186310AC0")]
		public EFIJJNGGBMI(HKGLAFGIPMJ JFDIFLBCLEH, int GAEBCMMDLKL, int MEBPJALCCIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8476960", Offset = "0x8474F60", VA = "0x188476960")]
		public EFIJJNGGBMI JIEHPDGPMIE(ReadOnlySpan<byte> DAJAOHIJHHL)
		{
			return default(EFIJJNGGBMI);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x44979D0", Offset = "0x4495FD0", VA = "0x1844979D0")]
		public EFIJJNGGBMI JIEHPDGPMIE<T>(T DAJAOHIJHHL) where T : struct
		{
			return default(EFIJJNGGBMI);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84768C0", Offset = "0x8474EC0", VA = "0x1884768C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private NHOENFDKKHD MAHKAFHEJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, LKOMLBJPOKB> KNPJHKKMLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> DAJAOHIJHHL;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84772B0", Offset = "0x84758B0", VA = "0x1884772B0")]
	public HKGLAFGIPMJ(NHOENFDKKHD MAHKAFHEJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8476FF0", Offset = "0x84755F0", VA = "0x188476FF0")]
	public int KJBAHDBLCHJ(DKHJPBKAEFJ KLAOHOGIDJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8476F00", Offset = "0x8475500", VA = "0x188476F00")]
	public EFIJJNGGBMI GDEAKPFLPPL(DKHJPBKAEFJ KLAOHOGIDJA)
	{
		return default(EFIJJNGGBMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8476E50", Offset = "0x8475450", VA = "0x188476E50")]
	public EFIJJNGGBMI GDEAKPFLPPL(int JECGJLAHMMP)
	{
		return default(EFIJJNGGBMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8477180", Offset = "0x8475780", VA = "0x188477180")]
	public void NMMCFIGJEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84770E0", Offset = "0x84756E0", VA = "0x1884770E0")]
	public HKGLAFGIPMJ NEPOCHBBDNF()
	{
		return default(HKGLAFGIPMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8476DF0", Offset = "0x84753F0", VA = "0x188476DF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HPMKLNEIPHI
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE20C0", Offset = "0x3DE06C0", VA = "0x183DE20C0")]
	public static HKGLAFGIPMJ KMLBEHGKDFG<T>([In] this HKGLAFGIPMJ JFDIFLBCLEH, DHHEIGGAIIJ<T> KLAOHOGIDJA, T FKMNCAKIOFK)
	{
		return default(HKGLAFGIPMJ);
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
