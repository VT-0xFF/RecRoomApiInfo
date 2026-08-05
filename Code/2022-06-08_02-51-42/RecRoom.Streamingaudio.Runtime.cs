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
public interface CNEGBOFHNMO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DNADPGAJOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<LLFLCGNFOAJ> AEDOOKOPPHG();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LLFLCGNFOAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string OKOPFAKOMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CFADKDGECLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JMMBIJEDPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NJLDLBMJLGI OIDKNNEAPGH(Action<ArraySegment<float>> IJOJDDBGAPC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BKBHLDPHCDO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NJLDLBMJLGI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BIEIPEEGMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5BBD80", Offset = "0x5BAD80", VA = "0x1805BBD80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5BBDA0", Offset = "0x5BADA0", VA = "0x1805BBDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BKDFACKIHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6BDD40", Offset = "0x6BCD40", VA = "0x1806BDD40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1B28B40", Offset = "0x1B27B40", VA = "0x181B28B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C6A0", Offset = "0x4D9B6A0", VA = "0x184D9C6A0")]
	public NJLDLBMJLGI(int DCOKNMKOOGK, int LMGHEBJCMCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GPKDMIOJPIP
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static CNEGBOFHNMO MFDAALHMDJL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool DNADPGAJOPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4D9C270", Offset = "0x4D9B270", VA = "0x184D9C270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C2E0", Offset = "0x4D9B2E0", VA = "0x184D9C2E0")]
	static GPKDMIOJPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C180", Offset = "0x4D9B180", VA = "0x184D9C180")]
	public static IReadOnlyList<LLFLCGNFOAJ> AEDOOKOPPHG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JMPKNPKLFID : CNEGBOFHNMO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GKAKIOPLGMB : LLFLCGNFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class AMHEPAFOIMO
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
			[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
			public AMHEPAFOIMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4D9BBA0", Offset = "0x4D9ABA0", VA = "0x184D9BBA0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice IKAGDAAMAKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture KMFENPLMILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BLBGBKHAIKA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OKOPFAKOMPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4D9BDA0", Offset = "0x4D9ADA0", VA = "0x184D9BDA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CFADKDGECLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6D38D0", Offset = "0x6D28D0", VA = "0x1806D38D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7F0AF0", Offset = "0x7EFAF0", VA = "0x1807F0AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JMMBIJEDPAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC25E50", Offset = "0xC24E50", VA = "0x180C25E50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4D9C100", Offset = "0x4D9B100", VA = "0x184D9C100", Slot = "7")]
		public NJLDLBMJLGI OIDKNNEAPGH(Action<ArraySegment<float>> IJOJDDBGAPC)
		{
			return default(NJLDLBMJLGI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4D9BDC0", Offset = "0x4D9ADC0", VA = "0x184D9BDC0")]
		private NJLDLBMJLGI OIDKNNEAPGH(int DCOKNMKOOGK, int LIINNMJICKM, int LMGHEBJCMCA, Action<ArraySegment<float>> IJOJDDBGAPC)
		{
			return default(NJLDLBMJLGI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4D9BD20", Offset = "0x4D9AD20", VA = "0x184D9BD20", Slot = "8")]
		public void BKBHLDPHCDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4D9C130", Offset = "0x4D9B130", VA = "0x184D9C130")]
		public GKAKIOPLGMB(MMDevice IKAGDAAMAKF, bool KMKJJBNPDOC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<GKAKIOPLGMB> GBIOPJODGPJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DNADPGAJOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x555B00", Offset = "0x554B00", VA = "0x180555B00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C390", Offset = "0x4D9B390", VA = "0x184D9C390", Slot = "5")]
	public IReadOnlyList<LLFLCGNFOAJ> AEDOOKOPPHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C630", Offset = "0x4D9B630", VA = "0x184D9C630")]
	public JMPKNPKLFID()
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
