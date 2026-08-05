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
		[Cpp2IlInjected.Address(RVA = "0x9C0E140", Offset = "0x9C0D140", VA = "0x189C0E140", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C0F720", Offset = "0x9C0E720", VA = "0x189C0F720")]
		public static int BRSYDTGPWVY(OLLICQXCWLL.TCTYKJDUXLX.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F860", Offset = "0x9C0E860", VA = "0x189C0F860")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C0D290", Offset = "0x9C0C290", VA = "0x189C0D290")]
		public static bool ZLLXSOJHBPH(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C0CB60", Offset = "0x9C0BB60", VA = "0x189C0CB60")]
		public static bool XQUKFZOHFQS(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C0CCD0", Offset = "0x9C0BCD0", VA = "0x189C0CCD0")]
		public static bool XQUKFZOHFQS(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C930", Offset = "0x9C0B930", VA = "0x189C0C930")]
		public static NativeArray<byte> JNTIZAJYNKV(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C9F0", Offset = "0x9C0B9F0", VA = "0x189C0C9F0")]
		private static bool OVCSLGOPDWT(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C7A0", Offset = "0x9C0B7A0", VA = "0x189C0C7A0")]
		private static bool BKQBZGOSBLE(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C8A0", Offset = "0x9C0B8A0", VA = "0x189C0C8A0")]
		private static bool JMARMZAJKRE(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9C0D240", Offset = "0x9C0C240", VA = "0x189C0D240")]
		private static void YNVTXPOZPPS(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C0CAF0", Offset = "0x9C0BAF0", VA = "0x189C0CAF0")]
		internal static int QHVZZPYJCWR(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9C0CB00", Offset = "0x9C0BB00", VA = "0x189C0CB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C0DBC0", Offset = "0x9C0CBC0", VA = "0x189C0DBC0")]
		public static NativeArray<byte> QQMEEPOQELO(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9C0D860", Offset = "0x9C0C860", VA = "0x189C0D860")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C0E420", Offset = "0x9C0D420", VA = "0x189C0E420")]
		public static int BRSYDTGPWVY(OLLICQXCWLL.TCTYKJDUXLX.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C0EF20", Offset = "0x9C0DF20", VA = "0x189C0EF20")]
		public static int ODIPXNZUIWJ(OLLICQXCWLL.TCTYKJDUXLX.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F060", Offset = "0x9C0E060", VA = "0x189C0F060")]
		private static void PDEDYPOUMST(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, OLLICQXCWLL.TCTYKJDUXLX.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C0EB30", Offset = "0x9C0DB30", VA = "0x189C0EB30")]
		private static void IXNZCVCBSWE(OLLICQXCWLL.TCTYKJDUXLX.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E240", Offset = "0x9C0D240", VA = "0x189C0E240")]
		private static void AJOAQQUZRRY(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E700", Offset = "0x9C0D700", VA = "0x189C0E700")]
		private static void DGTBMATIBTS(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F280", Offset = "0x9C0E280", VA = "0x189C0F280")]
		private static void PQLQAEGKMAB(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C0EA70", Offset = "0x9C0DA70", VA = "0x189C0EA70")]
		private static int ETZXPSKYQWU(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E9C0", Offset = "0x9C0D9C0", VA = "0x189C0E9C0")]
		private static bool EGBOQKSXZHR(this OLLICQXCWLL.TCTYKJDUXLX.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F500", Offset = "0x9C0E500", VA = "0x189C0F500")]
		private static bool RLNHVBDXPFJ(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F580", Offset = "0x9C0E580", VA = "0x189C0F580")]
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
