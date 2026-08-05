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
public interface HDIFJEJMDFP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BBBCBEBHEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PLBCACAHIIC> NEHLDOPMNLC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PLBCACAHIIC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string GKPIDFDNOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LPLCACLFOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HHIOENMAOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DLIACJOKEPO EBEPKEKHEAK(Action<ArraySegment<float>> LKEPFHDAAED);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCGNEGCCNAO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DLIACJOKEPO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FPEAPJHHFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NPENCGNAFHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D960", Offset = "0x2E1CB60", VA = "0x182E1D960")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EB12E0", Offset = "0x6EB04E0", VA = "0x186EB12E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7CF63A0", Offset = "0x7CF55A0", VA = "0x187CF63A0")]
	public DLIACJOKEPO(int KMFDKCJJMDF, int DEODAOLDHFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MIMAAAFDFGK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HDIFJEJMDFP PPFHDLNHEED;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BBBCBEBHEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x877C480", Offset = "0x877B680", VA = "0x18877C480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x877C5E0", Offset = "0x877B7E0", VA = "0x18877C5E0")]
	static MIMAAAFDFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x877C4F0", Offset = "0x877B6F0", VA = "0x18877C4F0")]
	public static IReadOnlyList<PLBCACAHIIC> NEHLDOPMNLC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CJKMFLLPIBK : HDIFJEJMDFP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ALIIIFFHELE : PLBCACAHIIC
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BKDJELNKJOA
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
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public BKDJELNKJOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x877BF50", Offset = "0x877B150", VA = "0x18877BF50")]
			internal void HDPNLPFADNG(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice ALLMFPJBBPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LJILOLBGGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NGPHECFCDKE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GKPIDFDNOIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x877BE60", Offset = "0x877B060", VA = "0x18877BE60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LPLCACLFOML
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xDC4260", Offset = "0xDC3460", VA = "0x180DC4260", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAADDE0", Offset = "0xAACFE0", VA = "0x180AADDE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HHIOENMAOJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD9B3D0", Offset = "0xD9A5D0", VA = "0x180D9B3D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x877BA70", Offset = "0x877AC70", VA = "0x18877BA70", Slot = "7")]
		public DLIACJOKEPO EBEPKEKHEAK(Action<ArraySegment<float>> LKEPFHDAAED)
		{
			return default(DLIACJOKEPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x877BAA0", Offset = "0x877ACA0", VA = "0x18877BAA0")]
		private DLIACJOKEPO EBEPKEKHEAK(int KMFDKCJJMDF, int EOGIFDNJBLN, int DEODAOLDHFK, Action<ArraySegment<float>> LKEPFHDAAED)
		{
			return default(DLIACJOKEPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x877BE80", Offset = "0x877B080", VA = "0x18877BE80", Slot = "8")]
		public void JCGNEGCCNAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x877BF00", Offset = "0x877B100", VA = "0x18877BF00")]
		public ALIIIFFHELE(MMDevice ALLMFPJBBPM, bool HGLECDLBJLL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<ALIIIFFHELE> EIHIPPFFMDH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BBBCBEBHEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x877C0D0", Offset = "0x877B2D0", VA = "0x18877C0D0", Slot = "5")]
	public IReadOnlyList<PLBCACAHIIC> NEHLDOPMNLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x877C3F0", Offset = "0x877B5F0", VA = "0x18877C3F0")]
	public CJKMFLLPIBK()
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
