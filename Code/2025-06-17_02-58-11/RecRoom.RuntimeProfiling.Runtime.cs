using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PNFGCJDHBCK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle MMMADPPJMEA(ProfilerCategory KGIGFDOMMJA, string HDFKCCDGHNN);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static MMMADPPJMEA BHFIPHHEHEM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8845EF0", Offset = "0x88448F0", VA = "0x188845EF0")]
	static PNFGCJDHBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3C29D70", Offset = "0x3C28770", VA = "0x183C29D70")]
	public static byte BFLKBNNCJEM<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8845E60", Offset = "0x8844860", VA = "0x188845E60")]
	public static ProfilerRecorderHandle EAACIHCICBH(ProfilerCategory NPAGJNCOHBO, string JABEHJMGCFJ)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8845EE0", Offset = "0x88448E0", VA = "0x188845EE0")]
	public static ProfilerCategory LAMJMJNCJHE(string NPAGJNCOHBO)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct FKAPCDPLHJN<T> : IEquatable<FKAPCDPLHJN<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* FLEDMKCHJBN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4B4D730", Offset = "0x4B4C130", VA = "0x184B4D730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B4D9F0", Offset = "0x4B4C3F0", VA = "0x184B4D9F0")]
	public FKAPCDPLHJN(ProfilerCategory KGIGFDOMMJA, string GBCFHNGPBLM, ProfilerMarkerDataUnit CFKBKCIEFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22DBD10", Offset = "0x22DA710", VA = "0x1822DBD10", Slot = "4")]
	public bool Equals(FKAPCDPLHJN<T> NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B4D670", Offset = "0x4B4C070", VA = "0x184B4D670", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> NDNHELJMDCG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CFLPJICDACJ : IEquatable<CFLPJICDACJ>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct GJGFKKMLOOO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr OPLNLKMHCJG;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8845C90", Offset = "0x8844690", VA = "0x188845C90")]
		internal GJGFKKMLOOO(IntPtr OPLNLKMHCJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8845C80", Offset = "0x8844680", VA = "0x188845C80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr OPLNLKMHCJG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8845C00", Offset = "0x8844600", VA = "0x188845C00")]
	public CFLPJICDACJ(ushort CDFHNMFKMPO, string GBCFHNGPBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8845C30", Offset = "0x8844630", VA = "0x188845C30")]
	public CFLPJICDACJ(ProfilerCategory KGIGFDOMMJA, string GBCFHNGPBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8845BE0", Offset = "0x88445E0", VA = "0x188845BE0")]
	public GJGFKKMLOOO JOIJIMDPILN()
	{
		return default(GJGFKKMLOOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8845BD0", Offset = "0x88445D0", VA = "0x188845BD0", Slot = "4")]
	public bool Equals(CFLPJICDACJ NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8845BD0", Offset = "0x88445D0", VA = "0x188845BD0", Slot = "5")]
	public bool Equals(ProfilerMarker NDNHELJMDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class OFPANFAAAHG
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9400", Offset = "0x3BF7E00", VA = "0x183BF9400")]
	internal unsafe static bool KLOJMIGHIOA<T>(ProfilerCounterValue<T> KNHMEDPDCMA, [Out] T* GCBMPILEBCJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3710DE0", Offset = "0x370F7E0", VA = "0x183710DE0")]
	public static ProfilerCategory OALOLJIGDFF(ushort EGMMEKBBOJJ)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8845D90", Offset = "0x8844790", VA = "0x188845D90")]
	public static ushort OKMPEMCBKGM(string LNFICPFFPAG)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct ALPIBOKGCIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort EBFGJBICDAN;
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
