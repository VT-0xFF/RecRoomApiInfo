using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AKDGGCGGCKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAD10", Offset = "0x7EC9910", VA = "0x187ECAD10")]
	public static ProfilerCategory BHANLNFCEFN(string LPPDGJBEHBN)
	{
		return default(ProfilerCategory);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct NGDNLODCCFH : IEquatable<NGDNLODCCFH>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public readonly struct CEDEMIGPCJF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr OJGHLMOGICI;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7ECAD30", Offset = "0x7EC9930", VA = "0x187ECAD30")]
		internal CEDEMIGPCJF(IntPtr OJGHLMOGICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7ECAD20", Offset = "0x7EC9920", VA = "0x187ECAD20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal const ushort NIIPFKENEPC = 1;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly IntPtr OJGHLMOGICI;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAE30", Offset = "0x7EC9A30", VA = "0x187ECAE30")]
	public NGDNLODCCFH(ushort IHDHEPDNODE, string BGKKCEGMOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAE00", Offset = "0x7EC9A00", VA = "0x187ECAE00")]
	public NGDNLODCCFH(string BGKKCEGMOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7ECADE0", Offset = "0x7EC99E0", VA = "0x187ECADE0")]
	public CEDEMIGPCJF LBDEECBNCIH()
	{
		return default(CEDEMIGPCJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7ECADD0", Offset = "0x7EC99D0", VA = "0x187ECADD0", Slot = "4")]
	public bool Equals(NGDNLODCCFH PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7ECADD0", Offset = "0x7EC99D0", VA = "0x187ECADD0", Slot = "5")]
	public bool Equals(ProfilerMarker PELBNOCGOOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DPNIKICHFAE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3027690", Offset = "0x3026290", VA = "0x183027690")]
	public static ProfilerCategory FOENMHDLCAP(ushort IIAADHHNCGN)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAD40", Offset = "0x7EC9940", VA = "0x187ECAD40")]
	public static ushort MDPEGBLFKJF(string BDLDIMNGING)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HCNLEFBDGEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ushort NGLIMLKICMH;
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
