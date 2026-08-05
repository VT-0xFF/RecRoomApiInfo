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
		[Cpp2IlInjected.Address(RVA = "0x9BDD310", Offset = "0x9BDBD10", VA = "0x189BDD310", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface QIBIVNUGRDG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ETGNTCDUBJF(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WSFSWRIEDET();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class NMSGFPFQSOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9BDD410", Offset = "0x9BDBE10", VA = "0x189BDD410")]
		public static int BCYAPCSBZRS(XPTGKDMPWQP.HDTPLDNTADR.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BDD550", Offset = "0x9BDBF50", VA = "0x189BDD550")]
		public static void KQBIGEISUHS(XPTGKDMPWQP.HDTPLDNTADR.Version a, [In] ByteString serialized, IEnumerable<QIBIVNUGRDG> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class XYKLRXOWYXS
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker SQAKUFMZXYX;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker JIKSWBRTFEE;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9BDF8E0", Offset = "0x9BDE2E0", VA = "0x189BDF8E0")]
		public static bool ZEUPAHGNKJZ(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9BDEE60", Offset = "0x9BDD860", VA = "0x189BDEE60")]
		public static bool PBZIISSUCMY(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9BDEFD0", Offset = "0x9BDD9D0", VA = "0x189BDEFD0")]
		public static bool PBZIISSUCMY(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9BDF540", Offset = "0x9BDDF40", VA = "0x189BDF540")]
		public static NativeArray<byte> RZROMMFIYEP(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9BDF7E0", Offset = "0x9BDE1E0", VA = "0x189BDF7E0")]
		private static bool YRRFVFAONJL(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9BDF690", Offset = "0x9BDE090", VA = "0x189BDF690")]
		private static bool WYLUGDXMCNW(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9BDF600", Offset = "0x9BDE000", VA = "0x189BDF600")]
		private static bool WYHFECOXGZW(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9BDF790", Offset = "0x9BDE190", VA = "0x189BDF790")]
		private static void XPHUEWCPVVA(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9BDEDF0", Offset = "0x9BDD7F0", VA = "0x189BDEDF0")]
		internal static int HNAHRBKROYL(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9BDEE00", Offset = "0x9BDD800", VA = "0x189BDEE00")]
		internal static int IHCKHYMHQGG(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HFPLGRZATXU
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker SQAKUFMZXYX;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker JIKSWBRTFEE;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9BDCD90", Offset = "0x9BDB790", VA = "0x189BDCD90")]
		public static NativeArray<byte> VTTFQVGVQMW(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9BDCA30", Offset = "0x9BDB430", VA = "0x189BDCA30")]
		public static NativeList<byte> DKKPZCKLEEB(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class VZCQOIQXCJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker CDXJVZIJSRH;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker CTHHDXPALZA;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker JRBDSXOMUHH;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker EOOZFZDXYFY;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDAF0", Offset = "0x9BDC4F0", VA = "0x189BDDAF0")]
		public static int BCYAPCSBZRS(XPTGKDMPWQP.HDTPLDNTADR.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9BDE150", Offset = "0x9BDCB50", VA = "0x189BDE150")]
		public static int HFAMURKYVWL(XPTGKDMPWQP.HDTPLDNTADR.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9BDE900", Offset = "0x9BDD300", VA = "0x189BDE900")]
		private static void QZUMEFSNUMJ(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, XPTGKDMPWQP.HDTPLDNTADR.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9BDE290", Offset = "0x9BDCC90", VA = "0x189BDE290")]
		private static void OOFHKSLTIQC(XPTGKDMPWQP.HDTPLDNTADR.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9BDD910", Offset = "0x9BDC310", VA = "0x189BDD910")]
		private static void AADPVLSJXCM(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDE90", Offset = "0x9BDC890", VA = "0x189BDDE90")]
		private static void DXNXXBMFYLM(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9BDE680", Offset = "0x9BDD080", VA = "0x189BDE680")]
		private static void QVPYAUBOSUP(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDDD0", Offset = "0x9BDC7D0", VA = "0x189BDDDD0")]
		private static int BOGRDRWWLVA(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9BDEBE0", Offset = "0x9BDD5E0", VA = "0x189BDEBE0")]
		private static bool XFLNVQTGSMZ(this XPTGKDMPWQP.HDTPLDNTADR.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9BDEB20", Offset = "0x9BDD520", VA = "0x189BDEB20")]
		private static bool SCRSYIZPGFT(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9BDEBA0", Offset = "0x9BDD5A0", VA = "0x189BDEBA0")]
		private static bool SCRSYIZPGFT(XPTGKDMPWQP.HDTPLDNTADR.Version a, ByteString b)
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
