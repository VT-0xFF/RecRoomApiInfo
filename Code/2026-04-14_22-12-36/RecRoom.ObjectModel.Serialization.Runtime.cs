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
		[Cpp2IlInjected.Address(RVA = "0x9A6CDB0", Offset = "0x9A6B9B0", VA = "0x189A6CDB0", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface AJWIRGNSFPI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TXTMGFSKEEJ(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SIFQFAPRLAF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class WALKITCNBXA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A6E390", Offset = "0x9A6CF90", VA = "0x189A6E390")]
		public static int BRSYDTGPWVY(OLLICQXCWLL.TCTYKJDUXLX.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9A6E4D0", Offset = "0x9A6D0D0", VA = "0x189A6E4D0")]
		public static void ZCCRVGHZMLQ(OLLICQXCWLL.TCTYKJDUXLX.Version a, [In] ByteString serialized, IEnumerable<AJWIRGNSFPI> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class EYFXRGWBRRE
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker PDIHXVVCYCB;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker OZZXVAPCTBU;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9A6BF00", Offset = "0x9A6AB00", VA = "0x189A6BF00")]
		public static bool ZLLXSOJHBPH(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B7D0", Offset = "0x9A6A3D0", VA = "0x189A6B7D0")]
		public static bool XQUKFZOHFQS(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B940", Offset = "0x9A6A540", VA = "0x189A6B940")]
		public static bool XQUKFZOHFQS(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B5A0", Offset = "0x9A6A1A0", VA = "0x189A6B5A0")]
		public static NativeArray<byte> JNTIZAJYNKV(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B660", Offset = "0x9A6A260", VA = "0x189A6B660")]
		private static bool OVCSLGOPDWT(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B410", Offset = "0x9A6A010", VA = "0x189A6B410")]
		private static bool BKQBZGOSBLE(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B510", Offset = "0x9A6A110", VA = "0x189A6B510")]
		private static bool JMARMZAJKRE(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A6BEB0", Offset = "0x9A6AAB0", VA = "0x189A6BEB0")]
		private static void YNVTXPOZPPS(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B760", Offset = "0x9A6A360", VA = "0x189A6B760")]
		internal static int QHVZZPYJCWR(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B770", Offset = "0x9A6A370", VA = "0x189A6B770")]
		internal static int VGMGQOMFQTS(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HWPEOFQSVCY
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker PDIHXVVCYCB;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker OZZXVAPCTBU;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C830", Offset = "0x9A6B430", VA = "0x189A6C830")]
		public static NativeArray<byte> QQMEEPOQELO(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C4D0", Offset = "0x9A6B0D0", VA = "0x189A6C4D0")]
		public static NativeList<byte> BQPJFLJMXHN(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class VVLFLURFGTG
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker XHHNKSMVTFJ;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker WPBKUVXECSA;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker HDHTFPJXXDR;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker JPOEHVKVLJC;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D090", Offset = "0x9A6BC90", VA = "0x189A6D090")]
		public static int BRSYDTGPWVY(OLLICQXCWLL.TCTYKJDUXLX.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DB90", Offset = "0x9A6C790", VA = "0x189A6DB90")]
		public static int ODIPXNZUIWJ(OLLICQXCWLL.TCTYKJDUXLX.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DCD0", Offset = "0x9A6C8D0", VA = "0x189A6DCD0")]
		private static void PDEDYPOUMST(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, OLLICQXCWLL.TCTYKJDUXLX.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D7A0", Offset = "0x9A6C3A0", VA = "0x189A6D7A0")]
		private static void IXNZCVCBSWE(OLLICQXCWLL.TCTYKJDUXLX.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A6CEB0", Offset = "0x9A6BAB0", VA = "0x189A6CEB0")]
		private static void AJOAQQUZRRY(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D370", Offset = "0x9A6BF70", VA = "0x189A6D370")]
		private static void DGTBMATIBTS(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DEF0", Offset = "0x9A6CAF0", VA = "0x189A6DEF0")]
		private static void PQLQAEGKMAB(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D6E0", Offset = "0x9A6C2E0", VA = "0x189A6D6E0")]
		private static int ETZXPSKYQWU(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A6D630", Offset = "0x9A6C230", VA = "0x189A6D630")]
		private static bool EGBOQKSXZHR(this OLLICQXCWLL.TCTYKJDUXLX.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A6E170", Offset = "0x9A6CD70", VA = "0x189A6E170")]
		private static bool RLNHVBDXPFJ(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A6E1F0", Offset = "0x9A6CDF0", VA = "0x189A6E1F0")]
		private static bool RLNHVBDXPFJ(OLLICQXCWLL.TCTYKJDUXLX.Version a, ByteString b)
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
