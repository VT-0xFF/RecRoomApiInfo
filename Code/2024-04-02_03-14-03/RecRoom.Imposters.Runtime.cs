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
	private readonly struct EGHAAOKEFIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly NHMJNBGFBMA PPOHABJOPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string EHAAMAPBCCL;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x902320", Offset = "0x900F20", VA = "0x180902320")]
		public EGHAAOKEFIP(NHMJNBGFBMA GFHEBCOMOJF, string HJKKEICKEBK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct IJCJONKDBBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public EGHAAOKEFIP queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6147D50", Offset = "0x6146950", VA = "0x186147D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61480F0", Offset = "0x6146CF0", VA = "0x1861480F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider FIKPGKHBPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CICENHLPKAG<EGHAAOKEFIP, GameObject> MAPGOEMMIPO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JBMKHPJBEEC PMIMKLOPKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B30", Offset = "0x7B1730", VA = "0x1807B2B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private CICENHLPKAG<EGHAAOKEFIP, GameObject> ADCHGCKKHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6143E20", Offset = "0x6142A20", VA = "0x186143E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int GMLJAPHEIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6143BF0", Offset = "0x61427F0", VA = "0x186143BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6143A10", Offset = "0x6142610", VA = "0x186143A10", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6143F80", Offset = "0x6142B80", VA = "0x186143F80", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6143AD0", Offset = "0x61426D0", VA = "0x186143AD0")]
	[AsyncStateMachine(typeof(IJCJONKDBBC))]
	private Task<GameObject> FJPLDCKPAPG(EGHAAOKEFIP PEEGDDOCDLL, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6143C40", Offset = "0x6142840", VA = "0x186143C40")]
	public Task<GameObject> LoadItemAsync(NHMJNBGFBMA GFHEBCOMOJF, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6143FF0", Offset = "0x6142BF0", VA = "0x186143FF0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BKPHBAEHKJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NHMJNBGFBMA GEKODBDJNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture LJFMFDGFMPO;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7BF470", Offset = "0x7BE070", VA = "0x1807BF470")]
		public BKPHBAEHKJB(NHMJNBGFBMA APKOFMCGPMM, Texture BLAFIMMPJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum DLDPFLDHJAM
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
	private class DBDDNKAICFE : OPHIBIFPHOD<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct DEPIIBALMMD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public DBDDNKAICFE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6142750", Offset = "0x6141350", VA = "0x186142750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6142F60", Offset = "0x6141B60", VA = "0x186142F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NHMJNBGFBMA APKOFMCGPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture CBOPAFAOIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig DBNMGDMDKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken EJGJLLMBDIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject GICDFAINHPM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override LHJBMADJJFP<Texture> JPBIOGLJEOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6142530", Offset = "0x6141130", VA = "0x186142530", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> BGLMDPPHPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6142590", Offset = "0x6141190", VA = "0x186142590")]
		public DBDDNKAICFE(NHMJNBGFBMA APKOFMCGPMM, RenderTexture CBOPAFAOIAL, ImposterRenderConfig DBNMGDMDKIL, CancellationToken EJGJLLMBDIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6142440", Offset = "0x6141040", VA = "0x186142440")]
		[AsyncStateMachine(typeof(DEPIIBALMMD))]
		private Task<Texture> NJPENKAACGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61423B0", Offset = "0x6140FB0", VA = "0x1861423B0", Slot = "10")]
		protected override void DLGLFADBMIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61423C0", Offset = "0x6140FC0", VA = "0x1861423C0")]
		private static void HHHJGMANNJA(GameObject GICDFAINHPM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EHPHFDCDAJJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6146680", Offset = "0x6145280", VA = "0x186146680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x892CC0", Offset = "0x8918C0", VA = "0x180892CC0", Slot = "5")]
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
	[FEGNHPIOBHH(NNBAHLKNBEN.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private DLDPFLDHJAM size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[MBOEKPBMMDJ("size", DLDPFLDHJAM.Custom)]
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
	private static int AKDEEBMGMEE;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture GBKONJPBEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private ECPMBBHFHIM<GameObject> NKMDGONMKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private LPNPPPGEAEB IKNBPPBIDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource PMGENMHPOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private EICCGEEHPKI<Texture> GJPKDBJPPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NHMJNBGFBMA LPJFBAODAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture EAOACBEDNHH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int KOONAMOOENN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61490B0", Offset = "0x6147CB0", VA = "0x1861490B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6149100", Offset = "0x6147D00", VA = "0x186149100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture KEGCICMKDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61487A0", Offset = "0x61473A0", VA = "0x1861487A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B20", Offset = "0x7B1720", VA = "0x1807B2B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private NHMJNBGFBMA GEKODBDJNCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A20", Offset = "0x7B6620", VA = "0x1807B7A20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6148B20", Offset = "0x6147720", VA = "0x186148B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool KPHNJABHDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5240820", Offset = "0x523F420", VA = "0x185240820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int MCEELDJCLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6148A00", Offset = "0x6147600", VA = "0x186148A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61486A0", Offset = "0x61472A0", VA = "0x1861486A0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6148C80", Offset = "0x6147880", VA = "0x186148C80")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6148AA0", Offset = "0x61476A0", VA = "0x186148AA0")]
	private void MDDJDPHFJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6148F90", Offset = "0x6147B90", VA = "0x186148F90")]
	public void Set(NHMJNBGFBMA ENEGLIGNNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6148F80", Offset = "0x6147B80", VA = "0x186148F80")]
	public void Set(Texture BLAFIMMPJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6148FA0", Offset = "0x6147BA0", VA = "0x186148FA0")]
	public void Set(BKPHBAEHKJB BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6148790", Offset = "0x6147390", VA = "0x186148790")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6148D80", Offset = "0x6147980", VA = "0x186148D80")]
	public void SetInternal(NHMJNBGFBMA ENEGLIGNNIA, [Optional] Texture CHCACFECPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6148D70", Offset = "0x6147970", VA = "0x186148D70")]
	public void SetCustomSize(int LIJMEEDENCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B2D80", Offset = "0x7B1980", VA = "0x1807B2D80")]
	public void SetAntiAliasing(int HNBOLJMHOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6148950", Offset = "0x6147550", VA = "0x186148950")]
	[AsyncStateMachine(typeof(EHPHFDCDAJJ))]
	private void DNHDMDLEMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61486B0", Offset = "0x61472B0", VA = "0x1861486B0")]
	private void CIJNLPADDHL(Texture BLAFIMMPJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6149030", Offset = "0x6147C30", VA = "0x186149030")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, LDONBAADOPB
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float PJIMNHCNJJB = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "4")]
	public void PrepareImposter(BCDOGKCIJAM ADOFCKCMGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6148660", Offset = "0x6147260", VA = "0x186148660")]
	public void SetReferencePoint(Vector3 FBFBHGAGOOB, Quaternion AMHIBJAFJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6148460", Offset = "0x6147060", VA = "0x186148460")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6148640", Offset = "0x6147240", VA = "0x186148640")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1481D80", Offset = "0x1480980", VA = "0x181481D80")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MIHDGCHOHIF
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static MIHDGCHOHIF FOOOOLMJJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float BOOHGJAFING;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F7B010", Offset = "0x1F79C10", VA = "0x181F7B010")]
	public MIHDGCHOHIF(float AENAFDHGMHF)
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
		[FEGNHPIOBHH(NNBAHLKNBEN.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int GCDDGEHNFDC = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int KPOFDPFDCNB = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> JPAKDGMFPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool GNNABADDFOA;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6149310", Offset = "0x6147F10", VA = "0x186149310")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6149210", Offset = "0x6147E10", VA = "0x186149210")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6149550", Offset = "0x6148150", VA = "0x186149550")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NHMJNBGFBMA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string DIJAEODPJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MIHDGCHOHIF MIHDGCHOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HGHOLFMPNPI;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> GCIMPPBLKNM(CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PMAABMCHPNB(NHMJNBGFBMA NAFFCAIMPLI);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDIMGELLLIF();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HPOPFMMKFNA();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CHDMMPKKFDM([Out] EICCGEEHPKI<Texture> NEGFCKBGJHK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DMMIMAHCEOM
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6142FD0", Offset = "0x6141BD0", VA = "0x186142FD0")]
	public static bool KLLIDFKOKND(NHMJNBGFBMA NMDOJCFGBAG, NHMJNBGFBMA LKABPBLPAIH)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, LDONBAADOPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6142260", Offset = "0x6140E60", VA = "0x186142260", Slot = "4")]
		public void PrepareImposter(BCDOGKCIJAM ADOFCKCMGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LDONBAADOPB
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(BCDOGKCIJAM ADOFCKCMGOM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GPJDLAMPDHA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> HIJCELLMBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> APPKLNKMHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JBMKHPJBEEC
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIGDDOACGGE(params Type[] LMFEGAKILJJ);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject OOLIAHLCIFD(GameObject FHPIFDJILGE, Transform MJOMMKLGFIJ, bool EHCCLHOOBPB = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T OOLIAHLCIFD<T>(T FHPIFDJILGE, Transform MJOMMKLGFIJ, bool EHCCLHOOBPB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T OOLIAHLCIFD<T>(GameObject FHPIFDJILGE, Transform MJOMMKLGFIJ, bool EHCCLHOOBPB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject OOLIAHLCIFD(GameObject FHPIFDJILGE, Transform MJOMMKLGFIJ, BCDOGKCIJAM ADOFCKCMGOM, bool EHCCLHOOBPB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IIMOBDJJBBO : IDisposable, JBMKHPJBEEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> DFNAFHKNBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> PHDNKJNHAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform ELDEJAENGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> EHDJEOHNEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> HMAJBHNCAKL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6146E60", Offset = "0x6145A60", VA = "0x186146E60")]
	[JDFNDIEGGDI(COFBNFOEGIB.None)]
	public static void ADHPCFGLOFB(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6147910", Offset = "0x6146510", VA = "0x186147910")]
	[Preserve]
	public IIMOBDJJBBO([NNEMKPMNJAE(null)] GPJDLAMPDHA JFECACDMJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6147440", Offset = "0x6146040", VA = "0x186147440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6147520", Offset = "0x6146120", VA = "0x186147520", Slot = "5")]
	public void FIGDDOACGGE(params Type[] LMFEGAKILJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6147880", Offset = "0x6146480", VA = "0x186147880", Slot = "6")]
	public GameObject OOLIAHLCIFD(GameObject FHPIFDJILGE, Transform MJOMMKLGFIJ, bool EHCCLHOOBPB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x280E210", Offset = "0x280CE10", VA = "0x18280E210", Slot = "7")]
	public T OOLIAHLCIFD<T>(T FHPIFDJILGE, Transform MJOMMKLGFIJ, bool EHCCLHOOBPB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x280E280", Offset = "0x280CE80", VA = "0x18280E280", Slot = "8")]
	public T OOLIAHLCIFD<T>(GameObject FHPIFDJILGE, Transform MJOMMKLGFIJ, bool EHCCLHOOBPB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61477F0", Offset = "0x61463F0", VA = "0x1861477F0", Slot = "9")]
	public GameObject OOLIAHLCIFD(GameObject FHPIFDJILGE, Transform MJOMMKLGFIJ, BCDOGKCIJAM ADOFCKCMGOM, bool EHCCLHOOBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x280E2B0", Offset = "0x280CEB0", VA = "0x18280E2B0", Slot = "10")]
	public T OOLIAHLCIFD<T>(GameObject FHPIFDJILGE, Transform MJOMMKLGFIJ, BCDOGKCIJAM ADOFCKCMGOM, bool EHCCLHOOBPB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x280E2F0", Offset = "0x280CEF0", VA = "0x18280E2F0")]
	private T OOLIAHLCIFD<T>(GameObject FHPIFDJILGE, Transform MJOMMKLGFIJ, BCDOGKCIJAM ADOFCKCMGOM, bool EHCCLHOOBPB, [Out] GameObject LNDBKKKOBDD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x280DD70", Offset = "0x280C970", VA = "0x18280DD70")]
	private T LMIAJCBFMCK<T>(GameObject DNJHAKIPIPL, BCDOGKCIJAM ADOFCKCMGOM, bool EHCCLHOOBPB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61476E0", Offset = "0x61462E0", VA = "0x1861476E0")]
	private void MLFICCGDGIH(Component AHNMMBDFHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6146F60", Offset = "0x6145B60", VA = "0x186146F60")]
	private void AJGJNAAGPND(Component AHNMMBDFHCD, BCDOGKCIJAM ADOFCKCMGOM, bool EHCCLHOOBPB, bool CCNHCJDAKKB, [Optional] Type CDALKBOOCFK, [Optional] Type MCIFJJDIKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6147570", Offset = "0x6146170", VA = "0x186147570")]
	private void JCBPNMGEDNC(GameObject DNJHAKIPIPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BCDOGKCIJAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> NDGKFONDBFE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2598D40", Offset = "0x2597940", VA = "0x182598D40")]
	public BCDOGKCIJAM FNEEIDKMODG<T>(T MOFONJCMKJD)
	{
		return default(BCDOGKCIJAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2598C30", Offset = "0x2597830", VA = "0x182598C30")]
	public T CPPPHMALPOD<T>(T FCKGAANHHID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2598460", Offset = "0x2597060", VA = "0x182598460")]
	public bool AGMIEMMEKCH<T>([Out] T MOFONJCMKJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EJGJKEBMAFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool FLEEGLCKOHJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xCB28E0", Offset = "0xCB14E0", VA = "0x180CB28E0")]
	public EJGJKEBMAFD(bool NAOFFIPOHLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PEGBGKHBCNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool FNIINDIDBLJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x61496C0", Offset = "0x61482C0", VA = "0x1861496C0")]
	public PEGBGKHBCNN(bool AGKJACLNEAG)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, LDONBAADOPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x61496D0", Offset = "0x61482D0", VA = "0x1861496D0", Slot = "4")]
		public void PrepareImposter(BCDOGKCIJAM ADOFCKCMGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
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
		public Bounds EFIOFFPKNII
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x61482D0", Offset = "0x6146ED0", VA = "0x1861482D0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6148290", Offset = "0x6146E90", VA = "0x186148290")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6148250", Offset = "0x6146E50", VA = "0x186148250")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6148160", Offset = "0x6146D60", VA = "0x186148160")]
		private void GOPFIJKFCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x61495F0", Offset = "0x61481F0", VA = "0x1861495F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x61495E0", Offset = "0x61481E0", VA = "0x1861495E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6149180", Offset = "0x6147D80", VA = "0x186149180")]
		public void NLCKIKGPADD(Vector3 BGLBCBBMBKI, Quaternion JEMEGMABBMI, float DPNJNHABAPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x61491B0", Offset = "0x6147DB0", VA = "0x1861491B0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EDEFJJPABHE
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 LGJNDMKDJBN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> PBKBKLKHICB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> FFAIEKLKENI;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera NMFJEMIFHKN;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> LHLFGNAGNEN;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> BPIKBJPIPHN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode BGHCGDGJJEM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color LNEFLMMJNGN;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color PKHJBLBPFAO;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color JEMMEKAEDFC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap GOLMAMNIJGM;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool JCHJGIIKDBP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> EABEAHBKMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x61443C0", Offset = "0x6142FC0", VA = "0x1861443C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> JMFBIOMDNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6144030", Offset = "0x6142C30", VA = "0x186144030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera KJCHFEIOHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6145140", Offset = "0x6143D40", VA = "0x186145140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6145B90", Offset = "0x6144790", VA = "0x186145B90")]
	public static void NNPBBPEFJCE(Vector3 MEDOJNFCELH, Quaternion JDBCDMAAAIC, ImposterRenderConfig KFKDHBHFEEM, bool MODOFGAAGPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6146120", Offset = "0x6144D20", VA = "0x186146120")]
	private static void OEJCCGHKKKP(Vector3 MEDOJNFCELH, Quaternion JDBCDMAAAIC, URPLight MNFJONIPPPK, ImposterRenderConfig.LightConfig PAAGCJBGNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6145A00", Offset = "0x6144600", VA = "0x186145A00")]
	public static void KPFAGLFEGLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6144D10", Offset = "0x6143910", VA = "0x186144D10")]
	private static void HEOGLHOAOBH(int BFHFPMMHOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6144A60", Offset = "0x6143660", VA = "0x186144A60")]
	public static void FDNENGJEMJK(ImposterRenderConfig KFKDHBHFEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6144C20", Offset = "0x6143820", VA = "0x186144C20")]
	public static void GHCKIFNHDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6144080", Offset = "0x6142C80", VA = "0x186144080")]
	public static void DFDKOMMLEAC(GameObject FIGKLOGKKHC, RenderTexture CBOPAFAOIAL, ImposterRenderConfig KFKDHBHFEEM, MIHDGCHOHIF BFIIEKGKECD, [Optional] Vector3? LJEPINJIFEO, [Optional] Vector3? MGBOJFJLEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6144410", Offset = "0x6143010", VA = "0x186144410")]
	private static void DLPOHPGHBDF(GameObject FIGKLOGKKHC, RenderTexture CBOPAFAOIAL, ImposterRenderConfig KFKDHBHFEEM, MIHDGCHOHIF BFIIEKGKECD, Vector3 LJEPINJIFEO, Vector3 MGBOJFJLEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6145E30", Offset = "0x6144A30", VA = "0x186145E30")]
	private static void OAOJKDFBAMB(GameObject FIGKLOGKKHC, Vector3 KNJPMJBICEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6145390", Offset = "0x6143F90", VA = "0x186145390")]
	private static void KGDAFCGPEBG(GameObject FHPIFDJILGE, ImposterRenderConfig KFKDHBHFEEM, MIHDGCHOHIF BFIIEKGKECD, [Out] Vector3 ELFKJOPEHIC, [Out] Quaternion GAHNJIHPCAB, [Out] float LEBDPEKLNPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6145AE0", Offset = "0x61446E0", VA = "0x186145AE0")]
	public static RenderTexture MDHCHPNBJNC(int JIBGHGEBPGM, int JMAKFJEBNGB, RenderTextureFormat AHKBHJGDBJA = RenderTextureFormat.ARGB32)
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
		public struct OJMCIKNDICK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AIEMBHKGDME LMEDJOOMECF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject OELFCNLLOCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture KEGCICMKDPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig BPEHKONIJKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public MIHDGCHOHIF MIHDGCHOHIF;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6149650", Offset = "0x6148250", VA = "0x186149650")]
			public OJMCIKNDICK(AIEMBHKGDME CCAJJKDGJLD, GameObject MIJKPHLMIFD, RenderTexture CBOPAFAOIAL, ImposterRenderConfig DBNMGDMDKIL, MIHDGCHOHIF BFIIEKGKECD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static CICENHLPKAG<OJMCIKNDICK, RenderTexture> EEPFOJKEEDL;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<OJMCIKNDICK> PGJBCNNHACF;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int HAHNAPJKDED
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6143540", Offset = "0x6142140", VA = "0x186143540")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61435B0", Offset = "0x61421B0", VA = "0x1861435B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject FIGKLOGKKHC, RenderTexture CBOPAFAOIAL, ImposterRenderConfig KFKDHBHFEEM, MIHDGCHOHIF BFIIEKGKECD, CancellationToken EJGJLLMBDIN, bool PJIACLLPPHJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61430C0", Offset = "0x6141CC0", VA = "0x1861430C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x61434A0", Offset = "0x61420A0", VA = "0x1861434A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x61432B0", Offset = "0x6141EB0", VA = "0x1861432B0")]
		private static Task<RenderTexture> EKAKFMGOMKC(OJMCIKNDICK IPGLFPNKIKO, CancellationToken EJGJLLMBDIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x61439D0", Offset = "0x61425D0", VA = "0x1861439D0")]
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
