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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class CELKAGMJIMB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
	public CELKAGMJIMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class ICNJCJKOMMN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8513BE0", Offset = "0x85121E0", VA = "0x188513BE0")]
	public ICNJCJKOMMN(int KCJLCGFEBMJ, int EEDEAMIAONK, int PKBFJNIOFKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class FNOKAJECPOA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
	public FNOKAJECPOA(bool EOBCEKOEOAB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class OFICODGPNIN : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8513C30", Offset = "0x8512230", VA = "0x188513C30")]
	public OFICODGPNIN(string NDIENANOGEK, string NGPLKKDGJMB = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class AFIINPOHKKO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x252DAF0", Offset = "0x252C0F0", VA = "0x18252DAF0")]
	public AFIINPOHKKO(int KOPHBHGIACG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum NBNENBOIAOH
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
public interface KHMIOIBFFKH
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PLJLHBHHOHL<T> : KHMIOIBFFKH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JENBMHHDBON([In] GIMEACGKDIN OLOJLFEGEJO, T KOPHBHGIACG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BGJNGFMAKIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool APGJJIGAFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int MIECALKCJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BINNNGAAOMI(Type GPEIAHGICNA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EEDACAMHFFP(NativeParallelHashMap<int, NDDIGIFKAJC> ICKFEKPLGLA, NativeArray<byte> CDDIADBJAOB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HBADCMGDADL
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class HPICGNMOCFM
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class HNHOGNJJMBL<T> : JHJJEAKJHHB<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4620370", Offset = "0x461E970", VA = "0x184620370")]
	protected HNHOGNJJMBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class JHJJEAKJHHB<T> : PLJLHBHHOHL<T>, KHMIOIBFFKH where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4B60FE0", Offset = "0x4B5F5E0", VA = "0x184B60FE0")]
	public void JENBMHHDBON([In] GIMEACGKDIN OLOJLFEGEJO, T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected JHJJEAKJHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B61290", Offset = "0x4B5F890", VA = "0x184B61290", Slot = "4")]
	private void OHFMLBFEAGM([In] GIMEACGKDIN OLOJLFEGEJO, T KOPHBHGIACG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class EDMBMKLLKON<T> : PLJLHBHHOHL<NativeArray<T>>, KHMIOIBFFKH where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B25260", Offset = "0x4B23860", VA = "0x184B25260")]
	public void JENBMHHDBON([In] GIMEACGKDIN OLOJLFEGEJO, NativeArray<T> KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3F55CF0", Offset = "0x3F542F0", VA = "0x183F55CF0")]
	public static ReadOnlySpan<T> ALAACKFICDK<T>(NativeArray<T> GHKPAFFMJAO) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected EDMBMKLLKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B25230", Offset = "0x4B23830", VA = "0x184B25230", Slot = "4")]
	private void GEHGGJGMANP([In] GIMEACGKDIN OLOJLFEGEJO, NativeArray<T> KOPHBHGIACG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KMCMFDHNDAK : PLJLHBHHOHL<KMCMFDHNDAK.EFFLLCHAJPA>, KHMIOIBFFKH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct EFFLLCHAJPA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	public void JENBMHHDBON([In] GIMEACGKDIN OLOJLFEGEJO, EFFLLCHAJPA KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public KMCMFDHNDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	private void DPBGEANAOEH([In] GIMEACGKDIN OLOJLFEGEJO, EFFLLCHAJPA KOPHBHGIACG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HMNCADNAHEB : PLJLHBHHOHL<string>, KHMIOIBFFKH
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly HMNCADNAHEB EHBCEBDHHPE;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8513810", Offset = "0x8511E10", VA = "0x188513810")]
	public void JENBMHHDBON([In] GIMEACGKDIN OLOJLFEGEJO, string KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public HMNCADNAHEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8513800", Offset = "0x8511E00", VA = "0x188513800", Slot = "4")]
	private void ABFOPDIIPFP([In] GIMEACGKDIN OLOJLFEGEJO, string KOPHBHGIACG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class BLBHLHDFHEO<T> : EMNPFIPLIOI<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4620370", Offset = "0x461E970", VA = "0x184620370")]
	protected BLBHLHDFHEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class EMNPFIPLIOI<T> : PLJLHBHHOHL<T>, KHMIOIBFFKH where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B611B0", Offset = "0x4B5F7B0", VA = "0x184B611B0")]
	public void JENBMHHDBON([In] GIMEACGKDIN OLOJLFEGEJO, T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected EMNPFIPLIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4B61290", Offset = "0x4B5F890", VA = "0x184B61290", Slot = "4")]
	private void OHFMLBFEAGM([In] GIMEACGKDIN OLOJLFEGEJO, T KOPHBHGIACG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GIMEACGKDIN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct GGFBJGHFIPE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly GIMEACGKDIN OLOJLFEGEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int BAEOEIOFMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int PFGFDODDPBC;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6370340", Offset = "0x636E940", VA = "0x186370340")]
		public GGFBJGHFIPE(GIMEACGKDIN OLOJLFEGEJO, int BAEOEIOFMPF, int PFGFDODDPBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85130F0", Offset = "0x85116F0", VA = "0x1885130F0")]
		public GGFBJGHFIPE JMEAKHBLOAN(ReadOnlySpan<byte> CDDIADBJAOB)
		{
			return default(GGFBJGHFIPE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x44E7320", Offset = "0x44E5920", VA = "0x1844E7320")]
		public GGFBJGHFIPE JMEAKHBLOAN<T>(T CDDIADBJAOB) where T : struct
		{
			return default(GGFBJGHFIPE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8513050", Offset = "0x8511650", VA = "0x188513050", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BGJNGFMAKIF NLGHBEJDCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, NDDIGIFKAJC> ICKFEKPLGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> CDDIADBJAOB;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8513610", Offset = "0x8511C10", VA = "0x188513610")]
	public GIMEACGKDIN(BGJNGFMAKIF NLGHBEJDCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8513520", Offset = "0x8511B20", VA = "0x188513520")]
	public int ODPONEENMNL(KHMIOIBFFKH CLMFOECLAFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8513200", Offset = "0x8511800", VA = "0x188513200")]
	public GGFBJGHFIPE AEDEJKMNEEE(KHMIOIBFFKH CLMFOECLAFP)
	{
		return default(GGFBJGHFIPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8513150", Offset = "0x8511750", VA = "0x188513150")]
	public GGFBJGHFIPE AEDEJKMNEEE(int MOBOCOMONEH)
	{
		return default(GGFBJGHFIPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x85133F0", Offset = "0x85119F0", VA = "0x1885133F0")]
	public void JOIKNHFPCOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8513350", Offset = "0x8511950", VA = "0x188513350")]
	public GIMEACGKDIN ICBGPFPDLLB()
	{
		return default(GIMEACGKDIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x85132F0", Offset = "0x85118F0", VA = "0x1885132F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HJOHIDDJIND
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC760", Offset = "0x3DEAD60", VA = "0x183DEC760")]
	public static GIMEACGKDIN MEFAAGOGBHI<T>([In] this GIMEACGKDIN OLOJLFEGEJO, PLJLHBHHOHL<T> CLMFOECLAFP, T KOPHBHGIACG)
	{
		return default(GIMEACGKDIN);
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
