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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MLGOCEDBEMN
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle BDMLOFOJFOD(ProfilerCategory OKIBPDDCDLN, string IDIDJIAHNBK);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static BDMLOFOJFOD GOPCKMIMBEF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9052BC0", Offset = "0x90511C0", VA = "0x189052BC0")]
	static MLGOCEDBEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3ED9F40", Offset = "0x3ED8540", VA = "0x183ED9F40")]
	public static byte DCLHENPLJPN<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9052B40", Offset = "0x9051140", VA = "0x189052B40")]
	public static ProfilerRecorderHandle OAFKDDDBLEH(ProfilerCategory CDBKPJPLCDA, string IAPOALMBIAP)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9052B30", Offset = "0x9051130", VA = "0x189052B30")]
	public static ProfilerCategory MGJCFILDFOD(string CDBKPJPLCDA)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct NPMCMFPGHKD<T> : IEquatable<NPMCMFPGHKD<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* FJCKHJCEFIG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5A9DBB0", Offset = "0x5A9C1B0", VA = "0x185A9DBB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5A9DEB0", Offset = "0x5A9C4B0", VA = "0x185A9DEB0")]
	public NPMCMFPGHKD(ProfilerCategory OKIBPDDCDLN, string NDIENANOGEK, ProfilerMarkerDataUnit NFKFGHJAMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x252B610", Offset = "0x2529C10", VA = "0x18252B610", Slot = "4")]
	public bool Equals(NPMCMFPGHKD<T> AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5A9DB10", Offset = "0x5A9C110", VA = "0x185A9DB10", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> AAGCKLPFJME)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HJOOCOBMHDA : IEquatable<HJOOCOBMHDA>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct JELEJMLIDCM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr GKLFEMBMMIA;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9052B20", Offset = "0x9051120", VA = "0x189052B20")]
		internal JELEJMLIDCM(IntPtr GKLFEMBMMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9052A80", Offset = "0x9051080", VA = "0x189052A80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr GKLFEMBMMIA;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9052AF0", Offset = "0x90510F0", VA = "0x189052AF0")]
	public HJOOCOBMHDA(ushort HCNAKJPGGBB, string NDIENANOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9052AA0", Offset = "0x90510A0", VA = "0x189052AA0")]
	public HJOOCOBMHDA(ProfilerCategory OKIBPDDCDLN, string NDIENANOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9052A90", Offset = "0x9051090", VA = "0x189052A90")]
	public void OPIAKOPOKFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9052A80", Offset = "0x9051080", VA = "0x189052A80")]
	public void KBLDJAMLPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9052A60", Offset = "0x9051060", VA = "0x189052A60")]
	public JELEJMLIDCM GPKCLKAHMNJ()
	{
		return default(JELEJMLIDCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9052A50", Offset = "0x9051050", VA = "0x189052A50", Slot = "4")]
	public bool Equals(HJOOCOBMHDA AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x9052A50", Offset = "0x9051050", VA = "0x189052A50", Slot = "5")]
	public bool Equals(ProfilerMarker AAGCKLPFJME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class DFGKOKGMHOK
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C23BF0", Offset = "0x3C221F0", VA = "0x183C23BF0")]
	internal unsafe static bool FBMBMLPPOFP<T>(ProfilerCounterValue<T> LDLCCFBHPAD, [Out] T* FFGHHIPCMDO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A68090", Offset = "0x3A66690", VA = "0x183A68090")]
	public static ProfilerCategory GHNGBJBOEBH(ushort LEECIAGOECO)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9052980", Offset = "0x9050F80", VA = "0x189052980")]
	public static ushort LCHAKLGLKIC(string EHGFJEIOFLE)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HGBHELHKGLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort NCLLAADEMMD;
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
