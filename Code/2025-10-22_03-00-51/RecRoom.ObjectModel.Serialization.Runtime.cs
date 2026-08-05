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
		[Cpp2IlInjected.Address(RVA = "0x871AEE0", Offset = "0x87194E0", VA = "0x18871AEE0", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface TQRLPLWUEBQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OCFYVUOOCXL(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KQPXXDZDTRT();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class QYFLSAJGGWW
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x871B390", Offset = "0x8719990", VA = "0x18871B390")]
		public static int VCOHRXMDMJA(LKQJPXEYMQJ.NVAURJSHQDD.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x871AFE0", Offset = "0x87195E0", VA = "0x18871AFE0")]
		public static void NMBQKOKXRTU(LKQJPXEYMQJ.NVAURJSHQDD.Version a, [In] ByteString serialized, IEnumerable<TQRLPLWUEBQ> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class TQGUQQYDVNU
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker HECJKWOEXRH;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker GJKZPUHSYNQ;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x871BC00", Offset = "0x871A200", VA = "0x18871BC00")]
		public static bool CHICKIDJRAF(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x871BA30", Offset = "0x871A030", VA = "0x18871BA30")]
		public static bool AOOHQJOKWNM(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x871B4D0", Offset = "0x8719AD0", VA = "0x18871B4D0")]
		public static bool AOOHQJOKWNM(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x871C0E0", Offset = "0x871A6E0", VA = "0x18871C0E0")]
		public static NativeArray<byte> FDOOFJZOKUF(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x871C230", Offset = "0x871A830", VA = "0x18871C230")]
		private static bool LCIHCNHSUUD(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x871C340", Offset = "0x871A940", VA = "0x18871C340")]
		private static bool VMKWTERFJCO(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x871C1A0", Offset = "0x871A7A0", VA = "0x18871C1A0")]
		private static bool KTUKNVKVJRA(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x871C440", Offset = "0x871AA40", VA = "0x18871C440")]
		private static void YKRRHMZYFFO(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x871C330", Offset = "0x871A930", VA = "0x18871C330")]
		internal static int QUBHMOSUVKN(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x871BBA0", Offset = "0x871A1A0", VA = "0x18871BBA0")]
		internal static int AULHFAGNRKA(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class BUWJKVEFTWI
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker HECJKWOEXRH;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker GJKZPUHSYNQ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x871A610", Offset = "0x8718C10", VA = "0x18871A610")]
		public static NativeArray<byte> DQAAQQXLKYE(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x871AAA0", Offset = "0x87190A0", VA = "0x18871AAA0")]
		public static NativeList<byte> UHCNGNQPGFF(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class TQXZEVLNYLW
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker CJIOUTOOWXJ;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker BSJOWYOMKOA;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker PXVQLYMWPEH;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker IPKJAXFUOZG;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x871D290", Offset = "0x871B890", VA = "0x18871D290")]
		public static int VCOHRXMDMJA(LKQJPXEYMQJ.NVAURJSHQDD.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x871CF70", Offset = "0x871B570", VA = "0x18871CF70")]
		public static int RUKXOBKKSIV(LKQJPXEYMQJ.NVAURJSHQDD.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x871C570", Offset = "0x871AB70", VA = "0x18871C570")]
		private static void EFYAGUBAFNJ(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, LKQJPXEYMQJ.NVAURJSHQDD.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x871C850", Offset = "0x871AE50", VA = "0x18871C850")]
		private static void IEPAUDWEKGU(LKQJPXEYMQJ.NVAURJSHQDD.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x871D0B0", Offset = "0x871B6B0", VA = "0x18871D0B0")]
		private static void TYXUQGJFRUS(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x871D630", Offset = "0x871BC30", VA = "0x18871D630")]
		private static void XPLAKZETFTC(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x871CCF0", Offset = "0x871B2F0", VA = "0x18871CCF0")]
		private static void RSZEWHNGJWZ(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x871D570", Offset = "0x871BB70", VA = "0x18871D570")]
		private static int VKWQBDWHGFG(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x871CC40", Offset = "0x871B240", VA = "0x18871CC40")]
		private static bool KDLJTVYNFMH(this LKQJPXEYMQJ.NVAURJSHQDD.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x871C790", Offset = "0x871AD90", VA = "0x18871C790")]
		private static bool EKCHGEVDRPV(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x871C810", Offset = "0x871AE10", VA = "0x18871C810")]
		private static bool EKCHGEVDRPV(LKQJPXEYMQJ.NVAURJSHQDD.Version a, ByteString b)
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
