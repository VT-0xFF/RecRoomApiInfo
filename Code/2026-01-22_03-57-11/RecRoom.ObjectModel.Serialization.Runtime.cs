using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel.Protobuf;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.Serialization;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Serialization_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8503E20", Offset = "0x8502620", VA = "0x188503E20", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface SPXFLQXKYIZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EUJHQPQNDSA(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JPLRKQDWIBU();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class XWABICWERAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8504BB0", Offset = "0x85033B0", VA = "0x188504BB0")]
		public static int WUEZPGYMDNX(STPWKGFCKGG.LTMCDKJGFXW.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85047F0", Offset = "0x8502FF0", VA = "0x1885047F0")]
		public static void FQFYQIUMPBZ(STPWKGFCKGG.LTMCDKJGFXW.Version a, [In] ByteString serialized, IEnumerable<SPXFLQXKYIZ> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class HOJHIOKPPJN
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker XNCMYIRTOIO;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker SEOHSYREWEJ;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85030B0", Offset = "0x85018B0", VA = "0x1885030B0")]
		public static bool SJAPWTXTKHK(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8503B80", Offset = "0x8502380", VA = "0x188503B80")]
		public static bool WKLBRSXYMKP(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8503620", Offset = "0x8501E20", VA = "0x188503620")]
		public static bool WKLBRSXYMKP(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8502D80", Offset = "0x8501580", VA = "0x188502D80")]
		public static NativeArray<byte> AEJXRCALAKI(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8502E50", Offset = "0x8501650", VA = "0x188502E50")]
		private static bool NUPQHCZATRM(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8502F50", Offset = "0x8501750", VA = "0x188502F50")]
		private static bool QJTFQSAAJED(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8503590", Offset = "0x8501D90", VA = "0x188503590")]
		private static bool WIGSUQPHNKF(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8503CF0", Offset = "0x85024F0", VA = "0x188503CF0")]
		private static void YPOVEJWAVTB(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8502E40", Offset = "0x8501640", VA = "0x188502E40")]
		internal static int KCUPTKMTUJK(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8503050", Offset = "0x8501850", VA = "0x188503050")]
		internal static int SCGPFYYTLXD(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class SYQKMJVUXDZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker XNCMYIRTOIO;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker SEOHSYREWEJ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8503F20", Offset = "0x8502720", VA = "0x188503F20")]
		public static NativeArray<byte> KUSANZCFKBF(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85043B0", Offset = "0x8502BB0", VA = "0x1885043B0")]
		public static NativeList<byte> OCFFWBJJICY(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class EDEPTAIBZER
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker XRHLCLAWFJS;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker ULSGCHLVUMD;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker TNBWSUSMLQI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker YMGQHQFIALJ;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8502560", Offset = "0x8500D60", VA = "0x188502560")]
		public static int WUEZPGYMDNX(STPWKGFCKGG.LTMCDKJGFXW.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85020F0", Offset = "0x85008F0", VA = "0x1885020F0")]
		public static int GDDCYANPMUS(STPWKGFCKGG.LTMCDKJGFXW.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8501C30", Offset = "0x8500430", VA = "0x188501C30")]
		private static void ESEMNEMRILK(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, STPWKGFCKGG.LTMCDKJGFXW.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8502840", Offset = "0x8501040", VA = "0x188502840")]
		private static void WVDLTPAGRVJ(STPWKGFCKGG.LTMCDKJGFXW.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8501F10", Offset = "0x8500710", VA = "0x188501F10")]
		private static void FODTUSBSILT(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85018B0", Offset = "0x85000B0", VA = "0x1885018B0")]
		private static void BNWVAKMJKAX(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85022E0", Offset = "0x8500AE0", VA = "0x1885022E0")]
		private static void TUAUMHJPTKC(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8501B70", Offset = "0x8500370", VA = "0x188501B70")]
		private static int DBROUNUCFCF(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8502230", Offset = "0x8500A30", VA = "0x188502230")]
		private static bool MVFVFBWZFSU(this STPWKGFCKGG.LTMCDKJGFXW.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8501E90", Offset = "0x8500690", VA = "0x188501E90")]
		private static bool FJPSGFOEWZW(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8501E50", Offset = "0x8500650", VA = "0x188501E50")]
		private static bool FJPSGFOEWZW(STPWKGFCKGG.LTMCDKJGFXW.Version a, ByteString b)
		{
			return default(bool);
		}
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
