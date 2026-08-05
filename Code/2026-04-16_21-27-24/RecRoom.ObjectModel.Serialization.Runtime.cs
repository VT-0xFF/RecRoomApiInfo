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
		[Cpp2IlInjected.Address(RVA = "0x9A52C10", Offset = "0x9A51A10", VA = "0x189A52C10", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A552B0", Offset = "0x9A540B0", VA = "0x189A552B0")]
		public static int FQPMCVEQUVB(MNDVNNESOGM.SFCQHHVLTYC.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9A553F0", Offset = "0x9A541F0", VA = "0x189A553F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A541F0", Offset = "0x9A52FF0", VA = "0x189A541F0")]
		public static bool AHEKFMXJTXY(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A54C40", Offset = "0x9A53A40", VA = "0x189A54C40")]
		public static bool DKVJXAPUQKZ(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A546D0", Offset = "0x9A534D0", VA = "0x189A546D0")]
		public static bool DKVJXAPUQKZ(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A550B0", Offset = "0x9A53EB0", VA = "0x189A550B0")]
		public static NativeArray<byte> PGWEIGZXQUO(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A54EB0", Offset = "0x9A53CB0", VA = "0x189A54EB0")]
		private static bool FUYSOOZJCEA(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9A54DB0", Offset = "0x9A53BB0", VA = "0x189A54DB0")]
		private static bool DUBOLKGVEEZ(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9A54FB0", Offset = "0x9A53DB0", VA = "0x189A54FB0")]
		private static bool JSGOKCIRVAL(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A55170", Offset = "0x9A53F70", VA = "0x189A55170")]
		private static void YZTAZOTNXAB(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9A550A0", Offset = "0x9A53EA0", VA = "0x189A550A0")]
		internal static int NXMYQOKHFYO(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A55040", Offset = "0x9A53E40", VA = "0x189A55040")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A52690", Offset = "0x9A51490", VA = "0x189A52690")]
		public static NativeArray<byte> ZWAUKJIJZTP(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9A52330", Offset = "0x9A51130", VA = "0x189A52330")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A52D10", Offset = "0x9A51B10", VA = "0x189A52D10")]
		public static int FQPMCVEQUVB(MNDVNNESOGM.SFCQHHVLTYC.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A53270", Offset = "0x9A52070", VA = "0x189A53270")]
		public static int QVWGDUWWSFW(MNDVNNESOGM.SFCQHHVLTYC.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A53E70", Offset = "0x9A52C70", VA = "0x189A53E70")]
		private static void YZEINBHQCAK(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, MNDVNNESOGM.SFCQHHVLTYC.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A539D0", Offset = "0x9A527D0", VA = "0x189A539D0")]
		private static void XCMUAFBJGSN(MNDVNNESOGM.SFCQHHVLTYC.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A53730", Offset = "0x9A52530", VA = "0x189A53730")]
		private static void TUSEPSTSJBJ(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A53470", Offset = "0x9A52270", VA = "0x189A53470")]
		private static void TBSAEUNXSNL(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A52FF0", Offset = "0x9A51DF0", VA = "0x189A52FF0")]
		private static void ILWSMUILJTW(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A533B0", Offset = "0x9A521B0", VA = "0x189A533B0")]
		private static int SLCSWDHQXDJ(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A53DC0", Offset = "0x9A52BC0", VA = "0x189A53DC0")]
		private static bool XMSZPIGUSFQ(this MNDVNNESOGM.SFCQHHVLTYC.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A53910", Offset = "0x9A52710", VA = "0x189A53910")]
		private static bool VYYICUMWBRA(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A53990", Offset = "0x9A52790", VA = "0x189A53990")]
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
