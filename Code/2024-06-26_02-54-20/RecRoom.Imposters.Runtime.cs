using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private readonly struct CGIJKHLEMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly COGGGBKBGAB KLNEPAJLPJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BHHKKMMCCDB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAB3FA0", Offset = "0xAB25A0", VA = "0x180AB3FA0")]
		public CGIJKHLEMAM(COGGGBKBGAB MOHJGJMENOK, string DDPKLNDJNDO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct DAKGPENPLAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CGIJKHLEMAM queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x695F020", Offset = "0x695D620", VA = "0x18695F020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x695F3C0", Offset = "0x695D9C0", VA = "0x18695F3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider PDODAEFJFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OEGIOJIPBCE<CGIJKHLEMAM, GameObject> PDMGKKFPIOM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BJLPLEGJHFG MEPIPADJPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x864DF0", Offset = "0x8633F0", VA = "0x180864DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OEGIOJIPBCE<CGIJKHLEMAM, GameObject> EOBJJFOPNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x695FE90", Offset = "0x695E490", VA = "0x18695FE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int HIKKBMDDEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x695FD80", Offset = "0x695E380", VA = "0x18695FD80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x695FDD0", Offset = "0x695E3D0", VA = "0x18695FDD0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69601D0", Offset = "0x695E7D0", VA = "0x1869601D0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6960240", Offset = "0x695E840", VA = "0x186960240")]
	[AsyncStateMachine(typeof(DAKGPENPLAD))]
	private Task<GameObject> PNLIHPPGKBG(CGIJKHLEMAM ONKJHIMLJAC, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x695FFF0", Offset = "0x695E5F0", VA = "0x18695FFF0")]
	public Task<GameObject> LoadItemAsync(COGGGBKBGAB MOHJGJMENOK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6960360", Offset = "0x695E960", VA = "0x186960360")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class NDPECDGLKCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public COGGGBKBGAB AFGHNLGIAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture HCPDGDFHMFM;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8677E0", Offset = "0x865DE0", VA = "0x1808677E0")]
		public NDPECDGLKCE(COGGGBKBGAB BNMOBGFDFNK, Texture ODAFHLABAMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum JAKGJEEAPMP
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class GBPAGLFFJEC : OCGDHNPKGKG<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct AKLOLOGGOIA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public GBPAGLFFJEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x695D770", Offset = "0x695BD70", VA = "0x18695D770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x695DF80", Offset = "0x695C580", VA = "0x18695DF80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly COGGGBKBGAB BNMOBGFDFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture PNMGAIOOBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig BLHGLOOHGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken DADBOHKBJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject LFNFIODEMPH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override HCGNNEJAOHI<Texture> PCBEFABIIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6960D90", Offset = "0x695F390", VA = "0x186960D90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> ADMBNEIFAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B530", VA = "0x18086CF30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6960DF0", Offset = "0x695F3F0", VA = "0x186960DF0")]
		public GBPAGLFFJEC(COGGGBKBGAB BNMOBGFDFNK, RenderTexture PNMGAIOOBPI, ImposterRenderConfig BLHGLOOHGPA, CancellationToken DADBOHKBJNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6960C10", Offset = "0x695F210", VA = "0x186960C10")]
		[AsyncStateMachine(typeof(AKLOLOGGOIA))]
		private Task<Texture> DMEKLBBHDMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6960D80", Offset = "0x695F380", VA = "0x186960D80", Slot = "10")]
		protected override void LFGLBHDCMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6960D00", Offset = "0x695F300", VA = "0x186960D00")]
		private static void IJBCNKFNOLD(GameObject LFNFIODEMPH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EKNLPJLMKAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69603A0", Offset = "0x695E9A0", VA = "0x1869603A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private JAKGJEEAPMP size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[MDFGNKLCKEN("size", JAKGJEEAPMP.Custom)]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Tooltip("Configuration specifying render properties for the imposter")]
	[SerializeField]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int CPMFHHKLGBH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture GEICPHJMFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private FIFOCLFLKIE<GameObject> MLLCPBPJKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private PGGFJFHOMCP NPJMNNBJPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource GKNCGENIMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private FMHOFFFMGIN<Texture> LDHAOLNEFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private COGGGBKBGAB FPDCLHFKKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture LDJFMJNBKLD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int NCLBFLHLEIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6961F30", Offset = "0x6960530", VA = "0x186961F30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6961F80", Offset = "0x6960580", VA = "0x186961F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture OMAGBOFBJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69615C0", Offset = "0x695FBC0", VA = "0x1869615C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86CF20", Offset = "0x86B520", VA = "0x18086CF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private COGGGBKBGAB AFGHNLGIAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x863DD0", Offset = "0x8623D0", VA = "0x180863DD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6961900", Offset = "0x695FF00", VA = "0x186961900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool DDEDOKHOBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x15871E0", Offset = "0x15857E0", VA = "0x1815871E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int DPCFNCNHOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6961A60", Offset = "0x6960060", VA = "0x186961A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69615A0", Offset = "0x695FBA0", VA = "0x1869615A0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6961B00", Offset = "0x6960100", VA = "0x186961B00")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6961880", Offset = "0x695FE80", VA = "0x186961880")]
	private void FPLKIOCDOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6961E50", Offset = "0x6960450", VA = "0x186961E50")]
	public void Set(COGGGBKBGAB NCJHOFOIOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6961E00", Offset = "0x6960400", VA = "0x186961E00")]
	public void Set(Texture ODAFHLABAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6961E10", Offset = "0x6960410", VA = "0x186961E10")]
	public void Set(NDPECDGLKCE CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69615B0", Offset = "0x695FBB0", VA = "0x1869615B0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6961C00", Offset = "0x6960200", VA = "0x186961C00")]
	public void SetInternal(COGGGBKBGAB NCJHOFOIOJK, [Optional] Texture NLAHHGDJCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6961BF0", Offset = "0x69601F0", VA = "0x186961BF0")]
	public void SetCustomSize(int AACJEPAFHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x86DC60", Offset = "0x86C260", VA = "0x18086DC60")]
	public void SetAntiAliasing(int PKKKJMHCOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69614F0", Offset = "0x695FAF0", VA = "0x1869614F0")]
	[AsyncStateMachine(typeof(EKNLPJLMKAB))]
	private void ANCGCJMOFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69617A0", Offset = "0x695FDA0", VA = "0x1869617A0")]
	private void DHEFIDOAEAI(Texture ODAFHLABAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6961EB0", Offset = "0x69604B0", VA = "0x186961EB0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, PCPLAOEPHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float PNLPEHDAAOD = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "4")]
	public void PrepareImposter(MEFAJDDBAOL LIIDINHCICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69614B0", Offset = "0x695FAB0", VA = "0x1869614B0")]
	public void SetReferencePoint(Vector3 DCBNBHMBGKP, Quaternion JAFBJNOBENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69612B0", Offset = "0x695F8B0", VA = "0x1869612B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6961490", Offset = "0x695FA90", VA = "0x186961490")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x15FB410", Offset = "0x15F9A10", VA = "0x1815FB410")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MOFFPPEEFII
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static MOFFPPEEFII PNNPLIEMMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float BJMJCHPDKHL;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x21705B0", Offset = "0x216EBB0", VA = "0x1821705B0")]
	public MOFFPPEEFII(float AABKBHOHMCB)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int CKOLLELJNNI = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int MBLIKMAPCKJ = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> FOJHHNNFNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool CKCNAGMHBLP;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6962190", Offset = "0x6960790", VA = "0x186962190")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6962090", Offset = "0x6960690", VA = "0x186962090")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69623D0", Offset = "0x69609D0", VA = "0x1869623D0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface COGGGBKBGAB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string FOLPMHMJFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MOFFPPEEFII MOFFPPEEFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action POJJEINAIII;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> NGOFLOHIDDO(CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NOGNDBMLADG(COGGGBKBGAB LJAAPFIIPOF);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBKJPEAKLHO();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPLBDGLBOPP();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MBBFEPJBLCB([Out] FMHOFFFMGIN<Texture> AHFNHFAABFH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PIFCAPENLKO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6964B40", Offset = "0x6963140", VA = "0x186964B40")]
	public static bool ICIJHFDEEBD(COGGGBKBGAB LJDKOIDHCOM, COGGGBKBGAB CEIKFEIEDNL)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, PCPLAOEPHBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x695EED0", Offset = "0x695D4D0", VA = "0x18695EED0", Slot = "4")]
		public void PrepareImposter(MEFAJDDBAOL LIIDINHCICD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PCPLAOEPHBA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(MEFAJDDBAOL LIIDINHCICD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NKNIELEAMBF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> CECHJDKMDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> BAIMLACINFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BJLPLEGJHFG
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCIAIHCDGBN(params Type[] KDDDEHNDNIG);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject IGMKDJIJPAD(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, bool KDFPECDOPCB = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T IGMKDJIJPAD<T>(T FIFJHOIIJHB, Transform HHMPHBNGMGF, bool KDFPECDOPCB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T IGMKDJIJPAD<T>(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, bool KDFPECDOPCB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject IGMKDJIJPAD(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, MEFAJDDBAOL LIIDINHCICD, bool KDFPECDOPCB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CCADCHLCMLI : IDisposable, BJLPLEGJHFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> DEBKHFPAAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> LGKJGKFAHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform HOFJIIMNAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> PDINEBFHFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> FKNHPGIBJOO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x695E940", Offset = "0x695CF40", VA = "0x18695E940")]
	[PECFDJPHGEK(BOIKMOKIOJG.None)]
	public static void KOPFFNBBLLA(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x695EA90", Offset = "0x695D090", VA = "0x18695EA90")]
	[Preserve]
	public CCADCHLCMLI([JFHFHOOOEKP(null)] NKNIELEAMBF FIPLBMGCFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x695E630", Offset = "0x695CC30", VA = "0x18695E630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x695EA40", Offset = "0x695D040", VA = "0x18695EA40", Slot = "5")]
	public void LCIAIHCDGBN(params Type[] KDDDEHNDNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x695E7A0", Offset = "0x695CDA0", VA = "0x18695E7A0", Slot = "6")]
	public GameObject IGMKDJIJPAD(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, bool KDFPECDOPCB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2916540", Offset = "0x2914B40", VA = "0x182916540", Slot = "7")]
	public T IGMKDJIJPAD<T>(T FIFJHOIIJHB, Transform HHMPHBNGMGF, bool KDFPECDOPCB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x29165D0", Offset = "0x2914BD0", VA = "0x1829165D0", Slot = "8")]
	public T IGMKDJIJPAD<T>(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, bool KDFPECDOPCB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x695E710", Offset = "0x695CD10", VA = "0x18695E710", Slot = "9")]
	public GameObject IGMKDJIJPAD(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, MEFAJDDBAOL LIIDINHCICD, bool KDFPECDOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2916BA0", Offset = "0x29151A0", VA = "0x182916BA0", Slot = "10")]
	public T IGMKDJIJPAD<T>(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, MEFAJDDBAOL LIIDINHCICD, bool KDFPECDOPCB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2916620", Offset = "0x2914C20", VA = "0x182916620")]
	private T IGMKDJIJPAD<T>(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, MEFAJDDBAOL LIIDINHCICD, bool KDFPECDOPCB, [Out] GameObject FJBHBAHIIFH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x29160A0", Offset = "0x29146A0", VA = "0x1829160A0")]
	private T FHOGHPMNHFF<T>(GameObject INALOLPJOHI, MEFAJDDBAOL LIIDINHCICD, bool KDFPECDOPCB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x695E830", Offset = "0x695CE30", VA = "0x18695E830")]
	private void KDEKMHPPOFP(Component ADPKHCOJMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x695E000", Offset = "0x695C600", VA = "0x18695E000")]
	private void AIHPLLDLGJO(Component ADPKHCOJMDE, MEFAJDDBAOL LIIDINHCICD, bool KDFPECDOPCB, bool PDPONADNBIB, [Optional] Type PEGGGHCICEG, [Optional] Type CPPPAJDLFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x695E4C0", Offset = "0x695CAC0", VA = "0x18695E4C0")]
	private void CABDEODNNPG(GameObject INALOLPJOHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MEFAJDDBAOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> OMOMKDNHCHC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2BF7050", Offset = "0x2BF5650", VA = "0x182BF7050")]
	public MEFAJDDBAOL LHLEJLJODIO<T>(T GAMCLFDCJFG)
	{
		return default(MEFAJDDBAOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6770", Offset = "0x2BF4D70", VA = "0x182BF6770")]
	public T BDJJCDMMBKL<T>(T AJMLHGDNPEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6880", Offset = "0x2BF4E80", VA = "0x182BF6880")]
	public bool KCOKGBINLEI<T>([Out] T GAMCLFDCJFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OJONBPNBKGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool GBGNFECAGJN;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xE3ED70", Offset = "0xE3D370", VA = "0x180E3ED70")]
	public OJONBPNBKGL(bool KHIIJFJHMBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BJKKHMFIMPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool DPHOHEBFHPK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x695DFF0", Offset = "0x695C5F0", VA = "0x18695DFF0")]
	public BJKKHMFIMPL(bool AOCFOFBNFGA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, PCPLAOEPHBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6964C30", Offset = "0x6963230", VA = "0x186964C30", Slot = "4")]
		public void PrepareImposter(MEFAJDDBAOL LIIDINHCICD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds GEKNNENMPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6961120", Offset = "0x695F720", VA = "0x186961120")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69610E0", Offset = "0x695F6E0", VA = "0x1869610E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69610A0", Offset = "0x695F6A0", VA = "0x1869610A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6960FB0", Offset = "0x695F5B0", VA = "0x186960FB0")]
		private void DNBKJLMCCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x6962470", Offset = "0x6960A70", VA = "0x186962470")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6962460", Offset = "0x6960A60", VA = "0x186962460")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6962000", Offset = "0x6960600", VA = "0x186962000")]
		public void DDPNDBLFLOD(Vector3 LLFCCOMMMGN, Quaternion OHCKGAGLKIP, float GLMDPOCOKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6962030", Offset = "0x6960630", VA = "0x186962030")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class ODOHCBOODMK
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 PFJKJFIAFFE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> KDINEGGBIMI;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> JCIGENLLEEO;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera GMDCABOIGBC;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> BLFBHCAOHLO;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> PICONGHHOCC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode PPPICIDOJPH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color BKPFACNMGJN;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color GPLCPFJHCAC;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color ONOJBMNIFAG;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap IFKLOMMNPDE;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool BADIKGPICOB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> HJMDLPBBCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6963320", Offset = "0x6961920", VA = "0x186963320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> KAPILFPIOJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6963370", Offset = "0x6961970", VA = "0x186963370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera MEABIDABCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6964500", Offset = "0x6962B00", VA = "0x186964500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6963B00", Offset = "0x6962100", VA = "0x186963B00")]
	public static void KDBMFFKAOCJ(Vector3 FBEPMJHBMKH, Quaternion JFIHPCOBEKE, ImposterRenderConfig KAEMAIJDAMB, bool LMOMCBJOAPG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6963DA0", Offset = "0x69623A0", VA = "0x186963DA0")]
	private static void KMFPPMJNBKJ(Vector3 FBEPMJHBMKH, Quaternion JFIHPCOBEKE, URPLight BNDIJHMLONB, ImposterRenderConfig.LightConfig FGDLAFKHDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69627C0", Offset = "0x6960DC0", VA = "0x1869627C0")]
	public static void BGNBEFJAMGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69640D0", Offset = "0x69626D0", VA = "0x1869640D0")]
	private static void NKFJAGFGOON(int LJAAOJLCMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6964750", Offset = "0x6962D50", VA = "0x186964750")]
	public static void PKBMDCEDDDG(ImposterRenderConfig KAEMAIJDAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69633C0", Offset = "0x69619C0", VA = "0x1869633C0")]
	public static void INNLHCDEBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6962FE0", Offset = "0x69615E0", VA = "0x186962FE0")]
	public static void EOCPGOFLBGJ(GameObject ENGJDLPBGPM, RenderTexture PNMGAIOOBPI, ImposterRenderConfig KAEMAIJDAMB, MOFFPPEEFII NFCCBNNMEBK, [Optional] Vector3? PJEEEJEOCBM, [Optional] Vector3? LAONDPDOHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69634B0", Offset = "0x6961AB0", VA = "0x1869634B0")]
	private static void JAKCPFECAHI(GameObject ENGJDLPBGPM, RenderTexture PNMGAIOOBPI, ImposterRenderConfig KAEMAIJDAMB, MOFFPPEEFII NFCCBNNMEBK, Vector3 PJEEEJEOCBM, Vector3 LAONDPDOHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69624D0", Offset = "0x6960AD0", VA = "0x1869624D0")]
	private static void AAIDLJIFGMP(GameObject ENGJDLPBGPM, Vector3 KPOFJDIKJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6962970", Offset = "0x6960F70", VA = "0x186962970")]
	private static void ELNKMDNAMGI(GameObject FIFJHOIIJHB, ImposterRenderConfig KAEMAIJDAMB, MOFFPPEEFII NFCCBNNMEBK, [Out] Vector3 IPPJKJIHGKF, [Out] Quaternion LKDBHMBBEJB, [Out] float BOHBMBKJKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69628A0", Offset = "0x6960EA0", VA = "0x1869628A0")]
	public static RenderTexture EDIFLKMABHB(int LLKEJNDKCDC, int HIHOMDFABKJ, RenderTextureFormat JFOBPJMAIKI = RenderTextureFormat.ARGB32, string OLOCJJENIFC = "[ImposterRendering]Preview")
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public struct FICACGPGAPF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public NIIIJMDBGHD MNJFGJFFNIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject FINAGNHPFIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture OMAGBOFBJGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig EPHLONIKEHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public MOFFPPEEFII MOFFPPEEFII;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6960BA0", Offset = "0x695F1A0", VA = "0x186960BA0")]
			public FICACGPGAPF(NIIIJMDBGHD JKOLNABNIDN, GameObject MKAOGJBGEKK, RenderTexture PNMGAIOOBPI, ImposterRenderConfig BLHGLOOHGPA, MOFFPPEEFII NFCCBNNMEBK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static OEGIOJIPBCE<FICACGPGAPF, RenderTexture> KGLFOLLGNOJ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<FICACGPGAPF> LODBCDLBLPC;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int OKAKJJCBGMH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x695F8B0", Offset = "0x695DEB0", VA = "0x18695F8B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x695F920", Offset = "0x695DF20", VA = "0x18695F920")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject ENGJDLPBGPM, RenderTexture PNMGAIOOBPI, ImposterRenderConfig KAEMAIJDAMB, MOFFPPEEFII NFCCBNNMEBK, CancellationToken DADBOHKBJNO, bool DDMEMLHPFLK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x695F430", Offset = "0x695DA30", VA = "0x18695F430", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x695F810", Offset = "0x695DE10", VA = "0x18695F810", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x695F620", Offset = "0x695DC20", VA = "0x18695F620")]
		private static Task<RenderTexture> GBGIMCACDHC(FICACGPGAPF KPFMOKBFKCE, CancellationToken DADBOHKBJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x695FD40", Offset = "0x695E340", VA = "0x18695FD40")]
		public DeferredImposterRenderer()
		{
		}
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
