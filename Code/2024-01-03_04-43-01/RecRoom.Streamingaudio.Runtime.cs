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
public interface GIBJBCINELD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MCMJBMGCNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<KMPGCFBDFDO> FIIDHKMLFME();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KMPGCFBDFDO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string GABNJEJFCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OPMMPJILFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HOBLJDHECBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LINKCPOFCPN CPKAACPFFIN(Action<ArraySegment<float>> FCFEFDOJHCD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ENELEPEGHFP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LINKCPOFCPN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MFEKPEJBICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85B650", Offset = "0x85A250", VA = "0x18085B650")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85B580", Offset = "0x85A180", VA = "0x18085B580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NPGNDLLMIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x20A61A0", Offset = "0x20A4DA0", VA = "0x1820A61A0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5304790", Offset = "0x5303390", VA = "0x185304790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x652E110", Offset = "0x652CD10", VA = "0x18652E110")]
	public LINKCPOFCPN(int LFFCEAFHKKN, int MIKIBCBLLEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ADNGIJFDPPF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static GIBJBCINELD HAKDLBEAKGE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MCMJBMGCNJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x652DA70", Offset = "0x652C670", VA = "0x18652DA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x652DAF0", Offset = "0x652C6F0", VA = "0x18652DAF0")]
	static ADNGIJFDPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x652D980", Offset = "0x652C580", VA = "0x18652D980")]
	public static IReadOnlyList<KMPGCFBDFDO> FIIDHKMLFME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JGEEDAFDBKM : GIBJBCINELD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NCFIJHOPOAH : KMPGCFBDFDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class AHBHABBFHMN
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
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public AHBHABBFHMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x652DBE0", Offset = "0x652C7E0", VA = "0x18652DBE0")]
			internal void JGLBCICBCFG(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NINFKODLPHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture ACLBGEDIAJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BPFFLGJKJLD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GABNJEJFCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x652E590", Offset = "0x652D190", VA = "0x18652E590", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OPMMPJILFAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x853290", Offset = "0x851E90", VA = "0x180853290", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x90A8D0", Offset = "0x9094D0", VA = "0x18090A8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HOBLJDHECBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC40E20", Offset = "0xC3FA20", VA = "0x180C40E20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x652E120", Offset = "0x652CD20", VA = "0x18652E120", Slot = "7")]
		public LINKCPOFCPN CPKAACPFFIN(Action<ArraySegment<float>> FCFEFDOJHCD)
		{
			return default(LINKCPOFCPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x652E150", Offset = "0x652CD50", VA = "0x18652E150")]
		private LINKCPOFCPN CPKAACPFFIN(int LFFCEAFHKKN, int BDCEDDBOOIH, int MIKIBCBLLEC, Action<ArraySegment<float>> FCFEFDOJHCD)
		{
			return default(LINKCPOFCPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x652E510", Offset = "0x652D110", VA = "0x18652E510", Slot = "8")]
		public void ENELEPEGHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x652E5B0", Offset = "0x652D1B0", VA = "0x18652E5B0")]
		public NCFIJHOPOAH(MMDevice NINFKODLPHH, bool CABOGDKMNGE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NCFIJHOPOAH> MGJBIJAFMLK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MCMJBMGCNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78C390", Offset = "0x78AF90", VA = "0x18078C390", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x652DD60", Offset = "0x652C960", VA = "0x18652DD60", Slot = "5")]
	public IReadOnlyList<KMPGCFBDFDO> FIIDHKMLFME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x652E080", Offset = "0x652CC80", VA = "0x18652E080")]
	public JGEEDAFDBKM()
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
