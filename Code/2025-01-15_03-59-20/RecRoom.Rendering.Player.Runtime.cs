using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x76D4300", Offset = "0x76D3700", VA = "0x1876D4300", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1A51480", Offset = "0x1A50880", VA = "0x181A51480", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x76D5D80", Offset = "0x76D5180", VA = "0x1876D5D80")]
		private void PKLDHDIFILK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76D6190", Offset = "0x76D5590", VA = "0x1876D6190", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76D5FC0", Offset = "0x76D53C0", VA = "0x1876D5FC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76D61F0", Offset = "0x76D55F0", VA = "0x1876D61F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(PKMHMDCOFHJ), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class PKMHMDCOFHJ : PMDBFLDINBO, FCDDCBJENJH
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class GGGAPPHMHLD : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public PKMHMDCOFHJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public GGGAPPHMHLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x76D4090", Offset = "0x76D3490", VA = "0x1876D4090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x76D42B0", Offset = "0x76D36B0", VA = "0x1876D42B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EENMOIPFKFJ GNPJEGNEAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CBKPLBJIJFB NMAGJHBNMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable DHHJJNKPGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable DLDNKGHOJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> KGPNPECLOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool LBDHKLDMKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool CLDICKDLJEP;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76D5CF0", Offset = "0x76D50F0", VA = "0x1876D5CF0")]
	[UnityEngine.Scripting.Preserve]
	public PKMHMDCOFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76D5610", Offset = "0x76D4A10", VA = "0x1876D5610", Slot = "4")]
	public void HFGPDAFPJBC(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x76D4F00", Offset = "0x76D4300", VA = "0x1876D4F00")]
	private void CNJIBLKLPDM(Scene ABCAMGHBGAH, LoadSceneMode EEEMLBIDJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x76D5460", Offset = "0x76D4860", VA = "0x1876D5460")]
	private void GFBLENEEHHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x76D5870", Offset = "0x76D4C70", VA = "0x1876D5870")]
	private void ODGGBMIKNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x76D5950", Offset = "0x76D4D50", VA = "0x1876D5950")]
	private (ReflectionProbe, int) OGEDBLCCFLJ()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x76D5B10", Offset = "0x76D4F10", VA = "0x1876D5B10")]
	[IteratorStateMachine(typeof(GGGAPPHMHLD))]
	private IEnumerator<ONHNFKGBFKG> OJGLBHFLGMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76D5B90", Offset = "0x76D4F90", VA = "0x1876D5B90")]
	private void PNFBAANPMCI([CanBeNull] ReflectionProbe NEFALNINPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x76D4F10", Offset = "0x76D4310", VA = "0x1876D4F10")]
	private void DHCIPECHPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76D4EB0", Offset = "0x76D42B0", VA = "0x1876D4EB0")]
	private void AKAJACFPCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x76D5790", Offset = "0x76D4B90", VA = "0x1876D5790", Slot = "5")]
	public void OBDLHHEKPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x76D4F40", Offset = "0x76D4340", VA = "0x1876D4F40")]
	[CompilerGenerated]
	private void EFHEKJOGLHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EENMOIPFKFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? APHPBCFHNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GMDGLEGGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKMJMMLCBAE();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OGPIIELGEDK : EENMOIPFKFJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string BHKJPHHDMGH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string KKDAPALJACE;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string NCNLAJDNILK;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string PEJHJIMHIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PBMDMFNAGKG IHDPOEGNLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? CBMDGCGPPIK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? APHPBCFHNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GMDGLEGGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8D0DA0", Offset = "0x8D01A0", VA = "0x1808D0DA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D0DF0", Offset = "0x8D01F0", VA = "0x1808D0DF0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	[UnityEngine.Scripting.Preserve]
	public OGPIIELGEDK([NotNull][CNGCCDLPGOD(null)] PBMDMFNAGKG NPHJHEOIMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x76D44C0", Offset = "0x76D38C0", VA = "0x1876D44C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x76D43D0", Offset = "0x76D37D0", VA = "0x1876D43D0")]
	[AGCFNMIICNN.HNNLCOLGEGD.DNCHPFJACPB]
	[UsedImplicitly]
	public static void ACAOKDFIMMP(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x76D45C0", Offset = "0x76D39C0", VA = "0x1876D45C0", Slot = "5")]
	public void FKMJMMLCBAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x76D47A0", Offset = "0x76D3BA0", VA = "0x1876D47A0")]
	private void MPAFEALEDKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76D46C0", Offset = "0x76D3AC0", VA = "0x1876D46C0")]
	private bool GCAGKKJCECG(string EIDDCDENPNJ, [Out] KPIDKLDELAH EKJINKPNGFE)
	{
		return default(bool);
	}
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
