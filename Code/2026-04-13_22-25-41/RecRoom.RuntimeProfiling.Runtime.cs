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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class HEMICENXCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate ProfilerRecorderHandle ProfilerRecorderHandleGetter(ProfilerCategory category, string statName);

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ProfilerRecorderHandleGetter QKTRCTSEULL;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA344980", Offset = "0xA343380", VA = "0x18A344980")]
		static HEMICENXCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF070", Offset = "0x3AEDA70", VA = "0x183AEF070")]
		public static byte PWFEEFWHLPJ<a>()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA3448F0", Offset = "0xA3432F0", VA = "0x18A3448F0")]
		public static ProfilerRecorderHandle HYYHQAZIFLN(ProfilerCategory a, string b)
		{
			return default(ProfilerRecorderHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA344970", Offset = "0xA343370", VA = "0x18A344970")]
		public static ProfilerCategory RSSEVNYBJAL(string a)
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
		public T YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x78F7CA0", Offset = "0x78F66A0", VA = "0x1878F7CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x78F7EE0", Offset = "0x78F68E0", VA = "0x1878F7EE0")]
		public RuntimeCounterValue(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1860FE0", Offset = "0x185F9E0", VA = "0x181860FE0", Slot = "4")]
		public bool Equals(RuntimeCounterValue<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x78F7B70", Offset = "0x78F6570", VA = "0x1878F7B70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA3448E0", Offset = "0xA3432E0", VA = "0x18A3448E0")]
			internal AutoScope(IntPtr markerPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA3448D0", Offset = "0xA3432D0", VA = "0x18A3448D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal readonly IntPtr markerPtr;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA344DB0", Offset = "0xA3437B0", VA = "0x18A344DB0")]
		public RuntimeMarker(ushort categoryID, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA344DE0", Offset = "0xA3437E0", VA = "0x18A344DE0")]
		public RuntimeMarker(ProfilerCategory category, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA344DA0", Offset = "0xA3437A0", VA = "0x18A344DA0")]
		public void SIUHUEYRRON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA3448D0", Offset = "0xA3432D0", VA = "0x18A3448D0")]
		public void End()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA344D80", Offset = "0xA343780", VA = "0x18A344D80")]
		public AutoScope Auto()
		{
			return default(AutoScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1860FE0", Offset = "0x185F9E0", VA = "0x181860FE0", Slot = "4")]
		public bool Equals(RuntimeMarker other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1860FE0", Offset = "0x185F9E0", VA = "0x181860FE0", Slot = "5")]
		public bool Equals(ProfilerMarker other)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Profiling.Unsafe
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class JQVPDIOIYPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0940", Offset = "0x3BAF340", VA = "0x183BB0940")]
		internal unsafe static bool SMEMSTSHBGU<T>(ProfilerCounterValue<T> a, [Out] T* b) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x368C760", Offset = "0x368B160", VA = "0x18368C760")]
		public static ProfilerCategory WGATTTIANAA(ushort a)
		{
			return default(ProfilerCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA344C00", Offset = "0xA343600", VA = "0x18A344C00")]
		public static ushort KWYMVEYBOLN(string a)
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
