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
		[Cpp2IlInjected.Address(RVA = "0xAB8760", Offset = "0xAB7760", VA = "0x180AB8760")]
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
		[Cpp2IlInjected.Address(RVA = "0x6991F80", Offset = "0x6990F80", VA = "0x186991F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6992320", Offset = "0x6991320", VA = "0x186992320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x867DF0", Offset = "0x866DF0", VA = "0x180867DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OEGIOJIPBCE<CGIJKHLEMAM, GameObject> EOBJJFOPNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6992DF0", Offset = "0x6991DF0", VA = "0x186992DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int HIKKBMDDEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6992CE0", Offset = "0x6991CE0", VA = "0x186992CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6992D30", Offset = "0x6991D30", VA = "0x186992D30", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6993130", Offset = "0x6992130", VA = "0x186993130", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69931A0", Offset = "0x69921A0", VA = "0x1869931A0")]
	[AsyncStateMachine(typeof(DAKGPENPLAD))]
	private Task<GameObject> PNLIHPPGKBG(CGIJKHLEMAM ONKJHIMLJAC, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6992F50", Offset = "0x6991F50", VA = "0x186992F50")]
	public Task<GameObject> LoadItemAsync(COGGGBKBGAB MOHJGJMENOK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69932C0", Offset = "0x69922C0", VA = "0x1869932C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86A7E0", Offset = "0x8697E0", VA = "0x18086A7E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x69906D0", Offset = "0x698F6D0", VA = "0x1869906D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6990EE0", Offset = "0x698FEE0", VA = "0x186990EE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6993CF0", Offset = "0x6992CF0", VA = "0x186993CF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> ADMBNEIFAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x86FF30", Offset = "0x86EF30", VA = "0x18086FF30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6993D50", Offset = "0x6992D50", VA = "0x186993D50")]
		public GBPAGLFFJEC(COGGGBKBGAB BNMOBGFDFNK, RenderTexture PNMGAIOOBPI, ImposterRenderConfig BLHGLOOHGPA, CancellationToken DADBOHKBJNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6993B70", Offset = "0x6992B70", VA = "0x186993B70")]
		[AsyncStateMachine(typeof(AKLOLOGGOIA))]
		private Task<Texture> DMEKLBBHDMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6993CE0", Offset = "0x6992CE0", VA = "0x186993CE0", Slot = "10")]
		protected override void LFGLBHDCMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6993C60", Offset = "0x6992C60", VA = "0x186993C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x6993300", Offset = "0x6992300", VA = "0x186993300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6994E90", Offset = "0x6993E90", VA = "0x186994E90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6994EE0", Offset = "0x6993EE0", VA = "0x186994EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture OMAGBOFBJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6994520", Offset = "0x6993520", VA = "0x186994520")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86FF20", Offset = "0x86EF20", VA = "0x18086FF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private COGGGBKBGAB AFGHNLGIAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x866DD0", Offset = "0x865DD0", VA = "0x180866DD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6994860", Offset = "0x6993860", VA = "0x186994860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool DDEDOKHOBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x158F080", Offset = "0x158E080", VA = "0x18158F080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int DPCFNCNHOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69949C0", Offset = "0x69939C0", VA = "0x1869949C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6994500", Offset = "0x6993500", VA = "0x186994500")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6994A60", Offset = "0x6993A60", VA = "0x186994A60")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69947E0", Offset = "0x69937E0", VA = "0x1869947E0")]
	private void FPLKIOCDOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6994DB0", Offset = "0x6993DB0", VA = "0x186994DB0")]
	public void Set(COGGGBKBGAB NCJHOFOIOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6994D60", Offset = "0x6993D60", VA = "0x186994D60")]
	public void Set(Texture ODAFHLABAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6994D70", Offset = "0x6993D70", VA = "0x186994D70")]
	public void Set(NDPECDGLKCE CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6994510", Offset = "0x6993510", VA = "0x186994510")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6994B60", Offset = "0x6993B60", VA = "0x186994B60")]
	public void SetInternal(COGGGBKBGAB NCJHOFOIOJK, [Optional] Texture NLAHHGDJCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6994B50", Offset = "0x6993B50", VA = "0x186994B50")]
	public void SetCustomSize(int AACJEPAFHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x870C60", Offset = "0x86FC60", VA = "0x180870C60")]
	public void SetAntiAliasing(int PKKKJMHCOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6994450", Offset = "0x6993450", VA = "0x186994450")]
	[AsyncStateMachine(typeof(EKNLPJLMKAB))]
	private void ANCGCJMOFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6994700", Offset = "0x6993700", VA = "0x186994700")]
	private void DHEFIDOAEAI(Texture ODAFHLABAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6994E10", Offset = "0x6993E10", VA = "0x186994E10")]
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
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "4")]
	public void PrepareImposter(MEFAJDDBAOL LIIDINHCICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6994410", Offset = "0x6993410", VA = "0x186994410")]
	public void SetReferencePoint(Vector3 DCBNBHMBGKP, Quaternion JAFBJNOBENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6994210", Offset = "0x6993210", VA = "0x186994210")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69943F0", Offset = "0x69933F0", VA = "0x1869943F0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1603760", Offset = "0x1602760", VA = "0x181603760")]
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
	[Cpp2IlInjected.Address(RVA = "0x217F0E0", Offset = "0x217E0E0", VA = "0x18217F0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69950F0", Offset = "0x69940F0", VA = "0x1869950F0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6994FF0", Offset = "0x6993FF0", VA = "0x186994FF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6995330", Offset = "0x6994330", VA = "0x186995330")]
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
	[Cpp2IlInjected.Address(RVA = "0x6997AA0", Offset = "0x6996AA0", VA = "0x186997AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6991E30", Offset = "0x6990E30", VA = "0x186991E30", Slot = "4")]
		public void PrepareImposter(MEFAJDDBAOL LIIDINHCICD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x866340", Offset = "0x865340", VA = "0x180866340")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x866340", Offset = "0x865340", VA = "0x180866340")]
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
	[Cpp2IlInjected.Address(RVA = "0x69918A0", Offset = "0x69908A0", VA = "0x1869918A0")]
	[PECFDJPHGEK(BOIKMOKIOJG.None)]
	public static void KOPFFNBBLLA(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69919F0", Offset = "0x69909F0", VA = "0x1869919F0")]
	[Preserve]
	public CCADCHLCMLI([JFHFHOOOEKP(null)] NKNIELEAMBF FIPLBMGCFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6991590", Offset = "0x6990590", VA = "0x186991590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69919A0", Offset = "0x69909A0", VA = "0x1869919A0", Slot = "5")]
	public void LCIAIHCDGBN(params Type[] KDDDEHNDNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6991700", Offset = "0x6990700", VA = "0x186991700", Slot = "6")]
	public GameObject IGMKDJIJPAD(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, bool KDFPECDOPCB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2926E40", Offset = "0x2925E40", VA = "0x182926E40", Slot = "7")]
	public T IGMKDJIJPAD<T>(T FIFJHOIIJHB, Transform HHMPHBNGMGF, bool KDFPECDOPCB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2926ED0", Offset = "0x2925ED0", VA = "0x182926ED0", Slot = "8")]
	public T IGMKDJIJPAD<T>(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, bool KDFPECDOPCB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6991670", Offset = "0x6990670", VA = "0x186991670", Slot = "9")]
	public GameObject IGMKDJIJPAD(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, MEFAJDDBAOL LIIDINHCICD, bool KDFPECDOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29274A0", Offset = "0x29264A0", VA = "0x1829274A0", Slot = "10")]
	public T IGMKDJIJPAD<T>(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, MEFAJDDBAOL LIIDINHCICD, bool KDFPECDOPCB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2926F20", Offset = "0x2925F20", VA = "0x182926F20")]
	private T IGMKDJIJPAD<T>(GameObject FIFJHOIIJHB, Transform HHMPHBNGMGF, MEFAJDDBAOL LIIDINHCICD, bool KDFPECDOPCB, [Out] GameObject FJBHBAHIIFH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x29269A0", Offset = "0x29259A0", VA = "0x1829269A0")]
	private T FHOGHPMNHFF<T>(GameObject INALOLPJOHI, MEFAJDDBAOL LIIDINHCICD, bool KDFPECDOPCB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6991790", Offset = "0x6990790", VA = "0x186991790")]
	private void KDEKMHPPOFP(Component ADPKHCOJMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6990F60", Offset = "0x698FF60", VA = "0x186990F60")]
	private void AIHPLLDLGJO(Component ADPKHCOJMDE, MEFAJDDBAOL LIIDINHCICD, bool KDFPECDOPCB, bool PDPONADNBIB, [Optional] Type PEGGGHCICEG, [Optional] Type CPPPAJDLFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6991420", Offset = "0x6990420", VA = "0x186991420")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C0F890", Offset = "0x2C0E890", VA = "0x182C0F890")]
	public MEFAJDDBAOL LHLEJLJODIO<T>(T GAMCLFDCJFG)
	{
		return default(MEFAJDDBAOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2C0EFB0", Offset = "0x2C0DFB0", VA = "0x182C0EFB0")]
	public T BDJJCDMMBKL<T>(T AJMLHGDNPEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2C0F0C0", Offset = "0x2C0E0C0", VA = "0x182C0F0C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x217F560", Offset = "0x217E560", VA = "0x18217F560")]
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
	[Cpp2IlInjected.Address(RVA = "0x6990F50", Offset = "0x698FF50", VA = "0x186990F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x866340", Offset = "0x865340", VA = "0x180866340")]
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
		[Cpp2IlInjected.Address(RVA = "0x6997B90", Offset = "0x6996B90", VA = "0x186997B90", Slot = "4")]
		public void PrepareImposter(MEFAJDDBAOL LIIDINHCICD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x866340", Offset = "0x865340", VA = "0x180866340")]
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
			[Cpp2IlInjected.Address(RVA = "0x6994080", Offset = "0x6993080", VA = "0x186994080")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6994040", Offset = "0x6993040", VA = "0x186994040")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6994000", Offset = "0x6993000", VA = "0x186994000")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6993F10", Offset = "0x6992F10", VA = "0x186993F10")]
		private void DNBKJLMCCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x866340", Offset = "0x865340", VA = "0x180866340")]
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
				[Cpp2IlInjected.Address(RVA = "0x69953D0", Offset = "0x69943D0", VA = "0x1869953D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x69953C0", Offset = "0x69943C0", VA = "0x1869953C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6994F60", Offset = "0x6993F60", VA = "0x186994F60")]
		public void DDPNDBLFLOD(Vector3 LLFCCOMMMGN, Quaternion OHCKGAGLKIP, float GLMDPOCOKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6994F90", Offset = "0x6993F90", VA = "0x186994F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6996280", Offset = "0x6995280", VA = "0x186996280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> KAPILFPIOJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69962D0", Offset = "0x69952D0", VA = "0x1869962D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera MEABIDABCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6997460", Offset = "0x6996460", VA = "0x186997460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6996A60", Offset = "0x6995A60", VA = "0x186996A60")]
	public static void KDBMFFKAOCJ(Vector3 FBEPMJHBMKH, Quaternion JFIHPCOBEKE, ImposterRenderConfig KAEMAIJDAMB, bool LMOMCBJOAPG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6996D00", Offset = "0x6995D00", VA = "0x186996D00")]
	private static void KMFPPMJNBKJ(Vector3 FBEPMJHBMKH, Quaternion JFIHPCOBEKE, URPLight BNDIJHMLONB, ImposterRenderConfig.LightConfig FGDLAFKHDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6995720", Offset = "0x6994720", VA = "0x186995720")]
	public static void BGNBEFJAMGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6997030", Offset = "0x6996030", VA = "0x186997030")]
	private static void NKFJAGFGOON(int LJAAOJLCMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x69976B0", Offset = "0x69966B0", VA = "0x1869976B0")]
	public static void PKBMDCEDDDG(ImposterRenderConfig KAEMAIJDAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6996320", Offset = "0x6995320", VA = "0x186996320")]
	public static void INNLHCDEBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6995F40", Offset = "0x6994F40", VA = "0x186995F40")]
	public static void EOCPGOFLBGJ(GameObject ENGJDLPBGPM, RenderTexture PNMGAIOOBPI, ImposterRenderConfig KAEMAIJDAMB, MOFFPPEEFII NFCCBNNMEBK, [Optional] Vector3? PJEEEJEOCBM, [Optional] Vector3? LAONDPDOHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6996410", Offset = "0x6995410", VA = "0x186996410")]
	private static void JAKCPFECAHI(GameObject ENGJDLPBGPM, RenderTexture PNMGAIOOBPI, ImposterRenderConfig KAEMAIJDAMB, MOFFPPEEFII NFCCBNNMEBK, Vector3 PJEEEJEOCBM, Vector3 LAONDPDOHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6995430", Offset = "0x6994430", VA = "0x186995430")]
	private static void AAIDLJIFGMP(GameObject ENGJDLPBGPM, Vector3 KPOFJDIKJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69958D0", Offset = "0x69948D0", VA = "0x1869958D0")]
	private static void ELNKMDNAMGI(GameObject FIFJHOIIJHB, ImposterRenderConfig KAEMAIJDAMB, MOFFPPEEFII NFCCBNNMEBK, [Out] Vector3 IPPJKJIHGKF, [Out] Quaternion LKDBHMBBEJB, [Out] float BOHBMBKJKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6995800", Offset = "0x6994800", VA = "0x186995800")]
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
			[Cpp2IlInjected.Address(RVA = "0x6993B00", Offset = "0x6992B00", VA = "0x186993B00")]
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
			[Cpp2IlInjected.Address(RVA = "0x6992810", Offset = "0x6991810", VA = "0x186992810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6992880", Offset = "0x6991880", VA = "0x186992880")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject ENGJDLPBGPM, RenderTexture PNMGAIOOBPI, ImposterRenderConfig KAEMAIJDAMB, MOFFPPEEFII NFCCBNNMEBK, CancellationToken DADBOHKBJNO, bool DDMEMLHPFLK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6992390", Offset = "0x6991390", VA = "0x186992390", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6992770", Offset = "0x6991770", VA = "0x186992770", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6992580", Offset = "0x6991580", VA = "0x186992580")]
		private static Task<RenderTexture> GBGIMCACDHC(FICACGPGAPF KPFMOKBFKCE, CancellationToken DADBOHKBJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6992CA0", Offset = "0x6991CA0", VA = "0x186992CA0")]
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
