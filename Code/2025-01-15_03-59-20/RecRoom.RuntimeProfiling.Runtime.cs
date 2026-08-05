using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AOPCHINFOGG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x79A40B0", Offset = "0x79A34B0", VA = "0x1879A40B0")]
	public static ProfilerCategory PNGFNLKKNDI(string KKOHHEKMNFB)
	{
		return default(ProfilerCategory);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct KGJMNAKOGFH : IEquatable<KGJMNAKOGFH>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public readonly struct MKNEEANMFML : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr BOIKKCICDMH;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x79A41F0", Offset = "0x79A35F0", VA = "0x1879A41F0")]
		internal MKNEEANMFML(IntPtr BOIKKCICDMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79A41E0", Offset = "0x79A35E0", VA = "0x1879A41E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal const ushort AJALMOOIDKD = 1;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly IntPtr BOIKKCICDMH;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x79A41B0", Offset = "0x79A35B0", VA = "0x1879A41B0")]
	public KGJMNAKOGFH(ushort HDOKJOADPLD, string LJAGHAHCFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x79A4180", Offset = "0x79A3580", VA = "0x1879A4180")]
	public KGJMNAKOGFH(string LJAGHAHCFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x79A4160", Offset = "0x79A3560", VA = "0x1879A4160")]
	public MKNEEANMFML PODNAGDKMLA()
	{
		return default(MKNEEANMFML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79A4150", Offset = "0x79A3550", VA = "0x1879A4150", Slot = "4")]
	public bool Equals(KGJMNAKOGFH BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x79A4150", Offset = "0x79A3550", VA = "0x1879A4150", Slot = "5")]
	public bool Equals(ProfilerMarker BMKPAKCEMFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BGCFOGBMCDF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2D2F490", Offset = "0x2D2E890", VA = "0x182D2F490")]
	public static ProfilerCategory KCFFPEHBPLH(ushort AAIDAPGPPPM)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79A40C0", Offset = "0x79A34C0", VA = "0x1879A40C0")]
	public static ushort DFJJAJLKNIH(string MKDLCIMILAB)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NOMDFDKNDPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ushort MCIOKGHEPPB;
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
