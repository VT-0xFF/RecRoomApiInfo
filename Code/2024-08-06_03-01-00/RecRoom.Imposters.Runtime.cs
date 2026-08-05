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
	private readonly struct NEDHFJDDGPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BGGLHJJFFGI KDHMMFKBEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string MOCPHNBJHGP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
		public NEDHFJDDGPE(BGGLHJJFFGI GLBGCIIDEMH, string HDMJEHFFBMG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct JDFCICMILDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NEDHFJDDGPE queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69D15F0", Offset = "0x69CFBF0", VA = "0x1869D15F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69D1990", Offset = "0x69CFF90", VA = "0x1869D1990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider DPBAHMDDLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FKNKKEIANCA<NEDHFJDDGPE, GameObject> HGDNGJPNHAK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EGFNIPDGFPF BBJEPJKDGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x85F4B0", Offset = "0x85DAB0", VA = "0x18085F4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FKNKKEIANCA<NEDHFJDDGPE, GameObject> DBLBLDPLJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69CFBB0", Offset = "0x69CE1B0", VA = "0x1869CFBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int NJKJMJLHEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69CFD10", Offset = "0x69CE310", VA = "0x1869CFD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69CFAF0", Offset = "0x69CE0F0", VA = "0x1869CFAF0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69D0050", Offset = "0x69CE650", VA = "0x1869D0050", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69CFD60", Offset = "0x69CE360", VA = "0x1869CFD60")]
	[AsyncStateMachine(typeof(JDFCICMILDF))]
	private Task<GameObject> LLDCEEKJOPH(NEDHFJDDGPE NDEMPNECIMP, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69CFE80", Offset = "0x69CE480", VA = "0x1869CFE80")]
	public Task<GameObject> LoadItemAsync(BGGLHJJFFGI GLBGCIIDEMH, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69D00C0", Offset = "0x69CE6C0", VA = "0x1869D00C0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class KNLFFPMGLDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BGGLHJJFFGI HOPMFAKKBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture NAFAPEGFHBJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86D260", Offset = "0x86B860", VA = "0x18086D260")]
		public KNLFFPMGLDH(BGGLHJJFFGI KCMAAPHOODE, Texture HMBKEPDDPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum NAOKJOJHJEH
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
	private class JDKINAAPBFM : LNCPEPHDNEM<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct BHKNGNLAIGO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public JDKINAAPBFM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x69CE810", Offset = "0x69CCE10", VA = "0x1869CE810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x69CF010", Offset = "0x69CD610", VA = "0x1869CF010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly BGGLHJJFFGI KCMAAPHOODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture AANJJFFGOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig BLLJCOBGAKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken NNGMAHIDECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject DHIGCFNCHKD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override DNKNPFLFPMI<Texture> GGOHKAHNAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x69D1B70", Offset = "0x69D0170", VA = "0x1869D1B70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> AFLJMNBJEMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69D1BE0", Offset = "0x69D01E0", VA = "0x1869D1BE0")]
		public JDKINAAPBFM(BGGLHJJFFGI KCMAAPHOODE, RenderTexture AANJJFFGOEK, ImposterRenderConfig BLLJCOBGAKL, CancellationToken NNGMAHIDECE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69D1A80", Offset = "0x69D0080", VA = "0x1869D1A80")]
		[AsyncStateMachine(typeof(BHKNGNLAIGO))]
		private Task<Texture> CMOHKEMBCNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69D1BD0", Offset = "0x69D01D0", VA = "0x1869D1BD0", Slot = "10")]
		protected override void HBFHKMBGDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69D1A00", Offset = "0x69D0000", VA = "0x1869D1A00")]
		private static void BCIOHCKCMHG(GameObject DHIGCFNCHKD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LOFLDMDNHBA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69D2C90", Offset = "0x69D1290", VA = "0x1869D2C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
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
	[FOAPFLEFDGH(NABHOIFJJJN.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private NAOKJOJHJEH size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[GHDFNKHJILJ("size", NAOKJOJHJEH.Custom)]
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
	private static int HFDAEMEDKCM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture NMGLICALOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private JLECCIBAKJB<GameObject> EKOEFPIGOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private JIMPAEGGIFL GPCIGBBMAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource NIGBFOEDEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private JPDJGJBEGGO<Texture> NMABLCHOMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private BGGLHJJFFGI CGLBFGPCPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture BFLACIKFHKG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int DLHEABHFACN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69D10D0", Offset = "0x69CF6D0", VA = "0x1869D10D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69D1120", Offset = "0x69CF720", VA = "0x1869D1120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture PCEEELCHCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69D0750", Offset = "0x69CED50", VA = "0x1869D0750")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8632D0", Offset = "0x8618D0", VA = "0x1808632D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BGGLHJJFFGI HOPMFAKKBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x865680", Offset = "0x863C80", VA = "0x180865680")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69D0930", Offset = "0x69CEF30", VA = "0x1869D0930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool KLCDCNPBLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x166ABF0", Offset = "0x16691F0", VA = "0x18166ABF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int IMCJAHOEPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69D0B40", Offset = "0x69CF140", VA = "0x1869D0B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69D06B0", Offset = "0x69CECB0", VA = "0x1869D06B0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69D0CB0", Offset = "0x69CF2B0", VA = "0x1869D0CB0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69D06D0", Offset = "0x69CECD0", VA = "0x1869D06D0")]
	private void JFAGBCFNDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69D0FF0", Offset = "0x69CF5F0", VA = "0x1869D0FF0")]
	public void Set(BGGLHJJFFGI CDCGKEDHHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69D0FA0", Offset = "0x69CF5A0", VA = "0x1869D0FA0")]
	public void Set(Texture HMBKEPDDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69D0FB0", Offset = "0x69CF5B0", VA = "0x1869D0FB0")]
	public void Set(KNLFFPMGLDH FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69D06C0", Offset = "0x69CECC0", VA = "0x1869D06C0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69D0DB0", Offset = "0x69CF3B0", VA = "0x1869D0DB0")]
	public void SetInternal(BGGLHJJFFGI CDCGKEDHHPA, [Optional] Texture NOMBPIPIAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69D0DA0", Offset = "0x69CF3A0", VA = "0x1869D0DA0")]
	public void SetCustomSize(int IBOOEGAKEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8632F0", Offset = "0x8618F0", VA = "0x1808632F0")]
	public void SetAntiAliasing(int IBDENPMCDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69D0A90", Offset = "0x69CF090", VA = "0x1869D0A90")]
	[AsyncStateMachine(typeof(LOFLDMDNHBA))]
	private void LKIPDPOLIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69D0BD0", Offset = "0x69CF1D0", VA = "0x1869D0BD0")]
	private void OPOMJJNIOOM(Texture HMBKEPDDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69D1050", Offset = "0x69CF650", VA = "0x1869D1050")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, BIAPNOOAEEL
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float CCNJKDKFPGB = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
	public void PrepareImposter(PFAGJBAMMNJ MBKNFOKFHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69D0670", Offset = "0x69CEC70", VA = "0x1869D0670")]
	public void SetReferencePoint(Vector3 JICIEEKFCFC, Quaternion GNOMFELINLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69D0480", Offset = "0x69CEA80", VA = "0x1869D0480")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69D0650", Offset = "0x69CEC50", VA = "0x1869D0650")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x16DE050", Offset = "0x16DC650", VA = "0x1816DE050")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JNMODMEEIOO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static JNMODMEEIOO OLBAOGFAKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float PFJEBMGIODF;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x21A1D30", Offset = "0x21A0330", VA = "0x1821A1D30")]
	public JNMODMEEIOO(float LLIDODNPKOH)
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
		[FOAPFLEFDGH(NABHOIFJJJN.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int JKGOPIIMJEI = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int AKDACADAMNL = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> NLJFLIKLHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool FJFKDEJNNPM;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69D1320", Offset = "0x69CF920", VA = "0x1869D1320")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69D1220", Offset = "0x69CF820", VA = "0x1869D1220")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69D1560", Offset = "0x69CFB60", VA = "0x1869D1560")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BGGLHJJFFGI
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string MDHHBIKGNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JNMODMEEIOO JNMODMEEIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DNFPELJBJDL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> LHLOMLFAFEF(CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BAHFPHMOOCA(BGGLHJJFFGI OGEIJLCLBIC);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HGJLGOLMGGG();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMOGLBOLGAK();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CLDMNPFCBDE([Out] JPDJGJBEGGO<Texture> DJHACJMDCAN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OEECFCJHEOH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69D5A20", Offset = "0x69D4020", VA = "0x1869D5A20")]
	public static bool PAMJEEFHCHL(BGGLHJJFFGI FLCGJIAHEJI, BGGLHJJFFGI JPGKOKLENPO)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, BIAPNOOAEEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x69CF080", Offset = "0x69CD680", VA = "0x1869CF080", Slot = "4")]
		public void PrepareImposter(PFAGJBAMMNJ MBKNFOKFHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BIAPNOOAEEL
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(PFAGJBAMMNJ MBKNFOKFHJD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CBEKOFODFIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> CBGDNMHKFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> IAFPFDAIMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EGFNIPDGFPF
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPJABHKOHLL(params Type[] NPALJOOCNBD);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject JBDEHOAMMBJ(GameObject OIGGDKAEPKI, Transform LPFOFJIMHOE, bool FFGLIODLEGB = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T JBDEHOAMMBJ<T>(T OIGGDKAEPKI, Transform LPFOFJIMHOE, bool FFGLIODLEGB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JBDEHOAMMBJ<T>(GameObject OIGGDKAEPKI, Transform LPFOFJIMHOE, bool FFGLIODLEGB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject JBDEHOAMMBJ(GameObject OIGGDKAEPKI, Transform LPFOFJIMHOE, PFAGJBAMMNJ MBKNFOKFHJD, bool FFGLIODLEGB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LBIHHKKHPHJ : IDisposable, EGFNIPDGFPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> MOIBEDADDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> HPEHHDGDADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform GHFMDJCDOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> DLBDKHFIHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> LBLLHPLNNDL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69D1EC0", Offset = "0x69D04C0", VA = "0x1869D1EC0")]
	[CCEDJDOPMOE(CFIDNIINJOK.None)]
	public static void EPFABJKOPAP(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69D2850", Offset = "0x69D0E50", VA = "0x1869D2850")]
	[Preserve]
	public LBIHHKKHPHJ([JLPFJOFFNLM(null)] CBEKOFODFIG DHKILKEKJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69D1DE0", Offset = "0x69D03E0", VA = "0x1869D1DE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69D20C0", Offset = "0x69D06C0", VA = "0x1869D20C0", Slot = "5")]
	public void IPJABHKOHLL(params Type[] NPALJOOCNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x69D2110", Offset = "0x69D0710", VA = "0x1869D2110", Slot = "6")]
	public GameObject JBDEHOAMMBJ(GameObject OIGGDKAEPKI, Transform LPFOFJIMHOE, bool FFGLIODLEGB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2C0F9A0", Offset = "0x2C0DFA0", VA = "0x182C0F9A0", Slot = "7")]
	public T JBDEHOAMMBJ<T>(T OIGGDKAEPKI, Transform LPFOFJIMHOE, bool FFGLIODLEGB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2C0FFB0", Offset = "0x2C0E5B0", VA = "0x182C0FFB0", Slot = "8")]
	public T JBDEHOAMMBJ<T>(GameObject OIGGDKAEPKI, Transform LPFOFJIMHOE, bool FFGLIODLEGB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69D21A0", Offset = "0x69D07A0", VA = "0x1869D21A0", Slot = "9")]
	public GameObject JBDEHOAMMBJ(GameObject OIGGDKAEPKI, Transform LPFOFJIMHOE, PFAGJBAMMNJ MBKNFOKFHJD, bool FFGLIODLEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2C10000", Offset = "0x2C0E600", VA = "0x182C10000", Slot = "10")]
	public T JBDEHOAMMBJ<T>(GameObject OIGGDKAEPKI, Transform LPFOFJIMHOE, PFAGJBAMMNJ MBKNFOKFHJD, bool FFGLIODLEGB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2C0FA30", Offset = "0x2C0E030", VA = "0x182C0FA30")]
	private T JBDEHOAMMBJ<T>(GameObject OIGGDKAEPKI, Transform LPFOFJIMHOE, PFAGJBAMMNJ MBKNFOKFHJD, bool FFGLIODLEGB, [Out] GameObject IDDNINAPHAD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2C10060", Offset = "0x2C0E660", VA = "0x182C10060")]
	private T NNJNAFEKJMB<T>(GameObject BBKKNFIIKNJ, PFAGJBAMMNJ MBKNFOKFHJD, bool FFGLIODLEGB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69D1FB0", Offset = "0x69D05B0", VA = "0x1869D1FB0")]
	private void GGKNBAODMFL(Component NNFKLCEBDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69D23A0", Offset = "0x69D09A0", VA = "0x1869D23A0")]
	private void KOLFNLDLNDF(Component NNFKLCEBDGC, PFAGJBAMMNJ MBKNFOKFHJD, bool FFGLIODLEGB, bool JJOPFOINCPL, [Optional] Type HMJODGFIIOH, [Optional] Type BOOLEAPLFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69D2230", Offset = "0x69D0830", VA = "0x1869D2230")]
	private void JHPAEFIJAMM(GameObject BBKKNFIIKNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct PFAGJBAMMNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> AMONMOMLNEN;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B720", Offset = "0x2D09D20", VA = "0x182D0B720")]
	public PFAGJBAMMNJ FNIGGHLNDBN<T>(T FOCCCCKPJEN)
	{
		return default(PFAGJBAMMNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2D0AE40", Offset = "0x2D09440", VA = "0x182D0AE40")]
	public T BJJBEHDKBAF<T>(T PBAONJMDGEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2D0AF50", Offset = "0x2D09550", VA = "0x182D0AF50")]
	public bool CBPJGMGJFOI<T>([Out] T FOCCCCKPJEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KIHEPHIMHKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool CKBBJIIBBGF;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x21A1BB0", Offset = "0x21A01B0", VA = "0x1821A1BB0")]
	public KIHEPHIMHKI(bool IKKOHHKLJGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HMDJNJAMAEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool ILINLBOGPLH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69D0170", Offset = "0x69CE770", VA = "0x1869D0170")]
	public HMDJNJAMAEJ(bool GEHLDCBAHHO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, BIAPNOOAEEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69D5B00", Offset = "0x69D4100", VA = "0x1869D5B00", Slot = "4")]
		public void PrepareImposter(PFAGJBAMMNJ MBKNFOKFHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
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
		public Bounds CABEHKLBNEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x69D02F0", Offset = "0x69CE8F0", VA = "0x1869D02F0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69D02B0", Offset = "0x69CE8B0", VA = "0x1869D02B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69D0270", Offset = "0x69CE870", VA = "0x1869D0270")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69D0180", Offset = "0x69CE780", VA = "0x1869D0180")]
		private void JCAAOIPOOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x69D34A0", Offset = "0x69D1AA0", VA = "0x1869D34A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x69D3490", Offset = "0x69D1A90", VA = "0x1869D3490")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D1190", Offset = "0x69CF790", VA = "0x1869D1190")]
		public void BFDOOABNPAL(Vector3 NMCHPCFLAPJ, Quaternion CJCMMPOFHDE, float MGKPFNCLJIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69D11C0", Offset = "0x69CF7C0", VA = "0x1869D11C0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class NOJMJFEPGHK
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 NMNHMBIILNI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> NJGCPMECLNG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> AMHKBNPCGHG;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera FMFDLIDLAIK;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> LKKKANNOKOL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> NKKKPFNIGHG;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode OGFPJLJKGAJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color IPFBKKFEJHF;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color HPGFHFLHJHE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color CKHDAJGKALM;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap CJDLAMJEEHO;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool INKGGLNMHFO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> JIPAIIHDGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69D36F0", Offset = "0x69D1CF0", VA = "0x1869D36F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> BIDBEDIILGA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69D56F0", Offset = "0x69D3CF0", VA = "0x1869D56F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera INAFOMLMPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69D34C0", Offset = "0x69D1AC0", VA = "0x1869D34C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69D4960", Offset = "0x69D2F60", VA = "0x1869D4960")]
	public static void JEOMGOFHIAM(Vector3 LFDLFMDFKJB, Quaternion KHEOPMIBCNJ, ImposterRenderConfig DOLNGIKEPFO, bool FDIKIGHDJBK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69D53D0", Offset = "0x69D39D0", VA = "0x1869D53D0")]
	private static void KFILMEMKGDL(Vector3 LFDLFMDFKJB, Quaternion KHEOPMIBCNJ, URPLight AJHGNGKHOFM, ImposterRenderConfig.LightConfig GGICEBOBPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69D41B0", Offset = "0x69D27B0", VA = "0x1869D41B0")]
	public static void FPKMGLDOIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69D4550", Offset = "0x69D2B50", VA = "0x1869D4550")]
	private static void INIPOFMPCMJ(int HPJLPDDFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x69D4BF0", Offset = "0x69D31F0", VA = "0x1869D4BF0")]
	public static void JMGBFKCOKIO(ImposterRenderConfig DOLNGIKEPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69D40D0", Offset = "0x69D26D0", VA = "0x1869D40D0")]
	public static void FMPNMMEJMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69D3D90", Offset = "0x69D2390", VA = "0x1869D3D90")]
	public static void EMLDGHELCDH(GameObject PNIKNPKKEBE, RenderTexture AANJJFFGOEK, ImposterRenderConfig DOLNGIKEPFO, JNMODMEEIOO IHCMNBBALFK, [Optional] Vector3? KBAMKCOAHIO, [Optional] Vector3? HEOGNBANLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69D4DA0", Offset = "0x69D33A0", VA = "0x1869D4DA0")]
	private static void KBPHAIHLCMA(GameObject PNIKNPKKEBE, RenderTexture AANJJFFGOEK, ImposterRenderConfig DOLNGIKEPFO, JNMODMEEIOO IHCMNBBALFK, Vector3 KBAMKCOAHIO, Vector3 HEOGNBANLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69D4290", Offset = "0x69D2890", VA = "0x1869D4290")]
	private static void GBDFMHIAINC(GameObject PNIKNPKKEBE, Vector3 IHNGEFNGBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69D3740", Offset = "0x69D1D40", VA = "0x1869D3740")]
	private static void EGIFHHMPAEN(GameObject OIGGDKAEPKI, ImposterRenderConfig DOLNGIKEPFO, JNMODMEEIOO IHCMNBBALFK, [Out] Vector3 CBFFKDICIJO, [Out] Quaternion EIECCMIJICD, [Out] float FOBCNOOKNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69D5740", Offset = "0x69D3D40", VA = "0x1869D5740")]
	public static RenderTexture PDJINENOGMP(int ALOKOPGHBLC, int FJCHAPINKHL, RenderTextureFormat GCFIDHFGDMF = RenderTextureFormat.ARGB32, string MPCJNFNPFHI = "[ImposterRendering]Preview")
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
		public struct FDINLFFFJDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public FILOAGJMCDA NKLIHJKEFFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject PGJPMCBDBCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture PCEEELCHCFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig CIHPMCJDNAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public JNMODMEEIOO JNMODMEEIOO;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x69D0100", Offset = "0x69CE700", VA = "0x1869D0100")]
			public FDINLFFFJDA(FILOAGJMCDA PNHJHEEKKBI, GameObject CGOMFALNKCF, RenderTexture AANJJFFGOEK, ImposterRenderConfig BLLJCOBGAKL, JNMODMEEIOO IHCMNBBALFK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static FKNKKEIANCA<FDINLFFFJDA, RenderTexture> NAOOBNFGAOO;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<FDINLFFFJDA> DEEGPKGGLLP;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int HLJAIDMGGII
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x69CF5B0", Offset = "0x69CDBB0", VA = "0x1869CF5B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69CF6B0", Offset = "0x69CDCB0", VA = "0x1869CF6B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject PNIKNPKKEBE, RenderTexture AANJJFFGOEK, ImposterRenderConfig DOLNGIKEPFO, JNMODMEEIOO IHCMNBBALFK, CancellationToken NNGMAHIDECE, bool GMAKLCIPIPA = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69CF1D0", Offset = "0x69CD7D0", VA = "0x1869CF1D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69CF620", Offset = "0x69CDC20", VA = "0x1869CF620", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69CF3C0", Offset = "0x69CD9C0", VA = "0x1869CF3C0")]
		private static Task<RenderTexture> CLIELJCGFMJ(FDINLFFFJDA JOLELDEABPK, CancellationToken NNGMAHIDECE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69CFAB0", Offset = "0x69CE0B0", VA = "0x1869CFAB0")]
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
