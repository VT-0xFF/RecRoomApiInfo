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
		[Cpp2IlInjected.Address(RVA = "0x8695D30", Offset = "0x8694B30", VA = "0x188695D30", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface FIXFSJMNDPL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TSLCAAVLPMQ(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IPFDCTVTWHM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class TLZUYHBXYQZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8695E30", Offset = "0x8694C30", VA = "0x188695E30")]
		public static int JLGWFVABEVX(SNFCDADGTVQ.VGCLVFOWXCM.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8695F70", Offset = "0x8694D70", VA = "0x188695F70")]
		public static void WIQOYHLWSQL(SNFCDADGTVQ.VGCLVFOWXCM.Version a, [In] ByteString serialized, IEnumerable<FIXFSJMNDPL> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class GHBORVOODSP
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker YEUWDAQZOGO;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker EPCQUQHYUDH;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8693970", Offset = "0x8692770", VA = "0x188693970")]
		public static bool KBXIVFQNHHS(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86943C0", Offset = "0x86931C0", VA = "0x1886943C0")]
		public static bool MIAWLESDFOH(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8693E50", Offset = "0x8692C50", VA = "0x188693E50")]
		public static bool MIAWLESDFOH(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8694590", Offset = "0x8693390", VA = "0x188694590")]
		public static NativeArray<byte> TNKVXPZAJBS(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8694660", Offset = "0x8693460", VA = "0x188694660")]
		private static bool WSXXJSCDYCK(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8693790", Offset = "0x8692590", VA = "0x188693790")]
		private static bool ENRULMCJHVV(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8693890", Offset = "0x8692690", VA = "0x188693890")]
		private static bool ITFDTVVLADL(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8693920", Offset = "0x8692720", VA = "0x188693920")]
		private static void ITRDRMVVYAX(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8694650", Offset = "0x8693450", VA = "0x188694650")]
		internal static int VEFBKINKWVG(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8694530", Offset = "0x8693330", VA = "0x188694530")]
		internal static int RGIHLCFFRWB(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class XSFSHTQJIGT
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker YEUWDAQZOGO;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker EPCQUQHYUDH;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8696690", Offset = "0x8695490", VA = "0x188696690")]
		public static NativeArray<byte> ZEPCZEKEFAX(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8696330", Offset = "0x8695130", VA = "0x188696330")]
		public static NativeList<byte> WMGSBZSEGYI(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class KEOPBETCREF
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker SOHQGYXXIYE;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker IYZZVTGKNNJ;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker GZPVIKEZFME;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker TRYVISHVXYX;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8694C80", Offset = "0x8693A80", VA = "0x188694C80")]
		public static int JLGWFVABEVX(SNFCDADGTVQ.VGCLVFOWXCM.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8694F60", Offset = "0x8693D60", VA = "0x188694F60")]
		public static int JNUBBHFLXEC(SNFCDADGTVQ.VGCLVFOWXCM.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86955C0", Offset = "0x86943C0", VA = "0x1886955C0")]
		private static void WIPHZIULAXG(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, SNFCDADGTVQ.VGCLVFOWXCM.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86957E0", Offset = "0x86945E0", VA = "0x1886957E0")]
		private static void XMDSPLKXJVF(SNFCDADGTVQ.VGCLVFOWXCM.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86953E0", Offset = "0x86941E0", VA = "0x1886953E0")]
		private static void VLUXFRXYVCN(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86949C0", Offset = "0x86937C0", VA = "0x1886949C0")]
		private static void ISMTTPXJYJB(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8695160", Offset = "0x8693F60", VA = "0x188695160")]
		private static void TKUXUWXEWZM(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86950A0", Offset = "0x8693EA0", VA = "0x1886950A0")]
		private static int MHANNISAMAB(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8694910", Offset = "0x8693710", VA = "0x188694910")]
		private static bool DSIZOENRAYI(this SNFCDADGTVQ.VGCLVFOWXCM.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8694850", Offset = "0x8693650", VA = "0x188694850")]
		private static bool DEHYPMWLLOU(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86948D0", Offset = "0x86936D0", VA = "0x1886948D0")]
		private static bool DEHYPMWLLOU(SNFCDADGTVQ.VGCLVFOWXCM.Version a, ByteString b)
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
