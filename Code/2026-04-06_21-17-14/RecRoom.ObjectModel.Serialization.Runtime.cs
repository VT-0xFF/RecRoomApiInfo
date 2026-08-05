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
		[Cpp2IlInjected.Address(RVA = "0x9BCB240", Offset = "0x9BCA240", VA = "0x189BCB240", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface FRAJNQOMWUI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SJHJBLSINXZ(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OTSRDIPIITJ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class IZQEDMXYZAY
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9870", Offset = "0x9BC8870", VA = "0x189BC9870")]
		public static int DDZFYPVXMRG(IRYAZLWJNZZ.SVFNYUIHGCD.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BC99B0", Offset = "0x9BC89B0", VA = "0x189BC99B0")]
		public static void KWSWPYAZAIQ(IRYAZLWJNZZ.SVFNYUIHGCD.Version a, [In] ByteString serialized, IEnumerable<FRAJNQOMWUI> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class QZCUAPHSENW
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker SOLAAWBJWKX;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker FYGSRCSIKDS;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB3A0", Offset = "0x9BCA3A0", VA = "0x189BCB3A0")]
		public static bool LVUSQDQNPMX(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB890", Offset = "0x9BCA890", VA = "0x189BCB890")]
		public static bool QSZHYYPANYE(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9BCBA00", Offset = "0x9BCAA00", VA = "0x189BCBA00")]
		public static bool QSZHYYPANYE(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9BCBF70", Offset = "0x9BCAF70", VA = "0x189BCBF70")]
		public static NativeArray<byte> QVMLYVFHBSH(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC1C0", Offset = "0x9BCB1C0", VA = "0x189BCC1C0")]
		private static bool XFUZKPZCPXH(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC0C0", Offset = "0x9BCB0C0", VA = "0x189BCC0C0")]
		private static bool UOGUVJOSKRO(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC030", Offset = "0x9BCB030", VA = "0x189BCC030")]
		private static bool SBMGPKCWBSI(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC2C0", Offset = "0x9BCB2C0", VA = "0x189BCC2C0")]
		private static void YUJQANUWRCG(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB880", Offset = "0x9BCA880", VA = "0x189BCB880")]
		internal static int OHDUFFGRZRV(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB340", Offset = "0x9BCA340", VA = "0x189BCB340")]
		internal static int JYAOQWCOOKO(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class IXGIDPCDBAK
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker SOLAAWBJWKX;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker FYGSRCSIKDS;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8F90", Offset = "0x9BC7F90", VA = "0x189BC8F90")]
		public static NativeArray<byte> GNOOKESNHUK(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9420", Offset = "0x9BC8420", VA = "0x189BC9420")]
		public static NativeList<byte> GPMURNMGHLH(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class KIZUBMMKITU
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker HBDVTEUKXIV;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker XTBEENNPOPA;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker FQPFEHKPZLT;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker APRAWOQPTHI;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA2A0", Offset = "0x9BC92A0", VA = "0x189BCA2A0")]
		public static int DDZFYPVXMRG(IRYAZLWJNZZ.SVFNYUIHGCD.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA7B0", Offset = "0x9BC97B0", VA = "0x189BCA7B0")]
		public static int LRKFNMWIHJV(IRYAZLWJNZZ.SVFNYUIHGCD.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA8F0", Offset = "0x9BC98F0", VA = "0x189BCA8F0")]
		private static void VWMGRGVGBSB(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, IRYAZLWJNZZ.SVFNYUIHGCD.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9BCACF0", Offset = "0x9BC9CF0", VA = "0x189BCACF0")]
		private static void YVTGAMWYZNU(IRYAZLWJNZZ.SVFNYUIHGCD.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9BCAB10", Offset = "0x9BC9B10", VA = "0x189BCAB10")]
		private static void XBJXLABKNRW(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9D60", Offset = "0x9BC8D60", VA = "0x189BC9D60")]
		private static void AULEGUWWNTA(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA020", Offset = "0x9BC9020", VA = "0x189BCA020")]
		private static void BDVGHADSMFN(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA640", Offset = "0x9BC9640", VA = "0x189BCA640")]
		private static int EMIIVVNWASK(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA700", Offset = "0x9BC9700", VA = "0x189BCA700")]
		private static bool JOWMKPEXRMF(this IRYAZLWJNZZ.SVFNYUIHGCD.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA580", Offset = "0x9BC9580", VA = "0x189BCA580")]
		private static bool EFMGXHZELIJ(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA600", Offset = "0x9BC9600", VA = "0x189BCA600")]
		private static bool EFMGXHZELIJ(IRYAZLWJNZZ.SVFNYUIHGCD.Version a, ByteString b)
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
