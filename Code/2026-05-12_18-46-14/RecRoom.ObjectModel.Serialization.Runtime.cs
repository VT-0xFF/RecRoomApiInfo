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
		[Cpp2IlInjected.Address(RVA = "0x9BB29B0", Offset = "0x9BB13B0", VA = "0x189BB29B0", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface ICZWDBBYBKW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CWCNQTWBXXL(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QCIVJGOFOSZ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class DOHDHKDBPPU
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9BB24C0", Offset = "0x9BB0EC0", VA = "0x189BB24C0")]
		public static int ODUFDOENDRI(YICQGXILDQB.TITDVGJTICR.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BB2600", Offset = "0x9BB1000", VA = "0x189BB2600")]
		public static void RXAPPYXTXOK(YICQGXILDQB.TITDVGJTICR.Version a, [In] ByteString serialized, IEnumerable<ICZWDBBYBKW> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class QMDEDFNTSRU
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker ZJKINQLVPXH;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker XKNZPVBTWCC;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3490", Offset = "0x9BB1E90", VA = "0x189BB3490")]
		public static bool XDRCGUEPYGB(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9BB2D00", Offset = "0x9BB1700", VA = "0x189BB2D00")]
		public static bool UHKBPJFHXTY(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9BB2E70", Offset = "0x9BB1870", VA = "0x189BB2E70")]
		public static bool UHKBPJFHXTY(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9BB33D0", Offset = "0x9BB1DD0", VA = "0x189BB33D0")]
		public static NativeArray<byte> VEAIOFXDJXX(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9BB2BB0", Offset = "0x9BB15B0", VA = "0x189BB2BB0")]
		private static bool PFJUDTKIVLF(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3970", Offset = "0x9BB2370", VA = "0x189BB3970")]
		private static bool YJPUKTZZEVI(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9BB2AC0", Offset = "0x9BB14C0", VA = "0x189BB2AC0")]
		private static bool EQJQNOUWHUW(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9BB2CB0", Offset = "0x9BB16B0", VA = "0x189BB2CB0")]
		private static void QLFLSOUNNZS(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9BB2AB0", Offset = "0x9BB14B0", VA = "0x189BB2AB0")]
		internal static int BXSGXLKITFT(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9BB2B50", Offset = "0x9BB1550", VA = "0x189BB2B50")]
		internal static int OKLLOEAQDSU(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class BESRTGGHTTC
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker ZJKINQLVPXH;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker XKNZPVBTWCC;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1F50", Offset = "0x9BB0950", VA = "0x189BB1F50")]
		public static NativeArray<byte> URXSTNDYLGA(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1BF0", Offset = "0x9BB05F0", VA = "0x189BB1BF0")]
		public static NativeList<byte> DBPUSHACFNF(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class AWZTTLDBYPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker KIADDKWPHBN;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker TDEXWQZHLFC;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker MQUKAAKQLVJ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker LRQUPTMCODO;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1440", Offset = "0x9BAFE40", VA = "0x189BB1440")]
		public static int ODUFDOENDRI(YICQGXILDQB.TITDVGJTICR.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1300", Offset = "0x9BAFD00", VA = "0x189BB1300")]
		public static int LYCTRDQFVYV(YICQGXILDQB.TITDVGJTICR.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9BB0B80", Offset = "0x9BAF580", VA = "0x189BB0B80")]
		private static void HMIWXUECBCD(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, YICQGXILDQB.TITDVGJTICR.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9BB0DA0", Offset = "0x9BAF7A0", VA = "0x189BB0DA0")]
		private static void HMJPZQNZIZC(YICQGXILDQB.TITDVGJTICR.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9BB09A0", Offset = "0x9BAF3A0", VA = "0x189BB09A0")]
		private static void GNUFILJJQUS(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1720", Offset = "0x9BB0120", VA = "0x189BB1720")]
		private static void UVVEHVYJOZG(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9BB0720", Offset = "0x9BAF120", VA = "0x189BB0720")]
		private static void ALTEBGQSLSV(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9BB19E0", Offset = "0x9BB03E0", VA = "0x189BB19E0")]
		private static int ZQPLXMHXBXS(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1190", Offset = "0x9BAFB90", VA = "0x189BB1190")]
		private static bool JWGJCRYWTQD(this YICQGXILDQB.TITDVGJTICR.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1280", Offset = "0x9BAFC80", VA = "0x189BB1280")]
		private static bool LQKNCGUZAPN(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1240", Offset = "0x9BAFC40", VA = "0x189BB1240")]
		private static bool LQKNCGUZAPN(YICQGXILDQB.TITDVGJTICR.Version a, ByteString b)
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
