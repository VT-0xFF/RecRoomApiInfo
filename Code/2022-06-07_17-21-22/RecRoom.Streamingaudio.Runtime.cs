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
		[Cpp2IlInjected.Address(RVA = "0x7961F0", Offset = "0x7949F0", VA = "0x1807961F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x826E70", Offset = "0x825670", VA = "0x180826E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BKDFACKIHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7961D0", Offset = "0x7949D0", VA = "0x1807961D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x800720", Offset = "0x7FEF20", VA = "0x180800720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF170", Offset = "0x4EFD970", VA = "0x184EFF170")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EFED40", Offset = "0x4EFD540", VA = "0x184EFED40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEDB0", Offset = "0x4EFD5B0", VA = "0x184EFEDB0")]
	static GPKDMIOJPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEC50", Offset = "0x4EFD450", VA = "0x184EFEC50")]
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
			[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
			public AMHEPAFOIMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4EFE670", Offset = "0x4EFCE70", VA = "0x184EFE670")]
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
			[Cpp2IlInjected.Address(RVA = "0x4EFE870", Offset = "0x4EFD070", VA = "0x184EFE870", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CFADKDGECLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5E2990", Offset = "0x5E1190", VA = "0x1805E2990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7003F0", Offset = "0x6FEBF0", VA = "0x1807003F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JMMBIJEDPAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739D90", VA = "0x18073B590", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4EFEBD0", Offset = "0x4EFD3D0", VA = "0x184EFEBD0", Slot = "7")]
		public NJLDLBMJLGI OIDKNNEAPGH(Action<ArraySegment<float>> IJOJDDBGAPC)
		{
			return default(NJLDLBMJLGI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4EFE890", Offset = "0x4EFD090", VA = "0x184EFE890")]
		private NJLDLBMJLGI OIDKNNEAPGH(int DCOKNMKOOGK, int LIINNMJICKM, int LMGHEBJCMCA, Action<ArraySegment<float>> IJOJDDBGAPC)
		{
			return default(NJLDLBMJLGI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4EFE7F0", Offset = "0x4EFCFF0", VA = "0x184EFE7F0", Slot = "8")]
		public void BKBHLDPHCDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4EFEC00", Offset = "0x4EFD400", VA = "0x184EFEC00")]
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
		[Cpp2IlInjected.Address(RVA = "0x561FE0", Offset = "0x5607E0", VA = "0x180561FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEE60", Offset = "0x4EFD660", VA = "0x184EFEE60", Slot = "5")]
	public IReadOnlyList<LLFLCGNFOAJ> AEDOOKOPPHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF100", Offset = "0x4EFD900", VA = "0x184EFF100")]
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
