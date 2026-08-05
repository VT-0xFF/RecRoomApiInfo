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
public interface KNCAMEPPDGH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CMGALCMGGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<OINOGIOEGHM> KFDHMPOBBNI();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OINOGIOEGHM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string CNKMNOLOFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JPILJAFDPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KIKONIOKFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DDCNOENOAEA IFBDIMKCNKI(Action<ArraySegment<float>> CNAECKKILBA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JKKNBDPFBIN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DDCNOENOAEA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ENBFLIBGGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5992D0", Offset = "0x5980D0", VA = "0x1805992D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5C0280", Offset = "0x5BF080", VA = "0x1805C0280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LPFHFPBOPNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5992B0", Offset = "0x5980B0", VA = "0x1805992B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEEC1C0", Offset = "0xEEAFC0", VA = "0x180EEC1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6160", Offset = "0x3CF4F60", VA = "0x183CF6160")]
	public DDCNOENOAEA(int BLFIBCJBPJG, int IMHDLJIGDAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DGHNACDFKMG
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static KNCAMEPPDGH FPOEAGBMAHO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool CMGALCMGGNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6170", Offset = "0x3CF4F70", VA = "0x183CF6170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3CF62D0", Offset = "0x3CF50D0", VA = "0x183CF62D0")]
	static DGHNACDFKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3CF61E0", Offset = "0x3CF4FE0", VA = "0x183CF61E0")]
	public static IReadOnlyList<OINOGIOEGHM> KFDHMPOBBNI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KLDMJEMMEAB : KNCAMEPPDGH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DHOGFBAFEHA : OINOGIOEGHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OKGPHNGBHEE
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
			[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
			public OKGPHNGBHEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3CF6A40", Offset = "0x3CF5840", VA = "0x183CF6A40")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice DBOHBKEKFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DODKPFOHOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource EAKNMFHBOLK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string CNKMNOLOFGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3CF66E0", Offset = "0x3CF54E0", VA = "0x183CF66E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JPILJAFDPCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x55FD70", Offset = "0x55EB70", VA = "0x18055FD70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x63FB00", Offset = "0x63E900", VA = "0x18063FB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KIKONIOKFLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7B3990", Offset = "0x7B2790", VA = "0x1807B3990", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6650", Offset = "0x3CF5450", VA = "0x183CF6650", Slot = "7")]
		public DDCNOENOAEA IFBDIMKCNKI(Action<ArraySegment<float>> CNAECKKILBA)
		{
			return default(DDCNOENOAEA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6370", Offset = "0x3CF5170", VA = "0x183CF6370")]
		private DDCNOENOAEA IFBDIMKCNKI(int BLFIBCJBPJG, int LINHDNKDLAN, int IMHDLJIGDAC, Action<ArraySegment<float>> CNAECKKILBA)
		{
			return default(DDCNOENOAEA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6680", Offset = "0x3CF5480", VA = "0x183CF6680", Slot = "8")]
		public void JKKNBDPFBIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6700", Offset = "0x3CF5500", VA = "0x183CF6700")]
		public DHOGFBAFEHA(MMDevice DBOHBKEKFPN, bool APGGHOOOMAD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<DHOGFBAFEHA> MIEOEKFLNII;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CMGALCMGGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x41FF60", Offset = "0x41ED60", VA = "0x18041FF60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6740", Offset = "0x3CF5540", VA = "0x183CF6740", Slot = "5")]
	public IReadOnlyList<OINOGIOEGHM> KFDHMPOBBNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3CF69E0", Offset = "0x3CF57E0", VA = "0x183CF69E0")]
	public KLDMJEMMEAB()
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
