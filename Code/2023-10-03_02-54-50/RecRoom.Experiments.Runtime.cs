using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[BGCFDHAOKNC]
public class KBIJNPPMONM : DHLADIKCNNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NBOBHCLEECA BBPDCCFHENH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B420", Offset = "0x5C89C20", VA = "0x185C8B420")]
	[Preserve]
	public KBIJNPPMONM([AKMGDNDIMPI(null)][NotNull] NBOBHCLEECA BBPDCCFHENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2440A90", Offset = "0x243F290", VA = "0x182440A90", Slot = "4")]
	public bool JEGPGAHAOBF<TExperiment>([Out] TExperiment MGFOPEAELDB) where TExperiment : ADJGAILAOHO, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x24409C0", Offset = "0x243F1C0", VA = "0x1824409C0", Slot = "5")]
	public bool JEGPGAHAOBF<TExperiment>(string OGNIDINIHBL, [Out] TExperiment MGFOPEAELDB) where TExperiment : ADJGAILAOHO, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ADJGAILAOHO
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NBOBHCLEECA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEGPGAHAOBF<TExperiment>([Out] TExperiment MGFOPEAELDB) where TExperiment : ADJGAILAOHO, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEGPGAHAOBF<TExperiment>(string OGNIDINIHBL, [Out] TExperiment MGFOPEAELDB) where TExperiment : ADJGAILAOHO, new();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMJLHLMDALA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DHLADIKCNNB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEGPGAHAOBF<TExperiment>([Out] TExperiment MGFOPEAELDB) where TExperiment : ADJGAILAOHO, new();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEGPGAHAOBF<TExperiment>(string OGNIDINIHBL, [Out] TExperiment MGFOPEAELDB) where TExperiment : ADJGAILAOHO, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class MMLFAIBKKJJ : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct NIIPNNNOLEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo DJPHLHBFHDB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type KCMFPKKHHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5C8BA60", Offset = "0x5C8A260", VA = "0x185C8BA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C8BB30", Offset = "0x5C8A330", VA = "0x185C8BB30")]
	public NIIPNNNOLEK(MemberInfo DJPHLHBFHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B930", Offset = "0x5C8A130", VA = "0x185C8B930")]
	public object MMNNIFHDOBP(object ELOCHLKHPBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B780", Offset = "0x5C89F80", VA = "0x185C8B780")]
	public void MJCDIIPOFFM(object ELOCHLKHPBP, object IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B520", Offset = "0x5C89D20", VA = "0x185C8B520")]
	private static bool LJLKCGOBDGJ(Type DIELCPFKDCN, object IFKKLLBODIE, [Out] object ECLIOBPHIFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum HCLAJLFBDHN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class MPCADIFNJNH : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string MJLCABAKOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool JGCOHPGFEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly HCLAJLFBDHN OHBHGCLHIGD;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B4C0", Offset = "0x5C89CC0", VA = "0x185C8B4C0")]
	public MPCADIFNJNH([Optional] string BOBHOMKFHJB, HCLAJLFBDHN BJKOKHNAAID = HCLAJLFBDHN.Experiment, bool LGPMCNOAJPP = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class FDMLEOPDLNN : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string MJLCABAKOPI;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B240", Offset = "0x5C89A40", VA = "0x185C8B240")]
	public FDMLEOPDLNN(string BOBHOMKFHJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[BGCFDHAOKNC]
public class HPPGINMJEMO : NBOBHCLEECA
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class BCBNCFKHKNL<TExperiment> where TExperiment : ADJGAILAOHO, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ECCKGMJPNBD statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public BCBNCFKHKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x45B1820", Offset = "0x45B0020", VA = "0x1845B1820")]
		internal bool AJJJCDNBFPJ(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HKFOCLLIPFB ECMECMOKLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, ADJGAILAOHO> AAMIBOGEBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, MPCADIFNJNH> ACHIPOJPAPP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B2D0", Offset = "0x5C89AD0", VA = "0x185C8B2D0")]
	[Preserve]
	public HPPGINMJEMO([NotNull][AKMGDNDIMPI(null)] HKFOCLLIPFB ECMECMOKLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x23D6570", Offset = "0x23D4D70", VA = "0x1823D6570", Slot = "4")]
	public bool JEGPGAHAOBF<TExperiment>([Out] TExperiment MGFOPEAELDB) where TExperiment : ADJGAILAOHO, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x23D6600", Offset = "0x23D4E00", VA = "0x1823D6600", Slot = "5")]
	public bool JEGPGAHAOBF<TExperiment>(string OGNIDINIHBL, [Out] TExperiment MGFOPEAELDB) where TExperiment : ADJGAILAOHO, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B280", Offset = "0x5C89A80", VA = "0x185C8B280", Slot = "6")]
	public void GMJLHLMDALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x23D6B90", Offset = "0x23D5390", VA = "0x1823D6B90")]
	private bool PFOLIOOJPBM<TExperiment>([Out] MPCADIFNJNH AJNFADKBELN) where TExperiment : ADJGAILAOHO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x23D61D0", Offset = "0x23D49D0", VA = "0x1823D61D0")]
	private static void FKGPFDEDIID<TExperiment>(TExperiment MGFOPEAELDB, Func<string, object, object> LKBIPFDKGPB, Predicate<string> BMKAOPLICIL) where TExperiment : ADJGAILAOHO
	{
	}
}
namespace Cpp2IlInjected;

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
