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
		[Cpp2IlInjected.Address(RVA = "0x8416130", Offset = "0x8415530", VA = "0x188416130", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IAKYJRTPXRW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XHJQFJUUCEX(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MKOAUOREKWX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class KMRFPQHMXZS
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8415C40", Offset = "0x8415040", VA = "0x188415C40")]
		public static int LLFUKQZVFHC(MUEFVPNMOTN.SEJJYADUEHN.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8415D80", Offset = "0x8415180", VA = "0x188415D80")]
		public static void NBCEUPWVOEU(MUEFVPNMOTN.SEJJYADUEHN.Version a, [In] ByteString serialized, IEnumerable<IAKYJRTPXRW> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class TCRVAMTHBSM
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker JPVVLCDWJZJ;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker THGOLYMIYFC;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8417760", Offset = "0x8416B60", VA = "0x188417760")]
		public static bool BYULPXZCNED(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84183F0", Offset = "0x84177F0", VA = "0x1884183F0")]
		public static bool LTZRZCHSEXO(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8417E90", Offset = "0x8417290", VA = "0x188417E90")]
		public static bool LTZRZCHSEXO(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8417D40", Offset = "0x8417140", VA = "0x188417D40")]
		public static NativeArray<byte> INFMNWJNXRF(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8417C40", Offset = "0x8417040", VA = "0x188417C40")]
		private static bool CMELATSLGSZ(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84185C0", Offset = "0x84179C0", VA = "0x1884185C0")]
		private static bool YOOFYYASHRW(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8417E00", Offset = "0x8417200", VA = "0x188417E00")]
		private static bool LDZTJLWIBMA(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8418570", Offset = "0x8417970", VA = "0x188418570")]
		private static void WYNSSYEJTQG(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8418560", Offset = "0x8417960", VA = "0x188418560")]
		internal static int UUKSEONWNAL(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8417700", Offset = "0x8416B00", VA = "0x188417700")]
		internal static int ATCVKVTFPSO(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class IGXPNIIZLYW
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker JPVVLCDWJZJ;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker THGOLYMIYFC;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84156D0", Offset = "0x8414AD0", VA = "0x1884156D0")]
		public static NativeArray<byte> SGDNKXEOGXU(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8415370", Offset = "0x8414770", VA = "0x188415370")]
		public static NativeList<byte> HBJOKOQZHIZ(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class PRAXLAZDCOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker HTCDVZZXCCZ;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker PZPNENCHHYO;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker FVUQPDVLVAF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker KWMXODFVGNU;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8416C40", Offset = "0x8416040", VA = "0x188416C40")]
		public static int LLFUKQZVFHC(MUEFVPNMOTN.SEJJYADUEHN.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8417140", Offset = "0x8416540", VA = "0x188417140")]
		public static int PDSLIMFWZDF(MUEFVPNMOTN.SEJJYADUEHN.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8416F20", Offset = "0x8416320", VA = "0x188416F20")]
		private static void NOILCNECSAV(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, MUEFVPNMOTN.SEJJYADUEHN.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84162F0", Offset = "0x84156F0", VA = "0x1884162F0")]
		private static void EMLYOLQGWLI(MUEFVPNMOTN.SEJJYADUEHN.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84166E0", Offset = "0x8415AE0", VA = "0x1884166E0")]
		private static void FITSFFCXMTS(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84168C0", Offset = "0x8415CC0", VA = "0x1884168C0")]
		private static void JMROQUYVZAC(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8417280", Offset = "0x8416680", VA = "0x188417280")]
		private static void QQUISIRVKIT(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8416B80", Offset = "0x8415F80", VA = "0x188416B80")]
		private static int KNANHGATOPM(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8417500", Offset = "0x8416900", VA = "0x188417500")]
		private static bool YFJEPTCGWRT(this MUEFVPNMOTN.SEJJYADUEHN.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8416230", Offset = "0x8415630", VA = "0x188416230")]
		private static bool CRUJMGXYZYN(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84162B0", Offset = "0x84156B0", VA = "0x1884162B0")]
		private static bool CRUJMGXYZYN(MUEFVPNMOTN.SEJJYADUEHN.Version a, ByteString b)
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
