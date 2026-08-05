using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DIOJLLPPPAF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DBJPPOKKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<EHHDODDKPEM> DNFMAAGPMNC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EHHDODDKPEM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string MCPIOFNNGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GCKBJHOCFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GINEALCNKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CLMLAFGNFFC FKIJPKNHCCC(Action<ArraySegment<float>> MHPGHAHOBNK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MHBAAJKMPLN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CLMLAFGNFFC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CJKGIFFOGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BFMMHMBHAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2F5C110", Offset = "0x2F5B310", VA = "0x182F5C110")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E42C20", Offset = "0x6E41E20", VA = "0x186E42C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7700", Offset = "0x7CB6900", VA = "0x187CB7700")]
	public CLMLAFGNFFC(int PBKKLLPHDFM, int ELPJGHHFDMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HNHADNDPHDC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static DIOJLLPPPAF NHPKMJMDCIE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool DBJPPOKKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8786B00", Offset = "0x8785D00", VA = "0x188786B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8786C60", Offset = "0x8785E60", VA = "0x188786C60")]
	static HNHADNDPHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8786B70", Offset = "0x8785D70", VA = "0x188786B70")]
	public static IReadOnlyList<EHHDODDKPEM> DNFMAAGPMNC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DKKMCEBCCLK : DIOJLLPPPAF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JPGJOJJLNPN : EHHDODDKPEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PFMIDKCELCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public PFMIDKCELCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8787230", Offset = "0x8786430", VA = "0x188787230")]
			internal void MDELAOIHHPP(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice JBDLADPHEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LIHKFANEJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BPMKFCADMBM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MCPIOFNNGEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8786D50", Offset = "0x8785F50", VA = "0x188786D50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GCKBJHOCFNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA674A0", Offset = "0xA666A0", VA = "0x180A674A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA671B0", Offset = "0xA663B0", VA = "0x180A671B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GINEALCNKBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xDF9DC0", Offset = "0xDF8FC0", VA = "0x180DF9DC0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8787130", Offset = "0x8786330", VA = "0x188787130", Slot = "7")]
		public CLMLAFGNFFC FKIJPKNHCCC(Action<ArraySegment<float>> MHPGHAHOBNK)
		{
			return default(CLMLAFGNFFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8786D70", Offset = "0x8785F70", VA = "0x188786D70")]
		private CLMLAFGNFFC FKIJPKNHCCC(int PBKKLLPHDFM, int DHHGCGGHFAH, int ELPJGHHFDMJ, Action<ArraySegment<float>> MHPGHAHOBNK)
		{
			return default(CLMLAFGNFFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8787160", Offset = "0x8786360", VA = "0x188787160", Slot = "8")]
		public void MHBAAJKMPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87871E0", Offset = "0x87863E0", VA = "0x1887871E0")]
		public JPGJOJJLNPN(MMDevice JBDLADPHEAD, bool CPIBKPMIELM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<JPGJOJJLNPN> DLIDFLCAEDK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DBJPPOKKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8786760", Offset = "0x8785960", VA = "0x188786760", Slot = "5")]
	public IReadOnlyList<EHHDODDKPEM> DNFMAAGPMNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8786A70", Offset = "0x8785C70", VA = "0x188786A70")]
	public DKKMCEBCCLK()
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
