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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GOHPMLGKKIL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle OPOMAJPDLAI(ProfilerCategory BAIHHLMIMOE, string FILKKCNNBKJ);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static OPOMAJPDLAI KJNJLJGJMDG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8ABFAF0", Offset = "0x8ABE0F0", VA = "0x188ABFAF0")]
	static GOHPMLGKKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B58E70", Offset = "0x3B57470", VA = "0x183B58E70")]
	public static byte MKFKPJNOBPE<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8ABFA60", Offset = "0x8ABE060", VA = "0x188ABFA60")]
	public static ProfilerRecorderHandle BEEEPMPAOMN(ProfilerCategory KCKENBLENBD, string MLIOBOBBHOG)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8ABFAE0", Offset = "0x8ABE0E0", VA = "0x188ABFAE0")]
	public static ProfilerCategory PPBKKBOAPAJ(string KCKENBLENBD)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct FFJFPDPMAEH<T> : IEquatable<FFJFPDPMAEH<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* DAONDOKKLLG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4C05250", Offset = "0x4C03850", VA = "0x184C05250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C053C0", Offset = "0x4C039C0", VA = "0x184C053C0")]
	public FFJFPDPMAEH(ProfilerCategory BAIHHLMIMOE, string IEDAJGLJHNI, ProfilerMarkerDataUnit HFEIIGALAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x23556E0", Offset = "0x2353CE0", VA = "0x1823556E0", Slot = "4")]
	public bool Equals(FFJFPDPMAEH<T> HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C05180", Offset = "0x4C03780", VA = "0x184C05180", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> HOPHFOOKMCC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GKPLGGPFIBC : IEquatable<GKPLGGPFIBC>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct OBDMFCGMLHJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr GEENAABHJKH;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFE60", Offset = "0x8ABE460", VA = "0x188ABFE60")]
		internal OBDMFCGMLHJ(IntPtr GEENAABHJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFE50", Offset = "0x8ABE450", VA = "0x188ABFE50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr GEENAABHJKH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8ABF9E0", Offset = "0x8ABDFE0", VA = "0x188ABF9E0")]
	public GKPLGGPFIBC(ushort DKLHKDGKAOI, string IEDAJGLJHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8ABFA10", Offset = "0x8ABE010", VA = "0x188ABFA10")]
	public GKPLGGPFIBC(ProfilerCategory BAIHHLMIMOE, string IEDAJGLJHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8ABF9C0", Offset = "0x8ABDFC0", VA = "0x188ABF9C0")]
	public OBDMFCGMLHJ PNCJFOEOLPH()
	{
		return default(OBDMFCGMLHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8ABF9B0", Offset = "0x8ABDFB0", VA = "0x188ABF9B0", Slot = "4")]
	public bool Equals(GKPLGGPFIBC HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8ABF9B0", Offset = "0x8ABDFB0", VA = "0x188ABF9B0", Slot = "5")]
	public bool Equals(ProfilerMarker HOPHFOOKMCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class ILENCGAJPEH
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B82810", Offset = "0x3B80E10", VA = "0x183B82810")]
	internal unsafe static bool KKHINDONOEA<T>(ProfilerCounterValue<T> GMNCBLNDADB, [Out] T* DGKLCFICOIC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x37CEE40", Offset = "0x37CD440", VA = "0x1837CEE40")]
	public static ProfilerCategory ENMDEJKCMOF(ushort NCIKMIMFCIL)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8ABFD80", Offset = "0x8ABE380", VA = "0x188ABFD80")]
	public static ushort MLDHHNOJDPM(string EEMMBMJPIDC)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct AHNIOJFKHCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort DJNKMBAGNLJ;
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
