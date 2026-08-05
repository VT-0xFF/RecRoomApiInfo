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
		[Cpp2IlInjected.Address(RVA = "0x7D1460", Offset = "0x7CFA60", VA = "0x1807D1460")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x862070", Offset = "0x860670", VA = "0x180862070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LEDDKALKOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7D1440", Offset = "0x7CFA40", VA = "0x1807D1440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83B920", Offset = "0x839F20", VA = "0x18083B920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E7B520", Offset = "0x4E79B20", VA = "0x184E7B520")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E7BB10", Offset = "0x4E7A110", VA = "0x184E7BB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E7BC70", Offset = "0x4E7A270", VA = "0x184E7BC70")]
	static NEHLIPPDHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4E7BB80", Offset = "0x4E7A180", VA = "0x184E7BB80")]
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
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public IPKCPCPMCCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4E7B530", Offset = "0x4E79B30", VA = "0x184E7B530")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E7B730", Offset = "0x4E79D30", VA = "0x184E7B730", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CAFMGMNBAED
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5E1990", Offset = "0x5DFF90", VA = "0x1805E1990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6FF3F0", Offset = "0x6FD9F0", VA = "0x1806FF3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GGJBIIFPHAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x776830", Offset = "0x774E30", VA = "0x180776830", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E7BA90", Offset = "0x4E7A090", VA = "0x184E7BA90", Slot = "7")]
		public IOIKMMIBDNA NFHBEEIFOGE(Action<ArraySegment<float>> HKHGMJEBNHA)
		{
			return default(IOIKMMIBDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4E7B750", Offset = "0x4E79D50", VA = "0x184E7B750")]
		private IOIKMMIBDNA NFHBEEIFOGE(int NNMLHHHODLD, int ACEDPFMPEIL, int ABFLGGDIDFF, Action<ArraySegment<float>> HKHGMJEBNHA)
		{
			return default(IOIKMMIBDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4E7B6B0", Offset = "0x4E79CB0", VA = "0x184E7B6B0", Slot = "8")]
		public void BNIEJHBHFJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4E7BAC0", Offset = "0x4E7A0C0", VA = "0x184E7BAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x560FE0", Offset = "0x55F5E0", VA = "0x180560FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E7BD20", Offset = "0x4E7A320", VA = "0x184E7BD20", Slot = "5")]
	public IReadOnlyList<NFNNBKPAGJL> KOMBJMAGOPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4E7BFC0", Offset = "0x4E7A5C0", VA = "0x184E7BFC0")]
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
