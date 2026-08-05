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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
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
	private readonly struct NFCEOAIBCCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly FDJBPMKOOPO AMNFCKMKNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string DGFFOJPABFM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA81780", Offset = "0xA7FF80", VA = "0x180A81780")]
		public NFCEOAIBCCN(FDJBPMKOOPO DMGLIHBPOAL, string PANEKIAKHIH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct OEBKNACENJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public NFCEOAIBCCN queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B657F0", Offset = "0x7B63FF0", VA = "0x187B657F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B65BB0", Offset = "0x7B643B0", VA = "0x187B65BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider HPCCNFBJBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NKJLFPGANPE<NFCEOAIBCCN, GameObject> HHHDFAIPMPL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NPMJMILLCHJ NOFFPHGLLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private NKJLFPGANPE<NFCEOAIBCCN, GameObject> GNMEJCMCEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B60C80", Offset = "0x7B5F480", VA = "0x187B60C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int AAOODMECMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B60DE0", Offset = "0x7B5F5E0", VA = "0x187B60DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B60BA0", Offset = "0x7B5F3A0", VA = "0x187B60BA0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B61120", Offset = "0x7B5F920", VA = "0x187B61120", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7B61000", Offset = "0x7B5F800", VA = "0x187B61000")]
	[AsyncStateMachine(typeof(OEBKNACENJG))]
	private Task<GameObject> MBNCCPFNNPH(NFCEOAIBCCN HLFBEDFOPPB, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B60E30", Offset = "0x7B5F630", VA = "0x187B60E30")]
	public Task<GameObject> LoadItemAsync(FDJBPMKOOPO DMGLIHBPOAL, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7B61190", Offset = "0x7B5F990", VA = "0x187B61190")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class PDMLPAMICHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FDJBPMKOOPO OKICGOBHGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture PPIFCFIECMO;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
		public PDMLPAMICHC(FDJBPMKOOPO CFAMGBHLJNL, Texture OAGLIKEGCPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum DOKLLNKIIPM
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
	private class BFLIJJONIMG : JLIPNKFLGEL<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct IFHLJNFBFLA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public BFLIJJONIMG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7B612C0", Offset = "0x7B5FAC0", VA = "0x187B612C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7B61AB0", Offset = "0x7B602B0", VA = "0x187B61AB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly FDJBPMKOOPO CFAMGBHLJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture PNHGGLOJLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig OOJEMDLIJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken DNHBNMHIDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D EBGACCADPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject KEBGBMHDOMA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override KJPDFMLMKLI<Texture2D> BHCHNLDLDDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7B5F430", Offset = "0x7B5DC30", VA = "0x187B5F430", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> PKNGMGKPCFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F600", Offset = "0x7B5DE00", VA = "0x187B5F600")]
		public BFLIJJONIMG(FDJBPMKOOPO CFAMGBHLJNL, RenderTexture PNHGGLOJLAG, ImposterRenderConfig OOJEMDLIJBP, CancellationToken DNHBNMHIDAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F490", Offset = "0x7B5DC90", VA = "0x187B5F490")]
		[AsyncStateMachine(typeof(IFHLJNFBFLA))]
		private Task<Texture2D> PHNNICLMECM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F400", Offset = "0x7B5DC00", VA = "0x187B5F400", Slot = "10")]
		protected override void FBKFMPFCODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F580", Offset = "0x7B5DD80", VA = "0x187B5F580")]
		private static void PLBIEADCJIC(GameObject KEBGBMHDOMA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CJJEENABIDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F7C0", Offset = "0x7B5DFC0", VA = "0x187B5F7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Header("General")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private DOKLLNKIIPM size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[LEOLDNKHGOB("size", DOKLLNKIIPM.Custom)]
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
	private static int CKPHDIFFCIL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture DDBFJJDOLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PKGIFHADLHM<GameObject> DHHEMKKKBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private LLDEFGHLBOH MJDHNLKKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource GCOFADJEBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private GOANNPAHNKI<Texture2D> GOONMHGOJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private FDJBPMKOOPO BKMJBFMPFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture APAFGGBIEMH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int GFHLGCHIMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A80", Offset = "0x7B61280", VA = "0x187B62A80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B62AD0", Offset = "0x7B612D0", VA = "0x187B62AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture JHBCGLHIHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B62470", Offset = "0x7B60C70", VA = "0x187B62470")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DA0", Offset = "0x9DF5A0", VA = "0x1809E0DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private FDJBPMKOOPO OKICGOBHGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B62230", Offset = "0x7B60A30", VA = "0x187B62230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool OIMGDCNBGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x212FD80", Offset = "0x212E580", VA = "0x18212FD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int DBEKMLLEDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B62190", Offset = "0x7B60990", VA = "0x187B62190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7B62050", Offset = "0x7B60850", VA = "0x187B62050")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7B62650", Offset = "0x7B60E50", VA = "0x187B62650")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B62060", Offset = "0x7B60860", VA = "0x187B62060")]
	private void BDKOAIHLGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B62960", Offset = "0x7B61160", VA = "0x187B62960")]
	public void Set(FDJBPMKOOPO EFMJFLLCAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B62950", Offset = "0x7B61150", VA = "0x187B62950")]
	public void Set(Texture OAGLIKEGCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B62970", Offset = "0x7B61170", VA = "0x187B62970")]
	public void Set(PDMLPAMICHC OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B62220", Offset = "0x7B60A20", VA = "0x187B62220")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B62750", Offset = "0x7B60F50", VA = "0x187B62750")]
	public void SetInternal(FDJBPMKOOPO EFMJFLLCAPN, [Optional] Texture PEAOAHKNHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B62740", Offset = "0x7B60F40", VA = "0x187B62740")]
	public void SetCustomSize(int KJKKKHNMLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9E4110", Offset = "0x9E2910", VA = "0x1809E4110")]
	public void SetAntiAliasing(int PECJIEANHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B620E0", Offset = "0x7B608E0", VA = "0x187B620E0")]
	[AsyncStateMachine(typeof(CJJEENABIDK))]
	private void CFJDHGGMIAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B62390", Offset = "0x7B60B90", VA = "0x187B62390")]
	private void GFOMODBAMDF(Texture OAGLIKEGCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B62A00", Offset = "0x7B61200", VA = "0x187B62A00")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, ACNIFOFIOML
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float JFIOIKNMGOK = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void PrepareImposter(AMFEEPKENMF KIAKHLGFPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B62010", Offset = "0x7B60810", VA = "0x187B62010")]
	public void SetReferencePoint(Vector3 IKAECBBFJHO, Quaternion KOBOFDGKPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B61E20", Offset = "0x7B60620", VA = "0x187B61E20")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B61FF0", Offset = "0x7B607F0", VA = "0x187B61FF0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1E0EA70", Offset = "0x1E0D270", VA = "0x181E0EA70")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DKKFJOBHDGD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static DKKFJOBHDGD CLANOJGAMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float AMLDODGCJBM;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2973C60", Offset = "0x2972460", VA = "0x182973C60")]
	public DKKFJOBHDGD(float BBNOGGAIAHG)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B66D90", Offset = "0x7B65590", VA = "0x187B66D90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int EHBEMFMJHAC = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int NEPAJALMODJ = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> NLKFJEOIGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool NCHBHFBABAH;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B62CE0", Offset = "0x7B614E0", VA = "0x187B62CE0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B62BE0", Offset = "0x7B613E0", VA = "0x187B62BE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B62F20", Offset = "0x7B61720", VA = "0x187B62F20")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FDJBPMKOOPO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string GCLGDBINGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DKKFJOBHDGD DKKFJOBHDGD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KJOEIKEHMGM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> ECDKDIBBKAD(CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LCOMBHMEADL(FDJBPMKOOPO PGPJMFPAKOO);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGPLICEAKAF();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GCOANDDCCEL();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GDAFHGICMKL(uint? LGHJFINGEPK, [Out] GOANNPAHNKI<Texture2D> FGAHMLNIIEA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GBNAEBLLBDF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7B611D0", Offset = "0x7B5F9D0", VA = "0x187B611D0")]
	public static bool DDNEMKOEALA(FDJBPMKOOPO HCDEPDPOJKN, FDJBPMKOOPO BKEHHNFCKAA)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, ACNIFOFIOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B60000", Offset = "0x7B5E800", VA = "0x187B60000", Slot = "4")]
		public void PrepareImposter(AMFEEPKENMF KIAKHLGFPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ACNIFOFIOML
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(AMFEEPKENMF KIAKHLGFPAF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NMKGKEJOJLA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> JKKLOMGLFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> HNCAFGOKDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NPMJMILLCHJ
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHIFLCCBJDH(params Type[] GPFNCNIBJAB);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject AONLEOKMNJA(GameObject GLNOEJGIDBO, Transform DFPCBMGPBFO, bool LCCCPLDOJAI = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T AONLEOKMNJA<T>(T GLNOEJGIDBO, Transform DFPCBMGPBFO, bool LCCCPLDOJAI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T AONLEOKMNJA<T>(GameObject GLNOEJGIDBO, Transform DFPCBMGPBFO, bool LCCCPLDOJAI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject AONLEOKMNJA(GameObject GLNOEJGIDBO, Transform DFPCBMGPBFO, AMFEEPKENMF KIAKHLGFPAF, bool LCCCPLDOJAI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PNBOCNLDJKN : IDisposable, NPMJMILLCHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> KDOCCACIPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> MJOEBCCEHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform CNLOAEBGEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> JEFCEPBDJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> BGPKECKPEFK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B65E20", Offset = "0x7B64620", VA = "0x187B65E20")]
	[PJMOOJOMMCC.OJAOBFKEEAO]
	public static void FGFPGKKONLH(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7B666A0", Offset = "0x7B64EA0", VA = "0x187B666A0")]
	[UnityEngine.Scripting.Preserve]
	public PNBOCNLDJKN([LDAFGEHKDJK(null)] NMKGKEJOJLA CPFOACKHDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B65D40", Offset = "0x7B64540", VA = "0x187B65D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7B66650", Offset = "0x7B64E50", VA = "0x187B66650", Slot = "5")]
	public void NHIFLCCBJDH(params Type[] GPFNCNIBJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7B65C20", Offset = "0x7B64420", VA = "0x187B65C20", Slot = "6")]
	public GameObject AONLEOKMNJA(GameObject GLNOEJGIDBO, Transform DFPCBMGPBFO, bool LCCCPLDOJAI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3999510", Offset = "0x3997D10", VA = "0x183999510", Slot = "7")]
	public T AONLEOKMNJA<T>(T GLNOEJGIDBO, Transform DFPCBMGPBFO, bool LCCCPLDOJAI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3998F40", Offset = "0x3997740", VA = "0x183998F40", Slot = "8")]
	public T AONLEOKMNJA<T>(GameObject GLNOEJGIDBO, Transform DFPCBMGPBFO, bool LCCCPLDOJAI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7B65CB0", Offset = "0x7B644B0", VA = "0x187B65CB0", Slot = "9")]
	public GameObject AONLEOKMNJA(GameObject GLNOEJGIDBO, Transform DFPCBMGPBFO, AMFEEPKENMF KIAKHLGFPAF, bool LCCCPLDOJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3998EE0", Offset = "0x39976E0", VA = "0x183998EE0", Slot = "10")]
	public T AONLEOKMNJA<T>(GameObject GLNOEJGIDBO, Transform DFPCBMGPBFO, AMFEEPKENMF KIAKHLGFPAF, bool LCCCPLDOJAI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3998F90", Offset = "0x3997790", VA = "0x183998F90")]
	private T AONLEOKMNJA<T>(GameObject GLNOEJGIDBO, Transform DFPCBMGPBFO, AMFEEPKENMF KIAKHLGFPAF, bool LCCCPLDOJAI, [Out] GameObject GCEJLKNKAJD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x39995A0", Offset = "0x3997DA0", VA = "0x1839995A0")]
	private T MMDHDIIHLPG<T>(GameObject KJMBGAPFJAM, AMFEEPKENMF KIAKHLGFPAF, bool LCCCPLDOJAI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B66540", Offset = "0x7B64D40", VA = "0x187B66540")]
	private void NDCHOOBCIKC(Component IKKBFHNKIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B66090", Offset = "0x7B64890", VA = "0x187B66090")]
	private void LKHHFEJMAEK(Component IKKBFHNKIMA, AMFEEPKENMF KIAKHLGFPAF, bool LCCCPLDOJAI, bool HILJLBNCKNI, [Optional] Type CPFMPKAJBHF, [Optional] Type BDDAGGHAIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7B65F20", Offset = "0x7B64720", VA = "0x187B65F20")]
	private void JEDIJBBGMCI(GameObject KJMBGAPFJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AMFEEPKENMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> HFHIKOPBKJE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3F0DD50", Offset = "0x3F0C550", VA = "0x183F0DD50")]
	public AMFEEPKENMF AFOHMCJECDO<T>(T DNGFIMNDOKG)
	{
		return default(AMFEEPKENMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3F0E480", Offset = "0x3F0CC80", VA = "0x183F0E480")]
	public T EFPADONOPCC<T>(T LHCNPHOLELG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3F0E590", Offset = "0x3F0CD90", VA = "0x183F0E590")]
	public bool MMIGFMCEJDL<T>([Out] T DNGFIMNDOKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GKOILGJOIMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool KGDNPDACLGJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2976410", Offset = "0x2974C10", VA = "0x182976410")]
	public GKOILGJOIMI(bool AGIGFBGJFPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JDEIFMNIHAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool GFBIEDJHIJE;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B62FB0", Offset = "0x7B617B0", VA = "0x187B62FB0")]
	public JDEIFMNIHAE(bool EFFGBMPJIKJ)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, ACNIFOFIOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7B66AE0", Offset = "0x7B652E0", VA = "0x187B66AE0", Slot = "4")]
		public void PrepareImposter(AMFEEPKENMF KIAKHLGFPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds MIPMHAPGGKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7B61C90", Offset = "0x7B60490", VA = "0x187B61C90")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7B61C50", Offset = "0x7B60450", VA = "0x187B61C50")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B61C10", Offset = "0x7B60410", VA = "0x187B61C10")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B61B20", Offset = "0x7B60320", VA = "0x187B61B20")]
		private void LCFBGLJDKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x7B65760", Offset = "0x7B63F60", VA = "0x187B65760")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7B65750", Offset = "0x7B63F50", VA = "0x187B65750")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("Get initial camera position to capture the bounds of an imposter.")]
		public bool frameCameraToImposterBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[LEOLDNKHGOB("frameCameraToImposterBounds", true)]
		public float heightCenterOffsetDivisor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("If the player is using FBA, modify the position of the camera.")]
		public Vector3 fullBodyPositionModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Auto Rotation")]
		public bool autoRotateYawImposter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[LEOLDNKHGOB("autoRotateYawImposter", true)]
		public float autoRotateDegreesPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7B62B40", Offset = "0x7B61340", VA = "0x187B62B40")]
		public void BCFBPILPPNA(Vector3 AIKKKIPJCNA, Quaternion OICDEIIICLM, float EMPANGFNGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B62B70", Offset = "0x7B61370", VA = "0x187B62B70")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class KLJNHBGOMCP
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 GPBHLPGDPIJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> MGOOKBHCIEN;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> LJHCKFPIMME;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera HBDLCAJCCLC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> JDONCIFJDAF;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> PPAIOBJBHPM;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode CDCIDCJHHHJ;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color MJIPLNCCLIL;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color IPECEFFJMHL;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color CELBIPNGCFI;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap IADDNHFOHOG;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool NNDFFAFDHGE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> OLOGDGIFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7B64E60", Offset = "0x7B63660", VA = "0x187B64E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> KHABNOLLDGO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7B63300", Offset = "0x7B61B00", VA = "0x187B63300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera OFBEBAKDAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B63790", Offset = "0x7B61F90", VA = "0x187B63790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B63500", Offset = "0x7B61D00", VA = "0x187B63500")]
	public static void EAFOBMODHDP(Vector3 ABGHDGCMGKG, Quaternion NDEIHBHDKEA, ImposterRenderConfig EFMAMPBCNBF, bool NNIIEBLIANG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B65220", Offset = "0x7B63A20", VA = "0x187B65220")]
	private static void PMKMIMLCCFP(Vector3 ABGHDGCMGKG, Quaternion NDEIHBHDKEA, URPLight GEOEGPBCBIG, ImposterRenderConfig.LightConfig MEDJLJPMOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B64D80", Offset = "0x7B63580", VA = "0x187B64D80")]
	public static void LIFICBIELKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B64890", Offset = "0x7B63090", VA = "0x187B64890")]
	private static void KFLDPLBBGJE(int EAOJJDPJKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B63350", Offset = "0x7B61B50", VA = "0x187B63350")]
	public static void DHCIKHCDCCM(ImposterRenderConfig EFMAMPBCNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B64CA0", Offset = "0x7B634A0", VA = "0x187B64CA0")]
	public static void KNINBCMANGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B62FC0", Offset = "0x7B617C0", VA = "0x187B62FC0")]
	public static void CLPFAPOABGH(GameObject IDHABMAHEAI, RenderTexture PNHGGLOJLAG, ImposterRenderConfig EFMAMPBCNBF, DKKFJOBHDGD JJPCEENHNGB, [Optional] Vector3? FNAHFHPHFFB, [Optional] Vector3? PGCIBLBMBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B639C0", Offset = "0x7B621C0", VA = "0x187B639C0")]
	private static void HMJPNMFCCCF(GameObject IDHABMAHEAI, RenderTexture PNHGGLOJLAG, ImposterRenderConfig EFMAMPBCNBF, DKKFJOBHDGD JJPCEENHNGB, Vector3 FNAHFHPHFFB, Vector3 PGCIBLBMBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7B63FF0", Offset = "0x7B627F0", VA = "0x187B63FF0")]
	private static void IKCBEPHHBNO(GameObject IDHABMAHEAI, Vector3 BMBHMNGNOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B64EB0", Offset = "0x7B636B0", VA = "0x187B64EB0")]
	public static void LNEFGFFJJAM(Bounds NLNIJGPOPAM, ImposterRenderConfig EFMAMPBCNBF, [Out] Vector3 MOCAJLMGMMO, [Out] Quaternion MGCPCNLLPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B64380", Offset = "0x7B62B80", VA = "0x187B64380")]
	private static void KEDBJCLPFDB(GameObject GLNOEJGIDBO, ImposterRenderConfig EFMAMPBCNBF, DKKFJOBHDGD JJPCEENHNGB, [Out] Vector3 MOCAJLMGMMO, [Out] Quaternion MGCPCNLLPFB, [Out] float HLAGFKGEKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B642B0", Offset = "0x7B62AB0", VA = "0x187B642B0")]
	public static RenderTexture JPDCNOIFDHA(int AJBHLEPGOLA, int OKDHCGBPBDJ, RenderTextureFormat CGJBGKAIMNA = RenderTextureFormat.ARGB32, string PLNALKGOMCO = "[ImposterRendering]Preview")
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct MLJHOILJAHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public ADBHNDANFKF FLMFKGOEEAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject AMMEDLBPDHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture JHBCGLHIHAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig LPDHJKKJKHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public DKKFJOBHDGD DKKFJOBHDGD;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7B65780", Offset = "0x7B63F80", VA = "0x187B65780")]
			public MLJHOILJAHB(ADBHNDANFKF HPMIHANAIEC, GameObject GPGLCGHOGKD, RenderTexture PNHGGLOJLAG, ImposterRenderConfig OOJEMDLIJBP, DKKFJOBHDGD JJPCEENHNGB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static NKJLFPGANPE<MLJHOILJAHB, RenderTexture> HKICDPPFHKI;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<MLJHOILJAHB> DHMGIJDFFKI;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int MJOJIFACDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7B603A0", Offset = "0x7B5EBA0", VA = "0x187B603A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7B60760", Offset = "0x7B5EF60", VA = "0x187B60760")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject IDHABMAHEAI, RenderTexture PNHGGLOJLAG, ImposterRenderConfig EFMAMPBCNBF, DKKFJOBHDGD JJPCEENHNGB, CancellationToken DNHBNMHIDAC, bool CLEBBGOOOMP = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7B60190", Offset = "0x7B5E990", VA = "0x187B60190", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7B60430", Offset = "0x7B5EC30", VA = "0x187B60430", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7B604C0", Offset = "0x7B5ECC0", VA = "0x187B604C0")]
		private static Task<RenderTexture> PJDLJODGAKM(MLJHOILJAHB EGPDAEPMIMM, CancellationToken DNHBNMHIDAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B60B60", Offset = "0x7B5F360", VA = "0x187B60B60")]
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
