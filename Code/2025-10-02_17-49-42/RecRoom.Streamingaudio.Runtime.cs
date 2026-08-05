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
public interface MGOPJDFPONJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IDNKFOBCHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<FEDCFFJEEKN> IPIPEHOEFOP();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FEDCFFJEEKN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string KMGIKAEEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IKFAMGAKHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AGPDCONGJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CNBBFHIPMCF NABNGGHGOGA(Action<ArraySegment<float>> AEPCPKCINPI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LHIMGNLHPMK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CNBBFHIPMCF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PGKDCALJAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LMBMFCEPJEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x30A5290", Offset = "0x30A3C90", VA = "0x1830A5290")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x30A52A0", Offset = "0x30A3CA0", VA = "0x1830A52A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8555190", Offset = "0x8553B90", VA = "0x188555190")]
	public CNBBFHIPMCF(int HGCOIPKMAAD, int MCAKEJBBCAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OJBLLGOANLA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MGOPJDFPONJ OHAMBBEIKAP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool IDNKFOBCHKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x908A920", Offset = "0x9089320", VA = "0x18908A920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x908AA90", Offset = "0x9089490", VA = "0x18908AA90")]
	static OJBLLGOANLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x908A9A0", Offset = "0x90893A0", VA = "0x18908A9A0")]
	public static IReadOnlyList<FEDCFFJEEKN> IPIPEHOEFOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PDHCCDAILIJ : MGOPJDFPONJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CFEDFNFNMCL : FEDCFFJEEKN
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LHKJADNKIBB
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
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public LHKJADNKIBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x908A7A0", Offset = "0x90891A0", VA = "0x18908A7A0")]
			internal void OPPNFHLMFED(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice POACFBHAOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture EOJCOBMJJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource ACMMDFMCBDH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string KMGIKAEEDOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x908A340", Offset = "0x9088D40", VA = "0x18908A340", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IKFAMGAKHKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC1EBD0", Offset = "0xC1D5D0", VA = "0x180C1EBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AGPDCONGJEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xF529B0", Offset = "0xF513B0", VA = "0x180F529B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x908A360", Offset = "0x9088D60", VA = "0x18908A360", Slot = "7")]
		public CNBBFHIPMCF NABNGGHGOGA(Action<ArraySegment<float>> AEPCPKCINPI)
		{
			return default(CNBBFHIPMCF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x908A390", Offset = "0x9088D90", VA = "0x18908A390")]
		private CNBBFHIPMCF NABNGGHGOGA(int HGCOIPKMAAD, int LECCPKDKJEL, int MCAKEJBBCAG, Action<ArraySegment<float>> AEPCPKCINPI)
		{
			return default(CNBBFHIPMCF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x908A2C0", Offset = "0x9088CC0", VA = "0x18908A2C0", Slot = "8")]
		public void LHIMGNLHPMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x908A750", Offset = "0x9089150", VA = "0x18908A750")]
		public CFEDFNFNMCL(MMDevice POACFBHAOGA, bool FAFKIJMEICM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<CFEDFNFNMCL> JDAPDFLDBCB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool IDNKFOBCHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x908AB80", Offset = "0x9089580", VA = "0x18908AB80", Slot = "5")]
	public IReadOnlyList<FEDCFFJEEKN> IPIPEHOEFOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x908AEA0", Offset = "0x90898A0", VA = "0x18908AEA0")]
	public PDHCCDAILIJ()
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
