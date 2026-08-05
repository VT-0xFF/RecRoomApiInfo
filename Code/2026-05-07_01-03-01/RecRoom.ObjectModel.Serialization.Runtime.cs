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
		[Cpp2IlInjected.Address(RVA = "0x9A52ED0", Offset = "0x9A518D0", VA = "0x189A52ED0", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A529E0", Offset = "0x9A513E0", VA = "0x189A529E0")]
		public static int ODUFDOENDRI(YICQGXILDQB.TITDVGJTICR.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9A52B20", Offset = "0x9A51520", VA = "0x189A52B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A539C0", Offset = "0x9A523C0", VA = "0x189A539C0")]
		public static bool XDRCGUEPYGB(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A53220", Offset = "0x9A51C20", VA = "0x189A53220")]
		public static bool UHKBPJFHXTY(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A53390", Offset = "0x9A51D90", VA = "0x189A53390")]
		public static bool UHKBPJFHXTY(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A53900", Offset = "0x9A52300", VA = "0x189A53900")]
		public static NativeArray<byte> VEAIOFXDJXX(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A530D0", Offset = "0x9A51AD0", VA = "0x189A530D0")]
		private static bool PFJUDTKIVLF(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9A53EA0", Offset = "0x9A528A0", VA = "0x189A53EA0")]
		private static bool YJPUKTZZEVI(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9A52FE0", Offset = "0x9A519E0", VA = "0x189A52FE0")]
		private static bool EQJQNOUWHUW(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A531D0", Offset = "0x9A51BD0", VA = "0x189A531D0")]
		private static void QLFLSOUNNZS(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9A52FD0", Offset = "0x9A519D0", VA = "0x189A52FD0")]
		internal static int BXSGXLKITFT(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A53070", Offset = "0x9A51A70", VA = "0x189A53070")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A52460", Offset = "0x9A50E60", VA = "0x189A52460")]
		public static NativeArray<byte> URXSTNDYLGA(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9A52100", Offset = "0x9A50B00", VA = "0x189A52100")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A51940", Offset = "0x9A50340", VA = "0x189A51940")]
		public static int ODUFDOENDRI(YICQGXILDQB.TITDVGJTICR.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A51800", Offset = "0x9A50200", VA = "0x189A51800")]
		public static int LYCTRDQFVYV(YICQGXILDQB.TITDVGJTICR.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A51080", Offset = "0x9A4FA80", VA = "0x189A51080")]
		private static void HMIWXUECBCD(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, YICQGXILDQB.TITDVGJTICR.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A512A0", Offset = "0x9A4FCA0", VA = "0x189A512A0")]
		private static void HMJPZQNZIZC(YICQGXILDQB.TITDVGJTICR.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A50EA0", Offset = "0x9A4F8A0", VA = "0x189A50EA0")]
		private static void GNUFILJJQUS(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A51C20", Offset = "0x9A50620", VA = "0x189A51C20")]
		private static void UVVEHVYJOZG(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A50C20", Offset = "0x9A4F620", VA = "0x189A50C20")]
		private static void ALTEBGQSLSV(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A51EE0", Offset = "0x9A508E0", VA = "0x189A51EE0")]
		private static int ZQPLXMHXBXS(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A51690", Offset = "0x9A50090", VA = "0x189A51690")]
		private static bool JWGJCRYWTQD(this YICQGXILDQB.TITDVGJTICR.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A51780", Offset = "0x9A50180", VA = "0x189A51780")]
		private static bool LQKNCGUZAPN(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A51740", Offset = "0x9A50140", VA = "0x189A51740")]
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
