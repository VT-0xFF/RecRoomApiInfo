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
	private readonly struct DLLPIIIEEKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly ENIMPNMNCKA LMPHMOENLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BKMLLKACEBD;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAB26B0", Offset = "0xAB18B0", VA = "0x180AB26B0")]
		public DLLPIIIEEKJ(ENIMPNMNCKA LFFFFGABCMN, string HNFJBCFMDLN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct GDHPLMIJKHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public DLLPIIIEEKJ queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6912EB0", Offset = "0x69120B0", VA = "0x186912EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6913250", Offset = "0x6912450", VA = "0x186913250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider IBMINJBFKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LLNBPHOHMNO<DLLPIIIEEKJ, GameObject> FECCBBNONIC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DJNGHJDKJGL AIEKMAMCBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851A90", VA = "0x180852890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LLNBPHOHMNO<DLLPIIIEEKJ, GameObject> GNCABEBFCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69120E0", Offset = "0x69112E0", VA = "0x1869120E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KIGBCLCJABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6912360", Offset = "0x6911560", VA = "0x186912360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6912020", Offset = "0x6911220", VA = "0x186912020", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6912580", Offset = "0x6911780", VA = "0x186912580", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6912240", Offset = "0x6911440", VA = "0x186912240")]
	[AsyncStateMachine(typeof(GDHPLMIJKHG))]
	private Task<GameObject> GGGKPKFBMBF(DLLPIIIEEKJ OHPHHLFKEGH, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69123B0", Offset = "0x69115B0", VA = "0x1869123B0")]
	public Task<GameObject> LoadItemAsync(ENIMPNMNCKA LFFFFGABCMN, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69125F0", Offset = "0x69117F0", VA = "0x1869125F0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CGPKFJBFLBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ENIMPNMNCKA ABABHNOPLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture FILIFCKICEL;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85E250", VA = "0x18085F050")]
		public CGPKFJBFLBC(ENIMPNMNCKA HHAEKJNKJFG, Texture IPABEBMKKAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum KAIJGJNJGCL
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
	private class GLMNBDJJABC : MDDCCCKDBFD<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct AJADCKDIMOI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public GLMNBDJJABC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6910BE0", Offset = "0x690FDE0", VA = "0x186910BE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x69113E0", Offset = "0x69105E0", VA = "0x1869113E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ENIMPNMNCKA HHAEKJNKJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture LHBPPPBOGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig IFAHGLHGPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken MPLGBOFHPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject EGILDIFIBOP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override MAKKFMNHCEA<Texture> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x69133B0", Offset = "0x69125B0", VA = "0x1869133B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855B60", VA = "0x180856960", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69134A0", Offset = "0x69126A0", VA = "0x1869134A0")]
		public GLMNBDJJABC(ENIMPNMNCKA HHAEKJNKJFG, RenderTexture LHBPPPBOGCG, ImposterRenderConfig IFAHGLHGPLP, CancellationToken MPLGBOFHPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69132C0", Offset = "0x69124C0", VA = "0x1869132C0")]
		[AsyncStateMachine(typeof(AJADCKDIMOI))]
		private Task<Texture> LKKJOIOIELO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6913410", Offset = "0x6912610", VA = "0x186913410", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6913420", Offset = "0x6912620", VA = "0x186913420")]
		private static void PMHDBJJGKBJ(GameObject EGILDIFIBOP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EOAILNPEGPA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6912630", Offset = "0x6911830", VA = "0x186912630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9EC1C0", Offset = "0x9EB3C0", VA = "0x1809EC1C0", Slot = "5")]
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
	[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private KAIJGJNJGCL size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[AHAGJGNEDIE("size", KAIJGJNJGCL.Custom)]
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
	private static int NDJEBFANHJC;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture GKHJCLFPDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PHBOGIKMHKK<GameObject> DBDEHGFIJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private HBGKBCMOMOE ACOPLEOHKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource NPCICLIMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private GBMNPHMLGKB<Texture> IMPACABBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private ENIMPNMNCKA DKEKABJIDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture EBPDPKOMNFP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int LPNCFDFODJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69145E0", Offset = "0x69137E0", VA = "0x1869145E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6914630", Offset = "0x6913830", VA = "0x186914630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture CAELAKPOIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6913E50", Offset = "0x6913050", VA = "0x186913E50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x856AA0", Offset = "0x855CA0", VA = "0x180856AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ENIMPNMNCKA ABABHNOPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x856A90", Offset = "0x855C90", VA = "0x180856A90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6913BB0", Offset = "0x6912DB0", VA = "0x186913BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool DNOMKCPEEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x158F290", Offset = "0x158E490", VA = "0x18158F290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int MIFGMBBNMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6914110", Offset = "0x6913310", VA = "0x186914110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6913BA0", Offset = "0x6912DA0", VA = "0x186913BA0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69141B0", Offset = "0x69133B0", VA = "0x1869141B0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6913D10", Offset = "0x6912F10", VA = "0x186913D10")]
	private void BKFEOLJCBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69144C0", Offset = "0x69136C0", VA = "0x1869144C0")]
	public void Set(ENIMPNMNCKA OKNKGNFBBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69144B0", Offset = "0x69136B0", VA = "0x1869144B0")]
	public void Set(Texture IPABEBMKKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69144D0", Offset = "0x69136D0", VA = "0x1869144D0")]
	public void Set(CGPKFJBFLBC JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6913D90", Offset = "0x6912F90", VA = "0x186913D90")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69142B0", Offset = "0x69134B0", VA = "0x1869142B0")]
	public void SetInternal(ENIMPNMNCKA OKNKGNFBBAK, [Optional] Texture OANBBHLCBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69142A0", Offset = "0x69134A0", VA = "0x1869142A0")]
	public void SetCustomSize(int EDABBBOIFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x858FB0", Offset = "0x8581B0", VA = "0x180858FB0")]
	public void SetAntiAliasing(int AIANMDPGLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6913DA0", Offset = "0x6912FA0", VA = "0x186913DA0")]
	[AsyncStateMachine(typeof(EOAILNPEGPA))]
	private void FHDOIKFEJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6914030", Offset = "0x6913230", VA = "0x186914030")]
	private void HLLBKMGPDDL(Texture IPABEBMKKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6914560", Offset = "0x6913760", VA = "0x186914560")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, EKLLAADFCPH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float NNAJOEMFFND = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "4")]
	public void PrepareImposter(OBAPJMOCHBF LDMPLMIKDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6913B60", Offset = "0x6912D60", VA = "0x186913B60")]
	public void SetReferencePoint(Vector3 NJGBBMKGAPK, Quaternion IJKPBDDGPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6913960", Offset = "0x6912B60", VA = "0x186913960")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6913B40", Offset = "0x6912D40", VA = "0x186913B40")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x15FE480", Offset = "0x15FD680", VA = "0x1815FE480")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DKBNIECPPOH
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static DKBNIECPPOH DLGENOFLPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float CCCKNIBDDMI;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x217A0C0", Offset = "0x21792C0", VA = "0x18217A0C0")]
	public DKBNIECPPOH(float MIOGALGFKIB)
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
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int MLCCGIKGFDJ = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int IGCOANGMCKP = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> KFIPHENHOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool KDLPLBHOAEM;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6914840", Offset = "0x6913A40", VA = "0x186914840")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6914740", Offset = "0x6913940", VA = "0x186914740")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6914A90", Offset = "0x6913C90", VA = "0x186914A90")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ENIMPNMNCKA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string OFHFAAMHODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DKBNIECPPOH DKBNIECPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GACBJEDPEKF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> AKHMACILMGM(CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MFANNBJAAHE(ENIMPNMNCKA OKGBBGMIACH);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BAOCNENGLLG();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNIJGGCIFAO();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EEBEFPOEMMF([Out] GBMNPHMLGKB<Texture> GJEEGDPJOGP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DNIAFOCLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69115E0", Offset = "0x69107E0", VA = "0x1869115E0")]
	public static bool ILKJEKAFIKL(ENIMPNMNCKA DPIMACKCMGA, ENIMPNMNCKA CLFCMEGFGPG)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, EKLLAADFCPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6911450", Offset = "0x6910650", VA = "0x186911450", Slot = "4")]
		public void PrepareImposter(OBAPJMOCHBF LDMPLMIKDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EKLLAADFCPH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(OBAPJMOCHBF LDMPLMIKDPA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NPAHAACKBKN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> GJPNHAGHKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> BOFNCDHMFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DJNGHJDKJGL
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCIAGPCBPJH(params Type[] DGLFPPDJICE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject OEEBGIHKACK(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, bool MAHGNEOOKFI = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T OEEBGIHKACK<T>(T OGCFILPLNFJ, Transform BMBBFJPOJEB, bool MAHGNEOOKFI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T OEEBGIHKACK<T>(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, bool MAHGNEOOKFI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject OEEBGIHKACK(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, OBAPJMOCHBF LDMPLMIKDPA, bool MAHGNEOOKFI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MAAAKMJNOHF : IDisposable, DJNGHJDKJGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> KOLIPBCLMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> GIBGJCJEHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform OCAMCONODBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> KFILKGPGMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> EMNGECJENBE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6914D40", Offset = "0x6913F40", VA = "0x186914D40")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	public static void ECBJKBNABGH(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69155E0", Offset = "0x69147E0", VA = "0x1869155E0")]
	[Preserve]
	public MAAAKMJNOHF([OMAPKKAGFIL(null)] NPAHAACKBKN MHMFIDMMKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6914C60", Offset = "0x6913E60", VA = "0x186914C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6915300", Offset = "0x6914500", VA = "0x186915300", Slot = "5")]
	public void LCIAGPCBPJH(params Type[] DGLFPPDJICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6915350", Offset = "0x6914550", VA = "0x186915350", Slot = "6")]
	public GameObject OEEBGIHKACK(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, bool MAHGNEOOKFI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2C29670", Offset = "0x2C28870", VA = "0x182C29670", Slot = "7")]
	public T OEEBGIHKACK<T>(T OGCFILPLNFJ, Transform BMBBFJPOJEB, bool MAHGNEOOKFI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2C29CF0", Offset = "0x2C28EF0", VA = "0x182C29CF0", Slot = "8")]
	public T OEEBGIHKACK<T>(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, bool MAHGNEOOKFI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69153E0", Offset = "0x69145E0", VA = "0x1869153E0", Slot = "9")]
	public GameObject OEEBGIHKACK(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, OBAPJMOCHBF LDMPLMIKDPA, bool MAHGNEOOKFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2C29610", Offset = "0x2C28810", VA = "0x182C29610", Slot = "10")]
	public T OEEBGIHKACK<T>(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, OBAPJMOCHBF LDMPLMIKDPA, bool MAHGNEOOKFI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2C29700", Offset = "0x2C28900", VA = "0x182C29700")]
	private T OEEBGIHKACK<T>(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, OBAPJMOCHBF LDMPLMIKDPA, bool MAHGNEOOKFI, [Out] GameObject GKANFBOFLDD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2C290B0", Offset = "0x2C282B0", VA = "0x182C290B0")]
	private T MGLHIMAPEJE<T>(GameObject NBDLDMDNCAL, OBAPJMOCHBF LDMPLMIKDPA, bool MAHGNEOOKFI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6914B50", Offset = "0x6913D50", VA = "0x186914B50")]
	private void ABOFNDBDOJJ(Component INPAFGCEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6914E40", Offset = "0x6914040", VA = "0x186914E40")]
	private void GAIFAKNIAGF(Component INPAFGCEBHH, OBAPJMOCHBF LDMPLMIKDPA, bool MAHGNEOOKFI, bool GGGFCFBOCPE, [Optional] Type IKEFIEELPJA, [Optional] Type LKNDGJOLLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6915470", Offset = "0x6914670", VA = "0x186915470")]
	private void OPKLMBJDKFK(GameObject NBDLDMDNCAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OBAPJMOCHBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> PMFAKBLHCLK;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2CBDD50", Offset = "0x2CBCF50", VA = "0x182CBDD50")]
	public OBAPJMOCHBF OLOHHMDPKEO<T>(T DCPJLNEPGKC)
	{
		return default(OBAPJMOCHBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2CBDC40", Offset = "0x2CBCE40", VA = "0x182CBDC40")]
	public T JMJOGDIBBHK<T>(T LIAHLPBCKNO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD460", Offset = "0x2CBC660", VA = "0x182CBD460")]
	public bool FFKNBABIJFJ<T>([Out] T DCPJLNEPGKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ALLNLILKFED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool KOLIPAPDGLK;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x217A0A0", Offset = "0x21792A0", VA = "0x18217A0A0")]
	public ALLNLILKFED(bool PCAMCMACDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FCDLHIEALBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool NKKKCJAADKH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6912E30", Offset = "0x6912030", VA = "0x186912E30")]
	public FCDLHIEALBI(bool BLFOMPKAMGE)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, EKLLAADFCPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6918090", Offset = "0x6917290", VA = "0x186918090", Slot = "4")]
		public void PrepareImposter(OBAPJMOCHBF LDMPLMIKDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
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
		public Bounds POJGNIALDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x69137D0", Offset = "0x69129D0", VA = "0x1869137D0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6913790", Offset = "0x6912990", VA = "0x186913790")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6913750", Offset = "0x6912950", VA = "0x186913750")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6913660", Offset = "0x6912860", VA = "0x186913660")]
		private void IEDINMOGHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
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
				[Cpp2IlInjected.Address(RVA = "0x6914B30", Offset = "0x6913D30", VA = "0x186914B30")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6914B20", Offset = "0x6913D20", VA = "0x186914B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x69146B0", Offset = "0x69138B0", VA = "0x1869146B0")]
		public void MAALOMOBCFK(Vector3 NEPAJBPGFBJ, Quaternion HJOKGKGAMMH, float PHNNFIHLMAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69146E0", Offset = "0x69138E0", VA = "0x1869146E0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class OFHMOHECKOD
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 IDJENEILIJA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> LIPGODGABDO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> POKEIJIHOEP;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera CHCHOJAEEDI;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> HIKOAPNJLGJ;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> ENILEKGDNBB;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode LBCJJMFDEKM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color HIJEEJBNINA;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color HLOGDCCHCDF;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color PIMDJBCOKHI;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap IDKBCLFBOFN;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool EFELNGHMLAC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> KBAIKHJPALG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69167A0", Offset = "0x69159A0", VA = "0x1869167A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> PHOIGFCPEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6917E10", Offset = "0x6917010", VA = "0x186917E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera LOBNLKGCLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6917920", Offset = "0x6916B20", VA = "0x186917920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6917B70", Offset = "0x6916D70", VA = "0x186917B70")]
	public static void MPKGPELMAFI(Vector3 CJFHJHPMOOL, Quaternion ENGOJMNMCKD, ImposterRenderConfig DCBGILCCPFH, bool GCMCLBCMJEB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6916380", Offset = "0x6915580", VA = "0x186916380")]
	private static void DBKGGGEGLMO(Vector3 CJFHJHPMOOL, Quaternion ENGOJMNMCKD, URPLight IDHIHINLIAM, ImposterRenderConfig.LightConfig GPNACIMONOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6917840", Offset = "0x6916A40", VA = "0x186917840")]
	public static void JIKIFNBAGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6916C00", Offset = "0x6915E00", VA = "0x186916C00")]
	private static void HCAIINAJHHM(int HOGPCLHDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6917030", Offset = "0x6916230", VA = "0x186917030")]
	public static void HCGIOGALCGI(ImposterRenderConfig DCBGILCCPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69166B0", Offset = "0x69158B0", VA = "0x1869166B0")]
	public static void ECLAOBAMFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69168C0", Offset = "0x6915AC0", VA = "0x1869168C0")]
	public static void GEBMMJLHPNE(GameObject ABOBFGIKPEE, RenderTexture LHBPPPBOGCG, ImposterRenderConfig DCBGILCCPFH, DKBNIECPPOH LONAIJJDHNG, [Optional] Vector3? EBIOECFLNIB, [Optional] Vector3? DGGLPGMIGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69171F0", Offset = "0x69163F0", VA = "0x1869171F0")]
	private static void JFKKBJJDGHE(GameObject ABOBFGIKPEE, RenderTexture LHBPPPBOGCG, ImposterRenderConfig DCBGILCCPFH, DKBNIECPPOH LONAIJJDHNG, Vector3 EBIOECFLNIB, Vector3 DGGLPGMIGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6916090", Offset = "0x6915290", VA = "0x186916090")]
	private static void ALPGLCPAODI(GameObject ABOBFGIKPEE, Vector3 OCDEKNFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6915A20", Offset = "0x6914C20", VA = "0x186915A20")]
	private static void AFOLCNBDNEH(GameObject OGCFILPLNFJ, ImposterRenderConfig DCBGILCCPFH, DKBNIECPPOH LONAIJJDHNG, [Out] Vector3 DPKEOGLOINP, [Out] Quaternion CLDPBHHHGMN, [Out] float HHNMBGADJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69167F0", Offset = "0x69159F0", VA = "0x1869167F0")]
	public static RenderTexture EMEFKGCCBLH(int FNKAMPFNBJB, int IJAJOPPBLCP, RenderTextureFormat BGOCEECJDJL = RenderTextureFormat.ARGB32, string AIDGLECBAHJ = "[ImposterRendering]Preview")
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
		public struct FPPCOHNBCOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CNPNGJHMILJ HBIKLDFHJPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject FKAIKAALJHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture CAELAKPOIKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig NAKALJBEMIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public DKBNIECPPOH DKBNIECPPOH;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6912E40", Offset = "0x6912040", VA = "0x186912E40")]
			public FPPCOHNBCOA(CNPNGJHMILJ KEGEDGBLGGL, GameObject MJCPOBGFMHM, RenderTexture LHBPPPBOGCG, ImposterRenderConfig IFAHGLHGPLP, DKBNIECPPOH LONAIJJDHNG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static LLNBPHOHMNO<FPPCOHNBCOA, RenderTexture> MOLDEJGFINM;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<FPPCOHNBCOA> AHBCKHEGDLN;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int IBPIPHCLDNE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x69118C0", Offset = "0x6910AC0", VA = "0x1869118C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6911BC0", Offset = "0x6910DC0", VA = "0x186911BC0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject ABOBFGIKPEE, RenderTexture LHBPPPBOGCG, ImposterRenderConfig DCBGILCCPFH, DKBNIECPPOH LONAIJJDHNG, CancellationToken MPLGBOFHPLM, bool NIDGNKHECHL = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69116D0", Offset = "0x69108D0", VA = "0x1869116D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6911B20", Offset = "0x6910D20", VA = "0x186911B20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6911930", Offset = "0x6910B30", VA = "0x186911930")]
		private static Task<RenderTexture> OPCPKFLHDBE(FPPCOHNBCOA GELJBOGFANH, CancellationToken MPLGBOFHPLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6911FE0", Offset = "0x69111E0", VA = "0x186911FE0")]
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
