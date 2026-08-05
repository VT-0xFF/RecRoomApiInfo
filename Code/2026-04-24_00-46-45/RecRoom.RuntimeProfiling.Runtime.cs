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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class VUZSUSJPJEZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate ProfilerRecorderHandle ProfilerRecorderHandleGetter(ProfilerCategory category, string statName);

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ProfilerRecorderHandleGetter AWAYJYIZTBB;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7C70", Offset = "0xA4B6670", VA = "0x18A4B7C70")]
		static VUZSUSJPJEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x40D0060", Offset = "0x40CEA60", VA = "0x1840D0060")]
		public static byte WOWURLLMFGV<a>()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7BE0", Offset = "0xA4B65E0", VA = "0x18A4B7BE0")]
		public static ProfilerRecorderHandle JYWANZDXUER(ProfilerCategory a, string b)
		{
			return default(ProfilerRecorderHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7C60", Offset = "0xA4B6660", VA = "0x18A4B7C60")]
		public static ProfilerCategory MHPUALFTUDH(string a)
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
		public T BPERYPXGUEX
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x78EC4D0", Offset = "0x78EAED0", VA = "0x1878EC4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x78EC650", Offset = "0x78EB050", VA = "0x1878EC650")]
		public RuntimeCounterValue(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1892600", Offset = "0x1891000", VA = "0x181892600", Slot = "4")]
		public bool Equals(RuntimeCounterValue<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x78EC2C0", Offset = "0x78EACC0", VA = "0x1878EC2C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA4B79A0", Offset = "0xA4B63A0", VA = "0x18A4B79A0")]
			internal AutoScope(IntPtr markerPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA4B7990", Offset = "0xA4B6390", VA = "0x18A4B7990", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal readonly IntPtr markerPtr;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7B60", Offset = "0xA4B6560", VA = "0x18A4B7B60")]
		public RuntimeMarker(ushort categoryID, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7B90", Offset = "0xA4B6590", VA = "0x18A4B7B90")]
		public RuntimeMarker(ProfilerCategory category, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7B50", Offset = "0xA4B6550", VA = "0x18A4B7B50")]
		public void JPMHDBJTTOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7990", Offset = "0xA4B6390", VA = "0x18A4B7990")]
		public void End()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7B30", Offset = "0xA4B6530", VA = "0x18A4B7B30")]
		public AutoScope Auto()
		{
			return default(AutoScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1892600", Offset = "0x1891000", VA = "0x181892600", Slot = "4")]
		public bool Equals(RuntimeMarker other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1892600", Offset = "0x1891000", VA = "0x181892600", Slot = "5")]
		public bool Equals(ProfilerMarker other)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Profiling.Unsafe
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class QMKKSWMAFFZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3E43B50", Offset = "0x3E42550", VA = "0x183E43B50")]
		internal unsafe static bool QNIFSZQALWW<T>(ProfilerCounterValue<T> a, [Out] T* b) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x36CC940", Offset = "0x36CB340", VA = "0x1836CC940")]
		public static ProfilerCategory JNTLOOZJKTY(ushort a)
		{
			return default(ProfilerCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7A60", Offset = "0xA4B6460", VA = "0x18A4B7A60")]
		public static ushort WDRWOEQODMN(string a)
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
