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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FOCFNDCIFDK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle LIBBMMPBJIE(ProfilerCategory NOJNONODDMI, string BELIJKLDEAM);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static LIBBMMPBJIE NLONMFFCGHP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x904C090", Offset = "0x904AA90", VA = "0x18904C090")]
	static FOCFNDCIFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3D92920", Offset = "0x3D91320", VA = "0x183D92920")]
	public static byte MPDABCJFEGO<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x904C010", Offset = "0x904AA10", VA = "0x18904C010")]
	public static ProfilerRecorderHandle KCOPHLEFGKG(ProfilerCategory NBDDPKLNOPL, string ECMMBLMACAB)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x904C000", Offset = "0x904AA00", VA = "0x18904C000")]
	public static ProfilerCategory IKDDGINMINC(string NBDDPKLNOPL)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct FGANCMFIHOK<T> : IEquatable<FGANCMFIHOK<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* KLLKNDIPNDF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0CE0", Offset = "0x4FEF6E0", VA = "0x184FF0CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0E50", Offset = "0x4FEF850", VA = "0x184FF0E50")]
	public FGANCMFIHOK(ProfilerCategory NOJNONODDMI, string IELIBBNCJAC, ProfilerMarkerDataUnit IPKJBKNHKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x252FAB0", Offset = "0x252E4B0", VA = "0x18252FAB0", Slot = "4")]
	public bool Equals(FGANCMFIHOK<T> GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0C10", Offset = "0x4FEF610", VA = "0x184FF0C10", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> GOCNHGEHNFD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MEDPEEKHCLL : IEquatable<MEDPEEKHCLL>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct HJCHNDLNMFC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr HLAFJHGCJKM;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x904C330", Offset = "0x904AD30", VA = "0x18904C330")]
		internal HJCHNDLNMFC(IntPtr HLAFJHGCJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x904C320", Offset = "0x904AD20", VA = "0x18904C320", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr HLAFJHGCJKM;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x904C470", Offset = "0x904AE70", VA = "0x18904C470")]
	public MEDPEEKHCLL(ushort KCOJDOHPMEM, string IELIBBNCJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x904C4A0", Offset = "0x904AEA0", VA = "0x18904C4A0")]
	public MEDPEEKHCLL(ProfilerCategory NOJNONODDMI, string IELIBBNCJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x904C460", Offset = "0x904AE60", VA = "0x18904C460")]
	public void HFBLIKOCLMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x904C320", Offset = "0x904AD20", VA = "0x18904C320")]
	public void PKAPPLHNNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x904C430", Offset = "0x904AE30", VA = "0x18904C430")]
	public HJCHNDLNMFC BFGCLDGFFLK()
	{
		return default(HJCHNDLNMFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x904C450", Offset = "0x904AE50", VA = "0x18904C450", Slot = "4")]
	public bool Equals(MEDPEEKHCLL GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x904C450", Offset = "0x904AE50", VA = "0x18904C450", Slot = "5")]
	public bool Equals(ProfilerMarker GOCNHGEHNFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class FNBHDBAINOO
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D704C0", Offset = "0x3D6EEC0", VA = "0x183D704C0")]
	internal unsafe static bool ICOIOBIOICL<T>(ProfilerCounterValue<T> PBNKNIIJKCO, [Out] T* HECKGFBKIOJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A32FB0", Offset = "0x3A319B0", VA = "0x183A32FB0")]
	public static ProfilerCategory NFDEGNBJHKP(ushort DNNIAOAKDFF)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x904BF30", Offset = "0x904A930", VA = "0x18904BF30")]
	public static ushort BMCOBCNHDKP(string DLILCEMDMPM)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct POEMJFEAIAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort PAEHCGBNODD;
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
