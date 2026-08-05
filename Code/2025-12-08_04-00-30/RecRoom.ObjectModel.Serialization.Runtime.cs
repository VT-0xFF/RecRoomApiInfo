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
		[Cpp2IlInjected.Address(RVA = "0x8446CB0", Offset = "0x84454B0", VA = "0x188446CB0", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface DJZIVIFFUNH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UFRFIQLZMUA(World a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JIBLBJTHOBM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class PFVGYAKEOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8448280", Offset = "0x8446A80", VA = "0x188448280")]
		public static int HMSZGQAGMUV(OPOSKLPGHHQ.SWOPFJGPAIA.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84483C0", Offset = "0x8446BC0", VA = "0x1884483C0")]
		public static void RKZAXCQMDZB(OPOSKLPGHHQ.SWOPFJGPAIA.Version a, [In] ByteString serialized, IEnumerable<DJZIVIFFUNH> b)
		{
		}
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization.V3AndV4
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class ARJXEDSTZXB
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct Aligned
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly ProfilerMarker ZITGQCTFXIC;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ProfilerMarker ITINIFICMZX;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84463E0", Offset = "0x8444BE0", VA = "0x1884463E0")]
		public static bool JTHFYZJYUTK(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8445D10", Offset = "0x8444510", VA = "0x188445D10")]
		public static bool HSYOOFMCGJJ(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8445E80", Offset = "0x8444680", VA = "0x188445E80")]
		public static bool HSYOOFMCGJJ(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84468C0", Offset = "0x84450C0", VA = "0x1884468C0")]
		public static NativeArray<byte> KLQMIIPCBNG(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8445C10", Offset = "0x8444410", VA = "0x188445C10")]
		private static bool FWTALHCAUSG(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8446A30", Offset = "0x8445230", VA = "0x188446A30")]
		private static bool PVDCXIYDDWX(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8446B40", Offset = "0x8445340", VA = "0x188446B40")]
		private static bool XCDZHKMAFRP(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8446980", Offset = "0x8445180", VA = "0x188446980")]
		private static void MWAHFKSNJRV(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8446B30", Offset = "0x8445330", VA = "0x188446B30")]
		internal static int RWMAEDQVWIU(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84469D0", Offset = "0x84451D0", VA = "0x1884469D0")]
		internal static int NJKZVNUMUND(int a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class PWQAYWLEAMT
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ProfilerMarker ZITGQCTFXIC;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker ITINIFICMZX;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8448770", Offset = "0x8446F70", VA = "0x188448770")]
		public static NativeArray<byte> GNQQQNNUFFR(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8448C00", Offset = "0x8447400", VA = "0x188448C00")]
		public static NativeList<byte> UGYHLZCRFLS(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeList<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class MWXRUTBMRUR
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ProfilerMarker IMAZAASGUMQ;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ProfilerMarker AELAKHVAMJB;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker JXJSPRTLTQY;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker FPABXLHIFZB;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8447680", Offset = "0x8445E80", VA = "0x188447680")]
		public static int HMSZGQAGMUV(OPOSKLPGHHQ.SWOPFJGPAIA.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8447960", Offset = "0x8446160", VA = "0x188447960")]
		public static int HXMTDEPXWYK(OPOSKLPGHHQ.SWOPFJGPAIA.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8446DB0", Offset = "0x84455B0", VA = "0x188446DB0")]
		private static void BAJXIKGKFZK(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, OPOSKLPGHHQ.SWOPFJGPAIA.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8447290", Offset = "0x8445A90", VA = "0x188447290")]
		private static void HAMEVSTVUSL(OPOSKLPGHHQ.SWOPFJGPAIA.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8447EA0", Offset = "0x84466A0", VA = "0x188447EA0")]
		private static void WABUUNTGVYF(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8446FD0", Offset = "0x84457D0", VA = "0x188446FD0")]
		private static void BEUPVJGEWFV(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8447C20", Offset = "0x8446420", VA = "0x188447C20")]
		private static void SRNRWUDKYWW(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8447AA0", Offset = "0x84462A0", VA = "0x188447AA0")]
		private static int QWLZDQCVFSV(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8448080", Offset = "0x8446880", VA = "0x188448080")]
		private static bool ZZKDMHONFWE(this OPOSKLPGHHQ.SWOPFJGPAIA.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8447BA0", Offset = "0x84463A0", VA = "0x188447BA0")]
		private static bool RZJSGSDRWHK(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8447B60", Offset = "0x8446360", VA = "0x188447B60")]
		private static bool RZJSGSDRWHK(OPOSKLPGHHQ.SWOPFJGPAIA.Version a, ByteString b)
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
