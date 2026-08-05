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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BCLOMDJABLE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle KNONPIALOAA(ProfilerCategory PAOIAAAHGOA, string DLKGLFGBGJL);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static KNONPIALOAA EOMMEGCGABM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8A85F80", Offset = "0x8A84780", VA = "0x188A85F80")]
	static BCLOMDJABLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x372A4F0", Offset = "0x3728CF0", VA = "0x18372A4F0")]
	public static byte BIMLKPICLPO<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8A85EF0", Offset = "0x8A846F0", VA = "0x188A85EF0")]
	public static ProfilerRecorderHandle BANGNHMNNJA(ProfilerCategory BBBBFNGAOPB, string NHPJCLKIHKG)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8A85F70", Offset = "0x8A84770", VA = "0x188A85F70")]
	public static ProfilerCategory BECNFPOKGPK(string BBBBFNGAOPB)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct GPEAFJAPIME<T> : IEquatable<GPEAFJAPIME<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* LKADIGHBFLK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4CB24F0", Offset = "0x4CB0CF0", VA = "0x184CB24F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2520", Offset = "0x4CB0D20", VA = "0x184CB2520")]
	public GPEAFJAPIME(ProfilerCategory PAOIAAAHGOA, string HPANEBBHGAC, ProfilerMarkerDataUnit JPFEKPNOGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x226C360", Offset = "0x226AB60", VA = "0x18226C360", Slot = "4")]
	public bool Equals(GPEAFJAPIME<T> KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2430", Offset = "0x4CB0C30", VA = "0x184CB2430", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> KEKEFPAJGHD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GLMECNBMNJC : IEquatable<GLMECNBMNJC>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct KMGAPPKHLJE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr FFKLNJNPECJ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A86390", Offset = "0x8A84B90", VA = "0x188A86390")]
		internal KMGAPPKHLJE(IntPtr FFKLNJNPECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A86380", Offset = "0x8A84B80", VA = "0x188A86380", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr FFKLNJNPECJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8A86230", Offset = "0x8A84A30", VA = "0x188A86230")]
	public GLMECNBMNJC(ushort HEPPCBLFJDD, string HPANEBBHGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8A86260", Offset = "0x8A84A60", VA = "0x188A86260")]
	public GLMECNBMNJC(ProfilerCategory PAOIAAAHGOA, string HPANEBBHGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8A86210", Offset = "0x8A84A10", VA = "0x188A86210")]
	public KMGAPPKHLJE IINKFBAKOEG()
	{
		return default(KMGAPPKHLJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8A86200", Offset = "0x8A84A00", VA = "0x188A86200", Slot = "4")]
	public bool Equals(GLMECNBMNJC KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8A86200", Offset = "0x8A84A00", VA = "0x188A86200", Slot = "5")]
	public bool Equals(ProfilerMarker KEKEFPAJGHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class HBGFKFGBGND
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x39EB910", Offset = "0x39EA110", VA = "0x1839EB910")]
	internal unsafe static bool LHGIODMNEIF<T>(ProfilerCounterValue<T> HNHPMKICAFG, [Out] T* CBGINFCIIGB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x36546B0", Offset = "0x3652EB0", VA = "0x1836546B0")]
	public static ProfilerCategory LEHIIEHOFNJ(ushort POALEMBOFMH)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8A862B0", Offset = "0x8A84AB0", VA = "0x188A862B0")]
	public static ushort GADCEAJAIOM(string OBKCOJPOJEP)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NLPAEHKDPBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort GCBDFGLALDB;
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
