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
public interface NALEIBKBPBG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GPEHEMDDJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<JCKPKFPHMOP> FFILKIJAKNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JCKPKFPHMOP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BNIPAODMOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OMGFMEDJDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OCGNMECGCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IJLDCINOJED AOGKGCIELFP(Action<ArraySegment<float>> HMCGKHCFDKN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEBCAGBNKPL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IJLDCINOJED
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DDBMLCKALAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62BAC0", Offset = "0x62ACC0", VA = "0x18062BAC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x652A60", Offset = "0x651C60", VA = "0x180652A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DMBKMFLDFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62BAA0", Offset = "0x62ACA0", VA = "0x18062BAA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E8BFC0", Offset = "0x1E8B1C0", VA = "0x181E8BFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D7F450", Offset = "0x3D7E650", VA = "0x183D7F450")]
	public IJLDCINOJED(int GNHCJKIHOIB, int KMLLKAKKMDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OBOMOGHKEDG
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NALEIBKBPBG AIEOKHMKNMM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GPEHEMDDJFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3D7F830", Offset = "0x3D7EA30", VA = "0x183D7F830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D7F990", Offset = "0x3D7EB90", VA = "0x183D7F990")]
	static OBOMOGHKEDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3D7F8A0", Offset = "0x3D7EAA0", VA = "0x183D7F8A0")]
	public static IReadOnlyList<JCKPKFPHMOP> FFILKIJAKNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EHOOKGFDEKH : NALEIBKBPBG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NLJFMBOGMMO : JCKPKFPHMOP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EBDJAOFOLDD
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
			[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
			public EBDJAOFOLDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3D7EFD0", Offset = "0x3D7E1D0", VA = "0x183D7EFD0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice MPNMJEFEKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture GPBDIBPJKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource PJCGEIKKGKD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BNIPAODMOIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3D7F7D0", Offset = "0x3D7E9D0", VA = "0x183D7F7D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OMGFMEDJDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x4E8A20", Offset = "0x4E7C20", VA = "0x1804E8A20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5E8610", Offset = "0x5E7810", VA = "0x1805E8610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OCGNMECGCDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x903200", Offset = "0x902400", VA = "0x180903200", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D7F740", Offset = "0x3D7E940", VA = "0x183D7F740", Slot = "7")]
		public IJLDCINOJED AOGKGCIELFP(Action<ArraySegment<float>> HMCGKHCFDKN)
		{
			return default(IJLDCINOJED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D7F460", Offset = "0x3D7E660", VA = "0x183D7F460")]
		private IJLDCINOJED AOGKGCIELFP(int GNHCJKIHOIB, int AHBLDKKFOLN, int KMLLKAKKMDK, Action<ArraySegment<float>> HMCGKHCFDKN)
		{
			return default(IJLDCINOJED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D7F770", Offset = "0x3D7E970", VA = "0x183D7F770", Slot = "8")]
		public void GEBCAGBNKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D7F7F0", Offset = "0x3D7E9F0", VA = "0x183D7F7F0")]
		public NLJFMBOGMMO(MMDevice MPNMJEFEKGG, bool OKHHBDIEDEP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NLJFMBOGMMO> AFFPNKMLMNE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GPEHEMDDJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x425F60", Offset = "0x425160", VA = "0x180425F60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3D7F150", Offset = "0x3D7E350", VA = "0x183D7F150", Slot = "5")]
	public IReadOnlyList<JCKPKFPHMOP> FFILKIJAKNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D7F3F0", Offset = "0x3D7E5F0", VA = "0x183D7F3F0")]
	public EHOOKGFDEKH()
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
