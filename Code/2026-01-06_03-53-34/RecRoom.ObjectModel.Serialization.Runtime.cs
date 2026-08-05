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
		[Cpp2IlInjected.Address(RVA = "0x8549E90", Offset = "0x8548890", VA = "0x188549E90", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x854B460", Offset = "0x8549E60", VA = "0x18854B460")]
		public static int HMSZGQAGMUV(OPOSKLPGHHQ.SWOPFJGPAIA.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x854B5A0", Offset = "0x8549FA0", VA = "0x18854B5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85495C0", Offset = "0x8547FC0", VA = "0x1885495C0")]
		public static bool JTHFYZJYUTK(NativeArray<byte> a, [Out] ByteString b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8548EF0", Offset = "0x85478F0", VA = "0x188548EF0")]
		public static bool HSYOOFMCGJJ(ByteString a, [Out] NativeList<byte> b, Allocator c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8549060", Offset = "0x8547A60", VA = "0x188549060")]
		public static bool HSYOOFMCGJJ(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8549AA0", Offset = "0x85484A0", VA = "0x188549AA0")]
		public static NativeArray<byte> KLQMIIPCBNG(int a, Allocator b = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8548DF0", Offset = "0x85477F0", VA = "0x188548DF0")]
		private static bool FWTALHCAUSG(NativeArray<byte> a, NativeList<byte> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8549C10", Offset = "0x8548610", VA = "0x188549C10")]
		private static bool PVDCXIYDDWX(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8549D20", Offset = "0x8548720", VA = "0x188549D20")]
		private static bool XCDZHKMAFRP(ReadOnlySpan<byte> a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8549B60", Offset = "0x8548560", VA = "0x188549B60")]
		private static void MWAHFKSNJRV(uint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8549D10", Offset = "0x8548710", VA = "0x188549D10")]
		internal static int RWMAEDQVWIU(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8549BB0", Offset = "0x85485B0", VA = "0x188549BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x854B960", Offset = "0x854A360", VA = "0x18854B960")]
		public static NativeArray<byte> GNQQQNNUFFR(ReadOnlySpan<byte> a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x854BDF0", Offset = "0x854A7F0", VA = "0x18854BDF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x854A860", Offset = "0x8549260", VA = "0x18854A860")]
		public static int HMSZGQAGMUV(OPOSKLPGHHQ.SWOPFJGPAIA.Version a, World b, [Out] ByteString c, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x854AB40", Offset = "0x8549540", VA = "0x18854AB40")]
		public static int HXMTDEPXWYK(OPOSKLPGHHQ.SWOPFJGPAIA.Version a, World b, [In] ByteString serialized)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8549F90", Offset = "0x8548990", VA = "0x188549F90")]
		private static void BAJXIKGKFZK(EntityManager a, NativeArray<EntityRemapUtility.EntityRemapInfo> b, OPOSKLPGHHQ.SWOPFJGPAIA.Version c, [Out] ByteString d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x854A470", Offset = "0x8548E70", VA = "0x18854A470")]
		private static void HAMEVSTVUSL(OPOSKLPGHHQ.SWOPFJGPAIA.Version a, World b, ByteString c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x854B080", Offset = "0x8549A80", VA = "0x18854B080")]
		private static void WABUUNTGVYF(EntityManager a, MemoryBinaryWriter b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x854A1B0", Offset = "0x8548BB0", VA = "0x18854A1B0")]
		private static void BEUPVJGEWFV(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x854AE00", Offset = "0x8549800", VA = "0x18854AE00")]
		private static void SRNRWUDKYWW(World a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x854AC80", Offset = "0x8549680", VA = "0x18854AC80")]
		private static int QWLZDQCVFSV(NativeArray<byte> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x854B260", Offset = "0x8549C60", VA = "0x18854B260")]
		private static bool ZZKDMHONFWE(this OPOSKLPGHHQ.SWOPFJGPAIA.Version a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x854AD80", Offset = "0x8549780", VA = "0x18854AD80")]
		private static bool RZJSGSDRWHK(EntityManager a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x854AD40", Offset = "0x8549740", VA = "0x18854AD40")]
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
