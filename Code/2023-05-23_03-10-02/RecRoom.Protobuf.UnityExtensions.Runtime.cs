using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CIIHGJLIAIH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x170DDE0", Offset = "0x170D1E0", VA = "0x18170DDE0")]
	public static GDFFOLEGBGJ AKAHDAOKFEM(this in Color LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x170DE80", Offset = "0x170D280", VA = "0x18170DE80")]
	public static Color INEKOHCFCOE(this GDFFOLEGBGJ LGKAJJKAMAG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x170DF50", Offset = "0x170D350", VA = "0x18170DF50")]
	public static Color? MAEHBFELFMK(this GDFFOLEGBGJ LGKAJJKAMAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EKIKNFGENDO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x170E070", Offset = "0x170D470", VA = "0x18170E070")]
	public static CKMKOKOMNCI AKAHDAOKFEM(this in Quaternion LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x170E110", Offset = "0x170D510", VA = "0x18170E110")]
	public static Quaternion INEKOHCFCOE(this CKMKOKOMNCI LGKAJJKAMAG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x170E1E0", Offset = "0x170D5E0", VA = "0x18170E1E0")]
	public static Quaternion? MAEHBFELFMK(this CKMKOKOMNCI LGKAJJKAMAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GLEJPGGLDJO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x170E590", Offset = "0x170D990", VA = "0x18170E590")]
	public static Quaternion CHCADMEFOFC(ANJLGBABNCP KOCKBILIHNN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x170E7B0", Offset = "0x170DBB0", VA = "0x18170E7B0")]
	public static GFFPGLPJHIF NGDBKOJFABK(Quaternion DLAOOLKJAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x170E4F0", Offset = "0x170D8F0", VA = "0x18170E4F0")]
	public static Quaternion AIBJLPFNNGJ(GFFPGLPJHIF KOCKBILIHNN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GHJAKCKPAMJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x170E300", Offset = "0x170D700", VA = "0x18170E300")]
	public static GFFPGLPJHIF AKAHDAOKFEM(this in Vector3 LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x170E390", Offset = "0x170D790", VA = "0x18170E390")]
	public static Vector3 INEKOHCFCOE(this GFFPGLPJHIF LGKAJJKAMAG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x170E430", Offset = "0x170D830", VA = "0x18170E430")]
	public static Vector3? MAEHBFELFMK(this GFFPGLPJHIF LGKAJJKAMAG)
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
