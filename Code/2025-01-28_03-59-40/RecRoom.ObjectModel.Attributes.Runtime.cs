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
public class KINLBDKFIMP : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KGFENDNHILH
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NIAAHCBELIH : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7970", Offset = "0x1DC6B70", VA = "0x181DC7970")]
	public NIAAHCBELIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct GPKICAEBCOC : IEquatable<GPKICAEBCOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly ulong ELOFPHHKCIM;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7367260", Offset = "0x7366460", VA = "0x187367260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6800", Offset = "0x1EB5A00", VA = "0x181EB6800", Slot = "4")]
	public bool Equals(GPKICAEBCOC JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x73671D0", Offset = "0x73663D0", VA = "0x1873671D0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A5E0", Offset = "0x2B297E0", VA = "0x182B2A5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FNJDBJHKMGO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
	public FNJDBJHKMGO()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ODLABCMJMIE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public ODLABCMJMIE()
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
