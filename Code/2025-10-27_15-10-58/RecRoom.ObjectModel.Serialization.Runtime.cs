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
		[Cpp2IlInjected.Address(RVA = "0x89389E0", Offset = "0x89379E0", VA = "0x1889389E0", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface XNXSSOMDXDN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SLREAEXQTSK(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YTBQRMTMKZK();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class YSHVYACUJSP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8938E90", Offset = "0x8937E90", VA = "0x188938E90")]
		public static int JLFSVPJYLHJ(VHWFVSGXSSU.PGFUJMMTYOK.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8938AE0", Offset = "0x8937AE0", VA = "0x188938AE0")]
		public static void CFOLLXIAOIJ(VHWFVSGXSSU.PGFUJMMTYOK.Version a, [In] ByteString serialized, IEnumerable<XNXSSOMDXDN> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class ZPMRRPZVXWB
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker PATYHRWOWPO;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker XYPQRUDOVKP;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8939AC0", Offset = "0x8938AC0", VA = "0x188939AC0")]
		public static bool YTGYPSWLMFQ(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8939800", Offset = "0x8938800", VA = "0x188939800")]
		public static bool GXHBBHZHUTP(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8939290", Offset = "0x8938290", VA = "0x188939290")]
		public static bool GXHBBHZHUTP(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8938FD0", Offset = "0x8937FD0", VA = "0x188938FD0")]
		public static NativeArray<byte> APXANAVMANU(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8939090", Offset = "0x8938090", VA = "0x188939090")]
		private static bool DIVTOCJXXSY(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8939190", Offset = "0x8938190", VA = "0x188939190")]
		private static bool EONPPGNPYMB(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8939A20", Offset = "0x8938A20", VA = "0x188939A20")]
		private static bool SZFLAPFOQWD(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8939970", Offset = "0x8938970", VA = "0x188939970")]
		private static void JXDALSWMNYJ(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8939AB0", Offset = "0x8938AB0", VA = "0x188939AB0")]
		internal static int VSSMKDFHZAG(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x89399C0", Offset = "0x89389C0", VA = "0x1889399C0")]
		internal static int KKCBHRSEOJV(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class GMFUMPPEBGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker PATYHRWOWPO;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker XYPQRUDOVKP;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8938100", Offset = "0x8937100", VA = "0x188938100")]
		public static NativeArray<byte> HUHAQPGCGIZ(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8938590", Offset = "0x8937590", VA = "0x188938590")]
		public static NativeList<byte> PRRYELAROUO(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class EDUMURCOTWD
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker UAJRDQNOHMW;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker VTZRWRGTTPD;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker DOJZWKHYKIO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker XGKEHKWBSFH;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8937360", Offset = "0x8936360", VA = "0x188937360")]
		public static int JLFSVPJYLHJ(VHWFVSGXSSU.PGFUJMMTYOK.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8937C40", Offset = "0x8936C40", VA = "0x188937C40")]
		public static int YIXSXLIXUMY(VHWFVSGXSSU.PGFUJMMTYOK.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8937D80", Offset = "0x8936D80", VA = "0x188937D80")]
		private static void YJFNNVAHGSG(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, VHWFVSGXSSU.PGFUJMMTYOK.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8936F70", Offset = "0x8935F70", VA = "0x188936F70")]
		private static void JCPDAWYBLBL(VHWFVSGXSSU.PGFUJMMTYOK.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8936CD0", Offset = "0x8935CD0", VA = "0x188936CD0")]
		private static void ETUCGVRJWHZ(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8937980", Offset = "0x8936980", VA = "0x188937980")]
		private static void WZGMKZEMEOZ(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8937640", Offset = "0x8936640", VA = "0x188937640")]
		private static void MVIEAEGTUVO(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8936EB0", Offset = "0x8935EB0", VA = "0x188936EB0")]
		private static int FRRGVEXBLVF(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8936C20", Offset = "0x8935C20", VA = "0x188936C20")]
		private static bool CNDNXFFTFKS(this VHWFVSGXSSU.PGFUJMMTYOK.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x89378C0", Offset = "0x89368C0", VA = "0x1889378C0")]
		private static bool USRZOCNKRZY(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8937940", Offset = "0x8936940", VA = "0x188937940")]
		private static bool USRZOCNKRZY(VHWFVSGXSSU.PGFUJMMTYOK.Version a, ByteString b)
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
