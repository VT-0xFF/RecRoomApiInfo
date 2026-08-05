using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class OBFIFFFEDEJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x427430", Offset = "0x425E30", VA = "0x180427430")]
	public OBFIFFFEDEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class HEGANKDPCGE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x427430", Offset = "0x425E30", VA = "0x180427430")]
	public HEGANKDPCGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class NDFDPFGMNNN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x427430", Offset = "0x425E30", VA = "0x180427430")]
	public NDFDPFGMNNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class DLFAHOMBFPC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x427430", Offset = "0x425E30", VA = "0x180427430")]
	public DLFAHOMBFPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class OGNEIOICDKO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Type OKCIHKIDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x427440", Offset = "0x425E40", VA = "0x180427440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x53A190", Offset = "0x538B90", VA = "0x18053A190")]
	public OGNEIOICDKO(Type BPLJEGANNCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OGOOHGFNMJI
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OOJLFNPEAFM<T> : OGOOHGFNMJI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPPDHKMOANH(ref OJAIKHNILDO CEKLGHBGJKC, T MDAEJMIAMDO, NPLOEDANIMH CDNKGHCKBCJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CHODKOJOPNJ(ref BEAMCPEOHEF BCOHJFPIEAF, NPLOEDANIMH CDNKGHCKBCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NPLOEDANIMH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::OOJLFNPEAFM<T> FLKDGOOHFAD<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LDGNNMIIFOC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x202C490", Offset = "0x202AE90", VA = "0x18202C490")]
	public static global::OOJLFNPEAFM<T> MELKIAHBJEH<T>(this NPLOEDANIMH CAMPPHCBPFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CIKKGGLAGCK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x10FD3B0", Offset = "0x10FBDB0", VA = "0x1810FD3B0")]
	public CIKKGGLAGCK(string PANDMENIIKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BEAMCPEOHEF
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly ArraySegment<byte> GOKOKCONIKI;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly byte[] HLJLHCMPCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly byte[] LKPHIKGCGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private int EDGPLGCCLLN;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OJAIKHNILDO
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly byte[] FBLFODPCFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private byte[] EKANCEBKLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private int EDGPLGCCLLN;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x10FD420", Offset = "0x10FBE20", VA = "0x1810FD420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
