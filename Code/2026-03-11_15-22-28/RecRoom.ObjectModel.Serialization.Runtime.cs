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
		[Cpp2IlInjected.Address(RVA = "0x86A44F0", Offset = "0x86A34F0", VA = "0x1886A44F0", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface XTLLHPJOGNT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IZNKKLARJHS(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BPSMAKIBARY();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class HWFBCRLEUKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86A4000", Offset = "0x86A3000", VA = "0x1886A4000")]
		public static int JDYMEHCDYNP(QNXPIAAYXFY.FZNFAKTBVRO.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86A4140", Offset = "0x86A3140", VA = "0x1886A4140")]
		public static void PYMJGEWGCNR(QNXPIAAYXFY.FZNFAKTBVRO.Version a, [In] ByteString serialized, IEnumerable<XTLLHPJOGNT> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class ARNQAGROAFF
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker WTUNCBUMNXI;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker VPSTUGZFDYJ;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86A2F60", Offset = "0x86A1F60", VA = "0x1886A2F60")]
		public static bool BCSVRZMFVDK(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86A3740", Offset = "0x86A2740", VA = "0x1886A3740")]
		public static bool USQSUPCVDDF(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86A38B0", Offset = "0x86A28B0", VA = "0x1886A38B0")]
		public static bool USQSUPCVDDF(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86A3630", Offset = "0x86A2630", VA = "0x1886A3630")]
		public static NativeArray<byte> TMURQIYVHPO(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86A34D0", Offset = "0x86A24D0", VA = "0x1886A34D0")]
		private static bool MZVZKWFWSEO(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86A3E20", Offset = "0x86A2E20", VA = "0x1886A3E20")]
		private static bool WMDLVLFLBSD(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86A3440", Offset = "0x86A2440", VA = "0x1886A3440")]
		private static bool EVWHIRORNIN(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86A36F0", Offset = "0x86A26F0", VA = "0x1886A36F0")]
		private static void TNURYUYSMQH(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x86A3E10", Offset = "0x86A2E10", VA = "0x1886A3E10")]
		internal static int WBHDEKKJYJW(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86A35D0", Offset = "0x86A25D0", VA = "0x1886A35D0")]
		internal static int QTYRGBCDQBP(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class PXUHPSZGKKT
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker WTUNCBUMNXI;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker VPSTUGZFDYJ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86A45F0", Offset = "0x86A35F0", VA = "0x1886A45F0")]
		public static NativeArray<byte> DCDCUDFHFQX(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86A4A80", Offset = "0x86A3A80", VA = "0x1886A4A80")]
		public static NativeList<byte> NSWFFHXWRQU(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class SITXWIDPMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker TVOUZDKVICI;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker ETYQZZKZEGT;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker JCUNUINPGBW;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker ULCFHHABZKD;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86A53A0", Offset = "0x86A43A0", VA = "0x1886A53A0")]
		public static int JDYMEHCDYNP(QNXPIAAYXFY.FZNFAKTBVRO.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A70", Offset = "0x86A4A70", VA = "0x1886A5A70")]
		public static int SAFFDQUFKBM(QNXPIAAYXFY.FZNFAKTBVRO.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86A5180", Offset = "0x86A4180", VA = "0x1886A5180")]
		private static void FXXGGAXSBII(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, QNXPIAAYXFY.FZNFAKTBVRO.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86A5C70", Offset = "0x86A4C70", VA = "0x1886A5C70")]
		private static void WQNVQSFERCD(QNXPIAAYXFY.FZNFAKTBVRO.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86A6060", Offset = "0x86A5060", VA = "0x1886A6060")]
		private static void XNRUDCEPHLL(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86A4EC0", Offset = "0x86A3EC0", VA = "0x1886A4EC0")]
		private static void FUWCPQDLDOL(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86A5680", Offset = "0x86A4680", VA = "0x1886A5680")]
		private static void LLFPVIISEHA(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86A59B0", Offset = "0x86A49B0", VA = "0x1886A59B0")]
		private static int QOSNUAQJVDP(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86A5900", Offset = "0x86A4900", VA = "0x1886A5900")]
		private static bool MPQXIHJPYYQ(this QNXPIAAYXFY.FZNFAKTBVRO.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86A5BF0", Offset = "0x86A4BF0", VA = "0x1886A5BF0")]
		private static bool WKZEGGVMGZK(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86A5BB0", Offset = "0x86A4BB0", VA = "0x1886A5BB0")]
		private static bool WKZEGGVMGZK(QNXPIAAYXFY.FZNFAKTBVRO.Version a, ByteString b)
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
