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
		[Cpp2IlInjected.Address(RVA = "0x9BD5E90", Offset = "0x9BD4890", VA = "0x189BD5E90", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface CUYGTWPPTQD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZDBAIWFQCIK(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CBYRPQCEVDS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class YIRUVOJFFGX
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8530", Offset = "0x9BD6F30", VA = "0x189BD8530")]
		public static int FQPMCVEQUVB(MNDVNNESOGM.SFCQHHVLTYC.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8670", Offset = "0x9BD7070", VA = "0x189BD8670")]
		public static void KQWMOILZGYJ(MNDVNNESOGM.SFCQHHVLTYC.Version a, [In] ByteString serialized, IEnumerable<CUYGTWPPTQD> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class OSPVLIMWAAZ
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker QRBBGTNYJOU;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker ETOPODAGXBZ;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7470", Offset = "0x9BD5E70", VA = "0x189BD7470")]
		public static bool AHEKFMXJTXY(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7EC0", Offset = "0x9BD68C0", VA = "0x189BD7EC0")]
		public static bool DKVJXAPUQKZ(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7950", Offset = "0x9BD6350", VA = "0x189BD7950")]
		public static bool DKVJXAPUQKZ(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8330", Offset = "0x9BD6D30", VA = "0x189BD8330")]
		public static NativeArray<byte> PGWEIGZXQUO(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8130", Offset = "0x9BD6B30", VA = "0x189BD8130")]
		private static bool FUYSOOZJCEA(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8030", Offset = "0x9BD6A30", VA = "0x189BD8030")]
		private static bool DUBOLKGVEEZ(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8230", Offset = "0x9BD6C30", VA = "0x189BD8230")]
		private static bool JSGOKCIRVAL(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9BD83F0", Offset = "0x9BD6DF0", VA = "0x189BD83F0")]
		private static void YZTAZOTNXAB(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8320", Offset = "0x9BD6D20", VA = "0x189BD8320")]
		internal static int NXMYQOKHFYO(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9BD82C0", Offset = "0x9BD6CC0", VA = "0x189BD82C0")]
		internal static int MPCNKVRDUNF(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HPQQCPVMBND
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker QRBBGTNYJOU;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker ETOPODAGXBZ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9BD5910", Offset = "0x9BD4310", VA = "0x189BD5910")]
		public static NativeArray<byte> ZWAUKJIJZTP(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9BD55B0", Offset = "0x9BD3FB0", VA = "0x189BD55B0")]
		public static NativeList<byte> QUHHVMPTKZU(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class MWZNANMXQKX
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker ZGUDHUYSPUO;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker HUXDUNOXTRH;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker IEHNTXEZJVQ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker MMJCLPUCURH;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9BD5F90", Offset = "0x9BD4990", VA = "0x189BD5F90")]
		public static int FQPMCVEQUVB(MNDVNNESOGM.SFCQHHVLTYC.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9BD64F0", Offset = "0x9BD4EF0", VA = "0x189BD64F0")]
		public static int QVWGDUWWSFW(MNDVNNESOGM.SFCQHHVLTYC.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9BD70F0", Offset = "0x9BD5AF0", VA = "0x189BD70F0")]
		private static void YZEINBHQCAK(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, MNDVNNESOGM.SFCQHHVLTYC.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6C50", Offset = "0x9BD5650", VA = "0x189BD6C50")]
		private static void XCMUAFBJGSN(MNDVNNESOGM.SFCQHHVLTYC.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9BD69B0", Offset = "0x9BD53B0", VA = "0x189BD69B0")]
		private static void TUSEPSTSJBJ(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9BD66F0", Offset = "0x9BD50F0", VA = "0x189BD66F0")]
		private static void TBSAEUNXSNL(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6270", Offset = "0x9BD4C70", VA = "0x189BD6270")]
		private static void ILWSMUILJTW(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6630", Offset = "0x9BD5030", VA = "0x189BD6630")]
		private static int SLCSWDHQXDJ(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7040", Offset = "0x9BD5A40", VA = "0x189BD7040")]
		private static bool XMSZPIGUSFQ(this MNDVNNESOGM.SFCQHHVLTYC.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6B90", Offset = "0x9BD5590", VA = "0x189BD6B90")]
		private static bool VYYICUMWBRA(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6C10", Offset = "0x9BD5610", VA = "0x189BD6C10")]
		private static bool VYYICUMWBRA(MNDVNNESOGM.SFCQHHVLTYC.Version a, ByteString b)
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
