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
public interface OKBBMIHHHMM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IMPNFOKDOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<ECIKGFDAKJM> ADPDNHOKLCH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ECIKGFDAKJM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string ODEDFFJLGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AFKAHHKGIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EHDOEFAIJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HLNOBINFIDO MMJIBAKGBIB(Action<ArraySegment<float>> IBDCICFCEPJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EBFIHLKPBIC();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HLNOBINFIDO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FKLOALHAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x122C2A0", Offset = "0x122B6A0", VA = "0x18122C2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NCJHAJFGPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2D41AC0", Offset = "0x2D40EC0", VA = "0x182D41AC0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D25A80", Offset = "0x6D24E80", VA = "0x186D25A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B5D240", Offset = "0x7B5C640", VA = "0x187B5D240")]
	public HLNOBINFIDO(int ADNCNMGEAPO, int GDHLLDHJPFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IFCPCDINJGD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OKBBMIHHHMM BIBBOGOLIEL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool IMPNFOKDOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85AD920", Offset = "0x85ACD20", VA = "0x1885AD920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85AD9A0", Offset = "0x85ACDA0", VA = "0x1885AD9A0")]
	static IFCPCDINJGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85AD830", Offset = "0x85ACC30", VA = "0x1885AD830")]
	public static IReadOnlyList<ECIKGFDAKJM> ADPDNHOKLCH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AMDMCAODODG : OKBBMIHHHMM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OIKNKNHNGKL : ECIKGFDAKJM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EFDJGLGCFMF
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
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public EFDJGLGCFMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x85AD6B0", Offset = "0x85ACAB0", VA = "0x1885AD6B0")]
			internal void JOGEENHGPKP(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice GHCHLANEPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture BEAPPPDHEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource AMAJEAAJEFJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ODEDFFJLGKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x85ADB10", Offset = "0x85ACF10", VA = "0x1885ADB10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AFKAHHKGIAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD74840", Offset = "0xD73C40", VA = "0x180D74840", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8A0", Offset = "0xA6CCA0", VA = "0x180A6D8A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EHDOEFAIJHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD676A0", Offset = "0xD66AA0", VA = "0x180D676A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85ADEF0", Offset = "0x85AD2F0", VA = "0x1885ADEF0", Slot = "7")]
		public HLNOBINFIDO MMJIBAKGBIB(Action<ArraySegment<float>> IBDCICFCEPJ)
		{
			return default(HLNOBINFIDO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85ADB30", Offset = "0x85ACF30", VA = "0x1885ADB30")]
		private HLNOBINFIDO MMJIBAKGBIB(int ADNCNMGEAPO, int COOLNJPBPPC, int GDHLLDHJPFB, Action<ArraySegment<float>> IBDCICFCEPJ)
		{
			return default(HLNOBINFIDO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85ADA90", Offset = "0x85ACE90", VA = "0x1885ADA90", Slot = "8")]
		public void EBFIHLKPBIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85ADF20", Offset = "0x85AD320", VA = "0x1885ADF20")]
		public OIKNKNHNGKL(MMDevice GHCHLANEPMF, bool BPOBAEMIECC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<OIKNKNHNGKL> NPCANNJBCNA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool IMPNFOKDOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85AD300", Offset = "0x85AC700", VA = "0x1885AD300", Slot = "5")]
	public IReadOnlyList<ECIKGFDAKJM> ADPDNHOKLCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85AD620", Offset = "0x85ACA20", VA = "0x1885AD620")]
	public AMDMCAODODG()
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
