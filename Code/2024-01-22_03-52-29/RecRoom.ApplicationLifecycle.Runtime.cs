using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AEEKDCONHEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Thread LLAKOCBDEBI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool AKADEFFHFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5EF0", Offset = "0x5EE52F0", VA = "0x185EE5EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5E90", Offset = "0x5EE5290", VA = "0x185EE5E90")]
	[PFGHMHCOGDP(HCKINNNGEKD.Unity_AfterSceneLoad)]
	private static void JKLDANPBABA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KHBCOBDANEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HMCLFBLAOKJ MIEOIMMOOIE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event MEOPFIBOPAN AKOCPLJFKLG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FKKGIHGJNCF CDCKLMHNAOM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GOEEIHMNNMO COBFCIDFCFC;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HINIAGBGJAC DLLEDMMNMOA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event CHJDEDFFLPH JFBENNBBANK;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event KHMCCMDLBPI ILIENADECNF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KMJJFAOANKG OJFIFIMMLNM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NIPCLEOBAGA HNFPDCGKNNH;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void MEOPFIBOPAN();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void FKKGIHGJNCF();
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void GOEEIHMNNMO();
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void CHJDEDFFLPH();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void KHMCCMDLBPI();
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void KMJJFAOANKG();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void HINIAGBGJAC();
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void HMCLFBLAOKJ(bool BBCDFDILNAL);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void NIPCLEOBAGA();
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ApplicationQuitBehavior : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5F40", Offset = "0x5EE5340", VA = "0x185EE5F40")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5EE6020", Offset = "0x5EE5420", VA = "0x185EE6020")]
		public static void SafeDestroyGameObject(GameObject IFGJJHCIEPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
		public ApplicationQuitBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LBNKFDEHMFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static bool BCFHMAAFAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5EE61C0", Offset = "0x5EE55C0", VA = "0x185EE61C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE60C0", Offset = "0x5EE54C0", VA = "0x185EE60C0")]
	[PFGHMHCOGDP(HCKINNNGEKD.Unity_AfterSceneLoad)]
	private static void FILODNFGCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6180", Offset = "0x5EE5580", VA = "0x185EE6180")]
	internal static void GDBHCECNPLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FLNIMAPLLEA
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<bool> PNAOINCJANF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetInnerFocusProvider(FLNIMAPLLEA EEJEILGGNLN);
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
