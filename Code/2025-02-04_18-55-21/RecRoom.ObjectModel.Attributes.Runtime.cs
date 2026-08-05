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
public class GCAKDFIEPKJ : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PFIIJLHPFJF
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MONEJBBHJAA : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5AB0", Offset = "0x1DF48B0", VA = "0x181DF5AB0")]
	public MONEJBBHJAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct GFJFMODCEFI : IEquatable<GFJFMODCEFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly ulong HKHKCHJEPKB;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x73C6360", Offset = "0x73C5160", VA = "0x1873C6360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1EDC900", Offset = "0x1EDB700", VA = "0x181EDC900", Slot = "4")]
	public bool Equals(GFJFMODCEFI LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x73C62D0", Offset = "0x73C50D0", VA = "0x1873C62D0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A8A0", Offset = "0x2B496A0", VA = "0x182B4A8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PKKFCEHIJMC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
	public PKKFCEHIJMC()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PINIBFHHCLA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public PINIBFHHCLA()
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
