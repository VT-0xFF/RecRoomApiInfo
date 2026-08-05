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
		[Cpp2IlInjected.Address(RVA = "0x8732970", Offset = "0x8731770", VA = "0x188732970", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface RHDCVNQYCRY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FWZXHCVSNXP(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DELFABVRANX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ZXETECHKBXQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8734410", Offset = "0x8733210", VA = "0x188734410")]
		public static int RUNOQELWJVM(NTIEBJGAYJP.CYQIAAWFTLX.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8734550", Offset = "0x8733350", VA = "0x188734550")]
		public static void YDNTPQCEQWC(NTIEBJGAYJP.CYQIAAWFTLX.Version a, [In] ByteString serialized, IEnumerable<RHDCVNQYCRY> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class MHOTZQZINDA
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker LBHCXAEHDPT;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker YKEGXTJNSSO;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8733320", Offset = "0x8732120", VA = "0x188733320")]
		public static bool KSNARLNKZZT(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8732C40", Offset = "0x8731A40", VA = "0x188732C40")]
		public static bool KBRCHMSLIJE(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8732DB0", Offset = "0x8731BB0", VA = "0x188732DB0")]
		public static bool KBRCHMSLIJE(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8732A70", Offset = "0x8731870", VA = "0x188732A70")]
		public static NativeArray<byte> BTSTSUPAFKN(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8733940", Offset = "0x8732740", VA = "0x188733940")]
		private static bool TMYQXYLAALN(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8732B30", Offset = "0x8731930", VA = "0x188732B30")]
		private static bool HTRFMNWSJEC(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8733800", Offset = "0x8732600", VA = "0x188733800")]
		private static bool OMIDNPVNLGG(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8733890", Offset = "0x8732690", VA = "0x188733890")]
		private static void OVONWRVGUCQ(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8732C30", Offset = "0x8731A30", VA = "0x188732C30")]
		internal static int IJTERYQEIQF(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87338E0", Offset = "0x87326E0", VA = "0x1887338E0")]
		internal static int TIXOIUUIVRC(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class WFQOOPPPOPS
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker LBHCXAEHDPT;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker YKEGXTJNSSO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8733B30", Offset = "0x8732930", VA = "0x188733B30")]
		public static NativeArray<byte> BLRAGGRKIIU(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8733FC0", Offset = "0x8732DC0", VA = "0x188733FC0")]
		public static NativeList<byte> EISVXQZLOQX(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class LMRPNSOCXNO
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker FSSHWHFKDIL;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker ANOKIYGFKQE;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker SYLJGIOXDYH;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker ITRRBCNJCQY;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87323B0", Offset = "0x87311B0", VA = "0x1887323B0")]
		public static int RUNOQELWJVM(NTIEBJGAYJP.CYQIAAWFTLX.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8731490", Offset = "0x8730290", VA = "0x188731490")]
		public static int DPNTVJWCUTP(NTIEBJGAYJP.CYQIAAWFTLX.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8731F10", Offset = "0x8730D10", VA = "0x188731F10")]
		private static void QKIWSPZTPOP(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, NTIEBJGAYJP.CYQIAAWFTLX.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8731B20", Offset = "0x8730920", VA = "0x188731B20")]
		private static void MWZWAPVHVUU(NTIEBJGAYJP.CYQIAAWFTLX.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8731940", Offset = "0x8730740", VA = "0x188731940")]
		private static void HETLYNBWBQS(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8731680", Offset = "0x8730480", VA = "0x188731680")]
		private static void GWPIPFZYPWU(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8732130", Offset = "0x8730F30", VA = "0x188732130")]
		private static void RTLYKHBRBZT(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8732690", Offset = "0x8731490", VA = "0x188732690")]
		private static int UGYDVRMPYMI(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x87315D0", Offset = "0x87303D0", VA = "0x1887315D0")]
		private static bool EMESPDUDSFZ(this NTIEBJGAYJP.CYQIAAWFTLX.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8732790", Offset = "0x8731590", VA = "0x188732790")]
		private static bool XGPXGANYHBB(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8732750", Offset = "0x8731550", VA = "0x188732750")]
		private static bool XGPXGANYHBB(NTIEBJGAYJP.CYQIAAWFTLX.Version a, ByteString b)
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
