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
public interface EMBKIPHOGBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OOLCLHFGNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<MLIBGGDGPNK> BCBDBCODBJE();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MLIBGGDGPNK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string JMOGNGDMLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FDJOKGGHPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NAFKBEGDINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MPPGICAAIFM NGAGCDIAKPJ(Action<ArraySegment<float>> ADABDJONAPD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HBIKMGBNEAG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MPPGICAAIFM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BODJLMLMBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x90D4B0", Offset = "0x90C4B0", VA = "0x18090D4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HGHGJNPIGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2276720", Offset = "0x2275720", VA = "0x182276720")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x55D8B50", Offset = "0x55D7B50", VA = "0x1855D8B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A30690", Offset = "0x6A2F690", VA = "0x186A30690")]
	public MPPGICAAIFM(int DCKPPPHHPFB, int NEAMNAFFLAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BEJNFKLCDHF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static EMBKIPHOGBJ PLCDBOCODGE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool OOLCLHFGNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6A303A0", Offset = "0x6A2F3A0", VA = "0x186A303A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A30420", Offset = "0x6A2F420", VA = "0x186A30420")]
	static BEJNFKLCDHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A302B0", Offset = "0x6A2F2B0", VA = "0x186A302B0")]
	public static IReadOnlyList<MLIBGGDGPNK> BCBDBCODBJE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NAMBMFHEMNP : EMBKIPHOGBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OCABCNBIHOK : MLIBGGDGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KIFGGNBHNBP
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
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public KIFGGNBHNBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6A30510", Offset = "0x6A2F510", VA = "0x186A30510")]
			internal void ABKFPAFNEDC(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HCEAGJONGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture MMHHJPNGEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource EGNOHOCMLFG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JMOGNGDMLHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6A30AD0", Offset = "0x6A2FAD0", VA = "0x186A30AD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FDJOKGGHPDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8FE2D0", Offset = "0x8FD2D0", VA = "0x1808FE2D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9F0430", Offset = "0x9EF430", VA = "0x1809F0430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NAFKBEGDINK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD107B0", VA = "0x180D117B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A30EB0", Offset = "0x6A2FEB0", VA = "0x186A30EB0", Slot = "7")]
		public MPPGICAAIFM NGAGCDIAKPJ(Action<ArraySegment<float>> ADABDJONAPD)
		{
			return default(MPPGICAAIFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A30AF0", Offset = "0x6A2FAF0", VA = "0x186A30AF0")]
		private MPPGICAAIFM NGAGCDIAKPJ(int DCKPPPHHPFB, int ONHMMMICKMA, int NEAMNAFFLAG, Action<ArraySegment<float>> ADABDJONAPD)
		{
			return default(MPPGICAAIFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A30A50", Offset = "0x6A2FA50", VA = "0x186A30A50", Slot = "8")]
		public void HBIKMGBNEAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A30EE0", Offset = "0x6A2FEE0", VA = "0x186A30EE0")]
		public OCABCNBIHOK(MMDevice HCEAGJONGJK, bool IBEJPKNGDLF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<OCABCNBIHOK> KPLBPDGBPKP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OOLCLHFGNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A306A0", Offset = "0x6A2F6A0", VA = "0x186A306A0", Slot = "5")]
	public IReadOnlyList<MLIBGGDGPNK> BCBDBCODBJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A309C0", Offset = "0x6A2F9C0", VA = "0x186A309C0")]
	public NAMBMFHEMNP()
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
