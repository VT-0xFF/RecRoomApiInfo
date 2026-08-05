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
		[Cpp2IlInjected.Address(RVA = "0x87A07D0", Offset = "0x879F5D0", VA = "0x1887A07D0", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface CVOVZHTPBEJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KIAMMTSMYTG(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PUOFOOQAOVA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class CQNTXHGHWER
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x879D490", Offset = "0x879C290", VA = "0x18879D490")]
		public static int GXJHGRBYWKN(ZYQDLLXBNSW.NGCTHUAORUY.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x879D5D0", Offset = "0x879C3D0", VA = "0x18879D5D0")]
		public static void UZXYHRMYAOP(ZYQDLLXBNSW.NGCTHUAORUY.Version a, [In] ByteString serialized, IEnumerable<CVOVZHTPBEJ> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class KCPBLQQYFYD
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker FHJHTJVNIRA;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker ZSPYZDDCUVL;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x879F980", Offset = "0x879E780", VA = "0x18879F980")]
		public static bool MSSHHSBBNKE(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x879FF20", Offset = "0x879ED20", VA = "0x18879FF20")]
		public static bool SNZPTSFWWZF(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87A0090", Offset = "0x879EE90", VA = "0x1887A0090")]
		public static bool SNZPTSFWWZF(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x879FE60", Offset = "0x879EC60", VA = "0x18879FE60")]
		public static NativeArray<byte> MTKLNFUBVTO(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x87A05F0", Offset = "0x879F3F0", VA = "0x1887A05F0")]
		private static bool UPJICTGQNKG(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x879F870", Offset = "0x879E670", VA = "0x18879F870")]
		private static bool FNUKTKRCUUL(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x879F730", Offset = "0x879E530", VA = "0x18879F730")]
		private static bool CSNALBJMYCV(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x879F7C0", Offset = "0x879E5C0", VA = "0x18879F7C0")]
		private static void EMUPPGKYJXN(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x879F970", Offset = "0x879E770", VA = "0x18879F970")]
		internal static int GNFKARQSVLG(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x879F810", Offset = "0x879E610", VA = "0x18879F810")]
		internal static int FELDPNDDDUF(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class JWOAFPZQDWH
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker FHJHTJVNIRA;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker ZSPYZDDCUVL;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x879F1C0", Offset = "0x879DFC0", VA = "0x18879F1C0")]
		public static NativeArray<byte> TGUTIXLHRMP(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x879EE60", Offset = "0x879DC60", VA = "0x18879EE60")]
		public static NativeList<byte> DQSEUONJFZC(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class IODTWDQXITT
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker IAIORAYWOUU;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker TYVZJDBQROH;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker CPVBBORQCTK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker SHNPFUEHLHZ;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x879DD70", Offset = "0x879CB70", VA = "0x18879DD70")]
		public static int GXJHGRBYWKN(ZYQDLLXBNSW.NGCTHUAORUY.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x879D990", Offset = "0x879C790", VA = "0x18879D990")]
		public static int AFOEVJGOXKG(ZYQDLLXBNSW.NGCTHUAORUY.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x879E310", Offset = "0x879D110", VA = "0x18879E310")]
		private static void MQMBKNOUJTK(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, ZYQDLLXBNSW.NGCTHUAORUY.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x879E860", Offset = "0x879D660", VA = "0x18879E860")]
		private static void XXJIZXPUMKH(ZYQDLLXBNSW.NGCTHUAORUY.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x879DAD0", Offset = "0x879C8D0", VA = "0x18879DAD0")]
		private static void AGERGYTREOJ(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x879E050", Offset = "0x879CE50", VA = "0x18879E050")]
		private static void JQSZSHPHTIH(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x879E5E0", Offset = "0x879D3E0", VA = "0x18879E5E0")]
		private static void VFLXAFEPSTI(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x879EC50", Offset = "0x879DA50", VA = "0x18879EC50")]
		private static int ZMHDEPQCJQF(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x879E530", Offset = "0x879D330", VA = "0x18879E530")]
		private static bool UUZCDNHNCSU(this ZYQDLLXBNSW.NGCTHUAORUY.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x879DCF0", Offset = "0x879CAF0", VA = "0x18879DCF0")]
		private static bool DCNYPEFJMNC(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x879DCB0", Offset = "0x879CAB0", VA = "0x18879DCB0")]
		private static bool DCNYPEFJMNC(ZYQDLLXBNSW.NGCTHUAORUY.Version a, ByteString b)
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
