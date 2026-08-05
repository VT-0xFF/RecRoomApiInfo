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
		[Cpp2IlInjected.Address(RVA = "0x9BCB1E0", Offset = "0x9BCA1E0", VA = "0x189BCB1E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC9810", Offset = "0x9BC8810", VA = "0x189BC9810")]
		public static int DDZFYPVXMRG(IRYAZLWJNZZ.SVFNYUIHGCD.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9950", Offset = "0x9BC8950", VA = "0x189BC9950")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BCB340", Offset = "0x9BCA340", VA = "0x189BCB340")]
		public static bool LVUSQDQNPMX(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB830", Offset = "0x9BCA830", VA = "0x189BCB830")]
		public static bool QSZHYYPANYE(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB9A0", Offset = "0x9BCA9A0", VA = "0x189BCB9A0")]
		public static bool QSZHYYPANYE(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9BCBF10", Offset = "0x9BCAF10", VA = "0x189BCBF10")]
		public static NativeArray<byte> QVMLYVFHBSH(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC160", Offset = "0x9BCB160", VA = "0x189BCC160")]
		private static bool XFUZKPZCPXH(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC060", Offset = "0x9BCB060", VA = "0x189BCC060")]
		private static bool UOGUVJOSKRO(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9BCBFD0", Offset = "0x9BCAFD0", VA = "0x189BCBFD0")]
		private static bool SBMGPKCWBSI(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC260", Offset = "0x9BCB260", VA = "0x189BCC260")]
		private static void YUJQANUWRCG(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB820", Offset = "0x9BCA820", VA = "0x189BCB820")]
		internal static int OHDUFFGRZRV(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB2E0", Offset = "0x9BCA2E0", VA = "0x189BCB2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC8F30", Offset = "0x9BC7F30", VA = "0x189BC8F30")]
		public static NativeArray<byte> GNOOKESNHUK(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9BC93C0", Offset = "0x9BC83C0", VA = "0x189BC93C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BCA240", Offset = "0x9BC9240", VA = "0x189BCA240")]
		public static int DDZFYPVXMRG(IRYAZLWJNZZ.SVFNYUIHGCD.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA750", Offset = "0x9BC9750", VA = "0x189BCA750")]
		public static int LRKFNMWIHJV(IRYAZLWJNZZ.SVFNYUIHGCD.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA890", Offset = "0x9BC9890", VA = "0x189BCA890")]
		private static void VWMGRGVGBSB(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, IRYAZLWJNZZ.SVFNYUIHGCD.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9BCAC90", Offset = "0x9BC9C90", VA = "0x189BCAC90")]
		private static void YVTGAMWYZNU(IRYAZLWJNZZ.SVFNYUIHGCD.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9BCAAB0", Offset = "0x9BC9AB0", VA = "0x189BCAAB0")]
		private static void XBJXLABKNRW(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9D00", Offset = "0x9BC8D00", VA = "0x189BC9D00")]
		private static void AULEGUWWNTA(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9FC0", Offset = "0x9BC8FC0", VA = "0x189BC9FC0")]
		private static void BDVGHADSMFN(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA5E0", Offset = "0x9BC95E0", VA = "0x189BCA5E0")]
		private static int EMIIVVNWASK(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA6A0", Offset = "0x9BC96A0", VA = "0x189BCA6A0")]
		private static bool JOWMKPEXRMF(this IRYAZLWJNZZ.SVFNYUIHGCD.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA520", Offset = "0x9BC9520", VA = "0x189BCA520")]
		private static bool EFMGXHZELIJ(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA5A0", Offset = "0x9BC95A0", VA = "0x189BCA5A0")]
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
