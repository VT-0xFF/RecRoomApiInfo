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
		[Cpp2IlInjected.Address(RVA = "0x8C330D0", Offset = "0x8C31CD0", VA = "0x188C330D0", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IHQJYKXDQLV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EJMRIKZVQIG(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Register();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class SDCPZSQUQML
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C34290", Offset = "0x8C32E90", VA = "0x188C34290")]
		public static int CNCAYFQSLFJ(PAIASMSNXTK.MMDAOZKJIDU.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C343D0", Offset = "0x8C32FD0", VA = "0x188C343D0")]
		public static void PHRWMHFHGUN(PAIASMSNXTK.MMDAOZKJIDU.Version a, [In] ByteString serialized, IEnumerable<IHQJYKXDQLV> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class QXOXSBYPHJH
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker MNDZEDUVBXG;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker LIHROTMTUBB;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C33CC0", Offset = "0x8C328C0", VA = "0x188C33CC0")]
		public static bool ZMGZTBMRCKS(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C331D0", Offset = "0x8C31DD0", VA = "0x188C331D0")]
		public static bool AOGFRSDQRHX(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C33340", Offset = "0x8C31F40", VA = "0x188C33340")]
		public static bool AOGFRSDQRHX(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C33BA0", Offset = "0x8C327A0", VA = "0x188C33BA0")]
		public static NativeArray<byte> YUMIIEXYHSC(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8C338C0", Offset = "0x8C324C0", VA = "0x188C338C0")]
		private static bool IETOMTLOADW(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8C33A10", Offset = "0x8C32610", VA = "0x188C33A10")]
		private static bool KYETWJMYDNP(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C33B10", Offset = "0x8C32710", VA = "0x188C33B10")]
		private static bool OKZJZZPNBTB(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C339C0", Offset = "0x8C325C0", VA = "0x188C339C0")]
		private static void JLHTQBJFZNL(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C338B0", Offset = "0x8C324B0", VA = "0x188C338B0")]
		internal static int DAXKNOGNGXA(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8C33C60", Offset = "0x8C32860", VA = "0x188C33C60")]
		internal static int YUVBORPPUVJ(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class LFQSYNGJNIZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker MNDZEDUVBXG;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker LIHROTMTUBB;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C327F0", Offset = "0x8C313F0", VA = "0x188C327F0")]
		public static NativeArray<byte> BVFJSXAAMZD(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8C32C80", Offset = "0x8C31880", VA = "0x188C32C80")]
		public static NativeList<byte> EUKSYNBFZKS(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class BDRMWXCAZAT
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker MQBDVOBZPOG;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker UAGUWLYDBLP;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker SGZHWJDXWZA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker CBKNEILSMTP;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8C31530", Offset = "0x8C30130", VA = "0x188C31530")]
		public static int CNCAYFQSLFJ(PAIASMSNXTK.MMDAOZKJIDU.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8C31EA0", Offset = "0x8C30AA0", VA = "0x188C31EA0")]
		public static int KLCCYYSLCGI(PAIASMSNXTK.MMDAOZKJIDU.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8C31310", Offset = "0x8C2FF10", VA = "0x188C31310")]
		private static void CBWNXTOYVWO(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, PAIASMSNXTK.MMDAOZKJIDU.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8C31AB0", Offset = "0x8C306B0", VA = "0x188C31AB0")]
		private static void IIOHNILZGKZ(PAIASMSNXTK.MMDAOZKJIDU.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8C318D0", Offset = "0x8C304D0", VA = "0x188C318D0")]
		private static void HBLGQXEOGCX(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8C32320", Offset = "0x8C30F20", VA = "0x188C32320")]
		private static void VVHKUNRGKZP(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8C320A0", Offset = "0x8C30CA0", VA = "0x188C320A0")]
		private static void UEOSRKRDOWQ(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8C31810", Offset = "0x8C30410", VA = "0x188C31810")]
		private static int GQQSUZQWCLZ(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8C325E0", Offset = "0x8C311E0", VA = "0x188C325E0")]
		private static bool WETWWRMZWJU(this PAIASMSNXTK.MMDAOZKJIDU.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8C31FE0", Offset = "0x8C30BE0", VA = "0x188C31FE0")]
		private static bool SRAEKCRZDMG(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8C32060", Offset = "0x8C30C60", VA = "0x188C32060")]
		private static bool SRAEKCRZDMG(PAIASMSNXTK.MMDAOZKJIDU.Version a, ByteString b)
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
