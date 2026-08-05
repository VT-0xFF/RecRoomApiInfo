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
public interface BPLOJBKBPPF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HNMGHMFNLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<NFNNBKPAGJL> KOMBJMAGOPC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NFNNBKPAGJL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string MNJPGDEKEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CAFMGMNBAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GGJBIIFPHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IOIKMMIBDNA NFHBEEIFOGE(Action<ArraySegment<float>> HKHGMJEBNHA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNIEJHBHFJO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IOIKMMIBDNA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int IBFFDIBGJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5598D0", Offset = "0x5588D0", VA = "0x1805598D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x843110", Offset = "0x842110", VA = "0x180843110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LEDDKALKOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE2C9E0", Offset = "0xE2B9E0", VA = "0x180E2C9E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF8BE40", Offset = "0xF8AE40", VA = "0x180F8BE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2F070", Offset = "0x1E2E070", VA = "0x181E2F070")]
	public IOIKMMIBDNA(int NNMLHHHODLD, int ABFLGGDIDFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NEHLIPPDHCN
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BPLOJBKBPPF IEKKIEKEIPO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool HNMGHMFNLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F660", Offset = "0x1E2E660", VA = "0x181E2F660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E2F7C0", Offset = "0x1E2E7C0", VA = "0x181E2F7C0")]
	static NEHLIPPDHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E2F6D0", Offset = "0x1E2E6D0", VA = "0x181E2F6D0")]
	public static IReadOnlyList<NFNNBKPAGJL> KOMBJMAGOPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class POPFDLGJAHK : BPLOJBKBPPF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KMPGEBJGGLN : NFNNBKPAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IPKCPCPMCCJ
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
			[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
			public IPKCPCPMCCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1E2F080", Offset = "0x1E2E080", VA = "0x181E2F080")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice KADCIGANOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JCGMJLLGKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource DHJPDEAJLKK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MNJPGDEKEDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1E2F280", Offset = "0x1E2E280", VA = "0x181E2F280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CAFMGMNBAED
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6C03E0", Offset = "0x6BF3E0", VA = "0x1806C03E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6C0430", Offset = "0x6BF430", VA = "0x1806C0430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GGJBIIFPHAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x89F860", Offset = "0x89E860", VA = "0x18089F860", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F5E0", Offset = "0x1E2E5E0", VA = "0x181E2F5E0", Slot = "7")]
		public IOIKMMIBDNA NFHBEEIFOGE(Action<ArraySegment<float>> HKHGMJEBNHA)
		{
			return default(IOIKMMIBDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F2A0", Offset = "0x1E2E2A0", VA = "0x181E2F2A0")]
		private IOIKMMIBDNA NFHBEEIFOGE(int NNMLHHHODLD, int ACEDPFMPEIL, int ABFLGGDIDFF, Action<ArraySegment<float>> HKHGMJEBNHA)
		{
			return default(IOIKMMIBDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F200", Offset = "0x1E2E200", VA = "0x181E2F200", Slot = "8")]
		public void BNIEJHBHFJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F610", Offset = "0x1E2E610", VA = "0x181E2F610")]
		public KMPGEBJGGLN(MMDevice KADCIGANOEP, bool LIJMGAIACGG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KMPGEBJGGLN> JHEOBPIPMMB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HNMGHMFNLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x557FC0", Offset = "0x556FC0", VA = "0x180557FC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E2F870", Offset = "0x1E2E870", VA = "0x181E2F870", Slot = "5")]
	public IReadOnlyList<NFNNBKPAGJL> KOMBJMAGOPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E2FB10", Offset = "0x1E2EB10", VA = "0x181E2FB10")]
	public POPFDLGJAHK()
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
