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
public interface FHPGOGOOMBK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HJLDOMNPOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<MJPPLOEBCNI> DPNHFIBGNIF();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MJPPLOEBCNI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HCNBCPLJCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HKNAOKIDEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HLHKBELJJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HMGIGBNPJDG HECBJMGHEGG(Action<ArraySegment<float>> ELLFKJCIDIE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JJBHJFAMGMF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HMGIGBNPJDG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CIDMJJOENKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFB0", Offset = "0x7EB7B0", VA = "0x1807ECFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NBBNKDFPFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDFF0", Offset = "0x1FBC7F0", VA = "0x181FBDFF0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x51E9800", Offset = "0x51E8000", VA = "0x1851E9800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x63544C0", Offset = "0x6352CC0", VA = "0x1863544C0")]
	public HMGIGBNPJDG(int JDCHLAAAEBK, int AOKEFOGCKFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IFAAAOOLAEH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FHPGOGOOMBK AEKHIPHOHFO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool HJLDOMNPOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63545C0", Offset = "0x6352DC0", VA = "0x1863545C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6354640", Offset = "0x6352E40", VA = "0x186354640")]
	static IFAAAOOLAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x63544D0", Offset = "0x6352CD0", VA = "0x1863544D0")]
	public static IReadOnlyList<MJPPLOEBCNI> DPNHFIBGNIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MHFICAJDMKF : FHPGOGOOMBK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GADHLHGFECM : MJPPLOEBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PMCBLHOICFJ
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
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public PMCBLHOICFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6354AE0", Offset = "0x63532E0", VA = "0x186354AE0")]
			internal void HPFDMLLDIMO(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice BBOEJGJKBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DKPNDAHCKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource HOMBFOIABNB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HCNBCPLJCJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6354450", Offset = "0x6352C50", VA = "0x186354450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HKNAOKIDEOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7FD4F0", Offset = "0x7FBCF0", VA = "0x1807FD4F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x867C80", Offset = "0x866480", VA = "0x180867C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HLHKBELJJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB82DD0", Offset = "0xB815D0", VA = "0x180B82DD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6353FE0", Offset = "0x63527E0", VA = "0x186353FE0", Slot = "7")]
		public HMGIGBNPJDG HECBJMGHEGG(Action<ArraySegment<float>> ELLFKJCIDIE)
		{
			return default(HMGIGBNPJDG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6354010", Offset = "0x6352810", VA = "0x186354010")]
		private HMGIGBNPJDG HECBJMGHEGG(int JDCHLAAAEBK, int HAKKCNPCLFI, int AOKEFOGCKFE, Action<ArraySegment<float>> ELLFKJCIDIE)
		{
			return default(HMGIGBNPJDG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x63543D0", Offset = "0x6352BD0", VA = "0x1863543D0", Slot = "8")]
		public void JJBHJFAMGMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6354470", Offset = "0x6352C70", VA = "0x186354470")]
		public GADHLHGFECM(MMDevice BBOEJGJKBDL, bool CMOIFMCIKPC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<GADHLHGFECM> GDHEDKJOKCJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HJLDOMNPOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6354730", Offset = "0x6352F30", VA = "0x186354730", Slot = "5")]
	public IReadOnlyList<MJPPLOEBCNI> DPNHFIBGNIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6354A50", Offset = "0x6353250", VA = "0x186354A50")]
	public MHFICAJDMKF()
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
