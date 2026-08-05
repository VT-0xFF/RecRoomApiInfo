using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Conditional("UNITY_EDITOR")]
[AttributeUsage(AttributeTargets.Method)]
public class LIFEHOAHICI : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FPNOOOBLMIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LGOEDLFAKIN : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2253320", Offset = "0x2251920", VA = "0x182253320")]
	public LGOEDLFAKIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct CKAEHLJNHBB : IEquatable<CKAEHLJNHBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly ulong IBMJNNAJGNM;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8159C00", Offset = "0x8158200", VA = "0x188159C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23556E0", Offset = "0x2353CE0", VA = "0x1823556E0", Slot = "4")]
	public bool Equals(CKAEHLJNHBB HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8159B70", Offset = "0x8158170", VA = "0x188159B70", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3059570", Offset = "0x3057B70", VA = "0x183059570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MKAIFECAAGF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
	public MKAIFECAAGF()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ILCOKFFEKFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ILCOKFFEKFJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
