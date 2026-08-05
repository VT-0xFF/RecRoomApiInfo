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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87952C0", Offset = "0x8793AC0", VA = "0x1887952C0", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8157C30", Offset = "0x8156430", VA = "0x188157C30", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8796260", Offset = "0x8794A60", VA = "0x188796260")]
		private void MBKOFANELHN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8796670", Offset = "0x8794E70", VA = "0x188796670", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87964A0", Offset = "0x8794CA0", VA = "0x1887964A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87966D0", Offset = "0x8794ED0", VA = "0x1887966D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(PHMPEGCLNAP), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class PHMPEGCLNAP : NLLGALIJPAA, DEPOIAMCLIH
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class EHAFODELOOC : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public PHMPEGCLNAP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public EHAFODELOOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8795050", Offset = "0x8793850", VA = "0x188795050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8795270", Offset = "0x8793A70", VA = "0x188795270", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private MDIKJLIBPEB OLAGGPLNDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private FNBFDEKMNMG OBBIALMFJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable PPOPGFHOIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable FHLKAOHICCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> AGKAEFHDJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool NLHAMFLICAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool DPGLCDKIBAJ;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x87961D0", Offset = "0x87949D0", VA = "0x1887961D0")]
	[UnityEngine.Scripting.Preserve]
	public PHMPEGCLNAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8795E10", Offset = "0x8794610", VA = "0x188795E10", Slot = "4")]
	public void InitExternal(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8795F90", Offset = "0x8794790", VA = "0x188795F90")]
	private void JOIJDMNAOEO(Scene DKCLIGACLBO, LoadSceneMode ICCFEABGHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8795390", Offset = "0x8793B90", VA = "0x188795390")]
	private void ACKMMANNBJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8795FA0", Offset = "0x87947A0", VA = "0x188795FA0")]
	private void NHOODJNNMHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8795730", Offset = "0x8793F30", VA = "0x188795730")]
	private (ReflectionProbe, int) HJKCKAJCMLB()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x87960D0", Offset = "0x87948D0", VA = "0x1887960D0")]
	[IteratorStateMachine(typeof(EHAFODELOOC))]
	private IEnumerator<ENGFNCJEKHI> OPHJFHAKMBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8795540", Offset = "0x8793D40", VA = "0x188795540")]
	private void AIDHPDNLENE([CanBeNull] ReflectionProbe IGIFOGMBABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8795700", Offset = "0x8793F00", VA = "0x188795700")]
	private void FMGPHFAJMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8796080", Offset = "0x8794880", VA = "0x188796080")]
	private void OBKEBMMKILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8795620", Offset = "0x8793E20", VA = "0x188795620", Slot = "5")]
	public void AIEFDFNMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x87958F0", Offset = "0x87940F0", VA = "0x1887958F0")]
	[CompilerGenerated]
	private void ICHHEDEOPAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MDIKJLIBPEB
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? HMEHEFMDLGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BFFNABOEDOL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPEBKKINLFH();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AAKECIIFJKO : MDIKJLIBPEB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string CBBPKJNIAHL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string DPDCADEDAEK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string DPMIGNIHAEC;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string ICOGFGNMBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private OKNMANBEBON DFLHENIBAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? PGKIHPOBNLK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? HMEHEFMDLGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BFFNABOEDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	[UnityEngine.Scripting.Preserve]
	public AAKECIIFJKO([NotNull][FAPODKMFODF(null)] OKNMANBEBON ANOIHLPEACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8794B10", Offset = "0x8793310", VA = "0x188794B10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8794C10", Offset = "0x8793410", VA = "0x188794C10")]
	[NOOFMBJKOEL.KNDBLKJENBF.CEKCOAHLABB]
	[UsedImplicitly]
	public static void LFAODLNPKOM(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8794D00", Offset = "0x8793500", VA = "0x188794D00", Slot = "5")]
	public void LPEBKKINLFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8794570", Offset = "0x8792D70", VA = "0x188794570")]
	private void AOJNNMAPFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8794E00", Offset = "0x8793600", VA = "0x188794E00")]
	private bool NOIGNPJPMBK(string IFFJEBHEBKF, [Out] PGOCLPJPCFO LCFPNFAGGBB)
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
