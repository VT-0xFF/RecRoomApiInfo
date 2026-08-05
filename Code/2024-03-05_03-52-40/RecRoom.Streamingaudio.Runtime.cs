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
public interface EKLONNALAIN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ABBELJLPEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<MLPBCDGAILE> CJCNLOEMFDA();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MLPBCDGAILE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string JHLBBBDKLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EIBONDLFBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CDEHHDLJENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BNAKECCMNKF DMNHJPLNLCA(Action<ArraySegment<float>> NHPEKKMOHMO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CBBFIAKCNKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct BNAKECCMNKF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FNAKMHKKOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HKBBJLPMPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x22396B0", Offset = "0x22384B0", VA = "0x1822396B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5534DA0", Offset = "0x5533BA0", VA = "0x185534DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69461F0", Offset = "0x6944FF0", VA = "0x1869461F0")]
	public BNAKECCMNKF(int NJMOIABGKFP, int ACEDFMIIGNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LEIIMOAONNL
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static EKLONNALAIN JLIBJBJNEEP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool ABBELJLPEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6946D00", Offset = "0x6945B00", VA = "0x186946D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6946D80", Offset = "0x6945B80", VA = "0x186946D80")]
	static LEIIMOAONNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6946C10", Offset = "0x6945A10", VA = "0x186946C10")]
	public static IReadOnlyList<MLPBCDGAILE> CJCNLOEMFDA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JGMEAGGBFDN : EKLONNALAIN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FOJMOEEAFNF : MLPBCDGAILE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HDOHICEFBND
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
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public HDOHICEFBND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x69466E0", Offset = "0x69454E0", VA = "0x1869466E0")]
			internal void LLFIMNLDJHB(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice DGMNFGKGOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture PPEKBGBCHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource HBKMCDPBOGI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JHLBBBDKLCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6946670", Offset = "0x6945470", VA = "0x186946670", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EIBONDLFBBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8E0F00", Offset = "0x8DFD00", VA = "0x1808E0F00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9B9090", Offset = "0x9B7E90", VA = "0x1809B9090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CDEHHDLJENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCE26A0", Offset = "0xCE14A0", VA = "0x180CE26A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6946640", Offset = "0x6945440", VA = "0x186946640", Slot = "7")]
		public BNAKECCMNKF DMNHJPLNLCA(Action<ArraySegment<float>> NHPEKKMOHMO)
		{
			return default(BNAKECCMNKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6946280", Offset = "0x6945080", VA = "0x186946280")]
		private BNAKECCMNKF DMNHJPLNLCA(int NJMOIABGKFP, int FLKPBDBFMEI, int ACEDFMIIGNL, Action<ArraySegment<float>> NHPEKKMOHMO)
		{
			return default(BNAKECCMNKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6946200", Offset = "0x6945000", VA = "0x186946200", Slot = "8")]
		public void CBBFIAKCNKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6946690", Offset = "0x6945490", VA = "0x186946690")]
		public FOJMOEEAFNF(MMDevice DGMNFGKGOCO, bool GOEEOKHCJKG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<FOJMOEEAFNF> FPODAHLILLM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ABBELJLPEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D4310", Offset = "0x7D3110", VA = "0x1807D4310", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6946860", Offset = "0x6945660", VA = "0x186946860", Slot = "5")]
	public IReadOnlyList<MLPBCDGAILE> CJCNLOEMFDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6946B80", Offset = "0x6945980", VA = "0x186946B80")]
	public JGMEAGGBFDN()
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
