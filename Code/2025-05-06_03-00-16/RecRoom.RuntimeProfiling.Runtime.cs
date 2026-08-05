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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MKOLELACCII
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle MNCHLIABJKP(ProfilerCategory NACCBIPFJIO, string GNCHKAKJHAA);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static MNCHLIABJKP JBBHHMKMCEJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8590660", Offset = "0x858EE60", VA = "0x188590660")]
	static MKOLELACCII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x38C4C40", Offset = "0x38C3440", VA = "0x1838C4C40")]
	public static byte AADCNDLPEPJ<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85905D0", Offset = "0x858EDD0", VA = "0x1885905D0")]
	public static ProfilerRecorderHandle KJHCMAEKDEJ(ProfilerCategory PPBJOEAHOEL, string DHKDNANNPLH)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8590650", Offset = "0x858EE50", VA = "0x188590650")]
	public static ProfilerCategory MKPPEPJCAFP(string PPBJOEAHOEL)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct PIMKBFCBEBC<T> : IEquatable<PIMKBFCBEBC<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* MDKNLLBCMML;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x55601E0", Offset = "0x555E9E0", VA = "0x1855601E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5560700", Offset = "0x555EF00", VA = "0x185560700")]
	public PIMKBFCBEBC(ProfilerCategory NACCBIPFJIO, string GLGOHIJMLFB, ProfilerMarkerDataUnit BMHMBLENGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x21100E0", Offset = "0x210E8E0", VA = "0x1821100E0", Slot = "4")]
	public bool Equals(PIMKBFCBEBC<T> PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5560210", Offset = "0x555EA10", VA = "0x185560210", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> PGPJMFPAKOO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CPOEGNJJJHD : IEquatable<CPOEGNJJJHD>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct HHABLJMCBGB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr CBOMMIPDMDK;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85904F0", Offset = "0x858ECF0", VA = "0x1885904F0")]
		internal HHABLJMCBGB(IntPtr CBOMMIPDMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85904E0", Offset = "0x858ECE0", VA = "0x1885904E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr CBOMMIPDMDK;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8590460", Offset = "0x858EC60", VA = "0x188590460")]
	public CPOEGNJJJHD(ushort BODKIOJNDPG, string GLGOHIJMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8590490", Offset = "0x858EC90", VA = "0x188590490")]
	public CPOEGNJJJHD(ProfilerCategory NACCBIPFJIO, string GLGOHIJMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8590440", Offset = "0x858EC40", VA = "0x188590440")]
	public HHABLJMCBGB OLINIHBGDHE()
	{
		return default(HHABLJMCBGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8590430", Offset = "0x858EC30", VA = "0x188590430", Slot = "4")]
	public bool Equals(CPOEGNJJJHD PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8590430", Offset = "0x858EC30", VA = "0x188590430", Slot = "5")]
	public bool Equals(ProfilerMarker PGPJMFPAKOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class MADKKNMKIKE
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38A4550", Offset = "0x38A2D50", VA = "0x1838A4550")]
	internal unsafe static bool FIAPFEKELNC<T>(ProfilerCounterValue<T> DGAPEKCNGJE, [Out] T* INCPHIBIIJF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x342B250", Offset = "0x3429A50", VA = "0x18342B250")]
	public static ProfilerCategory JONHGEFKPKC(ushort DAOHNEAMEBP)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8590500", Offset = "0x858ED00", VA = "0x188590500")]
	public static ushort OKEIEIFBKBL(string HBODPJHDMMC)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct JFNGDKBEMGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort BFIPOADCOBH;
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
