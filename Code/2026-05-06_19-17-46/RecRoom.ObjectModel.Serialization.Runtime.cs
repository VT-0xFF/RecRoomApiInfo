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
		[Cpp2IlInjected.Address(RVA = "0x9A7A120", Offset = "0x9A78B20", VA = "0x189A7A120", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A79FE0", Offset = "0x9A789E0", VA = "0x189A79FE0")]
		public static int YSTUTRBFEKU(NZYRHBLOQHB.UJFQYTKYYVN.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9A79C30", Offset = "0x9A78630", VA = "0x189A79C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A7AC40", Offset = "0x9A79640", VA = "0x189A7AC40")]
		public static bool QRITAURRAAD(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A220", Offset = "0x9A78C20", VA = "0x189A7A220")]
		public static bool ARRWXBGFMBO(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A390", Offset = "0x9A78D90", VA = "0x189A7A390")]
		public static bool ARRWXBGFMBO(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A7B120", Offset = "0x9A79B20", VA = "0x189A7B120")]
		public static NativeArray<byte> WJLKYDFPWYP(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A990", Offset = "0x9A79390", VA = "0x189A7A990")]
		private static bool EIPHVTGQTUN(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9A7AA90", Offset = "0x9A79490", VA = "0x189A7AA90")]
		private static bool HUZICVOANCA(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A900", Offset = "0x9A79300", VA = "0x189A7A900")]
		private static bool BESDJZKYINW(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A7AB90", Offset = "0x9A79590", VA = "0x189A7AB90")]
		private static void JUTOCITKTKW(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9A7B1E0", Offset = "0x9A79BE0", VA = "0x189A7B1E0")]
		internal static int ZGSOGCNFDMH(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A7ABE0", Offset = "0x9A795E0", VA = "0x189A7ABE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A796B0", Offset = "0x9A780B0", VA = "0x189A796B0")]
		public static NativeArray<byte> LVWFXWBNGKK(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9A79350", Offset = "0x9A77D50", VA = "0x189A79350")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A78CF0", Offset = "0x9A776F0", VA = "0x189A78CF0")]
		public static int YSTUTRBFEKU(NZYRHBLOQHB.UJFQYTKYYVN.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A78590", Offset = "0x9A76F90", VA = "0x189A78590")]
		public static int GJJIBJNOXXR(NZYRHBLOQHB.UJFQYTKYYVN.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A78FD0", Offset = "0x9A779D0", VA = "0x189A78FD0")]
		private static void YYGPFPUNJPP(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, NZYRHBLOQHB.UJFQYTKYYVN.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A77F20", Offset = "0x9A76920", VA = "0x189A77F20")]
		private static void BIJTSKMXPDQ(NZYRHBLOQHB.UJFQYTKYYVN.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A78A50", Offset = "0x9A77450", VA = "0x189A78A50")]
		private static void XDYDRLFIWFS(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A786D0", Offset = "0x9A770D0", VA = "0x189A786D0")]
		private static void IBZJWKHMPWS(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A78310", Offset = "0x9A76D10", VA = "0x189A78310")]
		private static void EZYXQUXAFLV(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A78990", Offset = "0x9A77390", VA = "0x189A78990")]
		private static int KWUQZSFKTXE(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A77E70", Offset = "0x9A76870", VA = "0x189A77E70")]
		private static bool AXDICAHBSVP(this NZYRHBLOQHB.UJFQYTKYYVN.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A78C30", Offset = "0x9A77630", VA = "0x189A78C30")]
		private static bool YBODAJWQQXX(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A78CB0", Offset = "0x9A776B0", VA = "0x189A78CB0")]
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
