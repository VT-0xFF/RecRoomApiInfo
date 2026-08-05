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
		[Cpp2IlInjected.Address(RVA = "0x849A600", Offset = "0x8499A00", VA = "0x18849A600", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface TOUKQCNRGVG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UBKRIWJADAX(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SHWXSEAJSCT();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class KUGNTKIKPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x849A4C0", Offset = "0x84998C0", VA = "0x18849A4C0")]
		public static int ZOEMUSXIIJO(GZIERLPHRJZ.NQYZCTZVWIX.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x849A110", Offset = "0x8499510", VA = "0x18849A110")]
		public static void EEMDESVXWQY(GZIERLPHRJZ.NQYZCTZVWIX.Version a, [In] ByteString serialized, IEnumerable<TOUKQCNRGVG> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class UBBLFZVPCAY
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker TAWUROOYVFF;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker RRIMWDDGXKY;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x849BBE0", Offset = "0x849AFE0", VA = "0x18849BBE0")]
		public static bool DOOIDNNZVOL(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x849C170", Offset = "0x849B570", VA = "0x18849C170")]
		public static bool HHGWURNQZYE(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x849C2E0", Offset = "0x849B6E0", VA = "0x18849C2E0")]
		public static bool HHGWURNQZYE(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x849C840", Offset = "0x849BC40", VA = "0x18849C840")]
		public static NativeArray<byte> LMOOZIFYCBF(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x849C900", Offset = "0x849BD00", VA = "0x18849C900")]
		private static bool UOUJGIKJRMF(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x849CA00", Offset = "0x849BE00", VA = "0x18849CA00")]
		private static bool VPHIVOHYHKA(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x849CB00", Offset = "0x849BF00", VA = "0x18849CB00")]
		private static bool YDJCJNHNVEM(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x849C0C0", Offset = "0x849B4C0", VA = "0x18849C0C0")]
		private static void EKKERCAMQZU(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x849BBD0", Offset = "0x849AFD0", VA = "0x18849BBD0")]
		internal static int AIMAGTGHVPZ(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x849C110", Offset = "0x849B510", VA = "0x18849C110")]
		internal static int ELTCPLAJLFU(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HJNNTWPICCK
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker TAWUROOYVFF;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker RRIMWDDGXKY;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8499BA0", Offset = "0x8498FA0", VA = "0x188499BA0")]
		public static NativeArray<byte> SXEOROAFTOG(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8499840", Offset = "0x8498C40", VA = "0x188499840")]
		public static NativeList<byte> CPLDJUIINHX(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class TJWAPOSZIOO
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker YSJYHHZMSNX;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker YDJFUTIMXZQ;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker DLCUHLFNBHL;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker FFLKBROHZCC;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x849B7A0", Offset = "0x849ABA0", VA = "0x18849B7A0")]
		public static int ZOEMUSXIIJO(GZIERLPHRJZ.NQYZCTZVWIX.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x849B660", Offset = "0x849AA60", VA = "0x18849B660")]
		public static int ZNTUWCUSIJR(GZIERLPHRJZ.NQYZCTZVWIX.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x849B440", Offset = "0x849A840", VA = "0x18849B440")]
		private static void XYTTWNAIMYJ(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, GZIERLPHRJZ.NQYZCTZVWIX.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x849B050", Offset = "0x849A450", VA = "0x18849B050")]
		private static void VQHRHRFLQJI(GZIERLPHRJZ.NQYZCTZVWIX.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x849AB30", Offset = "0x8499F30", VA = "0x18849AB30")]
		private static void GYCKWUVTJUA(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x849A7C0", Offset = "0x8499BC0", VA = "0x18849A7C0")]
		private static void BQKPVZMMAMK(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x849AD10", Offset = "0x849A110", VA = "0x18849AD10")]
		private static void JROKSKVVYAX(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x849A700", Offset = "0x8499B00", VA = "0x18849A700")]
		private static int BETEYPXHEAW(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x849AA80", Offset = "0x8499E80", VA = "0x18849AA80")]
		private static bool FWYLGKSEKXL(this GZIERLPHRJZ.NQYZCTZVWIX.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x849AFD0", Offset = "0x849A3D0", VA = "0x18849AFD0")]
		private static bool QGLWYBIOODP(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x849AF90", Offset = "0x849A390", VA = "0x18849AF90")]
		private static bool QGLWYBIOODP(GZIERLPHRJZ.NQYZCTZVWIX.Version a, ByteString b)
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
