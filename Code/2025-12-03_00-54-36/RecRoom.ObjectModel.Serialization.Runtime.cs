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
		[Cpp2IlInjected.Address(RVA = "0x83D3800", Offset = "0x83D2400", VA = "0x1883D3800", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface WYCZRSIKSQV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GUDELVDYPXC(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OGBNJYRINGK();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class AJUAWJKQJYF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83D3300", Offset = "0x83D1F00", VA = "0x1883D3300")]
		public static int BDRGTMDOXMV(ANUSQLSCPYK.KGSAZBXNTRG.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83D3440", Offset = "0x83D2040", VA = "0x1883D3440")]
		public static void EPPRRBASIJR(ANUSQLSCPYK.KGSAZBXNTRG.Version a, [In] ByteString serialized, IEnumerable<WYCZRSIKSQV> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class WSKYKZMVCCT
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker MOPLTBHHZXA;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker YMOSOONOQWR;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83D5A70", Offset = "0x83D4670", VA = "0x1883D5A70")]
		public static bool TISKYNKGCFK(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83D5F50", Offset = "0x83D4B50", VA = "0x1883D5F50")]
		public static bool WFURIPQIWLB(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83D60C0", Offset = "0x83D4CC0", VA = "0x1883D60C0")]
		public static bool WFURIPQIWLB(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83D5850", Offset = "0x83D4450", VA = "0x1883D5850")]
		public static NativeArray<byte> LCBFKFSVPKA(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83D5750", Offset = "0x83D4350", VA = "0x1883D5750")]
		private static bool KBNKJUIUGFU(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83D5910", Offset = "0x83D4510", VA = "0x1883D5910")]
		private static bool NSCKZDMNSML(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83D56C0", Offset = "0x83D42C0", VA = "0x1883D56C0")]
		private static bool ERUYOBPHLYF(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83D6640", Offset = "0x83D5240", VA = "0x1883D6640")]
		private static void YKGIKKVJICL(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83D6630", Offset = "0x83D5230", VA = "0x1883D6630")]
		internal static int XGUYHAXRKOM(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83D5A10", Offset = "0x83D4610", VA = "0x1883D5A10")]
		internal static int PTCGUAZVCYB(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TMGATNYQCCT
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker MOPLTBHHZXA;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker YMOSOONOQWR;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83D5140", Offset = "0x83D3D40", VA = "0x1883D5140")]
		public static NativeArray<byte> ZKHVVGMZGFB(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83D4DE0", Offset = "0x83D39E0", VA = "0x1883D4DE0")]
		public static NativeList<byte> BIWGEZMUXVK(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class RVZXWHECLAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker QAESFUZVUQM;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker KRHPHTCFSRN;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker PBOPHTHEFTO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker XCYWYEMPUXF;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83D3900", Offset = "0x83D2500", VA = "0x1883D3900")]
		public static int BDRGTMDOXMV(ANUSQLSCPYK.KGSAZBXNTRG.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83D4140", Offset = "0x83D2D40", VA = "0x1883D4140")]
		public static int HMIBFGLVIJE(ANUSQLSCPYK.KGSAZBXNTRG.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83D4280", Offset = "0x83D2E80", VA = "0x1883D4280")]
		private static void JMJNIPFHSPW(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, ANUSQLSCPYK.KGSAZBXNTRG.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83D3BE0", Offset = "0x83D27E0", VA = "0x1883D3BE0")]
		private static void BQVHHAZEVXB(ANUSQLSCPYK.KGSAZBXNTRG.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83D4760", Offset = "0x83D3360", VA = "0x1883D4760")]
		private static void LDVIXZOKTGV(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83D44A0", Offset = "0x83D30A0", VA = "0x1883D44A0")]
		private static void KIOQIEWKPMX(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83D4940", Offset = "0x83D3540", VA = "0x1883D4940")]
		private static void NTBZSSNXSDI(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83D4BC0", Offset = "0x83D37C0", VA = "0x1883D4BC0")]
		private static int YEAGSWPUZDH(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83D3FD0", Offset = "0x83D2BD0", VA = "0x1883D3FD0")]
		private static bool EBIACBTUDNK(this ANUSQLSCPYK.KGSAZBXNTRG.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83D40C0", Offset = "0x83D2CC0", VA = "0x1883D40C0")]
		private static bool EBZUCHMAUOQ(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83D4080", Offset = "0x83D2C80", VA = "0x1883D4080")]
		private static bool EBZUCHMAUOQ(ANUSQLSCPYK.KGSAZBXNTRG.Version a, ByteString b)
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
