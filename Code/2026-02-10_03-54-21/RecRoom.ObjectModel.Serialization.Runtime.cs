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
		[Cpp2IlInjected.Address(RVA = "0x8639410", Offset = "0x8638610", VA = "0x188639410", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface RRCQZZNEQEO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GJECUIFYJAZ(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JUFURAKXVZP();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class DLXWRFXKWDQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8638F20", Offset = "0x8638120", VA = "0x188638F20")]
		public static int MPZFMIWZEQG(TBCFNDVWWGJ.XTSKGUBYJNP.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8639060", Offset = "0x8638260", VA = "0x188639060")]
		public static void OLNXYDVZOVQ(TBCFNDVWWGJ.XTSKGUBYJNP.Version a, [In] ByteString serialized, IEnumerable<RRCQZZNEQEO> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class VGYEVJPKUDI
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker PJDKKEVBUJH;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker WOGTKLECYMW;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86397C0", Offset = "0x86389C0", VA = "0x1886397C0")]
		public static bool MYQSUTJZRZX(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8639DA0", Offset = "0x8638FA0", VA = "0x188639DA0")]
		public static bool XABUYDJGGUS(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8639F10", Offset = "0x8639110", VA = "0x188639F10")]
		public static bool XABUYDJGGUS(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86395B0", Offset = "0x86387B0", VA = "0x1886395B0")]
		public static NativeArray<byte> GSPCQYLECIJ(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8639670", Offset = "0x8638870", VA = "0x188639670")]
		private static bool HIXEGJGSTWH(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8639CA0", Offset = "0x8638EA0", VA = "0x188639CA0")]
		private static bool PNIKABUHEGW(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8639520", Offset = "0x8638720", VA = "0x188639520")]
		private static bool FRTBGESEBCK(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8639770", Offset = "0x8638970", VA = "0x188639770")]
		private static void KJVOQEAXZQU(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8639510", Offset = "0x8638710", VA = "0x188639510")]
		internal static int AABZFIEKGYR(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x863A470", Offset = "0x8639670", VA = "0x18863A470")]
		internal static int YIFEKJPQDQA(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class VNXEFCWXSEU
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker PJDKKEVBUJH;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker WOGTKLECYMW;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x863A910", Offset = "0x8639B10", VA = "0x18863A910")]
		public static NativeArray<byte> GKPXAAFYWPS(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x863A5B0", Offset = "0x86397B0", VA = "0x18863A5B0")]
		public static NativeList<byte> FABCDJHRCML(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class VYDIJXXYSYA
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker KZZQGGWLXDB;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker NCHYLSELARO;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker XXTCZLSZOWT;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker UGETRQGKZCU;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x863B290", Offset = "0x863A490", VA = "0x18863B290")]
		public static int MPZFMIWZEQG(TBCFNDVWWGJ.XTSKGUBYJNP.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x863AF30", Offset = "0x863A130", VA = "0x18863AF30")]
		public static int KZBCNIAMYQJ(TBCFNDVWWGJ.XTSKGUBYJNP.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x863B070", Offset = "0x863A270", VA = "0x18863B070")]
		private static void MHCZYITCFEX(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, TBCFNDVWWGJ.XTSKGUBYJNP.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x863BE10", Offset = "0x863B010", VA = "0x18863BE10")]
		private static void ZOINFHMMIZC(TBCFNDVWWGJ.XTSKGUBYJNP.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x863BC30", Offset = "0x863AE30", VA = "0x18863BC30")]
		private static void YUCIKYKBDYG(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x863B8B0", Offset = "0x863AAB0", VA = "0x18863B8B0")]
		private static void UAKHSLYQBPO(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x863B630", Offset = "0x863A830", VA = "0x18863B630")]
		private static void QWVIKXEDMEN(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x863BB70", Offset = "0x863AD70", VA = "0x18863BB70")]
		private static int UUWAXOHZWGQ(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x863AE80", Offset = "0x863A080", VA = "0x18863AE80")]
		private static bool GJQFTORGIHB(this TBCFNDVWWGJ.XTSKGUBYJNP.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x863B570", Offset = "0x863A770", VA = "0x18863B570")]
		private static bool PSMRPSZVMUD(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x863B5F0", Offset = "0x863A7F0", VA = "0x18863B5F0")]
		private static bool PSMRPSZVMUD(TBCFNDVWWGJ.XTSKGUBYJNP.Version a, ByteString b)
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
