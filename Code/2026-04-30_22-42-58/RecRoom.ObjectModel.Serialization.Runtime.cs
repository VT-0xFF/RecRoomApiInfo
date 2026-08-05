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
		[Cpp2IlInjected.Address(RVA = "0x99A6D10", Offset = "0x99A6110", VA = "0x1899A6D10", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface GHSAEABTOZW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RNDEKDVWNHB(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GZVUEGYMGMP();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ESIOGSOWCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99A6BD0", Offset = "0x99A5FD0", VA = "0x1899A6BD0")]
		public static int YSTUTRBFEKU(NZYRHBLOQHB.UJFQYTKYYVN.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99A6810", Offset = "0x99A5C10", VA = "0x1899A6810")]
		public static void FKYGQEJXFYE(NZYRHBLOQHB.UJFQYTKYYVN.Version a, [In] ByteString serialized, IEnumerable<GHSAEABTOZW> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class XMCMPMYPVDG
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker AHXGXIGUQKP;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker CEWTHLHPBOY;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99A7820", Offset = "0x99A6C20", VA = "0x1899A7820")]
		public static bool QRITAURRAAD(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99A6E10", Offset = "0x99A6210", VA = "0x1899A6E10")]
		public static bool ARRWXBGFMBO(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99A6F80", Offset = "0x99A6380", VA = "0x1899A6F80")]
		public static bool ARRWXBGFMBO(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99A7D00", Offset = "0x99A7100", VA = "0x1899A7D00")]
		public static NativeArray<byte> WJLKYDFPWYP(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99A7570", Offset = "0x99A6970", VA = "0x1899A7570")]
		private static bool EIPHVTGQTUN(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99A7670", Offset = "0x99A6A70", VA = "0x1899A7670")]
		private static bool HUZICVOANCA(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99A74E0", Offset = "0x99A68E0", VA = "0x1899A74E0")]
		private static bool BESDJZKYINW(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99A7770", Offset = "0x99A6B70", VA = "0x1899A7770")]
		private static void JUTOCITKTKW(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99A7DC0", Offset = "0x99A71C0", VA = "0x1899A7DC0")]
		internal static int ZGSOGCNFDMH(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99A77C0", Offset = "0x99A6BC0", VA = "0x1899A77C0")]
		internal static int NMIXBXQVIDM(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class CPBKYFBOUBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker AHXGXIGUQKP;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker CEWTHLHPBOY;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99A62A0", Offset = "0x99A56A0", VA = "0x1899A62A0")]
		public static NativeArray<byte> LVWFXWBNGKK(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99A5F40", Offset = "0x99A5340", VA = "0x1899A5F40")]
		public static NativeList<byte> DEOVKLRIVOJ(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class AVJOJOLMRYW
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker GBUDIKPMXZD;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker QPHDFQLLEOK;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker EUSXGZMLTIR;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker JRLSUSWXLDI;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99A58F0", Offset = "0x99A4CF0", VA = "0x1899A58F0")]
		public static int YSTUTRBFEKU(NZYRHBLOQHB.UJFQYTKYYVN.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99A5190", Offset = "0x99A4590", VA = "0x1899A5190")]
		public static int GJJIBJNOXXR(NZYRHBLOQHB.UJFQYTKYYVN.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99A5BD0", Offset = "0x99A4FD0", VA = "0x1899A5BD0")]
		private static void YYGPFPUNJPP(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, NZYRHBLOQHB.UJFQYTKYYVN.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99A4B20", Offset = "0x99A3F20", VA = "0x1899A4B20")]
		private static void BIJTSKMXPDQ(NZYRHBLOQHB.UJFQYTKYYVN.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99A5650", Offset = "0x99A4A50", VA = "0x1899A5650")]
		private static void XDYDRLFIWFS(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99A52D0", Offset = "0x99A46D0", VA = "0x1899A52D0")]
		private static void IBZJWKHMPWS(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99A4F10", Offset = "0x99A4310", VA = "0x1899A4F10")]
		private static void EZYXQUXAFLV(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x99A5590", Offset = "0x99A4990", VA = "0x1899A5590")]
		private static int KWUQZSFKTXE(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99A4A70", Offset = "0x99A3E70", VA = "0x1899A4A70")]
		private static bool AXDICAHBSVP(this NZYRHBLOQHB.UJFQYTKYYVN.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99A5830", Offset = "0x99A4C30", VA = "0x1899A5830")]
		private static bool YBODAJWQQXX(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99A58B0", Offset = "0x99A4CB0", VA = "0x1899A58B0")]
		private static bool YBODAJWQQXX(NZYRHBLOQHB.UJFQYTKYYVN.Version a, ByteString b)
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
