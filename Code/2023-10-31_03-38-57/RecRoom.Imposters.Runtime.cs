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
	private readonly struct BFDPMKLAGFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JGPBHNCKMOD PIMKOJLOOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string CDPBNEAFHPC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC80", Offset = "0x7EF080", VA = "0x1807EFC80")]
		public BFDPMKLAGFK(JGPBHNCKMOD BDCCDCCNPIN, string IDIHANEDCJM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct GEPOPLGNFDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public BFDPMKLAGFK queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C8D030", Offset = "0x5C8C430", VA = "0x185C8D030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C8D3D0", Offset = "0x5C8C7D0", VA = "0x185C8D3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider KAPJMCEELEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EOGEMKHKGBM<BFDPMKLAGFK, GameObject> OGIBLLBNFOP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BCABHFNDGHI EGNDGAKALEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B960", VA = "0x18075C560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private EOGEMKHKGBM<BFDPMKLAGFK, GameObject> ODPJOPAPAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A320", Offset = "0x5C89720", VA = "0x185C8A320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int ILKJPOIIOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A480", Offset = "0x5C89880", VA = "0x185C8A480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C8A140", Offset = "0x5C89540", VA = "0x185C8A140", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5C8A6B0", Offset = "0x5C89AB0", VA = "0x185C8A6B0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5C8A200", Offset = "0x5C89600", VA = "0x185C8A200")]
	[AsyncStateMachine(typeof(GEPOPLGNFDD))]
	private Task<GameObject> BHBHHEFDDDI(BFDPMKLAGFK KLNHKBMIMBL, CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5C8A4D0", Offset = "0x5C898D0", VA = "0x185C8A4D0")]
	public Task<GameObject> LoadItemAsync(JGPBHNCKMOD BDCCDCCNPIN, CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C8A720", Offset = "0x5C89B20", VA = "0x185C8A720")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EMOHFBPIIBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JGPBHNCKMOD OEMLOOCLDDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture IFJDJOICJLJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76B3A0", Offset = "0x76A7A0", VA = "0x18076B3A0")]
		public EMOHFBPIIBO(JGPBHNCKMOD JPKGOPFJDDC, Texture NKMJMDLAGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum HFLMDBLPNGI
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
	private class KIMEJIACOGH : EJOGLAHGLBK<Texture>, EFEAIAAGJLL, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct LFLBCJCNMKL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public KIMEJIACOGH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5C8FAD0", Offset = "0x5C8EED0", VA = "0x185C8FAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5C902E0", Offset = "0x5C8F6E0", VA = "0x185C902E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly JGPBHNCKMOD JPKGOPFJDDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture INJOMBFGBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig JHOPLHEIJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken ELGJALILGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject JNOBMGOFBOI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public OCKEEDNGMLO<Texture> GAPDMCCKMNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5C8F7C0", Offset = "0x5C8EBC0", VA = "0x185C8F7C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Task<Texture> FBKGLFOMOGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F910", Offset = "0x5C8ED10", VA = "0x185C8F910")]
		public KIMEJIACOGH(JGPBHNCKMOD JPKGOPFJDDC, RenderTexture INJOMBFGBPI, ImposterRenderConfig JHOPLHEIJAD, CancellationToken ELGJALILGJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F820", Offset = "0x5C8EC20", VA = "0x185C8F820")]
		[AsyncStateMachine(typeof(LFLBCJCNMKL))]
		private Task<Texture> OLEHIPOEOIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F7B0", Offset = "0x5C8EBB0", VA = "0x185C8F7B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F730", Offset = "0x5C8EB30", VA = "0x185C8F730")]
		private static void CEJCINCEFNJ(GameObject JNOBMGOFBOI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FBLKDNKCPIN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5C8C890", Offset = "0x5C8BC90", VA = "0x185C8C890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86F690", Offset = "0x86EA90", VA = "0x18086F690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[SerializeField]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[BCMNMDCFIOE(DGGKPPHNIIC.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private HFLMDBLPNGI size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[KLCMOLPFEML("size", HFLMDBLPNGI.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int GCAJAHNLHNA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture BMJNCCHDKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private KADBKNPIEDD<GameObject> DENAOKBGDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private FKNGOBIAJDA GHFBGHCIBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource HGNKABNPMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private EJOGLAHGLBK<Texture> EEFBBOIPBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private JGPBHNCKMOD PLNPNOIFFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture MAKPKFBLBOG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int AMMOIPBNPPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F230", Offset = "0x5C8E630", VA = "0x185C8F230")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F280", Offset = "0x5C8E680", VA = "0x185C8F280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture OMDBOBIIDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C8ED40", Offset = "0x5C8E140", VA = "0x185C8ED40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75C7C0", Offset = "0x75BBC0", VA = "0x18075C7C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JGPBHNCKMOD OEMLOOCLDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7610F0", Offset = "0x7604F0", VA = "0x1807610F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5C8EBE0", Offset = "0x5C8DFE0", VA = "0x185C8EBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool FOLOEKJIHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4E63D60", Offset = "0x4E63160", VA = "0x184E63D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int GOBGMBBDPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5C8E820", Offset = "0x5C8DC20", VA = "0x185C8E820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C8E940", Offset = "0x5C8DD40", VA = "0x185C8E940")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C8EAF0", Offset = "0x5C8DEF0", VA = "0x185C8EAF0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C8E8C0", Offset = "0x5C8DCC0", VA = "0x185C8E8C0")]
	private void AOGJHJDMJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5C8F150", Offset = "0x5C8E550", VA = "0x185C8F150")]
	public void Set(JGPBHNCKMOD EJFGBIKEAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C8F100", Offset = "0x5C8E500", VA = "0x185C8F100")]
	public void Set(Texture NKMJMDLAGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C8F110", Offset = "0x5C8E510", VA = "0x185C8F110")]
	public void Set(EMOHFBPIIBO EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C8E950", Offset = "0x5C8DD50", VA = "0x185C8E950")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C8EF00", Offset = "0x5C8E300", VA = "0x185C8EF00")]
	public void SetInternal(JGPBHNCKMOD EJFGBIKEAPB, [Optional] Texture NMGKMCBCHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C8EEF0", Offset = "0x5C8E2F0", VA = "0x185C8EEF0")]
	public void SetCustomSize(int HIAGJOGLOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x764B60", Offset = "0x763F60", VA = "0x180764B60")]
	public void SetAntiAliasing(int FBFCLILNHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C8E960", Offset = "0x5C8DD60", VA = "0x185C8E960")]
	[AsyncStateMachine(typeof(FBLKDNKCPIN))]
	private void HAGNLGDFLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C8EA10", Offset = "0x5C8DE10", VA = "0x185C8EA10")]
	private void KMJBMKJNJIO(Texture NKMJMDLAGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C8F1B0", Offset = "0x5C8E5B0", VA = "0x185C8F1B0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, LPJOAALLNDD
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float GKBJFCLGAPJ = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "4")]
	public void PrepareImposter(MAILIMMKFKD ILKHBODBFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5C8E7E0", Offset = "0x5C8DBE0", VA = "0x185C8E7E0")]
	public void SetReferencePoint(Vector3 DPHLBKLFIPE, Quaternion CMOGOLPKHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5C8E5E0", Offset = "0x5C8D9E0", VA = "0x185C8E5E0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5C8E7C0", Offset = "0x5C8DBC0", VA = "0x185C8E7C0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1303BB0", Offset = "0x1302FB0", VA = "0x181303BB0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LEOOFFPCHEL
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static LEOOFFPCHEL LAGHHDMFJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float LMKOPMFEBDA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F364C0", Offset = "0x1F358C0", VA = "0x181F364C0")]
	public LEOOFFPCHEL(float OAMEOGDHKMA)
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
		[SerializeField]
		[BCMNMDCFIOE(DGGKPPHNIIC.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int IEHPMIOIJPM = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int AGHGPFJKJFC = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> CPMLKBPNKPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool COHEKAEGCMM;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F460", Offset = "0x5C8E860", VA = "0x185C8F460")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F360", Offset = "0x5C8E760", VA = "0x185C8F360")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F6A0", Offset = "0x5C8EAA0", VA = "0x185C8F6A0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JGPBHNCKMOD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string FKFJHHBIKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LEOOFFPCHEL LEOOFFPCHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FEOPNIJEFDE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> HOOEILGBHNA(CancellationToken ELGJALILGJE);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BJMDOGMHFGF(JGPBHNCKMOD LJIBJAOOGGF);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HAFCAONPOPM();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LNLACEEJCHP();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DJPKLJCLHNH([Out] EJOGLAHGLBK<Texture> BDAHEMIBJMO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PMPIDAKPBKP
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5C90390", Offset = "0x5C8F790", VA = "0x185C90390")]
	public static bool HPHHLBOENLF(JGPBHNCKMOD AIHGPAGPJLN, JGPBHNCKMOD LCCEDPGDCNH)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, LPJOAALLNDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5C896F0", Offset = "0x5C88AF0", VA = "0x185C896F0", Slot = "4")]
		public void PrepareImposter(MAILIMMKFKD ILKHBODBFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LPJOAALLNDD
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(MAILIMMKFKD ILKHBODBFFI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LLMNLPACDAO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> DNHJELEBEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> AEBOCMPLFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BCABHFNDGHI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject KFIJJHBONAH(GameObject FOHPGKLHLGD, Transform EBFCMPBKGBM, bool DOFCFEPPBFJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T KFIJJHBONAH<T>(T FOHPGKLHLGD, Transform EBFCMPBKGBM, bool DOFCFEPPBFJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T KFIJJHBONAH<T>(GameObject FOHPGKLHLGD, Transform EBFCMPBKGBM, bool DOFCFEPPBFJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject KFIJJHBONAH(GameObject FOHPGKLHLGD, Transform EBFCMPBKGBM, MAILIMMKFKD ILKHBODBFFI, bool DOFCFEPPBFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IEMJMGCANIN : IDisposable, BCABHFNDGHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> DDHFNHGPGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> LGKLEIPGLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform NDAPHCOOHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> HPLANHOMJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> JDLJDNDICAM;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5C8DC80", Offset = "0x5C8D080", VA = "0x185C8DC80")]
	[JMHDKPKEECF(OPIGPDFNEON.None)]
	public static void JHBKMICOLHJ(HLDKHDLHDPB KBPJCNHNBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5C8DEA0", Offset = "0x5C8D2A0", VA = "0x185C8DEA0")]
	[Preserve]
	public IEMJMGCANIN([LOJAGCNCPBJ(null)] LLMNLPACDAO FPOJFLBLNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5C8D550", Offset = "0x5C8C950", VA = "0x185C8D550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5C8DD80", Offset = "0x5C8D180", VA = "0x185C8DD80", Slot = "5")]
	public GameObject KFIJJHBONAH(GameObject FOHPGKLHLGD, Transform EBFCMPBKGBM, bool DOFCFEPPBFJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x23CF0C0", Offset = "0x23CE4C0", VA = "0x1823CF0C0", Slot = "6")]
	public T KFIJJHBONAH<T>(T FOHPGKLHLGD, Transform EBFCMPBKGBM, bool DOFCFEPPBFJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x23CF090", Offset = "0x23CE490", VA = "0x1823CF090", Slot = "7")]
	public T KFIJJHBONAH<T>(GameObject FOHPGKLHLGD, Transform EBFCMPBKGBM, bool DOFCFEPPBFJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5C8DE10", Offset = "0x5C8D210", VA = "0x185C8DE10", Slot = "8")]
	public GameObject KFIJJHBONAH(GameObject FOHPGKLHLGD, Transform EBFCMPBKGBM, MAILIMMKFKD ILKHBODBFFI, bool DOFCFEPPBFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x23CF050", Offset = "0x23CE450", VA = "0x1823CF050", Slot = "9")]
	public T KFIJJHBONAH<T>(GameObject FOHPGKLHLGD, Transform EBFCMPBKGBM, MAILIMMKFKD ILKHBODBFFI, bool DOFCFEPPBFJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x23CEAE0", Offset = "0x23CDEE0", VA = "0x1823CEAE0")]
	private T KFIJJHBONAH<T>(GameObject FOHPGKLHLGD, Transform EBFCMPBKGBM, MAILIMMKFKD ILKHBODBFFI, bool DOFCFEPPBFJ, [Out] GameObject FGPFNLFCCDJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x23B87C0", Offset = "0x23B7BC0", VA = "0x1823B87C0")]
	private T ECMFANEPAGA<T>(GameObject IPAGFDLNMDK, MAILIMMKFKD ILKHBODBFFI, bool DOFCFEPPBFJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5C8D440", Offset = "0x5C8C840", VA = "0x185C8D440")]
	private void BLHLIGLOGPP(Component NCKHGGMLODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C8D630", Offset = "0x5C8CA30", VA = "0x185C8D630")]
	private void GMBMMEDCEJC(Component NCKHGGMLODI, MAILIMMKFKD ILKHBODBFFI, bool DOFCFEPPBFJ, bool HMBKELFOFHP, [Optional] Type GMANIBEEFLG, [Optional] Type NNFDFDBOEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5C8DB10", Offset = "0x5C8CF10", VA = "0x185C8DB10")]
	private void HBOOHKEIHKN(GameObject IPAGFDLNMDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MAILIMMKFKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> MINBHDKLCFB;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2468C50", Offset = "0x2468050", VA = "0x182468C50")]
	public MAILIMMKFKD GMFKOPHMECD<T>(T BFGBHOLAAFC)
	{
		return default(MAILIMMKFKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2469B50", Offset = "0x2468F50", VA = "0x182469B50")]
	public T OPODPAEFLEB<T>(T DPPAMEJDDPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2469380", Offset = "0x2468780", VA = "0x182469380")]
	public bool IIDAIDKPMAP<T>([Out] T BFGBHOLAAFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LLBFAKLFPCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool DOCJKEJDIND;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xB488D0", Offset = "0xB47CD0", VA = "0x180B488D0")]
	public LLBFAKLFPCC(bool BGNPKIHFKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NMPONBCFDGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool LDKJENDEJGO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5C90380", Offset = "0x5C8F780", VA = "0x185C90380")]
	public NMPONBCFDGH(bool OKLGAACFEBB)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, LPJOAALLNDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5C90480", Offset = "0x5C8F880", VA = "0x185C90480", Slot = "4")]
		public void PrepareImposter(MAILIMMKFKD ILKHBODBFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
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
		public Bounds GGCIOOEDGEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5C8E450", Offset = "0x5C8D850", VA = "0x185C8E450")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5C8E410", Offset = "0x5C8D810", VA = "0x185C8E410")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5C8E3D0", Offset = "0x5C8D7D0", VA = "0x185C8E3D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5C8E2E0", Offset = "0x5C8D6E0", VA = "0x185C8E2E0")]
		private void OBABCKDNPFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x5C90360", Offset = "0x5C8F760", VA = "0x185C90360")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5C90350", Offset = "0x5C8F750", VA = "0x185C90350")]
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
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F300", Offset = "0x5C8E700", VA = "0x185C8F300")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EKGJGLLFJKH
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> MPAOKDICOEM;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 PCLAOPNIKEF;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 OKFKGPCNFOD;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera ABONICCIJLP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> CPBJGHOJHFA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> EPIKDACHLEF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode NBOMOAJOCGG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color PDNEDCGAOOM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color LMCKFOIPGPN;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color MBFHFKHMKKL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap FCKCMKDBENN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool DHGCJIANIAF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera MBKIBIEFMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5C8AFC0", Offset = "0x5C8A3C0", VA = "0x185C8AFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5C8ABC0", Offset = "0x5C89FC0", VA = "0x185C8ABC0")]
	public static void DDBGDHDBKDG(Vector3 GAGIOFALDJA, Quaternion LEIIEHNGKIC, ImposterRenderConfig OKAFKMIPJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5C8BE20", Offset = "0x5C8B220", VA = "0x185C8BE20")]
	private static void MIAKMHANNLD(Vector3 GAGIOFALDJA, Quaternion LEIIEHNGKIC, URPLight PEFNBFGFBDJ, ImposterRenderConfig.LightConfig LGNPCMGOMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5C8AEE0", Offset = "0x5C8A2E0", VA = "0x185C8AEE0")]
	public static void ECJINKPCKDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5C8C150", Offset = "0x5C8B550", VA = "0x185C8C150")]
	private static void MLOLJLOHLJB(int BLDHFILOAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5C8A760", Offset = "0x5C89B60", VA = "0x185C8A760")]
	public static void BPAAEHDMCKE(ImposterRenderConfig OKAFKMIPJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B1D0", Offset = "0x5C8A5D0", VA = "0x185C8B1D0")]
	public static void FJBHIEPKMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5C8C4D0", Offset = "0x5C8B8D0", VA = "0x185C8C4D0")]
	public static void OHMCEJONHOF(GameObject BKOLDKJIJJB, RenderTexture INJOMBFGBPI, ImposterRenderConfig OKAFKMIPJJL, LEOOFFPCHEL IKNHIBPIEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B2C0", Offset = "0x5C8A6C0", VA = "0x185C8B2C0")]
	private static void GCMOCPMPFNI(GameObject BKOLDKJIJJB, RenderTexture INJOMBFGBPI, ImposterRenderConfig OKAFKMIPJJL, LEOOFFPCHEL IKNHIBPIEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5C8A920", Offset = "0x5C89D20", VA = "0x185C8A920")]
	private static void CAJPDJMAKCG(GameObject BKOLDKJIJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B8A0", Offset = "0x5C8ACA0", VA = "0x185C8B8A0")]
	public static void JHLOCHGCLNC(GameObject FOHPGKLHLGD, Vector3 CALJDJFHDMA, Vector3 GIKDOECIBPJ, float EFOOFBKCGMG, LEOOFFPCHEL IKNHIBPIEFP, [Out] Vector3 GEMCGKHOOMM, [Out] Quaternion JHCLLEFBCEN, [Out] float MMFJCAMFKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5C8AE30", Offset = "0x5C8A230", VA = "0x185C8AE30")]
	public static RenderTexture DEHBOGJLGLJ(int DFFLJOMMBKP, int JLHCJGALPIM, RenderTextureFormat LFCIMIBPFKO = RenderTextureFormat.ARGB32)
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
		public struct BHAIMONNEKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public NFBEAPPNOOK MINCBGLJFOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject HKOFPDNHDEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture OMDBOBIIDHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig NKJFGHHLBLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public LEOOFFPCHEL LEOOFFPCHEL;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5C89680", Offset = "0x5C88A80", VA = "0x185C89680")]
			public BHAIMONNEKC(NFBEAPPNOOK AFACHDDFPGD, GameObject BLJPFDDODNA, RenderTexture INJOMBFGBPI, ImposterRenderConfig JHOPLHEIJAD, LEOOFFPCHEL IKNHIBPIEFP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static EOGEMKHKGBM<BHAIMONNEKC, RenderTexture> ILCFKHDCDLM;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<BHAIMONNEKC> DGPHCEBINAL;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int DCEKDBOCPMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5C89A30", Offset = "0x5C88E30", VA = "0x185C89A30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5C89CE0", Offset = "0x5C890E0", VA = "0x185C89CE0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject BKOLDKJIJJB, RenderTexture INJOMBFGBPI, ImposterRenderConfig OKAFKMIPJJL, LEOOFFPCHEL IKNHIBPIEFP, CancellationToken ELGJALILGJE, bool NGFHJEACAFM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5C89840", Offset = "0x5C88C40", VA = "0x185C89840", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5C89C40", Offset = "0x5C89040", VA = "0x185C89C40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5C89AA0", Offset = "0x5C88EA0", VA = "0x185C89AA0")]
		private static Task<RenderTexture> BMHFLDAFACB(BHAIMONNEKC DPPBICFLPNC, CancellationToken ELGJALILGJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A100", Offset = "0x5C89500", VA = "0x185C8A100")]
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
