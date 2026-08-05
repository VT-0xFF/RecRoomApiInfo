using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.Serialization;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Serialization_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E870F0", Offset = "0x7E862F0", VA = "0x187E870F0", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NCEKCKEOCJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOOHMFGKEEE(World NKENFIFGFHM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOCHIMKFMHO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OMKJHBHEDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E87200", Offset = "0x7E86400", VA = "0x187E87200")]
	public static int GLIJIJECBGD(BGEGNKNPBBF.OJGDAMOOLEA.JFJBGJEGEBC COBPGHDNJHM, World NKENFIFGFHM, [Out] ByteString DICDKKLOOEO, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> NCHOCPCGNFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7E87300", Offset = "0x7E86500", VA = "0x187E87300")]
	public static void LGDGOEJNBEH(BGEGNKNPBBF.OJGDAMOOLEA.JFJBGJEGEBC COBPGHDNJHM, [In] ByteString DICDKKLOOEO, IEnumerable<NCEKCKEOCJG> JKMCIGFJNBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PIBHNFAGNFP
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct HIKKAEGELCN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly ProfilerMarker EBFLKOOMEBC;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly ProfilerMarker JPEDLCCPKIL;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7E88AE0", Offset = "0x7E87CE0", VA = "0x187E88AE0")]
	public static bool IOIDBBJHDCA(NativeArray<byte> HEDDMJOGMMB, [Out] ByteString DICDKKLOOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E899D0", Offset = "0x7E88BD0", VA = "0x187E899D0")]
	public static bool PNHAMCGELAH(ByteString DICDKKLOOEO, [Out] NativeList<byte> NPEFBLFNGDJ, Allocator FOPENOLHBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E89310", Offset = "0x7E88510", VA = "0x187E89310")]
	public static bool PNHAMCGELAH(NativeArray<byte> HEDDMJOGMMB, NativeList<byte> NPEFBLFNGDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E88A20", Offset = "0x7E87C20", VA = "0x187E88A20")]
	public static NativeArray<byte> BDFMNAIBPLH(int LMMGFKFHEJP, Allocator FOPENOLHBOM = Allocator.Temp)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E891C0", Offset = "0x7E883C0", VA = "0x187E891C0")]
	private static bool KDHNMKAMIDB(NativeArray<byte> HEDDMJOGMMB, NativeList<byte> NPEFBLFNGDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E890C0", Offset = "0x7E882C0", VA = "0x187E890C0")]
	private static bool JNIBACHFABP(int IJDLLECOBKE, int NNAMDOJJIJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E88990", Offset = "0x7E87B90", VA = "0x187E88990")]
	private static bool AFGAGBFBJLA(ReadOnlySpan<byte> IGFOGCEEFHD, [Out] uint MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7E89070", Offset = "0x7E88270", VA = "0x187E89070")]
	private static void JICILNJJOCD(uint MLCDCHNOCFI, Span<byte> IGFOGCEEFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7E89060", Offset = "0x7E88260", VA = "0x187E89060")]
	internal static int JCBGDMONCBI(int MLCDCHNOCFI, int NGFOPAPDOLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7E892B0", Offset = "0x7E884B0", VA = "0x187E892B0")]
	internal static int PJANGFAPKLO(int MLCDCHNOCFI, int NGFOPAPDOLC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class IELGHFEJKNG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ProfilerMarker EBFLKOOMEBC;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ProfilerMarker JPEDLCCPKIL;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7E86B20", Offset = "0x7E85D20", VA = "0x187E86B20")]
	public static NativeArray<byte> JPIFELPOGPJ(ReadOnlySpan<byte> HEDDMJOGMMB, Allocator FOPENOLHBOM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E86710", Offset = "0x7E85910", VA = "0x187E86710")]
	public static NativeList<byte> ALGGCGCIAEC(ReadOnlySpan<byte> HEDDMJOGMMB, Allocator FOPENOLHBOM)
	{
		return default(NativeList<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class PHAHILCOJJI
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker MCBMNJNFFEM;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly ProfilerMarker BGCCNBGDCOG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly ProfilerMarker NAEDGPKNNPI;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly ProfilerMarker NBMDBOHFDPI;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E87DD0", Offset = "0x7E86FD0", VA = "0x187E87DD0")]
	public static int GLIJIJECBGD(BGEGNKNPBBF.OJGDAMOOLEA.JFJBGJEGEBC COBPGHDNJHM, World NKENFIFGFHM, [Out] ByteString DICDKKLOOEO, [Out] NativeArray<EntityRemapUtility.EntityRemapInfo> AFAOCFMKHBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E886A0", Offset = "0x7E878A0", VA = "0x187E886A0")]
	public static int KKNCLOCEOPN(BGEGNKNPBBF.OJGDAMOOLEA.JFJBGJEGEBC COBPGHDNJHM, World NKENFIFGFHM, [In] ByteString DICDKKLOOEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E876B0", Offset = "0x7E868B0", VA = "0x187E876B0")]
	private static void BFLDECCHDJB(EntityManager EPEFONCBOCP, NativeArray<EntityRemapUtility.EntityRemapInfo> AFAOCFMKHBL, BGEGNKNPBBF.OJGDAMOOLEA.JFJBGJEGEBC COBPGHDNJHM, [Out] ByteString DICDKKLOOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E88100", Offset = "0x7E87300", VA = "0x187E88100")]
	private static void IENOPLGGHNA(BGEGNKNPBBF.OJGDAMOOLEA.JFJBGJEGEBC COBPGHDNJHM, World NKENFIFGFHM, ByteString DICDKKLOOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E878D0", Offset = "0x7E86AD0", VA = "0x187E878D0")]
	private static void EFOCGHINOKH(EntityManager EPEFONCBOCP, MemoryBinaryWriter GDEDILINNBI, NativeArray<EntityRemapUtility.EntityRemapInfo> AFAOCFMKHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E87B00", Offset = "0x7E86D00", VA = "0x187E87B00")]
	private static void FAMLJBOHJLN(World NKENFIFGFHM, NativeArray<byte> GKBCBCNOOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E885E0", Offset = "0x7E877E0", VA = "0x187E885E0")]
	private static bool JPKABGIHOJJ(this BGEGNKNPBBF.OJGDAMOOLEA.JFJBGJEGEBC COBPGHDNJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E88520", Offset = "0x7E87720", VA = "0x187E88520")]
	private static bool JGIFBIPAIGB(EntityManager EPEFONCBOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E885A0", Offset = "0x7E877A0", VA = "0x187E885A0")]
	private static bool JGIFBIPAIGB(BGEGNKNPBBF.OJGDAMOOLEA.JFJBGJEGEBC COBPGHDNJHM, ByteString DICDKKLOOEO)
	{
		return default(bool);
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
