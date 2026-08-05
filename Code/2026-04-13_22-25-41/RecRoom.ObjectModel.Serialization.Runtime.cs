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
		[Cpp2IlInjected.Address(RVA = "0x9A6B300", Offset = "0x9A69D00", VA = "0x189A6B300", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A6C8E0", Offset = "0x9A6B2E0", VA = "0x189A6C8E0")]
		public static int BRSYDTGPWVY(OLLICQXCWLL.TCTYKJDUXLX.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9A6CA20", Offset = "0x9A6B420", VA = "0x189A6CA20")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A6A450", Offset = "0x9A68E50", VA = "0x189A6A450")]
		public static bool ZLLXSOJHBPH(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A69D20", Offset = "0x9A68720", VA = "0x189A69D20")]
		public static bool XQUKFZOHFQS(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A69E90", Offset = "0x9A68890", VA = "0x189A69E90")]
		public static bool XQUKFZOHFQS(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A69AF0", Offset = "0x9A684F0", VA = "0x189A69AF0")]
		public static NativeArray<byte> JNTIZAJYNKV(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A69BB0", Offset = "0x9A685B0", VA = "0x189A69BB0")]
		private static bool OVCSLGOPDWT(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9A69960", Offset = "0x9A68360", VA = "0x189A69960")]
		private static bool BKQBZGOSBLE(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9A69A60", Offset = "0x9A68460", VA = "0x189A69A60")]
		private static bool JMARMZAJKRE(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A6A400", Offset = "0x9A68E00", VA = "0x189A6A400")]
		private static void YNVTXPOZPPS(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9A69CB0", Offset = "0x9A686B0", VA = "0x189A69CB0")]
		internal static int QHVZZPYJCWR(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A69CC0", Offset = "0x9A686C0", VA = "0x189A69CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A6AD80", Offset = "0x9A69780", VA = "0x189A6AD80")]
		public static NativeArray<byte> QQMEEPOQELO(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9A6AA20", Offset = "0x9A69420", VA = "0x189A6AA20")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A6B5E0", Offset = "0x9A69FE0", VA = "0x189A6B5E0")]
		public static int BRSYDTGPWVY(OLLICQXCWLL.TCTYKJDUXLX.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C0E0", Offset = "0x9A6AAE0", VA = "0x189A6C0E0")]
		public static int ODIPXNZUIWJ(OLLICQXCWLL.TCTYKJDUXLX.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C220", Offset = "0x9A6AC20", VA = "0x189A6C220")]
		private static void PDEDYPOUMST(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, OLLICQXCWLL.TCTYKJDUXLX.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A6BCF0", Offset = "0x9A6A6F0", VA = "0x189A6BCF0")]
		private static void IXNZCVCBSWE(OLLICQXCWLL.TCTYKJDUXLX.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B400", Offset = "0x9A69E00", VA = "0x189A6B400")]
		private static void AJOAQQUZRRY(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B8C0", Offset = "0x9A6A2C0", VA = "0x189A6B8C0")]
		private static void DGTBMATIBTS(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C440", Offset = "0x9A6AE40", VA = "0x189A6C440")]
		private static void PQLQAEGKMAB(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A6BC30", Offset = "0x9A6A630", VA = "0x189A6BC30")]
		private static int ETZXPSKYQWU(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A6BB80", Offset = "0x9A6A580", VA = "0x189A6BB80")]
		private static bool EGBOQKSXZHR(this OLLICQXCWLL.TCTYKJDUXLX.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C6C0", Offset = "0x9A6B0C0", VA = "0x189A6C6C0")]
		private static bool RLNHVBDXPFJ(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A6C740", Offset = "0x9A6B140", VA = "0x189A6C740")]
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
