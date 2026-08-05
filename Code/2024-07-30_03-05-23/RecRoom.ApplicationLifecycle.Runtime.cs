using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NPGACAPPFEB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread FOKALHMCELN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool ALDPMIKOPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6887AC0", Offset = "0x68860C0", VA = "0x186887AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6887A60", Offset = "0x6886060", VA = "0x186887A60")]
	[LBGCFGAFOMG(GACAEABCFNO.Unity_AfterSceneLoad)]
	private static void IKLHHCEEFCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JGBDINOJDJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MOLNDIJLKOJ ECGIIFMGPGP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event LIKFLOFOFLJ JPIODFAGAAF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event ADLFPBOCOJF CPKGOLOAPKI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OIKLLFHPCCB OBELDGMGNMD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event BHGIHPNKOFK KIHEOKIFLMN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event NIHJMJOHGDE ADHLIILCICI;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event ELNKJPMABNI PPAAGMINNML;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event GPHBJEFDFMH MFEIOFPECPH;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event PGEHIEDFAOO LEKFIBBEAMG;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void LIKFLOFOFLJ();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void ADLFPBOCOJF();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void OIKLLFHPCCB();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void NIHJMJOHGDE();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void ELNKJPMABNI();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void GPHBJEFDFMH();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void BHGIHPNKOFK();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void MOLNDIJLKOJ(bool AMMCGHJHHIO);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void PGEHIEDFAOO();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68877A0", Offset = "0x6885DA0", VA = "0x1868877A0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6887880", Offset = "0x6885E80", VA = "0x186887880")]
		public static void SafeDestroyGameObject(GameObject FNAHDAKHMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MDGPDHPIJMO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool ADGHNEKJNJK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6887920", Offset = "0x6885F20", VA = "0x186887920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68879A0", Offset = "0x6885FA0", VA = "0x1868879A0")]
	[LBGCFGAFOMG(GACAEABCFNO.Unity_AfterSceneLoad)]
	private static void PNLKNBIHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6887960", Offset = "0x6885F60", VA = "0x186887960")]
	internal static void FBFPAMGJBOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IPOMFOKBLDO
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> GCIHEIPEPMM;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(IPOMFOKBLDO NBENJBJCCLC);
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
