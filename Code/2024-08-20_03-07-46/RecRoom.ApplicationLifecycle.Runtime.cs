using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GCECNNEAPFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread GDLCELDJBPC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool OPJPMMPJHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67FAAD0", Offset = "0x67F9AD0", VA = "0x1867FAAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67FAB20", Offset = "0x67F9B20", VA = "0x1867FAB20")]
	[JHNEDNDFJPF(JOFJHDAEEPM.Unity_AfterSceneLoad)]
	private static void HDKCILMBALK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MIJJCBKIGMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event JKLABEFHNBD NLPCAHONOCD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event OFBOEEOKDCB GACAEOGENLN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event PKMDNNFHCMB FKADPNLKBOK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CMNKFAOCDNP CKPHNMOIKMP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CJKIDBCONAA HFLNKOHFMGI;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event HNBNBFHMOEG LHBEDPAJMOI;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event OPMHCLMOMON NDGBHLAHIDH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MAGBDHBHANC GFPBPPDLFFN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event GPGCEOBLABP NFPJEFEOAJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void OFBOEEOKDCB();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void PKMDNNFHCMB();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void CMNKFAOCDNP();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HNBNBFHMOEG();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void OPMHCLMOMON();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void MAGBDHBHANC();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void CJKIDBCONAA();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void JKLABEFHNBD(bool BINMFMMBPAC);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void GPGCEOBLABP();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67FA950", Offset = "0x67F9950", VA = "0x1867FA950")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67FAA30", Offset = "0x67F9A30", VA = "0x1867FAA30")]
		public static void SafeDestroyGameObject(GameObject IDHOMJBMFPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MIINHDINJOG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool HJJGCPKFMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC40", Offset = "0x67F9C40", VA = "0x1867FAC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67FAB80", Offset = "0x67F9B80", VA = "0x1867FAB80")]
	[JHNEDNDFJPF(JOFJHDAEEPM.Unity_AfterSceneLoad)]
	private static void LFNNOPDGNGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67FAC80", Offset = "0x67F9C80", VA = "0x1867FAC80")]
	internal static void MCHKBPDOBHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HMGPGJJELDP
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> IGDFNFDPCON;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(HMGPGJJELDP ODJANOAINHC);
}
namespace Cpp2IlInjected
{
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
}
