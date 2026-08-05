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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class OPOKHALVVFE
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate ProfilerRecorderHandle ProfilerRecorderHandleGetter(ProfilerCategory category, string statName);

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ProfilerRecorderHandleGetter VKHAARDVQKW;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA32D420", Offset = "0xA32C220", VA = "0x18A32D420")]
		static OPOKHALVVFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3D78470", Offset = "0x3D77270", VA = "0x183D78470")]
		public static byte RWNSTASKYYI<a>()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA32D390", Offset = "0xA32C190", VA = "0x18A32D390")]
		public static ProfilerRecorderHandle MAPZFODMVYI(ProfilerCategory a, string b)
		{
			return default(ProfilerRecorderHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA32D410", Offset = "0xA32C210", VA = "0x18A32D410")]
		public static ProfilerCategory VFHFRSQKCIA(string a)
		{
			return default(ProfilerCategory);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct RuntimeCounterValue<T> : IEquatable<RuntimeCounterValue<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly T* valuePtr;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T PGGBLURLEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x78A6100", Offset = "0x78A4F00", VA = "0x1878A6100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x78A6280", Offset = "0x78A5080", VA = "0x1878A6280")]
		public RuntimeCounterValue(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1858FD0", Offset = "0x1857DD0", VA = "0x181858FD0", Slot = "4")]
		public bool Equals(RuntimeCounterValue<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x78A5F10", Offset = "0x78A4D10", VA = "0x1878A5F10", Slot = "5")]
		public bool Equals(ProfilerCounterValue<T> other)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)2, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct RuntimeMarker : IEquatable<RuntimeMarker>, IEquatable<ProfilerMarker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct AutoScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			[NativeDisableUnsafePtrRestriction]
			internal readonly IntPtr markerPtr;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA32D2B0", Offset = "0xA32C0B0", VA = "0x18A32D2B0")]
			internal AutoScope(IntPtr markerPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA32D2A0", Offset = "0xA32C0A0", VA = "0x18A32D2A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal readonly IntPtr markerPtr;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA32D780", Offset = "0xA32C580", VA = "0x18A32D780")]
		public RuntimeMarker(ushort categoryID, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA32D7B0", Offset = "0xA32C5B0", VA = "0x18A32D7B0")]
		public RuntimeMarker(ProfilerCategory category, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA32D750", Offset = "0xA32C550", VA = "0x18A32D750")]
		public void AZAFAXRXEYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA32D2A0", Offset = "0xA32C0A0", VA = "0x18A32D2A0")]
		public void End()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA32D760", Offset = "0xA32C560", VA = "0x18A32D760")]
		public AutoScope Auto()
		{
			return default(AutoScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1858FD0", Offset = "0x1857DD0", VA = "0x181858FD0", Slot = "4")]
		public bool Equals(RuntimeMarker other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1858FD0", Offset = "0x1857DD0", VA = "0x181858FD0", Slot = "5")]
		public bool Equals(ProfilerMarker other)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Profiling.Unsafe
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class JCTIUYJBJZO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3B40DB0", Offset = "0x3B3FBB0", VA = "0x183B40DB0")]
		internal unsafe static bool POQDXOWSTLR<T>(ProfilerCounterValue<T> a, [Out] T* b) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3684DC0", Offset = "0x3683BC0", VA = "0x183684DC0")]
		public static ProfilerCategory TDHXGHXDWSD(ushort a)
		{
			return default(ProfilerCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA32D2C0", Offset = "0xA32C0C0", VA = "0x18A32D2C0")]
		public static ushort XRRMYZVTSMI(string a)
		{
			return default(ushort);
		}
	}
	[StructLayout((LayoutKind)2, Size = 2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct ProfilerCategoryProxy
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public ushort m_CategoryId;
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
