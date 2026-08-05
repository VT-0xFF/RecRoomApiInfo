using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PFGNIGNLONH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread OEEFPLBMBKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool IMBHBPDEKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5C07390", Offset = "0x5C06790", VA = "0x185C07390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C073E0", Offset = "0x5C067E0", VA = "0x185C073E0")]
	[LADHGFOOMDP(MEEEIBLMBLE.Unity_AfterSceneLoad)]
	private static void KNIANBDCMAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CDOHLKFPFCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LFPLBFFLOAA PLFDPLJHCDC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event EDPOPGADDAL MCPJDCOFDHA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JONGKJDHDGN OIDBFPCGOHI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JNMCBHEICPJ BHIDFMIADLP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FHBMEFPCPLP GGNEHJCHKIN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PJMMMKDHGCL DOFOBHHJCMK;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event DMIDBJPMAHN OOAMBHGAJEI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event BECDNMIBNFG GABPNLLMKOI;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event DGPILABEONF JFPLICKLHIA;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void EDPOPGADDAL();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void JONGKJDHDGN();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JNMCBHEICPJ();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void PJMMMKDHGCL();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void DMIDBJPMAHN();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void BECDNMIBNFG();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void FHBMEFPCPLP();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void LFPLBFFLOAA(bool BBNJIDAKOMM);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void DGPILABEONF();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5C070D0", Offset = "0x5C064D0", VA = "0x185C070D0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5C071B0", Offset = "0x5C065B0", VA = "0x185C071B0")]
		public static void SafeDestroyGameObject(GameObject GHAOKLKOOCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MLLIKDGAEFL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool AGIONMBJHHE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5C07250", Offset = "0x5C06650", VA = "0x185C07250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5C072D0", Offset = "0x5C066D0", VA = "0x185C072D0")]
	[LADHGFOOMDP(MEEEIBLMBLE.Unity_AfterSceneLoad)]
	private static void OMELHDOHHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5C07290", Offset = "0x5C06690", VA = "0x185C07290")]
	internal static void DBLCNAEANNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EPBEPMLICEA
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> DKJGPPHCLJI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(EPBEPMLICEA NAHGPGEHHIM);
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
