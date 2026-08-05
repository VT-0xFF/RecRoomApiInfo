using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LAFFOBADFJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7807680", Offset = "0x7806680", VA = "0x187807680")]
	public static ProfilerCategory ECIOGKALKND(string NLNOCPGODML)
	{
		return default(ProfilerCategory);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct NDPGBHBCKEF : IEquatable<NDPGBHBCKEF>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public readonly struct LNLALJMCJMB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr ALILONNJDAE;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x78076A0", Offset = "0x78066A0", VA = "0x1878076A0")]
		internal LNLALJMCJMB(IntPtr ALILONNJDAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7807690", Offset = "0x7806690", VA = "0x187807690", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal const ushort EOHBIMDABAO = 1;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly IntPtr ALILONNJDAE;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x78076E0", Offset = "0x78066E0", VA = "0x1878076E0")]
	public NDPGBHBCKEF(ushort ODKIDHHBIFE, string DMCFPOLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7807710", Offset = "0x7806710", VA = "0x187807710")]
	public NDPGBHBCKEF(string DMCFPOLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x78076C0", Offset = "0x78066C0", VA = "0x1878076C0")]
	public LNLALJMCJMB OEGAKPBNLKO()
	{
		return default(LNLALJMCJMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x78076B0", Offset = "0x78066B0", VA = "0x1878076B0", Slot = "4")]
	public bool Equals(NDPGBHBCKEF DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78076B0", Offset = "0x78066B0", VA = "0x1878076B0", Slot = "5")]
	public bool Equals(ProfilerMarker DFABCHNPEEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EPKHOEKNLBI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C7E0", Offset = "0x2C5B7E0", VA = "0x182C5C7E0")]
	public static ProfilerCategory GAAGBJGOANH(ushort LIJPEMFBOMD)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x78075F0", Offset = "0x78065F0", VA = "0x1878075F0")]
	public static ushort BDCAEDLMKMP(string HKMMGDHKFED)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NENGHLHLMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ushort FBIDMIGJDLN;
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
