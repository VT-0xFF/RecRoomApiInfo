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
public interface ONGHOPAOPPN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MPNBOGAEOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<JEEGEBBKPBL> IADBFHDFNJB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JEEGEBBKPBL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HCOINFFCEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IHBMHKLANCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NNIMLPHHCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FEPEICPNANA JOOPIPFMDEL(Action<ArraySegment<float>> ABCKGGDLEKO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OBDOGGFOIJC();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FEPEICPNANA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ANOEGKPCNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F1550", Offset = "0x7EFD50", VA = "0x1807F1550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BCOMKEMNNAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE230", Offset = "0x1FBCA30", VA = "0x181FBE230")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x51FC7D0", Offset = "0x51FAFD0", VA = "0x1851FC7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6399D50", Offset = "0x6398550", VA = "0x186399D50")]
	public FEPEICPNANA(int KPMNMMELNNG, int JIEMAPGDGNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AOGBMKOHNDD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static ONGHOPAOPPN MHJHGEAMNGH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MPNBOGAEOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6399740", Offset = "0x6397F40", VA = "0x186399740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x63998B0", Offset = "0x63980B0", VA = "0x1863998B0")]
	static AOGBMKOHNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x63997C0", Offset = "0x6397FC0", VA = "0x1863997C0")]
	public static IReadOnlyList<JEEGEBBKPBL> IADBFHDFNJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BDCLEDBMPHM : ONGHOPAOPPN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NBHOKEECIIF : JEEGEBBKPBL
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JEBKJFMICCE
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
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public JEBKJFMICCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6399D60", Offset = "0x6398560", VA = "0x186399D60")]
			internal void PLIBCMCCFPG(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice FCJCNICEPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture BLDGHMJMICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource ADGLHMKHMDH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HCOINFFCEEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6399EE0", Offset = "0x63986E0", VA = "0x186399EE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IHBMHKLANCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FB580", VA = "0x1807FCD80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x86B8B0", Offset = "0x86A0B0", VA = "0x18086B8B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NNIMLPHHCLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB86B20", Offset = "0xB85320", VA = "0x180B86B20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6399F00", Offset = "0x6398700", VA = "0x186399F00", Slot = "7")]
		public FEPEICPNANA JOOPIPFMDEL(Action<ArraySegment<float>> ABCKGGDLEKO)
		{
			return default(FEPEICPNANA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6399F30", Offset = "0x6398730", VA = "0x186399F30")]
		private FEPEICPNANA JOOPIPFMDEL(int KPMNMMELNNG, int FGKKIKCJAKJ, int JIEMAPGDGNF, Action<ArraySegment<float>> ABCKGGDLEKO)
		{
			return default(FEPEICPNANA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x639A2F0", Offset = "0x6398AF0", VA = "0x18639A2F0", Slot = "8")]
		public void OBDOGGFOIJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x639A370", Offset = "0x6398B70", VA = "0x18639A370")]
		public NBHOKEECIIF(MMDevice FCJCNICEPGC, bool GLOOHAGIEDO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NBHOKEECIIF> FLFEEGPCJBF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MPNBOGAEOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63999A0", Offset = "0x63981A0", VA = "0x1863999A0", Slot = "5")]
	public IReadOnlyList<JEEGEBBKPBL> IADBFHDFNJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6399CC0", Offset = "0x63984C0", VA = "0x186399CC0")]
	public BDCLEDBMPHM()
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
