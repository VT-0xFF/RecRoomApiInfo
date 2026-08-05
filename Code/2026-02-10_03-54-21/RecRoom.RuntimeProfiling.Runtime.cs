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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class NWLVINMTBZR
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate ProfilerRecorderHandle ProfilerRecorderHandleGetter(ProfilerCategory category, string statName);

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ProfilerRecorderHandleGetter FAOJVGZBQMV;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F06690", Offset = "0x8F05890", VA = "0x188F06690")]
		static NWLVINMTBZR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x38EF190", Offset = "0x38EE390", VA = "0x1838EF190")]
		public static byte EHJCOONAXXN<a>()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8F06600", Offset = "0x8F05800", VA = "0x188F06600")]
		public static ProfilerRecorderHandle TCASWVYDWXV(ProfilerCategory a, string b)
		{
			return default(ProfilerRecorderHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F06680", Offset = "0x8F05880", VA = "0x188F06680")]
		public static ProfilerCategory VNFBMHUKBNV(string a)
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
		public T LRBPAVAYBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5F66220", Offset = "0x5F65420", VA = "0x185F66220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F66490", Offset = "0x5F65690", VA = "0x185F66490")]
		public RuntimeCounterValue(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x15F8520", Offset = "0x15F7720", VA = "0x1815F8520", Slot = "4")]
		public bool Equals(RuntimeCounterValue<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F66110", Offset = "0x5F65310", VA = "0x185F66110", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F06520", Offset = "0x8F05720", VA = "0x188F06520")]
			internal AutoScope(IntPtr markerPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8F06510", Offset = "0x8F05710", VA = "0x188F06510", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal readonly IntPtr markerPtr;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8F069E0", Offset = "0x8F05BE0", VA = "0x188F069E0")]
		public RuntimeMarker(ushort categoryID, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F06A10", Offset = "0x8F05C10", VA = "0x188F06A10")]
		public RuntimeMarker(ProfilerCategory category, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8F069D0", Offset = "0x8F05BD0", VA = "0x188F069D0")]
		public void NEOQDMXJNFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8F06510", Offset = "0x8F05710", VA = "0x188F06510")]
		public void End()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F069B0", Offset = "0x8F05BB0", VA = "0x188F069B0")]
		public AutoScope Auto()
		{
			return default(AutoScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x15F8520", Offset = "0x15F7720", VA = "0x1815F8520", Slot = "4")]
		public bool Equals(RuntimeMarker other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x15F8520", Offset = "0x15F7720", VA = "0x1815F8520", Slot = "5")]
		public bool Equals(ProfilerMarker other)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Profiling.Unsafe
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class BYFJGKFJZCV
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3419E30", Offset = "0x3419030", VA = "0x183419E30")]
		internal unsafe static bool SNCGXHDGKKU<T>(ProfilerCounterValue<T> a, [Out] T* b) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x33719F0", Offset = "0x3370BF0", VA = "0x1833719F0")]
		public static ProfilerCategory DBCNABYXYMY(ushort a)
		{
			return default(ProfilerCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8F06530", Offset = "0x8F05730", VA = "0x188F06530")]
		public static ushort SPETEFUHWXB(string a)
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
