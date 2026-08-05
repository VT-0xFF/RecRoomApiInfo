using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DFHDGKMBOJI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x638E0E0", Offset = "0x638C8E0", VA = "0x18638E0E0")]
	public static DFBIFPLDNNH JMOOMJHDBEG([In] this Color PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x638E0B0", Offset = "0x638C8B0", VA = "0x18638E0B0")]
	public static Color AEDPLFCAHJC(this DFBIFPLDNNH PIEBBHMNEOG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x638E160", Offset = "0x638C960", VA = "0x18638E160")]
	public static Color? MJALPDGLPCA(this DFBIFPLDNNH PIEBBHMNEOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IMEOOAKEPGM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x638E1E0", Offset = "0x638C9E0", VA = "0x18638E1E0")]
	public static Quaternion FOKJJHCKKOA(DDNPPCHDIKB FCHBDAMJEHN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x638E4A0", Offset = "0x638CCA0", VA = "0x18638E4A0")]
	public static PHLIOKLOOLO LHPPCLNBLKA(Quaternion HPOIOFEMAOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x638E400", Offset = "0x638CC00", VA = "0x18638E400")]
	public static Quaternion IBFEAABIEEO(PHLIOKLOOLO FCHBDAMJEHN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PJPOPBHGFKP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x638E840", Offset = "0x638D040", VA = "0x18638E840")]
	public static NMCFPJMJEGG JMOOMJHDBEG([In] this Quaternion PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x638E7D0", Offset = "0x638CFD0", VA = "0x18638E7D0")]
	public static Quaternion AEDPLFCAHJC(this NMCFPJMJEGG PIEBBHMNEOG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x638E8C0", Offset = "0x638D0C0", VA = "0x18638E8C0")]
	public static Quaternion? MJALPDGLPCA(this NMCFPJMJEGG PIEBBHMNEOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PJPIHJOEEPL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x638E760", Offset = "0x638CF60", VA = "0x18638E760")]
	public static PNAEPEBDFOG JMOOMJHDBEG([In] this Vector2 PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x638E700", Offset = "0x638CF00", VA = "0x18638E700")]
	public static Vector2 AEDPLFCAHJC(this PNAEPEBDFOG PIEBBHMNEOG)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OGNKHHLHKHD
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x638E600", Offset = "0x638CE00", VA = "0x18638E600")]
	public static PHLIOKLOOLO JMOOMJHDBEG([In] this Vector3 PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x638E590", Offset = "0x638CD90", VA = "0x18638E590")]
	public static Vector3 AEDPLFCAHJC(this PHLIOKLOOLO PIEBBHMNEOG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x638E670", Offset = "0x638CE70", VA = "0x18638E670")]
	public static Vector3? MJALPDGLPCA(this PHLIOKLOOLO PIEBBHMNEOG)
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
